using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Dialog Text #26</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Dialog Text")]
    class DialogText : FontScheme 
    {
        public DialogText()
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
