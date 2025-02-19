using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp.Commands;
using WpfApp.Models;
using WpfApp.Services;

namespace WpfApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private string _statusMessage;
        public event PropertyChangedEventHandler? PropertyChanged;
      
        private readonly TicketService _ticketService;
        public ICommand LoginCommand { get; set; }

        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string StatusMessage
        {
            
            set
            {
                _statusMessage = value;
                OnPropertyChanged(nameof(StatusMessage));
            }
        }

        public LoginViewModel()
        {
            _ticketService = new TicketService();
           
            LoginCommand = new RelayCommand(LoginUser, CanLoginUser);
           
        }

        private bool CanLoginUser(object obj)
        {
            return true;
        }

        private async void LoginUser(object obj)
        {

            //var user = _authService.Authenticate(UserName, Password);
            var user = new User
            {
                UserName = UserName,
                Password = Password
            };
            var exUser =await _ticketService.LoginUser(user);

            if (exUser != null)
            {
                MessageBox.Show("login sucess");
                StatusMessage = "Login Successfull";
                MainWindow mainWindow = new MainWindow(exUser.Id);
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("login not sucess");
                StatusMessage = "Invalid username or password";
            }
        }

       


        protected void OnPropertyChanged(string propertyName) =>
       PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
