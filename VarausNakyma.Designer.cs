
namespace Hotel
{
    partial class VarausNakyma
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbUusiAsiakasVarauksessa = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVMokki = new System.Windows.Forms.ComboBox();
            this.cbVAsiakas = new System.Windows.Forms.ComboBox();
            this.cbVtoimialue = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpVarausLoppuu = new System.Windows.Forms.DateTimePicker();
            this.dtpVarausAlkaa = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPalvelut = new System.Windows.Forms.ListBox();
            this.tbvHenkilomaara = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnvPoistaPalvelu = new System.Windows.Forms.Button();
            this.btnvPalvelunLisaus = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbvPalvelunlisäys = new System.Windows.Forms.ComboBox();
            this.gbUuVaAs = new System.Windows.Forms.GroupBox();
            this.tbvToimipaikka = new System.Windows.Forms.TextBox();
            this.tbvPostinumero = new System.Windows.Forms.TextBox();
            this.tbvPuhnum = new System.Windows.Forms.TextBox();
            this.tbvSposti = new System.Windows.Forms.TextBox();
            this.tbvOsoite = new System.Windows.Forms.TextBox();
            this.tbvSukunimi = new System.Windows.Forms.TextBox();
            this.tbvEtunimi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnvTallenna = new System.Windows.Forms.Button();
            this.epVirhe = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbUuVaAs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epVirhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbUusiAsiakasVarauksessa);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbVMokki);
            this.groupBox3.Controls.Add(this.cbVAsiakas);
            this.groupBox3.Controls.Add(this.cbVtoimialue);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 208);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // cbUusiAsiakasVarauksessa
            // 
            this.cbUusiAsiakasVarauksessa.AutoSize = true;
            this.cbUusiAsiakasVarauksessa.Location = new System.Drawing.Point(6, 181);
            this.cbUusiAsiakasVarauksessa.Name = "cbUusiAsiakasVarauksessa";
            this.cbUusiAsiakasVarauksessa.Size = new System.Drawing.Size(111, 21);
            this.cbUusiAsiakasVarauksessa.TabIndex = 19;
            this.cbUusiAsiakasVarauksessa.Text = "Uusi Asiakas";
            this.cbUusiAsiakasVarauksessa.UseVisualStyleBackColor = true;
            this.cbUusiAsiakasVarauksessa.CheckedChanged += new System.EventHandler(this.UusiAsiakasVarauksessa_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mökki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Asiakas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Toimialue";
            // 
            // cbVMokki
            // 
            this.cbVMokki.FormattingEnabled = true;
            this.cbVMokki.Location = new System.Drawing.Point(6, 151);
            this.cbVMokki.Name = "cbVMokki";
            this.cbVMokki.Size = new System.Drawing.Size(496, 24);
            this.cbVMokki.TabIndex = 3;
            // 
            // cbVAsiakas
            // 
            this.cbVAsiakas.FormattingEnabled = true;
            this.cbVAsiakas.Location = new System.Drawing.Point(6, 83);
            this.cbVAsiakas.Name = "cbVAsiakas";
            this.cbVAsiakas.Size = new System.Drawing.Size(496, 24);
            this.cbVAsiakas.TabIndex = 2;
            // 
            // cbVtoimialue
            // 
            this.cbVtoimialue.FormattingEnabled = true;
            this.cbVtoimialue.Location = new System.Drawing.Point(6, 21);
            this.cbVtoimialue.Name = "cbVtoimialue";
            this.cbVtoimialue.Size = new System.Drawing.Size(496, 24);
            this.cbVtoimialue.TabIndex = 1;
            this.cbVtoimialue.SelectedIndexChanged += new System.EventHandler(this.cbVtoimialue_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpVarausLoppuu);
            this.groupBox2.Controls.Add(this.dtpVarausAlkaa);
            this.groupBox2.Location = new System.Drawing.Point(12, 543);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 133);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Loppu päivämäärä";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Alku päivämäärä";
            // 
            // dtpVarausLoppuu
            // 
            this.dtpVarausLoppuu.Location = new System.Drawing.Point(28, 92);
            this.dtpVarausLoppuu.Name = "dtpVarausLoppuu";
            this.dtpVarausLoppuu.Size = new System.Drawing.Size(465, 22);
            this.dtpVarausLoppuu.TabIndex = 12;
            // 
            // dtpVarausAlkaa
            // 
            this.dtpVarausAlkaa.Location = new System.Drawing.Point(28, 33);
            this.dtpVarausAlkaa.Name = "dtpVarausAlkaa";
            this.dtpVarausAlkaa.Size = new System.Drawing.Size(465, 22);
            this.dtpVarausAlkaa.TabIndex = 11;
            this.dtpVarausAlkaa.ValueChanged += new System.EventHandler(this.ctpVarausAlkaa_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPalvelut);
            this.groupBox1.Controls.Add(this.tbvHenkilomaara);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnvPoistaPalvelu);
            this.groupBox1.Controls.Add(this.btnvPalvelunLisaus);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbvPalvelunlisäys);
            this.groupBox1.Location = new System.Drawing.Point(536, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 586);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // lbPalvelut
            // 
            this.lbPalvelut.FormattingEnabled = true;
            this.lbPalvelut.ItemHeight = 16;
            this.lbPalvelut.Location = new System.Drawing.Point(6, 246);
            this.lbPalvelut.Name = "lbPalvelut";
            this.lbPalvelut.Size = new System.Drawing.Size(326, 180);
            this.lbPalvelut.TabIndex = 101;
            // 
            // tbvHenkilomaara
            // 
            this.tbvHenkilomaara.Location = new System.Drawing.Point(120, 101);
            this.tbvHenkilomaara.Name = "tbvHenkilomaara";
            this.tbvHenkilomaara.Size = new System.Drawing.Size(100, 22);
            this.tbvHenkilomaara.TabIndex = 15;
            this.tbvHenkilomaara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHenkilomaara_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Henkilömäärä";
            // 
            // btnvPoistaPalvelu
            // 
            this.btnvPoistaPalvelu.Location = new System.Drawing.Point(18, 466);
            this.btnvPoistaPalvelu.Name = "btnvPoistaPalvelu";
            this.btnvPoistaPalvelu.Size = new System.Drawing.Size(325, 50);
            this.btnvPoistaPalvelu.TabIndex = 18;
            this.btnvPoistaPalvelu.Text = "Poista palvelu";
            this.btnvPoistaPalvelu.UseVisualStyleBackColor = true;
            this.btnvPoistaPalvelu.Click += new System.EventHandler(this.btnvPoistaPalvelu_Click);
            // 
            // btnvPalvelunLisaus
            // 
            this.btnvPalvelunLisaus.Location = new System.Drawing.Point(16, 173);
            this.btnvPalvelunLisaus.Name = "btnvPalvelunLisaus";
            this.btnvPalvelunLisaus.Size = new System.Drawing.Size(325, 50);
            this.btnvPalvelunLisaus.TabIndex = 16;
            this.btnvPalvelunLisaus.Text = "Lisää palvelu";
            this.btnvPalvelunLisaus.UseVisualStyleBackColor = true;
            this.btnvPalvelunLisaus.Click += new System.EventHandler(this.btnvPalvelunLisaus_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 99;
            this.label14.Text = "Lisää palvelu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Palvelut";
            // 
            // cbvPalvelunlisäys
            // 
            this.cbvPalvelunlisäys.FormattingEnabled = true;
            this.cbvPalvelunlisäys.ItemHeight = 16;
            this.cbvPalvelunlisäys.Location = new System.Drawing.Point(18, 46);
            this.cbvPalvelunlisäys.Name = "cbvPalvelunlisäys";
            this.cbvPalvelunlisäys.Size = new System.Drawing.Size(324, 24);
            this.cbvPalvelunlisäys.TabIndex = 14;
            // 
            // gbUuVaAs
            // 
            this.gbUuVaAs.Controls.Add(this.tbvToimipaikka);
            this.gbUuVaAs.Controls.Add(this.tbvPostinumero);
            this.gbUuVaAs.Controls.Add(this.tbvPuhnum);
            this.gbUuVaAs.Controls.Add(this.tbvSposti);
            this.gbUuVaAs.Controls.Add(this.tbvOsoite);
            this.gbUuVaAs.Controls.Add(this.tbvSukunimi);
            this.gbUuVaAs.Controls.Add(this.tbvEtunimi);
            this.gbUuVaAs.Controls.Add(this.label13);
            this.gbUuVaAs.Controls.Add(this.label9);
            this.gbUuVaAs.Controls.Add(this.label8);
            this.gbUuVaAs.Controls.Add(this.label7);
            this.gbUuVaAs.Controls.Add(this.label6);
            this.gbUuVaAs.Controls.Add(this.label5);
            this.gbUuVaAs.Controls.Add(this.label4);
            this.gbUuVaAs.Location = new System.Drawing.Point(12, 220);
            this.gbUuVaAs.Name = "gbUuVaAs";
            this.gbUuVaAs.Size = new System.Drawing.Size(518, 317);
            this.gbUuVaAs.TabIndex = 29;
            this.gbUuVaAs.TabStop = false;
            this.gbUuVaAs.Visible = false;
            // 
            // tbvToimipaikka
            // 
            this.tbvToimipaikka.Location = new System.Drawing.Point(151, 196);
            this.tbvToimipaikka.Name = "tbvToimipaikka";
            this.tbvToimipaikka.Size = new System.Drawing.Size(345, 22);
            this.tbvToimipaikka.TabIndex = 8;
            this.tbvToimipaikka.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbvToimipaikka.Validated += new System.EventHandler(this.Validoitukentta);
            // 
            // tbvPostinumero
            // 
            this.tbvPostinumero.Location = new System.Drawing.Point(151, 157);
            this.tbvPostinumero.Name = "tbvPostinumero";
            this.tbvPostinumero.Size = new System.Drawing.Size(345, 22);
            this.tbvPostinumero.TabIndex = 7;
            this.tbvPostinumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbvPostinumero_KeyPress);
            this.tbvPostinumero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbvPostinumero_KeyUp);
            this.tbvPostinumero.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbvPostinumero.Validated += new System.EventHandler(this.Validoitukentta);
            // 
            // tbvPuhnum
            // 
            this.tbvPuhnum.Location = new System.Drawing.Point(151, 271);
            this.tbvPuhnum.Name = "tbvPuhnum";
            this.tbvPuhnum.Size = new System.Drawing.Size(345, 22);
            this.tbvPuhnum.TabIndex = 10;
            this.tbvPuhnum.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbvPuhnum.Validated += new System.EventHandler(this.Validoitukentta);
            // 
            // tbvSposti
            // 
            this.tbvSposti.Location = new System.Drawing.Point(151, 238);
            this.tbvSposti.Name = "tbvSposti";
            this.tbvSposti.Size = new System.Drawing.Size(345, 22);
            this.tbvSposti.TabIndex = 9;
            this.tbvSposti.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbvSposti.Validated += new System.EventHandler(this.Validoitukentta);
            // 
            // tbvOsoite
            // 
            this.tbvOsoite.Location = new System.Drawing.Point(151, 117);
            this.tbvOsoite.Name = "tbvOsoite";
            this.tbvOsoite.Size = new System.Drawing.Size(345, 22);
            this.tbvOsoite.TabIndex = 6;
            this.tbvOsoite.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbvOsoite.Validated += new System.EventHandler(this.Validoitukentta);
            // 
            // tbvSukunimi
            // 
            this.tbvSukunimi.Location = new System.Drawing.Point(151, 73);
            this.tbvSukunimi.Name = "tbvSukunimi";
            this.tbvSukunimi.Size = new System.Drawing.Size(345, 22);
            this.tbvSukunimi.TabIndex = 5;
            this.tbvSukunimi.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbvSukunimi.Validated += new System.EventHandler(this.Validoitukentta);
            // 
            // tbvEtunimi
            // 
            this.tbvEtunimi.Location = new System.Drawing.Point(151, 25);
            this.tbvEtunimi.Name = "tbvEtunimi";
            this.tbvEtunimi.Size = new System.Drawing.Size(345, 22);
            this.tbvEtunimi.TabIndex = 4;
            this.tbvEtunimi.Validating += new System.ComponentModel.CancelEventHandler(this.Validoikentta);
            this.tbvEtunimi.Validated += new System.EventHandler(this.Validoitukentta);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Postitoimipaikka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Postinumero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Puhelin numero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sähköposti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lähiosoite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sukunimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Etunimi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(727, 619);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 48);
            this.button2.TabIndex = 20;
            this.button2.Text = "Peruuta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btvCancel_Click);
            // 
            // btnvTallenna
            // 
            this.btnvTallenna.Location = new System.Drawing.Point(553, 619);
            this.btnvTallenna.Name = "btnvTallenna";
            this.btnvTallenna.Size = new System.Drawing.Size(152, 48);
            this.btnvTallenna.TabIndex = 19;
            this.btnvTallenna.Text = "Lisää varaus";
            this.btnvTallenna.UseVisualStyleBackColor = true;
            this.btnvTallenna.Click += new System.EventHandler(this.btnvTallenna_Click);
            // 
            // epVirhe
            // 
            this.epVirhe.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // VarausNakyma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 699);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbUuVaAs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnvTallenna);
            this.Name = "VarausNakyma";
            this.Text = "VarausNakyma";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbUuVaAs.ResumeLayout(false);
            this.gbUuVaAs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epVirhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbUusiAsiakasVarauksessa;
        private System.Windows.Forms.GroupBox gbUuVaAs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVMokki;
        private System.Windows.Forms.ComboBox cbVAsiakas;
        private System.Windows.Forms.ComboBox cbVtoimialue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpVarausLoppuu;
        private System.Windows.Forms.DateTimePicker dtpVarausAlkaa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbvHenkilomaara;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnvPoistaPalvelu;
        private System.Windows.Forms.Button btnvPalvelunLisaus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbvPalvelunlisäys;
        private System.Windows.Forms.TextBox tbvToimipaikka;
        private System.Windows.Forms.TextBox tbvPostinumero;
        private System.Windows.Forms.TextBox tbvPuhnum;
        private System.Windows.Forms.TextBox tbvSposti;
        private System.Windows.Forms.TextBox tbvOsoite;
        private System.Windows.Forms.TextBox tbvSukunimi;
        private System.Windows.Forms.TextBox tbvEtunimi;
        private System.Windows.Forms.Button btnvTallenna;
        private System.Windows.Forms.ListBox lbPalvelut;
        private System.Windows.Forms.ErrorProvider epVirhe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}