using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class OwnerController : Controller
    {
        private RealEstateContext objDataContext = new RealEstateContext();
        // GET: Owner
        public ActionResult Index()
        {
            List<Owner> AllOwners = objDataContext.Owners.ToList();
            return View(AllOwners);
        }

        //Add Owner
        //Create action to view the insert form
        public ActionResult Create()
        {
            
            return View();
        }

        //Create action to insert new owner details to table
        [HttpPost]
        public ActionResult Create(Owner owner)
        {
            objDataContext.Owners.Add(owner);
            objDataContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(string ownerno)
        {
           Owner owner = objDataContext.Owners
                .SingleOrDefault(x => x.OwnerNo == ownerno);
            return View(owner);
        }



        public ActionResult Update(string ownerno)
        {
            //ViewBag.Details = new SelectList(objDataContext.Rents, "PropertyNo", "Ptype");
            Owner owner = objDataContext.Owners
               .SingleOrDefault(x => x.OwnerNo == ownerno);
            return View(owner);
        }

        [HttpPost]
        public ActionResult Update(string ownerno, Owner UpdatedOwner)
        {
            Owner owner = objDataContext.Owners
                .SingleOrDefault(x => x.OwnerNo == ownerno);
           owner = UpdatedOwner;
            objDataContext.SaveChanges();
            return RedirectToAction("Index");

        }



        public ActionResult Delete(string ownerno)
        {
            Owner owner = objDataContext.Owners
               .SingleOrDefault(x => x.OwnerNo == ownerno);
            return View(owner);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteRent(string ownerno)
        {
            Owner owner = objDataContext.Owners
               .SingleOrDefault(x => x.OwnerNo == ownerno);
            objDataContext.Owners.Remove(owner);
            return RedirectToAction("Index");
        }












    }
}