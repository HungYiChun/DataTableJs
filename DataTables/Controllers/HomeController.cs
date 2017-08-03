using DataTables.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTables.Controllers
{
    public class HomeController : Controller
    {
        private DataTablesModel db = new DataTablesModel();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployees()
        {
            List<Employees> data = db.Employees.ToList();
            return Json(new { data = data }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ChildRows()
        {
            return View();
        }

        public ActionResult FormInputs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FormInputs(List<Employees> employeesList)
        {
            foreach (Employees item in employeesList)
            {
                Employees temp = db.Employees.FirstOrDefault(x => x.EmployeeId == item.EmployeeId);

                temp.Title = item.Title;
                temp.Address = item.Address;
                temp.City = item.City;
                temp.PostalCode = item.PostalCode;
                temp.PostalCode = item.Country;

                db.Entry(temp).State = EntityState.Modified;
            }
            db.SaveChanges();

            return View();
        }

        public ActionResult CustomTable()
        {
            return View(db.Employees.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}