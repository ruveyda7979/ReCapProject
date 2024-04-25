// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var car in carManager.GetCarDetails())
{
    Console.WriteLine(car.Id + "/" + car.Description + "/" + car.DailyPrice + "/" + car.BrandName
        + "/" + car.ColorName);
}

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.Description);
//}

//List<Car> cars = new List<Car>
//{
//new Car { DailyPrice = 0, Description= "Manuel 7 people"},
//new Car { DailyPrice = 500, Description= "Automatic 5 people"},
//};

//foreach (var car in cars)
//{
//    bool isAdded = carManager.Add(car);
//    if (isAdded)
//    {
//        Console.WriteLine($"Car added successfully: {car.Description}");
//    }
//    else
//    {
//        Console.WriteLine($"Failed add to car: {car.Description}. Please check control the input parameters");
//    }
    
//}


    
    
