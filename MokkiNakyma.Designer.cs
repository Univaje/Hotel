
namespace Hotel
{
    partial class MokkiNakyma
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMnimi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMosoite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMvarustelu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMkuvaus = new System.Windows.Forms.TextBox();
            this.btnTallennaMokki = new System.Windows.Forms.Button();
            this.btnPeruutaLisaus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMhlmaara = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMposti = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMHinta = new System.Windows.Forms.TextBox();
            this.tbToimipaikka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mökin nimi";
            // 
            // tbMnimi
            // 
            this.tbMnimi.Location = new System.Drawing.Point(37, 49);
            this.tbMnimi.Name = "tbMnimi";
            this.tbMnimi.Size = new System.Drawing.Size(421, 22);
            this.tbMnimi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Katuosoite";
            // 
            // tbMosoite
            // 
            this.tbMosoite.Location = new System.Drawing.Point(37, 94);
            this.tbMosoite.Name = "tbMosoite";
            this.tbMosoite.Size = new System.Drawing.Size(421, 22);
            this.tbMosoite.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Postinumero";
            // 
            // tbMvarustelu
            // 
            this.tbMvarustelu.Location = new System.Drawing.Point(108, 332);
            this.tbMvarustelu.Name = "tbMvarustelu";
            this.tbMvarustelu.Size = new System.Drawing.Size(191, 22);
            this.tbMvarustelu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kuvaus";
            // 
            // tbMkuvaus
            // 
            this.tbMkuvaus.Location = new System.Drawing.Point(37, 191);
            this.tbMkuvaus.Multiline = true;
            this.tbMkuvaus.Name = "tbMkuvaus";
            this.tbMkuvaus.Size = new System.Drawing.Size(421, 114);
            this.tbMkuvaus.TabIndex = 6;
            // 
            // btnTallennaMokki
            // 
            this.btnTallennaMokki.Location = new System.Drawing.Point(19, 447);
            this.btnTallennaMokki.Name = "btnTallennaMokki";
            this.btnTallennaMokki.Size = new System.Drawing.Size(181, 57);
            this.btnTallennaMokki.TabIndex = 10;
            this.btnTallennaMokki.Text = "Tallenna";
            this.btnTallennaMokki.UseVisualStyleBackColor = true;
            this.btnTallennaMokki.Click += new System.EventHandler(this.TallennaMokki_Click);
            // 
            // btnPeruutaLisaus
            // 
            this.btnPeruutaLisaus.Location = new System.Drawing.Point(308, 447);
            this.btnPeruutaLisaus.Name = "btnPeruutaLisaus";
            this.btnPeruutaLisaus.Size = new System.Drawing.Size(181, 57);
            this.btnPeruutaLisaus.TabIndex = 11;
            this.btnPeruutaLisaus.Text = "Peruuta";
            this.btnPeruutaLisaus.UseVisualStyleBackColor = true;
            this.btnPeruutaLisaus.Click += new System.EventHandler(this.btnPeruutaLisaus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Varustelu";
            // 
            // cbMhlmaara
            // 
            this.cbMhlmaara.FormattingEnabled = true;
            this.cbMhlmaara.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMhlmaara.Location = new System.Drawing.Point(410, 332);
            this.cbMhlmaara.Name = "cbMhlmaara";
            this.cbMhlmaara.Size = new System.Drawing.Size(72, 24);
            this.cbMhlmaara.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Henkilo määrä";
            // 
            // tbMposti
            // 
            this.tbMposti.Location = new System.Drawing.Point(37, 139);
            this.tbMposti.Name = "tbMposti";
            this.tbMposti.Size = new System.Drawing.Size(206, 22);
            this.tbMposti.TabIndex = 4;
            this.tbMposti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMposti_KeyPress);
            this.tbMposti.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbMposti_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hinta";
            // 
            // tbMHinta
            // 
            this.tbMHinta.Location = new System.Drawing.Point(164, 385);
            this.tbMHinta.Name = "tbMHinta";
            this.tbMHinta.Size = new System.Drawing.Size(206, 22);
            this.tbMHinta.TabIndex = 9;
            this.tbMHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMHinta_KeyPress);
            // 
            // tbToimipaikka
            // 
            this.tbToimipaikka.Location = new System.Drawing.Point(252, 139);
            this.tbToimipaikka.Name = "tbToimipaikka";
            this.tbToimipaikka.Size = new System.Drawing.Size(206, 22);
            this.tbToimipaikka.TabIndex = 5;
            this.tbToimipaikka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMposti_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Postitoimipaikka";
            // 
            // MokkiNakyma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 529);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMhlmaara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPeruutaLisaus);
            this.Controls.Add(this.btnTallennaMokki);
            this.Controls.Add(this.tbMkuvaus);
            this.Controls.Add(this.tbToimipaikka);
            this.Controls.Add(this.tbMposti);
            this.Controls.Add(this.tbMHinta);
            this.Controls.Add(this.tbMvarustelu);
            this.Controls.Add(this.tbMosoite);
            this.Controls.Add(this.tbMnimi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MokkiNakyma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMnimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMosoite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMvarustelu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMkuvaus;
        private System.Windows.Forms.Button btnTallennaMokki;
        private System.Windows.Forms.Button btnPeruutaLisaus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMhlmaara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMposti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMHinta;
        private System.Windows.Forms.TextBox tbToimipaikka;
        private System.Windows.Forms.Label label9;
    }
}