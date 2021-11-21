using System;
using ECommerceApi.Data;
using ECommerceApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApi.Services
{
    public interface IUserService
    {
        Task<ICollection<User>> GetUsers();
    }

    public class UserService:BaseService, IUserService
    {
        public UserService(ECommerceDbContext db)
            :base(db)
        {

        }

        public async Task<ICollection<User>> GetUsers()
        {
           var u =  await db.User.ToListAsync();

            return u;
        }

    }
}

