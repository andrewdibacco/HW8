using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Enum;
using FleetSim.Objects.Interfaces;

namespace FleetSim.Objects.Classes
{
    public class Car : Vehicle, ICar
    {
        public int year { get; set; }
        public string make { get; set; }
        public string model { get; set; }

        public Car()
            : base()
        {

        }

        public Car(int year, string make, string model)
            : base()
        {
            this.year = year;
            this.make = make;
            this.model = model;
        }

        public Car(int year, string make, string model, Color.Colors color)
            : base()
        {
            this.year = year;
            this.make = make;
            this.model = model;
            this.color = color;
        }

        public override void rebuildEngine()
        {
            Console.WriteLine($"{model} engine rebuilt at {mileage} miles on {lastServiceDate}");
            base.rebuildEngine();
        }
    }
}
