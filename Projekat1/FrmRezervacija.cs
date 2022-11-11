using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat1
{
    public partial class FrmRezervacija : Form
    {
        List<Projekcija> projekcije;
        double cena;
        public FrmRezervacija()
        {
            InitializeComponent();
            foreach (Sala s in Globals.Sale)
            {
                cbSale.Items.Add("Sala " + s.BrojSale);
            }
            foreach (Film f in Globals.Filmovi)
            {
                cbNaziv.Items.Add(f.Naziv);
            }
            dateTimePicker1.Value = DateTime.Now.AddHours(1);
            dateTimePicker2.Value = DateTime.Now.AddDays(7);
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            projekcije = new List<Projekcija>();
            listBox1.Items.Clear();
            //Provera za validnost datuma
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Pocetni datum ne moze biti u proslosti."); return;
            }
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("Krajni datum ne moze biti pre pocetnog."); return;
            }
            //provera za sale i naziv
            if (cbSale.SelectedIndex != -1 && cbNaziv.SelectedIndex != -1)
            {
                int br = int.Parse(cbSale.Text.Last().ToString());
                foreach (Projekcija p in Globals.Projekcije)
                    if (br == p.Sala.BrojSale && p.Film.Naziv == cbNaziv.Text)
                        projekcije.Add(p);
            }
            //provera za sale
            else if (cbSale.SelectedIndex != -1)
            {
                int br = int.Parse(cbSale.Text.Last().ToString());
                foreach (Projekcija p in Globals.Projekcije)
                    if (br == p.Sala.BrojSale)
                        projekcije.Add(p);
            }
            //provera za naziv
            else if (cbNaziv.SelectedIndex != -1)
            {
                foreach (Projekcija p in Globals.Projekcije)
                    if (p.Film.Naziv == cbNaziv.Text)
                        projekcije.Add(p);
            }
            //else dodaj sve
            else
            {
                foreach (Projekcija p in Globals.Projekcije)
                    projekcije.Add(p);
            }
            //filtrira filmove koji su u opsegu datuma i koji imaju slobodna mesta
            for (int i = 0; i < projekcije.Count; i++)
            {
                if (projekcije[i].Datum.Date < dateTimePicker1.Value || projekcije[i].Datum.Date > dateTimePicker2.Value || projekcije[i].Sala.BrojSedista == 0)
                {
                    projekcije.RemoveAt(i);
                    i--;
                }
            }

            foreach (Projekcija p in projekcije)
                listBox1.Items.Add(p.ToString() + ", Broj dostupnih mesta: " + p.Sala.BrojSedista);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FrmRezervacija f = new FrmRezervacija();
            f.Show();
            this.Close();
        }

        private void numMesta_ValueChanged(object sender, EventArgs e)
        {
            Projekcija projekcija = new Projekcija();
            if (projekcije == null)
            {
                MessageBox.Show("Niste izabrali projekciju"); return;
            }
            else
            {
                foreach (Projekcija p in projekcije)
                    if (int.Parse(listBox1.SelectedItem.ToString().First().ToString()) == p.UidProjekcija )
                        projekcija = p;
            }
            cena = projekcija.Cena_karte * (double)numMesta.Value;
            txtCena.Text = cena.ToString() + " RSD";
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            Projekcija projekcija = new Projekcija();
            if (projekcije == null)
            {
                MessageBox.Show("Niste izabrali projekciju"); return;
            }
            else
            {
                foreach (Projekcija p in projekcije)
                    if (listBox1.SelectedIndex == p.UidProjekcija - 1)
                        projekcija = p;
            }
            if (projekcija.UidProjekcija == 0)
            {
                MessageBox.Show("Niste izabrali projekciju."); return;
            }
            if (numMesta.Value < 1)
            {
                MessageBox.Show("Ne mozete napraviti rezervaciju sa 0 rezervisnaih mesta."); return;
            }
            else if (numMesta.Value > projekcija.Sala.BrojSedista)
            {
                MessageBox.Show("Ne mozete rezervisati vise mesta nego sto postoji u sali."); return;
            }
            else if (projekcija.Film.Uzrast > DateTime.Now.Year - Globals.Kupac.DatumRodjenja.Year)
            {
                MessageBox.Show("Film nije primeren za gledaoce mladje od " + projekcija.Film.Uzrast + " godina\nVase godine: " + (DateTime.Now.Year - Globals.Kupac.DatumRodjenja.Year)); return; ;
            }
            else
            {
                foreach (Projekcija p in Globals.Projekcije)
                    if (projekcija.UidProjekcija == p.UidProjekcija)
                        p.Sala.BrojSedista -= (int)numMesta.Value;

            }
            Globals.Rezervacije.Add(new Rezervacija(projekcija.UidProjekcija, Globals.Kupac.Uid, (int)numMesta.Value, cena));

            this.Close();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



