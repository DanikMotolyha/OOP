using Form1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        Garage garage = new Garage();

        private int price;
        private int maxSpeed;
        private int year;
        private int amountOfSeats;
        private int amountOfDoors;
        private bool roof;
        private bool engine;
        private int maxLoad;
        public Form1()
        {
            InitializeComponent();
        }

        private void addBicycle_Click(object sender, EventArgs e)
        {
            price = (int)Price.Value;
            maxSpeed = (int)MaxSpeed.Value;
            year = (int)Year.Value;
            amountOfSeats = (int)AmountOfSeats.Value;
            amountOfDoors = (int)AmountOfDoors.Value;
            engine = Engine.Checked;

            Bicycle bicycle = new Bicycle(price,maxSpeed,year,amountOfSeats,amountOfDoors,engine);
            garage.addVehicle(bicycle);

            GarageList.Text += bicycle.getVehicleConfig() + "\r\n";
        }

        private void addLoryy_Click(object sender, EventArgs e)
        {
            price = (int)Price.Value;
            maxSpeed = (int)MaxSpeed.Value;
            year = (int)Year.Value;
            amountOfSeats = (int)AmountOfSeats.Value;
            amountOfDoors = (int)AmountOfDoors.Value;
            maxLoad = (int)MaxLoad.Value;

            Lorry lorry = new Lorry(price, maxSpeed, year, amountOfSeats, amountOfDoors, maxLoad);
            garage.addVehicle(lorry);

            GarageList.Text += lorry.getVehicleConfig() + "\r\n";
        }

        private void addCar_Click(object sender, EventArgs e)
        {
            price = (int)Price.Value;
            maxSpeed = (int)MaxSpeed.Value;
            year = (int)Year.Value;
            amountOfSeats = (int)AmountOfSeats.Value;
            amountOfDoors = (int)AmountOfDoors.Value;
            roof = Roof.Checked;

            Car car = new Car(price, maxSpeed, year, amountOfSeats, amountOfDoors, roof);
            garage.addVehicle(car);

            GarageList.Text += car.getVehicleConfig() + "\r\n";
        }

        private void PrintGarageInMemory_Click(object sender, EventArgs e)
        {
            GarageList.Clear();
            List<string> list = garage.getVehiclesInfoList();

            list.ForEach(elem => GarageList.Text += elem + "\r\n");
        }

        private void PrintGarageFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                GarageList.Clear();
                garage.readFromFile().ForEach(line => GarageList.Text += line + "\r\n");
            }
            catch (Exception ex)
            {
                errorMessage.Text = "cannot read data from file";
            }
        }

        private void WriteGarageToFile_Click(object sender, EventArgs e)
        {
            try
            {
                garage.writeToFile();
            }
            catch (Exception ex) {
                errorMessage.Text = "cannot write to file data";
            }
        }

        private void SortByYear_Click(object sender, EventArgs e)
        {
            garage.sortByYear(SortingFilter.Checked);

            GarageList.Clear();
            List<string> list = garage.getVehiclesInfoList();

            list.ForEach(elem => GarageList.Text += elem + "\r\n");
        }

        private void clearOutputGarage_Click(object sender, EventArgs e)
        {
            GarageList.Clear();
        }
    }
}
