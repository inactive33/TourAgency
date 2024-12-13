using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;

namespace TourAgency.Models
{
    internal class SignInModel
    {
        private readonly string _connectionString;

        // Конструктор принимает строку подключения
        public SignInModel(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool ValidateUser(string login, string password)
        {
            bool isValid = false;

            // Используем DbConnection для создания универсального подключения
            using (DbConnection connection = CreateConnection())
            {
                try
                {
                    connection.Open();

                    // Универсальный SQL запрос для проверки наличия пользователя
                    string query = "SELECT COUNT(1) FROM Users WHERE Login = @Login AND Password = @Password";

                    using (DbCommand command = connection.CreateCommand())
                    {
                        command.CommandText = query;

                        // Параметры запроса
                        DbParameter loginParam = command.CreateParameter();
                        loginParam.ParameterName = "@Login";
                        loginParam.Value = login;
                        command.Parameters.Add(loginParam);

                        DbParameter passwordParam = command.CreateParameter();
                        passwordParam.ParameterName = "@Password";
                        passwordParam.Value = password;
                        command.Parameters.Add(passwordParam);

                        // Выполнение запроса и возврат результата
                        int result = Convert.ToInt32(command.ExecuteScalar());

                        if (result > 0)
                        {
                            isValid = true;  // Пользователь найден
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return isValid;
        }

        private DbConnection CreateConnection()
        {
            // Используем DbProviderFactory для универсальности
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");  // Используем провайдер SQL Server
            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = _connectionString;
            return connection;
        }


    }
}
