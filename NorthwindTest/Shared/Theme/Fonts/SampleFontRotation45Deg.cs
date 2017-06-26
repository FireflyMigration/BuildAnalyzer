using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Sample Font rotation 45 Deg. #101</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Sample Font rotation 45 Deg.")]
    class SampleFontRotation45Deg : FontScheme 
    {
        public SampleFontRotation45Deg()
        {
            try
            {
                this.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
                this.TextAngle = 45;
            }
            catch
            {
            }
        }
    }
}
