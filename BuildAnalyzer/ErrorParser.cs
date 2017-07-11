using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BuildAnalyzer
{
    class ErrorParser
    {
        internal ErrorDetails ParseError(string logLine)
        {
            var errorDetails = new ErrorDetails
            {
                Description = ExtractError(logLine),
                Project = ExtractProject(logLine),
            };
            errorDetails.File = ExtractFile(logLine, errorDetails.Project);
            ExtractLineAndColumn(logLine, errorDetails);

            return errorDetails;
        }

        string ExtractError(string logLine)
        {
            int position = logLine.IndexOf(": error ");
            string errorMessage = logLine.Substring(position + 2);
            errorMessage = errorMessage.Substring(errorMessage.IndexOf(':') + 2);

            return errorMessage;
        }

        string ExtractProject(string logLine)
        {
            var lastOpenBracket = logLine.LastIndexOf('[');
            if (lastOpenBracket == -1)
                return null;
            string projectFile = logLine.Substring(lastOpenBracket + 1);
            projectFile = projectFile.Remove(projectFile.Length - 1);
            return projectFile;
        }

        string ExtractFile(string logLine, string projectFile)
        {
            if (logLine.Contains("msbuild.xml"))
                return Path.GetFullPath("msbuild.xml");

            if (projectFile == null)
                return String.Empty;

            var regex = new Regex(@"(>|C:\\).+?((\b\.cs\b)|(\b\.targets\b))");
            var match = regex.Match(logLine);
            if (match.Success)
            {
                string codeFileName = match.Value.Replace(">","");
                string projectFolder = Path.GetDirectoryName(projectFile);

                if (projectFolder == null)
                    return String.Empty;
                string fullFileName = Path.GetFullPath(Path.Combine(projectFolder, codeFileName));

                return fullFileName;
            }

            return string.Empty;
        }

        void ExtractLineAndColumn(string logLine, ErrorDetails errorDetails)
        {
            var regx = new Regex(@"\([0-9]+,[0-9]+\)");
            var match = regx.Match(logLine);

            if (match.Success)
            {
                var lineAndColumn = match.Value.Substring(1);
                lineAndColumn = lineAndColumn.Remove(lineAndColumn.Length - 1);
                var parts = lineAndColumn.Split(',');
                errorDetails.Line = Int32.Parse(parts[0]);
                errorDetails.Column = Int32.Parse(parts[1]);
            }
        }
    }
}
