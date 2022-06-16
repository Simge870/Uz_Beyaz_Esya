namespace Uz_Beyaz_Esya
{
    partial class Anaform
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SatisYap = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSatisYap = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSatisDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnSatisSil = new System.Windows.Forms.ToolStripButton();
            this.OdemeYap = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataOdemeYap = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnOdemeDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnOdemeSil = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMusteriler = new System.Windows.Forms.ToolStripButton();
            this.btnUrunler = new System.Windows.Forms.ToolStripButton();
            this.btnSatısYap = new System.Windows.Forms.ToolStripButton();
            this.btnOdemeYap = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.SatisYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSatisYap)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.OdemeYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOdemeYap)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SatisYap);
            this.tabControl1.Controls.Add(this.OdemeYap);
            this.tabControl1.Location = new System.Drawing.Point(3, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 279);
            this.tabControl1.TabIndex = 0;
            // 
            // SatisYap
            // 
            this.SatisYap.Controls.Add(this.button1);
            this.SatisYap.Controls.Add(this.textBox1);
            this.SatisYap.Controls.Add(this.label1);
            this.SatisYap.Controls.Add(this.dataSatisYap);
            this.SatisYap.Controls.Add(this.toolStrip2);
            this.SatisYap.Location = new System.Drawing.Point(4, 22);
            this.SatisYap.Name = "SatisYap";
            this.SatisYap.Padding = new System.Windows.Forms.Padding(3);
            this.SatisYap.Size = new System.Drawing.Size(526, 253);
            this.SatisYap.TabIndex = 0;
            this.SatisYap.Text = "Satış Yap";
            this.SatisYap.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Uz_Beyaz_Esya.Properties.Resources.button_circle_find;
            this.button1.Location = new System.Drawing.Point(464, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ara:";
            // 
            // dataSatisYap
            // 
            this.dataSatisYap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSatisYap.Location = new System.Drawing.Point(5, 31);
            this.dataSatisYap.Name = "dataSatisYap";
            this.dataSatisYap.Size = new System.Drawing.Size(513, 216);
            this.dataSatisYap.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSatisDuzenle,
            this.btnSatisSil});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(520, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSatisDuzenle
            // 
            this.btnSatisDuzenle.Image = global::Uz_Beyaz_Esya.Properties.Resources.give_money_1_update;
            this.btnSatisDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatisDuzenle.Name = "btnSatisDuzenle";
            this.btnSatisDuzenle.Size = new System.Drawing.Size(69, 22);
            this.btnSatisDuzenle.Text = "Düzenle";
            this.btnSatisDuzenle.Click += new System.EventHandler(this.btnSatisDuzenle_Click);
            // 
            // btnSatisSil
            // 
            this.btnSatisSil.Image = global::Uz_Beyaz_Esya.Properties.Resources.give_money_1_remove;
            this.btnSatisSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatisSil.Name = "btnSatisSil";
            this.btnSatisSil.Size = new System.Drawing.Size(39, 22);
            this.btnSatisSil.Text = "Sil";
            this.btnSatisSil.Click += new System.EventHandler(this.btnSatisSil_Click);
            // 
            // OdemeYap
            // 
            this.OdemeYap.Controls.Add(this.button2);
            this.OdemeYap.Controls.Add(this.dataOdemeYap);
            this.OdemeYap.Controls.Add(this.textBox2);
            this.OdemeYap.Controls.Add(this.label2);
            this.OdemeYap.Controls.Add(this.toolStrip3);
            this.OdemeYap.Location = new System.Drawing.Point(4, 22);
            this.OdemeYap.Name = "OdemeYap";
            this.OdemeYap.Padding = new System.Windows.Forms.Padding(3);
            this.OdemeYap.Size = new System.Drawing.Size(526, 253);
            this.OdemeYap.TabIndex = 1;
            this.OdemeYap.Text = "Ödeme Yap";
            this.OdemeYap.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Uz_Beyaz_Esya.Properties.Resources.button_circle_find;
            this.button2.Location = new System.Drawing.Point(472, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataOdemeYap
            // 
            this.dataOdemeYap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOdemeYap.Location = new System.Drawing.Point(6, 31);
            this.dataOdemeYap.Name = "dataOdemeYap";
            this.dataOdemeYap.Size = new System.Drawing.Size(512, 216);
            this.dataOdemeYap.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(357, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ara:";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOdemeDuzenle,
            this.btnOdemeSil});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(520, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnOdemeDuzenle
            // 
            this.btnOdemeDuzenle.Image = global::Uz_Beyaz_Esya.Properties.Resources.give_money_1_update;
            this.btnOdemeDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeDuzenle.Name = "btnOdemeDuzenle";
            this.btnOdemeDuzenle.Size = new System.Drawing.Size(69, 22);
            this.btnOdemeDuzenle.Text = "Düzenle";
            this.btnOdemeDuzenle.ToolTipText = "btnOdemeDuzenle";
            this.btnOdemeDuzenle.Click += new System.EventHandler(this.btnOdemeDuzenle_Click);
            // 
            // btnOdemeSil
            // 
            this.btnOdemeSil.Image = global::Uz_Beyaz_Esya.Properties.Resources.give_money_1_remove;
            this.btnOdemeSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeSil.Name = "btnOdemeSil";
            this.btnOdemeSil.Size = new System.Drawing.Size(39, 22);
            this.btnOdemeSil.Text = "Sil";
            this.btnOdemeSil.ToolTipText = "btnOdemeSil";
            this.btnOdemeSil.Click += new System.EventHandler(this.btnOdemeSil_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMusteriler,
            this.btnUrunler,
            this.btnSatısYap,
            this.btnOdemeYap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(537, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Image = global::Uz_Beyaz_Esya.Properties.Resources.user_id;
            this.btnMusteriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(80, 22);
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Image = global::Uz_Beyaz_Esya.Properties.Resources.roller_transport;
            this.btnUrunler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(66, 22);
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnSatısYap
            // 
            this.btnSatısYap.Image = global::Uz_Beyaz_Esya.Properties.Resources.give_money_1_add;
            this.btnSatısYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatısYap.Name = "btnSatısYap";
            this.btnSatısYap.Size = new System.Drawing.Size(73, 22);
            this.btnSatısYap.Text = "Satış Yap";
            this.btnSatısYap.Click += new System.EventHandler(this.btnSatısYap_Click);
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Image = global::Uz_Beyaz_Esya.Properties.Resources.credit_card_back;
            this.btnOdemeYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(88, 22);
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 309);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.Anaform_Load);
            this.tabControl1.ResumeLayout(false);
            this.SatisYap.ResumeLayout(false);
            this.SatisYap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSatisYap)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.OdemeYap.ResumeLayout(false);
            this.OdemeYap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOdemeYap)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SatisYap;
        private System.Windows.Forms.DataGridView dataSatisYap;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSatisDuzenle;
        private System.Windows.Forms.ToolStripButton btnSatisSil;
        private System.Windows.Forms.TabPage OdemeYap;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMusteriler;
        private System.Windows.Forms.ToolStripButton btnUrunler;
        private System.Windows.Forms.ToolStripButton btnSatısYap;
        private System.Windows.Forms.ToolStripButton btnOdemeYap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataOdemeYap;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnOdemeDuzenle;
        private System.Windows.Forms.ToolStripButton btnOdemeSil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

