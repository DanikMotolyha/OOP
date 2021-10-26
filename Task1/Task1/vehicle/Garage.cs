using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Garage
    {
        public List<Vehicle> vehicles = new List<Vehicle>();

        public void addVehicle(Vehicle vehicle) {
            vehicles.Add(vehicle);
        }

        public void removeVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }
        public List<string> getVehiclesInfoList() => vehicles.ConvertAll(
                new Converter<Vehicle, string>(
                    (Vehicle vehicle) => vehicle.getVehicleConfig()
                    )
        );
        public void sortByYear(bool descending)
        {
            vehicles = descending 
                    ? vehicles.OrderByDescending(elem => elem.Year).ToList() 
                    : vehicles.OrderBy(elem => elem.Year).ToList(); 
        }
        public void writeToFile(string fileName = "data.txt") 
        {
            using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default))
            {
                string text = "";
                foreach (Vehicle vehicle in vehicles) {
                    text += vehicle.getVehicleConfig() + '\n';
                }
                sw.WriteLine(text);
            }
        }
        public List<string> readFromFile(string fileName = "data.txt")
        {
            List<string> list = new List<string>();
            string text = "READ FROM FILE: " + fileName;
            list.Add(text);
            using (StreamReader sr = new StreamReader(fileName, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            return list;
        }
    }
}
