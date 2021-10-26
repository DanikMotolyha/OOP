using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Car : Vehicle
    {
        //крыша
        public bool Roof { get; set; }

        public Car(
            int prise, int maxspeed, int year, 
            int amountOfSeats, int amountOfDoors, bool roof)
            : base(prise, maxspeed, year, amountOfSeats,amountOfDoors)
        {
            Roof = roof;
        }

        //переопределение виртуального метода родителя
        public override string getVehicleConfig()
        {
            string config = "Car info: " + base.getVehicleConfig() + ",Roof: " + Roof;
            return config;
        }

    }
}
