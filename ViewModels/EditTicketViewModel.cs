﻿using System;
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
using WpfApp.Views;

namespace WpfApp.ViewModels
{
    public class EditTicketViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
       

        private readonly TicketService _ticketService;
        private Ticket _ticket;
        public ICommand SaveCommand { get; }

        public Ticket Ticket
        {
            get
            {
                return _ticket;
            }
            set
            {
                _ticket = value;
                OnPropertyChanged(nameof(Ticket));  
            }
        }

        public bool IsOpen
        {
            get
            {
                return Ticket.Status == "Open";
            }
            set
            {
                if (value)
                {
                    Ticket.Status = "Open";
                }
                OnPropertyChanged(nameof(IsOpen));
                OnPropertyChanged(nameof(IsInProgress));
                OnPropertyChanged(nameof(IsClosed));
            }
        }

        public bool IsInProgress
        {
            get
            {
                return Ticket.Status == "In Progress";
            }
            set
            {
                if(value)
                {
                    Ticket.Status = "In Progress";
                }
                OnPropertyChanged(nameof(IsInProgress));
                OnPropertyChanged(nameof(IsOpen));
                OnPropertyChanged(nameof(IsClosed));
                OnPropertyChanged(nameof(IsOpenEnabled));
            }
        }

        public bool IsOpenEnabled
        {
            get
            {
                return Ticket.Status != "In Progress"; // Disable if "In Progress" is selected
            }
        }

        public bool IsClosed
        {
            get
            {
                return Ticket.Status == "Closed";
            }
            set
            {
                if(value)
                {
                    Ticket.Status = "Closed";
                }
                OnPropertyChanged(nameof(IsClosed));
                OnPropertyChanged(nameof(IsOpen));
                OnPropertyChanged(nameof(IsInProgress));
            }
        }


        public EditTicketViewModel(Ticket ticket)
        {
            _ticketService = new TicketService();
            Ticket = ticket;
            
            SaveCommand = new RelayCommand(SaveTicket, CanSaveTicket);
            if (IsClosed)
            {
                MainWindow mainWindow = new MainWindow(Ticket.UserId);
                mainWindow.Show();
            }
        }

        private bool CanSaveTicket(object obj)
        {
            
            
            return true;
        }

        private async void SaveTicket(object obj)
        {
            await _ticketService.UpdateTicketStatus(Ticket.Id, Ticket.Status);

            if(obj is Window EditTicket)
            {
                EditTicket.Close();
            }
            MainWindow mainWindow = new MainWindow(Ticket.UserId);
            mainWindow.Show();

           
        }

        protected void OnPropertyChanged(string propertyName) =>
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
