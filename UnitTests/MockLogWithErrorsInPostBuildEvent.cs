using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    class MockLogWithErrorsInPostBuildEvent : MockFilesProvider
    {
        protected override string GetLogText()
        {
            return "     2>C:\\Program Files (x86)\\MSBuild\\14.0\\bin\\Microsoft.Common.CurrentVersion.targets(4713,5): error MSB3073: The command \"call \"*Undefined*..\\tools\\vsvars32.bat\"\\r [d:\\Industrios\\Dotnet\\ENV\\ENV.csproj]\r\n" +
                   "C:\\Program Files (x86)\\MSBuild\\14.0\\bin\\Microsoft.Common.CurrentVersion.targets(4713,5): error MSB3073: editbin.exe /NXCOMPAT:NO \"d:\\Industrios\\Dotnet\\bin\\ENV.dll\"\\r [d:\\Industrios\\Dotnet\\ENV\\ENV.csproj]\r\n" +
                   "C:\\Program Files (x86)\\MSBuild\\14.0\\bin\\Microsoft.Common.CurrentVersion.targets(4713,5): error MSB3073: \" exited with code 9009. [d:\\Industrios\\Dotnet\\ENV\\ENV.csproj]\r\n";
        }

        protected override string GetCodeFileText(string fileName)
        {
            return "";
        }

        protected override string GetExpectedResultText()
        {
            return "Error in post build event:\r\n" +
                   "The command \"call \"*Undefined*..\\tools\\vsvars32.bat\"\\r [d:\\Industrios\\Dotnet\\ENV\\ENV.csproj]\r\n\r\n" +
                   "Error in post build event:\r\n" +
                   "editbin.exe /NXCOMPAT:NO \"d:\\Industrios\\Dotnet\\bin\\ENV.dll\"\\r [d:\\Industrios\\Dotnet\\ENV\\ENV.csproj]\r\n\r\n" +
                   "Error in post build event:\r\n" +
                   "\" exited with code 9009. [d:\\Industrios\\Dotnet\\ENV\\ENV.csproj]\r\n\r\n" +
                   "========================\r\n" +
                   "Total errors: 3\r\n" +
                   "========================\r\n\r\n" +
                   "Projects:\r\n" +
                   "d:\\Industrios\\Dotnet\\ENV\\ENV.csproj\r\n"; ;
        }
    }
}
