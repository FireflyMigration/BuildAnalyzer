using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 5 Italic #69</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 5 Italic")]
    public class Header5Italic : FontScheme 
    {
        public Header5Italic()
        {
            try
            {
                this.Font = new Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
