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
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Odeme Odeme { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {
            if (nmTutar.Value == 0)
            {
                errorProvider1.SetError(nmTutar, "Tutar boş geçilemez");
                nmTutar.Focus();
                return;
            }
            else 
            {
                errorProvider1.SetError(nmTutar, "");
            }
            if (cbtur.SelectedItem == null)
            {
                errorProvider1.SetError(cbtur, "Tür boş geçilemez.");
                cbtur.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbtur, "");
            }
            if (txtAcıklama.Text == "") 
            {
                errorProvider1.SetError(txtAcıklama, "Açıklama boş geçilemez.");
                cbtur.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAcıklama, "");
            }
            Odeme.MusteriID = Guid.Parse(txtMusteri.Text);
            Odeme.Tur = cbtur.SelectedItem.ToString();
            Odeme.Tarih = dtpTarih.Value;
            Odeme.Tutar = (double)nmTutar.Value;
            Odeme.Aciklama= txtAcıklama.Text;

            DialogResult = DialogResult.OK;
        }
        private void BtnMusteri_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMusteri.Text = frm.Musteri.ID.ToString();
            }
        }
    }
}
    

