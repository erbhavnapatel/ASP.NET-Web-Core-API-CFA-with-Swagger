using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Supplier_Authentication.Entities
{
    public class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
