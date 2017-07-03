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
            Test(new MockLogWithWarningsAndErrorsFilesProvider());
        }

        static void Test(MockFilesProvider mockFilesProvider)
        {
            var analyzer = new LogAnalyzer(mockFilesProvider);
            analyzer.Analyze();
            mockFilesProvider.AssertResult();
        }

        [TestMethod]
        public void TestLogWithErrorsOnly()
        {
            Test(new MockLogWithErrorsOnlyFilesProvider());
        }

        [TestMethod]
        public void TestSuccessfulLog()
        {
            Test(new MockSuccessfulLogFilesProvider());
        }

        [TestMethod]
        public void TestLogWithErrorInMsbuildXml()
        {
            Test(new MockLogWithErrorInMsbuildXml());
        }

       
    }
}
