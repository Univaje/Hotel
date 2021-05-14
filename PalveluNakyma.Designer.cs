
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
            this.SuspendLayout();
            // 
            // ppalvelu_tb
            // 
            this.ppalvelu_tb.Location = new System.Drawing.Point(123, 99);
            this.ppalvelu_tb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ppalvelu_tb.Name = "ppalvelu_tb";
            this.ppalvelu_tb.Size = new System.Drawing.Size(154, 20);
            this.ppalvelu_tb.TabIndex = 1;
            this.ppalvelu_tb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ptoimialue_tb
            // 
            this.ptoimialue_tb.Location = new System.Drawing.Point(123, 143);
            this.ptoimialue_tb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ptoimialue_tb.Name = "ptoimialue_tb";
            this.ptoimialue_tb.Size = new System.Drawing.Size(154, 20);
            this.ptoimialue_tb.TabIndex = 2;
            // 
            // peruuta_btn
            // 
            this.peruuta_btn.Location = new System.Drawing.Point(330, 369);
            this.peruuta_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.peruuta_btn.Name = "peruuta_btn";
            this.peruuta_btn.Size = new System.Drawing.Size(170, 52);
            this.peruuta_btn.TabIndex = 8;
            this.peruuta_btn.Text = "Peruuta";
            this.peruuta_btn.UseVisualStyleBackColor = true;
            this.peruuta_btn.Click += new System.EventHandler(this.peruuta_btn_Click);
            // 
            // lisää_btn
            // 
            this.lisää_btn.Location = new System.Drawing.Point(330, 300);
            this.lisää_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lisää_btn.Name = "lisää_btn";
            this.lisää_btn.Size = new System.Drawing.Size(170, 52);
            this.lisää_btn.TabIndex = 7;
            this.lisää_btn.Text = "Lisää";
            this.lisää_btn.UseVisualStyleBackColor = true;
            this.lisää_btn.Click += new System.EventHandler(this.lisää_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toimialue";
            // 
            // palvelu_lbl
            // 
            this.palvelu_lbl.AutoSize = true;
            this.palvelu_lbl.Location = new System.Drawing.Point(43, 103);
            this.palvelu_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.palvelu_lbl.Name = "palvelu_lbl";
            this.palvelu_lbl.Size = new System.Drawing.Size(42, 13);
            this.palvelu_lbl.TabIndex = 7;
            this.palvelu_lbl.Text = "Palvelu";
            // 
            // palv_tb
            // 
            this.palv_tb.Location = new System.Drawing.Point(393, 143);
            this.palv_tb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.palv_tb.Name = "palv_tb";
            this.palv_tb.Size = new System.Drawing.Size(76, 20);
            this.palv_tb.TabIndex = 6;
            // 
            // phinta_tb
            // 
            this.phinta_tb.Location = new System.Drawing.Point(393, 103);
            this.phinta_tb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.phinta_tb.Name = "phinta_tb";
            this.phinta_tb.Size = new System.Drawing.Size(76, 20);
            this.phinta_tb.TabIndex = 5;
            this.phinta_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phinta_tb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tyyppi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hinta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kuvaus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Alv";
            // 
            // pkuvaus_tb
            // 
            this.pkuvaus_tb.Location = new System.Drawing.Point(123, 257);
            this.pkuvaus_tb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pkuvaus_tb.Multiline = true;
            this.pkuvaus_tb.Name = "pkuvaus_tb";
            this.pkuvaus_tb.Size = new System.Drawing.Size(154, 55);
            this.pkuvaus_tb.TabIndex = 4;
            // 
            // ptyyppi_tb
            // 
            this.ptyyppi_tb.Location = new System.Drawing.Point(123, 219);
            this.ptyyppi_tb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ptyyppi_tb.Name = "ptyyppi_tb";
            this.ptyyppi_tb.Size = new System.Drawing.Size(76, 20);
            this.ptyyppi_tb.TabIndex = 3;
            // 
            // PalveluNakyma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 454);
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
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
    }
}