using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;
using FleetSim.Objects.Classes;
using FleetSim.Objects.Enum;

namespace FleetSim.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();

            Car c1 = new Car(2008,"Jeep","Patriot",Color.Colors.Blue);
            cars.Add(c1);

            Car c2 = new Car(2014,"Ford","Fusion",Color.Colors.White);
            cars.Add(c2);

            Car c3 = new Car(2005,"Saturn","Vue",Color.Colors.Red);
            cars.Add(c3);

            Car c4 = new Car(2013,"Chevy","Equinox",Color.Colors.Red);
            cars.Add(c4);

            Car c5 = new Car(2010,"Jeep","Wrangler",Color.Colors.Red);
            cars.Add(c5);

            Random r = new Random();

            foreach (Car car in cars)
            {
                car.mileage = r.Next(5000, 15000);
                System.Console.WriteLine($"Car: {car.year} {car.make} {car.model}");
                System.Console.WriteLine($"Vin: {car.vin}");
                System.Console.WriteLine($"Color: {car.color}");
                System.Console.WriteLine($"Initial Mileage: {car.mileage}");
                System.Console.WriteLine();
                
                for (int i = 0; i < 10; i++)
                {
                    car.mileage += r.Next(1000, 30000);

                    try
                    {
                        car.tuneUp();
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine(ex.Message);
                    }
                }

                System.Console.WriteLine();
            }

        }
    }
}
