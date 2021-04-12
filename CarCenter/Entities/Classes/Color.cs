using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCenter.Entities.Classes
{
    class Color
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public static Color White => new Color(255, 255, 255);
        public static Color Black => new Color(0, 0, 0);
        public static Color Blue => new Color(0, 0, 255);
        public static Color Red => new Color(255, 0, 0);
        public static Color Orange => new Color(255, 150, 0);

        public Color(int red, int green, int blue)
        {
            R = red;
            G = green;
            B = blue;
        }

        public override string ToString()
        {
            return $"[{R}, {G}, {B}]";
        }
    }
}
