Vehicle car = new Vehicle("Tesla", 5, "Red", true);
Vehicle anotherCar = new Vehicle("Tesla Model Y", "Silver and white");
Vehicle scooter = new Vehicle("Scooter", 1, "Brown", false);
Vehicle horse = new Vehicle("Donna", "Black");


List<Vehicle> allVehicles = new List<Vehicle>();
allVehicles.Add(car);
allVehicles.Add(anotherCar);
allVehicles.Add(scooter);
allVehicles.Add(horse);

// Displaying information about each vehicle
foreach (Vehicle v in allVehicles)
{
    v.ShowInfo();
}

car.Travel(100);
car.ShowInfo();

anotherCar.Travel(120);
anotherCar.ShowInfo();
