using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Views
{
    /// <summary>Show Customers(P#3)</summary>
    partial class ShowCustomersView : NorthwindTest.Shared.Theme.Controls.CompatibleForm 
    {
        ShowCustomers _controller;
        internal ShowCustomersView(ShowCustomers controller)
        {
            _controller = controller;
            InitializeComponent();
        }
    }
}
