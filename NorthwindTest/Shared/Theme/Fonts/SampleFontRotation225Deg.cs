using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Sample Font rotation 225 Deg. #105</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Sample Font rotation 225 Deg.")]
    class SampleFontRotation225Deg : FontScheme 
    {
        public SampleFontRotation225Deg()
        {
            try
            {
                this.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
                this.TextAngle = 225;
            }
            catch
            {
            }
        }
    }
}
