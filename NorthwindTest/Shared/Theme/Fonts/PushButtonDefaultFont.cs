using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Push Button Default Font #9</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Push Button Default Font")]
    public class PushButtonDefaultFont : FontScheme 
    {
        public PushButtonDefaultFont()
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
