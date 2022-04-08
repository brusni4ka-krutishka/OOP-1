using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
namespace Lab6_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<StockItem> ItemList = new List<StockItem>();

        class StockItem
        {
            public string Title { get; set; }
            public string Firm { get; set; }
            public string Cost { get; set; }
            public string Stock { get; set; }
            public string ImgPath { get; set; }
        }
       
        public MainWindow()
        {
            InitializeComponent();
            List<StockItem> list = new List<StockItem>
            {
                new StockItem{Title="Огромная пробка Red Boy", Firm="Doc Johnson", Cost="221 руб", Stock="25", ImgPath="./img/1.png"},
                new StockItem{Title="Черный фаллоимитатор King-Sized Anal Dildo", Firm="Lovetoy", Cost="445 руб", Stock="15", ImgPath="./img/2.png"},
                new StockItem{Title="Фаллоимитатор Мустанг Черный", Firm="Erasexa", Cost="338 руб", Stock="18", ImgPath="./img/3.png"},
                new StockItem{Title="Лубрикант для фистинга pjur power 150 мл", Firm="Pjur", Cost="62 руб", Stock="5", ImgPath="./img/4.png"},
                new StockItem{Title="Бондаж для рук и груди", Firm="Pjur", Cost="62 руб", Stock="5", ImgPath="./img/4.png"},
                new StockItem{Title="Электростимулятор плуг", Firm="ОOО \"Кисс Экспо\" ", Cost="106 руб", Stock="7", ImgPath="./img/6.png"},
            };
            Photos.ItemsSource = list;

        }

    }
}
