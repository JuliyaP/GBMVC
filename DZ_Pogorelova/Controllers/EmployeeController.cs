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
            
            return View(Emloyee.empl);
        }



        public ActionResult Details(int id)
        {
            return View(Emloyee.empl.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}