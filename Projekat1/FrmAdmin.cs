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
    public partial class FrmAdmin : Form
    {
        Kupac kupac;
        Rezervacija rezervacija;
        Projekcija projekcija;
        Film film;
        Sala sala;
        int x = 0;
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            foreach (Kupac k in Globals.Kupci)
            {
                cbKupac.Items.Add(k.ToString());
            }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy HH:mm";
        }

        private void cbKupac_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbRezervacije.Items.Clear();
            string s = cbKupac.SelectedItem.ToString();
            x = int.Parse(s.First().ToString());
            foreach (Kupac k in Globals.Kupci)
                if (k.Uid == x)
                    kupac = k;
            foreach (Rezervacija r in Globals.Rezervacije)
                if (r.UidKupca == x)
                    lbRezervacije.Items.Add(r.ToStringFull());
        }

        private void lbRezervacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = lbRezervacije.SelectedItem.ToString();
            x = int.Parse(s.First().ToString());
            foreach (Rezervacija r in Globals.Rezervacije)
                if (r.UidProjekcije == x && r.UidKupca == kupac.Uid)
                    rezervacija = r;
            txtRezervacija.Text = rezervacija.ToStringFull();

            foreach (Projekcija p in Globals.Projekcije)
                if (p.UidProjekcija == rezervacija.UidProjekcije)
                    projekcija = p;

            txtProjekcija.Text = projekcija.ToString();
            sala = projekcija.Sala;
            txtSala.Text = sala.BrojSale.ToString();
            txtSedista.Text = rezervacija.BrojSedista.ToString();
            dateTimePicker1.Value = projekcija.Datum;
            txtCena.Text = projekcija.Cena_karte.ToString();

            foreach (Film f in Globals.Filmovi)
                if (f.Uid == projekcija.Film.Uid)
                    film = f;
            txtFilm.Text = film.ToString();
            txtNaziv.Text = film.Naziv;
            txtZanr.Text = film.Zanr;
            txtTrajanje.Text = film.Trajanje.ToString();
            txtUzrast.Text = film.Uzrast.ToString();

        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FrmPrijava f = new FrmPrijava();
            f.MdiParent = FrmMain.ActiveForm;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
            this.Close();
        }

        private void txtDodaj_Click(object sender, EventArgs e)
        {
            if (kupac == null)
            {
                MessageBox.Show("Kupac nije izabran"); return;
            }
            Globals.Kupac = kupac;
            FrmRezervacija f = new FrmRezervacija();
            f.Show();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTrajanje.Text, out int x))
                film.Trajanje = int.Parse(txtTrajanje.Text);
            else { MessageBox.Show("Polje za trajanje filma ne sme sadrzati slova"); return; }
            if (int.TryParse(txtTrajanje.Text, out int y))
                film.Uzrast = int.Parse(txtUzrast.Text);
            else { MessageBox.Show("Polje za uzrast ne sme sadrzati slova"); return; }

            film.Naziv = txtNaziv.Text;
            film.Zanr = txtZanr.Text;
            projekcija.Film = film;

            if (int.TryParse(txtSala.Text, out int z))
                projekcija.Sala.BrojSale = int.Parse(txtSala.Text);
            else { MessageBox.Show("Polje za broj sale ne sme sadrzati slova"); return; }
            if (int.TryParse(txtSedista.Text, out int a))
            {
                rezervacija.BrojSedista = int.Parse(txtSedista.Text);
                projekcija.Sala.BrojSedista -= int.Parse(txtSedista.Text);
            }

            projekcija.Datum = dateTimePicker1.Value;
            if (double.TryParse(txtCena.Text, out double b))
            {
                projekcija.Cena_karte = double.Parse(txtCena.Text);
                rezervacija.UkupnaCena = double.Parse(txtCena.Text) * int.Parse(txtSedista.Text);
            }
            else { MessageBox.Show("Polje za cenu ne sme sadrzati slova"); return; }
            
            for (int i = 0; i < Globals.Projekcije.Count; i++)
                if (Globals.Projekcije[i].UidProjekcija == projekcija.UidProjekcija)
                    Globals.Projekcije[i] = projekcija;

            for (int i = 0; i < Globals.Rezervacije.Count; i ++)
                if (Globals.Rezervacije[i].UidKupca == rezervacija.UidKupca && Globals.Rezervacije[i].UidProjekcije == rezervacija.UidProjekcije)
                    Globals.Projekcije[i] = projekcija;
            MessageBox.Show("Podaci uspesno azurirani");
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (rezervacija == null)
            { MessageBox.Show("Nije izabrana nijedna rezervacija"); return; }

            Globals.Rezervacije.Remove(rezervacija);
            MessageBox.Show("Rezervacija uspesno izbrisana");
        }
    }
}
