using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    class Film
    {
        int uid;
        string naziv, zanr;
        int trajanje;   //u min
        int uzrast;

        public Film(int uid, string naziv, string zanr, int trajanje, int uzrast)
        {
            this.Uid = uid;
            this.Naziv = naziv;
            this.Zanr = zanr;
            this.Trajanje = trajanje;
            this.Uzrast = uzrast;

        }

        public int Uid { get => uid; set => uid = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Zanr { get => zanr; set => zanr = value; }
        public int Trajanje { get => trajanje; set => trajanje = value; }
        public int Uzrast { get => uzrast; set => uzrast = value; }

        public override string ToString()
        {
            return "Naziv: " + this.Naziv + ", Zanr: " + this.Zanr + ", Duzina trajanja (min): " + this.Trajanje + ", Granica godina: " + this.Uzrast;
        }

    }
}
