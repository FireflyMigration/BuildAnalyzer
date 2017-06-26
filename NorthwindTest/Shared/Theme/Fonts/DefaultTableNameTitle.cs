using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Default Table Name Title #5</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Default Table Name Title")]
    class DefaultTableNameTitle : FontScheme 
    {
        public DefaultTableNameTitle()
        {
            try
            {
                this.Font = new Font("MS Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
