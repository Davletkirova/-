using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TicketHos
{
    /// <summary>
    /// Логика взаимодействия для DocChoice.xaml
    /// </summary>
    public partial class DocChoice : Page
    {
        Ticket contextTicket;
        public DocChoice(Patient postPatient)
        {
            InitializeComponent();
            contextTicket = new Ticket() { Patient = postPatient};
            DataContext = contextTicket;
            Direction.ItemsSource = Registration.ticketEntities.Specialization.ToList();
            date_Birth.BlackoutDates.Add(new CalendarDateRange(new DateTime(1990, 1, 1), DateTime.Now.AddDays(-1)));
        }



        private void Doc1_Click(object sender, RoutedEventArgs e)
        {
            if (Direction.Text != "" && DoctorsBox.Text != "" && date_Birth.Text != "" && TimeBox.Text != "")
            {
                ChoiseDoctor();
                NavigationService.Navigate(new TicketPatient(contextTicket));
            }
            else
            {
                MessageBox.Show("Введите все данные", "Ошибка");
            }
            Registration.ticketEntities.Ticket.Add(contextTicket);
            Registration.ticketEntities.SaveChanges();
            
        }

        private void Direction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Direction.SelectedItem != null)
            {
                DoctorsBox.ItemsSource =  ((Direction.SelectedItem) as Specialization).Specialist.ToList();
            }
        }

        private void ChoiseDoctor()
        {
            if (Direction.Text != "" && DoctorsBox.Text != "" && date_Birth.Text != "" && TimeBox.Text != "")
            {
                contextTicket.Time = new Time() { Time1 = (TimeSpan)TimeBox.SelectedItem, Date = date_Birth.SelectedDate };
            }
            else
            {
                MessageBox.Show("Введите все данные", "Ошибка");
            }
        }

        private void date_Birth_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var times = new List<TimeSpan>();
            for (int i = 8; i <= 18; i++)
            {
                times.Add(TimeSpan.FromHours(i));
            }
            foreach (var time in times)
            {
                if (Registration.ticketEntities.Time.FirstOrDefault(t => t.Time1.Value == time && t.Date == date_Birth.SelectedDate) != null)
                    continue;
                TimeBox.Items.Add(time);
            }
        }
    }
}
