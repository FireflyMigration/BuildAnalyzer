using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Views
{
    /// <summary>Details(P#5.1)</summary>
    partial class ShowOrdersDetails : NorthwindTest.Shared.Theme.Controls.CompatibleForm 
    {
        ShowOrders.Details _controller;
        internal ShowOrdersDetails(ShowOrders.Details controller)
        {
            _controller = controller;
            InitializeComponent();
        }
        void cboOrderDetails_ProductID_BindListSource(object sender, System.EventArgs e)
        {
            var Products = new Models.Products();
            cboOrderDetails_ProductID.ListSource = Products;
            cboOrderDetails_ProductID.ValueColumn = Products.ProductID;
            cboOrderDetails_ProductID.DisplayColumn = Products.ProductName;
            cboOrderDetails_ProductID.ListOrderBy = Products.SortByProductName;
        }
    }
}
