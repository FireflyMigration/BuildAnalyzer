using System;
using ENV;
namespace NorthwindTest.Views
{
    internal partial class DefaultPulldownMenu : System.Windows.Forms.ContextMenuStrip,IHaveAMenu 
    {
        MenuManager _menuManager;
        public void InitUserBasedMenus()
        {
            mnuDeveloperTools.Visible = Common.EnableDeveloperTools;
            mnuProfiler.Visible = Common.EnableDeveloperTools;
            ENV.Utilities.Profiler.InitMenu(mnuProfiler);
        }
        public DefaultPulldownMenu(System.ComponentModel.IContainer container) : base(container)
        {
            InitializeComponent();
            InitUserBasedMenus();
            _menuManager = new MenuManager(this);
            _menuManager.Map("", mnuFile);
            _menuManager.Map("", mnuShellToOS);
            _menuManager.Map("", mnuPrinterSetup);
            _menuManager.Map("", mnuExitSystem, false);
            _menuManager.Map("", mnuEdit);
            _menuManager.Map("", mnuCancel, false);
            _menuManager.Map("", mnuUndoEditing, false);
            _menuManager.Map("", mnuZoom, false);
            _menuManager.Map("", mnuWide, false);
            _menuManager.Map("", mnuCreateLine, false);
            _menuManager.Map("", mnuDeleteLine, false);
            _menuManager.Map("", mnuCut, false);
            _menuManager.Map("", mnuCopy, false);
            _menuManager.Map("", mnuPaste, false);
            _menuManager.Map("", mnuSelectAll, false);
            _menuManager.Map("", mnuDitto, false);
            _menuManager.Map("", mnuSetToNULL, false);
            _menuManager.Map("", mnuVCR);
            _menuManager.Map("", mnuBeginTable, false);
            _menuManager.Map("", mnuPreviousScreen, false);
            _menuManager.Map("", mnuPreviousRow, false);
            _menuManager.Map("", mnuNextRow, false);
            _menuManager.Map("", mnuNextScreen, false);
            _menuManager.Map("", mnuEndTable, false);
            _menuManager.Map("", mnuOptions);
            _menuManager.Map("", mnuModifyRecords, false);
            _menuManager.Map("", mnuCreateRecords, false);
            _menuManager.Map("", mnuQueryRecords, false);
            _menuManager.Map("", mnuLocateA_Record, false);
            _menuManager.Map("", mnuLocateNext, false);
            _menuManager.Map("", mnuRangeOfRecords, false);
            _menuManager.Map("", mnuViewByKey, false);
            _menuManager.Map("", mnuSortRecords, false);
            _menuManager.Map("", mnuPrintData, false);
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
            _menuManager.Map("", mnuAbout);
            _menuManager.Map("", mnuChangeFormColor);
            _menuManager.SetCurrentStateAsDefault();
        }
        public void DoOnMenu(Action<MenuManager> action)
        {
            action(_menuManager);
        }
        protected override void OnOpened(EventArgs e)
        {
            MenuManager.ApplyToContextMenu(this, this);
            MenuManager.EnableContextItem(mnuExitSystem, Firefly.Box.Command.ExitApplication);
            MenuManager.EnableContextItem(mnuCancel, Firefly.Box.Command.UndoChangesInRow);
            MenuManager.EnableContextItem(mnuUndoEditing, Firefly.Box.Command.UndoEditing);
            MenuManager.EnableContextItem(mnuZoom, Firefly.Box.Command.Expand);
            MenuManager.EnableContextItem(mnuWide, Firefly.Box.Command.ExpandTextBox);
            MenuManager.EnableContextItem(mnuCreateLine, Firefly.Box.Command.InsertRow);
            MenuManager.EnableContextItem(mnuDeleteLine, Firefly.Box.Command.DeleteRow);
            MenuManager.EnableContextItem(mnuCut, Firefly.Box.Command.Cut);
            MenuManager.EnableContextItem(mnuCopy, Firefly.Box.Command.Copy);
            MenuManager.EnableContextItem(mnuPaste, Firefly.Box.Command.Paste);
            MenuManager.EnableContextItem(mnuSelectAll, Firefly.Box.Command.SelectAll);
            MenuManager.EnableContextItem(mnuDitto, Firefly.Box.Command.SetFocusedControlValueSameAsInPreviousRow);
            MenuManager.EnableContextItem(mnuSetToNULL, Firefly.Box.Command.SetFocusedControlValueToNull);
            MenuManager.EnableContextItem(mnuBeginTable, Firefly.Box.Command.GoToFirstRow);
            MenuManager.EnableContextItem(mnuPreviousScreen, Firefly.Box.Command.GoToPreviousPage);
            MenuManager.EnableContextItem(mnuPreviousRow, Firefly.Box.Command.GoToPreviousRow);
            MenuManager.EnableContextItem(mnuNextRow, Firefly.Box.Command.GoToNextRow);
            MenuManager.EnableContextItem(mnuNextScreen, Firefly.Box.Command.GoToNextPage);
            MenuManager.EnableContextItem(mnuEndTable, Firefly.Box.Command.GoToLastRow);
            MenuManager.EnableContextItem(mnuModifyRecords, Firefly.Box.Command.SwitchToUpdateActivity);
            MenuManager.EnableContextItem(mnuCreateRecords, Firefly.Box.Command.SwitchToInsertActivity);
            MenuManager.EnableContextItem(mnuQueryRecords, Firefly.Box.Command.SwitchToBrowseActivity);
            MenuManager.EnableContextItem(mnuLocateA_Record, Commands.FindRows);
            MenuManager.EnableContextItem(mnuLocateNext, Commands.FindNextRow);
            MenuManager.EnableContextItem(mnuRangeOfRecords, Commands.FilterRows);
            MenuManager.EnableContextItem(mnuViewByKey, Commands.SelectOrderBy);
            MenuManager.EnableContextItem(mnuSortRecords, Commands.CustomOrderBy);
            MenuManager.EnableContextItem(mnuPrintData, Commands.ExportData);
            MenuManager.EnableContextItem(mnuHelp1, Firefly.Box.Command.Help);
        }
        void ShellToOS_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuShellToOS, () => _menuManager.Raise(Commands.ShellToOS));
        }
        void PrinterSetup_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuPrinterSetup, () => _menuManager.Raise(Commands.PrinterSettingsDialog));
        }
        void ExitSystem_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuExitSystem, () => _menuManager.Raise(Firefly.Box.Command.ExitApplication));
        }
        void Cancel_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuCancel, () => _menuManager.Raise(Firefly.Box.Command.UndoChangesInRow));
        }
        void UndoEditing_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuUndoEditing, () => _menuManager.Raise(Firefly.Box.Command.UndoEditing));
        }
        void Zoom_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuZoom, () => _menuManager.Raise(Firefly.Box.Command.Expand));
        }
        void Wide_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuWide, () => _menuManager.Raise(Firefly.Box.Command.ExpandTextBox));
        }
        void CreateLine_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuCreateLine, () => _menuManager.Raise(Firefly.Box.Command.InsertRow));
        }
        void DeleteLine_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuDeleteLine, () => _menuManager.Raise(Firefly.Box.Command.DeleteRow));
        }
        void Cut_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuCut, () => _menuManager.Raise(Firefly.Box.Command.Cut));
        }
        void Copy_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuCopy, () => _menuManager.Raise(Firefly.Box.Command.Copy));
        }
        void Paste_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuPaste, () => _menuManager.Raise(Firefly.Box.Command.Paste));
        }
        void SelectAll_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuSelectAll, () => _menuManager.Raise(Firefly.Box.Command.SelectAll));
        }
        void Ditto_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuDitto, () => _menuManager.Raise(Firefly.Box.Command.SetFocusedControlValueSameAsInPreviousRow));
        }
        void SetToNULL_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuSetToNULL, () => _menuManager.Raise(Firefly.Box.Command.SetFocusedControlValueToNull));
        }
        void BeginTable_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuBeginTable, () => _menuManager.Raise(Firefly.Box.Command.GoToFirstRow));
        }
        void PreviousScreen_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuPreviousScreen, () => _menuManager.Raise(Firefly.Box.Command.GoToPreviousPage));
        }
        void PreviousRow_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuPreviousRow, () => _menuManager.Raise(Firefly.Box.Command.GoToPreviousRow));
        }
        void NextRow_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuNextRow, () => _menuManager.Raise(Firefly.Box.Command.GoToNextRow));
        }
        void NextScreen_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuNextScreen, () => _menuManager.Raise(Firefly.Box.Command.GoToNextPage));
        }
        void EndTable_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuEndTable, () => _menuManager.Raise(Firefly.Box.Command.GoToLastRow));
        }
        void ModifyRecords_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuModifyRecords, () => _menuManager.Raise(Firefly.Box.Command.SwitchToUpdateActivity));
        }
        void CreateRecords_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuCreateRecords, () => _menuManager.Raise(Firefly.Box.Command.SwitchToInsertActivity));
        }
        void QueryRecords_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuQueryRecords, () => _menuManager.Raise(Firefly.Box.Command.SwitchToBrowseActivity));
        }
        void LocateA_Record_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuLocateA_Record, () => _menuManager.Raise(Commands.FindRows));
        }
        void LocateNext_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuLocateNext, () => _menuManager.Raise(Commands.FindNextRow));
        }
        void RangeOfRecords_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuRangeOfRecords, () => _menuManager.Raise(Commands.FilterRows));
        }
        void ViewByKey_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuViewByKey, () => _menuManager.Raise(Commands.SelectOrderBy));
        }
        void SortRecords_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuSortRecords, () => _menuManager.Raise(Commands.CustomOrderBy));
        }
        void PrintData_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuPrintData, () => _menuManager.Raise(Commands.ExportData));
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
        void Help_Click(object sender, EventArgs e)
        {
            _menuManager.RunOnActiveContext(mnuHelp1, () => _menuManager.Raise(Firefly.Box.Command.Help));
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
