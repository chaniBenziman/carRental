using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental
{
    internal interface Customer
    {
        // Method: Returns the name of the customer
        string GetName();

        // Method: Processes the rental of a vehicle for a given number of days
        void RentVehicle(Vehicle vehicle, int days);

        // Method: Returns a list of vehicles rented by the customer
        List<Vehicle> GetRentedVehicles();
    }
}
