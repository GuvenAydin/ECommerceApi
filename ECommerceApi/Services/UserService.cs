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
        dynamic AuthenticateUser(string email, string password);
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

            //token will be return
            return AuthenticateUser(model.Email, unencryptedPassword);
        }




        public dynamic AuthenticateUser(string email,string password)
        {

            var encodedPassword = _cryptoService.Encode(password);

            var user = db.User.FirstOrDefault(x => x.Email == email && x.Password == encodedPassword);

            if (user != null)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, user.FirstName),
                    new Claim(ClaimTypes.Surname, user.LastName),
                    new Claim(ClaimTypes.Email, user.Email),
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