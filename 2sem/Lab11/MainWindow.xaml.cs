using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace Lab11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MobileContext db;
        public MainWindow()
        {
            InitializeComponent();

            db = new MobileContext();
            db.Phones.Load(); // загружаем данные
            phonesGrid.ItemsSource = db.Phones.Local.ToBindingList(); // устанавливаем привязку к кэшу

            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (phonesGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < phonesGrid.SelectedItems.Count; i++)
                {
                    Phone phone = phonesGrid.SelectedItems[i] as Phone;
                    if (phone != null)
                    {
                        db.Phones.Remove(phone);
                    }
                }
            }
            db.SaveChanges();
        }
    }
    public class Phone
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }
    public class MobileContext : DbContext
    {
        public MobileContext() : base("Server=localhost; Database=mobiledb; Trusted_Connection=True; Encrypt=False; TrustServerCertificate=True")
        {

        }
        public DbSet<Phone> Phones { get; set; }
    }
}
