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
            List<Branch> Allbranches = objDataContext.Branches.ToList();
            return View(Allbranches);
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





        public ActionResult Details(string branchno)
        {
           Branch branch = objDataContext.Branches
                .SingleOrDefault(x => x.BranchNo == branchno);
            return View(branch);
        }



        public ActionResult Update(string branchno)
        {
            ViewBag.Details = new SelectList(objDataContext.Branches, "BranchNo", "City");
            Branch branch = objDataContext.Branches
               .SingleOrDefault(x => x.BranchNo == branchno);
            return View(branch);
        }

        [HttpPost]
        public ActionResult Update(string branchno, Branch Updatedbranch)
        {
            Branch branch = objDataContext.Branches
                 .SingleOrDefault(x => x.BranchNo == branchno);
            branch = Updatedbranch;
            objDataContext.SaveChanges();
            return RedirectToAction("Index");

        }



        public ActionResult Delete(string branchno)
        {
            Branch branch = objDataContext.Branches
               .SingleOrDefault(x => x.BranchNo == branchno);
            return View(branch);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteBranch(string branchno)
        {
            Branch branch = objDataContext.Branches
               .SingleOrDefault(x => x.BranchNo == branchno);
            objDataContext.Branches.Remove(branch);
            return RedirectToAction("Index");
        }



















    }
}