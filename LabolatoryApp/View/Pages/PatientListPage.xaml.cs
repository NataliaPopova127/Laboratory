using LabolatoryApp.Models;
using LabolatoryApp.Models.Entity;
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
    /// Логика взаимодействия для PatientListPage.xaml
    /// </summary>
    public partial class PatientListPage : Page
    {
        public List<String> list = new List<String>();
        public PatientListPage()
        {
            InitializeComponent();
            using(LabolatoryDBEntities context = new LabolatoryDBEntities())
            {
                foreach(var patient in context.Patient)
                {
                    list.Add(PatientModel.PatientList(patient).ToString());
                }    
            }
            lvPatient.ItemsSource = list;
        }

        private void tbFindString_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                using (LabolatoryDBEntities context = new LabolatoryDBEntities())
                {
                    list.Clear();
                    foreach (var patient in context.Patient)
                    {
                        var lastname = "";
                        var email = "";
                        var pasport = 0;
                        if (patient.Lastname == null)
                            lastname = " ";
                        else
                            lastname = patient.Lastname;

                        if (patient.Email == null)
                            email = " ";
                        else
                            email = patient.Email;

                        if (patient.Pasport == null)
                            pasport = 0;
                        else
                            pasport = (int)patient.Pasport;
                        
                        if (patient.Id.ToString().Contains(tbFindString.Text) ||
                            patient.Name.Contains(tbFindString.Text) ||
                        patient.Surname.Contains(tbFindString.Text) ||
                        lastname.Contains(tbFindString.Text) ||
                        pasport.ToString().Contains(tbFindString.Text) ||
                        email.Contains(tbFindString.Text))
                        {
                            list.Add(PatientModel.PatientList(patient).ToString());
                        }
                    }
                }
                lvPatient.ItemsSource = list;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
