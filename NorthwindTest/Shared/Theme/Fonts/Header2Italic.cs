using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 2 Italic #66</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 2 Italic")]
    public class Header2Italic : FontScheme 
    {
        public Header2Italic()
        {
            try
            {
                this.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
