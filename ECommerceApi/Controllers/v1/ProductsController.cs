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
		/// List all users
		/// </summary>
		/// <returns>User list</returns>
		[HttpGet]
		[ProducesResponseType(typeof(List<Product>), 200)]
		public async Task<IActionResult> Get()
		{
			var products = await _context.Product.ToListAsync();

			return Success("Products listed.", null, products);
		}

	}
}

