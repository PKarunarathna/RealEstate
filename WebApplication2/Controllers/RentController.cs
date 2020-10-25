using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class RentController : Controller
    {
        private RealEstateContext objDataContext = new RealEstateContext();
        public ActionResult Index()
        {
            List<Rent> rents = objDataContext.Rents.ToList();
            return View(rents);
        }

        //Insert Department details
        //Create action to view the insert form
        public ActionResult Create()
        {
            ViewBag.branchDetails = objDataContext.Branches;
            ViewBag.ownerDetails = objDataContext.Owners;
            ViewBag.stafftDetails = objDataContext.Staffs;
            return View();
        }
        //Create action to insert new rent details to table
        [HttpPost]
        public ActionResult Create(Rent rent)
        {
            objDataContext.Rents.Add(rent);
            objDataContext.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult Details(string pptyno)
        {
            Rent rent = objDataContext.Rents
                .SingleOrDefault(x => x.PropertyNo == pptyno);
            return View(rent);
        }



        public ActionResult Update(string pptyno)
        {
            ViewBag.Details = new SelectList(objDataContext.Rents, "PropertyNo", "Ptype");
            Rent rent = objDataContext.Rents
                 .SingleOrDefault(x => x.PropertyNo == pptyno);
            return View(rent);
        }

        [HttpPost]
        public ActionResult Update(string pptyno,Rent UpdatedRent)
        {
            Rent rent = objDataContext.Rents
                 .SingleOrDefault(x => x.PropertyNo == pptyno);
            rent = UpdatedRent;
            objDataContext.SaveChanges();
            return RedirectToAction("Index");
            
        }



        public ActionResult Delete(string pptyno)
        {
            Rent rent = objDataContext.Rents
                .SingleOrDefault(x => x.PropertyNo == pptyno);
            return View(rent);
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteRent(string pptyno)
        {
            Rent rent = objDataContext.Rents
                .SingleOrDefault(x => x.PropertyNo == pptyno);
            objDataContext.Rents.Remove(rent);
            return RedirectToAction("Index");
        }





    }
}