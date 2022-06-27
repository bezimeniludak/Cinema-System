using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    class Projekcija
    {
        private int uidProjekcija;
        private DateTime datum;// jedan date time a odvojen prikaz datuma i vremena
        private Sala sala;
        private double cenaKarte;
        private Film film;

        public Projekcija() {
            this.UidProjekcija = 0;
            this.Datum = DateTime.Now;
            this.Sala = null;
            this.Cena_karte = 0;
            this.Film = null;
        }
        public Projekcija(int uidProjekcija, DateTime datum, Sala sala, double cenaKarte, Film film)
        {
            this.UidProjekcija = uidProjekcija;
            this.Datum = datum;
            this.Sala = sala;
            this.Cena_karte = cenaKarte;
            this.Film = film;
        }

        public int UidProjekcija { get => uidProjekcija; set => uidProjekcija = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public double Cena_karte { get => cenaKarte; set => cenaKarte = value; }
        internal Sala Sala { get => sala; set => sala = value; }
        internal Film Film { get => film; set => film = value; }

        public override string ToString()
        {
            return UidProjekcija+". Film: " + Film.Naziv + ", Datum projekcije: " + Datum.ToShortDateString() + ", Vreme pocetka projekcije: " 
                    + Datum.ToShortTimeString()+", Sala br.: " + Sala.BrojSale + ", Cena karte: " + Cena_karte+" RSD";
        }
    }
}
