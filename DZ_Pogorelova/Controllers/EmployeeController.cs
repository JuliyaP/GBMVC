using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DZ_Pogorelova.Models;

namespace DZ_Pogorelova.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> empl = new List<Employee>
                    {
                        new Employee(){ Id=1, FirstName = "Jack", Age = 8, LastName = "Smith",MiddleName = "Ivanovich",PersonCard="Horooch",Position = "Developer" },
                        new Employee(){ Id=2, FirstName = "Ваня", Age = 18, LastName = "Боярышкин",MiddleName = "Камекгбекович",PersonCard="Horooch",Position = "Disigner" },
                        new Employee(){ Id=3, FirstName = "Василий", Age = 81, LastName = "Трошкин",MiddleName = "Петрович",PersonCard="Horooch",Position = "Analytic" } };
            return View(empl);
        }
    }
}