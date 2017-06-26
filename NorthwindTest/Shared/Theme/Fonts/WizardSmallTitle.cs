using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Wizard small title #82</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Wizard small title")]
    public class WizardSmallTitle : FontScheme 
    {
        public WizardSmallTitle()
        {
            try
            {
                this.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
