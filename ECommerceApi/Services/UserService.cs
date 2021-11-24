using System;
using ECommerceApi.Data;
using ECommerceApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApi.Services
{
    public interface IUserService
    {
        Task<ICollection<User>> GetUsers();
        User Register(User model);
    }

    public class UserService:BaseService, IUserService
    {
        public readonly ICryptoService _cryptoService;


        public UserService(ECommerceDbContext db, ICryptoService cryptoService)
            :base(db)
        {
            this._cryptoService = cryptoService;
        }

        public async Task<ICollection<User>> GetUsers()
        {
            return await db.User.ToListAsync();
        }


        public User Register(User model)
        {
            model.Password = _cryptoService.Encode(model.Password);

            db.User.Add(model);

            db.SaveChanges();
           
            return model;
        }

    }
}

