using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental
{
    internal class Car : Vehicle
    {
        private string type;

        // Constructor: Initializes a car with its type, license plate, make, model, and rental price
        public Car(string type, string licensePlate, string make, string model, double rentalPrice)
            : base(licensePlate, make, model, rentalPrice)
        {
            this.type = type;
        }

        // Override Method: Calculates the rental cost based on the number of rental days
        public override double CalculateRentalCost(int days)
        {
            return GetRentalPrice() * days;
        }
    }
}
