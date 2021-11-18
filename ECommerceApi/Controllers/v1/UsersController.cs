using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApi.Controllers.Base.v1;
using ECommerceApi.Data;
using ECommerceApi.Entities;
using ECommerceApi.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApi.Controllers.v1
{
    public class UsersController : Basev1ApiController
    {
        private readonly ECommerceDbContext _context;

        public UsersController(ECommerceDbContext context)
        {
            _context = context;

        }

		/// <summary>
		/// Create a new user
		/// </summary>
		/// <param name="model">User information</param>
		/// <returns>Results</returns>
		[HttpPost]
		[ValidateModel]
		[ProducesResponseType(typeof(ApiReturn<User>), 200)]
		[ProducesResponseType(typeof(ApiReturn<User>), 400)]
		[ProducesResponseType(typeof(ApiReturn<User>), 500)]
		public async Task<IActionResult> Post([FromBody] User model)
		{
			try
			{
				await _context.User.AddAsync(model);
				await _context.SaveChangesAsync();

				return Success("User added successfully.", null, model);
			}
			catch (Exception ex)
			{
				return Error<object>("Something went wrong!", ex.Message, null);
			}

		}
	}
}

