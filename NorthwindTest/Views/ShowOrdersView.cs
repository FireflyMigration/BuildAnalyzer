using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Views
{
    /// <summary>Show Orders(P#5)</summary>
    partial class ShowOrdersView : NorthwindTest.Shared.Theme.Controls.CompatibleForm 
    {
        ShowOrders _controller;
        internal ShowOrdersView(ShowOrders controller)
        {
            _controller = controller;
            InitializeComponent();
        }
        void cboOrders_CustomerID_BindListSource(object sender, System.EventArgs e)
        {
            var Customers = new Models.Customers();
            cboOrders_CustomerID.ListSource = Customers;
            cboOrders_CustomerID.ValueColumn = Customers.CustomerID;
            cboOrders_CustomerID.DisplayColumn = Customers.CompanyName;
            cboOrders_CustomerID.ListOrderBy = Customers.SortByCompanyName;
        }
        void btn_Click(object sender, ButtonClickEventArgs e)
        {
            e.Raise(_controller.ExpandCust);
        }
        void btnPrint_Click(object sender, ButtonClickEventArgs e)
        {
            e.Raise(_controller.Print1);
        }
    }
}
