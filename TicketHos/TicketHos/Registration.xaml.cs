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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public static TicketEntities ticketEntities = new TicketEntities();
        Patient contextPatient;
        public Registration()
        {
            InitializeComponent();
            contextPatient = new Patient();
            DataContext = contextPatient;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (First_name.Text != "" && Last_name.Text != "" && Middle_name.Text != "" && Polis.Text != "")
            {
                try
                {
                    contextPatient.FirstName = First_name.Text;
                    contextPatient.LastName = Last_name.Text;
                    contextPatient.MiddleName = Middle_name.Text;
                    contextPatient.DateOfBirth = Convert.ToDateTime(DayOfBirth.Text);
                    contextPatient.Police = Convert.ToString(Polis.Text);
                    ticketEntities.Patient.Add(contextPatient);
                    ticketEntities.SaveChanges();
                    NavigationService.Navigate(new DocChoice(contextPatient));
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста заполните все поля", "Error!");
            }
        }
    }
}
