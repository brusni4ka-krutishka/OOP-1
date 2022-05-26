using Microsoft.Win32;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        SqlDataAdapter HouseAdapter, FlatAdapter;
        DataTable HouseTable, FlatTable;

        public MainWindow()
        {
            InitializeComponent();

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            string FlatSql = "select номер_квартиры, количество_комнат, балкон, фото from dbo.Квартира";

            FlatTable = new DataTable();

            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                SqlCommand FlatCommand = new SqlCommand(FlatSql, sqlConnection);
                FlatAdapter = new SqlDataAdapter(FlatCommand)
                {

                    // установка команды на добавление для вызова хранимой процедуры

                    InsertCommand = new SqlCommand("sp_InsertFlat", sqlConnection)
                };
                FlatAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                FlatAdapter.InsertCommand.Parameters.Add(new SqlParameter("@номер_квартиры", SqlDbType.Int, 0, "номер_квартиры"));
                FlatAdapter.InsertCommand.Parameters.Add(new SqlParameter("@количество_комнат", SqlDbType.Int, 0, "количество_комнат"));
                FlatAdapter.InsertCommand.Parameters.Add(new SqlParameter("@балкон", SqlDbType.NVarChar, 50, "балкон"));
                FlatAdapter.InsertCommand.Parameters.Add(new SqlParameter("@фото", SqlDbType.NVarChar, 300, "фото"));

                SqlParameter FlatParameter = FlatAdapter.InsertCommand.Parameters.Add("@id_квартиры", SqlDbType.Int, 0, "id_квартиры");
                FlatParameter.Direction = ParameterDirection.Output;
                sqlConnection.Open();
                FlatAdapter.Fill(FlatTable);
                flatGridFlat.ItemsSource = FlatTable.DefaultView;
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
        }




        private void ClickHouse(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string HouseSql = "select номер_дома, год_постройки, тип_материала from dbo.Дом order by номер_дома";
            HouseTable = new DataTable();
            SqlCommand HouseCommand = new SqlCommand(HouseSql, sqlConnection);
            HouseAdapter = new SqlDataAdapter(HouseCommand)
            {
                InsertCommand = new SqlCommand("sp_InsertHouse", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                }
            };
            HouseAdapter.InsertCommand.Parameters.Add(new SqlParameter("@номер_дома", SqlDbType.Int, 0, "номер_дома"));
            HouseAdapter.InsertCommand.Parameters.Add(new SqlParameter("@год_постройки", SqlDbType.Int, 0, "год_постройки"));
            HouseAdapter.InsertCommand.Parameters.Add(new SqlParameter("@тип_материала", SqlDbType.NVarChar, 50, "тип_материала"));
            SqlParameter HouseParameter = HouseAdapter.InsertCommand.Parameters.Add("@id_дома", SqlDbType.Int, 0, "id_дома");
            HouseParameter.Direction = ParameterDirection.Output;
            sqlConnection.Open();
            HouseAdapter.Fill(HouseTable);
            flatGridHouse.ItemsSource = HouseTable.DefaultView;
            sqlConnection.Close();

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand comm3 = new SqlCommand($"select max(id_дома) from dbo.Дом", sqlConnection);
            SqlCommand comm4 = new SqlCommand($"select max(id_квартиры) from Квартира", sqlConnection);

            sqlConnection.Open();
            int idHouse = (int)comm3.ExecuteScalar();
            int idFlat = (int)comm4.ExecuteScalar();

            SqlTransaction transaction = sqlConnection.BeginTransaction("UpdateTransaction1");
            try
            {

                SqlCommand sqlcmd2 = sqlConnection.CreateCommand();
                sqlcmd2.Transaction = transaction;
                sqlcmd2.CommandText = "INSERT into dbo.Дом (id_дома, номер_дома, год_постройки, тип_материала) Values (@idHouse, @nubmHouse, @year, @material)";
                sqlcmd2.Parameters.AddWithValue("@idHouse", idHouse + 1);
                sqlcmd2.Parameters.AddWithValue("@nubmHouse", HouseNmberBox.Text.Trim());
                sqlcmd2.Parameters.AddWithValue("@year", YearBox.Text);
                sqlcmd2.Parameters.AddWithValue("@material", MaterialBox.Text);
                sqlcmd2.ExecuteNonQuery();


                SqlCommand sqlcmd3 = sqlConnection.CreateCommand();
                sqlcmd3.Transaction = transaction;

                sqlcmd3.CommandText = "INSERT into dbo.Квартира (id_квартиры, номер_квартиры, id_дома, количество_комнат, балкон, фото) Values (@idFlat, @numbFlat, @idHouse1, @room, @balcony, @photo)";
                sqlcmd3.Parameters.AddWithValue("@idFlat", idFlat + 1);
                sqlcmd3.Parameters.AddWithValue("@numbFlat", FlatNmberBox.Text.Trim());
                sqlcmd3.Parameters.AddWithValue("@idHouse1", idHouse + 1);
                sqlcmd3.Parameters.AddWithValue("@room", RoomNmberBox.Text.Trim());
                sqlcmd3.Parameters.AddWithValue("@balcony", BalconyBox.Text);
                sqlcmd3.Parameters.AddWithValue("@photo", LoadedImagePath);

                sqlcmd3.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception) { MessageBox.Show("Ошибка отката транзакции"); }

            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void FlatDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (flatGridFlat.SelectedItems != null)
            {
                for (int i = 0; i < flatGridFlat.SelectedItems.Count; i++)
                {
                    if (flatGridFlat.SelectedItems[i] is DataRowView datarowView)
                    {
                        DataRow dataRow = datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
        }

        string LoadedImagePath;
        private void LoadImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Image files (*.png;*.jpg)|*.png;*.jpg",
                InitialDirectory = System.IO.Directory.GetCurrentDirectory()
            };
            if (dlg.ShowDialog() == true)
            {
                LoadedImagePath = dlg.FileName;
                SelectedImageText.Text = System.IO.Path.GetFileName(dlg.FileName);
            }
            else
            {
                LoadedImagePath = null;
                SelectedImageText.Text = "";
            }
        }
    }
}
