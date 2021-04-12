using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCenter.Model
{
    class CarDealer
    {        
        public Vehicle FindMostExpensiveVehicle(IEnumerable<Vehicle> vehicles)
        {
            /*
            Vehicle expensiveVehicle = vehicles[0];
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Price > expensiveVehicle.Price)
                {
                    expensiveVehicle = vehicle;
                }
            }
            return expensiveVehicle;*/

            if (vehicles == null)
            {
                throw new ArgumentNullException();
            }

            return vehicles.Single(x => x.Price == vehicles.Max(y => y.Price));
        }

        public Vehicle FindCheapestVehicle(IEnumerable<Vehicle> vehicles)
        {
            if (vehicles == null)
            {
                throw new ArgumentNullException();
            }

            return vehicles.Single(x => x.Price == vehicles.Min(y => y.Price));
        }
    }
}
