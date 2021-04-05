using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCenter.Model
{
    class CarDealer
    {
        public VehicleList Vehicles { get; set; }
        
        public Vehicle FindMostExpensiveVehicle()
        {
            Vehicle expensiveVehicle = Vehicles[0];
            foreach (Vehicle vehicle in Vehicles)
            {
                if (vehicle.Price > expensiveVehicle.Price)
                {
                    expensiveVehicle = vehicle;
                }
            }

            Vehicles.
            return expensiveVehicle;
        }
    }
}
