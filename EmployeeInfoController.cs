using eScout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eScout.Controllers
{
    public class EmployeeInfoController : Controller
    {
       

        // GET: EmployeeInfo/Create
        public ActionResult EmployeeInfo()
        {
            return View();
        }

        // POST: EmployeeInfo/Create
        [HttpPost]
        public ActionResult EmployeeInfo(EmployeeInfo collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeInfoDb sdb = new EmployeeInfoDb();
                    if (sdb.Emp_Name(collection))
                    {
                        ViewBag.Message = "Employee Details Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        

       

       

      
    }
}
