using System;
using System.Security.Cryptography;
using System.Text;

namespace FN.Store.Domain.Helpers
{
    public static class StringHelpers
    {

        public static string Encrypt(this string senha)
        {

            var salt = "|DD6F458B13274FDC8782F3FABC749E396C4907F4A6F446DA96A69F9D20FB44DA";

            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);

            byte[] hashBytes;
            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }


            return Convert.ToBase64String(hashBytes);
        }

    }
}
