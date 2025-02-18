using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.Models;
using WpfApp.ViewModels;
using WpfApp.Views;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _userId;
        public MainWindow()
        {
           
            InitializeComponent();
        }

        public MainWindow(int id) : this()
        {
            _userId = id;
            DataContext = new MainViewModel(_userId);
        }

        private void AddTicket_click(object sender, RoutedEventArgs e)
        {
            AddTicket addTicket = new AddTicket(_userId);
            addTicket.Show();

        }

        private void EditTicket_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Ticket ticket)
            {
                EditTicket editTicket = new EditTicket(ticket);
                editTicket.Show();
            }
        }
    }
}