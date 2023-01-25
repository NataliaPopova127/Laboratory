using LabolatoryApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabolatoryApp.Models
{
    public class PatientModel
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Pasport { get; set; }
        public string Email { get; set; }
        public static PatientModel PatientList(Patient context)
        {
            var pasport = 0;
            if (context.Pasport == null)
                pasport = 0;
            else
                pasport = (int)context.Pasport;
            return new PatientModel()
            {
                Id = context.Id,
                Surname = context.Surname,
                Name = context.Name,
                Lastname = context.Lastname,
                Pasport = pasport,
                Email = context.Email
            };
        }
        public override string ToString()
        {
            return $"id: {Id}\n" +
                $"ФИО: {Surname} {Name} {Lastname}\n" +
                $"Паспортные данные: {Pasport}\n" +
                $"Email: {Email}\n";
        }
    }
}
