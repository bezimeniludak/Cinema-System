using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    class Sala
    {
        private int uidSala;
        private int brojSale;
        private int brojSedista;

        public int UidSala { get => uidSala; set => uidSala = value; }
        public int BrojSale { get => brojSale; set => brojSale = value; }
        public int BrojSedista { get => brojSedista; set => brojSedista = value; }

        public Sala(int uidSala, int brojSale, int brojSedista)
        {
            this.UidSala = uidSala;
            this.BrojSale = brojSale;
            this.BrojSedista = brojSedista;
        }
        public override string ToString()
        {
            return "Broj sale: " + BrojSale + ", Ukupan broj sedista: " + BrojSedista;
        }

    }
}
