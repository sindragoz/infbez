using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InfoSecurityLab1
{
    class CryptographyController
    {
        private SHA1CryptoServiceProvider sha;
        private DESCryptoServiceProvider des;
        private string passPhrase = "ultraHar";

        public CryptographyController()
        {
            sha = new SHA1CryptoServiceProvider();
            des = new DESCryptoServiceProvider();
            setDes();
        }
        public string EncryptToSHA(string strToEncrypt)
        {
            sha.ComputeHash(Encoding.UTF8.GetBytes(strToEncrypt));
            return string.Join("", sha.Hash.Select(x => x.ToString("x2")));
        }

        public void setDes()
        {
            des.Mode = CipherMode.CBC;
            des.IV = des.Key = Encoding.UTF8.GetBytes(passPhrase).ToArray();
        }
        public DESCryptoServiceProvider getDes()
        {
            return des;
        }

        public string DecryptFile(byte[] bytesToDecrypt)
        {
            return UnicodeEncoding.Unicode.GetString(des.CreateDecryptor().TransformFinalBlock(bytesToDecrypt, 0, bytesToDecrypt.Length));
        }

        public string EncryptFile(string strToEncrypt)
        {
            return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(UnicodeEncoding.Unicode.GetBytes(strToEncrypt), 0, UnicodeEncoding.Unicode.GetBytes(strToEncrypt).Length));
        }
    }
}
