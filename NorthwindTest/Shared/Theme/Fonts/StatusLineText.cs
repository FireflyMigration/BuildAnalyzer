using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Status Line Text #28</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Status Line Text")]
    class StatusLineText : FontScheme 
    {
        public StatusLineText()
        {
            try
            {
                this.Font = new Font("MS Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
