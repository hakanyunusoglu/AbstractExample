using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExampleConsole
{
    public class FullTimePersonel : BasePersonel
    {
        public int YillikMaas { get; set; }
        public override int AylikMass()
        {
            return YillikMaas / 12;
        }

    }
}
