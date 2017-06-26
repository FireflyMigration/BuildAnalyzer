using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Tab Text #21</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Tab Text")]
    class TabText : FontScheme 
    {
        public TabText()
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
