using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 6 Italic #70</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 6 Italic")]
    public class Header6Italic : FontScheme 
    {
        public Header6Italic()
        {
            try
            {
                this.Font = new Font("Times New Roman", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
