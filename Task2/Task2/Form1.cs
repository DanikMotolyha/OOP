using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        private string name;
        private DateTime date;
        private int citySquare;
        private int cityPopulation;
        private County country;

        City city = null;
        public Form1()
        {
            InitializeComponent();
            cityCountry.Items.Add(County.BELARUS);
            cityCountry.Items.Add(County.RUSSIA);
            cityCountry.Items.Add(County.LILHUANIA);
        }

        private void createCity_Click(object sender, EventArgs e)
        {
            name = cityName.Text;
            date = cityDate.Value;
            citySquare = (int)square.Value;
            cityPopulation = (int)population.Value;

            if (cityCountry.SelectedIndex == -1) country = County.BELARUS;
            else {
                Enum.TryParse(Convert.ToString(cityCountry.SelectedItem), out country);
            }

            city = new City(name, date, citySquare, cityPopulation, country);
            createdCityField.Clear();
            createdCityField.Text = city.ToString();
        }

        private void writeToFile_Click(object sender, EventArgs e)
        {
            if (city == null) errorMessage.Text = "вы не создали город";
            else
            {
                errorMessage.Clear();
                try
                {
                    city.writeToFile();
                    errorMessage.Text = "успешно записано";
                }
                catch (Exception ex) { 
                    errorMessage.Text = "ошибка записи" + ex.Message;
                }
            }
        }

        private void serialize_Click(object sender, EventArgs e)
        {
            if (city == null) errorMessage.Text = "вы не создали город";
            else
            {
                errorMessage.Clear();
                try
                {
                    city.serialize();
                    errorMessage.Text = "успешно сериализованно";
                }
                catch (Exception ex)
                {
                    errorMessage.Text = "ошибка сериализации" + ex.Message;
                }
            }
        }

        private void deserialize_Click(object sender, EventArgs e)
        {
                errorMessage.Clear();
                try
                {
                    city = City.deserialize();
                    createdCityField.Clear();
                    createdCityField.Text = city.ToString();
                    errorMessage.Text = "успешно десериализованно";
                }
                catch (Exception ex)
                {
                    errorMessage.Text = "ошибка десериализации" + ex.Message;
                }
        }

        private void parseFromFile_Click(object sender, EventArgs e)
        {
                errorMessage.Clear();
                try
                {
                    city = City.parseFromFile();
                    createdCityField.Clear();
                    createdCityField.Text = city.ToString();
                    errorMessage.Text = "парсинг прошел успешно";
                }
                catch (Exception ex)
                {
                    errorMessage.Text = "Ошибка парсинга" + ex.Message;
                }
        }
    }
}
