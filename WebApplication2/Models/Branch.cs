using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    [Table("Branch_tbl")]
    public class Branch
    {
        
        [Key]
        public string BranchNo { get; set; }

        public String Street { get; set; }

        public String City{ get; set; }

        public string Postcode { get; set; }



    }
}