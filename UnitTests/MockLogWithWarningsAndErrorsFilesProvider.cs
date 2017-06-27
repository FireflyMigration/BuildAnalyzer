using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildAnalyzer;
using Shouldly;

namespace UnitTests
{
    class MockLogWithWarningsAndErrorsFilesProvider : IFilesProvider
    {
        readonly StringBuilder _actualResult = new StringBuilder();

        public TextReader GetLogReader()
        {
            return new StringReader(Log);
        }

        public TextWriter GetResultWriter()
        {
            return new StringWriter(_actualResult);
        }

        public TextReader GetCodeFileReader(string fileName)
        {
            return new StringReader(CodeWithError);
        }

        public void AssertResult()
        {
            _actualResult.ToString().ShouldBe(ExpectedResult);
        }

        const string Log =
            "Build started 26/06/2017 23:23:21.\r\n" +
"     1>Project \"C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj\" on node 1 (default targets).\r\n" +
"     1>C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\Microsoft.Common.CurrentVersion.targets(1755,5): warning : The referenced project 'C:\\Dotnet2\\WizardOfOz\\BackwardCompatabilityFunctions\\BackwardCompatabilityFunctions.csproj' does not exist. [C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj]\r\n" +
"     1>C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\Microsoft.Common.CurrentVersion.targets(1755,5): warning : The referenced project 'C:\\Dotnet2\\WizardOfOz\\Witch\\Firefly.Box.csproj' does not exist. [C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj]\r\n" +
"     1>CoreResGen:\r\n" +
"         No resources are out of date with respect to their source files. Skipping resource generation.\r\n" +
"       GenerateTargetFrameworkMonikerAttribute:\r\n" +
"       Skipping target \"GenerateTargetFrameworkMonikerAttribute\" because all output files are up-to-date with respect to the input files.\r\n" +
"       CoreCompile:\r\n" +
"         C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\Roslyn\\csc.exe /noconfig /nowarn:1587,1570,1591,1701,1702 /nostdlib+ /platform:anycpu32bitpreferred /errorreport:prompt /warn:4 /define:DEBUG;TRACE /highentropyva+ /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\mscorlib.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Core.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Data.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Design.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Drawing.Design.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Drawing.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Web.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Windows.Forms.dll\" /reference:\"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.5.2\\System.Xml.dll\" /debug+ /debug:full /optimize- /out:obj\\Debug\\NorthwindTest.exe /subsystemversion:5.00 /resource:obj\\Debug\\NorthwindTest.Properties.Resources.resources /resource:obj\\Debug\\NorthwindTest.Views.ApplicationMdi.resources /target:winexe /utf8output Properties\\Resources.Designer.cs Views\\ContextMenuMap.cs Printing\\Print_OrderC1.cs Shared\\Theme\\Printing\\RichTextBox.cs Shared\\Theme\\IO\\Html\\HtmlTableCell.cs Shared\\Theme\\ColorSchemes.cs Shared\\Theme\\Fonts\\Header3Bold.cs Shared\\Theme\\Fonts\\Reserved36.cs Shared\\Theme\\Controls\\PictureBox.cs Shared\\Theme\\Fonts\\DialogText.cs Shared\\DataSources.cs Shared\\Theme\\Fonts\\PushButtonDefaultFont.cs Printing\\Print_OrderC1.Designer.cs Print_Order.cs Shared\\Theme\\Controls\\PictureBox.Designer.cs Shared\\Theme\\Fonts\\Reserved16.cs Views\\DefaultPulldownMenu.cs Views\\DefaultPulldownMenu.Designer.cs Shared\\Printing\\Printers.cs Shared\\Theme\\Fonts\\Header6BoldItalic.cs Shared\\Theme\\Colors\\Window_sDefault.cs Shared\\Theme\\Printing\\RichTextBox.Designer.cs Shared\\Theme\\Fonts\\Header4Bold.cs Shared\\Theme\\Controls\\Form.cs Shared\\Theme\\Controls\\Form.Designer.cs Shared\\Theme\\Printing\\GroupBox.cs Shared\\Theme\\Printing\\GroupBox.Designer.cs Shared\\Theme\\Fonts\\Reserved17.cs Shared\\Theme\\Fonts\\PushButtonText.cs Shared\\Theme\\Controls\\CheckBox.cs Shared\\Theme\\Controls\\CheckBox.Designer.cs Types\\CustomerID.cs Printing\\Print_OrdersC1.cs Printing\\Print_OrdersC1.Designer.cs Print_Orders.cs Shared\\Theme\\Colors\\Control_sDefault.cs Shared\\Theme\\Controls\\RichTextBox.cs Shared\\Theme\\Controls\\RichTextBox.Designer.cs Shared\\Theme\\Fonts\\Reserved23.cs Shared\\Theme\\Printing\\Shape.cs Shared\\Theme\\Printing\\Shape.Designer.cs Shared\\Theme\\Fonts\\RadioButtonDefaultFont.cs Types\\OrderID.cs Shared\\Theme\\Fonts\\Header5Bold.cs Shared\\Theme\\Fonts\\Reserved37.cs Shared\\Theme\\Fonts\\Reserved18.cs Shared\\Theme\\Controls\\CompatibleForm.cs Shared\\Theme\\Controls\\CompatibleForm.Designer.cs Shared\\Theme\\Fonts\\Reserved.cs Shared\\Theme\\Controls\\ScrollBar.cs Shared\\Theme\\Controls\\ScrollBar.Designer.cs Shared\\Theme\\Fonts\\Header6Bold.cs Shared\\Theme\\Controls\\Button.cs Shared\\Theme\\Controls\\Button.Designer.cs Shared\\Theme\\Fonts\\Reserved19.cs Shared\\Theme\\Fonts\\Reserved1.cs Views\\changeFormColorView.cs Shared\\Theme\\Fonts\\StatusLineText.cs Types\\ProdID.cs Shared\\Theme\\Printing\\ReportSection.cs Shared\\Theme\\Printing\\ReportSection.Designer.cs Shared\\Theme\\Fonts\\HTML_DefaultItalic.cs Views\\changeFormColorView.Designer.cs Types\\Amount.cs Shared\\Theme\\Colors\\missing39ColorInTheClrFile.cs Shared\\Theme\\Fonts\\Reserved2.cs Shared\\Theme\\Fonts\\ConfirmMessagesFont.cs Shared\\Theme\\Fonts\\Reserved20.cs changeFormColor.cs Shared\\Theme\\Colors\\missing40ColorInTheClrFile.cs Shared\\Theme\\Fonts\\Reserved38.cs Types\\Date1.cs Shared\\Theme\\Fonts\\Reserved24.cs Shared\\Theme\\Fonts\\Header1Italic.cs Shared\\Theme\\Fonts\\ToolkitWindowsFont.cs Shared\\Theme\\Fonts\\Reserved3.cs Shared\\Theme\\Printing\\ReportLayout.cs Shared\\Theme\\Printing\\ReportLayout.Designer.cs Shared\\Theme\\Colors\\Red.cs Shared\\Theme\\Fonts\\Reserved21.cs Shared\\Theme\\Controls\\RadioButton.cs Shared\\Theme\\Controls\\RadioButton.Designer.cs Shared\\Theme\\Colors\\Blue.cs Shared\\Theme\\Fonts\\Reserved39.cs Shared\\Theme\\Fonts\\Header2Italic.cs Shared\\Theme\\Fonts\\SmallFont.cs Views\\Controls\\OK.cs Views\\Controls\\OK.Designer.cs Shared\\Theme\\Colors\\missing41ColorInTheClrFile.cs Shared\\Theme\\Fonts\\Reserved40.cs Views\\TestSubFormCallFor357View.cs Shared\\Theme\\Controls\\ListBox.cs Shared\\Theme\\Controls\\ListBox.Designer.cs Shared\\Theme\\Fonts\\Header3Italic.cs Shared\\Theme\\Fonts\\Reserved41.cs Shared\\Theme\\Controls\\GroupBox.cs Shared\\Theme\\Controls\\GroupBox.Designer.cs Shared\\Theme\\Fonts\\Reserved4.cs Shared\\Theme\\Fonts\\Reserved22.cs Views\\TestSubFormCallFor357View.Designer.cs Shared\\Theme\\Fonts\\Header4Italic.cs Shared\\Theme\\Fonts\\Reserved42.cs Views\\TestSubFormCallFor357Details.cs Shared\\Theme\\Fonts\\Reserved5.cs Views\\TestSubFormCallFor357Details.Designer.cs TestSubFormCallFor357.cs Shared\\Theme\\Controls\\Shape.cs Views\\Controls\\Close1.cs Views\\Controls\\Close1.Designer.cs Shared\\Theme\\Fonts\\SampleFontRotation45Deg.cs Shared\\Theme\\Colors\\missing39ColorInTheClrFile1.cs Shared\\Theme\\Controls\\TabControl.cs Shared\\Theme\\Controls\\TabControl.Designer.cs Shared\\Theme\\Fonts\\HTML_Default.cs Shared\\Theme\\Fonts\\SampleFontRotation90Deg.cs Shared\\Theme\\Fonts\\Reserved6.cs Shared\\Theme\\Colors\\missing40ColorInTheClrFile1.cs Shared\\Theme\\Fonts\\Header5Italic.cs Shared\\Theme\\Fonts\\Header1.cs Shared\\Theme\\Fonts\\Reserved25.cs Shared\\Theme\\Fonts\\Reserved7.cs Shared\\Theme\\Controls\\Line.cs Shared\\Theme\\Controls\\Line.Designer.cs Shared\\Theme\\TextIO\\TextSection.cs Shared\\Theme\\TextIO\\TextSection.Designer.cs Shared\\Theme\\Controls\\ComboBox.cs Shared\\Theme\\Controls\\ComboBox.Designer.cs Models\\Customers.cs Shared\\Theme\\Controls\\Shape.Designer.cs Shared\\Theme\\Fonts\\Header2.cs Shared\\Theme\\Fonts\\SampleFontRotation135Deg.cs Shared\\Theme\\Fonts\\Reserved8.cs Shared\\Theme\\Fonts\\LargeFont.cs Shared\\Theme\\Fonts\\SampleFontRotation180Deg.cs Shared\\Theme\\TextIO\\TextTemplate.cs Shared\\Theme\\TextIO\\Line.cs Shared\\Theme\\Colors\\missing41ColorInTheClrFile1.cs Shared\\Theme\\Printing\\Label.cs Views\\Controls\\V9CompatibleDefaultTable.cs Views\\Controls\\V9CompatibleDefaultTable.Designer.cs Shared\\Theme\\Fonts\\WizardLargeTitle.cs Shared\\Theme\\Colors\\missing6ColorInTheClrFile1.cs Shared\\Theme\\Fonts\\Header3.cs Shared\\Theme\\Fonts\\Header6Italic.cs Shared\\Theme\\Fonts\\FixedSizeFont.cs Shared\\Theme\\TextIO\\TextLayout.cs Shared\\Theme\\TextIO\\TextLayout.Designer.cs Shared\\Theme\\Fonts\\SampleFontRotation225Deg.cs Shared\\Theme\\Printing\\Label.Designer.cs Shared\\Theme\\Fonts\\Header4.cs Shared\\Theme\\Fonts\\WizardSmallTitle.cs Shared\\Theme\\Colors\\missing6ColorInTheClrFile.cs Shared\\Theme\\Fonts\\Header5.cs Shared\\Theme\\IO\\Html\\HtmlLine.cs Shared\\DebugHelper.cs Shared\\Theme\\TextPrintingStylesMap.cs Shared\\Theme\\Fonts\\WizardText.cs BusinessProcessBase.cs Shared\\Theme\\TextIO\\Shape.cs Models\\Orders.cs Shared\\Theme\\IO\\Html\\HtmlTextBox.cs Shared\\Theme\\Fonts\\Reserved26.cs Shared\\Theme\\Fonts\\InheritedProperty.cs Shared\\Theme\\Fonts\\DefaultDialogEditFields.cs Shared\\Theme\\IO\\Html\\HtmlSection.cs Shared\\Theme\\Controls\\Label.cs Shared\\Theme\\TextIO\\TextBox.cs Shared\\Theme\\Controls\\Label.Designer.cs Shared\\Theme\\Fonts\\HTML_DefaultBoldItalic.cs Shared\\Theme\\IO\\Html\\HtmlFrameSet.cs Shared\\Theme\\Printing\\Grid.cs Shared\\Theme\\Fonts\\Header6.cs Shared\\Theme\\Fonts\\Reserved27.cs Shared\\Theme\\Fonts\\Header1BoldItalic.cs Shared\\Theme\\Fonts\\DefaultTableTitle.cs FlowUIControllerBase.cs Shared\\Theme\\Printing\\Line.cs Shared\\Theme\\Fonts\\HTML_DefaultBold.cs Shared\\Theme\\Printing\\Line.Designer.cs Shared\\Theme\\Fonts\\SampleFontRotation270Deg.cs UIControllerBase.cs Shared\\Theme\\Fonts\\Header1Bold.cs Shared\\Theme\\Fonts\\BrokenProperty.cs Shared\\Theme\\Printing\\Grid.Designer.cs Shared\\Theme\\Fonts\\Reserved9.cs Shared\\Theme\\Printing\\TextBox.cs Shared\\Theme\\Printing\\TextBox.Designer.cs Shared\\Theme\\Fonts\\Header2Bold.cs Shared\\Theme\\Fonts\\AsDataProperty.cs Shared\\Theme\\Fonts\\Reserved28.cs Shared\\Theme\\IO\\Html\\HtmlGrid.cs Shared\\Theme\\Fonts\\Header2BoldItalic.cs Shared\\Theme\\Fonts\\TabText.cs Shared\\Theme\\Fonts\\DefaultTableEditField.cs Shared\\Theme\\Fonts\\SampleFontRotation315Deg.cs Shared\\Theme\\Fonts\\Header4BoldItalic.cs Shared\\Theme\\IO\\Html\\HtmlTable.cs Shared\\Theme\\Controls\\Grid.cs Shared\\Theme\\Fonts\\Tooltips.cs Shared\\Theme\\Fonts\\Reserved10.cs Shared\\Theme\\Controls\\ActiveX.cs Shared\\Theme\\Controls\\Grid.Designer.cs Shared\\Theme\\Fonts\\Header5BoldItalic.cs Shared\\Theme\\Fonts\\SampleFontRotation0Deg.cs Shared\\Theme\\Controls\\CompatibleLabel.cs Models\\OrderDetails.cs Shared\\Theme\\Fonts\\TableFields.cs Shared\\Theme\\Fonts\\UserDefinedFont.cs Shared\\Theme\\Fonts\\Reserved34.cs Views\\ShowCustomersView.cs Shared\\Theme\\Controls\\CompatibleGrid.cs Shared\\Theme\\Controls\\CompatibleGrid.Designer.cs Models\\Products.cs Shared\\Theme\\Fonts\\UserDefinedFont1.cs Shared\\Theme\\Fonts\\Reserved35.cs Shared\\Theme\\Fonts\\Header3BoldItalic.cs Shared\\Theme\\IO\\Html\\HtmlTableRow.cs Shared\\Theme\\Controls\\ActiveX.Designer.cs AsyncHelperBase.cs Shared\\Theme\\Fonts\\Reserved29.cs Models\\Categories.cs Shared\\Theme\\FontSchemes.cs Shared\\Theme\\Fonts\\DefaultFixedSizeFont.cs Shared\\Theme\\Fonts\\Reserved14.cs Views\\ShowProductsView.cs Shared\\Theme\\Printing\\GridColumn.cs Shared\\Theme\\Printing\\GridColumn.Designer.cs Views\\ShowProductsView.Designer.cs ShowProducts.cs Views\\DefaultContextMenu.cs Shared\\Theme\\Controls\\CompatibleTextBox.cs Views\\ShowCustomersView.Designer.cs Views\\DefaultContextMenu.Designer.cs ShowCustomers.cs Models\\Shippers.cs Shared\\Theme\\IO\\Html\\HtmlGridColumn.cs Shared\\Theme\\Controls\\CompatibleLabel.Designer.cs Shared\\Theme\\Fonts\\Reserved11.cs Models\\Suppliers.cs Shared\\Theme\\Fonts\\DefaultImportForm.cs Application.cs Shared\\Theme\\Controls\\CompatibleTextBox.Designer.cs Shared\\Theme\\Fonts\\Reserved12.cs Views\\ShowOrdersView.cs Shared\\Theme\\Controls\\SubForm.cs Shared\\Theme\\Controls\\SubForm.Designer.cs Views\\ShowOrdersView.Designer.cs Views\\ShowOrdersDetails.cs Views\\ShowOrdersDetails.Designer.cs Shared\\Theme\\Controls\\TextBox.cs Shared\\Theme\\Controls\\TextBox.Designer.cs ShowOrders.cs ApplicationPrograms.cs ApplicationEntities.cs Views\\ApplicationMdi.cs Shared\\Theme\\Fonts\\Reserved15.cs Shared\\Theme\\Controls\\TreeView.cs Shared\\Theme\\Controls\\TreeView.Designer.cs Shared\\Theme\\Fonts\\TableTitle.cs Shared\\Theme\\Fonts\\Reserved13.cs Shared\\Theme\\Fonts\\Reserved30.cs Shared\\Theme\\Fonts\\DialogFields.cs Shared\\Theme\\TextIO\\TextLabel.cs Shared\\Theme\\Fonts\\Reserved31.cs Views\\ApplicationMdi.Designer.cs Program.cs Shared\\Theme\\IO\\Html\\HtmlLabel.cs Shared\\Theme\\Fonts\\Reserved32.cs Shared\\Theme\\Fonts\\Reserved33.cs Shared\\Theme\\IO\\Html\\HtmlFrame.cs Shared\\Theme\\Controls\\CompatibleGridColumn.cs Shared\\Theme\\Controls\\CompatibleGridColumn.Designer.cs Shared\\Theme\\Controls\\GridColumn.cs Shared\\Theme\\Controls\\GridColumn.Designer.cs Shared\\Theme\\Printing\\PictureBox.cs Shared\\Theme\\Printing\\PictureBox.Designer.cs Shared\\Theme\\IO\\Html\\HtmlPictureBox.cs Shared\\Theme\\Fonts\\DefaultDialogText.cs Shared\\Theme\\Fonts\\DefaultTableNameTitle.cs Shared\\Theme\\Fonts\\DefaultHelp.cs Properties\\AssemblyInfo.cs \"C:\\Users\\Sefi\\AppData\\Local\\Temp\\.NETFramework,Version=v4.5.2.AssemblyAttributes.cs\"\r\n" +
"         Using shared compilation with compiler from directory: C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\Roslyn\r\n" +
"     1>TestSubFormCallFor357.cs(52,37): error CS1002: ; expected [C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj]\r\n" +
"     1>Done Building Project \"C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj\" (default targets) -- FAILED.\r\n" +
"\r\n" +
"Build FAILED.\r\n" +
"\r\n" +
"       \"C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj\" (default target) (1) ->\r\n" +
"       (ResolveProjectReferences target) -> \r\n" +
"         C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\Microsoft.Common.CurrentVersion.targets(1755,5): warning : The referenced project 'C:\\Dotnet2\\WizardOfOz\\BackwardCompatabilityFunctions\\BackwardCompatabilityFunctions.csproj' does not exist. [C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj]\r\n" +
"         C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\Microsoft.Common.CurrentVersion.targets(1755,5): warning : The referenced project 'C:\\Dotnet2\\WizardOfOz\\Witch\\Firefly.Box.csproj' does not exist. [C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj]\r\n" +
"\r\n" +
"\r\n" +
"       \"C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj\" (default target) (1) ->\r\n" +
"       (CoreCompile target) -> \r\n" +
"         TestSubFormCallFor357.cs(52,37): error CS1002: ; expected [C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj]\r\n" +
"\r\n" +
"    2 Warning(s)\r\n" +
"    1 Error(s)\r\n" +
"\r\n" +
"Time Elapsed 00:00:00.62\r\n" +
"\r\n";

