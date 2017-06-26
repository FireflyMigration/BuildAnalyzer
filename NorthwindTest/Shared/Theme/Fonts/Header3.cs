using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 3 #53</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 3")]
    public class Header3 : FontScheme 
    {
        public Header3()
        {
            try
            {
                this.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
