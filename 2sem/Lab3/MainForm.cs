using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Linq;
using System.Threading;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public static List<Adress> list = new List<Adress>();
        private Flat flat;
        private Adress adress;
        private string action;
        private readonly string mainFilePath = "./objects.json";
        private readonly string sortResFilePath = "./sortRes.json";
        private readonly string searchResFilePath = "./searchRes.json";
        private string fileContent;
        private string sortResult;
        public static string searchResult;

        private readonly Stack<string[]> undoAction = new Stack<string[]>();
        private readonly Stack<string[]> redoAction = new Stack<string[]>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "";
            action = "стереть данные";
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
                
                flat = new Flat(uint.Parse(Meters.Text),uint.Parse(Rooms.Value.ToString()), mass, DateTimePicker.Value, MaterialType.Text,uint.Parse(Floor.Text));
                adress = new Adress(flat, CountryT.Text, TownT.Text, DistrictT.Text, StreetT.Text, BuildingT.Text, FlatT.Text,int.Parse(Index.Text));
                
                if (!MyValidate.IsValid(flat)) MessageBox.Show("Проверьте значения полей.");
                else if (!MyValidate.IsValid(adress)) MessageBox.Show("Проверьте значения полей адреса.");
                else
                {
                    list.Add(adress);
                    OutputBox.Text = adress.ShowInfo();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Для продолжения регистрации, пожалуйста, заполните все поля формы правильно");
            }
            finally { action = "записать данные"; }
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
           File.WriteAllText(mainFilePath,JsonConvert.SerializeObject(list));
           action = "записать в файл";
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            try
            {
                list = JsonConvert.DeserializeObject<List<Adress>>(File.ReadAllText(mainFilePath));
                foreach (var item in list) OutputBox.Text += item.ShowInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Файл не существует!");
            }
            finally { action = "выгрузить из файла"; }
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

        private void Index_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            char bs = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(bs))
            {
                e.Handled = true;
            }
        }

           void Timer_Tick(object sender, EventArgs e)
           {
            DateLabel.Text = DateTime.Now.ToLongDateString();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            ObjCounter.Text = "Объектов: " + list.Count.ToString();
            LastAction.Text = $"Последнее действие: {action}";
           }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            var timer = new System.Windows.Forms.Timer() { Interval = 1000 };
            timer.Tick += Timer_Tick;
            timer.Start();
            try
            {
                list = JsonConvert.DeserializeObject<List<Adress>>(File.ReadAllText(mainFilePath));
            }
            catch (Exception)
            {
                ObjCounter.Text = "файл не обнаружен";
            }
        }

        private void AboutProgram(object sender, EventArgs e)
        {
            MessageBox.Show("Версия: 1.0.0.\nГончаревич Евгений Витальевич.");
        }

        private void поМетражуToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var list2 = list.OrderByDescending(item => item.Flat.Meters);
            OutputBox.Text += "";
            foreach (var item in list2)
            {
                OutputBox.Text += item.ShowInfo();
            }
            sortResult += JsonConvert.SerializeObject(list2);
        }

        private void поКоличествуКомнатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list2 = list.OrderByDescending(item => item.Flat.RoomsCount);
            OutputBox.Text += "";
            foreach (var item in list2)
            {
                OutputBox.Text += item.ShowInfo();
            }
            sortResult += JsonConvert.SerializeObject(list2);
        }

        private void поЭтажуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list2 = list.OrderByDescending(item => item.Flat.Floor);
            OutputBox.Text += "";
            foreach (var item in list2)
            {
                OutputBox.Text += item.ShowInfo();
            }
            sortResult += JsonConvert.SerializeObject(list2);
        }

        private void поискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(() => WriteToFile(searchResFilePath, searchResult));
            t1.Start();
        }
        void WriteToFile(string path, string result)
        {
            if (File.Exists(path)) fileContent = File.ReadAllText(path);
            File.WriteAllText(path, fileContent + "\n" + result + "\n");
        }
        private void сортировкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(()=>WriteToFile(sortResFilePath, sortResult));
            t1.Start();
        }

        private void типМатериалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchByMaterial newForm = new SearchByMaterial();
            newForm.Show();
        }

        private void индексToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchByIndex newForm = new SearchByIndex();
            newForm.Show();
        }

        private void HideMenuBar_Click(object sender, EventArgs e)
        {
            MenuBar.Visible = false;
        }

        private void показатьМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBar.Visible = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Balcony.Checked = false;
            Basement.Checked = false;
            WC.Checked = false;
            Bath.Checked = false;
            Kitchen.Checked = false;
            Meters.Clear();
            Floor.Clear();
            FlatT.Clear();
            BuildingT.Clear();
            StreetT.Clear();
            DistrictT.Clear();
            TownT.Clear();
            CountryT.Clear();
            Index.Clear();
            OutputBox.Clear();
        }

        private void DeleteLast_Click(object sender, EventArgs e)
        {
            list.RemoveAt(list.Count - 1);
            File.WriteAllText(mainFilePath, JsonConvert.SerializeObject(list));
            action = "записать в файл";
        }

    }
}

