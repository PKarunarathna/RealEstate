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

       









    }
}