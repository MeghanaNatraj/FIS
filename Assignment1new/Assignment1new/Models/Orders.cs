using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1new.Models
{
    //[Table("AssignmentDB")]
    public class Orders
    {
        //[Key]
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public double Amt { get; set; }
    }
}