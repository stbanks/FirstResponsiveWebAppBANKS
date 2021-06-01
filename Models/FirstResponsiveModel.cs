using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppBANKS.Models
{
    public class FirstResponsiveModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string YourName { get; set; }
        [Required(ErrorMessage = "Please enter your birthday as mm/dd/yyyy")]
        public DateTime Birthday { get; set; }
        //public int AgeLater { get; set; }
        public static DateTime Today = DateTime.Today;
        //public DateTime EndDec = new DateTime(Today.Year, 12, 31);

        public string GrabName()
        {
            return YourName;
        }
        public int CalculateAgeNow()
        {
            int age;
            age = Today.Year - Birthday.Year;
            if (DateTime.Now.DayOfYear < Birthday.DayOfYear)
            {
                age -= 1;
            }
            return age;
        }
        public int CalculateAgeLater()
        {
            int age;
            age = Today.Year - Birthday.Year;
            return age;
        }
    }
}
