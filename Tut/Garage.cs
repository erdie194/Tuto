using System;
using System.Collections.Generic;
namespace Tut
{
    public class Garage
    {
        private List<Car> garage = new List<Car>();

        public Garage()
        {
        }

        public void addCar(Car car)
        {
            garage.Add(car);
        }

        public Car getCar(int i)
        {
            return garage[i];
        }

        public List<Car> findCarsWithColor(string ffarbe)
        {
            return garage.FindAll(x => x.farbe == ffarbe);
        }


    }
}
