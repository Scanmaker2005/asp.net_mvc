using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using CalculoFrete.Web.Models;
using System.Security.Cryptography;
using System.Text;

namespace CalculoFrete.Web.Core
{
    public class Crypt
    {
        public static string MD5(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }



    }
}