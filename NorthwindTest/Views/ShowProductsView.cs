using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Views
{
    /// <summary>Show Products(P#4)</summary>
    partial class ShowProductsView : NorthwindTest.Shared.Theme.Controls.CompatibleForm 
    {
        ShowProducts _controller;
        internal ShowProductsView(ShowProducts controller)
        {
            _controller = controller;
            InitializeComponent();
        }
    }
}
