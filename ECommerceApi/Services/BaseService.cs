using System;
using ECommerceApi.Data;

namespace ECommerceApi.Services
{
    public class BaseService
    {
        public ECommerceDbContext db { get; set; }


        public BaseService(ECommerceDbContext eCommerceDbContext)
        {
            db = eCommerceDbContext;
        }
    }
}

