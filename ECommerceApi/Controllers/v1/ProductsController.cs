using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApi.Controllers.Base.v1;
using ECommerceApi.Data;
using ECommerceApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECommerceApi.Controllers.v1
{
    public class ProductsController : Basev1ApiController
    {
        private readonly ECommerceDbContext _context;

        public ProductsController(ECommerceDbContext context)
        {
            _context = context;
        }

		/// <summary>
		/// List all products
		/// </summary>
		/// <returns>Product list</returns>
		[HttpGet]
		[ProducesResponseType(typeof(List<Product>), 200)]
		public async Task<IActionResult> Get()
		{
			var products = await _context.Product.ToListAsync();

			return Success("Products listed.", null, products);
		}


		/// <summary>
		/// Get single product by id 
		/// </summary>
		/// <returns>Single product</returns>
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(Product), 200)]
		public async Task<IActionResult> GetProductById(int id)
		{
			var product = await _context.Product.FirstOrDefaultAsync(x=>x.Id == id);

			return Success("Product listed.", null, product);
		}

	}
}

