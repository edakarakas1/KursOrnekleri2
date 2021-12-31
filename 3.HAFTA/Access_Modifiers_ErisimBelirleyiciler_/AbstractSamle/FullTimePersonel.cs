using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSamle
{
    public class FullTimePersonel:BasePersonel
    {
        public int yillikMaas { get; set; }
        public override int AylikMaas()
        { return yillikMaas/12; }
    }
}
