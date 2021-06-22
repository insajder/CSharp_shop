using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prodavnicaTVP
{
    class Proizvod
    {
        private string Naziv_proizvoda;
        private double Kolicina;
        private DateTime datum;

        public Proizvod(string naziv_proizvoda, double kolicina)
        {
            Naziv_proizvoda1 = naziv_proizvoda;
            Kolicina1 = kolicina;
            Datum = DateTime.Now;
        }
        public Proizvod(string naziv_proizvoda, double kolicina, DateTime datum)
        {
            Naziv_proizvoda1 = naziv_proizvoda;
            Kolicina1 = kolicina;
            Datum = datum;
        }
        public Proizvod()
        {
            Naziv_proizvoda1 = "";
            Kolicina1 = 0;
            Datum = DateTime.Now;
        }

        public string Naziv_proizvoda1 { get => Naziv_proizvoda; set => Naziv_proizvoda = value; }
        public double Kolicina1 { get => Kolicina; set => Kolicina = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public override string ToString()
        {
            return Naziv_proizvoda+", "+Kolicina+", "+datum.Month;
        }
    }
}
