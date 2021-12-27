using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExampleConsole
{
    public abstract class BasePersonel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        

        public string isim()
        {
            return Ad + " " + Soyad;
        }
        public abstract int AylikMass();
    }
}
