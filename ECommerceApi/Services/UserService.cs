using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using ECommerceApi.Data;
using ECommerceApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ECommerceApi.Services
{
    public interface IUserService
    {
        Task<ICollection<User>> GetUsers();
        dynamic Register(User model);
        dynamic AuthenticateUser(string email);
    }

    public class UserService:BaseService, IUserService
    {
        public readonly ICryptoService _cryptoService;

        private readonly IConfiguration _configuration;
       

        public UserService(ECommerceDbContext db, ICryptoService cryptoService, IConfiguration configuration)
            :base(db)
        {
            this._cryptoService = cryptoService;
            this._configuration = configuration;

        }

        public async Task<ICollection<User>> GetUsers()
        {
            return await db.User.ToListAsync();
        }


        public dynamic Register(User model)
        {
            var unencryptedPassword = model.Password;

            model.Password = _cryptoService.Encode(model.Password);
            db.User.Add(model);
            db.SaveChanges();


            var resultModel = AuthenticateUser(model.Email);


            return resultModel;
        }

        public dynamic AuthenticateUser(string email)
        {
            if(string.IsNullOrWhiteSpace(email) == false)
            {
                var claims = new[]
                {
                    //new Claim(ClaimTypes.Name, firstName),
                    //new Claim(ClaimTypes.Surname, lastName),
                    new Claim(ClaimTypes.Email, email),
                };

                var key = new SymmetricSecurityKey(Convert.FromBase64String(_configuration["Authentication:JwtKey"]));

                var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.UtcNow.AddMonths(1),
                    signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
                );
                var generatedToken = new JwtSecurityTokenHandler().WriteToken(token);

                return new
                {
                    Token = generatedToken
                };
            }

            return false;
        }



    }
}

