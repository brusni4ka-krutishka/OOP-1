using System;
using System.Windows.Forms;

namespace Lab1
{
    
    public partial class Form1 : Form
    {
        Resize resize = new Resize();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try { textBox2.Text = resize.ToEurope(textBox1.Text); }
            catch (Exception) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { textBox2.Text = resize.ToRussian(textBox1.Text); }
            catch (Exception) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { textBox2.Text = resize.ToAmerican(textBox1.Text); }
            catch (Exception) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { textBox2.Text = resize.ToBritain(textBox1.Text); }
            catch (Exception) { }
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = "dblclick";
            }
            catch (Exception)
            {

            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("ПРивет");
        }
    }
    public interface ISize
    {
        string ToEurope(string size);
        string ToRussian(string size);
        string ToAmerican(string size);
        string ToBritain(string size);
    }
    class Resize : ISize
    {
        public string ToEurope(string size)
        {
            size=size.Replace(".", ",");
            float sizeFloat = float.Parse(size);
            float x = 1.0f;
            for (float i = .0f; i <= sizeFloat; i += 0.5f)
            {
                if (i % 2 < 1)
                    x += 0.5f;
                else
                    x++;
            }
            if (sizeFloat < 25) return $"Гном что ли? {x}";
            return x.ToString();
        }
        public string ToRussian(string size)
        {
            size = size.Replace(".", ",");
            float sizeFloat = float.Parse(size);
            float x = 1.0f;
            for (float i = .0f; i <= sizeFloat; i += 0.5f)
            {
                if (i % 2 < 1)
                    x += 0.5f;
                else
                    x++;
            }
            if (sizeFloat < 25) return $"Гном что ли? {x - 1}";

            return (x-1).ToString();
        }
        public string ToAmerican(string size)
        {
            size = size.Replace(".", ",");
            float sizeFloat = float.Parse(size);
            float x = 1.0f;
            for (float i = .0f; i <= sizeFloat; i += 0.5f)
            {
                if (i % 2 < 1)
                    x += 0.5f;
                else
                    x++;
            }
            if (sizeFloat < 25) return $"Гном что ли? {x-33}";
            return (x - 33).ToString();
        }
        public string ToBritain(string size)
        {
            size = size.Replace(".", ",");
            float sizeFloat = float.Parse(size);
            float x = 1.0f;
            for (float i = .0f; i <= sizeFloat; i += 0.5f)
            {
                if (i % 2 < 1)
                    x += 0.5f;
                else
                    x++;
            }
            if (sizeFloat < 25) return $"Гном что ли? {x - 33}";
            return (x - 33.5).ToString();
        }
    }
}
