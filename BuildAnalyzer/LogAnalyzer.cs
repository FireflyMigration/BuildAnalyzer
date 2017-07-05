using System.Collections.Generic;
using System.IO;

namespace BuildAnalyzer
{
    class LogAnalyzer
    {
        readonly IFilesProvider _filesProvider;
        readonly TextWriter _resultWriter;
        readonly HashSet<string> _projects = new HashSet<string>();

        public LogAnalyzer(IFilesProvider filesProvider)
        {
            _filesProvider = filesProvider;
            _resultWriter = _filesProvider.GetResultWriter();
        }

        internal int Analyze()
        {
            int errorCount = 0;
            var errorParser = new ErrorParser();

            using (_resultWriter)
            {
                using (var logReader = _filesProvider.GetLogReader())
                {
                    string logLine;
                    while ((logLine = logReader.ReadLine()) != null)
                    {
                        if (logLine.Contains(": error"))
                        {
                            var errorDetails = errorParser.ParseError(logLine);
                            WriteDetailedError(errorDetails);

                            if (!string.IsNullOrEmpty(errorDetails.Project))
                            {
                                _projects.Add(errorDetails.Project);
                            }

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


        void WriteDetailedError(ErrorDetails errorDetails)
        {
            try
            {
                using (var codeReader = _filesProvider.GetCodeFileReader(errorDetails.File))
                {
                    string lastProgram = "";
                    int line = 0;
                    string codeLine;

                    if (errorDetails.File.EndsWith("msbuild.xml"))
                        _resultWriter.WriteLine("Migration Engine Error! Please run the migration again.\r\n");

                    if (errorDetails.File.EndsWith(".targets"))
                    {
                        _resultWriter.WriteLine("Error in post build event:");
                        _resultWriter.WriteLine(errorDetails.Description);
                        _resultWriter.WriteLine();
                        return;
                    }

                    while ((codeLine = codeReader.ReadLine()) != null)
                    {
                        var progPos = codeLine.IndexOf("(P#");
                        if (progPos > 0)
                        {
                            lastProgram = codeLine.Substring(progPos);
                            lastProgram = lastProgram.Remove(lastProgram.IndexOf(')') + 1);
                        }

                        line++;

                        if (line == errorDetails.Line)
                        {
                            _resultWriter.WriteLine(line + ": " + codeLine.Replace("\t", " "));
                            _resultWriter.WriteLine(new string('-', errorDetails.Column + line.ToString().Length + 1) +
                                                    '^' + "  " + errorDetails.Description);
                            _resultWriter.WriteLine(errorDetails.File + " " + lastProgram);
                            break;
                        }
                    }
                    _resultWriter.WriteLine();
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

            if (_projects.Count > 0)
            {
                _resultWriter.WriteLine("Projects:");

                foreach (var project in _projects)
                {
                    _resultWriter.WriteLine(project);
                }
            }
        }
    }
}
