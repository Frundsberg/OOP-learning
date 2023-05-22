using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB11
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\LAB11\db.accdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void InsertDataButton_Click(object sender, EventArgs e)
        {
            // Отримуємо дані з текстових полів
            string departure = departureTextBox.Text;
            string destination = destinationTextBox.Text;
            decimal price = decimal.Parse(priceTextBox.Text);
            string airline = airlineTextBox.Text;
            int flightId = int.Parse(flightIdTextBox.Text); // Отримання значення Id рейсу з текстового поля
            

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Запит на вставку даних
                string insertQuery = "INSERT INTO Рейси (Id, Місце_відправлення, Місце_прибуття, Ціна, Авіакомпанія) VALUES (?, ?, ?, ?, ?)";
                // Виконуємо команду з параметрами
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@p0", flightId);
                    command.Parameters.AddWithValue("@p1", departure);
                    command.Parameters.AddWithValue("@p2", destination);
                    command.Parameters.AddWithValue("@p3", price);
                    command.Parameters.AddWithValue("@p4", airline);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Дані успішно вставлені до бази даних.");
            }
        }


        private void DisplayDataButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Отримуємо дані з бази даних
                DataTable dataTable = RetrieveData(connection);

                // Відображаємо дані в DataGridView
                dataGridView.DataSource = dataTable;
            }
        }

        private DataTable RetrieveData(OleDbConnection connection)
        {
            // Запит на отримання даних
            string selectQuery = "SELECT * FROM Рейси";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, connection))
            {
                // Створюємо нову таблицю
                DataTable dataTable = new DataTable();

                // Заповнюємо таблицю даними з бази даних
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Звіт 1: Середня ціна рейсу
                string reportQuery1 = "SELECT AVG(Ціна) AS Середня_ціна FROM Рейси";

                using (OleDbCommand command = new OleDbCommand(reportQuery1, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        StringBuilder report1 = new StringBuilder();

                        // Читаємо дані і формуємо звіт
                        if (reader.Read())
                        {
                            decimal averagePrice = (decimal)reader["Середня_ціна"];
                            report1.AppendLine($"Середня ціна рейсу: {averagePrice:C}");
                        }

                        // Виводимо звіт 1 у RichTextBox
                        reportRichTextBox.Text = report1.ToString();
                    }
                }

                // Звіт 2: Звіт за ID рейсу
                string reportQuery2 = "SELECT * FROM Рейси WHERE Id = ?";

                using (OleDbCommand command = new OleDbCommand(reportQuery2, connection))
                {
                    int flightId = int.Parse(searchTextBox.Text); // Значення ID для пошуку
                    command.Parameters.AddWithValue("@p0", flightId);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        StringBuilder report2 = new StringBuilder();

                        // Читаємо дані і формуємо звіт
                        while (reader.Read())
                        {
                            string flightDeparture = reader["Місце_відправлення"].ToString();
                            string flightDestination = reader["Місце_прибуття"].ToString();
                            decimal flightPrice = (decimal)reader["Ціна"];
                            string flightAirline = reader["Авіакомпанія"].ToString();

                            report2.AppendLine($"ID рейсу: {flightId}");
                            report2.AppendLine($"Місце відправлення: {flightDeparture}");
                            report2.AppendLine($"Місце прибуття: {flightDestination}");
                            report2.AppendLine($"Ціна: {flightPrice:C}");
                            report2.AppendLine($"Авіакомпанія: {flightAirline}");
                            report2.AppendLine();
                        }

                        // Виводимо звіт 2 у RichTextBox
                        reportRichTextBox2.Text = report2.ToString();
                    }
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int searchCriteria = int.Parse(searchTextBox.Text);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Запит на пошук даних за критерієм (ID)
                string searchQuery = "SELECT * FROM Рейси WHERE Id = ?";

                using (OleDbCommand command = new OleDbCommand(searchQuery, connection))
                {
                    command.Parameters.AddWithValue("@p0", searchCriteria);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        StringBuilder searchResults = new StringBuilder();

                        // Читаємо дані і формуємо результати пошуку
                        while (reader.Read())
                        {
                            string flightId = reader["Id"].ToString();
                            string flightDeparture = reader["Місце_відправлення"].ToString();
                            string flightDestination = reader["Місце_прибуття"].ToString();
                             int   flightPrice = (int)reader["Ціна"];
                            string flightAirline = reader["Авіакомпанія"].ToString();

                            searchResults.AppendLine($"ID рейсу: {flightId}");
                            searchResults.AppendLine($"Місце відправлення: {flightDeparture}");
                            searchResults.AppendLine($"Місце прибуття: {flightDestination}");
                            searchResults.AppendLine($"Ціна: {flightPrice:C}");
                            searchResults.AppendLine($"Авіакомпанія: {flightAirline}");
                            searchResults.AppendLine();
                        }

                        // Виводимо результати пошуку у RichTextBox
                        searchResultsRichTextBox.Text = searchResults.ToString();
                    }
                }
            }
        }

       
    }
}