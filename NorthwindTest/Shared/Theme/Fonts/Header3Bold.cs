using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 3 Bold #60</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 3 Bold")]
    public class Header3Bold : FontScheme 
    {
        public Header3Bold()
        {
            try
            {
                this.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
