using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp.Commands;
using WpfApp.Services;

namespace WpfApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private string _statusMessage;
        public event PropertyChangedEventHandler? PropertyChanged;
        private readonly AuthService _authService;
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
            _authService = new AuthService();
            LoginCommand = new RelayCommand(LoginUser, CanLoginUser);
           
        }

        private bool CanLoginUser(object obj)
        {
            return true;
        }

        private void LoginUser(object obj)
        {
            MessageBox.Show("login user ufncrtion");
            var user = _authService.Authenticate(UserName, Password);

            if (user != null)
            {
                MessageBox.Show("login sucess");
                StatusMessage = "Login Successfull";
                MainWindow mainWindow = new MainWindow(user.Id);
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
