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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtIme.Text.Trim().Equals(""))
            {
                MessageBox.Show("Polje za ime ne moze biti prazno");
            }
            else if (txtPrezime.Text.Trim().Equals(""))
            {
                MessageBox.Show("Polje za prezime ne moze biti prazno");
            }
            else
            {
                if (txtIme.Text.Trim().Equals(Globals.Admin.KorIme) && txtPrezime.Text.Trim().Equals(Globals.Admin.Lozinka))
                {
                    FrmAdmin f = new FrmAdmin();
                    f.MdiParent = FrmMain.ActiveForm;
                    f.FormBorderStyle = FormBorderStyle.None;
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    MessageBox.Show("Uspesna prijava");
                    this.Close();
                    return;
                }
                foreach (Kupac k in Globals.Kupci)
                {
                    if (txtIme.Text.Trim().Equals(k.KorIme) && txtPrezime.Text.Trim().Equals(k.Lozinka))
                    {
                        Globals.Kupac = k;
                        FrmKupac f = new FrmKupac();
                        f.MdiParent = FrmMain.ActiveForm;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                        MessageBox.Show("Uspesna prijava");
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Prijava neuspela. Pogresno uneti podaci ili korisnik ne postoji. Pokusajte ponovo ili se registrujete.");
            }
        }


        private void btnNoviNalog_Click(object sender, EventArgs e)
        {
            FrmRegistracija f = new FrmRegistracija();
            f.MdiParent = FrmMain.ActiveForm;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
            this.Close();
        }
    }
}
