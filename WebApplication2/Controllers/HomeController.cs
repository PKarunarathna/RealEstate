using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home

        private RealEstateContext objDataContext = new RealEstateContext ();
        public ActionResult Index()
        {
            List<Staff> AllStaffs = objDataContext.Staffs.ToList();
            return View(AllStaffs);
        }

        public ActionResult StaffNames()
        {
            List<Staff> StaffName = objDataContext.Staffs.ToList();
            return View(StaffName);
        }

        public ActionResult Rent()
        {
            List<Rent> rents = objDataContext.Rents.ToList();
            return View(rents);
        }

        public ActionResult Branch()
        {
            List<Branch> Allbranches = objDataContext.Branches.ToList();
            return View(Allbranches);
        }


        public ActionResult Owner()
        {
            List<Owner> AllOwners = objDataContext.Owners.ToList();
            return View(AllOwners);
        }


        //get staff based on their position
        public ActionResult StaffDetails(string position)
        {
            Staff staff = objDataContext.Staffs
                .SingleOrDefault(x => x.Position == position);
            return View(staff);
        }

        //filter buildings by city
        public ActionResult BuildingInCity(string city)
        {
            List<Rent> rents = objDataContext.Rents.Where(x => x.City == city).ToList();
            return View(rents);
        }
        




















    }
}