using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komparatori
{
    public class Drehi : Magazin
    {
        private int nomer;
        private string imenastoka;
        private string kachestvo;
        public int Nomer
        {
            get { return nomer; }
            set { nomer = value; }
        }
        public string Imenastoka
        {
            get { return imenastoka; }
            set { imenastoka = value; }
        }
        public string Kachestvo
        {
            get { return kachestvo; }
            set { kachestvo = value; }
        }
        public Drehi(string name, int price,int nomer, string imenastoka, string kachestvo):base(name,price)
        {
            Nomer = nomer;
            Imenastoka = imenastoka;
            Kachestvo = kachestvo;
           
        }   
    }
}
