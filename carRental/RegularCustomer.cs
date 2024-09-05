using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental
{
    internal class RegularCustomer : Customer
    {
        private string name;
        private List<Vehicle> rentedVehicles;

        // Constructor: Initializes a regular customer with a name and an empty list of rented vehicles
        public RegularCustomer(string name)
        {
            this.name = name;
            this.rentedVehicles = new List<Vehicle>();
        }

        // Method: Returns the name of the customer
        public string GetName()
        {
            return name;
        }

        // Virtual Method: Processes the rental of a vehicle and adds it to the list of rented vehicles
        public virtual void RentVehicle(Vehicle vehicle, int days)
        {
            if (!rentedVehicles.Contains(vehicle))
            {
                rentedVehicles.Add(vehicle);
            }
            double sum = vehicle.CalculateRentalCost(days);
            if (!(this is CorporateCustomer))
            {
                Console.WriteLine($"{name} rented {vehicle.GetModel()} for {days} days at a cost of {sum}.");
            }
        }

        // Method: Returns the list of vehicles rented by the customer
        public List<Vehicle> GetRentedVehicles()
        {
            return rentedVehicles;
        }


    }
}
