using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeRecordDAL.Entities;
using EmployeeRecordBLL;

namespace EmployeeRecordPL.Controllers
{
    public class EmployeeController : Controller
    { 
        EmployeeBLL DataAccess = new EmployeeBLL();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EmployeeList()
        {
            var employeeList = DataAccess.GetEmployeeList().ToList();
            return View(employeeList);
        }

        [HttpGet]
        public ActionResult EmployeeOption(int Id = 0)
        {
            var employee = DataAccess.GetEmploye(Id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult EmployeeOption(Employee employee)
        {
            var _employee = DataAccess.EmployeeOption(employee);
            if(_employee.Validate.MethodStatu)
                return RedirectToAction("EmployeeList");
            else
                return View(_employee);
        }

        [HttpGet]
        public ActionResult CustomSearch()
        {
            ViewBag.emplooyeList = null;
            return View();
        }

        [HttpPost]
        public ActionResult CustomSearch(CustomSearch customSearch)
        {
            var result =  DataAccess.CustomSearch(customSearch);
            ViewBag.emplooyeList = result.EmployeeList == null ? null : result.EmployeeList;
            return View(result);
        }
    }
}