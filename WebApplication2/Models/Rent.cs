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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Property No")]
        public string PropertyNo { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string Ptype { get; set; }
        public int Rooms { get; set; }

        [Display(Name ="OwnerNo")]
        [ForeignKey("Owner")]
        public string OwnerRef { get; set; }
        public virtual Owner Owner { get; set; }

        [Display(Name = "StaffNo")]
        [ForeignKey("Staff")]
        public string StaffRef { get; set; }
        public virtual Staff Staff { get; set; }

        [Display(Name = "BranchNo")]
        [ForeignKey("Branch")]
        public string BranchRef { get; set; }
        public virtual Branch Branch { get; set; }

        public int Rent1 { get; set; }
        public string BranchNo { get; internal set; }
    }

}