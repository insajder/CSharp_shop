using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prodavnicaTVP
{
    class Kategorija
    {
        private int ID;
        private string Naziv_kategorije;

        public Kategorija(int iD, string naziv_kategorije)
        {
            ID1 = iD;
            Naziv_kategorije1 = naziv_kategorije;
        }
        public Kategorija()
        {
            ID1 = 0;
            Naziv_kategorije1 = "";
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Naziv_kategorije1 { get => Naziv_kategorije; set => Naziv_kategorije = value; }
        public override string ToString()
        {
            return Naziv_kategorije;
        }
    }
}
