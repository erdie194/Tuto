using System;
using System.Collections.Generic;

namespace Tut
{
    class Program
    {
       

        
        static void Main(string[] args)
        {
            Garage HomeGarage = new Garage();
            Car car1 = new Car(12, "Rot");
            Car car2 = new Car(1123, "Gelb");
            Car car3 = new Car(122, "Blau");
            Car car4 = new Car(70, "Gelb");

            HomeGarage.addCar(car1);
            HomeGarage.addCar(car2);
            HomeGarage.addCar(car3);
            HomeGarage.addCar(car4);

            List<Car> YellowCars = HomeGarage.findCarsWithColor("Gelb");
            foreach (Car car in YellowCars)
            {
                car.ShowCar();
            }
        }
    }
}
