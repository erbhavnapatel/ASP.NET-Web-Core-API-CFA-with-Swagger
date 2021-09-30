using Customer_Supplier_Authentication.Entities;
using Customer_Supplier_Authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Supplier_Authentication.Repositories
{
    public interface IOrderRepository
    {
        public Task<Order> FindOrderById(int orderId);
        public Task<List<OrderModel>> GetOrders();
        public Task<Order> DeleteOrder(int orderId);
    }
}