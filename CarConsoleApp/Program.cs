// See https://aka.ms/new-console-template for more information
using CarConsoleApp;



Car car1 = new Car("XX12345", "Toyota", 291);

Console.WriteLine(car1);

Car car2 = new Car() { RegNo = "XX123456", Model = "BMW", Hk = 150 };

Car car3 = new Car(); car3.RegNo = "XX123"; car3.Model = "BMW"; car3.Hk = 150;

Console.WriteLine(car3);
Console.WriteLine(new Car("XX12345", "BMWW", 150));


CarList carList = new CarList();
carList.AddNewCar("XX88222", "XY", 1299);
carList.AddNewCar("XX882223", "XY", 1299);
carList.AddNewCar("XX883333", "XY", 1299);
carList.AddNewCar("XX884444", "XY2", 1299);
carList.AddNewCar("XX884555", "XY", 1299);
carList.AddNewCar("XX8845556", "XY2", 1299);


try
{
    carList.AddCurrentCar(car3);
}
catch (ArgumentException e) 
{ 
    Console.WriteLine(e);
}



List<Car> listall = carList.GetCars();

foreach (var item in listall)
{
    Console.WriteLine(item);
}

Console.WriteLine(carList.GetCar("XX884444"));

Console.WriteLine(carList.GetCar2("XX882223"));

carList.RemoveCar("XX8845556");
Console.ReadLine();


Console.ReadLine();

List<Car> carsSameModel = carList.GetAllCarsRegno("XY");


StationCar stationcar = new StationCar("station Car", "EJSK", "Toyota", 210);

Console.WriteLine(stationcar);
