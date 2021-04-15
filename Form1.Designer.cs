
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
            this.tpAsiakas = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tpMokki = new System.Windows.Forms.TabPage();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tcHotelli = new System.Windows.Forms.TabControl();
            this.tpToimialue = new System.Windows.Forms.TabPage();
            this.dgv11 = new System.Windows.Forms.DataGridView();
            this.tpPalvelut = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tpLaskut = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.manhattanProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manhattanProject = new Hotel.ManhattanProject();
            this.toimintaalueTableAdapter = new Hotel.ManhattanProjectTableAdapters.toimintaalueTableAdapter();
            this.mokkiTableAdapter1 = new Hotel.ManhattanProjectTableAdapters.mokkiTableAdapter();
            this.btnToimialue1 = new System.Windows.Forms.Button();
            this.btnToimialue2 = new System.Windows.Forms.Button();
            this.btnToimialue3 = new System.Windows.Forms.Button();
            this.btnToimialue4 = new System.Windows.Forms.Button();
            this.btnToimialue5 = new System.Windows.Forms.Button();
            this.btnToimialue6 = new System.Windows.Forms.Button();
            this.btnToimialue7 = new System.Windows.Forms.Button();
            this.btnToimialue8 = new System.Windows.Forms.Button();
            this.tpAsiakas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tpMokki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tcHotelli.SuspendLayout();
            this.tpToimialue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv11)).BeginInit();
            this.tpPalvelut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tpLaskut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manhattanProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manhattanProject)).BeginInit();
            this.SuspendLayout();
            // 
            // tpAsiakas
            // 
            this.tpAsiakas.Controls.Add(this.dataGridView3);
            this.tpAsiakas.Location = new System.Drawing.Point(4, 25);
            this.tpAsiakas.Name = "tpAsiakas";
            this.tpAsiakas.Padding = new System.Windows.Forms.Padding(3);
            this.tpAsiakas.Size = new System.Drawing.Size(1507, 654);
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
            this.tpMokki.Controls.Add(this.dgvMokit);
            this.tpMokki.Controls.Add(this.tabControl2);
            this.tpMokki.Location = new System.Drawing.Point(4, 25);
            this.tpMokki.Name = "tpMokki";
            this.tpMokki.Padding = new System.Windows.Forms.Padding(3);
            this.tpMokki.Size = new System.Drawing.Size(1507, 654);
            this.tpMokki.TabIndex = 0;
            this.tpMokki.Text = "Mökki";
            this.tpMokki.UseVisualStyleBackColor = true;
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMuokkaa.Location = new System.Drawing.Point(642, 580);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(234, 57);
            this.btnMuokkaa.TabIndex = 4;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnPoista
            // 
            this.btnPoista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoista.Location = new System.Drawing.Point(1270, 582);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(217, 59);
            this.btnPoista.TabIndex = 3;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisaa.Location = new System.Drawing.Point(2, 580);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(208, 58);
            this.btnLisaa.TabIndex = 2;
            this.btnLisaa.Text = "Lisaa";
            this.btnLisaa.UseVisualStyleBackColor = true;
            // 
            // dgvMokit
            // 
            this.dgvMokit.AllowUserToAddRows = false;
            this.dgvMokit.AllowUserToDeleteRows = false;
            this.dgvMokit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Location = new System.Drawing.Point(9, -4);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.ReadOnly = true;
            this.dgvMokit.RowHeadersWidth = 51;
            this.dgvMokit.RowTemplate.Height = 24;
            this.dgvMokit.Size = new System.Drawing.Size(1492, 580);
            this.dgvMokit.TabIndex = 1;
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
            this.tcHotelli.Size = new System.Drawing.Size(1515, 683);
            this.tcHotelli.TabIndex = 0;
            // 
            // tpToimialue
            // 
            this.tpToimialue.Controls.Add(this.dgv11);
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
            this.tpToimialue.Size = new System.Drawing.Size(1507, 654);
            this.tpToimialue.TabIndex = 4;
            this.tpToimialue.Text = "Toimialue";
            this.tpToimialue.UseVisualStyleBackColor = true;
            // 
            // dgv11
            // 
            this.dgv11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv11.Location = new System.Drawing.Point(927, 55);
            this.dgv11.Name = "dgv11";
            this.dgv11.RowHeadersWidth = 51;
            this.dgv11.RowTemplate.Height = 24;
            this.dgv11.Size = new System.Drawing.Size(399, 222);
            this.dgv11.TabIndex = 1;
            // 
            // tpPalvelut
            // 
            this.tpPalvelut.Controls.Add(this.dataGridView2);
            this.tpPalvelut.Location = new System.Drawing.Point(4, 25);
            this.tpPalvelut.Name = "tpPalvelut";
            this.tpPalvelut.Size = new System.Drawing.Size(1507, 654);
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
            this.dataGridView2.Size = new System.Drawing.Size(1009, 371);
            this.dataGridView2.TabIndex = 0;
            // 
            // tpLaskut
            // 
            this.tpLaskut.Controls.Add(this.dataGridView4);
            this.tpLaskut.Location = new System.Drawing.Point(4, 25);
            this.tpLaskut.Name = "tpLaskut";
            this.tpLaskut.Size = new System.Drawing.Size(1507, 654);
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
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1507, 654);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Varaukset";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(665, 44);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(294, 276);
            this.checkedListBox1.TabIndex = 0;
            // 
            // manhattanProjectBindingSource
            // 
            this.manhattanProjectBindingSource.DataSource = this.manhattanProject;
            this.manhattanProjectBindingSource.Position = 0;
            // 
            // manhattanProject
            // 
            this.manhattanProject.DataSetName = "ManhattanProject";
            this.manhattanProject.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // mokkiTableAdapter1
            // 
            this.mokkiTableAdapter1.ClearBeforeFill = true;
            // 
            // btnToimialue1
            // 
            this.btnToimialue1.Location = new System.Drawing.Point(486, 347);
            this.btnToimialue1.Name = "btnToimialue1";
            this.btnToimialue1.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue1.TabIndex = 0;
            this.btnToimialue1.Tag = "1";
            this.btnToimialue1.Text = "Ylläs";
            this.btnToimialue1.UseVisualStyleBackColor = true;
            this.btnToimialue1.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue2
            // 
            this.btnToimialue2.Location = new System.Drawing.Point(698, 347);
            this.btnToimialue2.Name = "btnToimialue2";
            this.btnToimialue2.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue2.TabIndex = 0;
            this.btnToimialue2.Tag = "2";
            this.btnToimialue2.Text = "Levi";
            this.btnToimialue2.UseVisualStyleBackColor = true;
            this.btnToimialue2.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue3
            // 
            this.btnToimialue3.Location = new System.Drawing.Point(910, 347);
            this.btnToimialue3.Name = "btnToimialue3";
            this.btnToimialue3.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue3.TabIndex = 0;
            this.btnToimialue3.Tag = "3";
            this.btnToimialue3.Text = "Ruka";
            this.btnToimialue3.UseVisualStyleBackColor = true;
            this.btnToimialue3.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue4
            // 
            this.btnToimialue4.Location = new System.Drawing.Point(1122, 347);
            this.btnToimialue4.Name = "btnToimialue4";
            this.btnToimialue4.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue4.TabIndex = 0;
            this.btnToimialue4.Tag = "4";
            this.btnToimialue4.Text = "Salla";
            this.btnToimialue4.UseVisualStyleBackColor = true;
            this.btnToimialue4.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue5
            // 
            this.btnToimialue5.Location = new System.Drawing.Point(486, 553);
            this.btnToimialue5.Name = "btnToimialue5";
            this.btnToimialue5.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue5.TabIndex = 0;
            this.btnToimialue5.Tag = "5";
            this.btnToimialue5.Text = "Vuokatti";
            this.btnToimialue5.UseVisualStyleBackColor = true;
            this.btnToimialue5.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue6
            // 
            this.btnToimialue6.Location = new System.Drawing.Point(698, 553);
            this.btnToimialue6.Name = "btnToimialue6";
            this.btnToimialue6.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue6.TabIndex = 0;
            this.btnToimialue6.Tag = "6";
            this.btnToimialue6.Text = "Tahko";
            this.btnToimialue6.UseVisualStyleBackColor = true;
            this.btnToimialue6.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue7
            // 
            this.btnToimialue7.Location = new System.Drawing.Point(910, 553);
            this.btnToimialue7.Name = "btnToimialue7";
            this.btnToimialue7.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue7.TabIndex = 0;
            this.btnToimialue7.Tag = "7";
            this.btnToimialue7.Text = "Pyhä";
            this.btnToimialue7.UseVisualStyleBackColor = true;
            this.btnToimialue7.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // btnToimialue8
            // 
            this.btnToimialue8.Location = new System.Drawing.Point(1122, 553);
            this.btnToimialue8.Name = "btnToimialue8";
            this.btnToimialue8.Size = new System.Drawing.Size(206, 190);
            this.btnToimialue8.TabIndex = 0;
            this.btnToimialue8.Tag = "8";
            this.btnToimialue8.Text = "Saariselkä";
            this.btnToimialue8.UseVisualStyleBackColor = true;
            this.btnToimialue8.Click += new System.EventHandler(this.ToimialueValinta);
            // 
            // HotelManhattan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 690);
            this.Controls.Add(this.tcHotelli);
            this.Name = "HotelManhattan";
            this.Text = "Hotel Manhanttan";
            this.Load += new System.EventHandler(this.HotelManhattan_Load);
            this.tpAsiakas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tpMokki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tcHotelli.ResumeLayout(false);
            this.tpToimialue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv11)).EndInit();
            this.tpPalvelut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tpLaskut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manhattanProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manhattanProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.BindingSource manhattanProjectBindingSource;
        private ManhattanProject manhattanProject;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private ManhattanProjectTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private System.Windows.Forms.DataGridView dgv11;
        private ManhattanProjectTableAdapters.mokkiTableAdapter mokkiTableAdapter1;
        private System.Windows.Forms.Button btnToimialue8;
        private System.Windows.Forms.Button btnToimialue7;
        private System.Windows.Forms.Button btnToimialue6;
        private System.Windows.Forms.Button btnToimialue5;
        private System.Windows.Forms.Button btnToimialue4;
        private System.Windows.Forms.Button btnToimialue3;
        private System.Windows.Forms.Button btnToimialue2;
        private System.Windows.Forms.Button btnToimialue1;
    }
}

