using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    class Kupac : Korisnik
    {
        private DateTime datumRodjenja;
        private string tel;
        private string pol;

        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Pol { get => pol; set => pol = value; }

        public Kupac(int uid, string korIme, string lozinka, DateTime datumRodjenja, string tel, string pol) : base(uid, korIme, lozinka)
        {
            this.DatumRodjenja = datumRodjenja;
            this.Tel = tel;
            this.Pol = pol;
            IsAdmin = false;
        }
        public override string ToString()
        {
            return Uid + ". " + KorIme + ", " + Lozinka + ", Datum rodjenja: " + DatumRodjenja.ToShortDateString() + ", Telefon: " + Tel + ", Pol: " + Pol;
        }
    }
}
