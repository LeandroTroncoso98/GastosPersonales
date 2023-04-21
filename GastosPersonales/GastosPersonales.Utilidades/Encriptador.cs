using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.Utilidades
{
    public class Encriptador
    {
        public static string Encriptar(string clave)
        {
            string hash = "X30";
            byte[] data = UTF8Encoding.UTF8.GetBytes(clave);
            MD5 mD5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();
            tripleDES.Key = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode= CipherMode.ECB;
            ICryptoTransform transform = tripleDES.CreateEncryptor();

            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(result);
        }
    }
}
