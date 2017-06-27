using System.IO;

namespace BuildAnalyzer
{
    class FileSystemFilesProvider : IFilesProvider
    {
        readonly TextReader _logReader;
        readonly TextWriter _resultWriter;

        public FileSystemFilesProvider(TextReader logReader, TextWriter resultWriter)
        {
            _logReader = logReader;
            _resultWriter = resultWriter;
        }

        public TextReader GetLogReader()
        {
            return _logReader;
        }

        public TextWriter GetResultWriter()
        {
            return _resultWriter;
        }

        public TextReader GetCodeFileReader(string fileName)
        {
            return new StreamReader(fileName);
        }
    }
}