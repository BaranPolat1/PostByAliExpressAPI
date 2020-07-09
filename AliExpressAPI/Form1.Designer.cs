namespace AliExpressAPI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTedarikciXML = new System.Windows.Forms.TextBox();
            this.btnXmlOku = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUrunAdi = new System.Windows.Forms.ComboBox();
            this.cmbUrunAciklama = new System.Windows.Forms.ComboBox();
            this.cmbPaketYuksekligi = new System.Windows.Forms.ComboBox();
            this.cmbPaketGenisligi = new System.Windows.Forms.ComboBox();
            this.cmbPaketUzunlugu = new System.Windows.Forms.ComboBox();
            this.cmbPaketAgirligi = new System.Windows.Forms.ComboBox();
            this.txtUrunDil = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbUrunFoto1 = new System.Windows.Forms.ComboBox();
            this.cmbUrunFoto2 = new System.Windows.Forms.ComboBox();
            this.cmbUrunFoto4 = new System.Windows.Forms.ComboBox();
            this.cmbUrunFoto5 = new System.Windows.Forms.ComboBox();
            this.cmbUrunFoto6 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbUrunFiyat = new System.Windows.Forms.ComboBox();
            this.cmbStokAded = new System.Windows.Forms.ComboBox();
            this.brnUrunGonder = new System.Windows.Forms.Button();
            this.txtKargoSablonID = new System.Windows.Forms.TextBox();
            this.txtHizmetPolitikaNo = new System.Windows.Forms.TextBox();
            this.cmbParentElement = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbUrunFoto3 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtKargoyaVerilisSuresi = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbUrunMarka = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HataMesaji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HataKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tedarkçi XML dosyası:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTedarikciXML
            // 
            this.txtTedarikciXML.Location = new System.Drawing.Point(183, 15);
            this.txtTedarikciXML.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTedarikciXML.Multiline = true;
            this.txtTedarikciXML.Name = "txtTedarikciXML";
            this.txtTedarikciXML.Size = new System.Drawing.Size(168, 26);
            this.txtTedarikciXML.TabIndex = 1;
            // 
            // btnXmlOku
            // 
            this.btnXmlOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnXmlOku.Location = new System.Drawing.Point(191, 53);
            this.btnXmlOku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXmlOku.Name = "btnXmlOku";
            this.btnXmlOku.Size = new System.Drawing.Size(148, 30);
            this.btnXmlOku.TabIndex = 2;
            this.btnXmlOku.Text = "XML\'i Oku";
            this.btnXmlOku.UseVisualStyleBackColor = true;
            this.btnXmlOku.Click += new System.EventHandler(this.btnXmlOku_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Açıklaması:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Desteklenen Dil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(368, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Paket Yüksekliği:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(368, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Paket Genişliği:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(368, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Paket Uzunluğu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(368, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Paket Ağırlığı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(369, 346);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kargo Şablon ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(368, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Hizmet Politikası No:";
            // 
            // cmbUrunAdi
            // 
            this.cmbUrunAdi.FormattingEnabled = true;
            this.cmbUrunAdi.Location = new System.Drawing.Point(198, 113);
            this.cmbUrunAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUrunAdi.Name = "cmbUrunAdi";
            this.cmbUrunAdi.Size = new System.Drawing.Size(143, 21);
            this.cmbUrunAdi.TabIndex = 3;
            // 
            // cmbUrunAciklama
            // 
            this.cmbUrunAciklama.FormattingEnabled = true;
            this.cmbUrunAciklama.Location = new System.Drawing.Point(198, 162);
            this.cmbUrunAciklama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUrunAciklama.Name = "cmbUrunAciklama";
            this.cmbUrunAciklama.Size = new System.Drawing.Size(143, 21);
            this.cmbUrunAciklama.TabIndex = 3;
            // 
            // cmbPaketYuksekligi
            // 
            this.cmbPaketYuksekligi.FormattingEnabled = true;
            this.cmbPaketYuksekligi.Location = new System.Drawing.Point(557, 106);
            this.cmbPaketYuksekligi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPaketYuksekligi.Name = "cmbPaketYuksekligi";
            this.cmbPaketYuksekligi.Size = new System.Drawing.Size(143, 21);
            this.cmbPaketYuksekligi.TabIndex = 3;
            // 
            // cmbPaketGenisligi
            // 
            this.cmbPaketGenisligi.FormattingEnabled = true;
            this.cmbPaketGenisligi.Location = new System.Drawing.Point(557, 151);
            this.cmbPaketGenisligi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPaketGenisligi.Name = "cmbPaketGenisligi";
            this.cmbPaketGenisligi.Size = new System.Drawing.Size(143, 21);
            this.cmbPaketGenisligi.TabIndex = 3;
            // 
            // cmbPaketUzunlugu
            // 
            this.cmbPaketUzunlugu.FormattingEnabled = true;
            this.cmbPaketUzunlugu.Location = new System.Drawing.Point(557, 201);
            this.cmbPaketUzunlugu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPaketUzunlugu.Name = "cmbPaketUzunlugu";
            this.cmbPaketUzunlugu.Size = new System.Drawing.Size(143, 21);
            this.cmbPaketUzunlugu.TabIndex = 3;
            // 
            // cmbPaketAgirligi
            // 
            this.cmbPaketAgirligi.FormattingEnabled = true;
            this.cmbPaketAgirligi.Location = new System.Drawing.Point(557, 63);
            this.cmbPaketAgirligi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPaketAgirligi.Name = "cmbPaketAgirligi";
            this.cmbPaketAgirligi.Size = new System.Drawing.Size(143, 21);
            this.cmbPaketAgirligi.TabIndex = 3;
            // 
            // txtUrunDil
            // 
            this.txtUrunDil.Location = new System.Drawing.Point(198, 343);
            this.txtUrunDil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUrunDil.Name = "txtUrunDil";
            this.txtUrunDil.Size = new System.Drawing.Size(143, 20);
            this.txtUrunDil.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(727, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ürün Fotoğraf 1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(727, 63);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ürün Fotoğraf 2:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(727, 156);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ürün Fotoğraf 4:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(727, 110);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Ürün Fotoğraf 3:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(726, 203);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ürün Fotoğraf 5:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(726, 249);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Ürün Fotoğraf 6:";
            // 
            // cmbUrunFoto1
            // 
            this.cmbUrunFoto1.FormattingEnabled = true;
            this.cmbUrunFoto1.Location = new System.Drawing.Point(915, 20);
            this.cmbUrunFoto1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUrunFoto1.Name = "cmbUrunFoto1";
            this.cmbUrunFoto1.Size = new System.Drawing.Size(143, 21);
            this.cmbUrunFoto1.TabIndex = 3;
            // 
            // cmbUrunFoto2
            // 
            this.cmbUrunFoto2.FormattingEnabled = true;
            this.cmbUrunFoto2.Location = new System.Drawing.Point(915, 63);
            this.cmbUrunFoto2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUrunFoto2.Name = "cmbUrunFoto2";
            this.cmbUrunFoto2.Size = new System.Drawing.Size(143, 21);
            this.cmbUrunFoto2.TabIndex = 3;
            // 
            // cmbUrunFoto4
            // 
            this.cmbUrunFoto4.FormattingEnabled = true;
            this.cmbUrunFoto4.Location = new System.Drawing.Point(915, 156);
            this.cmbUrunFoto4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUrunFoto4.Name = "cmbUrunFoto4";
            this.cmbUrunFoto4.Size = new System.Drawing.Size(143, 21);
            this.cmbUrunFoto4.TabIndex = 3;
            // 
            // cmbUrunFoto5
            // 
            this.cmbUrunFoto5.FormattingEnabled = true;
            this.cmbUrunFoto5.Location = new System.Drawing.Point(915, 202);
            this.cmbUrunFoto5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUrunFoto5.Name = "cmbUrunFoto5";
            this.cmbUrunFoto5.Size = new System.Drawing.Size(143, 21);
            this.cmbUrunFoto5.TabIndex = 3;
            // 
            // cmbUrunFoto6
            // 
            this.cmbUrunFoto6.FormattingEnabled = true;
            this.cmbUrunFoto6.Location = new System.Drawing.Point(915, 251);
            this.cmbUrunFoto6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUrunFoto6.Name = "cmbUrunFoto6";
            this.cmbUrunFoto6.Size = new System.Drawing.Size(143, 21);
            this.cmbUrunFoto6.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(7, 205);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Ürün Fiyatı:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(9, 252);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Stok Adedi:";
            // 
            // cmbUrunFiyat
            // 
            this.cmbUrunFiyat.FormattingEnabled = true;
            this.cmbUrunFiyat.Location = new System.Drawing.Point(198, 202);
            this.cmbUrunFiyat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUrunFiyat.Name = "cmbUrunFiyat";
            this.cmbUrunFiyat.Size = new System.Drawing.Size(143, 21);
            this.cmbUrunFiyat.TabIndex = 3;
            // 
            // cmbStokAded
            // 
            this.cmbStokAded.FormattingEnabled = true;
            this.cmbStokAded.Location = new System.Drawing.Point(198, 249);
            this.cmbStokAded.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStokAded.Name = "cmbStokAded";
            this.cmbStokAded.Size = new System.Drawing.Size(143, 21);
            this.cmbStokAded.TabIndex = 3;
            // 
            // brnUrunGonder
            // 
            this.brnUrunGonder.BackColor = System.Drawing.SystemColors.Control;
            this.brnUrunGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brnUrunGonder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.brnUrunGonder.Location = new System.Drawing.Point(915, 301);
            this.brnUrunGonder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brnUrunGonder.Name = "brnUrunGonder";
            this.brnUrunGonder.Size = new System.Drawing.Size(175, 44);
            this.brnUrunGonder.TabIndex = 5;
            this.brnUrunGonder.Text = "Ürün Gönderme İşlemini Başlat";
            this.brnUrunGonder.UseVisualStyleBackColor = false;
            this.brnUrunGonder.Click += new System.EventHandler(this.brnUrunGonder_Click);
            // 
            // txtKargoSablonID
            // 
            this.txtKargoSablonID.Location = new System.Drawing.Point(557, 343);
            this.txtKargoSablonID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKargoSablonID.Multiline = true;
            this.txtKargoSablonID.Name = "txtKargoSablonID";
            this.txtKargoSablonID.Size = new System.Drawing.Size(143, 25);
            this.txtKargoSablonID.TabIndex = 6;
            // 
            // txtHizmetPolitikaNo
            // 
            this.txtHizmetPolitikaNo.Location = new System.Drawing.Point(557, 249);
            this.txtHizmetPolitikaNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHizmetPolitikaNo.Multiline = true;
            this.txtHizmetPolitikaNo.Name = "txtHizmetPolitikaNo";
            this.txtHizmetPolitikaNo.Size = new System.Drawing.Size(143, 25);
            this.txtHizmetPolitikaNo.TabIndex = 6;
            // 
            // cmbParentElement
            // 
            this.cmbParentElement.FormattingEnabled = true;
            this.cmbParentElement.Location = new System.Drawing.Point(556, 20);
            this.cmbParentElement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbParentElement.Name = "cmbParentElement";
            this.cmbParentElement.Size = new System.Drawing.Size(144, 21);
            this.cmbParentElement.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(368, 24);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(185, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Parent Elementi Seçiniz:";
            // 
            // cmbUrunFoto3
            // 
            this.cmbUrunFoto3.FormattingEnabled = true;
            this.cmbUrunFoto3.Location = new System.Drawing.Point(915, 106);
            this.cmbUrunFoto3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUrunFoto3.Name = "cmbUrunFoto3";
            this.cmbUrunFoto3.Size = new System.Drawing.Size(143, 21);
            this.cmbUrunFoto3.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(368, 297);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(174, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "Kargoya Veriliş Süresi:";
            // 
            // txtKargoyaVerilisSuresi
            // 
            this.txtKargoyaVerilisSuresi.Location = new System.Drawing.Point(557, 297);
            this.txtKargoyaVerilisSuresi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKargoyaVerilisSuresi.Multiline = true;
            this.txtKargoyaVerilisSuresi.Name = "txtKargoyaVerilisSuresi";
            this.txtKargoyaVerilisSuresi.Size = new System.Drawing.Size(143, 24);
            this.txtKargoyaVerilisSuresi.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(9, 301);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "Marka:";
            // 
            // cmbUrunMarka
            // 
            this.cmbUrunMarka.FormattingEnabled = true;
            this.cmbUrunMarka.Location = new System.Drawing.Point(198, 297);
            this.cmbUrunMarka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUrunMarka.Name = "cmbUrunMarka";
            this.cmbUrunMarka.Size = new System.Drawing.Size(143, 21);
            this.cmbUrunMarka.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunAdi,
            this.Durum,
            this.HataMesaji,
            this.HataKodu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 375);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 235);
            this.dataGridView1.TabIndex = 8;
            // 
            // UrunAdi
            // 
            this.UrunAdi.HeaderText = "Ürün";
            this.UrunAdi.MinimumWidth = 6;
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Width = 250;
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Durum";
            this.Durum.MinimumWidth = 6;
            this.Durum.Name = "Durum";
            this.Durum.Width = 250;
            // 
            // HataMesaji
            // 
            this.HataMesaji.HeaderText = "Hata Mesajı";
            this.HataMesaji.MinimumWidth = 6;
            this.HataMesaji.Name = "HataMesaji";
            this.HataMesaji.Width = 250;
            // 
            // HataKodu
            // 
            this.HataKodu.HeaderText = "Hata Kodu";
            this.HataKodu.Name = "HataKodu";
            this.HataKodu.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbUrunMarka);
            this.Controls.Add(this.cmbParentElement);
            this.Controls.Add(this.txtHizmetPolitikaNo);
            this.Controls.Add(this.txtKargoyaVerilisSuresi);
            this.Controls.Add(this.txtKargoSablonID);
            this.Controls.Add(this.brnUrunGonder);
            this.Controls.Add(this.txtUrunDil);
            this.Controls.Add(this.cmbPaketAgirligi);
            this.Controls.Add(this.cmbUrunFoto6);
            this.Controls.Add(this.cmbPaketUzunlugu);
            this.Controls.Add(this.cmbUrunFoto5);
            this.Controls.Add(this.cmbPaketGenisligi);
            this.Controls.Add(this.cmbUrunFoto4);
            this.Controls.Add(this.cmbPaketYuksekligi);
            this.Controls.Add(this.cmbUrunFoto3);
            this.Controls.Add(this.cmbUrunFoto2);
            this.Controls.Add(this.cmbStokAded);
            this.Controls.Add(this.cmbUrunFiyat);
            this.Controls.Add(this.cmbUrunAciklama);
            this.Controls.Add(this.cmbUrunFoto1);
            this.Controls.Add(this.cmbUrunAdi);
            this.Controls.Add(this.btnXmlOku);
            this.Controls.Add(this.txtTedarikciXML);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Ali Express API";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTedarikciXML;
        private System.Windows.Forms.Button btnXmlOku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbUrunAdi;
        private System.Windows.Forms.ComboBox cmbUrunAciklama;
        private System.Windows.Forms.ComboBox cmbPaketYuksekligi;
        private System.Windows.Forms.ComboBox cmbPaketGenisligi;
        private System.Windows.Forms.ComboBox cmbPaketUzunlugu;
        private System.Windows.Forms.ComboBox cmbPaketAgirligi;
        private System.Windows.Forms.TextBox txtUrunDil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbUrunFoto1;
        private System.Windows.Forms.ComboBox cmbUrunFoto2;
        private System.Windows.Forms.ComboBox cmbUrunFoto4;
        private System.Windows.Forms.ComboBox cmbUrunFoto5;
        private System.Windows.Forms.ComboBox cmbUrunFoto6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbUrunFiyat;
        private System.Windows.Forms.ComboBox cmbStokAded;
        private System.Windows.Forms.Button brnUrunGonder;
        private System.Windows.Forms.TextBox txtKargoSablonID;
        private System.Windows.Forms.TextBox txtHizmetPolitikaNo;
        private System.Windows.Forms.ComboBox cmbParentElement;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbUrunFoto3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtKargoyaVerilisSuresi;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbUrunMarka;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn HataMesaji;
        private System.Windows.Forms.DataGridViewTextBoxColumn HataKodu;
    }
}

