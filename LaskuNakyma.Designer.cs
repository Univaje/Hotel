﻿namespace Hotel
{
    partial class LaskuNakyma
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
            this.LaskuIdtxt = new System.Windows.Forms.TextBox();
            this.Varausid1tx = new System.Windows.Forms.TextBox();
            this.Summatxt = new System.Windows.Forms.TextBox();
            this.ALVtxt = new System.Windows.Forms.TextBox();
            this.LaskuIDmuokkaus = new System.Windows.Forms.Label();
            this.VarausID1muokkaus = new System.Windows.Forms.Label();
            this.Summamuokkaus = new System.Windows.Forms.Label();
            this.Alvmuokkaus = new System.Windows.Forms.Label();
            this.TallennaLasku = new System.Windows.Forms.Button();
            this.PeruutaLasku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LaskuIdtxt
            // 
            this.LaskuIdtxt.Location = new System.Drawing.Point(183, 34);
            this.LaskuIdtxt.Name = "LaskuIdtxt";
            this.LaskuIdtxt.Size = new System.Drawing.Size(100, 20);
            this.LaskuIdtxt.TabIndex = 0;
            // 
            // Varausid1tx
            // 
            this.Varausid1tx.Location = new System.Drawing.Point(183, 94);
            this.Varausid1tx.Name = "Varausid1tx";
            this.Varausid1tx.Size = new System.Drawing.Size(100, 20);
            this.Varausid1tx.TabIndex = 1;
            // 
            // Summatxt
            // 
            this.Summatxt.Location = new System.Drawing.Point(183, 159);
            this.Summatxt.Name = "Summatxt";
            this.Summatxt.Size = new System.Drawing.Size(100, 20);
            this.Summatxt.TabIndex = 2;
            // 
            // ALVtxt
            // 
            this.ALVtxt.Location = new System.Drawing.Point(183, 222);
            this.ALVtxt.Name = "ALVtxt";
            this.ALVtxt.Size = new System.Drawing.Size(100, 20);
            this.ALVtxt.TabIndex = 3;
            // 
            // LaskuIDmuokkaus
            // 
            this.LaskuIDmuokkaus.AutoSize = true;
            this.LaskuIDmuokkaus.Location = new System.Drawing.Point(47, 34);
            this.LaskuIDmuokkaus.Name = "LaskuIDmuokkaus";
            this.LaskuIDmuokkaus.Size = new System.Drawing.Size(47, 13);
            this.LaskuIDmuokkaus.TabIndex = 4;
            this.LaskuIDmuokkaus.Text = "LaskuID";
            // 
            // VarausID1muokkaus
            // 
            this.VarausID1muokkaus.AutoSize = true;
            this.VarausID1muokkaus.Location = new System.Drawing.Point(47, 94);
            this.VarausID1muokkaus.Name = "VarausID1muokkaus";
            this.VarausID1muokkaus.Size = new System.Drawing.Size(57, 13);
            this.VarausID1muokkaus.TabIndex = 5;
            this.VarausID1muokkaus.Text = "VarausID1";
            // 
            // Summamuokkaus
            // 
            this.Summamuokkaus.AutoSize = true;
            this.Summamuokkaus.Location = new System.Drawing.Point(50, 166);
            this.Summamuokkaus.Name = "Summamuokkaus";
            this.Summamuokkaus.Size = new System.Drawing.Size(42, 13);
            this.Summamuokkaus.TabIndex = 6;
            this.Summamuokkaus.Text = "Summa";
            // 
            // Alvmuokkaus
            // 
            this.Alvmuokkaus.AutoSize = true;
            this.Alvmuokkaus.Location = new System.Drawing.Point(50, 228);
            this.Alvmuokkaus.Name = "Alvmuokkaus";
            this.Alvmuokkaus.Size = new System.Drawing.Size(27, 13);
            this.Alvmuokkaus.TabIndex = 7;
            this.Alvmuokkaus.Text = "ALV";
            // 
            // TallennaLasku
            // 
            this.TallennaLasku.Location = new System.Drawing.Point(72, 318);
            this.TallennaLasku.Name = "TallennaLasku";
            this.TallennaLasku.Size = new System.Drawing.Size(102, 47);
            this.TallennaLasku.TabIndex = 8;
            this.TallennaLasku.Text = "Tallenna";
            this.TallennaLasku.UseVisualStyleBackColor = true;
            this.TallennaLasku.Click += new System.EventHandler(this.TallennaLasku_Click);
            // 
            // PeruutaLasku
            // 
            this.PeruutaLasku.Location = new System.Drawing.Point(229, 318);
            this.PeruutaLasku.Name = "PeruutaLasku";
            this.PeruutaLasku.Size = new System.Drawing.Size(103, 47);
            this.PeruutaLasku.TabIndex = 9;
            this.PeruutaLasku.Text = "Peruuta";
            this.PeruutaLasku.UseVisualStyleBackColor = true;
            this.PeruutaLasku.Click += new System.EventHandler(this.PeruutaLasku_Click);
            // 
            // LaskuNakyma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 432);
            this.Controls.Add(this.PeruutaLasku);
            this.Controls.Add(this.TallennaLasku);
            this.Controls.Add(this.Alvmuokkaus);
            this.Controls.Add(this.Summamuokkaus);
            this.Controls.Add(this.VarausID1muokkaus);
            this.Controls.Add(this.LaskuIDmuokkaus);
            this.Controls.Add(this.ALVtxt);
            this.Controls.Add(this.Summatxt);
            this.Controls.Add(this.Varausid1tx);
            this.Controls.Add(this.LaskuIdtxt);
            this.Name = "LaskuNakyma";
            this.Text = "LaskuNakyma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LaskuIdtxt;
        private System.Windows.Forms.TextBox Varausid1tx;
        private System.Windows.Forms.TextBox Summatxt;
        private System.Windows.Forms.TextBox ALVtxt;
        private System.Windows.Forms.Label LaskuIDmuokkaus;
        private System.Windows.Forms.Label VarausID1muokkaus;
        private System.Windows.Forms.Label Summamuokkaus;
        private System.Windows.Forms.Label Alvmuokkaus;
        private System.Windows.Forms.Button TallennaLasku;
        private System.Windows.Forms.Button PeruutaLasku;
    }
}