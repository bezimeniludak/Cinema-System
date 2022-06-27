using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    public static class Globals
    {
        private static List<Kupac> kupci = new List<Kupac>();
        internal static List<Kupac> Kupci { get => kupci; set => kupci = value; }

        private static Kupac kupac;
        internal static Kupac Kupac { get => kupac; set => kupac = value; }

        private static List<Film> filmovi = new List<Film>();
        internal static List<Film> Filmovi { get => filmovi; set => filmovi = value; }


        private static List<Sala> sale = new List<Sala>() {
            new Sala(1,1,20),
            new Sala(2,2,30),
            new Sala(3,3,15),
            new Sala(4,4,25)
        };
        internal static List<Sala> Sale { get => sale; set => sale = value; }


        private static List<Projekcija> projekcije = new List<Projekcija>();
        internal static List<Projekcija> Projekcije { get => projekcije; set => projekcije = value; }


        private static List<Rezervacija> rezervacije = new List<Rezervacija>();
        internal static List<Rezervacija> Rezervacije { get => rezervacije; set => rezervacije = value; }


        internal static Admin Admin { get => admin; set => admin = value; }

        private static Admin admin = new Admin(1, "admin", "admin");
    }
}
