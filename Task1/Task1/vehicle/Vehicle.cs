using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    /*
     * Абстрактный базовый класс
     */
    abstract class Vehicle
    {
        // цена транспортного средства
        private int price;
        // максимальная скорость
        private int maxSpeed;
        // год выпуска
        private int year;
        // количество сидений
        private int amountOfSeats;
        // количество дверей
        private int amountOfDoors;

        protected Vehicle(
            int price, int maxSpeed, int year, 
            int amountOfSeats, int amountOfDoors)
        {
            Price = price;
            MaxSpeed = maxSpeed;
            Year = year;
            AmountOfSeats = amountOfSeats;
            AmountOfDoors = amountOfDoors;
        }

        public virtual string getVehicleConfig() {
            string config =
                "price: " + price +
                ",maxSpeed: " + maxSpeed +
                ",year: " + year +
                ",ammountOfSeats: " + amountOfSeats +
                ",ammountOfDoors: " + amountOfDoors;
            return config;
        }

        public int Price
        {
            get { return price; }
            set { if (value > 0) price = value; }
        }
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { if (value > 0) maxSpeed = value; }
        }
        public int Year
        {
            get { return year; }
            set { if (value <= DateTime.Today.Year) year = value; }
        }

        public int AmountOfDoors 
        {
            get { return amountOfDoors; }
            set { if (value > 0) amountOfDoors = value; } 
        }
        public int AmountOfSeats 
        {
            get { return amountOfSeats; }
            set { if (value > 0) amountOfSeats = value; }
        }
    }
}
