using WebApplicationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] {
            new Product {Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1.25M},
            new Product {Id = 2, Name = "Yo Yo", Category = "Toys", Price = 3.25M},
            new Product {Id = 3, Name = "Hammer", Category = "Hardware", Price = 15.25M}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int Id)
        {
            var product = products.FirstOrDefault((p) => p.Id == Id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
