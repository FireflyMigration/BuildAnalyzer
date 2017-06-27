using System;
using System.Configuration;
using System.IO;

namespace BuildAnalyzer
{
    class Program
    {
        public static int Main(string[] args)
        {
            var logFile = args.Length == 0 ? "buildDebug.log" : args[0];
            var logReader = new StreamReader(logFile);
            var resultWriter = new StreamWriter(logFile + ".errors.txt");

            try
            {
                var logAnalyzer = new LogAnalyzer(new FileSystemFilesProvider(logReader, resultWriter));
                var errorCount = logAnalyzer.Analyze();

                if (File.Exists(logFile + ".NoErrors.txt"))
                    File.Delete(logFile + ".NoErrors.txt");

                if (errorCount == 0)
                {
                    File.Move(logFile + ".errors.txt", logFile + ".NoErrors.txt");
                    return 0;
                }

                return 1;
            }
            catch (Exception e)
            {
                resultWriter.WriteLine("Build Analyzer Error:");
                resultWriter.WriteLine(e.Message);
                resultWriter.WriteLine(e.StackTrace);

                if (File.Exists(logFile + ".NoErrors.txt"))
                    File.Delete(logFile + ".NoErrors.txt");

                return 0;
            }
        }
    }
}