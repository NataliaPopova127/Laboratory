using LabolatoryApp.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace LabolatoryApp.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Laborant.xaml
    /// </summary>
    public partial class AssistantWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int second = 0;
        int minute = 0;
        int hour = 0;
        bool isWarning = false;
        public AssistantWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0,0,1);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            second++;
            tbTimer.Text = $"{hour}:{minute}:{second}";
            if (second == 59)
            {
                minute++;
                second = 0;
            }
            if(minute == 59)
            {
                hour++;
                minute = 0;
            }   
            if(minute == 5 && isWarning == false)
            {
                isWarning = true;
                MessageBox.Show("Осталось 5 минут до завершения сеанса!");
            }
            if(minute == 10)
            {
                new AuthorizationWindow().Show();
                Close();
            }
        }
        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            new AuthorizationWindow().Show();
            Close();
        }
        private void btnMakeReport_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new MakeReportPage();
        }
        private void btnTakeBiomaterial_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new TakeBiomaterialPage();
        }

        private void btnViewListPatient_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new PatientListPage();
        }
    }
}
