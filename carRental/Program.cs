using carRental;


Vehicle car = new Car("Toyota", "ABC123", "Corolla", "Sedan", 70);
Vehicle truck = new Truck(80, "XYZ789", "Ford", "F-150", 800);
Vehicle car2 = new Car("Kia", "ABC123", "Corolla", "Picanto", 50);
Vehicle truck2 = new Truck(80, "XYZ789", "Ford", "C-900", 1000);

Customer regularCustomer = new RegularCustomer("Chani Benziman");
Customer corporateCustomer = new CorporateCustomer("Michal Rot", "Intel");

regularCustomer.RentVehicle(car, 3);
corporateCustomer.RentVehicle(truck, 2);
regularCustomer.RentVehicle(car2, 3);
corporateCustomer.RentVehicle(truck2, 2);

Console.WriteLine($"Rented Vehicles by {regularCustomer.GetName()}:");
foreach (var vehicle in regularCustomer.GetRentedVehicles())
{
    Console.WriteLine($"{vehicle.GetModel()} - {vehicle.CalculateRentalCost(3)}");
}

Console.WriteLine($"Rented Vehicles by {((CorporateCustomer)corporateCustomer).GetName()}:");
List<Vehicle> vehicles = corporateCustomer.GetRentedVehicles();
foreach (var vehicle in vehicles)
{
    Console.Write($"{vehicle.GetModel()} - ");
    corporateCustomer.RentVehicle(vehicle, 2);
}

