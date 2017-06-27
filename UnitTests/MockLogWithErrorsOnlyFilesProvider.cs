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
    class MockLogWithErrorsOnlyFilesProvider : IFilesProvider
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
 "     1>TestSubFormCallFor357.cs(52,37): error CS1002: ; expected [C:\\Users\\Sefi\\Source\\Repos\\BuildAnalyzer\\NorthwindTest\\NorthwindTest.csproj]\r\n" +
"\r\n" +
"Build FAILED.\r\n" +
"    2 Warning(s)\r\n" +
"    1 Error(s)\r\n" +
"\r\n" +
"Time Elapsed 00:00:00.53\r\n" +
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
