using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public abstract class TemelSinif
    {
        public DateTime KayitTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }

        public TemelSinif()
        {
            KayitTarihi = DateTime.Now;
            GuncellemeTarihi = DateTime.Now;
            
        }
        public void Test()
        {
            Console.WriteLine("TemelSınıf  => Sınıf");
        }
        public abstract void TestAbstract(); //Sadece methodun imzası yer alır
    }
}