        const string ExpectedResult =
            "52:                 InitializeDataView()\r\n" +
            "----------------------------------------^  ; expected [C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj]\r\n" +
            "C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\TestSubFormCallFor357.cs (P#11.1)\r\n" +
            "\r\n" +
            "========================\r\n" +
            "Total errors: 1\r\n" +
            "========================\r\n" +
            "\r\n" +
            "Projects:\r\n" +
            "C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj\r\n";



        const string CodeWithError =
            "using Firefly.Box;\r\n" +
"using ENV.Data;\r\n" +
"using ENV;\r\n" +
"using Firefly.Box.Flow;\r\n" +
"namespace NorthwindTest\r\n" +
"{\r\n" +
"    /// <summary>TestSubFormCallFor357(P#11)</summary>\r\n" +
"    /// <remark>Last change before Migration: 05/06/2017 10:11:19</remark>\r\n" +
"    internal class TestSubFormCallFor357 : UIControllerBase \r\n" +
"    {\r\n" +
"        #region Models\r\n" +
"        internal readonly Models.Orders Orders = new Models.Orders { Cached = true, AllowRowLocking = true };\r\n" +
"        #endregion\r\n" +
"        internal details details1;\r\n" +
"        public TestSubFormCallFor357()\r\n" +
"        {\r\n" +
"            #region Initialize CachedControllers\r\n" +
"            details1 = new details(this);\r\n" +
"            #endregion\r\n" +
"            Title = \"TestSubFormCallFor357\";\r\n" +
"            InitializeDataView();\r\n" +
"        }\r\n" +
"        void InitializeDataView()\r\n" +
"        {\r\n" +
"            From = Orders;\r\n" +
"            OrderBy = Orders.SortByPK_Orders;\r\n" +
"            #region Column Selection\r\n" +
"            Columns.Add(Orders.OrderID);\r\n" +
"            #endregion\r\n" +
"        }\r\n" +
"        protected override void OnLoad()\r\n" +
"        {\r\n" +
"            RowLocking = LockingStrategy.OnRowSaving;\r\n" +
"            View = () => new Views.TestSubFormCallFor357View(this);\r\n" +
"        }\r\n" +
"        #region Subforms\r\n" +
"        internal void details_SubForm() => details1.Run();\r\n" +
"        \r\n" +
"        #endregion\r\n" +
"        /// <summary>details(P#11.1)</summary>\r\n" +
"        /// <remark>Last change before Migration: 05/06/2017 10:11:19</remark>\r\n" +
"        internal class details : UIControllerBase \r\n" +
"        {\r\n" +
"            #region Models\r\n" +
"            internal readonly Models.OrderDetails OrderDetails = new Models.OrderDetails { AllowRowLocking = true };\r\n" +
"            #endregion\r\n" +
"            TestSubFormCallFor357 _parent;\r\n" +
"            public details(TestSubFormCallFor357 parent)\r\n" +
"            {\r\n" +
"                _parent = parent;\r\n" +
"                Title = \"details\";\r\n" +
"                InitializeDataView()\r\n" +
"            }\r\n" +
"            void InitializeDataView()\r\n" +
"            {\r\n" +
"                From = OrderDetails;\r\n" +
"                Where.Add(OrderDetails.OrderID.IsEqualTo(_parent.Orders.OrderID));\r\n" +
"                \r\n" +
"                OrderBy = OrderDetails.SortByPK_Order_Details;\r\n" +
"                #region Column Selection\r\n" +
"                Columns.Add(OrderDetails.OrderID);\r\n" +
"                #endregion\r\n" +
"            }\r\n" +
"            /// <summary>details(P#11.1)</summary>\r\n" +
"            internal void Run()\r\n" +
"            {\r\n" +
"                Execute();\r\n" +
"            }\r\n" +
"            protected override void OnLoad()\r\n" +
"            {\r\n" +
"                View = () => new Views.TestSubFormCallFor357Details(this);\r\n" +
"            }\r\n" +
"            protected override void OnStart()\r\n" +
"            {\r\n" +
"                Message.ShowWarning(u.Str(u.SubformExecMode(0), \"7\"));\r\n" +
"            }\r\n" +
"        }\r\n" +
"    }\r\n" +
"}\r\n" +
"\r\n";
        
    }
}
