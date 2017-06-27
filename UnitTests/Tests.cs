using BuildAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Tests
    {      
        [TestMethod]
        public void TestLogWithWarningsAndErrors()
        {
            var mockFilesProvider = new MockLogWithWarningsAndErrorsFilesProvider();
            var analyzer = new LogAnalyzer(mockFilesProvider);
            analyzer.Analyze();
            mockFilesProvider.AssertResult();
        }

        [TestMethod]
        public void TestLogWithErrorsOnly2()
        {
            var mockFilesProvider = new MockLogWithErrorsOnlyFilesProvider();
            var analyzer = new LogAnalyzer(mockFilesProvider);
            analyzer.Analyze();
            mockFilesProvider.AssertResult();
        }
    }
}
