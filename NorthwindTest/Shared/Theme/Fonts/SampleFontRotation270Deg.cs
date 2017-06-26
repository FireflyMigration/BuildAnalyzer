using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Sample Font rotation 270 Deg. #106</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Sample Font rotation 270 Deg.")]
    class SampleFontRotation270Deg : FontScheme 
    {
        public SampleFontRotation270Deg()
        {
            try
            {
                this.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
                this.TextAngle = 270;
            }
            catch
            {
            }
        }
    }
}
