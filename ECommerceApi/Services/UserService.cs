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
        public UserService(ECommerceDbContext db)
            :base(db)
        {

        }

        public async Task<ICollection<User>> GetUsers()
        {
            return await db.User.ToListAsync();
        }


        public User Register(User model)
        {


            db.User.Add(model);
            db.SaveChanges();
           
            return model;
        }

    }
}

