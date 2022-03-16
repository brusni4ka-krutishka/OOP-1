using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public List<Adress> list= new List<Adress>();
        public Flat flat;
        public Adress adress;
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "";
        }

        private void WriteData_Click(object sender, EventArgs e)
        {
            try
            {
                byte i = 0;
                string[] mass= new string[5];
                if (Kitchen.Checked) { 
                    mass[i] = Kitchen.Text;
                    i++;
                }
                if (Bath.Checked)
                {
                    mass[i] = Bath.Text;
                    i++;
                }
                if (WC.Checked)
                {
                    mass[i] = WC.Text;
                    i++;
                }
                if (Basement.Checked)
                {
                    mass[i] = Basement.Text;
                    i++;
                }
                if (Balcony.Checked)
                {
                    mass[i] = Balcony.Text;
                    i++;
                }
                if (mass.Length == 0) mass[0] = "Опции не выбраны";
                flat = new Flat(uint.Parse(Meters.Text),uint.Parse(Rooms.Value.ToString()), mass, DateTimePicker.Value, MaterialType.Text,uint.Parse(Floor.Text));
                adress = new Adress(flat, CountryT.Text, TownT.Text, DistrictT.Text, StreetT.Text, BuildingT.Text, FlatT.Text);
                list.Add(adress);
                
                OutputBox.Text = adress.ShowInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Для продолжения регистрации, пожалуйста, заполните все поля формы");
            }
        }

        private void Meters_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            char bs = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(bs))
            {
                e.Handled = true;
            }
        }

        private void Serialize_Click(object sender, EventArgs e)
        {
           File.WriteAllText("./objects.json",JsonConvert.SerializeObject(list));
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            try
            {
                list = JsonConvert.DeserializeObject<List<Adress>>(File.ReadAllText("./objects.json"));
                foreach (var item in list) OutputBox.Text += item.ShowInfo();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void Floor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            char bs = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(bs))
            {
                e.Handled = true;
            }
        }

        private void CountryT_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            char bs = e.KeyChar;

            if (Char.IsDigit(number) && !Char.IsControl(bs))
            {
                e.Handled = true;
            }
        }

        private void TownT_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            char bs = e.KeyChar;

            if (Char.IsDigit(number) && !Char.IsControl(bs))
            {
                e.Handled = true;
            }
        }

        private void DistrictT_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            char bs = e.KeyChar;

            if (Char.IsDigit(number) && !Char.IsControl(bs))
            {
                e.Handled = true;
            }
        }

        private void StreetT_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            char bs = e.KeyChar;

            if (Char.IsDigit(number) && !Char.IsControl(bs))
            {
                e.Handled = true;
            }
        }
    }
}

