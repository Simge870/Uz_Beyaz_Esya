using Uz_Beyaz_Esya.BL;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uz_Beyaz_Esya.UI
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmMusteri frmMusteri = new frmMusteri()
            {
                Text = "Müşteri Ekle",
                Musteri = new Musteri() { ID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriEkle(frmMusteri.Musteri);

                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            frmMusteri frmMusteri = new frmMusteri()
            {
                Text = "Müşteri Güncelle",
                Güncelleme = true,
                Musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),

                },
            };

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriGüncelle(frmMusteri.Musteri);

                if (b)
                {
                    row.Cells[1].Value = frmMusteri.Musteri.Ad;
                    row.Cells[2].Value = frmMusteri.Musteri.Soyad;
                    row.Cells[3].Value = frmMusteri.Musteri.Telefon;
                    row.Cells[4].Value = frmMusteri.Musteri.Mail;
                    row.Cells[5].Value = frmMusteri.Musteri.Adres;
                }

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MüşteriGetir(btnSil.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.MüşteriGetir("");
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];
        }
        public Musteri Musteri { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];


            Musteri = new Musteri()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad = row.Cells[1].Value.ToString(),
                Soyad = row.Cells[2].Value.ToString(),
                Telefon = row.Cells[3].Value.ToString(),
                Mail = row.Cells[4].Value.ToString(),
                Adres = row.Cells[5].Value.ToString(),
            };


            DialogResult = DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.UrunGetir(button1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
