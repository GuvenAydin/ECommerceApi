using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using ECommerceApi.Controllers.Base;
using ECommerceApi.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ECommerceApi.Controllers
{
	[ApiVersionNeutral]
	public class AuthController : BaseApiController
	{
		private readonly IConfiguration _configuration;

		public AuthController(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		[AllowAnonymous]
		[HttpPost("token")]
		public IActionResult Post([FromBody] AuthModel model)
		{
			if (model.UserName == "guven" && model.Password == "Asd1234")
			{
				var claims = new[]
				{
					new Claim(ClaimTypes.Name, "guven"),
					new Claim(ClaimTypes.Surname, "aydin"),
					new Claim(ClaimTypes.DateOfBirth, "1970/01/01")
				};

				var key = new SymmetricSecurityKey(Convert.FromBase64String(_configuration["Authentication:JwtKey"]));

				var token = new JwtSecurityToken(
					claims: claims,
					expires: DateTime.UtcNow.AddMonths(1),
					signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
				);
				var generatedToken = new JwtSecurityTokenHandler().WriteToken(token);

				return Ok(new
				{
					Token = generatedToken
				});
			}

			return Unauthorized();
		}
	}
}

