using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Supplier_Authentication.Models
{
    public class OrderModel
    {
        [Required(ErrorMessage = "Cannot be blank")]
        public int Id { get; set; }
        
        [Required]
        public DateTime OrderDate { get; set; }
        
        [Required]
        public string OrderNumber { get; set; }
        
        [Required]
        public int CustomerId { get; set; }
        
        [Required]
        public decimal? TotalAmount { get; set; }
    }
}
