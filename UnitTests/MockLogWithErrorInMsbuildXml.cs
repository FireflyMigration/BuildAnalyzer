using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    class MockLogWithErrorInMsbuildXml : MockFilesProvider
    {
        protected override string GetLogText()
        {
            return "     1>d:\\Etobres\\CustomerMigration\\Dotnet\\msbuild.xml(3,19): error MSB4025: The project file could not be loaded. '<', hexadecimal value 0x3C, is an invalid attribute character. Line 3, position 19.\r\n";
        }

        protected override string GetCodeFileText(string fileName)
        {
            return "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n" +
                   "<Project DefaultTargets=\"Step0\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\" ToolsVersion=\"3.5\">\r\n" +
                   "    <Target Name=\"<!$SB_TARGET>\" DependsOnTargets=\"<!$SB_DEPENDS>\">\r\n" +
                   "    <MSBuild Projects=\"<!$SB_PROJ>\"  BuildInParallel=\"true\"  StopOnFirstFailure=\"true\"/>\r\n" +
                   "    </Target>\r\n" +
                   "  </Project>\r\n";
        }

        protected override string GetExpectedResultText()
        {
            return "Migration Engine Error! Please run the migration again.\r\n\r\n" +
                   "3:     <Target Name=\"<!$SB_TARGET>\" DependsOnTargets=\"<!$SB_DEPENDS>\">\r\n" +
                   "---------------------^  The project file could not be loaded. '<', hexadecimal value 0x3C, is an invalid attribute character. Line 3, position 19.\r\n" +
                   "C:\\Repos\\BuildAnalyzer\\UnitTests\\bin\\Debug\\msbuild.xml \r\n\r\n" +
                   "========================\r\n" +
                   "Total errors: 1\r\n" +
                   "========================\r\n\r\n";

        }
    }
}
