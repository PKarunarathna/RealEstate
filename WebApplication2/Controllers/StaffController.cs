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
            ViewBag.BranchDetails = objDataContext.Branches;
            //ViewBag.BranchDetails = new SelectList(objDataContext.Staffs,"BranchNo","City");
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

        public ActionResult Details(string staffno)
        {
           Staff staff = objDataContext.Staffs
                .SingleOrDefault(x => x.StaffNo == staffno);
            return View(staff);
        }



        public ActionResult Update(string staffno)
        {
            // ViewBag.Details = new SelectList(objDataContext.Rents, "PropertyNo", "Ptype");
            Staff staff = objDataContext.Staffs
                 .SingleOrDefault(x => x.StaffNo == staffno);
            return View(staff);
        }

        [HttpPost]
        public ActionResult Update(string staffno, Staff UpdatedStaff)
        {
            Staff staff = objDataContext.Staffs
                   .SingleOrDefault(x => x.StaffNo == staffno);
            staff= UpdatedStaff;
            objDataContext.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Delete(string staffno)
        {
            Staff staff = objDataContext.Staffs
                  .SingleOrDefault(x => x.StaffNo == staffno);
            return View(staff);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteRent(string staffno)
        {
            Staff staff = objDataContext.Staffs
                 .SingleOrDefault(x => x.StaffNo == staffno);
           
            objDataContext.Staffs.Remove(staff);
            return RedirectToAction("Index");
        }



    }
}