using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab2
{
    public partial class SearchByMaterial : Form
    {
        public SearchByMaterial()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var list2= MainForm.list.FindAll(t => t.Flat.Material.ToLower().Contains(MaterialSearch.Text.ToLower()));
            foreach (var item in list2)
            {
                OutputBox2.Text += item.ShowInfo();
            }
            MainForm.searchResult += JsonConvert.SerializeObject(list2);
        }

        private void ClearMaterial_Click(object sender, EventArgs e)
        {
            OutputBox2.Text = "";
        }
    }
}
