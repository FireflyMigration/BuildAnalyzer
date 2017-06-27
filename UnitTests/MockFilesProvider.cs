using System.IO;
using System.Text;
using BuildAnalyzer;
using Shouldly;

namespace UnitTests
{
    abstract class MockFilesProvider : IFilesProvider
    {
        readonly StringBuilder _actualResult = new StringBuilder();

        public TextReader GetLogReader()
        {
            return new StringReader(GetLogText());
        }

        protected abstract string GetLogText();

        public TextWriter GetResultWriter()
        {
            return new StringWriter(_actualResult);
        }

        public TextReader GetCodeFileReader(string fileName)
        {
            return new StringReader(GetCodeFileText(fileName));
        }

        protected abstract string GetCodeFileText(string fileName);

        public void AssertResult()
        {
            _actualResult.ToString().ShouldBe(GetExpectedResultText());
        }

        protected abstract string GetExpectedResultText();
    }
}
