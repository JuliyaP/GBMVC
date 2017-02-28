using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DZ_Pogorelova.Utils;

namespace DZ_Pogorelova.Controllers
{
    public class EmployeeController : Controller
    {
        
  
        public ActionResult Index()
        {
            
            return View(Employee.empl);
        }



        public ActionResult Details(int id)
        {
            return View(Employee.empl.FirstOrDefault(x => x.Id == id));
        }


        [System.Web.Mvc.HttpGet]
        public ActionResult CreateEmployee()
        {
            

            return View("CreateEmployee");
        }

        

    }
}