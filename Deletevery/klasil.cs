using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deletevery
{
    class klasil
    {
        public string[] Klasor(string dosyayolu)
        {
            try
            {
                string[] dosyalar = Directory.GetFiles(dosyayolu);
                return dosyalar;
            }
            catch
            {
                return null;
            }

        }
        public void silagam(string dosya)
        {
            try
            {
                File.Delete(dosya);
            }
            catch
            {
                Console.WriteLine("Dosya bulunamadı.");
            }
        }

        internal string[] klasor(object klasorismi)
        {
            throw new NotImplementedException();
        }
    }
}
