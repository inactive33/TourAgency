using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourAgency.Entities;
using TourAgency.Models;

namespace TourAgency.ViewModel
{
    internal class SignInVM : BindableBase
    {
        private string _login;
        private string _password;
        private string _message;
        readonly private SignInModel _userModel;

        public SignInVM()
        {
            // Извлекаем строку подключения через метод GetContext()
            var connectionString = GetConnectionString();

            if (string.IsNullOrEmpty(connectionString))
            {
                Message = "Ошибка: строка подключения не найдена.";
                return;
            }

            // Инициализируем модель с извлеченной строкой подключения
            _userModel = new SignInModel(connectionString);
        }

        // Свойства для привязки данных
        public string Login
        {
            get { return _login; }
            set { SetProperty(ref _login, value); }
        }

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        // Команда для выполнения входа
        public DelegateCommand LoginCommand => new DelegateCommand(ExecuteLogin);
        private void ExecuteLogin()
        {
            // Пытаемся проверить пользователя
            if (_userModel.ValidateUser(_login, _password))
            {
                Message = "Login successful!";
            }
            else
            {
                Message = "Invalid login or password.";
            }
        }
        // Метод для получения строки подключения
        private string GetConnectionString()
        {
            try
            {
                // Пробуем получить строку подключения через контекст
                var context = TourAgencyEntities.GetContext();
                var connectionString = context.Database.Connection.ConnectionString;
                return connectionString;
            }
            catch (Exception ex)
            {
                // В случае ошибки возвращаем null или сообщение об ошибке
                Message = "Ошибка при получении строки подключения: " + ex.Message;
                return null;
            }
        }
    }
}
