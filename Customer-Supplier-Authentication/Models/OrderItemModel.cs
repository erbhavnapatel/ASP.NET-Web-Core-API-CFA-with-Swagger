using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Supplier_Authentication.Models
{
    public class OrderItemModel
    {
        [Required(ErrorMessage = "Cannot be blank")]
        //[MaxLength(5)]
        public int Id { get; set; }
        [Required]
        //[MaxLength(5)]
        public int OrderId { get; set; }
        [Required]
        //[MaxLength(5)]
        public int ProductId { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
