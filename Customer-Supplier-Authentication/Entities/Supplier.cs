using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Supplier_Authentication.Entities
{
    public class Supplier
    {
        public Supplier()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
