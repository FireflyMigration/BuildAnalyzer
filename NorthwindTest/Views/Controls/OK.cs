using System.Drawing;
using Firefly.Box.UI;
using Firefly.Box;
namespace NorthwindTest.Views.Controls
{
    /// <summary>OK(M#6)</summary>
    [System.ComponentModel.Description("OK")]
    public partial class OK : NorthwindTest.Shared.Theme.Controls.Button 
    {
        public OK()
        {
            InitializeComponent();
        }
        void this_Click(object sender, Firefly.Box.UI.Advanced.ButtonClickEventArgs e)
        {
            e.Raise(Command.Select);
        }
    }
}
