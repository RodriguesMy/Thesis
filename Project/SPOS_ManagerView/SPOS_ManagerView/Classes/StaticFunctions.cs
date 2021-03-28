using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SPOS_ManagerView.Classes
{
    public class StaticFunctions
    {
        public static string GetHash(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            using SHA512 sha512 = new SHA512Managed();
            byte[] bytes = sha512.ComputeHash(data);

            return String.Concat(Array.ConvertAll(bytes, b => b.ToString("X2")));
        }
    }
}
