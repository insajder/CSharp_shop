namespace prodavnicaTVP
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.btnDodajNaRacun = new System.Windows.Forms.Button();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.gwPocetna = new System.Windows.Forms.DataGridView();
            this.cbKategorije = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.btnIzlistajKat = new System.Windows.Forms.Button();
            this.btnObrisiKat = new System.Windows.Forms.Button();
            this.btnDodajKat = new System.Windows.Forms.Button();
            this.gwKategorije = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnIzmeniProizvod = new System.Windows.Forms.Button();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.btnObrisiPro = new System.Windows.Forms.Button();
            this.btnIzlistajProizvode = new System.Windows.Forms.Button();
            this.gwProizvodi = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gwRacuni = new System.Windows.Forms.DataGridView();
            this.btnIzlistajRacune = new System.Windows.Forms.Button();
            this.dtKraj = new System.Windows.Forms.DateTimePicker();
            this.dtPocetak = new System.Windows.Forms.DateTimePicker();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pnl = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUkupnoProizvoda = new System.Windows.Forms.Label();
            this.lbProizvodi = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProizvodi = new System.Windows.Forms.ComboBox();
            this.cbMesec = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.btnKupi = new System.Windows.Forms.Button();
            this.lblUkCena = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.btnObrisiProizvod = new System.Windows.Forms.Button();
            this.lbRacun = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwPocetna)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwKategorije)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwProizvodi)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwRacuni)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(988, 541);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPretraga);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPretraga);
            this.tabPage1.Controls.Add(this.lblCena);
            this.tabPage1.Controls.Add(this.btnDodajNaRacun);
            this.tabPage1.Controls.Add(this.nudKolicina);
            this.tabPage1.Controls.Add(this.gwPocetna);
            this.tabPage1.Controls.Add(this.cbKategorije);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(980, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pocetna";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(685, 20);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(123, 32);
            this.btnPretraga.TabIndex = 7;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naziv proizvoda";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(536, 23);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(131, 22);
            this.txtPretraga.TabIndex = 5;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(21, 446);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(75, 24);
            this.lblCena.TabIndex = 4;
            this.lblCena.Text = "Cena: 0";
            // 
            // btnDodajNaRacun
            // 
            this.btnDodajNaRacun.Location = new System.Drawing.Point(177, 405);
            this.btnDodajNaRacun.Name = "btnDodajNaRacun";
            this.btnDodajNaRacun.Size = new System.Drawing.Size(163, 32);
            this.btnDodajNaRacun.TabIndex = 3;
            this.btnDodajNaRacun.Text = "Dodaj u korpu";
            this.btnDodajNaRacun.UseVisualStyleBackColor = true;
            this.btnDodajNaRacun.Click += new System.EventHandler(this.btnDodajNaRacun_Click);
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(21, 408);
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(134, 22);
            this.nudKolicina.TabIndex = 2;
            this.nudKolicina.ValueChanged += new System.EventHandler(this.nudKolicina_ValueChanged);
            // 
            // gwPocetna
            // 
            this.gwPocetna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwPocetna.Location = new System.Drawing.Point(17, 69);
            this.gwPocetna.Name = "gwPocetna";
            this.gwPocetna.ReadOnly = true;
            this.gwPocetna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gwPocetna.Size = new System.Drawing.Size(791, 322);
            this.gwPocetna.TabIndex = 1;
            this.gwPocetna.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwPocetna_CellClick);
            this.gwPocetna.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gwPocetna_ColumnHeaderMouseClick);
            this.gwPocetna.SelectionChanged += new System.EventHandler(this.gwPocetna_SelectionChanged);
            // 
            // cbKategorije
            // 
            this.cbKategorije.FormattingEnabled = true;
            this.cbKategorije.Location = new System.Drawing.Point(17, 25);
            this.cbKategorije.Name = "cbKategorije";
            this.cbKategorije.Size = new System.Drawing.Size(195, 24);
            this.cbKategorije.TabIndex = 0;
            this.cbKategorije.SelectedIndexChanged += new System.EventHandler(this.cbKategorije_SelectedIndexChanged);
            this.cbKategorije.TextChanged += new System.EventHandler(this.cbKategorije_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtKategorija);
            this.tabPage2.Controls.Add(this.btnIzlistajKat);
            this.tabPage2.Controls.Add(this.btnObrisiKat);
            this.tabPage2.Controls.Add(this.btnDodajKat);
            this.tabPage2.Controls.Add(this.gwKategorije);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(980, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kategorije";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtKategorija
            // 
            this.txtKategorija.Location = new System.Drawing.Point(517, 54);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.Size = new System.Drawing.Size(238, 23);
            this.txtKategorija.TabIndex = 4;
            // 
            // btnIzlistajKat
            // 
            this.btnIzlistajKat.Location = new System.Drawing.Point(136, 53);
            this.btnIzlistajKat.Name = "btnIzlistajKat";
            this.btnIzlistajKat.Size = new System.Drawing.Size(240, 40);
            this.btnIzlistajKat.TabIndex = 3;
            this.btnIzlistajKat.Text = "Izlistaj kategorije";
            this.btnIzlistajKat.UseVisualStyleBackColor = true;
            this.btnIzlistajKat.Click += new System.EventHandler(this.btnIzlistajKat_Click);
            // 
            // btnObrisiKat
            // 
            this.btnObrisiKat.Location = new System.Drawing.Point(134, 362);
            this.btnObrisiKat.Name = "btnObrisiKat";
            this.btnObrisiKat.Size = new System.Drawing.Size(240, 40);
            this.btnObrisiKat.TabIndex = 2;
            this.btnObrisiKat.Text = "Obrisi kategoriju";
            this.btnObrisiKat.UseVisualStyleBackColor = true;
            this.btnObrisiKat.Click += new System.EventHandler(this.btnObrisiKat_Click);
            // 
            // btnDodajKat
            // 
            this.btnDodajKat.Location = new System.Drawing.Point(515, 99);
            this.btnDodajKat.Name = "btnDodajKat";
            this.btnDodajKat.Size = new System.Drawing.Size(240, 40);
            this.btnDodajKat.TabIndex = 1;
            this.btnDodajKat.Text = "Dodaj kategoriju";
            this.btnDodajKat.UseVisualStyleBackColor = true;
            this.btnDodajKat.Click += new System.EventHandler(this.btnDodajKat_Click);
            // 
            // gwKategorije
            // 
            this.gwKategorije.AllowUserToAddRows = false;
            this.gwKategorije.AllowUserToDeleteRows = false;
            this.gwKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwKategorije.Location = new System.Drawing.Point(95, 115);
            this.gwKategorije.Name = "gwKategorije";
            this.gwKategorije.ReadOnly = true;
            this.gwKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gwKategorije.Size = new System.Drawing.Size(308, 223);
            this.gwKategorije.TabIndex = 0;
            this.gwKategorije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwKategorije_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnIzmeniProizvod);
            this.tabPage3.Controls.Add(this.btnDodajProizvod);
            this.tabPage3.Controls.Add(this.btnObrisiPro);
            this.tabPage3.Controls.Add(this.btnIzlistajProizvode);
            this.tabPage3.Controls.Add(this.gwProizvodi);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(980, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proizvodi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniProizvod
            // 
            this.btnIzmeniProizvod.Location = new System.Drawing.Point(284, 426);
            this.btnIzmeniProizvod.Name = "btnIzmeniProizvod";
            this.btnIzmeniProizvod.Size = new System.Drawing.Size(240, 40);
            this.btnIzmeniProizvod.TabIndex = 11;
            this.btnIzmeniProizvod.Text = "Izmeni proizvod";
            this.btnIzmeniProizvod.UseVisualStyleBackColor = true;
            this.btnIzmeniProizvod.Click += new System.EventHandler(this.btnIzmeniProizvod_Click);
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Location = new System.Drawing.Point(22, 426);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(240, 40);
            this.btnDodajProizvod.TabIndex = 10;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // btnObrisiPro
            // 
            this.btnObrisiPro.Location = new System.Drawing.Point(553, 426);
            this.btnObrisiPro.Name = "btnObrisiPro";
            this.btnObrisiPro.Size = new System.Drawing.Size(240, 40);
            this.btnObrisiPro.TabIndex = 9;
            this.btnObrisiPro.Text = "Obrisi proizvod";
            this.btnObrisiPro.UseVisualStyleBackColor = true;
            this.btnObrisiPro.Click += new System.EventHandler(this.btnObrisiPro_Click);
            // 
            // btnIzlistajProizvode
            // 
            this.btnIzlistajProizvode.Location = new System.Drawing.Point(22, 23);
            this.btnIzlistajProizvode.Name = "btnIzlistajProizvode";
            this.btnIzlistajProizvode.Size = new System.Drawing.Size(240, 40);
            this.btnIzlistajProizvode.TabIndex = 8;
            this.btnIzlistajProizvode.Text = "Izlistaj proizvode";
            this.btnIzlistajProizvode.UseVisualStyleBackColor = true;
            this.btnIzlistajProizvode.Click += new System.EventHandler(this.btnIzlistajProizvode_Click);
            // 
            // gwProizvodi
            // 
            this.gwProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwProizvodi.Location = new System.Drawing.Point(22, 79);
            this.gwProizvodi.Name = "gwProizvodi";
            this.gwProizvodi.ReadOnly = true;
            this.gwProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gwProizvodi.Size = new System.Drawing.Size(771, 330);
            this.gwProizvodi.TabIndex = 5;
            this.gwProizvodi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwProizvodi_CellClick);
            this.gwProizvodi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwProizvodi_CellValueChanged);
            this.gwProizvodi.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gwProizvodi_ColumnHeaderMouseClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.gwRacuni);
            this.tabPage4.Controls.Add(this.btnIzlistajRacune);
            this.tabPage4.Controls.Add(this.dtKraj);
            this.tabPage4.Controls.Add(this.dtPocetak);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(980, 512);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Racuni";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Krajnji datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pocetni datum:";
            // 
            // gwRacuni
            // 
            this.gwRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwRacuni.Location = new System.Drawing.Point(35, 154);
            this.gwRacuni.Name = "gwRacuni";
            this.gwRacuni.ReadOnly = true;
            this.gwRacuni.Size = new System.Drawing.Size(708, 312);
            this.gwRacuni.TabIndex = 3;
            // 
            // btnIzlistajRacune
            // 
            this.btnIzlistajRacune.Location = new System.Drawing.Point(35, 95);
            this.btnIzlistajRacune.Name = "btnIzlistajRacune";
            this.btnIzlistajRacune.Size = new System.Drawing.Size(708, 40);
            this.btnIzlistajRacune.TabIndex = 2;
            this.btnIzlistajRacune.Text = "Izlistaj racune";
            this.btnIzlistajRacune.UseVisualStyleBackColor = true;
            this.btnIzlistajRacune.Click += new System.EventHandler(this.btnIzlistajRacune_Click);
            // 
            // dtKraj
            // 
            this.dtKraj.Location = new System.Drawing.Point(413, 46);
            this.dtKraj.Name = "dtKraj";
            this.dtKraj.Size = new System.Drawing.Size(330, 23);
            this.dtKraj.TabIndex = 1;
            // 
            // dtPocetak
            // 
            this.dtPocetak.Location = new System.Drawing.Point(35, 46);
            this.dtPocetak.Name = "dtPocetak";
            this.dtPocetak.Size = new System.Drawing.Size(330, 23);
            this.dtPocetak.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pnl);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.lblUkupnoProizvoda);
            this.tabPage5.Controls.Add(this.lbProizvodi);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.cbProizvodi);
            this.tabPage5.Controls.Add(this.cbMesec);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(980, 512);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Statistika";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(603, 80);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(350, 350);
            this.pnl.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "100%";
            // 
            // lblUkupnoProizvoda
            // 
            this.lblUkupnoProizvoda.AutoSize = true;
            this.lblUkupnoProizvoda.Location = new System.Drawing.Point(102, 364);
            this.lblUkupnoProizvoda.Name = "lblUkupnoProizvoda";
            this.lblUkupnoProizvoda.Size = new System.Drawing.Size(73, 17);
            this.lblUkupnoProizvoda.TabIndex = 5;
            this.lblUkupnoProizvoda.Text = "Ukupno: 0";
            // 
            // lbProizvodi
            // 
            this.lbProizvodi.FormattingEnabled = true;
            this.lbProizvodi.ItemHeight = 16;
            this.lbProizvodi.Location = new System.Drawing.Point(8, 69);
            this.lbProizvodi.Name = "lbProizvodi";
            this.lbProizvodi.Size = new System.Drawing.Size(336, 292);
            this.lbProizvodi.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(599, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Proizvodi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mesec:";
            // 
            // cbProizvodi
            // 
            this.cbProizvodi.FormattingEnabled = true;
            this.cbProizvodi.Location = new System.Drawing.Point(697, 25);
            this.cbProizvodi.Name = "cbProizvodi";
            this.cbProizvodi.Size = new System.Drawing.Size(262, 24);
            this.cbProizvodi.TabIndex = 1;
            this.cbProizvodi.SelectedValueChanged += new System.EventHandler(this.cbProizvodi_SelectedValueChanged);
            // 
            // cbMesec
            // 
            this.cbMesec.FormattingEnabled = true;
            this.cbMesec.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "Mart",
            "April",
            "Maj",
            "Jun",
            "Jul",
            "Avgust",
            "Septembar",
            "Oktobar",
            "Novembar",
            "Decembar"});
            this.cbMesec.Location = new System.Drawing.Point(82, 14);
            this.cbMesec.Name = "cbMesec";
            this.cbMesec.Size = new System.Drawing.Size(262, 24);
            this.cbMesec.TabIndex = 0;
            this.cbMesec.SelectedValueChanged += new System.EventHandler(this.cbMesec_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStorniraj);
            this.panel1.Controls.Add(this.btnKupi);
            this.panel1.Controls.Add(this.lblUkCena);
            this.panel1.Controls.Add(this.lblDatum);
            this.panel1.Controls.Add(this.lblVreme);
            this.panel1.Controls.Add(this.btnObrisiProizvod);
            this.panel1.Controls.Add(this.lbRacun);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1071, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 519);
            this.panel1.TabIndex = 2;
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Location = new System.Drawing.Point(194, 434);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(115, 68);
            this.btnStorniraj.TabIndex = 7;
            this.btnStorniraj.Text = "Storniraj racun";
            this.btnStorniraj.UseVisualStyleBackColor = true;
            this.btnStorniraj.Click += new System.EventHandler(this.btnStorniraj_Click);
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(32, 434);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(109, 68);
            this.btnKupi.TabIndex = 6;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // lblUkCena
            // 
            this.lblUkCena.AutoSize = true;
            this.lblUkCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkCena.Location = new System.Drawing.Point(29, 340);
            this.lblUkCena.Name = "lblUkCena";
            this.lblUkCena.Size = new System.Drawing.Size(132, 24);
            this.lblUkCena.TabIndex = 5;
            this.lblUkCena.Text = "Ukupna cena: ";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(28, 407);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(74, 24);
            this.lblDatum.TabIndex = 4;
            this.lblDatum.Text = "Datum: ";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.Location = new System.Drawing.Point(28, 375);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(77, 24);
            this.lblVreme.TabIndex = 3;
            this.lblVreme.Text = "Vreme: ";
            // 
            // btnObrisiProizvod
            // 
            this.btnObrisiProizvod.Location = new System.Drawing.Point(168, 6);
            this.btnObrisiProizvod.Name = "btnObrisiProizvod";
            this.btnObrisiProizvod.Size = new System.Drawing.Size(141, 68);
            this.btnObrisiProizvod.TabIndex = 2;
            this.btnObrisiProizvod.Text = "Obrisi proizvod";
            this.btnObrisiProizvod.UseVisualStyleBackColor = true;
            this.btnObrisiProizvod.Click += new System.EventHandler(this.btnObrisiProizvod_Click);
            // 
            // lbRacun
            // 
            this.lbRacun.FormattingEnabled = true;
            this.lbRacun.ItemHeight = 24;
            this.lbRacun.Location = new System.Drawing.Point(33, 80);
            this.lbRacun.Name = "lbRacun";
            this.lbRacun.Size = new System.Drawing.Size(276, 244);
            this.lbRacun.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Racun";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwPocetna)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwKategorije)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwProizvodi)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwRacuni)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDodajNaRacun;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.DataGridView gwPocetna;
        private System.Windows.Forms.ComboBox cbKategorije;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStorniraj;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.Label lblUkCena;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Button btnObrisiProizvod;
        private System.Windows.Forms.ListBox lbRacun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzlistajKat;
        private System.Windows.Forms.Button btnObrisiKat;
        private System.Windows.Forms.Button btnDodajKat;
        private System.Windows.Forms.DataGridView gwKategorije;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.Button btnIzlistajProizvode;
        private System.Windows.Forms.DataGridView gwProizvodi;
        private System.Windows.Forms.Button btnObrisiPro;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView gwRacuni;
        private System.Windows.Forms.Button btnIzlistajRacune;
        private System.Windows.Forms.DateTimePicker dtKraj;
        private System.Windows.Forms.DateTimePicker dtPocetak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUkupnoProizvoda;
        private System.Windows.Forms.ListBox lbProizvodi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProizvodi;
        private System.Windows.Forms.ComboBox cbMesec;
        private System.Windows.Forms.Button btnIzmeniProizvod;
        private System.Windows.Forms.Button btnDodajProizvod;
    }
}

