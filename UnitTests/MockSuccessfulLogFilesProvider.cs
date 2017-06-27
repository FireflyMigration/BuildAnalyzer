using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    class MockSuccessfulLogFilesProvider : MockFilesProvider
    {
        protected override string GetLogText()
        {
            return "Build started 27/06/2017 10:46:35.\r\n" +
                   "     1>Project \"C:\\Users\\Sefi\\Documents\\visual studio 2017\\Projects\\Demo\\Demo\\Demo.csproj\" on node 1 (default targets).\r\n" +
                   "     1>GenerateBindingRedirects:\r\n" +
                   "         No suggested binding redirects from ResolveAssemblyReferences.\r\n" +
                   "       GenerateTargetFrameworkMonikerAttribute:\r\n" +
                   "       Skipping target \"GenerateTargetFrameworkMonikerAttribute\" because all output files are up-to-date with respect to the input files.\r\n" +
                   "       CoreCompile:\r\n" +
                   "         C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\Roslyn\\csc.exe /noconfig /nowarn:1701,1702 /nostdlib+ /platform:anycpu32bitpreferred /errorreport:prompt /warn:4 /define:DEBUG;TRACE /highentropyva+ /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\Microsoft.CSharp.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\mscorlib.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Core.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Data.DataSetExtensions.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Data.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Net.Http.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Xml.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Xml.Linq.dll\" /debug+ /debug:full /filealign:512 /optimize- /out:obj\\Debug\\Demo.exe /subsystemversion:6.00 /target:exe /utf8output Program.cs Properties\\AssemblyInfo.cs \"C:\\Users\\Sefi\\AppData\\Local\\Temp\\.NETFramework,Version=v4.5.2.AssemblyAttributes.cs\"\r\n" +
                   "         Using shared compilation with compiler from directory: C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\Roslyn\r\n" +
                   "       _CopyAppConfigFile:\r\n" +
                   "         Copying file from \"App.config\" to \"bin\\Debug\\Demo.exe.config\".\r\n" +
                   "       CopyFilesToOutputDirectory:\r\n" +
                   "         Copying file from \"obj\\Debug\\Demo.exe\" to \"bin\\Debug\\Demo.exe\".\r\n" +
                   "         Demo -> C:\\Users\\Sefi\\Documents\\visual studio 2017\\Projects\\Demo\\Demo\\bin\\Debug\\Demo.exe\r\n" +
                   "         Copying file from \"obj\\Debug\\Demo.pdb\" to \"bin\\Debug\\Demo.pdb\".\r\n" +
                   "     1>Done Building Project \"C:\\Users\\Sefi\\Documents\\visual studio 2017\\Projects\\Demo\\Demo\\Demo.csproj\" (default targets).\r\n" +
                   "\r\n" +
                   "Build succeeded.\r\n" +
                   "    0 Warning(s)\r\n" +
                   "    0 Error(s)\r\n" +
                   "\r\n" +
                   "Time Elapsed 00:00:00.33\r\n" +
                   "\r\n";
        }

        protected override string GetCodeFileText(string fileName)
        {
            throw new Exception("Should not ask for code file as there are not errors");
        }

        protected override string GetExpectedResultText()
        {
            return String.Empty;
        }
    }
}
