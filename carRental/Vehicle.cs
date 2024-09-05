using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental
{
    internal abstract class Vehicle
    {
        private string licensePlate;

        private string make;

        private string model;

        protected double rentalPrice;

        // Constructor: Initializes the vehicle with license plate, make, model, and rental price
        public Vehicle(string licensePlate, string make, string model, double rentalPrice)
        {
            this.licensePlate = licensePlate;
            this.make = make;
            this.model = model;
            this.rentalPrice = rentalPrice;
        }

        // Method: Returns the license plate of the vehicle
        public string GetLicensePlate()
        {
            return licensePlate;
        }

        // Method: Returns the make of the vehicle
        public string GetMake()
        {
            return make;
        }

        // Method: Returns the model of the vehicle
        public string GetModel()
        {
            return model;
        }

        // Method: Returns the rental price of the vehicle
        public double GetRentalPrice()
        {
            return rentalPrice;
        }

        // Abstract Method: Calculates the rental cost based on the number of rental days
        public abstract double CalculateRentalCost(int days);
    }
}
