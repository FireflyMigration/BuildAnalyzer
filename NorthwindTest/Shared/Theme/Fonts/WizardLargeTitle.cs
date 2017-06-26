using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Wizard large title #81</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Wizard large title")]
    public class WizardLargeTitle : FontScheme 
    {
        public WizardLargeTitle()
        {
            try
            {
                this.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
