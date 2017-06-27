using System.IO;

namespace BuildAnalyzer
{
    interface IFilesProvider
    {
        TextReader GetLogReader();
        TextWriter GetResultWriter();
        TextReader GetCodeFileReader(string fileName);
    }
}
