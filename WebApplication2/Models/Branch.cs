using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Branch
    {
        [Key]
        public string BranchNo { get; set; }

        public String Street { get; set; }

        public String City{ get; set; }

        public int Postcode { get; set; }



    }
}