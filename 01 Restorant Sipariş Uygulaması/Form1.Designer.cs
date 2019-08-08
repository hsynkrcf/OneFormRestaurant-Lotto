namespace _01_Restorant_Sipariş_Uygulaması
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menüBoy = new System.Windows.Forms.GroupBox();
            this.radioTam = new System.Windows.Forms.RadioButton();
            this.radioYarim = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menü = new System.Windows.Forms.ComboBox();
            this.extras = new System.Windows.Forms.GroupBox();
            this.extrasSalad = new System.Windows.Forms.CheckBox();
            this.extrasHardal = new System.Windows.Forms.CheckBox();
            this.extrasTursu = new System.Windows.Forms.CheckBox();
            this.extrasAci = new System.Windows.Forms.CheckBox();
            this.extrasMayonez = new System.Windows.Forms.CheckBox();
            this.extrasSogan = new System.Windows.Forms.CheckBox();
            this.extrasPatates = new System.Windows.Forms.CheckBox();
            this.extrasEzme = new System.Windows.Forms.CheckBox();
            this.extrasKetcap = new System.Windows.Forms.CheckBox();
            this.extrasRanch = new System.Windows.Forms.CheckBox();
            this.drinks = new System.Windows.Forms.GroupBox();
            this.drinkTea = new System.Windows.Forms.CheckBox();
            this.drinkKola = new System.Windows.Forms.CheckBox();
            this.drinkAyran = new System.Windows.Forms.CheckBox();
            this.drinkSoda = new System.Windows.Forms.CheckBox();
            this.drinkWater = new System.Windows.Forms.CheckBox();
            this.drinkSalgam = new System.Windows.Forms.CheckBox();
            this.menüAdet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.hesapYap = new System.Windows.Forms.Button();
            this.siparisEkle = new System.Windows.Forms.Button();
            this.deleteSiparis = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.cleaner = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menüBoy.SuspendLayout();
            this.extras.SuspendLayout();
            this.drinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 421);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(801, 196);
            this.listBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "01.jpg");
            this.ımageList1.Images.SetKeyName(1, "02.png");
            this.ımageList1.Images.SetKeyName(2, "03.png");
            this.ımageList1.Images.SetKeyName(3, "04.png");
            this.ımageList1.Images.SetKeyName(4, "05.jpg");
            this.ımageList1.Images.SetKeyName(5, "06.jpg");
            // 
            // menüBoy
            // 
            this.menüBoy.Controls.Add(this.radioTam);
            this.menüBoy.Controls.Add(this.radioYarim);
            this.menüBoy.Enabled = false;
            this.menüBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menüBoy.Location = new System.Drawing.Point(305, 63);
            this.menüBoy.Name = "menüBoy";
            this.menüBoy.Size = new System.Drawing.Size(181, 87);
            this.menüBoy.TabIndex = 2;
            this.menüBoy.TabStop = false;
            this.menüBoy.Text = "Menü Boyutu";
            this.menüBoy.Leave += new System.EventHandler(this.menüBoy_Leave);
            // 
            // radioTam
            // 
            this.radioTam.AutoSize = true;
            this.radioTam.Location = new System.Drawing.Point(6, 47);
            this.radioTam.Name = "radioTam";
            this.radioTam.Size = new System.Drawing.Size(63, 22);
            this.radioTam.TabIndex = 1;
            this.radioTam.TabStop = true;
            this.radioTam.Text = "TAM";
            this.radioTam.UseVisualStyleBackColor = true;
            // 
            // radioYarim
            // 
            this.radioYarim.AutoSize = true;
            this.radioYarim.Location = new System.Drawing.Point(6, 23);
            this.radioYarim.Name = "radioYarim";
            this.radioYarim.Size = new System.Drawing.Size(79, 22);
            this.radioYarim.TabIndex = 0;
            this.radioYarim.TabStop = true;
            this.radioYarim.Text = "YARIM";
            this.radioYarim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(302, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENÜ";
            // 
            // menü
            // 
            this.menü.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menü.FormattingEnabled = true;
            this.menü.Items.AddRange(new object[] {
            "Tavuk Döner",
            "Et Döner",
            "Tombik Döner",
            "Lahmacun",
            "Adana Kebap",
            "Pirzola Menü"});
            this.menü.Location = new System.Drawing.Point(365, 21);
            this.menü.Name = "menü";
            this.menü.Size = new System.Drawing.Size(121, 24);
            this.menü.TabIndex = 3;
            this.menü.SelectedIndexChanged += new System.EventHandler(this.menü_SelectedIndexChanged);
            // 
            // extras
            // 
            this.extras.Controls.Add(this.extrasSalad);
            this.extras.Controls.Add(this.extrasHardal);
            this.extras.Controls.Add(this.extrasTursu);
            this.extras.Controls.Add(this.extrasAci);
            this.extras.Controls.Add(this.extrasMayonez);
            this.extras.Controls.Add(this.extrasSogan);
            this.extras.Controls.Add(this.extrasPatates);
            this.extras.Controls.Add(this.extrasEzme);
            this.extras.Controls.Add(this.extrasKetcap);
            this.extras.Controls.Add(this.extrasRanch);
            this.extras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.extras.Location = new System.Drawing.Point(543, 13);
            this.extras.Name = "extras";
            this.extras.Size = new System.Drawing.Size(239, 213);
            this.extras.TabIndex = 2;
            this.extras.TabStop = false;
            this.extras.Text = "Ekstralar";
            // 
            // extrasSalad
            // 
            this.extrasSalad.AutoSize = true;
            this.extrasSalad.Location = new System.Drawing.Point(133, 139);
            this.extrasSalad.Name = "extrasSalad";
            this.extrasSalad.Size = new System.Drawing.Size(77, 22);
            this.extrasSalad.TabIndex = 6;
            this.extrasSalad.Text = "Salata";
            this.extrasSalad.UseVisualStyleBackColor = true;
            // 
            // extrasHardal
            // 
            this.extrasHardal.AutoSize = true;
            this.extrasHardal.Location = new System.Drawing.Point(6, 99);
            this.extrasHardal.Name = "extrasHardal";
            this.extrasHardal.Size = new System.Drawing.Size(79, 22);
            this.extrasHardal.TabIndex = 6;
            this.extrasHardal.Text = "Hardal";
            this.extrasHardal.UseVisualStyleBackColor = true;
            // 
            // extrasTursu
            // 
            this.extrasTursu.AutoSize = true;
            this.extrasTursu.Location = new System.Drawing.Point(133, 60);
            this.extrasTursu.Name = "extrasTursu";
            this.extrasTursu.Size = new System.Drawing.Size(73, 22);
            this.extrasTursu.TabIndex = 6;
            this.extrasTursu.Text = "Turşu";
            this.extrasTursu.UseVisualStyleBackColor = true;
            // 
            // extrasAci
            // 
            this.extrasAci.AutoSize = true;
            this.extrasAci.Location = new System.Drawing.Point(6, 176);
            this.extrasAci.Name = "extrasAci";
            this.extrasAci.Size = new System.Drawing.Size(88, 22);
            this.extrasAci.TabIndex = 6;
            this.extrasAci.Text = "Acı Sos";
            this.extrasAci.UseVisualStyleBackColor = true;
            // 
            // extrasMayonez
            // 
            this.extrasMayonez.AutoSize = true;
            this.extrasMayonez.Location = new System.Drawing.Point(6, 60);
            this.extrasMayonez.Name = "extrasMayonez";
            this.extrasMayonez.Size = new System.Drawing.Size(98, 22);
            this.extrasMayonez.TabIndex = 6;
            this.extrasMayonez.Text = "Mayonez";
            this.extrasMayonez.UseVisualStyleBackColor = true;
            // 
            // extrasSogan
            // 
            this.extrasSogan.AutoSize = true;
            this.extrasSogan.Location = new System.Drawing.Point(133, 98);
            this.extrasSogan.Name = "extrasSogan";
            this.extrasSogan.Size = new System.Drawing.Size(78, 22);
            this.extrasSogan.TabIndex = 6;
            this.extrasSogan.Text = "Soğan";
            this.extrasSogan.UseVisualStyleBackColor = true;
            // 
            // extrasPatates
            // 
            this.extrasPatates.AutoSize = true;
            this.extrasPatates.Location = new System.Drawing.Point(133, 23);
            this.extrasPatates.Name = "extrasPatates";
            this.extrasPatates.Size = new System.Drawing.Size(87, 22);
            this.extrasPatates.TabIndex = 6;
            this.extrasPatates.Text = "Patates";
            this.extrasPatates.UseVisualStyleBackColor = true;
            // 
            // extrasEzme
            // 
            this.extrasEzme.AutoSize = true;
            this.extrasEzme.Location = new System.Drawing.Point(133, 176);
            this.extrasEzme.Name = "extrasEzme";
            this.extrasEzme.Size = new System.Drawing.Size(73, 22);
            this.extrasEzme.TabIndex = 6;
            this.extrasEzme.Text = "Ezme";
            this.extrasEzme.UseVisualStyleBackColor = true;
            // 
            // extrasKetcap
            // 
            this.extrasKetcap.AutoSize = true;
            this.extrasKetcap.Location = new System.Drawing.Point(6, 23);
            this.extrasKetcap.Name = "extrasKetcap";
            this.extrasKetcap.Size = new System.Drawing.Size(82, 22);
            this.extrasKetcap.TabIndex = 6;
            this.extrasKetcap.Text = "Ketçap";
            this.extrasKetcap.UseVisualStyleBackColor = true;
            // 
            // extrasRanch
            // 
            this.extrasRanch.AutoSize = true;
            this.extrasRanch.Location = new System.Drawing.Point(6, 139);
            this.extrasRanch.Name = "extrasRanch";
            this.extrasRanch.Size = new System.Drawing.Size(113, 22);
            this.extrasRanch.TabIndex = 6;
            this.extrasRanch.Text = "Ranch Sos";
            this.extrasRanch.UseVisualStyleBackColor = true;
            // 
            // drinks
            // 
            this.drinks.Controls.Add(this.drinkTea);
            this.drinks.Controls.Add(this.drinkKola);
            this.drinks.Controls.Add(this.drinkAyran);
            this.drinks.Controls.Add(this.drinkSoda);
            this.drinks.Controls.Add(this.drinkWater);
            this.drinks.Controls.Add(this.drinkSalgam);
            this.drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drinks.Location = new System.Drawing.Point(25, 249);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(253, 134);
            this.drinks.TabIndex = 2;
            this.drinks.TabStop = false;
            this.drinks.Text = "İçecekler";
            // 
            // drinkTea
            // 
            this.drinkTea.AutoSize = true;
            this.drinkTea.Location = new System.Drawing.Point(120, 63);
            this.drinkTea.Name = "drinkTea";
            this.drinkTea.Size = new System.Drawing.Size(59, 22);
            this.drinkTea.TabIndex = 7;
            this.drinkTea.Text = "Çay";
            this.drinkTea.UseVisualStyleBackColor = true;
            // 
            // drinkKola
            // 
            this.drinkKola.AutoSize = true;
            this.drinkKola.Location = new System.Drawing.Point(6, 23);
            this.drinkKola.Name = "drinkKola";
            this.drinkKola.Size = new System.Drawing.Size(64, 22);
            this.drinkKola.TabIndex = 8;
            this.drinkKola.Text = "Kola";
            this.drinkKola.UseVisualStyleBackColor = true;
            // 
            // drinkAyran
            // 
            this.drinkAyran.AutoSize = true;
            this.drinkAyran.Location = new System.Drawing.Point(6, 63);
            this.drinkAyran.Name = "drinkAyran";
            this.drinkAyran.Size = new System.Drawing.Size(72, 22);
            this.drinkAyran.TabIndex = 12;
            this.drinkAyran.Text = "Ayran";
            this.drinkAyran.UseVisualStyleBackColor = true;
            // 
            // drinkSoda
            // 
            this.drinkSoda.AutoSize = true;
            this.drinkSoda.Location = new System.Drawing.Point(6, 100);
            this.drinkSoda.Name = "drinkSoda";
            this.drinkSoda.Size = new System.Drawing.Size(69, 22);
            this.drinkSoda.TabIndex = 9;
            this.drinkSoda.Text = "Soda";
            this.drinkSoda.UseVisualStyleBackColor = true;
            // 
            // drinkWater
            // 
            this.drinkWater.AutoSize = true;
            this.drinkWater.Location = new System.Drawing.Point(120, 100);
            this.drinkWater.Name = "drinkWater";
            this.drinkWater.Size = new System.Drawing.Size(50, 22);
            this.drinkWater.TabIndex = 11;
            this.drinkWater.Text = "Su";
            this.drinkWater.UseVisualStyleBackColor = true;
            // 
            // drinkSalgam
            // 
            this.drinkSalgam.AutoSize = true;
            this.drinkSalgam.Location = new System.Drawing.Point(120, 22);
            this.drinkSalgam.Name = "drinkSalgam";
            this.drinkSalgam.Size = new System.Drawing.Size(86, 22);
            this.drinkSalgam.TabIndex = 10;
            this.drinkSalgam.Text = "Şalgam";
            this.drinkSalgam.UseVisualStyleBackColor = true;
            // 
            // menüAdet
            // 
            this.menüAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menüAdet.FormattingEnabled = true;
            this.menüAdet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.menüAdet.Location = new System.Drawing.Point(305, 202);
            this.menüAdet.Name = "menüAdet";
            this.menüAdet.Size = new System.Drawing.Size(181, 24);
            this.menüAdet.TabIndex = 3;
            this.menüAdet.SelectedIndexChanged += new System.EventHandler(this.menüAdet_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(344, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menü ADET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(333, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toplam Tutar";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(308, 310);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(166, 67);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "00.00";
            // 
            // hesapYap
            // 
            this.hesapYap.BackColor = System.Drawing.SystemColors.Highlight;
            this.hesapYap.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapYap.Location = new System.Drawing.Point(543, 269);
            this.hesapYap.Name = "hesapYap";
            this.hesapYap.Size = new System.Drawing.Size(127, 54);
            this.hesapYap.TabIndex = 4;
            this.hesapYap.Text = "Tutar Hesapla";
            this.hesapYap.UseVisualStyleBackColor = false;
            this.hesapYap.Click += new System.EventHandler(this.hesapYap_Click);
            // 
            // siparisEkle
            // 
            this.siparisEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.siparisEkle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisEkle.Location = new System.Drawing.Point(676, 269);
            this.siparisEkle.Name = "siparisEkle";
            this.siparisEkle.Size = new System.Drawing.Size(124, 54);
            this.siparisEkle.TabIndex = 4;
            this.siparisEkle.Text = "Sipariş Ekle";
            this.siparisEkle.UseVisualStyleBackColor = false;
            this.siparisEkle.Click += new System.EventHandler(this.siparisEkle_Click);
            // 
            // deleteSiparis
            // 
            this.deleteSiparis.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.deleteSiparis.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteSiparis.Location = new System.Drawing.Point(543, 329);
            this.deleteSiparis.Name = "deleteSiparis";
            this.deleteSiparis.Size = new System.Drawing.Size(127, 54);
            this.deleteSiparis.TabIndex = 4;
            this.deleteSiparis.Text = "Sipariş Sil";
            this.deleteSiparis.UseVisualStyleBackColor = false;
            this.deleteSiparis.Click += new System.EventHandler(this.deleteSiparis_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Firebrick;
            this.exit.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.Location = new System.Drawing.Point(676, 329);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(124, 54);
            this.exit.TabIndex = 4;
            this.exit.Text = "ÇIKIŞ YAP";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // cleaner
            // 
            this.cleaner.Location = new System.Drawing.Point(725, 390);
            this.cleaner.Name = "cleaner";
            this.cleaner.Size = new System.Drawing.Size(75, 26);
            this.cleaner.TabIndex = 5;
            this.cleaner.Text = "Temizle";
            this.cleaner.UseVisualStyleBackColor = true;
            this.cleaner.Click += new System.EventHandler(this.cleaner_Click);
            // 
            // btnTemp
            // 
            this.btnTemp.Enabled = false;
            this.btnTemp.Location = new System.Drawing.Point(552, 392);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(110, 23);
            this.btnTemp.TabIndex = 6;
            this.btnTemp.Text = "Silineni Geri Al";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.hesapYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 659);
            this.ControlBox = false;
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.cleaner);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.siparisEkle);
            this.Controls.Add(this.deleteSiparis);
            this.Controls.Add(this.hesapYap);
            this.Controls.Add(this.drinks);
            this.Controls.Add(this.extras);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menüAdet);
            this.Controls.Add(this.menü);
            this.Controls.Add(this.menüBoy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menüBoy.ResumeLayout(false);
            this.menüBoy.PerformLayout();
            this.extras.ResumeLayout(false);
            this.extras.PerformLayout();
            this.drinks.ResumeLayout(false);
            this.drinks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox menüBoy;
        private System.Windows.Forms.RadioButton radioTam;
        private System.Windows.Forms.RadioButton radioYarim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox menü;
        private System.Windows.Forms.GroupBox extras;
        private System.Windows.Forms.GroupBox drinks;
        private System.Windows.Forms.ComboBox menüAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button hesapYap;
        private System.Windows.Forms.Button siparisEkle;
        private System.Windows.Forms.Button deleteSiparis;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button cleaner;
        private System.Windows.Forms.CheckBox extrasSalad;
        private System.Windows.Forms.CheckBox extrasHardal;
        private System.Windows.Forms.CheckBox extrasTursu;
        private System.Windows.Forms.CheckBox extrasAci;
        private System.Windows.Forms.CheckBox extrasMayonez;
        private System.Windows.Forms.CheckBox extrasSogan;
        private System.Windows.Forms.CheckBox extrasPatates;
        private System.Windows.Forms.CheckBox extrasEzme;
        private System.Windows.Forms.CheckBox extrasKetcap;
        private System.Windows.Forms.CheckBox extrasRanch;
        private System.Windows.Forms.CheckBox drinkTea;
        private System.Windows.Forms.CheckBox drinkKola;
        private System.Windows.Forms.CheckBox drinkAyran;
        private System.Windows.Forms.CheckBox drinkSoda;
        private System.Windows.Forms.CheckBox drinkWater;
        private System.Windows.Forms.CheckBox drinkSalgam;
        private System.Windows.Forms.Button btnTemp;
    }
}

