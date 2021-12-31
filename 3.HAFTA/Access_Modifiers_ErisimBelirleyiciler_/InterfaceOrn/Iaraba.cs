using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrn
{
    public interface Iaraba
    {
        string marka { get; set; }
        string model { get; set; }
        int modelYili { get; set; }
        string sanzıman { get; set; }
        void ozellikOku();
}
}
