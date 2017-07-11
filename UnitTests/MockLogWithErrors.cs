using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    class MockLogWithErrors : MockFilesProvider
    {
        protected override string GetLogText()
        {
            return "     9>EXTUFB002NotifySnippet.cs(2,7): error CS0246: The type or namespace name 'oneXCOutlookIntegrator' could not be found (are you missing a using directive or an assembly reference?) [D:\\targo\\dotnet\\ExternalTools\\ExternalTools.csproj]\r\n" +
                "     9>EXTUFB001MakePhoneCallSnippet.cs(2,7): error CS0246: The type or namespace name 'oneXCOutlookIntegrator' could not be found (are you missing a using directive or an assembly reference?) [D:\\targo\\dotnet\\ExternalTools\\ExternalTools.csproj]\r\n" +
                "Build FAILED.\r\n" +
                "    21 Warning(s)\r\n" +
                "    2 Error(s)\r\n" +
                "Time Elapsed 00:00:01.87\r\n";

        }

        protected override string GetCodeFileText(string fileName)
        {
            return "";
        }

        protected override string GetExpectedResultText()
        {
            return "\r\n\r\n========================\r\n" +
                   "Total errors: 2\r\n" +
                   "========================\r\n\r\n" +
                   "Projects:\r\n" +
                   "D:\\targo\\dotnet\\ExternalTools\\ExternalTools.csproj\r\n";
        }
    }
}
