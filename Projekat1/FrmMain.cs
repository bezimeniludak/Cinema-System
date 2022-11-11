using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string[] niz;
            string red = "";
            using (StreamReader sr = new StreamReader("kupci.txt"))
            {
                while (red != null)
                {
                    red = sr.ReadLine();
                    if (red != null)
                    {
                        niz = red.Split(',');
                        Globals.Kupci.Add(
                            new Kupac(
                                int.Parse(niz.ElementAt(0)),
                                niz.ElementAt(1),
                                niz.ElementAt(2),
                                DateTime.Parse(niz.ElementAt(3)),
                                niz.ElementAt(4),
                                niz.ElementAt(5)));
                    }
                }
            }
            using (StreamReader sr = new StreamReader("filmovi.txt"))
            {
                red = "";
                while (red != null)
                {
                    red = sr.ReadLine();
                    if (red != null)
                    {
                        niz = red.Split(',');
                        Globals.Filmovi.Add(
                            new Film(
                                int.Parse(niz.ElementAt(0)),
                                niz.ElementAt(1),
                                niz.ElementAt(2),
                                int.Parse(niz.ElementAt(3)),
                                int.Parse(niz.ElementAt(4))));
                    }
                }
            }
            using (StreamReader sr = new StreamReader("projekcije.txt"))
            {
                Random rnd=new Random();
                red = "";
                while (red != null)
                {
                    red = sr.ReadLine();
                    if (red != null)
                    {
                        niz = red.Split(',');
                        Globals.Projekcije.Add(
                            new Projekcija(
                                int.Parse(niz.ElementAt(0)), 
                                //DateTime.Parse(niz.ElementAt(1)), //Eventually out of date
                                DateTime.Now.AddDays(rnd.Next(7)),
                                Globals.Sale.ElementAt(int.Parse(niz.ElementAt(2))),
                                double.Parse(niz.ElementAt(3)),
                                Globals.Filmovi.ElementAt(int.Parse(niz.ElementAt(4)))));
                    }
                }
            }
            using (StreamReader sr = new StreamReader("rezervacije.txt"))
            {
                red = "";
                while (red != null)
                {
                    red = sr.ReadLine();
                    if (red != null)
                    {
                        niz = red.Split(',');
                        Globals.Rezervacije.Add(
                            new Rezervacija(
                                int.Parse(niz.ElementAt(0)),
                                int.Parse(niz.ElementAt(1)),
                                int.Parse(niz.ElementAt(2)),
                                double.Parse(niz.ElementAt(3))));
                    }
                }
            }
            Prijava();
        }

        public void Prijava()
        {
            FrmPrijava f = new FrmPrijava();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("kupci.txt"))
            {
                foreach (Kupac k in Globals.Kupci)
                    sw.WriteLine(k.Uid + "," + k.KorIme + "," + k.Lozinka + "," + k.DatumRodjenja.ToShortDateString() + "," + k.Tel + "," + k.Pol);
            }
            using (StreamWriter sw = new StreamWriter("filmovi.txt"))
            {
                foreach (Film f in Globals.Filmovi)
                    sw.WriteLine(f.Uid + "," + f.Naziv + "," + f.Zanr + "," + f.Trajanje + "," + f.Uzrast);
            }
            using (StreamWriter sw = new StreamWriter("projekcije.txt"))
            {
                foreach (Projekcija p in Globals.Projekcije)
                    sw.WriteLine(p.UidProjekcija + "," + p.Datum.ToString() + "," + (p.Sala.BrojSale - 1) + "," + p.Cena_karte + "," + (p.Film.Uid - 1));
            }
            using (StreamWriter sw = new StreamWriter("rezervacije.txt"))
            {
                foreach (Rezervacija r in Globals.Rezervacije)
                {
                    sw.WriteLine(r.UidProjekcije + "," + r.UidKupca + "," + r.BrojSedista + "," + r.UkupnaCena);
                }
            }
        }
    }
}
