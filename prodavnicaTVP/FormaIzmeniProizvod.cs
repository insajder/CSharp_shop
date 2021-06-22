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
    public partial class FormaIzmeniProizvod : Form
    {
        BazaDataSet3 ds = new BazaDataSet3();
        BazaDataSet3TableAdapters.KategorijaTableAdapter daKategorija;
        BazaDataSet3TableAdapters.ProizvodTableAdapter daProizvod;

        string id;

        public FormaIzmeniProizvod()
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
        public FormaIzmeniProizvod(BazaDataSet3 ds, string id) : this()
        {
            this.ds = ds;
            this.id = id;

            var nadji_proizvod = ds.Proizvod.FindByID(int.Parse(id));
            
            txtNazivPro.Text = nadji_proizvod.Naziv_proizvoda;
            txtKolicinaPro.Text = nadji_proizvod.Kolicina.ToString();
            txtCenaPro.Text = nadji_proizvod.Cena.ToString();
            cbKategorijaPro.Text = nadji_proizvod.KategorijaRow.Naziv_kategorije;
        }

        private void btnSacuvajIzmenePro_Click(object sender, EventArgs e)
        {
            if (txtNazivPro.Text.Trim().Length != 0 &&
                txtKolicinaPro.Text.Trim().Length != 0 &&
                txtCenaPro.Text.Trim().Length != 0 &&
                cbKategorijaPro.SelectedValue != null)
            {
                var isti_proizvod = ds.Proizvod.Where(x => x.Naziv_proizvoda.ToLower().Equals(txtNazivPro.Text.ToLower()) &&
                                                    x.ID != int.Parse(id));

                var nadji_proizvod = ds.Proizvod.FindByID(int.Parse(id));

                if (isti_proizvod.Count() > 0)
                {
                    MessageBox.Show("Proizvod sa ovim nazivom vec postoji");
                }
                else
                {
                    int kol;
                    double ce;
                    bool pr_kol = Int32.TryParse(txtKolicinaPro.Text, out kol);
                    bool pr_ce = Double.TryParse(txtCenaPro.Text, out ce);

                    if (pr_kol && pr_ce)
                    {
                        nadji_proizvod.Naziv_proizvoda = txtNazivPro.Text;

                        string kol_str = txtKolicinaPro.Text;
                        double kol_int = Convert.ToInt64(Convert.ToDouble(kol_str));

                        nadji_proizvod.Kolicina = kol_int;
                        nadji_proizvod.Cena = double.Parse(txtCenaPro.Text);
                        nadji_proizvod.KategorijaRow.Naziv_kategorije = cbKategorijaPro.Text;

                        daProizvod.Update(ds.Proizvod);
                        MessageBox.Show("Uspesno ste izmenili proizvod");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Podaci nisu validni");
                }
            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }
        }
    }
}
