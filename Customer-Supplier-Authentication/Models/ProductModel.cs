using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Supplier_Authentication.Models
{
    public class ProductModel
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string ProductName { get; set; }
        
        public int SupplierId { get; set; }
        
        [Required]
        public decimal? UnitPrice { get; set; }
        
        public string Package { get; set; }
        
        public bool IsDiscontinued { get; set; }
    }
}
