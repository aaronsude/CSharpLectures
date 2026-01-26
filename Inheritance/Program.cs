//using Inheritance.Examples;

//Vehicle[] allVehicles =
//[
//    new Motorcycle(brand: "Kawasaki", 2018, 125),
//    new Car(brand: "Toyota", yearOfProduction: 2005, doors: 5),
//    new Airplane(brand: "Airbus", yearOfProduction: 2024, 550)
//];

//foreach (Vehicle vehicle in allVehicles)
//    vehicle.Start();



using Inheritance.Solutions;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Employee[] team =
//        [
//            new Manager("Alice", 50.0, 1000.0),
//            new Developer("Bob", 40.0, 10.0),
//            new Employee("Charlie", 30.0)
//        ];

//foreach (var emp in team)
//{
//    Console.WriteLine($"{emp.Name} earns: {emp.GetSalary():C}");
//}


Animal[] animals =
        [
            new Dog("Rex"),
            new Cat("Mittens"),
            new Bird("Tweety"),
            new Dog("Buddy")
        ];

foreach (Animal animal in animals)
{
    animal.MakeSound();
}