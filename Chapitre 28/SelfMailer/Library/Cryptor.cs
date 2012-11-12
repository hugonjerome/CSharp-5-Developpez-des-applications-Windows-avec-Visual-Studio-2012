using System.Security.Cryptography;
using System.Text;

namespace SelfMailer.Library
{
    public static class Cryptor
    {
        private static byte[] Key = new byte[] { 140, 58, 74, 45, 196, 24, 19, 220 };
        private static byte[] Vector = new byte[] { 211, 26, 16, 198, 172, 15, 1, 3 };

        public static byte[] SwitchCrypt(byte[] data)
        {
            DESCryptoServiceProvider o = new DESCryptoServiceProvider();
            o.Key = Key;
            o.IV = Vector;
            ICryptoTransform cryptor = o.CreateEncryptor();
            return cryptor.TransformFinalBlock(data, 0, data.Length);
        }
        public static string SwitchCrypt(string s)
        {
            byte[] original = Encoding.UTF8.GetBytes(s);
            byte[] switched = Cryptor.SwitchCrypt(original);
            return Encoding.UTF8.GetString(switched);
        }
    }
}
