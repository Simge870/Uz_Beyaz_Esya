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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun()
            {
                Text = "Ürün Ekle",
                Urun = new Urun() { ID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunEkle(frm.Urun);

                if (b)
                {

                    DataSet ds = BLogic.UrunGetir("");
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

            FrmUrun frm = new FrmUrun()
            {
                Text = "Ürün Güncelle",
                Güncelleme = true,
                Urun = new Urun()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Marka = row.Cells[1].Value.ToString(),
                    Model = row.Cells[2].Value.ToString(),
                    Renk = row.Cells[3].Value.ToString(),
                    Seri = row.Cells[4].Value.ToString(),
                    Stok = row.Cells[5].Value.ToString(),
                    Garanti = row.Cells[6].Value.ToString(),
                    Tarih = row.Cells[7].Value.ToString(),
                }
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunGüncelle(frm.Urun);

                if (b)
                {
                    row.Cells[1].Value = frm.Urun.Marka;
                    row.Cells[2].Value = frm.Urun.Model;
                    row.Cells[3].Value = frm.Urun.Renk;
                    row.Cells[4].Value = frm.Urun.Seri;
                    row.Cells[5].Value = frm.Urun.Stok;
                    row.Cells[6].Value = frm.Urun.Garanti;
                    row.Cells[7].Value = frm.Urun.Tarih;

                }

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.UrunGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }
        }
        public Urun Urun { get; set; }
        private void btnOk_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];


            Urun = new Urun()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Marka = row.Cells[1].Value.ToString(),
                Model = row.Cells[2].Value.ToString(),
                Renk = row.Cells[3].Value.ToString(),
                Seri = row.Cells[4].Value.ToString(),
                Stok = row.Cells[5].Value.ToString(),
                Garanti = row.Cells[6].Value.ToString(),
                Tarih = row.Cells[7].Value.ToString(),
            };

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
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
