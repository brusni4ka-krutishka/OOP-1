using System;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Lab2
{
    public partial class SearchByIndex : Form
    {
        public SearchByIndex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list2 = MainForm.list.FindAll(t => t.Index.ToString().Contains(MaterialSearch.Text));
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
