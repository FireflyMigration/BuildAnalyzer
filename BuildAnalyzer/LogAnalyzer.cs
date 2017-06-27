using System.Collections.Generic;
using System.IO;

namespace BuildAnalyzer
{
    class LogAnalyzer
    {
        readonly TextReader _logReader;
        readonly TextWriter _resultWriter;
        readonly HashSet<string> _projects = new HashSet<string>();

        public LogAnalyzer(TextReader logReader, TextWriter resultWriter)
        {
            _logReader = logReader;
            _resultWriter = resultWriter;
        }

        internal int Analyze()
        {
            int errorCount = 0;
            using (_resultWriter)
            {
                using (_logReader)
                {
                    string logLine;
                    while ((logLine = _logReader.ReadLine()) != null)
                    {
                        if (logLine.Contains(": error"))
                        {
                            _projects.Add(ExtractProject(logLine));
                            WriteCodeLine(logLine);
                            errorCount++;
                        }

                        if (logLine.Contains("Build FAILED."))
                            break;
                    }

                    if (errorCount > 0)
                    {
                        WriteFooter(errorCount);
                    }
                }
            }

            return errorCount;
        }

        static string ExtractProject(string logLine)
        {
            string projectFile = logLine.Substring(logLine.LastIndexOf('[') + 1);
            projectFile = projectFile.Remove(projectFile.Length - 1);
            return projectFile;
        }

        

        void WriteCodeLine(string logLine)
        {
            string codeFileName = logLine.Remove(logLine.IndexOf('(')).Trim();
            codeFileName = codeFileName.Substring(codeFileName.IndexOf('>') + 1);
            string fullFileName = Path.GetFullPath(Path.Combine(ExtractProjectFolder(logLine), codeFileName));

            var lineAndColumn = logLine.Substring(logLine.IndexOf('(') + 1);
            lineAndColumn = lineAndColumn.Remove(lineAndColumn.IndexOf(')'));
            var parts = lineAndColumn.Split(',');
            int line = int.Parse(parts[0]);
            int column = int.Parse(parts[1]);

            WriteCodeLine(fullFileName, line, column, ExtractError(logLine));
            _resultWriter.WriteLine();
        }

        static string ExtractProjectFolder(string logLine)
        {
            int lastOpenBracket = logLine.LastIndexOf('[');
            if (lastOpenBracket > 0)
            {
                logLine = logLine.Substring(lastOpenBracket + 1);
                logLine = logLine.Remove(logLine.IndexOf(']'));
                return Path.GetDirectoryName(logLine);
            }
            return "The project file could not be loaded";
        }

        static string ExtractError(string logLine)
        {
            int position = logLine.IndexOf(": error ");
            string errorMessage = logLine.Substring(position + 2);

            return errorMessage;
        }

        void WriteCodeLine(string codeFile, int errorLine, int errorColumn, string error)
        {
            try
            {
                using (var codeReader = new StreamReader(codeFile))
                {
                    string lastProgram = "";
                    int currentLine = 0;
                    string codeLine;

                    while ((codeLine = codeReader.ReadLine()) != null)
                    {
                        var progPos = codeLine.IndexOf("(P#");
                        if (progPos > 0)
                        {
                            lastProgram = codeLine.Substring(progPos);
                            lastProgram = lastProgram.Remove(lastProgram.IndexOf(')') + 1);
                        }
                        currentLine++;
                        if (currentLine == errorLine)
                        {
                            codeLine = codeLine.Replace("\t", " ");
                            _resultWriter.WriteLine(errorLine + ": " + codeLine);
                            _resultWriter.WriteLine(new string('-', errorColumn - 1 + errorLine.ToString().Length + 2) + '^' +
                                                    "  " + error.Substring(error.IndexOf(':') + 2));
                            _resultWriter.WriteLine(codeFile + " " + lastProgram);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        void WriteFooter(int counter)
        {
            _resultWriter.WriteLine("========================");
            _resultWriter.WriteLine("Total errors: " + counter);
            _resultWriter.WriteLine("========================");
            _resultWriter.WriteLine("");
            _resultWriter.WriteLine("Projects:");

            foreach (var project in _projects)
            {
                _resultWriter.WriteLine(project);
            }
        }
    }
}
