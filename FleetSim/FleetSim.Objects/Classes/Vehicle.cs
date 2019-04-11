using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Interfaces;
using FleetSim.Objects.Enum;

namespace FleetSim.Objects.Classes
{
    public class Vehicle : IVehicle
    {
        protected Guid _vin;
        public Guid vin { get => this._vin; }

        public float mileage { get; set; }
        public Color.Colors color { get; set; }
        public DateTime lastServiceDate { get; set; }
        public float lastServiceMileage { get; set; }

        public Vehicle()
        {
            _vin = Guid.NewGuid();
            mileage = 0;
            lastServiceMileage = 0;
        }

        public void tuneUp()
        {

            if (mileage >= 100000)
            {
                lastServiceDate = DateTime.Now;
                rebuildEngine();
            }
            else if (mileage - lastServiceMileage >= 30000)
            {
                lastServiceMileage = mileage;
                lastServiceDate = DateTime.Now;
                Console.WriteLine($"Vehicle tuned up at {mileage} miles on {lastServiceDate}");
            }
            else
            {
                string erMsg = "";

                if (lastServiceMileage + 30000 >= 100000)
                {
                    erMsg = $"This vehicle's current mileage is {mileage} and was last serviced at {lastServiceMileage}. Next servicing is recommended in {100000 - mileage} miles";
                }
                else
                {
                    erMsg = $"This vehicle's current mileage is {mileage} and was last serviced at {lastServiceMileage}. Next servicing is recommended in {30000 - (mileage - lastServiceMileage) } miles";
                }
                Exception ex = new Exception(erMsg);
                throw ex;
            }

        }

        public virtual void rebuildEngine()
        {
            this.mileage = 0;
            this.lastServiceMileage = 0;
            
        }
    }
}
