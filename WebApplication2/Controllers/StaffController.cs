using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StaffController : Controller
    {
        
        // GET: Staff

        private RealEstateContext objDataContext = new RealEstateContext();
        public ActionResult Index()
        {
            List<Staff> AllStaffs = objDataContext.Staffs.ToList();
            return View(AllStaffs);
        }

        //Insert staff details
        //Create action to view the insert form
        public ActionResult Create()
        {
            return View();
        }
        //Create action to insert new staff details to table
        [HttpPost]
        public ActionResult Create(Staff staff)
        {
            objDataContext.Staffs.Add(staff);
            objDataContext.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}