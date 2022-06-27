using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    class Korisnik
    {
        private int uid;
        private string korIme;
        private string lozinka;
        private bool isAdmin;

        public int Uid { get => uid; set => uid = value; }
        public string KorIme { get => korIme; set => korIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        public Korisnik(int uid, string korIme, string lozinka)
        {
            this.Uid = uid;
            this.korIme = korIme;
            this.Lozinka = lozinka;
        }
        public override string ToString()
        {
            return "Korisnicko ime: " + KorIme + ", Lozinka: " + Lozinka;
        }
    }
}
