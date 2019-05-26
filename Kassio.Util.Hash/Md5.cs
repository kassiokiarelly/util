using System;
using System.Security.Cryptography;
using System.Text;

namespace Kassio.Util.Hash
{
    public class Md5
    {
        public static byte[] Md5Sum(byte[] buffer)
        {
            using (var provider = new MD5CryptoServiceProvider())
            {
                var hash = provider.ComputeHash(buffer);
                return hash;
            }
        }

        public static string Md5Sum(string strIn)
        {
            var buffer = Encoding.UTF8.GetBytes(strIn);
            var hash = Md5Sum(buffer);
            var md5hex = BitConverter.ToString(hash).Replace("-", "");
            return md5hex;
        }

        public static string Md5Sum(string strIn, string format = "D")
        {
            var hash = Md5Sum(strIn);
            return Guid.ParseExact(hash, "N").ToString(format);
        }
    }

    public static class Md5HashExtension
    {
        public static string Md5Sum(this string strIn)
        {
            var hash = Md5.Md5Sum(strIn, "D");
            return hash;
        }

        public static string Md5Sum(this string strIn, Md5HashFormat format)
        {
            var hash = Md5.Md5Sum(strIn, format.ToString("G"));
            return hash;
        }


    }
}
