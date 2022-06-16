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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Urun Urun { get; set; }
        public bool Güncelleme { get; set; }
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            if (Güncelleme)
            {
                if (!ErrorControl(txtMarka)) return;
                if (!ErrorControl(txtModel)) return;
                if (!ErrorControl(txtRenk)) return;
                if (!ErrorControl(nmStok)) return;
                if (!ErrorControl(txtSeri)) return;
                if (!ErrorControl(nmGaranti)) return;
                if (!ErrorControl(dtTarih)) return;

                Urun.Marka = txtMarka.Text;
                Urun.Model = txtModel.Text;
                Urun.Renk = txtRenk.Text;
                Urun.Seri = txtSeri.Text;
                Urun.Stok = nmStok.Text;
                Urun.Garanti = nmGaranti.Text;
                Urun.Tarih = dtTarih.Text;


                DialogResult = DialogResult.OK;
            }    
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (string.IsNullOrEmpty(c.Text))
                {
                    errorProvider1.SetError(c, "Boş geçilemez");
                    return false;
                }
            }
            else if (c is NumericUpDown)
            {
                if (c.Text == "0")
                {
                    errorProvider1.SetError(c, "Boş geçilemez");
                    return false;
                }
            }
            else if (c is DateTimePicker)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Boş geçilemez");
                    return false;
                }
            }
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtMarka)) return;
            if (!ErrorControl(txtModel)) return;
            if (!ErrorControl(txtRenk)) return;
            if (!ErrorControl(nmStok)) return;
            if (!ErrorControl(txtSeri)) return;
            if (!ErrorControl(nmGaranti)) return;
            if (!ErrorControl(dtTarih)) return;

            Urun.Marka = txtMarka.Text;
            Urun.Model = txtModel.Text;
            Urun.Renk = txtRenk.Text;
            Urun.Stok = nmStok.Text;
            Urun.Seri = txtSeri.Text;
            Urun.Garanti = nmGaranti.Text;
            Urun.Tarih = dtTarih.Text;


            DialogResult = DialogResult.OK;
        }
    }
}