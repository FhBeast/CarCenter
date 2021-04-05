using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCenter.Exceptions
{
    class VehicleExistException : ArgumentException
    {
        public VehicleExistException(string message) : base(message)
        {
        }
        public VehicleExistException()
        {

        }
    }
}
