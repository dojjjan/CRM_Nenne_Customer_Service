using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Nenne_Customer_API.Models
{
    public partial class Customer
    {
        public int? CustomerId { get; set; }
        [StringLength(255)]
        public string CustomerName { get; set; }
        [StringLength(255)]
        public string CustomerAddress { get; set; }
        [StringLength(64)]
        public string CustomerPhone { get; set; }
        [StringLength(500)]
        public string CustomerDescription { get; set; }
        [StringLength(255)]
        public string CustomerContact { get; set; }
    }
}
