using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Sample Font rotation 135 Deg. #103</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Sample Font rotation 135 Deg.")]
    class SampleFontRotation135Deg : FontScheme 
    {
        public SampleFontRotation135Deg()
        {
            try
            {
                this.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
                this.TextAngle = 135;
            }
            catch
            {
            }
        }
    }
}
