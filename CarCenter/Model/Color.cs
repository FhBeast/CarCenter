using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCenter.Model
{
    class Color
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
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
