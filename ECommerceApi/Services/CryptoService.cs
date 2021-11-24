using System;
using System.Security.Cryptography;
using ECommerceApi.Data;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;


namespace ECommerceApi.Services
{
    public interface ICryptoService
    {
        string Encode(string password);
    }


    public class CryptoService:BaseService, ICryptoService
    {
        public CryptoService(ECommerceDbContext db)
            : base(db)
        {

        }


        public string Encode (string password)
        {

            // generate a 128-bit salt using a cryptographically strong random sequence of nonzero values
            byte[] salt = new byte[128 / 8];
           

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));


            return hashed;
        }
    }
}

