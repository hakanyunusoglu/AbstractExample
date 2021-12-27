using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class Musteri : TemelSinif
    {
        public int MusteriID { get; set; }
        public Musteri()
        {
            MusteriID = 1;
        }
        public override void TestAbstract()
        {
            Console.WriteLine("Musteri => TestAbstract");
        }
    }
}
