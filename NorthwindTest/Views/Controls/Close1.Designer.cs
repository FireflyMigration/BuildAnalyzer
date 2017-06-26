using System.Drawing;
using Firefly.Box.UI;
using Firefly.Box;
namespace NorthwindTest.Views.Controls
{
    partial class Close1
    {
        void InitializeComponent()
        {
            this.ClickEventRegistrationErasesPreviouslyRegisteredClickHandlers = true;
            this.Format = "Close";
            this.Click += new Firefly.Box.UI.Advanced.ButtonClickEventHandler(this.this_Click);
        }
    }
}
