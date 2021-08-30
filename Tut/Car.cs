using System;
namespace Tut
{
    public class Car
    {
        public int ps { get; private set; }
        public string farbe { get; private set; }

        public Car(int ps, string farbe)
        {
            this.ps = ps;
            this.farbe = farbe;
        }

      

        public void ShowCar() 
        {
            Console.WriteLine("Farbe: " + ps);
            Console.WriteLine("PS: " + farbe);

        }
    }

    
}
