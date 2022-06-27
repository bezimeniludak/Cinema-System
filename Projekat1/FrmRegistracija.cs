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
    public partial class FrmRegistracija : Form
    {
        public FrmRegistracija()
        {
            InitializeComponent();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            FrmPrijava f = new FrmPrijava();
            f.MdiParent = FrmMain.ActiveForm;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
            this.Close();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (txtIme.Text.Equals("") || txtLozinka.Text.Equals("") || txtTel.Text.Equals("")) { MessageBox.Show("Polje ne moze biti prazno"); return; }
            else if (txtIme.Text.Length<4 || txtLozinka.Text.Length<4) { MessageBox.Show("Premalo karaktera(min. 4)"); return; }
            else if (txtTel.Text.Any(char.IsLetter)) { MessageBox.Show("Telefonski broj ne moze da sadrzi slova"); return; }

            int uid = Globals.Kupci.Count + 1;
            string korIme = txtIme.Text.Trim();
            string lozinka = txtLozinka.Text.Trim();
            DateTime datum = dateTimePicker1.Value;
            if (DateTime.UtcNow.Year - datum.Year < 10) { MessageBox.Show("Korisnik ne moze biti mladji od 10 godina"); return; }
            string tel = txtTel.Text.Trim();
            string pol;
            if (rbMuski.Checked)
                pol = "Muski";
            else
                pol = "Zenski";

            Globals.Kupci.Add(new Kupac(uid, korIme, lozinka, datum, tel, pol));
            MessageBox.Show("Uspesna registracija.");
            FrmPrijava f = new FrmPrijava();
            f.MdiParent = FrmMain.ActiveForm;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
            this.Close();
        }
    }
}
