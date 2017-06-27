using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
            errorDetails.File = ExtractCodeFile(logLine, errorDetails.Project);
            ExtractLineAndColumn(logLine, errorDetails);

            return errorDetails;
        }

        string ExtractError(string logLine)
        {
            int position = logLine.IndexOf(": error ");
            string errorMessage = logLine.Substring(position + 2);

            return errorMessage;
        }

        string ExtractProject(string logLine)
        {
            var lastOpenBracket = logLine.LastIndexOf('[');
            string projectFile = logLine.Substring(lastOpenBracket + 1);
            projectFile = projectFile.Remove(projectFile.Length - 1);
            return projectFile;
        }

        string ExtractCodeFile(string logLine, string projectFile)
        {
            string codeFileName = logLine.Remove(logLine.IndexOf('(')).Trim();
            codeFileName = codeFileName.Substring(codeFileName.IndexOf('>') + 1);
            string projectFolder = Path.GetDirectoryName(projectFile);
            string fullFileName = Path.GetFullPath(Path.Combine(projectFolder, codeFileName));

            return fullFileName;
        }

        void ExtractLineAndColumn(string logLine, ErrorDetails errorDetails)
        {
            var lineAndColumn = logLine.Substring(logLine.IndexOf('(') + 1);
            lineAndColumn = lineAndColumn.Remove(lineAndColumn.IndexOf(')'));
            var parts = lineAndColumn.Split(',');
            errorDetails.Line = Int32.Parse(parts[0]);
            errorDetails.Column = Int32.Parse(parts[1]);
        }
    }
}
