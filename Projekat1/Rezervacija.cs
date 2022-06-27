using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    class Rezervacija
    {
        int uidProjekcije;
        int uidKupca;
        int brojSedista;
        double ukupnaCena;

        public Rezervacija()
        {
            this.UidProjekcije = 0;
            this.UidKupca = 0;
            this.BrojSedista = 0;
            this.UkupnaCena = 0;
        }

        public Rezervacija(int uidProjekcije, int uidKupca, int brojSedista, double ukupnaCena)
        {
            this.UidProjekcije = uidProjekcije;
            this.UidKupca = uidKupca;
            this.BrojSedista = brojSedista;
            this.UkupnaCena = ukupnaCena;
        }

        public int UidProjekcije { get => uidProjekcije; set => uidProjekcije = value; }
        public int UidKupca { get => uidKupca; set => uidKupca = value; }
        public int BrojSedista { get => brojSedista; set => brojSedista = value; }
        public double UkupnaCena { get => ukupnaCena; set => ukupnaCena = value; }

        public override string ToString()
        {
            return ", Broj mesta: " + BrojSedista + ", Ukupna cena: " + UkupnaCena+" RSD";
        }
        public string ToStringFull()
        {
            return UidProjekcije + ". UID kupca: " + UidKupca + ", Broj mesta: " + BrojSedista + ", Ukupna cena: " + UkupnaCena + " RSD";
        }

    }
}
