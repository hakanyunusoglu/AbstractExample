using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExampleConsole
{
    public class SozlesmeliPersonel : BasePersonel
    {
        public int SaatlikOdeme { get; set; }
        public int CalismaSuresi { get; set; }
        public override int AylikMass()
        {
            return SaatlikOdeme * CalismaSuresi;
        }
    }
}
