using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prodavnicaTVP
{
    class Racun
    {
        private DateTime Datum;
        private List<Proizvod> proizvodi;

        public Racun( DateTime datum, List<Proizvod> proizvodi)
        {
            Datum1 = datum;
            this.proizvodi = proizvodi;
        }
        public Racun()
        {
            Datum1 = DateTime.Now;
            this.proizvodi = new List<Proizvod>();
        }

        public DateTime Datum1 { get => Datum; set => Datum = value; }
        internal List<Proizvod> Proizvodi { get => proizvodi; set => proizvodi = value; }

        public override string ToString()
        {
            return Datum.ToString();
        }
    }
}
