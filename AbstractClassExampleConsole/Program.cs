using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExampleConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimePersonel ftp = new FullTimePersonel();
            ftp.YillikMaas = 113000;
            ftp.Ad = "Hakan";
            ftp.Soyad = "Yunusoglu";
            SozlesmeliPersonel sp = new SozlesmeliPersonel();
            sp.CalismaSuresi = 11;
            sp.SaatlikOdeme = 173;
            sp.Ad = "Ahmet";
            sp.Soyad = "Veli";
            Console.WriteLine("Fulltime Aylık Maaş => {0} - {1}",ftp.isim(),ftp.AylikMass());
            Console.WriteLine("Sozlesmeli Aylık Maaş => {0} - {1}",sp.isim(),sp.AylikMass());
            Console.ReadLine();
        }
    }
}
