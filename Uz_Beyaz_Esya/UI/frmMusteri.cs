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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtSoyad)) return;
            if (!ErrorControl(mtxttel)) return;
            if (!ErrorControl(txtmail))return;
            if (!ErrorControl(txtAdres)) return;

            Musteri.Ad = txtAd.Text;
            Musteri.Soyad = txtSoyad.Text;
            Musteri.Telefon = mtxttel.Text;
            Musteri.Mail = txtmail.Text;
            Musteri.Adres = txtAdres.Text;
            
            DialogResult = DialogResult.OK;
        }
        public Musteri Musteri { get; set; }
        public bool Güncelleme { get; set; }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private bool ErrorControl(Control C)
        {
            if(C is TextBox)
            {
                if (C.Text == "")
                {
                    errorProvider1.SetError(C, "Lütfen tüm alanları doldurunuz.");
                    return true;
                }
                else
                {
                    errorProvider1.SetError(C, "");
                    return false;
                }
            }
            if (C is MaskedTextBox)
            {
                if (C.Text == "")
                {
                    errorProvider1.SetError(C, "Lütfen tüm alanları doldurunuz.");
                    return true;
                }
                else
                {
                    errorProvider1.SetError(C, "");
                    return false;
                }
            }
            return true;

        }
        private void frmMusteri_Load(object sender, EventArgs e)
        {
            txtID.Text= Musteri.ID.ToString();
            if (Güncelleme) {
                txtAd.Text = Musteri.Ad;
                txtSoyad.Text = Musteri.Soyad;
                mtxttel.Text = Musteri.Telefon;
                txtmail.Text = Musteri.Mail;
                txtAdres.Text = Musteri.Adres;
            }
        }
    }
}
