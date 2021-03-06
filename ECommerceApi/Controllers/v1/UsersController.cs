using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApi.Controllers.Base.v1;
using ECommerceApi.Data;
using ECommerceApi.Entities;
using ECommerceApi.Helpers;
using ECommerceApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApi.Controllers.v1
{
    public class UsersController : Basev1ApiController
    {
		public readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
			_userService = userService;
		}

		/// <summary>
		/// Create a new user
		/// </summary>
		/// <param name="model">User information</param>
		/// <returns>Results</returns>
		[HttpPost]
		[ValidateModel]
		[AllowAnonymous]
		[ProducesResponseType(typeof(ApiReturn<User>), 200)]
		[ProducesResponseType(typeof(ApiReturn<User>), 400)]
		[ProducesResponseType(typeof(ApiReturn<User>), 500)]
		public async Task<IActionResult> Post([FromBody] User model)
		{
			try
			{
				var modelResult = _userService.Register(model);

				return Success("User added successfully.", null, modelResult);
			}
			catch (Exception ex)
			{
				return Error<object>("Something went wrong!", ex.Message, null);
			}

		}


		/// <summary>
		/// List all users
		/// </summary>
		/// <returns>User list</returns>
		[HttpGet]
		[ProducesResponseType(typeof(List<User>), 200)]
		public async Task<IActionResult> Get()
		{
			var users = await _userService.GetUsers();

			return Success("Products listed.", null, users);
		}
	}
}

