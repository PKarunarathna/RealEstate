using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Staff
    {
        [Key]
        public string StaffNo { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Position{ get; set; }
        public date DOB { get; set; }
        public int Salary { get; set; }
         
        [ForeignKey("Branch")]
        public int BranchRef { get; set; }
        public Branch Branch_BranchNo { get; set; }




        

    }
}