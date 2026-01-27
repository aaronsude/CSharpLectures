using Interfaces.One;
using Interfaces.Two;

//Car audi = new Car("Audi");

//Airplane airbus = new Airplane("Airbus A380");

//Boat boat = new Boat("New Boat");
//IVehicle[] vehicleList = [audi, airbus, boat];

//foreach (var vehicle in vehicleList)
//{
//    vehicle.Start();
//    vehicle.Stop();
//}

//IUserRepository repository = new FileStorageUserRepository();
//_ = repository.GetUser(1);


//Animal[] animals = new Animal[]
//        {
//            new Dog("Buddy"),
//            new Cat("Luna"),
//            new Bird("Sky")
//        };

//foreach (var animal in animals)
//{
//    animal.MakeSound();
//    animal.Feed();
//    Console.WriteLine("-----");
//}



Car bmw = new Car("BMW");
Airplane airbus = new Airplane("Airbus");

IVehicle[] vehicles = [bmw, airbus] ;
foreach (var vehicle in vehicles)
{
    vehicle.Start();

}