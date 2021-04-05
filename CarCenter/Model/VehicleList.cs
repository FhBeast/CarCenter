using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarCenter.Exceptions;
using System.Collections;

namespace CarCenter.Model
{
    class VehicleList : IEnumerable<Vehicle>
    {
        private List<Vehicle> vehicles;

        public VehicleList()
        {
            vehicles = new List<Vehicle>();
        }

        public Vehicle this[int index]
        {
            get
            {
                return vehicles[index];
            }
        }

        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException();
            }

            vehicles.Add(vehicle);
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            return vehicles.GetEnumerator();
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException();
            }

            if (vehicles.Contains(vehicle))
            {
                throw new VehicleExistException("Vehicle not exist");
            }

            vehicles.Remove(vehicle);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
