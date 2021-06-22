using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prodavnicaTVP
{
    public partial class FormaDodajProizvod : Form
    {
        BazaDataSet3 ds = new BazaDataSet3();
        BazaDataSet3TableAdapters.KategorijaTableAdapter daKategorija;
        BazaDataSet3TableAdapters.ProizvodTableAdapter daProizvod;
        public FormaDodajProizvod()
        {
            InitializeComponent();
            daKategorija = new BazaDataSet3TableAdapters.KategorijaTableAdapter();
            daProizvod = new BazaDataSet3TableAdapters.ProizvodTableAdapter();

            daKategorija.Fill(ds.Kategorija);
            cbKategorijaPro.DataSource = null;
            cbKategorijaPro.BindingContext = new BindingContext();
            cbKategorijaPro.DisplayMember = "Naziv_kategorije";
            cbKategorijaPro.ValueMember = "Naziv_kategorije";
            cbKategorijaPro.DataSource = ds.Kategorija;
        }
        public FormaDodajProizvod(BazaDataSet3 ds):this()
        {
            this.ds = ds;
        }

        private void btnDodajPro_Click(object sender, EventArgs e)
        {
            if (txtNazivPro.Text.Trim().Length != 0 &&
                txtKolicinaPro.Text.Trim().Length != 0 &&
                txtCenaPro.Text.Trim().Length != 0 &&
                cbKategorijaPro.SelectedValue != null)
            {
                var isti_proizvod = ds.Proizvod.Where(x => x.Naziv_proizvoda.ToLower().Equals(txtNazivPro.Text.ToLower()));

                if (isti_proizvod.Count() > 0)
                {
                    MessageBox.Show("Proizvod sa ovim nazivom vec postoji");
                }
                else
                {

                    BazaDataSet3.ProizvodRow red = ds.Proizvod.NewProizvodRow();

                    int kol;
                    double ce;
                    bool pr_kol = Int32.TryParse(txtKolicinaPro.Text, out kol);
                    bool pr_ce = Double.TryParse(txtCenaPro.Text, out ce);

                    if (pr_kol && pr_ce)
                    {

                        red.Naziv_proizvoda = txtNazivPro.Text;

                        string kol_str = txtKolicinaPro.Text;
                        double kol_int = Convert.ToInt64(Convert.ToDouble(kol_str));

                        red.Kolicina = kol_int;
                        red.Cena = double.Parse(txtCenaPro.Text);

                        Kategorija k = new Kategorija();
                        k.Naziv_kategorije1 = cbKategorijaPro.SelectedItem.ToString();

                        var nadji_kategoriju = ds.Kategorija.FirstOrDefault(x => x.Naziv_kategorije.Equals(cbKategorijaPro.SelectedValue.ToString()));
                        k.ID1 = nadji_kategoriju.ID;

                        red.Kategorija = k.ID1;

                        ds.Proizvod.AddProizvodRow(red);
                        daProizvod.Update(ds.Proizvod);
                        MessageBox.Show("Uspesno ste dodali proizvod");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Podaci nisu validini");
                }
            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }
        }
    }
}
