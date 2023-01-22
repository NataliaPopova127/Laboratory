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

namespace LabolatoryApp.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
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


        private void btnSignInHistory_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new SignInHistoryOfUsersPage();
        }

        private void btnDataOfMaterial_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new DataOfMaterialPage();
        }
    }
}
