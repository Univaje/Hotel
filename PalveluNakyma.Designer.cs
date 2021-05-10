
namespace Hotel
{
    partial class PalveluNakyma
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
            this.ppalvelu_tb = new System.Windows.Forms.TextBox();
            this.ptoimialue_tb = new System.Windows.Forms.TextBox();
            this.peruuta_btn = new System.Windows.Forms.Button();
            this.lisää_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.palvelu_lbl = new System.Windows.Forms.Label();
            this.palv_tb = new System.Windows.Forms.TextBox();
            this.phinta_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pkuvaus_tb = new System.Windows.Forms.TextBox();
            this.ptyyppi_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ppalveluID_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ppalvelu_tb
            // 
            this.ppalvelu_tb.Location = new System.Drawing.Point(185, 152);
            this.ppalvelu_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ppalvelu_tb.Name = "ppalvelu_tb";
            this.ppalvelu_tb.Size = new System.Drawing.Size(229, 26);
            this.ppalvelu_tb.TabIndex = 2;
            this.ppalvelu_tb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ptoimialue_tb
            // 
            this.ptoimialue_tb.Location = new System.Drawing.Point(185, 254);
            this.ptoimialue_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptoimialue_tb.Name = "ptoimialue_tb";
            this.ptoimialue_tb.Size = new System.Drawing.Size(229, 26);
            this.ptoimialue_tb.TabIndex = 2;
            // 
            // peruuta_btn
            // 
            this.peruuta_btn.Location = new System.Drawing.Point(495, 567);
            this.peruuta_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.peruuta_btn.Name = "peruuta_btn";
            this.peruuta_btn.Size = new System.Drawing.Size(255, 80);
            this.peruuta_btn.TabIndex = 4;
            this.peruuta_btn.Text = "Peruuta";
            this.peruuta_btn.UseVisualStyleBackColor = true;
            this.peruuta_btn.Click += new System.EventHandler(this.peruuta_btn_Click);
            // 
            // lisää_btn
            // 
            this.lisää_btn.Location = new System.Drawing.Point(495, 461);
            this.lisää_btn.Name = "lisää_btn";
            this.lisää_btn.Size = new System.Drawing.Size(255, 80);
            this.lisää_btn.TabIndex = 5;
            this.lisää_btn.Text = "Lisää";
            this.lisää_btn.UseVisualStyleBackColor = true;
            this.lisää_btn.Click += new System.EventHandler(this.lisää_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toimialue";
            // 
            // palvelu_lbl
            // 
            this.palvelu_lbl.AutoSize = true;
            this.palvelu_lbl.Location = new System.Drawing.Point(65, 158);
            this.palvelu_lbl.Name = "palvelu_lbl";
            this.palvelu_lbl.Size = new System.Drawing.Size(59, 20);
            this.palvelu_lbl.TabIndex = 7;
            this.palvelu_lbl.Text = "Palvelu";
            // 
            // palv_tb
            // 
            this.palv_tb.Location = new System.Drawing.Point(590, 220);
            this.palv_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.palv_tb.Name = "palv_tb";
            this.palv_tb.Size = new System.Drawing.Size(112, 26);
            this.palv_tb.TabIndex = 8;
            // 
            // phinta_tb
            // 
            this.phinta_tb.Location = new System.Drawing.Point(590, 158);
            this.phinta_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phinta_tb.Name = "phinta_tb";
            this.phinta_tb.Size = new System.Drawing.Size(112, 26);
            this.phinta_tb.TabIndex = 9;
            this.phinta_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phinta_tb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tyyppi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hinta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kuvaus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Alv";
            // 
            // pkuvaus_tb
            // 
            this.pkuvaus_tb.Location = new System.Drawing.Point(185, 396);
            this.pkuvaus_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pkuvaus_tb.Multiline = true;
            this.pkuvaus_tb.Name = "pkuvaus_tb";
            this.pkuvaus_tb.Size = new System.Drawing.Size(229, 82);
            this.pkuvaus_tb.TabIndex = 14;
            // 
            // ptyyppi_tb
            // 
            this.ptyyppi_tb.Location = new System.Drawing.Point(185, 337);
            this.ptyyppi_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptyyppi_tb.Name = "ptyyppi_tb";
            this.ptyyppi_tb.Size = new System.Drawing.Size(112, 26);
            this.ptyyppi_tb.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 40);
            this.label7.TabIndex = 17;
            this.label7.Text = "\r\nPalveluID";
            // 
            // ppalveluID_tb
            // 
            this.ppalveluID_tb.Location = new System.Drawing.Point(185, 204);
            this.ppalveluID_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ppalveluID_tb.Name = "ppalveluID_tb";
            this.ppalveluID_tb.Size = new System.Drawing.Size(112, 26);
            this.ppalveluID_tb.TabIndex = 16;
            this.ppalveluID_tb.Text = "\r\n";
            // 
            // PalveluNakyma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 699);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ppalveluID_tb);
            this.Controls.Add(this.pkuvaus_tb);
            this.Controls.Add(this.ptyyppi_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.palv_tb);
            this.Controls.Add(this.phinta_tb);
            this.Controls.Add(this.palvelu_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lisää_btn);
            this.Controls.Add(this.peruuta_btn);
            this.Controls.Add(this.ptoimialue_tb);
            this.Controls.Add(this.ppalvelu_tb);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PalveluNakyma";
            this.Text = "PalveluNakyma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ppalvelu_tb;
        private System.Windows.Forms.TextBox ptoimialue_tb;
        private System.Windows.Forms.Button peruuta_btn;
        private System.Windows.Forms.Button lisää_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label palvelu_lbl;
        private System.Windows.Forms.TextBox palv_tb;
        private System.Windows.Forms.TextBox phinta_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pkuvaus_tb;
        private System.Windows.Forms.TextBox ptyyppi_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ppalveluID_tb;
    }
}