
namespace Hotel
{
    partial class HotelManhattan
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tpAsiakas = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tpMokki = new System.Windows.Forms.TabPage();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Hotel.DataSet1();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tcHotelli = new System.Windows.Forms.TabControl();
            this.tpToimialue = new System.Windows.Forms.TabPage();
            this.btnToimialue8 = new System.Windows.Forms.Button();
            this.btnToimialue7 = new System.Windows.Forms.Button();
            this.btnToimialue6 = new System.Windows.Forms.Button();
            this.btnToimialue5 = new System.Windows.Forms.Button();
            this.btnToimialue4 = new System.Windows.Forms.Button();
            this.btnToimialue3 = new System.Windows.Forms.Button();
            this.btnToimialue2 = new System.Windows.Forms.Button();
            this.btnToimialue1 = new System.Windows.Forms.Button();
            this.tpPalvelut = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tpLaskut = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mokkiTableAdapter = new Hotel.DataSet1TableAdapters.mokkiTableAdapter();
            this.tpAsiakas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tpMokki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tcHotelli.SuspendLayout();
            this.tpToimialue.SuspendLayout();
            this.tpPalvelut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tpLaskut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tpAsiakas
            // 
            this.tpAsiakas.Controls.Add(this.dataGridView3);
            this.tpAsiakas.Location = new System.Drawing.Point(4, 25);
            this.tpAsiakas.Name = "tpAsiakas";
            this.tpAsiakas.Padding = new System.Windows.Forms.Padding(3);
            this.tpAsiakas.Size = new System.Drawing.Size(1051, 431);
            this.tpAsiakas.TabIndex = 1;
            this.tpAsiakas.Text = "Asiakas";
            this.tpAsiakas.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(852, 358);
            this.dataGridView3.TabIndex = 0;
            // 
            // tpMokki
            // 
            this.tpMokki.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tpMokki.Controls.Add(this.btnMuokkaa);
            this.tpMokki.Controls.Add(this.btnPoista);
            this.tpMokki.Controls.Add(this.btnLisaa);
            this.tpMokki.Controls.Add(this.dataGridView1);
            this.tpMokki.Controls.Add(this.tabControl2);
            this.tpMokki.Location = new System.Drawing.Point(4, 25);
            this.tpMokki.Name = "tpMokki";
            this.tpMokki.Padding = new System.Windows.Forms.Padding(3);
            this.tpMokki.Size = new System.Drawing.Size(1051, 431);
            this.tpMokki.TabIndex = 0;
            this.tpMokki.Text = "Mökki";
            this.tpMokki.UseVisualStyleBackColor = true;
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMuokkaa.Location = new System.Drawing.Point(423, 370);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(234, 57);
            this.btnMuokkaa.TabIndex = 4;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnPoista
            // 
            this.btnPoista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoista.Location = new System.Drawing.Point(831, 372);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(217, 59);
            this.btnPoista.TabIndex = 3;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisaa.Location = new System.Drawing.Point(2, 370);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(208, 58);
            this.btnLisaa.TabIndex = 2;
            this.btnLisaa.Text = "Lisaa";
            this.btnLisaa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, -4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 370);
            this.dataGridView1.TabIndex = 1;
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(433, 319);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(8, 8);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tcHotelli
            // 
            this.tcHotelli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcHotelli.Controls.Add(this.tpToimialue);
            this.tcHotelli.Controls.Add(this.tpMokki);
            this.tcHotelli.Controls.Add(this.tpPalvelut);
            this.tcHotelli.Controls.Add(this.tpAsiakas);
            this.tcHotelli.Controls.Add(this.tpLaskut);
            this.tcHotelli.Controls.Add(this.tabPage1);
            this.tcHotelli.Location = new System.Drawing.Point(0, 0);
            this.tcHotelli.Name = "tcHotelli";
            this.tcHotelli.SelectedIndex = 0;
            this.tcHotelli.Size = new System.Drawing.Size(1059, 460);
            this.tcHotelli.TabIndex = 0;
            // 
            // tpToimialue
            // 
            this.tpToimialue.Controls.Add(this.btnToimialue8);
            this.tpToimialue.Controls.Add(this.btnToimialue7);
            this.tpToimialue.Controls.Add(this.btnToimialue6);
            this.tpToimialue.Controls.Add(this.btnToimialue5);
            this.tpToimialue.Controls.Add(this.btnToimialue4);
            this.tpToimialue.Controls.Add(this.btnToimialue3);
            this.tpToimialue.Controls.Add(this.btnToimialue2);
            this.tpToimialue.Controls.Add(this.btnToimialue1);
            this.tpToimialue.Location = new System.Drawing.Point(4, 25);
            this.tpToimialue.Name = "tpToimialue";
            this.tpToimialue.Size = new System.Drawing.Size(1051, 431);
            this.tpToimialue.TabIndex = 4;
            this.tpToimialue.Text = "Toimialue";
            this.tpToimialue.UseVisualStyleBackColor = true;
            // 
            // btnToimialue8
            // 
            this.btnToimialue8.Location = new System.Drawing.Point(644, 209);
            this.btnToimialue8.Name = "btnToimialue8";
            this.btnToimialue8.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue8.TabIndex = 0;
            this.btnToimialue8.Text = "Saariselkä";
            this.btnToimialue8.UseVisualStyleBackColor = true;
            this.btnToimialue8.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue7
            // 
            this.btnToimialue7.Location = new System.Drawing.Point(432, 209);
            this.btnToimialue7.Name = "btnToimialue7";
            this.btnToimialue7.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue7.TabIndex = 0;
            this.btnToimialue7.Text = "Pyhä";
            this.btnToimialue7.UseVisualStyleBackColor = true;
            this.btnToimialue7.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue6
            // 
            this.btnToimialue6.Location = new System.Drawing.Point(220, 209);
            this.btnToimialue6.Name = "btnToimialue6";
            this.btnToimialue6.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue6.TabIndex = 0;
            this.btnToimialue6.Text = "Tahko";
            this.btnToimialue6.UseVisualStyleBackColor = true;
            this.btnToimialue6.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue5
            // 
            this.btnToimialue5.Location = new System.Drawing.Point(8, 209);
            this.btnToimialue5.Name = "btnToimialue5";
            this.btnToimialue5.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue5.TabIndex = 0;
            this.btnToimialue5.Text = "Vuokatti";
            this.btnToimialue5.UseVisualStyleBackColor = true;
            this.btnToimialue5.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue4
            // 
            this.btnToimialue4.Location = new System.Drawing.Point(644, 3);
            this.btnToimialue4.Name = "btnToimialue4";
            this.btnToimialue4.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue4.TabIndex = 0;
            this.btnToimialue4.Text = "Salla";
            this.btnToimialue4.UseVisualStyleBackColor = true;
            this.btnToimialue4.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue3
            // 
            this.btnToimialue3.Location = new System.Drawing.Point(432, 3);
            this.btnToimialue3.Name = "btnToimialue3";
            this.btnToimialue3.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue3.TabIndex = 0;
            this.btnToimialue3.Text = "Ruka";
            this.btnToimialue3.UseVisualStyleBackColor = true;
            this.btnToimialue3.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue2
            // 
            this.btnToimialue2.Location = new System.Drawing.Point(220, 3);
            this.btnToimialue2.Name = "btnToimialue2";
            this.btnToimialue2.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue2.TabIndex = 0;
            this.btnToimialue2.Text = "Levi";
            this.btnToimialue2.UseVisualStyleBackColor = true;
            this.btnToimialue2.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue1
            // 
            this.btnToimialue1.Location = new System.Drawing.Point(8, 3);
            this.btnToimialue1.Name = "btnToimialue1";
            this.btnToimialue1.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue1.TabIndex = 0;
            this.btnToimialue1.Text = "Ylläs";
            this.btnToimialue1.UseVisualStyleBackColor = true;
            this.btnToimialue1.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // tpPalvelut
            // 
            this.tpPalvelut.Controls.Add(this.dataGridView2);
            this.tpPalvelut.Location = new System.Drawing.Point(4, 25);
            this.tpPalvelut.Name = "tpPalvelut";
            this.tpPalvelut.Size = new System.Drawing.Size(1051, 431);
            this.tpPalvelut.TabIndex = 3;
            this.tpPalvelut.Text = "Palvelut";
            this.tpPalvelut.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(992, 358);
            this.dataGridView2.TabIndex = 0;
            // 
            // tpLaskut
            // 
            this.tpLaskut.Controls.Add(this.dataGridView4);
            this.tpLaskut.Location = new System.Drawing.Point(4, 25);
            this.tpLaskut.Name = "tpLaskut";
            this.tpLaskut.Size = new System.Drawing.Size(1051, 431);
            this.tpLaskut.TabIndex = 2;
            this.tpLaskut.Text = "Laskut";
            this.tpLaskut.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(858, 361);
            this.dataGridView4.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 431);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Varaukset";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // HotelManhattan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 467);
            this.Controls.Add(this.tcHotelli);
            this.Name = "HotelManhattan";
            this.Text = "Hotel Manhanttan";
            this.Load += new System.EventHandler(this.HotelManhattan_Load);
            this.tpAsiakas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tpMokki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tcHotelli.ResumeLayout(false);
            this.tpToimialue.ResumeLayout(false);
            this.tpPalvelut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tpLaskut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage tpAsiakas;
        private System.Windows.Forms.TabPage tpMokki;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tcHotelli;
        private System.Windows.Forms.TabPage tpLaskut;
        private System.Windows.Forms.TabPage tpPalvelut;
        private System.Windows.Forms.TabPage tpToimialue;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnToimialue8;
        private System.Windows.Forms.Button btnToimialue7;
        private System.Windows.Forms.Button btnToimialue6;
        private System.Windows.Forms.Button btnToimialue5;
        private System.Windows.Forms.Button btnToimialue4;
        private System.Windows.Forms.Button btnToimialue3;
        private System.Windows.Forms.Button btnToimialue2;
        private System.Windows.Forms.Button btnToimialue1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnLisaa;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private DataSet1TableAdapters.mokkiTableAdapter mokkiTableAdapter;
    }
}

