using System.IO;

namespace BuildAnalyzer
{
    class FileSystemFilesProvider : IFilesProvider
    {
        readonly string _logFile;
        readonly string _resultFile;

        public FileSystemFilesProvider(string logFile, string resultFile)
        {
            _logFile = logFile;
            _resultFile = resultFile;
        }

        public TextReader GetLogReader()
        {
            return new StreamReader(_logFile);
        }

        public TextWriter GetResultWriter()
        {
            return new StreamWriter(_resultFile);
        }

        public TextReader GetCodeFileReader(string fileName)
        {
            return new StreamReader(fileName);
        }
    }
}