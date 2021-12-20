
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtKisiNo = new System.Windows.Forms.TextBox();
            this.txtAdresNo = new System.Windows.Forms.TextBox();
            this.txtIletisimNo = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBolge = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbBagisTur = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBagisNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBagisMiktar = new System.Windows.Forms.TextBox();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbBagisciEkle = new System.Windows.Forms.RadioButton();
            this.rdbBagisEkle = new System.Windows.Forms.RadioButton();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rdbBagisGuncelle = new System.Windows.Forms.RadioButton();
            this.rdbBagisciGuncelle = new System.Windows.Forms.RadioButton();
            this.rdbBagisSil = new System.Windows.Forms.RadioButton();
            this.rdbBagisciSil = new System.Windows.Forms.RadioButton();
            this.rdbBagisAra = new System.Windows.Forms.RadioButton();
            this.rdbBagisciAra = new System.Windows.Forms.RadioButton();
            this.txtBagisAdresNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBagisUlke = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(514, 227);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(123, 267);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(120, 22);
            this.txtAdi.TabIndex = 5;
            // 
            // txtKisiNo
            // 
            this.txtKisiNo.Location = new System.Drawing.Point(123, 343);
            this.txtKisiNo.Name = "txtKisiNo";
            this.txtKisiNo.Size = new System.Drawing.Size(120, 22);
            this.txtKisiNo.TabIndex = 6;
            // 
            // txtAdresNo
            // 
            this.txtAdresNo.Location = new System.Drawing.Point(389, 262);
            this.txtAdresNo.Name = "txtAdresNo";
            this.txtAdresNo.Size = new System.Drawing.Size(120, 22);
            this.txtAdresNo.TabIndex = 7;
            // 
            // txtIletisimNo
            // 
            this.txtIletisimNo.Location = new System.Drawing.Point(124, 381);
            this.txtIletisimNo.Name = "txtIletisimNo";
            this.txtIletisimNo.Size = new System.Drawing.Size(120, 22);
            this.txtIletisimNo.TabIndex = 8;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(123, 305);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(120, 22);
            this.txtSoyadi.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "KISI NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "SOYADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "ADRES NO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "ILETISIM NO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "BOLGE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(319, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "SEHIR";
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(389, 340);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(120, 22);
            this.txtSehir.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(328, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "ULKE";
            // 
            // txtBolge
            // 
            this.txtBolge.Location = new System.Drawing.Point(389, 301);
            this.txtBolge.Name = "txtBolge";
            this.txtBolge.Size = new System.Drawing.Size(120, 22);
            this.txtBolge.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(574, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "BAGIS TUR";
            // 
            // cmbBagisTur
            // 
            this.cmbBagisTur.FormattingEnabled = true;
            this.cmbBagisTur.Items.AddRange(new object[] {
            "SU KUYUSU",
            "KURBAN",
            "YETIM HAMILIGI",
            "SADAKA"});
            this.cmbBagisTur.Location = new System.Drawing.Point(669, 260);
            this.cmbBagisTur.Name = "cmbBagisTur";
            this.cmbBagisTur.Size = new System.Drawing.Size(121, 24);
            this.cmbBagisTur.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(574, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "BAGIS NO";
            // 
            // txtBagisNo
            // 
            this.txtBagisNo.Location = new System.Drawing.Point(670, 301);
            this.txtBagisNo.Name = "txtBagisNo";
            this.txtBagisNo.Size = new System.Drawing.Size(120, 22);
            this.txtBagisNo.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(544, 341);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 17);
            this.label18.TabIndex = 47;
            this.label18.Text = "BAGIS MIKTAR";
            // 
            // txtBagisMiktar
            // 
            this.txtBagisMiktar.Location = new System.Drawing.Point(669, 340);
            this.txtBagisMiktar.Name = "txtBagisMiktar";
            this.txtBagisMiktar.Size = new System.Drawing.Size(120, 22);
            this.txtBagisMiktar.TabIndex = 46;
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(389, 379);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(120, 22);
            this.txtUlke.TabIndex = 48;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbBagisAra);
            this.groupBox2.Controls.Add(this.rdbBagisciAra);
            this.groupBox2.Controls.Add(this.rdbBagisSil);
            this.groupBox2.Controls.Add(this.rdbBagisciSil);
            this.groupBox2.Controls.Add(this.rdbBagisGuncelle);
            this.groupBox2.Controls.Add(this.rdbBagisEkle);
            this.groupBox2.Controls.Add(this.rdbBagisciGuncelle);
            this.groupBox2.Controls.Add(this.rdbBagisciEkle);
            this.groupBox2.Location = new System.Drawing.Point(566, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 227);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekle ";
            // 
            // rdbBagisciEkle
            // 
            this.rdbBagisciEkle.AutoSize = true;
            this.rdbBagisciEkle.Location = new System.Drawing.Point(6, 34);
            this.rdbBagisciEkle.Name = "rdbBagisciEkle";
            this.rdbBagisciEkle.Size = new System.Drawing.Size(105, 21);
            this.rdbBagisciEkle.TabIndex = 5;
            this.rdbBagisciEkle.TabStop = true;
            this.rdbBagisciEkle.Text = "Bagisci Ekle";
            this.rdbBagisciEkle.UseVisualStyleBackColor = true;
            this.rdbBagisciEkle.CheckedChanged += new System.EventHandler(this.rdbBagisciEkle_CheckedChanged);
            // 
            // rdbBagisEkle
            // 
            this.rdbBagisEkle.AutoSize = true;
            this.rdbBagisEkle.Location = new System.Drawing.Point(6, 63);
            this.rdbBagisEkle.Name = "rdbBagisEkle";
            this.rdbBagisEkle.Size = new System.Drawing.Size(95, 21);
            this.rdbBagisEkle.TabIndex = 6;
            this.rdbBagisEkle.TabStop = true;
            this.rdbBagisEkle.Text = "Bagis Ekle";
            this.rdbBagisEkle.UseVisualStyleBackColor = true;
            this.rdbBagisEkle.CheckedChanged += new System.EventHandler(this.rdbBagisEkle_CheckedChanged);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(575, 427);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(194, 57);
            this.btnOnayla.TabIndex = 51;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(669, 379);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(120, 22);
            this.txtTelefon.TabIndex = 54;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(547, 379);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 17);
            this.label17.TabIndex = 52;
            this.label17.Text = "TELEFON(11)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 42);
            this.button1.TabIndex = 55;
            this.button1.Text = "CIKIS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 37);
            this.button2.TabIndex = 56;
            this.button2.Text = "BAGIS LISTESI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 37);
            this.button3.TabIndex = 57;
            this.button3.Text = "BAGISCI LISTESI";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rdbBagisGuncelle
            // 
            this.rdbBagisGuncelle.AutoSize = true;
            this.rdbBagisGuncelle.Location = new System.Drawing.Point(7, 121);
            this.rdbBagisGuncelle.Name = "rdbBagisGuncelle";
            this.rdbBagisGuncelle.Size = new System.Drawing.Size(124, 21);
            this.rdbBagisGuncelle.TabIndex = 6;
            this.rdbBagisGuncelle.TabStop = true;
            this.rdbBagisGuncelle.Text = "Bagis Guncelle";
            this.rdbBagisGuncelle.UseVisualStyleBackColor = true;
            this.rdbBagisGuncelle.CheckedChanged += new System.EventHandler(this.rdbBagisGuncelle_CheckedChanged);
            // 
            // rdbBagisciGuncelle
            // 
            this.rdbBagisciGuncelle.AutoSize = true;
            this.rdbBagisciGuncelle.Location = new System.Drawing.Point(6, 92);
            this.rdbBagisciGuncelle.Name = "rdbBagisciGuncelle";
            this.rdbBagisciGuncelle.Size = new System.Drawing.Size(134, 21);
            this.rdbBagisciGuncelle.TabIndex = 5;
            this.rdbBagisciGuncelle.TabStop = true;
            this.rdbBagisciGuncelle.Text = "Bagisci Guncelle";
            this.rdbBagisciGuncelle.UseVisualStyleBackColor = true;
            this.rdbBagisciGuncelle.CheckedChanged += new System.EventHandler(this.rdbBagisciGuncelle_CheckedChanged);
            // 
            // rdbBagisSil
            // 
            this.rdbBagisSil.AutoSize = true;
            this.rdbBagisSil.Location = new System.Drawing.Point(8, 179);
            this.rdbBagisSil.Name = "rdbBagisSil";
            this.rdbBagisSil.Size = new System.Drawing.Size(83, 21);
            this.rdbBagisSil.TabIndex = 8;
            this.rdbBagisSil.TabStop = true;
            this.rdbBagisSil.Text = "Bagis Sil";
            this.rdbBagisSil.UseVisualStyleBackColor = true;
            this.rdbBagisSil.CheckedChanged += new System.EventHandler(this.rdbBagisSil_CheckedChanged);
            // 
            // rdbBagisciSil
            // 
            this.rdbBagisciSil.AutoSize = true;
            this.rdbBagisciSil.Location = new System.Drawing.Point(7, 150);
            this.rdbBagisciSil.Name = "rdbBagisciSil";
            this.rdbBagisciSil.Size = new System.Drawing.Size(93, 21);
            this.rdbBagisciSil.TabIndex = 7;
            this.rdbBagisciSil.TabStop = true;
            this.rdbBagisciSil.Text = "Bagisci Sil";
            this.rdbBagisciSil.UseVisualStyleBackColor = true;
            this.rdbBagisciSil.CheckedChanged += new System.EventHandler(this.rdbBagisciSil_CheckedChanged);
            // 
            // rdbBagisAra
            // 
            this.rdbBagisAra.AutoSize = true;
            this.rdbBagisAra.Location = new System.Drawing.Point(116, 177);
            this.rdbBagisAra.Name = "rdbBagisAra";
            this.rdbBagisAra.Size = new System.Drawing.Size(90, 21);
            this.rdbBagisAra.TabIndex = 10;
            this.rdbBagisAra.TabStop = true;
            this.rdbBagisAra.Text = "Bagis Ara";
            this.rdbBagisAra.UseVisualStyleBackColor = true;
            this.rdbBagisAra.CheckedChanged += new System.EventHandler(this.rdbBagisAra_CheckedChanged);
            // 
            // rdbBagisciAra
            // 
            this.rdbBagisciAra.AutoSize = true;
            this.rdbBagisciAra.Location = new System.Drawing.Point(116, 150);
            this.rdbBagisciAra.Name = "rdbBagisciAra";
            this.rdbBagisciAra.Size = new System.Drawing.Size(100, 21);
            this.rdbBagisciAra.TabIndex = 9;
            this.rdbBagisciAra.TabStop = true;
            this.rdbBagisciAra.Text = "Bagisci Ara";
            this.rdbBagisciAra.UseVisualStyleBackColor = true;
            this.rdbBagisciAra.CheckedChanged += new System.EventHandler(this.rdbBagisciAra_CheckedChanged);
            // 
            // txtBagisAdresNo
            // 
            this.txtBagisAdresNo.Location = new System.Drawing.Point(389, 418);
            this.txtBagisAdresNo.Name = "txtBagisAdresNo";
            this.txtBagisAdresNo.Size = new System.Drawing.Size(120, 22);
            this.txtBagisAdresNo.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "bagis adres no";
            // 
            // txtBagisUlke
            // 
            this.txtBagisUlke.Location = new System.Drawing.Point(389, 446);
            this.txtBagisUlke.Name = "txtBagisUlke";
            this.txtBagisUlke.Size = new System.Drawing.Size(120, 22);
            this.txtBagisUlke.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "bagis ulke";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(806, 537);
            this.Controls.Add(this.txtBagisUlke);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBagisAdresNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtUlke);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtBagisMiktar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbBagisTur);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBagisNo);
            this.Controls.Add(this.txtBolge);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtIletisimNo);
            this.Controls.Add(this.txtAdresNo);
            this.Controls.Add(this.txtKisiNo);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtKisiNo;
        private System.Windows.Forms.TextBox txtAdresNo;
        private System.Windows.Forms.TextBox txtIletisimNo;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBolge;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbBagisTur;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBagisNo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBagisMiktar;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbBagisEkle;
        private System.Windows.Forms.RadioButton rdbBagisciEkle;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rdbBagisGuncelle;
        private System.Windows.Forms.RadioButton rdbBagisciGuncelle;
        private System.Windows.Forms.RadioButton rdbBagisAra;
        private System.Windows.Forms.RadioButton rdbBagisciAra;
        private System.Windows.Forms.RadioButton rdbBagisSil;
        private System.Windows.Forms.RadioButton rdbBagisciSil;
        private System.Windows.Forms.TextBox txtBagisAdresNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBagisUlke;
        private System.Windows.Forms.Label label7;
    }
}

