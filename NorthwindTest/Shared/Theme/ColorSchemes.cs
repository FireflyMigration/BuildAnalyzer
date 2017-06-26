using System.Drawing;
using Firefly.Box.UI;
using Firefly.Box;
using System.Collections.Generic;
namespace NorthwindTest.Shared.Theme
{
    /// <summary>Map of Colors used to resolve value by index</summary>
    public class ColorSchemes
    {
        static ColorSchemes()
        {
            _map.Add(1, new Colors.Window_sDefault());
            _map.Add(2, new Colors.Control_sDefault());
            _map.Add(3, new Colors.Red());
            _map.Add(4, new Colors.Blue());
            _map.Add(6, new Colors.missing6ColorInTheClrFile1());
            _map.Add(39, new Colors.missing39ColorInTheClrFile1());
            _map.Add(40, new Colors.missing40ColorInTheClrFile1());
            _map.Add(41, new Colors.missing41ColorInTheClrFile1());
        }
        /// <summary>Used to find Colors by index</summary>
        public static ColorScheme Find(Number index)
        {
            if (index==null||!_map.ContainsKey(index))
                return new ENV.UI.MissingColor();
            return _map[index];
        }
        static Dictionary<Number,ColorScheme> _map = new Dictionary<Number,ColorScheme>();
    }
}
