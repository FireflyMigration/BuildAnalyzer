using System;
using ENV;
using Firefly.Box;
namespace NorthwindTest.Views
{
    partial class ApplicationMdi : System.Windows.Forms.Form,IHaveAMenu 
    {
        MenuManager _menuManager;
        public override System.Drawing.Size MinimumSize { get { return Common.GetMDIMinimumSize(this, base.MinimumSize); } set { base.MinimumSize = value; } }
        internal System.Windows.Forms.ContextMenuStrip _optionsContextMenuStrip;
        public ApplicationMdi()
        {
            _menuManager = new MenuManager(this);
            Icon = ENV.Common.DefaultIcon;
            InitializeComponent();
            InitUserBasedMenus();
            Common.MDILoad(this);
            _menuManager.MapMainMenu(1, DefaultPulldownMenu, DefaultPulldownMenuToolStrip);
            _menuManager.Activate(1);
            MenuManager.DetermineEnabled(DefaultPulldownMenu);
            _menuManager.Map("", mnuFile);
            _menuManager.Map("", mnuShellToOS);
            _menuManager.Map("", mnuPrinterSetup);
            _menuManager.Map("", mnuExitSystem, false);
            Command.ExitApplication.BindMenuItem(mnuExitSystem);
            _menuManager.Map("", mnuEdit);
            _menuManager.Map("", mnuCancel, false);
            Command.UndoChangesInRow.BindMenuItem(mnuCancel);
            _menuManager.Map("", mnuUndoEditing, false);
            Command.UndoEditing.BindMenuItem(mnuUndoEditing);
            _menuManager.Map("", mnuZoom, false);
            Command.Expand.BindMenuItem(mnuZoom);
            _menuManager.Map("", mnuWide, false);
            Command.ExpandTextBox.BindMenuItem(mnuWide);
            _menuManager.Map("", mnuCreateLine, false);
            Command.InsertRow.BindMenuItem(mnuCreateLine);
            _menuManager.Map("", mnuDeleteLine, false);
            Command.DeleteRow.BindMenuItem(mnuDeleteLine);
            _menuManager.Map("", mnuCut, false);
            Command.Cut.BindMenuItem(mnuCut);
            _menuManager.Map("", mnuCopy, false);
            Command.Copy.BindMenuItem(mnuCopy);
            _menuManager.Map("", mnuPaste, false);
            Command.Paste.BindMenuItem(mnuPaste);
            _menuManager.Map("", mnuSelectAll, false);
            Command.SelectAll.BindMenuItem(mnuSelectAll);
            _menuManager.Map("", mnuDitto, false);
            Command.SetFocusedControlValueSameAsInPreviousRow.BindMenuItem(mnuDitto);
            _menuManager.Map("", mnuSetToNULL, false);
            Command.SetFocusedControlValueToNull.BindMenuItem(mnuSetToNULL);
            _menuManager.Map("", mnuVCR);
            _menuManager.Map("", mnuBeginTable, false);
            Command.GoToFirstRow.BindMenuItem(mnuBeginTable);
            _menuManager.Map("", tsbBeginTable, false);
            _menuManager.MapAsChild(mnuVCR, tsbBeginTable);
            Command.GoToFirstRow.BindMenuItem(tsbBeginTable);
            _menuManager.Map("", mnuPreviousScreen, false);
            Command.GoToPreviousPage.BindMenuItem(mnuPreviousScreen);
            _menuManager.Map("", tsbPreviousScreen, false);
            _menuManager.MapAsChild(mnuVCR, tsbPreviousScreen);
            Command.GoToPreviousPage.BindMenuItem(tsbPreviousScreen);
            _menuManager.Map("", mnuPreviousRow, false);
            Command.GoToPreviousRow.BindMenuItem(mnuPreviousRow);
            _menuManager.Map("", tsbPreviousRow, false);
            _menuManager.MapAsChild(mnuVCR, tsbPreviousRow);
            Command.GoToPreviousRow.BindMenuItem(tsbPreviousRow);
            _menuManager.Map("", mnuNextRow, false);
            Command.GoToNextRow.BindMenuItem(mnuNextRow);
            _menuManager.Map("", tsbNextRow, false);
            _menuManager.MapAsChild(mnuVCR, tsbNextRow);
            Command.GoToNextRow.BindMenuItem(tsbNextRow);
            _menuManager.Map("", mnuNextScreen, false);
            Command.GoToNextPage.BindMenuItem(mnuNextScreen);
            _menuManager.Map("", tsbNextScreen, false);
            _menuManager.MapAsChild(mnuVCR, tsbNextScreen);
            Command.GoToNextPage.BindMenuItem(tsbNextScreen);
            _menuManager.Map("", mnuEndTable, false);
            Command.GoToLastRow.BindMenuItem(mnuEndTable);
            _menuManager.Map("", tsbEndTable, false);
            _menuManager.MapAsChild(mnuVCR, tsbEndTable);
            Command.GoToLastRow.BindMenuItem(tsbEndTable);
            _menuManager.Map("", mnuOptions);
            _menuManager.Map("", mnuModifyRecords, false);
            Command.SwitchToUpdateActivity.BindMenuItem(mnuModifyRecords);
            _menuManager.Map("", tsbModifyRecords, false);
            _menuManager.MapAsChild(mnuOptions, tsbModifyRecords);
            Command.SwitchToUpdateActivity.BindMenuItem(tsbModifyRecords);
            _menuManager.Map("", mnuCreateRecords, false);
            Command.SwitchToInsertActivity.BindMenuItem(mnuCreateRecords);
            _menuManager.Map("", tsbCreateRecords, false);
            _menuManager.MapAsChild(mnuOptions, tsbCreateRecords);
            Command.SwitchToInsertActivity.BindMenuItem(tsbCreateRecords);
            _menuManager.Map("", mnuQueryRecords, false);
            Command.SwitchToBrowseActivity.BindMenuItem(mnuQueryRecords);
            _menuManager.Map("", tsbQueryRecords, false);
            _menuManager.MapAsChild(mnuOptions, tsbQueryRecords);
            Command.SwitchToBrowseActivity.BindMenuItem(tsbQueryRecords);
            _menuManager.Map("", mnuLocateA_Record, false);
            Commands.FindRows.BindMenuItem(mnuLocateA_Record);
            _menuManager.Map("", tsbLocateA_Record, false);
            _menuManager.MapAsChild(mnuOptions, tsbLocateA_Record);
            Commands.FindRows.BindMenuItem(tsbLocateA_Record);
            _menuManager.Map("", mnuLocateNext, false);
            Commands.FindNextRow.BindMenuItem(mnuLocateNext);
            _menuManager.Map("", tsbLocateNext, false);
            _menuManager.MapAsChild(mnuOptions, tsbLocateNext);
            Commands.FindNextRow.BindMenuItem(tsbLocateNext);
            _menuManager.Map("", mnuRangeOfRecords, false);
            Commands.FilterRows.BindMenuItem(mnuRangeOfRecords);
            _menuManager.Map("", tsbRangeOfRecords, false);
            _menuManager.MapAsChild(mnuOptions, tsbRangeOfRecords);
            Commands.FilterRows.BindMenuItem(tsbRangeOfRecords);
            _menuManager.Map("", mnuViewByKey, false);
            Commands.SelectOrderBy.BindMenuItem(mnuViewByKey);
            _menuManager.Map("", tsbViewByKey, false);
            _menuManager.MapAsChild(mnuOptions, tsbViewByKey);
            Commands.SelectOrderBy.BindMenuItem(tsbViewByKey);
            _menuManager.Map("", mnuSortRecords, false);
            Commands.CustomOrderBy.BindMenuItem(mnuSortRecords);
            _menuManager.Map("", tsbSortRecords, false);
            _menuManager.MapAsChild(mnuOptions, tsbSortRecords);
            Commands.CustomOrderBy.BindMenuItem(tsbSortRecords);
            _menuManager.Map("", mnuPrintData, false);
            Commands.ExportData.BindMenuItem(mnuPrintData);
            ENV.Commands.ClearCurrentValueInTemplate.BindMenuItem(mnuClearValue);
            _menuManager.Map("", mnuClearValue, false);
            ENV.Commands.ClearTemplate.BindMenuItem(mnuClearTemplate);
            _menuManager.Map("", mnuClearTemplate, false);
            ENV.Commands.TemplateFromValues.BindMenuItem(mnuFromValues);
            _menuManager.Map("", mnuFromValues, false);
            ENV.Commands.TemplateToValues.BindMenuItem(mnuToValue);
            _menuManager.Map("", mnuToValue, false);
            ENV.Commands.TemplateExpression.BindMenuItem(mnuDefineExpression);
            _menuManager.Map("", mnuDefineExpression, false);
            _menuManager.Map("", mnuPrograms);
            _menuManager.Map("", mnuCustomers);
            _menuManager.Map("", mnuProducts);
            _menuManager.Map("", mnuOrders);
            _menuManager.Map("", mnuOrdersReport);
            _menuManager.Map("", mnuHelp);
            _menuManager.Map("", mnuHelp1, false);
            Command.Help.BindMenuItem(mnuHelp1);
            _menuManager.Map("", tsbHelp, false);
            _menuManager.MapAsChild(mnuHelp, tsbHelp);
            Command.Help.BindMenuItem(tsbHelp);
            _menuManager.Map("", mnuAbout);
            _menuManager.Map("", mnuChangeFormColor);
            MenuManager.DetermineEnabled(DefaultPulldownMenuToolStrip);
            ENV.Utilities.Profiler.InitToolStrip(DefaultPulldownMenuToolStrip);
            TemplateModeFilter.SetTemplateModeMenues(mnuCancel, mnuEdit, mnuUndoEditing, mnuZoom, mnuWide, mnuCut, mnuCopy, mnuPaste, mnuSelectAll, mnuSetToNULL, mnuClearValue, mnuOptions, mnuClearTemplate, mnuFromValues, mnuToValue, mnuDefineExpression, mnuHelp1, mnuHelp, tsbHelp);
        }
        public void DoOnMenu(Action<MenuManager> action)
        {
            action(_menuManager);
        }
        public void InitUserBasedMenus()
        {
            mnuDeveloperTools.Visible = Common.EnableDeveloperTools;
            mnuProfiler.Visible = Common.EnableDeveloperTools;
            ENV.Utilities.Profiler.InitMenu(mnuProfiler);
            mnuDeveloperTools1.Visible = Common.EnableDeveloperTools;
            mnuProfiler1.Visible = Common.EnableDeveloperTools;
            ENV.Utilities.Profiler.InitMenu(mnuProfiler1);
        }
        [System.Diagnostics.DebuggerStepThrough]
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            Common.ProcessMDIMessage(this, m);
            base.WndProc(ref m);
            Common.ProcessMDIMessageAfterMDI(this, m);
        }
        protected override void OnClosed(EventArgs e)
        {
            Common.MDIClose(this);
            base.OnClosed(e);
        }
        protected override void ScaleControl(System.Drawing.SizeF factor, System.Windows.Forms.BoundsSpecified specified)
        {
            Common.MDIScale(this, factor);
            base.ScaleControl(factor, specified);
        }
        void expandStatusLabel_Click(object sender, EventArgs e)
        {
            _menuManager.Raise(Command.Expand);
        }
        void expandTextBoxStatusLabel_Click(object sender, EventArgs e)
        {
            _menuManager.Raise(Command.ExpandTextBox);
        }
        void Users_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuUsers, () => ENV.Security.UserManager.ManageUsers());
        }
        void Groups_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuGroups, () => ENV.Security.UserManager.ManageGroups());
        }
        void SecuredValues_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuSecuredValues, () => ENV.Security.UserManager.ManageSecuredValues());
        }
        void ChangePassword_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuChangePassword, () => ENV.Security.UserManager.ChangePassword());
        }
        void TestErrorLog_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ErrorLog.Test());
        }
        void FireflyAbout_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => new ENV.UI.AboutFirefly().ShowDialog());
        }
        void CallStack_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ErrorLog.ShowCurrentLocation());
        }
        void CallStackBrowser_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Utilities.CallStackBrowser.Run());
        }
        void EntityBrowser_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Utilities.EntityBrowser.ShowEntityBrowser(Application.Instance));
        }
        void ProgramsProwser_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Utilities.ProgramRunner.ShowAllPrograms(Application.Instance));
        }
        void GetDefiniton_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Utilities.GetDefinition.Run(typeof (NorthwindTest.Shared.DataSources)));
        }
        void SQLQuery_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Utilities.SQLQuery.Run(typeof (NorthwindTest.Shared.DataSources)));
        }
        void DisplayUserSettings_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => UserSettings.Display());
        }
        void TestPathDecode_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => PathDecoder.ContextPathDecoder.PathDecoderTester());
        }
        void DemoExpand_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.UI.TextBox.ToggleExpandButton());
        }
        void ScalingDemo_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Labs.ScreenScale.Show());
        }
        void EnableAdvancedFeatures_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.UI.Grid.AlwaysEnableGridEnhancements = !ENV.UI.Grid.AlwaysEnableGridEnhancements);
        }
        void EnableAdvancedFeatures_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.UI.Grid.AlwaysUseUnderConstructionNewGridLook = !ENV.UI.Grid.AlwaysUseUnderConstructionNewGridLook);
        }
        void FaceLift_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Labs.FaceLiftDemo.Enabled = !ENV.Labs.FaceLiftDemo.Enabled);
        }
        void ShellToOS_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuShellToOS, () => _menuManager.Raise(Commands.ShellToOS));
        }
        void PrinterSetup_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuPrinterSetup, () => _menuManager.Raise(Commands.PrinterSettingsDialog));
        }
        void Users_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuUsers1, () => ENV.Security.UserManager.ManageUsers());
        }
        void Groups_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuGroups1, () => ENV.Security.UserManager.ManageGroups());
        }
        void SecuredValues_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuSecuredValues1, () => ENV.Security.UserManager.ManageSecuredValues());
        }
        void ChangePassword_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuChangePassword1, () => ENV.Security.UserManager.ChangePassword());
        }
        void TestErrorLog_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ErrorLog.Test());
        }
        void FireflyAbout_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => new ENV.UI.AboutFirefly().ShowDialog());
        }
        void CallStack_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ErrorLog.ShowCurrentLocation());
        }
        void CallStackBrowser_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Utilities.CallStackBrowser.Run());
        }
        void EntityBrowser_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Utilities.EntityBrowser.ShowEntityBrowser(Application.Instance));
        }
        void ProgramsProwser_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Utilities.ProgramRunner.ShowAllPrograms(Application.Instance));
        }
        void GetDefiniton_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Utilities.GetDefinition.Run(typeof (NorthwindTest.Shared.DataSources)));
        }
        void SQLQuery_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Utilities.SQLQuery.Run(typeof (NorthwindTest.Shared.DataSources)));
        }
        void DisplayUserSettings_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => UserSettings.Display());
        }
        void TestPathDecode_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => PathDecoder.ContextPathDecoder.PathDecoderTester());
        }
        void DemoExpand_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.UI.TextBox.ToggleExpandButton());
        }
        void ScalingDemo_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Labs.ScreenScale.Show());
        }
        void EnableAdvancedFeatures_Click2(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.UI.Grid.AlwaysEnableGridEnhancements = !ENV.UI.Grid.AlwaysEnableGridEnhancements);
        }
        void EnableAdvancedFeatures_Click3(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.UI.Grid.AlwaysUseUnderConstructionNewGridLook = !ENV.UI.Grid.AlwaysUseUnderConstructionNewGridLook);
        }
        void FaceLift_Click1(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(() => ENV.Labs.FaceLiftDemo.Enabled = !ENV.Labs.FaceLiftDemo.Enabled);
        }
        void Customers_Click(object sender, EventArgs e)
        {
            _menuManager.CloseActiveControllersAndRun(mnuCustomers, () => new NorthwindTest.ShowCustomers().Run());
        }
        void Products_Click(object sender, EventArgs e)
        {
            _menuManager.CloseActiveControllersAndRun(mnuProducts, () => new NorthwindTest.ShowProducts().Run());
        }
        void Orders_Click(object sender, EventArgs e)
        {
            _menuManager.CloseActiveControllersAndRun(mnuOrders, () => new NorthwindTest.ShowOrders().Run());
        }
        void OrdersReport_Click(object sender, EventArgs e)
        {
            _menuManager.CloseActiveControllersAndRun(mnuOrdersReport, () => new NorthwindTest.Print_Orders().Run());
        }
        void About_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuAbout, () => _menuManager.Raise(Commands.About));
        }
        void changeFormColor_Click(object sender, EventArgs e)
        {
            _menuManager.CloseActiveControllersAndRun(mnuChangeFormColor, () => new NorthwindTest.changeFormColor().Run());
        }
        protected T Create<T>()
        {
            return AbstractFactory.Create<T>();
        }
    }
}
