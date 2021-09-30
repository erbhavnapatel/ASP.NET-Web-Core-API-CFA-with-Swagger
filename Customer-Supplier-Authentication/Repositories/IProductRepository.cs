using Customer_Supplier_Authentication.Entities;
using Customer_Supplier_Authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Supplier_Authentication.Repositories
{
    public interface IProductRepository
    {
        public Task<Product> FindProductById(int id);
        public Task<List<ProductModel>> GetProducts();
        public Task<Product> DeleteProduct(int productId);
    }
}