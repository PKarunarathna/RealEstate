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

    }
}