using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DZ_Pogorelova.Models;

namespace DZ_Pogorelova.Utils
{
    public static class Emloyee
    {
      public static   List<Employee> empl = new List<Employee>
                    {
                        new Employee(){ Id=1, FirstName = "Анна", Age = 8, LastName = "Тимофеева",MiddleName = "Александровна",PersonCard=" Умение работать в коллективе. Целеустремленность, аналитический склад ума. Плюс ответственность и бла-бла-бла",Position = "Developer" },
                        new Employee(){ Id=2, FirstName = "Иван", Age = 18, LastName = "Мурзиков",MiddleName = "Григорьевич",PersonCard="Horooch",Position = "Disigner" },
                        new Employee(){ Id=3, FirstName = "Василий", Age = 81, LastName = "Трошкин",MiddleName = "Петрович",PersonCard="Horooch",Position = "Analytic" } };
    }
}