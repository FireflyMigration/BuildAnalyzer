using System;
using System.IO;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestExpectedOutput()
        {
            BuildAnalyzer.Program.Main(new[] {@"..\..\..\BuildDebug.log"});

            const string expectedFile = @"..\..\..\Expected.txt";
            const string actualFile = @"..\..\..\BuildDebug.log.errors.txt";

            var expectedHash = GetFileHash(expectedFile);
            var actualHash = GetFileHash(actualFile);

            Assert.AreEqual(expectedHash, actualHash);

        }

        public string GetFileHash(string filename)
        {
            var hash = new SHA1Managed();
            var clearBytes = File.ReadAllBytes(filename);
            var hashedBytes = hash.ComputeHash(clearBytes);
            return ConvertBytesToHex(hashedBytes);
        }

        public string ConvertBytesToHex(byte[] bytes)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x"));
            }
            return sb.ToString();
        }
    }
}
