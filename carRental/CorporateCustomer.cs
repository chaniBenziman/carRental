using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental
{
    internal class CorporateCustomer : RegularCustomer
    {
        private string companyName;

        // Constructor: Initializes a corporate customer with name and company name
        public CorporateCustomer(string name, string companyName)
        : base(name)
        {
            this.companyName = companyName;
        }

        // Method: Returns the name of the company
        public string GetName()
        {
            return companyName;
        }

        // Override Method: Processes the rental of a vehicle with a 10% discount for corporate customers
        public override void RentVehicle(Vehicle vehicle, int days)
        {
            double sum = vehicle.CalculateRentalCost(days) * 0.9; // Apply 10% discount
            base.RentVehicle(vehicle, days);
            Console.WriteLine($"{companyName} rented {vehicle.GetModel()} for {days} days at a cost of {sum}");
        }
    }
}
