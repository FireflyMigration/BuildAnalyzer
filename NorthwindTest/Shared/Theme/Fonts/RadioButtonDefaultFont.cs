using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Radio Button Default Font #10</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Radio Button Default Font")]
    public class RadioButtonDefaultFont : FontScheme 
    {
        public RadioButtonDefaultFont()
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
