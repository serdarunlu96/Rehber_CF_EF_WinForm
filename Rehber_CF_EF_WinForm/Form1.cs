using Microsoft.EntityFrameworkCore;
using Rehber_CF_EF_WinForm.Data;

namespace Rehber_CF_EF_WinForm
{
    public partial class Form1 : Form
    {
        RehberContext db;
        public Form1()
        {
            db = new RehberContext();
            InitializeComponent();
            dgvRehber.DataSource = db.Kisiler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTelefon.Text;

            if (ad == "" || soyad == "" || telefon == "")
            {
                MessageBox.Show("Ad ya da soyad ya da telefon bos, eksik olaný giriniz.");
                return;
            }
            if (db.Kisiler.Any(k => k.Telefon == telefon))
            {
                MessageBox.Show("Telefon daha once girildi, baska telefon giriniz");
                return;
            }
            db.Add(new Kisi() { Ad = ad, Soyad = soyad, Telefon = telefon });
            db.SaveChanges();
            KisilerListele();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
        }

        private void KisilerListele()
        {
            dgvRehber.DataSource = db.Kisiler.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;

            if (db.Kisiler.Any(x => x.Ad.Contains(adSoyad)) || db.Kisiler.Any(x => x.Soyad.Contains(adSoyad)))
            {
                dgvRehber.DataSource = db.Kisiler.Where(x => x.Ad.Contains(adSoyad) || x.Soyad.Contains(adSoyad)).ToList();
                txtAdSoyad.Clear();
            }
            else
            {
                dgvRehber.DataSource = null;
                MessageBox.Show("Eslesen kisi bulunamadý.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ad = txtAdSoyad.Text;
            string soyad = txtAdSoyad.Text;
            string telefon = txtTelefon.Text;

            db.Update(new Kisi() { Ad = ad, Soyad = soyad, Telefon = telefon });
            db.SaveChanges();
            KisilerListele();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvRehber.SelectedRows.Count < 0)
            {
                MessageBox.Show("Rehberden birisini seçmeniz lazým!");
                return;
            }

            Kisi silinecekKisi = (Kisi)dgvRehber.SelectedRows[0].DataBoundItem;

            db.Kisiler.Remove(silinecekKisi);
            db.SaveChanges();
            MessageBox.Show("Kisi rehberden silindi.");
            KisilerListele();
        }
    }
}