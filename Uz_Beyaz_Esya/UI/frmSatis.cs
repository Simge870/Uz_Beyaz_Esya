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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Satis Satis { get; set; }
        public bool Güncelleme { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (nmfiyat.Value == 0)
            {
                errorProvider1.SetError(nmfiyat, "Fiyat 0 olamaz");
                nmfiyat.Focus();
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }

            Satis.Tarih = dtpTarih.Value;
            Satis.Fiyat = (double)nmfiyat.Value;
            Satis.MusteriID = Guid.Parse(txtMusteri.Text);
            Satis.UrunID = Guid.Parse(txtUrun.Text);
            Satis.ID = Guid.Parse(txtID.Text);



            DialogResult = DialogResult.OK;
        }
        private void frmSatis_Load(object sender, EventArgs e)
        {
            if (Güncelleme)
            {
                txtMusteri.Text = Satis.MusteriID.ToString();
                txtUrun.Text = Satis.UrunID.ToString();
                nmfiyat.Value = (decimal)Satis.Fiyat;
                dtpTarih.Value = Satis.Tarih;
            }
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMusteri.Text = frm.Musteri.ID.ToString();
            }
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            Urunler frm = new Urunler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUrun.Text = frm.Urun.ID.ToString();
            }
        }
    }
}