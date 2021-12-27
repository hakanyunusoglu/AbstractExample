using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class SuperMusteri : Musteri
    {
        public override void TestAbstract()
        {
            Console.WriteLine("SuperMusteri => TestAbstract");
        }
    }
}
