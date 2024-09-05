using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental
{
    internal class Truck : Vehicle
    {
        private int capacity;

        // Constructor: Initializes a truck with capacity, license plate, make, model, and rental price
        public Truck(int capacity, string licensePlate, string make, string model, double rentalPrice)
            : base(licensePlate, make, model, rentalPrice)
        {
            this.capacity = capacity;
        }

        // Override Method: Calculates the rental cost based on the number of days and the truck's capacity
        public override double CalculateRentalCost(int days)
        {
            return GetRentalPrice() * days + capacity * days;
        }
    }
}
