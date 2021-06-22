using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prodavnicaTVP
{
    public partial class Form1 : Form
    {
        BazaDataSet3 ds;
        BazaDataSet3TableAdapters.KategorijaTableAdapter daKategorija;
        BazaDataSet3TableAdapters.ProizvodTableAdapter daProizvod;
        BazaDataSet3TableAdapters.RacunTableAdapter daRacun;
        BazaDataSet3TableAdapters.StatistikaTableAdapter daStatistika;

        List<Racun> lst_racuna;
        List<Proizvod> lst_proizvoda;

        int indeks;
        int indeks_kategorije;
        int indeks_proizvoda;
        double uk_cena_pro;
        double uk_cena_racuna=0;
        public Form1()
        {
            InitializeComponent();
            ds = new BazaDataSet3();
            daKategorija = new BazaDataSet3TableAdapters.KategorijaTableAdapter();
            daProizvod = new BazaDataSet3TableAdapters.ProizvodTableAdapter();
            daRacun = new BazaDataSet3TableAdapters.RacunTableAdapter();
            daStatistika = new BazaDataSet3TableAdapters.StatistikaTableAdapter();

            lst_racuna = new List<Racun>();
            lst_proizvoda = new List<Proizvod>();

            daKategorija.Fill(ds.Kategorija);
            daProizvod.Fill(ds.Proizvod);
            daRacun.Fill(ds.Racun);

            DataGridViewComboBoxColumn cmbCol = new DataGridViewComboBoxColumn();
            cmbCol.HeaderText = "Kategorija";
            cmbCol.Name = "KategorijaC";
            cmbCol.DataSource = ds.Kategorija;
            cmbCol.DisplayMember = "Naziv_kategorije";
            cmbCol.ValueMember = "ID";
            cmbCol.ReadOnly = true;
            gwPocetna.DataSource = ds.Proizvod;
            gwPocetna.Columns["Kategorija"].Visible = false;
            gwPocetna.Columns.Add(cmbCol);
            gwPocetna.Columns["KategorijaC"].DisplayIndex = 3;
            gwPocetna.AllowUserToAddRows = false;

            DataGridViewComboBoxColumn cmbCol2 = new DataGridViewComboBoxColumn();
            cmbCol2.HeaderText = "Kategorija";
            cmbCol2.Name = "KategorijaC";
            cmbCol2.DataSource = ds.Kategorija;
            cmbCol2.DisplayMember = "Naziv_kategorije";
            cmbCol2.ValueMember = "ID";
            gwProizvodi.DataSource = ds.Proizvod;
            gwProizvodi.Columns.Add(cmbCol2);
            gwProizvodi.Columns["KategorijaC"].DisplayIndex = 3;
            gwProizvodi.Columns["Kategorija"].Visible = false;

            dtKraj.MaxDate = DateTime.Now;
            dtPocetak.MaxDate = DateTime.Now;
            dtPocetak.Value = DateTime.Now.AddDays(-30);

            gwPocetna.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;
            gwPocetna.Columns["Naziv_proizvoda"].SortMode = DataGridViewColumnSortMode.NotSortable;
            gwPocetna.Columns["Kolicina"].SortMode = DataGridViewColumnSortMode.NotSortable;
            gwPocetna.Columns["Kategorija"].SortMode = DataGridViewColumnSortMode.NotSortable;
            gwPocetna.Columns["Cena"].SortMode = DataGridViewColumnSortMode.NotSortable;

            gwProizvodi.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;
            gwProizvodi.Columns["Naziv_proizvoda"].SortMode = DataGridViewColumnSortMode.NotSortable;
            gwProizvodi.Columns["Kolicina"].SortMode = DataGridViewColumnSortMode.NotSortable;
            gwProizvodi.Columns["Kategorija"].SortMode = DataGridViewColumnSortMode.NotSortable;
            gwProizvodi.Columns["Cena"].SortMode = DataGridViewColumnSortMode.NotSortable;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbKategorije.DataSource = null;
            cbKategorije.BindingContext = new BindingContext();
            cbKategorije.DisplayMember = "Naziv_kategorije";
            cbKategorije.ValueMember = "Naziv_kategorije";

            cbKategorije.DataSource = ds.Kategorija;
            cbKategorije.Text = "";

            OsveziProizvodePocetna();
        }

        public void OsveziProizvodePocetna()
        {
            var upit = ds.Proizvod.OrderBy(p => p.Naziv_proizvoda).ToList();
            gwPocetna.DataSource = upit.CopyToDataTable();
            foreach (DataGridViewRow row in gwPocetna.Rows)
            {
                row.Cells["KategorijaC"].Value = row.Cells["Kategorija"].Value;
            }
        }
        private void cbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKategorije.SelectedItem != null)
            {
                txtPretraga.Text = "";
                var upit = ds.Proizvod.Where(x => x.KategorijaRow.Naziv_kategorije.Equals(cbKategorije.SelectedValue.ToString())).OrderBy(p => p.Naziv_proizvoda).ToList();
                gwPocetna.DataSource = upit.CopyToDataTable();
                foreach (DataGridViewRow row in gwPocetna.Rows)
                {
                    row.Cells["KategorijaC"].Value = row.Cells["Kategorija"].Value;
                }
                
            }
        }
        private void nudKolicina_ValueChanged(object sender, EventArgs e)
        {
            if (gwPocetna.SelectedRows != null)
            {
                DataGridViewRow selektovani = gwPocetna.Rows[indeks];

                string cena = selektovani.Cells["Cena"].Value.ToString();
                double c;
                bool pr = Double.TryParse(cena, out c);
                if (pr)
                {
                    uk_cena_pro = Convert.ToDouble(nudKolicina.Value) * c;
                    lblCena.Text = "Cena: " + uk_cena_pro + " dinara";
                }
            }
            else
            {
                MessageBox.Show("Prvo izaberite proizvod");
            }
        }

        private void gwPocetna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indeks = e.RowIndex;
        }

        private void btnDodajNaRacun_Click(object sender, EventArgs e)
        {
            DataGridViewRow selektovani = gwPocetna.Rows[indeks];
            string str_id = selektovani.Cells["ID"].Value.ToString();
            int id_pro = Convert.ToInt32(str_id);
            string naziv = selektovani.Cells["Naziv_proizvoda"].Value.ToString();
            double kolicina = (double)nudKolicina.Value;

            var smanji_kolicinu = ds.Proizvod.FindByID(id_pro);
            double kol = (double)nudKolicina.Value;
            if (smanji_kolicinu.Kolicina >= kol)
            {
                smanji_kolicinu.Kolicina -= kol;
                daProizvod.Update(ds.Proizvod);

                if (gwPocetna.SelectedRows != null && nudKolicina.Value > 0)
                {
                    lbRacun.Items.Add(naziv + "  |  " + kolicina + "  |  " + uk_cena_pro);
                    uk_cena_racuna += uk_cena_pro;
                    lblUkCena.Text = "Ukupna cena: " + uk_cena_racuna + " dinara";
                    OsveziProizvodePocetna();

                    lst_proizvoda.Add(new Proizvod(naziv, kolicina));
                }
                else
                {
                    MessageBox.Show("Izaberite proizvod i kolicinu");
                }
                lblVreme.Text = "Vreme: " + DateTime.Now.ToString("HH:mm");
                lblDatum.Text = "Datum: " + DateTime.Now.ToString("dd.MM.yyyy");

                nudKolicina.Value = 0;
            }
            else
            {
                MessageBox.Show("Nema dovoljno proizvoda");
            }
        }
        public void osveziKategorije()
        {
            daKategorija.Fill(ds.Kategorija);
            gwKategorije.DataSource = ds.Kategorija;
        }
        private void btnIzlistajKat_Click(object sender, EventArgs e)
        {
            osveziKategorije();
        }

        private void btnDodajKat_Click(object sender, EventArgs e)
        {
            if (txtKategorija.Text.Trim().Length != 0)
            {
                var postoji = ds.Kategorija.Where(x => x.Naziv_kategorije.ToLower().Equals(txtKategorija.Text.ToLower()));
                if (postoji.Count() <= 0)
                {
                    BazaDataSet3.KategorijaRow red = ds.Kategorija.NewKategorijaRow();
                    red.Naziv_kategorije = txtKategorija.Text;
                    ds.Kategorija.AddKategorijaRow(red);
                    daKategorija.Update(ds.Kategorija);
                }
                else
                {
                    MessageBox.Show("Kategorija sa ovim nazivom vec postoji");
                }
            }
            else
                MessageBox.Show("Unesite naziv kategorije");
        }

        private void btnObrisiKat_Click(object sender, EventArgs e)
        {
            DataGridViewRow selektovani = gwKategorije.Rows[indeks_kategorije];

            string str_id = selektovani.Cells["ID"].Value.ToString();
            int id_kategorije = int.Parse(str_id);
            
            string str_naziv = selektovani.Cells["Naziv_kategorije"].Value.ToString();
            string naziv_kategorije = str_naziv;

            var obrisi = ds.Kategorija.FirstOrDefault(x => x.ID == id_kategorije);

            if (obrisi != null)
            {
                var linq = from x in ds.Proizvod
                           where x.KategorijaRow.ID == id_kategorije
                           select x;
                if (linq.Count() > 0)
                {
                    foreach (var d in linq)
                    {
                        int id = d.ID;
                        string naziv = d.Naziv_proizvoda;
                        double kolicina = d.Kolicina;
                        double cena = d.Cena;
                        Kategorija k = new Kategorija();
                        k.ID1 = d.KategorijaRow.ID;
                        k.Naziv_kategorije1 = d.KategorijaRow.Naziv_kategorije;

                        daProizvod.Delete(id, naziv, kolicina, cena, k.ID1);
                        MessageBox.Show("Uspesno brisanje");
                    }
                }

                daKategorija.Delete(id_kategorije, naziv_kategorije);

                osveziKategorije();
            }

            osveziProizvode();
            OsveziProizvodePocetna();
        }

        private void gwKategorije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indeks_kategorije = e.RowIndex;
        }

        public void osveziProizvode()
        {
            daProizvod.Fill(ds.Proizvod);
            var proizvodi = ds.Proizvod.ToList();
            gwProizvodi.DataSource = proizvodi.CopyToDataTable();
            foreach (DataGridViewRow row in gwProizvodi.Rows)
            {
                row.Cells["KategorijaC"].Value = row.Cells["Kategorija"].Value;
            }
        }
        private void btnIzlistajProizvode_Click(object sender, EventArgs e)
        {

            osveziProizvode();
        }

        private void btnObrisiPro_Click(object sender, EventArgs e)
        {
            DataGridViewRow selektovani = gwProizvodi.Rows[indeks_proizvoda];

            string str_id = selektovani.Cells["ID"].Value.ToString();
            int id_proizvoda = int.Parse(str_id);

            string str_naziv = selektovani.Cells["Naziv_proizvoda"].Value.ToString();
            string naziv = str_naziv;

            string str_kol = selektovani.Cells["Kolicina"].Value.ToString();
            double kol = Convert.ToDouble(str_kol);

            string str_cena = selektovani.Cells["Cena"].Value.ToString();
            double cena = Convert.ToDouble(str_cena);

            string str_kat = selektovani.Cells["Kategorija"].Value.ToString();
            Kategorija k = new Kategorija();
            k.ID1 = Convert.ToInt32(str_kat);
            var nadji_kat = ds.Kategorija.FindByID(k.ID1);
            k.Naziv_kategorije1 = nadji_kat.Naziv_kategorije;

            var obrisi = ds.Proizvod.FindByID(id_proizvoda);
            if (obrisi != null)
            {
                daProizvod.Delete(id_proizvoda, naziv, kol, cena, k.ID1);
                OsveziProizvodePocetna();
            }
            //daProizvod.Fill(ds.Proizvod);
            gwProizvodi.DataSource = ds.Proizvod;
        }
        public void ObrisiProizvode()
        {
            DataGridViewRow selektovani = gwProizvodi.Rows[indeks_proizvoda];

            string str_id = selektovani.Cells["ID"].Value.ToString();
            int id_proizvoda = int.Parse(str_id);

            string str_naziv = selektovani.Cells["Naziv_proizvoda"].Value.ToString();
            string naziv = str_naziv;

            string str_kol = selektovani.Cells["Kolicina"].Value.ToString();
            double kol = Convert.ToDouble(str_kol);

            string str_cena = selektovani.Cells["Cena"].Value.ToString();
            double cena = Convert.ToDouble(str_cena);

            string str_kat = selektovani.Cells["Kategorija"].Value.ToString();
            Kategorija k = new Kategorija();
            k.ID1 = Convert.ToInt32(str_kat);
            var nadji_kat = ds.Kategorija.FindByID(k.ID1);
            k.Naziv_kategorije1 = nadji_kat.Naziv_kategorije;

            var obrisi = ds.Proizvod.FindByID(id_proizvoda);
            if (obrisi != null)
            {
                daProizvod.Delete(id_proizvoda, naziv, kol, cena, k.ID1);
                OsveziProizvodePocetna();
            }
            //daProizvod.Fill(ds.Proizvod);
            gwProizvodi.DataSource = ds.Proizvod;
        }

        private void gwProizvodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indeks_proizvoda = e.RowIndex;
        }

        private void btnKupi_Click(object sender, EventArgs e)
        {
            if (uk_cena_racuna != 0)
            {
                BazaDataSet3.RacunRow red = ds.Racun.NewRacunRow();
                red.Ukupna_cena = uk_cena_racuna;
                red.Vreme = DateTime.Now;
                red.Datum = DateTime.Now;
                ds.Racun.AddRacunRow(red);
                daRacun.Update(ds.Racun);


                uk_cena_racuna = 0;
                lbRacun.Items.Clear();
                lblUkCena.Text = "Ukupna cena: ";
                lblVreme.Text = "Vreme: ";
                lblDatum.Text = "Datum: ";


                daStatistika.Fill(ds.Statistika);

                for (int i = 0; i < lst_proizvoda.Count(); i++) {
                    var upitProveraNaziva = from x in ds.Statistika
                               where x.Naziv_proizvoda == lst_proizvoda[i].Naziv_proizvoda1
                               select x;
                    if(upitProveraNaziva.Count() > 0)
                    {
                        var upitProveraMeseca = from x in ds.Statistika
                                                where x.Datum_prodaje.Month == lst_proizvoda[i].Datum.Month
                                                select x;
                        if (upitProveraMeseca.Count() > 0)
                        {
                            var povecaj_broj_prodatih = ds.Statistika.FirstOrDefault(x => x.Naziv_proizvoda == lst_proizvoda[i].Naziv_proizvoda1
                                                        && x.Datum_prodaje.Month == lst_proizvoda[i].Datum.Month);
                            povecaj_broj_prodatih.Broj_prodatih += Convert.ToInt32(lst_proizvoda[i].Kolicina1);
                            daStatistika.Update(ds.Statistika);
                        }
                        else
                        {
                            var br = from x in ds.Statistika
                                     where x.Naziv_proizvoda == lst_proizvoda[i].Naziv_proizvoda1
                                     select x.Broj_prodatih;
                            int brojProdatih = Convert.ToInt32(lst_proizvoda[i].Kolicina1);

                            BazaDataSet3.StatistikaRow red_st = ds.Statistika.NewStatistikaRow();
                            red_st.Naziv_proizvoda = lst_proizvoda[i].Naziv_proizvoda1;
                            red_st.Broj_prodatih = brojProdatih;
                            red_st.Datum_prodaje = lst_proizvoda[i].Datum;
                            ds.Statistika.AddStatistikaRow(red_st);
                            daStatistika.Update(ds.Statistika);
                        }
                    }
                    else
                    {
                        var br = from x in ds.Statistika
                                 where x.Naziv_proizvoda == lst_proizvoda[i].Naziv_proizvoda1
                                 select x.Broj_prodatih;
                        int brojProdatih = Convert.ToInt32(lst_proizvoda[i].Kolicina1);

                        BazaDataSet3.StatistikaRow red_st = ds.Statistika.NewStatistikaRow();
                        red_st.Naziv_proizvoda = lst_proizvoda[i].Naziv_proizvoda1;
                        red_st.Broj_prodatih = brojProdatih;
                        red_st.Datum_prodaje = lst_proizvoda[i].Datum;
                        ds.Statistika.AddStatistikaRow(red_st);
                        daStatistika.Update(ds.Statistika);
                    }
                }
                lst_proizvoda = new List<Proizvod>();

                MessageBox.Show("Uspesna kupovina");
            }
            else
                MessageBox.Show("Dodajte ptoizvode");
        }

        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            if (uk_cena_racuna != 0)
            {
                for(int i=0; i<lbRacun.Items.Count; i++)
                {
                    string[] sadrzaj = lbRacun.Items[i].ToString().Split('|');
                    var povecaj_kolicinu = ds.Proizvod.Where(x => x.Naziv_proizvoda.Trim().Equals(sadrzaj[0].Trim())).FirstOrDefault();
                    povecaj_kolicinu.Kolicina += Convert.ToDouble(sadrzaj[1]);
                    daProizvod.Update(ds.Proizvod);
                }
                OsveziProizvodePocetna();

                uk_cena_racuna = 0;
                lbRacun.Items.Clear();
                lblUkCena.Text = "Ukupna cena: ";
                lblVreme.Text = "Vreme: ";
                lblDatum.Text = "Datum: ";
            }
            else
                MessageBox.Show("Prazna korpa");
        }

        private void btnObrisiProizvod_Click(object sender, EventArgs e)
        {
            if (lbRacun.SelectedItem != null)
            {
                String[] izabrani = lbRacun.SelectedItem.ToString().Split('|');
                uk_cena_racuna -= Convert.ToDouble(izabrani[2]);
                lblUkCena.Text = "Ukupna cena: " + uk_cena_racuna;

                lbRacun.Items.Remove(lbRacun.Items[lbRacun.SelectedIndex]);

                var povecaj_kolicinu = ds.Proizvod.Where(x => x.Naziv_proizvoda.Trim().Equals(izabrani[0].Trim())).FirstOrDefault();
                povecaj_kolicinu.Kolicina += Convert.ToDouble(izabrani[1]);
                daProizvod.Update(ds.Proizvod);

                OsveziProizvodePocetna();
            }
            else
                MessageBox.Show("Prvo izaberite polje");
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            if(txtPretraga.Text.Trim().Length != 0)
            {
                var nadjen = ds.Proizvod.Where(x => x.Naziv_proizvoda.ToLower().StartsWith(txtPretraga.Text.ToLower()));
               
                var upit = nadjen.ToList();
                if (nadjen.Count() > 0)
                {
                    gwPocetna.DataSource = upit.CopyToDataTable();

                    foreach (DataGridViewRow row in gwPocetna.Rows)
                    {
                        row.Cells["KategorijaC"].Value = row.Cells["Kategorija"].Value;
                    }
                }
                else
                {
                    DataTable dt = (DataTable)gwPocetna.DataSource;
                    if (dt != null)
                        dt.Clear();
                }
            }
        }

        private void gwProizvodi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show(gwProizvodi.Rows[e.RowIndex].Cells["KategorijaC"].Value.ToString());
                gwProizvodi.Rows[e.RowIndex].Cells["Kategorija"].Value = gwProizvodi.Rows[e.RowIndex].Cells["KategorijaC"].Value;
            }
            return;
        }

        private void btnIzlistajRacune_Click(object sender, EventArgs e)
        {
            daRacun.Fill(ds.Racun);

            var linq = ds.Racun.Where(x => x.Datum >= dtPocetak.Value && x.Datum <= dtKraj.Value.AddMinutes(50));

            if (linq.Count() > 0)
            {
                gwRacuni.DataSource = linq.CopyToDataTable();
                gwRacuni.Columns["Vreme"].DefaultCellStyle.Format = "HH:mm:ss";
                gwRacuni.Columns["Datum"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }
        }
        private void cbMesec_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbMesec.SelectedItem.ToString())
            {
                case "Januar":
                    procitajProizvodeMesec(1);
                    break;
                case "Februar":
                    procitajProizvodeMesec(2);
                    break;
                case "Mart":
                    procitajProizvodeMesec(3);
                    break;
                case "April":
                    procitajProizvodeMesec(4);
                    break;
                case "Maj":
                    procitajProizvodeMesec(5);
                    break;
                case "Jun":
                    procitajProizvodeMesec(6);
                    break;
                case "Jul":
                    procitajProizvodeMesec(7);
                    break;
                case "Avgust":
                    procitajProizvodeMesec(8);
                    break;
                case "Septembar":
                    procitajProizvodeMesec(9);
                    break;
                case "Oktobar":
                    procitajProizvodeMesec(10);
                    break;
                case "Novembar":
                    procitajProizvodeMesec(11);
                    break;
                case "Decembar":
                    procitajProizvodeMesec(12);
                    break;
            }
        }
        public void procitajProizvodeMesec(int mesec)
        {
            lbProizvodi.Items.Clear();
            daStatistika.Fill(ds.Statistika);
            var upit = from x in ds.Statistika
                       where mesec == x.Datum_prodaje.Month
                       select x;
            int ukupno = 0;
            if (upit.Count() > 0)
            {
                foreach (var v in upit)
                {
                    ukupno += v.Broj_prodatih;
                }
                foreach (var v in upit)
                {
                    double procenat = (double)v.Broj_prodatih * 100 / ukupno;
                    lbProizvodi.Items.Add(v.Naziv_proizvoda.Trim().PadRight(35-v.Naziv_proizvoda.Trim().Length) + v.Broj_prodatih.ToString().Trim().PadRight(25-v.Broj_prodatih.ToString().Trim().Length) + procenat.ToString("#.#") + "%");
                }
            }
            lblUkupnoProizvoda.Text = "Ukupno: " + ukupno;
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            
            osveziProizvode();

            cbProizvodi.DataSource = null;
            cbProizvodi.BindingContext = new BindingContext();
            cbProizvodi.DisplayMember = "Naziv_proizvoda";
            cbProizvodi.ValueMember = "Naziv_proizvoda";
            cbProizvodi.DataSource = ds.Proizvod.CopyToDataTable();
        }
        private void cbProizvodi_SelectedValueChanged(object sender, EventArgs e)
        {
            daStatistika.Fill(ds.Statistika);
            tabPage5.Paint += crtaj;
            tabPage5.Invalidate();
        }
        private void crtaj(object sender, PaintEventArgs e)
        {
            string sel = cbProizvodi.SelectedValue.ToString();
            
            var upit = from x in ds.Statistika
                       where x.Naziv_proizvoda == sel
                       orderby x.Datum_prodaje.Month
                       select x;

            Pen p = new Pen(Color.Black, 3);
            Rectangle rect = new Rectangle(pnl.Location.X, pnl.Location.Y, pnl.Width, pnl.Height);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawEllipse(p, rect);

            float suma_za_statistiku = 0;
            if (upit.Count() > 0)
            {
                float pocetniUgao = 0;
                
                
                foreach (var v in upit)
                {
                    suma_za_statistiku += (float)v.Broj_prodatih;
                }
                int visina = 80;

                Brush[] boje =
                {
                    Brushes.Red,
                    Brushes.LightGreen,
                    Brushes.Blue,
                    Brushes.LightBlue,
                    Brushes.Green,
                    Brushes.Lime,
                    Brushes.Orange,
                    Brushes.Fuchsia,
                    Brushes.Yellow,
                    Brushes.Cyan,
                    Brushes.Purple,
                    Brushes.Aqua
                };
                int i = 0;
                
                foreach (var v in upit)
                {
                    e.Graphics.FillPie(boje[i], new Rectangle(pnl.Location.X, pnl.Location.Y, pnl.Width, pnl.Height), pocetniUgao, (v.Broj_prodatih * 360) / suma_za_statistiku);

                    Rectangle r = new Rectangle();
                    r = new Rectangle(370, visina, 20, 20);
                    e.Graphics.FillRectangle(boje[i], r);

                    Font font1 = new Font("Microsoft Sans Serif", 14);
                    string mesec_prodaje = mesec(v.Datum_prodaje.Month);
                    e.Graphics.DrawString(mesec_prodaje + ", " + v.Broj_prodatih.ToString() + " => " + (v.Broj_prodatih * 100 / suma_za_statistiku).ToString("#.#") + "%", font1, Brushes.Black, 400, visina+2);

                    pocetniUgao += (v.Broj_prodatih * 360) / suma_za_statistiku;
                    i++;
                    visina += 30;
                }
                
            }
        }
        public string mesec(int rbr)
        {
            string str = "";
            switch (rbr)
            {
                case 1: str = "Januar"; break;
                case 2: str = "Februar"; break;
                case 3: str = "Mart"; break;
                case 4: str = "April"; break;
                case 5: str = "Maj"; break;
                case 6: str = "Jun"; break;
                case 7: str = "Jul"; break;
                case 8: str = "Avgust"; break;
                case 9: str = "Septembar"; break;
                case 10: str = "Oktobar"; break;
                case 11: str = "Novembar"; break;
                case 12: str = "Decembar"; break;
            }
            return str;
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            if (txtPretraga.Text.Trim().Length > 0)
            {
                cbKategorije.Text = "";
            }
            if (txtPretraga.Text == "")
            {
                OsveziProizvodePocetna();
            }
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            FormaDodajProizvod frm = new FormaDodajProizvod(ds);
            frm.Show();
        }

        private void btnIzmeniProizvod_Click(object sender, EventArgs e)
        {
            DataGridViewRow selektovani = gwProizvodi.Rows[indeks_proizvoda];
            
            if (selektovani != null)
            {
                string str_id = selektovani.Cells["ID"].Value.ToString();
                FormaIzmeniProizvod frm = new FormaIzmeniProizvod(ds, str_id);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Izaberite proizvod");
            }
        }

        private void gwPocetna_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in gwPocetna.Rows)
            {
                row.Cells["KategorijaC"].Value = row.Cells["Kategorija"].Value;
            }
        }

        private void gwProizvodi_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in gwProizvodi.Rows)
            {
                row.Cells["KategorijaC"].Value = row.Cells["Kategorija"].Value;
            }
        }

        private void cbKategorije_TextChanged(object sender, EventArgs e)
        {
            if (cbKategorije.Text == "")
            {
                OsveziProizvodePocetna();
            }
        }

        private void gwPocetna_SelectionChanged(object sender, EventArgs e)
        {
            nudKolicina.Value = 0;
        }

    }
}
