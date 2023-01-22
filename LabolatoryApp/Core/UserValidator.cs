using LabolatoryApp.Models.Entity;
using LabolatoryApp.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LabolatoryApp.Core
{
    public class UserValidator
    {
        public static bool UserValidate(string login, string password)
        {
            using (LabolatoryDBEntities context = new LabolatoryDBEntities())
            {
                foreach (var employe in context.Employes)
                {
                    if (login == employe.Login && password == employe.Password)
                    {
                        AuthorizationWindow.Role = employe.RoleId;
                        return true;
                    }
                    return false;
                }
                return false;
            }
            
        }

    }
}
