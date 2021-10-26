using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum County { BELARUS, RUSSIA, LILHUANIA };

    [Serializable]
    class City
    {

        //название города
        private string name;
        //дата основания
        private DateTime date;
        //площадь
        private int square;
        //население
        private int population;
        //страна
        private County country;

        public City(string name, DateTime date, int square, int population, County country)
        {
            this.name = name;
            this.date = date;
            this.square = square;
            this.population = population;
            this.country = country;
        }

        //метод записи в файл( по умолчанию data.txt)
        public void writeToFile(string fileName = "data.txt") {
            using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(ToString());
            }
        }


        //метод простейшего парсинга из файла( по умолчанию data.txt)
        public static City parseFromFile(string fileName = "data.txt") {
            using (StreamReader sr = new StreamReader(fileName, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    City city = parse(line);
                    return city;
                }
            }
            return null;
        }
        private static City parse(string str) {
            City city;
            string[] mass = str.Split(" ");
            string cityName = (string)mass[0];
            DateTime cityDate = DateTime.Parse((string)mass[1]); 
            int citySquare = int.Parse(mass[2]);
            int cityPopulation = int.Parse(mass[3]);
            County cityCountry;
            Enum.TryParse(mass[4], out cityCountry);
            city = new City(cityName, cityDate, citySquare, cityPopulation, cityCountry);
            return city;
        }


        //сериализация( по умолчанию data.dat)
        public void serialize(string fileName = "default.dat") {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);
            }
        }
        
        //десериализация( по умолчанию data.dat)
        public static City deserialize(string fileName = "default.dat")
        {
            City city = null;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("default.dat", FileMode.OpenOrCreate))
            {
                city = (City)formatter.Deserialize(fs);
            }
            return city;
        }
        //метод, преобразовывающий объект в строку
        public override string ToString()
        {
            return name + " " + date.ToShortDateString() + " " + square + " " + population +  " " + country;
        }
        //метод, преобразовывающий объект в строку с хэш-кодами
        public string ToStringWithHash()
        {
            return "name: " + name + ",hash: " + name.GetHashCode() + "\r\n"
                + "date: " + date.ToShortDateString() + ",hash: " + date.GetHashCode() + "\r\n"
                + "square: " + square + ",hash: " + square.GetHashCode() + "\r\n"
                + "population: " + population + ",hash: " + population.GetHashCode() + "\r\n"
                + "country: " + country.ToString() + ",hash: " + country.GetHashCode() + "\r\n";
        }
    }
}
