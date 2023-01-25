using LabolatoryApp.Models.Entity;
using LabolatoryApp.View.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabolatoryApp.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TakeBiomaterialPage.xaml
    /// </summary>
    public partial class TakeBiomaterialPage : Page
    {
        public TakeBiomaterialPage()
        {
            InitializeComponent();
            using (LabolatoryDBEntities context = new LabolatoryDBEntities())
            {
                var order = context.Order.ToList();
                tbCodeMaterial.Text = (order.LastOrDefault().Code + 1).ToString();
            }
        }

        private void btnMakeOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int code = Convert.ToInt32(tbCodeMaterial.Text);
                string surname = tbSurnamePatient.Text;
                string name = tbNamePatient.Text;
                var lastname = tbLastnamePatient.Text;
                if(lastname == "")
                {
                    lastname = null;
                }

                using (LabolatoryDBEntities context = new LabolatoryDBEntities())
                {
                    var patient = context.Patient.FirstOrDefault(p => p.Name == name
                    && p.Surname == surname && p.Lastname == lastname);

                    if (context.Order.FirstOrDefault(o => o.Code == code) != null)
                        throw new Exception("Заказ с таким кодом уже существует");
                    else
                    {
                        if (patient == null)
                        {
                            var result = MessageBox.Show("Клиента с таким" +
                                " именем не существует. Добавить?", "Ошибка", MessageBoxButton.YesNo);
                            if (result == MessageBoxResult.Yes)
                            {
                                new AddPatientWindow().ShowDialog();
                            }
                        }
                        else
                        {
                            Random random = new Random();
                            context.Order.Add(new Order {Code = code,
                                DateOfCreate = DateTime.Now, StatusOrder_Id = 1,
                                StatusService_Id = 1, AmountDayForCreate = random.Next(1, 31) });

                            
                            context.SaveChanges();
                            MessageBox.Show("Запись добавлена");
                        }
                    } 
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
