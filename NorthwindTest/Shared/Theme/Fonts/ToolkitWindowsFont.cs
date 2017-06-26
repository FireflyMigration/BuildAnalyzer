using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Toolkit Windows Font #30</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Toolkit Windows Font")]
    class ToolkitWindowsFont : FontScheme 
    {
        public ToolkitWindowsFont()
        {
            try
            {
                this.Font = new Font("MS Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
