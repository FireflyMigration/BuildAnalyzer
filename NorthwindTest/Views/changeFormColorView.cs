using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Views
{
    /// <summary>changeFormColor(P#9)</summary>
    partial class changeFormColorView : NorthwindTest.Shared.Theme.Controls.CompatibleForm 
    {
        changeFormColor _controller;
        internal changeFormColorView(changeFormColor controller)
        {
            _controller = controller;
            InitializeComponent();
        }
        void this_BindColorScheme(object sender, ColorSchemeBindingEventArgs e)
        {
            e.Value = ColorSchemes.Find(_controller.Exp_1());
        }
    }
}
