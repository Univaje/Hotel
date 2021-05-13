
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPeruutaLisaus = new System.Windows.Forms.Button();
            this.btnTallennaMokki = new System.Windows.Forms.Button();
            this.tbMkuvaus = new System.Windows.Forms.TextBox();
            this.tbToimipaikka = new System.Windows.Forms.TextBox();
            this.tbMposti = new System.Windows.Forms.TextBox();
            this.tbMHinta = new System.Windows.Forms.TextBox();
            this.tbMvarustelu = new System.Windows.Forms.TextBox();
            this.tbMosoite = new System.Windows.Forms.TextBox();
            this.tbMnimi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMhlomaara = new System.Windows.Forms.TextBox();
            this.epVirhe = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epVirhe)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Hinta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Henkilo määrä";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Varustelu";
            // 
            // btnPeruutaLisaus
            // 
            this.btnPeruutaLisaus.Location = new System.Drawing.Point(315, 443);
            this.btnPeruutaLisaus.Name = "btnPeruutaLisaus";
            this.btnPeruutaLisaus.Size = new System.Drawing.Size(181, 57);
            this.btnPeruutaLisaus.TabIndex = 59;
            this.btnPeruutaLisaus.Text = "Peruuta";
            this.btnPeruutaLisaus.UseVisualStyleBackColor = true;
            this.btnPeruutaLisaus.Click += new System.EventHandler(this.btnPeruutaLisaus_Click);
            // 
            // btnTallennaMokki
            // 
            this.btnTallennaMokki.Location = new System.Drawing.Point(26, 443);
            this.btnTallennaMokki.Name = "btnTallennaMokki";
            this.btnTallennaMokki.Size = new System.Drawing.Size(181, 57);
            this.btnTallennaMokki.TabIndex = 58;
            this.btnTallennaMokki.Text = "Tallenna";
            this.btnTallennaMokki.UseVisualStyleBackColor = true;
            this.btnTallennaMokki.Click += new System.EventHandler(this.TallennaMokki_Click);
            // 
            // tbMkuvaus
            // 
            this.tbMkuvaus.Location = new System.Drawing.Point(44, 187);
            this.tbMkuvaus.Multiline = true;
            this.tbMkuvaus.Name = "tbMkuvaus";
            this.tbMkuvaus.Size = new System.Drawing.Size(421, 114);
            this.tbMkuvaus.TabIndex = 54;
            this.tbMkuvaus.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbMkuvaus.Validated += new System.EventHandler(this.ValidoituKentta);
            // 
            // tbToimipaikka
            // 
            this.tbToimipaikka.Location = new System.Drawing.Point(259, 135);
            this.tbToimipaikka.Name = "tbToimipaikka";
            this.tbToimipaikka.Size = new System.Drawing.Size(206, 22);
            this.tbToimipaikka.TabIndex = 53;
            this.tbToimipaikka.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbToimipaikka.Validated += new System.EventHandler(this.ValidoituKentta);
            // 
            // tbMposti
            // 
            this.tbMposti.Location = new System.Drawing.Point(44, 135);
            this.tbMposti.Name = "tbMposti";
            this.tbMposti.Size = new System.Drawing.Size(206, 22);
            this.tbMposti.TabIndex = 52;
            this.tbMposti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMposti_KeyPress);
            this.tbMposti.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbMposti_KeyUp);
            this.tbMposti.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbMposti.Validated += new System.EventHandler(this.ValidoituKentta);
            // 
            // tbMHinta
            // 
            this.tbMHinta.Location = new System.Drawing.Point(171, 381);
            this.tbMHinta.Name = "tbMHinta";
            this.tbMHinta.Size = new System.Drawing.Size(206, 22);
            this.tbMHinta.TabIndex = 57;
            this.tbMHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMHinta_KeyPress);
            this.tbMHinta.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbMHinta.Validated += new System.EventHandler(this.ValidoituKentta);
            // 
            // tbMvarustelu
            // 
            this.tbMvarustelu.Location = new System.Drawing.Point(115, 328);
            this.tbMvarustelu.Name = "tbMvarustelu";
            this.tbMvarustelu.Size = new System.Drawing.Size(191, 22);
            this.tbMvarustelu.TabIndex = 55;
            this.tbMvarustelu.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbMvarustelu.Validated += new System.EventHandler(this.ValidoituKentta);
            // 
            // tbMosoite
            // 
            this.tbMosoite.Location = new System.Drawing.Point(44, 90);
            this.tbMosoite.Name = "tbMosoite";
            this.tbMosoite.Size = new System.Drawing.Size(421, 22);
            this.tbMosoite.TabIndex = 51;
            this.tbMosoite.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbMosoite.Validated += new System.EventHandler(this.ValidoituKentta);
            // 
            // tbMnimi
            // 
            this.tbMnimi.Location = new System.Drawing.Point(44, 45);
            this.tbMnimi.Name = "tbMnimi";
            this.tbMnimi.Size = new System.Drawing.Size(421, 22);
            this.tbMnimi.TabIndex = 50;
            this.tbMnimi.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbMnimi.Validated += new System.EventHandler(this.ValidoituKentta);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kuvaus";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Postitoimipaikka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Postinumero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Katuosoite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mökin nimi";
            // 
            // tbMhlomaara
            // 
            this.tbMhlomaara.Location = new System.Drawing.Point(417, 330);
            this.tbMhlomaara.Name = "tbMhlomaara";
            this.tbMhlomaara.Size = new System.Drawing.Size(100, 22);
            this.tbMhlomaara.TabIndex = 56;
            this.tbMhlomaara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMhlomaara_KeyPress);
            this.tbMhlomaara.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbMhlomaara_KeyUp);
            this.tbMhlomaara.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbMhlomaara.Validated += new System.EventHandler(this.ValidoituKentta);
            // 
            // epVirhe
            // 
            this.epVirhe.ContainerControl = this;
            // 
            // MokkiNakyma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 580);
            this.Controls.Add(this.tbMhlomaara);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
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
            this.Text = "MokkiNakyma";
            ((System.ComponentModel.ISupportInitialize)(this.epVirhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPeruutaLisaus;
        private System.Windows.Forms.Button btnTallennaMokki;
        private System.Windows.Forms.TextBox tbMkuvaus;
        private System.Windows.Forms.TextBox tbToimipaikka;
        private System.Windows.Forms.TextBox tbMposti;
        private System.Windows.Forms.TextBox tbMHinta;
        private System.Windows.Forms.TextBox tbMvarustelu;
        private System.Windows.Forms.TextBox tbMosoite;
        private System.Windows.Forms.TextBox tbMnimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMhlomaara;
        private System.Windows.Forms.ErrorProvider epVirhe;
    }
}