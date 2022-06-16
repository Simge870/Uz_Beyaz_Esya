using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Uz_Beyaz_Esya.BL;
using Uz_Beyaz_Esya.UI;

namespace Uz_Beyaz_Esya
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void Anaform_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.SatisDetay();
            if (ds1 != null)
                dataSatisYap.DataSource = ds1.Tables[0];


            DataSet ds2 = BLogic.OdemeDetay();
            if (ds2 != null)
                dataOdemeYap.DataSource = ds2.Tables[0];
        }

        Musteriler mf = new Musteriler();
        Urunler uf = new Urunler();
        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            uf.ShowDialog();
        }
        

        private void btnSatisDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataSatisYap.SelectedRows[0];

            frmSatis frm = new frmSatis()
            {
                Text = "Satış Güncelle",
                Güncelleme = true,
                Satis = new Satis()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    UrunID = Guid.Parse(row.Cells[2].Value.ToString()),
                    Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[4].Value.ToString()),

                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisGüncelle(frm.Satis);

                if (b)
                {
                    row.Cells[1].Value = frm.Satis.MusteriID;
                    row.Cells[2].Value = frm.Satis.UrunID;
                    row.Cells[3].Value = frm.Satis.Fiyat;
                    row.Cells[4].Value = frm.Satis.Tarih;

                }

            }
        }

        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataSatisYap.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.SatisDetay();
                    if (ds != null)
                        dataSatisYap.DataSource = ds.Tables[0];
                }
            }
        }
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            FrmOdeme frm = new FrmOdeme()
            {
                Text = "Ödeme Yap",
                Odeme = new Odeme()
                {
                    ID = Guid.NewGuid()
                }
            };


        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeEkle(frm.Odeme);

                if (b)
                {

                    DataSet ds2 = BLogic.OdemeDetay();
                    if (ds2 != null)
                        dataOdemeYap.DataSource = ds2.Tables[0];
                }
                else
                    goto tekrar;
            }
        }
                
            private void btnOdemeDuzenle_Click(object sender, EventArgs e)
            {
                DataGridViewRow row = dataOdemeYap.SelectedRows[0];

                FrmOdeme frm = new FrmOdeme()
                {
                    Text = "Ödeme Güncelle",
                    Güncelleme = true,
                    Odeme = new Odeme()
                    {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[2].Value.ToString()),
                    Tutar = double.Parse(row.Cells[3].Value.ToString()),
                    Tur = row.Cells[4].Value.ToString(),
                    Aciklama = row.Cells[5].Value.ToString(),

                    },
            };

                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                bool b = BLogic.OdemeGüncelle(frm.Odeme);

                if (b)
                {
                    row.Cells[1].Value = frm.Odeme.MusteriID;
                    row.Cells[2].Value = frm.Odeme.Tarih;
                    row.Cells[3].Value = frm.Odeme.Tutar;
                    row.Cells[4].Value = frm.Odeme.Tur;
                    row.Cells[5].Value = frm.Odeme.Aciklama;
                }        
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.UrunGetir(button1.Text);
            if (ds != null)
                dataSatisYap.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.UrunGetir(button2.Text);
            if (ds != null)
                dataOdemeYap.DataSource = ds.Tables[0];
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataSatisYap.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.OdemeDetay();
                    if (ds != null)
                        dataSatisYap.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnSatısYap_Click(object sender, EventArgs e)
        {
            frmSatis frm = new frmSatis()
            {
                Text = "Satış Yap",
                Satis = new Satis()
                {
                    ID = Guid.NewGuid()
                }
            };


        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisEkle(frm.Satis);

                if (b)
                {

                    DataSet ds1 = BLogic.SatisDetay();
                    if (ds1 != null)
                        dataSatisYap.DataSource = ds1.Tables[0];
                }
                else
                    goto tekrar;

            }
        }
    }
}
