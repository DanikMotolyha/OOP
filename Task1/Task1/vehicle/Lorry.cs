using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Lorry : Vehicle
    {
        //максимальная нагрузка грузовика в тоннах
        private int maxLoad;
        
        public Lorry(int prise, int maxspeed, int year,
            int amountOfSeats, int amountOfDoors, int maxLoad)
            : base(prise, maxspeed, year, amountOfSeats, amountOfDoors)
        {
            MaxLoad = maxLoad;
        }
        //переопределение виртуального метода родителя
        public override string getVehicleConfig()
        {
            string config = "Lorry info: " + base.getVehicleConfig() + ",maxLoad: " + maxLoad;
            return config;
        }

        public int MaxLoad
        {
            get { return maxLoad; }
            set { if (value > 0) maxLoad = value; }
        }


    }
}
