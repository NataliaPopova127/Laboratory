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
    /// Логика взаимодействия для LaborantWindow_2.xaml
    /// </summary>
    public partial class AssistantWindow_2 : Window
    {
        public AssistantWindow_2()
        {
            InitializeComponent();
        }

        private void btnAnalizator_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new AnalyzerForAssistantPage();
        }
        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            new AuthorizationWindow().Show();
            Close();
        }
    }
}
