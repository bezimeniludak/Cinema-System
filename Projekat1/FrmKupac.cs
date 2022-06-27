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
    public partial class FrmKupac : Form
    {
        List<Rezervacija> r;
        public FrmKupac()
        {
            InitializeComponent();
            r = new List<Rezervacija>();
        }

        private void FrmKupac_Load(object sender, EventArgs e)
        {

            lblImePrezime.Text = Globals.Kupac.KorIme;
            foreach (Rezervacija rez in Globals.Rezervacije)
                if (Globals.Kupac.Uid == rez.UidKupca)
                    r.Add(rez);

            foreach (Rezervacija rez in r)
                foreach (Projekcija pro in Globals.Projekcije)
                    if (rez.UidProjekcije == pro.UidProjekcija)
                        lbRez.Items.Add(pro.ToString() + rez.ToString());
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

        private void btnBrisiRez_Click(object sender, EventArgs e)
        {
            Rezervacija rez3 = new Rezervacija();
            foreach (Rezervacija rez1 in r)
                foreach (Rezervacija rez2 in Globals.Rezervacije)
                    if (rez1.UidProjekcije == rez2.UidProjekcije && rez1.UidKupca == rez2.UidKupca)
                        rez3 = rez1;

            foreach (Projekcija p in Globals.Projekcije)
            {
                if (rez3.UidProjekcije == p.UidProjekcija)
                    p.Sala.BrojSedista += rez3.BrojSedista;
            }
            Globals.Rezervacije.Remove(rez3);
            lbRez.Items.Remove(lbRez.SelectedItem);
            MessageBox.Show("Rezervacija uspesno izbrisana.");
        }

        private void btnDodajRez_Click(object sender, EventArgs e)
        {
            FrmRezervacija f = new FrmRezervacija();
            f.Show();
        }
    }
}
