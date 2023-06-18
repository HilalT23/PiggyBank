using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggybank
{
    public enum ParaType {
        Madeni,
        Banknot
    }
    public class Para
    {
     
        public string ParaAdi { get; set; }

        public double ParaMiktarı { get; set; }
        public ParaType ParaType { get; set; }

        public override string ToString() => ParaAdi +"-"+ ParaMiktarı;

        public double ToplamTutar { get; set; }
    }
}
