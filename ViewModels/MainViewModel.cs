using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp.Models;
using WpfApp.Services;

namespace WpfApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly TicketService _ticketService;
        private readonly int _userId;
        private ObservableCollection<Ticket> _tickets;
        public event PropertyChangedEventHandler? PropertyChanged;
      

        public ObservableCollection<Ticket> Tickets
        {
            get
            {
                return _tickets;
            }
            set
            {
                _tickets = value;
                OnPropertyChanged(nameof(Tickets));
            }
        }

       

        public MainViewModel(int userId)
        {
            _userId = userId;
            _ticketService = new TicketService();
            LoadTickets();
        }


        private async void LoadTickets()
        {
            var tickets = await _ticketService.GetUserTickets(_userId);
            Tickets = new ObservableCollection<Ticket>(tickets);
        }





        protected void OnPropertyChanged(string propertyName) =>
       PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
