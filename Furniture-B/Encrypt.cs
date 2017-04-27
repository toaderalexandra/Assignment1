using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Furniture_B
{
    class Encrypt
    {
        public static string GetMD5(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            byte[] result = md5.Hash;
            StringBuilder passMD5 = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                passMD5.Append(result[i].ToString("x2"));
            }
            return passMD5.ToString();
        }
    }
}
