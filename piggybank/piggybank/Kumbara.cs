using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggybank
{
   public class Kumbara
    {
        public double MaxHacim;
        public double CurrentHacim;
        public bool isBroken;
        public int KırılmaSayısı = 0;
        public Para SeciliPara { get; set; }

        public double toplamPara { get; set; }
        public void Hesapla()
        {
            //toplamPara = 0;
            toplamPara += SeciliPara.ParaMiktarı;

        }

        public override string ToString()
        {
            return string.Format(toplamPara.ToString());
        }
       

        public void Repair()
        {
            if (isBroken)
            {
                KırılmaSayısı += 1;
                isBroken = false;
            }
            else
            {
                throw new PiggyBankException("kumbara kırık değil.");
            }
        }
   
        public class PiggyBankException : Exception
        {
            public PiggyBankException(string message) : base(message) { }
        }
    }

}

