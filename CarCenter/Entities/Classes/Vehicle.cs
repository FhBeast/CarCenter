using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCenter.Entities.Classes
{
    abstract class Vehicle
    {
        public decimal Price { get; set; }
        public int Mileage { get; set; }
        public int YearOfRelease { get; set; }
        public int Weight { get; set; }
        public Color BodyColor { get; set; }
    }
}
