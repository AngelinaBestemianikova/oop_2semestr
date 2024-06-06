using Lab_11.Model;
using Lab_11.View;
using Lab_11.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Lab_11
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        List<Medcentre> medcentre = new();
        private void OnStartup(object sender, StartupEventArgs e)
        {
            connectToDB();
            MainWindow window = new();
            MainViewModel viewModel = new(medcentre);
            window.DataContext = viewModel;
            window.Show();
        }

        private void connectToDB()
        {
            string sql = "select * from Doctors;";
            SqlConnection connection = null;
            // Создайте объект DataTable для хранения данных из базы данных.
            DataTable dataTable = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            Medcentre cons;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                int id = 1;

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        id++;
                        string name = reader.GetString(0);
                        string spec = reader.GetString(1);
                        string category = reader.GetString(2);
                        string department = reader.GetString(3);
                        string time = reader.GetString(4);
                        DateOnly date = DateOnly.FromDateTime(reader.GetDateTime(5));
                     
                        cons = new(name, spec, category, department, time, date);
                        medcentre.Add(cons);
                    }
                }

                reader.CloseAsync();
            }
        }
    }
}
