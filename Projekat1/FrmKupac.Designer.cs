
namespace Projekat1
{
    partial class FrmKupac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDodajRez = new System.Windows.Forms.Button();
            this.btnBrisiRez = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.lbRez = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDodajRez
            // 
            this.btnDodajRez.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRez.Location = new System.Drawing.Point(774, 464);
            this.btnDodajRez.Name = "btnDodajRez";
            this.btnDodajRez.Size = new System.Drawing.Size(173, 41);
            this.btnDodajRez.TabIndex = 12;
            this.btnDodajRez.Text = "Dodajte rezervaciju";
            this.btnDodajRez.UseVisualStyleBackColor = true;
            this.btnDodajRez.Click += new System.EventHandler(this.btnDodajRez_Click);
            // 
            // btnBrisiRez
            // 
            this.btnBrisiRez.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrisiRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisiRez.Location = new System.Drawing.Point(37, 464);
            this.btnBrisiRez.Name = "btnBrisiRez";
            this.btnBrisiRez.Size = new System.Drawing.Size(173, 41);
            this.btnBrisiRez.TabIndex = 11;
            this.btnBrisiRez.Text = "Izbrišite rezervaciju";
            this.btnBrisiRez.UseVisualStyleBackColor = true;
            this.btnBrisiRez.Click += new System.EventHandler(this.btnBrisiRez_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rezervacije:";
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezime.Location = new System.Drawing.Point(142, 21);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(166, 25);
            this.lblImePrezime.TabIndex = 9;
            this.lblImePrezime.Text = "Korisnicko Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Korisnik:";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(846, 21);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(101, 41);
            this.btnOdjava.TabIndex = 7;
            this.btnOdjava.Text = "Odjavite se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // lbRez
            // 
            this.lbRez.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRez.FormattingEnabled = true;
            this.lbRez.ItemHeight = 20;
            this.lbRez.Location = new System.Drawing.Point(37, 91);
            this.lbRez.Name = "lbRez";
            this.lbRez.Size = new System.Drawing.Size(910, 344);
            this.lbRez.TabIndex = 13;
            // 
            // FrmKupac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lbRez);
            this.Controls.Add(this.btnDodajRez);
            this.Controls.Add(this.btnBrisiRez);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdjava);
            this.Name = "FrmKupac";
            this.Text = "FrmKupac";
            this.Load += new System.EventHandler(this.FrmKupac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajRez;
        private System.Windows.Forms.Button btnBrisiRez;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.ListBox lbRez;
    }
}