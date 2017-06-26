using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 1 Italic #65</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 1 Italic")]
    public class Header1Italic : FontScheme 
    {
        public Header1Italic()
        {
            try
            {
                this.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
