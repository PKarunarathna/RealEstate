using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Rent
    {
        [Key]
        public string PropertyNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Ptype{ get; set; }
        public int Rooms { get; set; }

        [ForeignKey]
        public int RefRoomNo { get; set; }

        [ForeignKey("Staff")]
        public int StaffRef { get; set; }
        public Staff RefStaffNo { get; set; }

        [ForeignKey("Branch")]
        public int BranchRef { get; set; }
        public Branch RefBranchNo { get; set; }

        public int Rent1 { get; set; }

    }
}