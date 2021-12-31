using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSamle
{
    public class SozlesmeliPersonel:BasePersonel
    {
        public int saatliOdeme { get; set; }
        public int calısmaSuresi { get; set; }
        public override int AylikMaas()
        {
            return saatliOdeme * calısmaSuresi;
        }
    }
}
