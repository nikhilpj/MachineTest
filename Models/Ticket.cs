using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Models
{
    public  class Ticket: INotifyPropertyChanged
    {
        private int _id;
        private int _userId;
        private string _title;
        private string _description;
        private string _status;
        public int Id { get {
            return _id;
            }

            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        
        }
            
        public int UserId { get; set; }
        public string Title { get {
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
        public string Status
        {
            get
            { 
                return _status; 
            }
        
            set
            {
                _status = value;
                //OnPropertyChanged(nameof(Status));
            }
        }

        public bool isEditable
        {
            get
            {
                return Status != "Closed";
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
