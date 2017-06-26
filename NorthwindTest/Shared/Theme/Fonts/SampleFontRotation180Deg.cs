using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Sample Font rotation 180 Deg. #104</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Sample Font rotation 180 Deg.")]
    class SampleFontRotation180Deg : FontScheme 
    {
        public SampleFontRotation180Deg()
        {
            try
            {
                this.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
                this.TextAngle = 180;
            }
            catch
            {
            }
        }
    }
}
