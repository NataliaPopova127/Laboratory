using LabolatoryApp.Core;
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
    /// Логика взаимодействия для AuthorizationWinodw.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public static int Role { get; set; }
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var validate = UserValidator.UserValidate(tbLogin.Text, tbPassword.Password);
                if (validate)
                {
                    if (Role == 2)
                        new AccountantWindow().Show();
                    else if (Role == 1)
                        new AdminWindow().Show();
                    else if (Role == 3)
                        new AssistantWindow().Show();
                    else if (Role == 4)
                        new AssistantWindow_2().Show();
                    Close();
                }
                else
                {
                    throw new Exception("Неверный логин или пароль");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenPassword_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
