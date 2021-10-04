using Customer_Supplier_Authentication.Entities;
using Customer_Supplier_Authentication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Supplier_Authentication.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly OrderEntitiesContext _context;

        public ProductRepository(OrderEntitiesContext context)
        {
            this._context = context;
        }

        public async Task<Product> DeleteProduct(int productId)
        {
            var product = await _context.Product.FindAsync(productId);
            if (product == null)
            {
                return null;
            }
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> FindProductById(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return null;
            }
            return product;
        }

        public async Task<List<ProductModel>> GetProducts()
        {
            var products = new List<ProductModel>();
            var allProducts = await _context.Product.ToListAsync();
            if (allProducts.Any() == true)
            {
                foreach (var p in allProducts)
                {
                    products.Add(new ProductModel()
                    {
                        Id = p.Id,
                        ProductName = p.ProductName,
                        Package = p.Package,
                        UnitPrice = p.UnitPrice,
                        IsDiscontinued = p.IsDiscontinued,
                        SupplierId = p.SupplierId
                    });
                }
            }
            return products;
        }

        public async Task UpdateProduct(ProductModel productModel)
        {
            var newProduct = new Product()
            {
                ProductName = productModel.ProductName,
                SupplierId = productModel.SupplierId,
                UnitPrice = productModel.UnitPrice,
                Package = productModel.Package,
                IsDiscontinued = productModel.IsDiscontinued
            };

            _context.Product.Update(newProduct);
            await _context.SaveChangesAsync();
        }
    }
}
