using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    [Table("Rent_tbl")]
    public class Rent
    {
        [Key]
        public string PropertyNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Ptype{ get; set; }
        public int Rooms { get; set; }

        [ForeignKey("Owner")]
        public string OwnerRef { get; set; }
        public virtual Owner OwnerNo { get; set; }

        [ForeignKey("Staff")]
        public string StaffRef { get; set; }
        public  Staff StaffNo { get; set; }

        [ForeignKey("Branch")]
        public string BranchRef { get; set; }
        public virtual Branch BranchNo { get; set; }
        
        public int Rent1 { get; set; }

    }
}