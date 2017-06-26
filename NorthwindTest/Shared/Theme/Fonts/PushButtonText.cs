using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Push Button Text #27</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Push Button Text")]
    class PushButtonText : FontScheme 
    {
        public PushButtonText()
        {
            try
            {
                this.Font = new Font("MS Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
