using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Bicycle : Vehicle
    {
        //мотор
        public bool Engine { get; set; }

        public Bicycle(int prise, int maxspeed, int year,
            int amountOfSeats, int amountOfDoors, bool engine)
            : base(prise, maxspeed, year, amountOfSeats, amountOfDoors)
        {
            Engine = engine;
        }

        //переопределение виртуального метода родителя
        public override string getVehicleConfig()
        {
            string config = "Bicycle info: " + base.getVehicleConfig() + ",Engine: " + Engine;
            return config;
        }

    }
}
