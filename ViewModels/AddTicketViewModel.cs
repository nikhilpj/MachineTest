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
    public class AddTicketViewModel : INotifyPropertyChanged
    {
        private readonly TicketService _ticketService;

        public event PropertyChangedEventHandler? PropertyChanged;

        private string _title;
        private string _description;
        private int _userId;
        private string _statusMessage;
        public ICommand SubmitCommand { get; }


        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public string StatusMessage
        {
            get
            {
                return _statusMessage;
            }
            set
            {
                _statusMessage = value;
                OnPropertyChanged(nameof(StatusMessage));
            }
        }

        public AddTicketViewModel(int userId)
        {
            _userId = userId;
            _ticketService = new TicketService();
            SubmitCommand = new RelayCommand(SubmitTicket,CanSubmitTicket);
        }

        private bool CanSubmitTicket(object obj)
        {
            return true;
        }

        private async void SubmitTicket(object obj)
        {
            var newTicket = new Ticket
            {
                UserId = _userId,
                Title = Title,
                Description = Description,
                Status = "Open"
            };

            bool isSucess = await _ticketService.CreateTicket(newTicket);
            if (isSucess)
            {
                StatusMessage = "Ticket added successfully";
                MessageBox.Show(StatusMessage);
                Application.Current.Windows[2].Close();
            }
            else
            {
                StatusMessage = "error in adding Ticket";
                MessageBox.Show(StatusMessage);
            }


        }

        protected void OnPropertyChanged(string propertyName) =>
     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
