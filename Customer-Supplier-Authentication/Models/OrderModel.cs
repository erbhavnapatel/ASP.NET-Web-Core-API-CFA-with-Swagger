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
        //[MaxLength(5)]
        public int Id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        //[MaxLength(7)]
        public string OrderNumber { get; set; }
        [Required]
        //[MaxLength(5)]
        public int CustomerId { get; set; }
        [Required]
        //[MaxLength(4)]
        public decimal? TotalAmount { get; set; }
    }
}
