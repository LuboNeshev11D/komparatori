using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komparatori
{
    public class Elektrouredi:Magazin 
    {
        private int moshtnost;
        private string garanciq;

        public int Moshtnost
        {
            get { return moshtnost; }
            set { moshtnost = value; }
        }
        public string Garanciq
        {
            get { return garanciq; }
            set { garanciq = value; }
        }
        public Elektrouredi(string name, int price, int moshtnost, string garanciq) : base(name,price)
        {
            Moshtnost = moshtnost;
            Garanciq = garanciq;
        }

    
    }
}
