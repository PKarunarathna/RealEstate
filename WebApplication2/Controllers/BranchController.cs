using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BranchController : Controller
    {
        private RealEstateContext objDataContext = new RealEstateContext();
        // GET: Branch
        
        public ActionResult Index()
        {
            List<Branch> branches = objDataContext.Branches.ToList();
            return View(branches);
        }

        //Insert branch details
        //Create action to view the insert form
        public ActionResult Create()
        {
            return View();
        }
        //Create action to insert new branch details to table
        [HttpPost]
        public ActionResult Create(Branch branch)
        {
            objDataContext.Branches.Add(branch);
            objDataContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}