using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 4 Italic #68</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 4 Italic")]
    public class Header4Italic : FontScheme 
    {
        public Header4Italic()
        {
            try
            {
                this.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
