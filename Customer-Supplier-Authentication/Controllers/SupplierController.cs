using Customer_Supplier_Authentication.Entities;
using Customer_Supplier_Authentication.Models;
using Customer_Supplier_Authentication.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customer_Supplier_Authentication.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public SupplierController(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            this._orderRepository = orderRepository;
            this._productRepository = productRepository;
        }

        // GET: api/<SupplierController>
        [HttpGet]
        [Route("~/view-all-orders")]
        public async Task<List<OrderModel>> GetAllOrders()
        {
            return await _orderRepository.GetOrders();
        }

        // GET: api/<SupplierController>/5
        [HttpGet]
        [Route("~/view-all-products")]
        public async Task<List<ProductModel>> GetAllProducts()
        {
            return await _productRepository.GetProducts();
        }

        // GET api/<SupplierController>/5
        [HttpGet("{productId}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var result = await _productRepository.FindProductById(id);
            if (result != null)
            {
                return result;
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete("{productId}")]
        public async Task<ActionResult<Product>> DeleteProduct(int productId)
        {
            var result = await _productRepository.DeleteProduct(productId);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }
    }
}
