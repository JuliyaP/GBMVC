using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DZ_Pogorelova.Models
{
    public class Employee
    {
       
        public int Id { get; set; }
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }
        [Display(Name = "Должность")]
        public string Position { get; set; }
        [Display(Name = "Личная карточка")]
        public string PersonCard { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }

    }
}