using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _01_Restorant_Sipariş_Uygulaması
{
    public partial class Form1 : Form
    {
         object temp;
         double exAndDrunk = 0;
         string menüSecim = string.Empty;
         string menüAdedi = string.Empty;
         string porsiyon = string.Empty;
         double menüFiyat = 0;
         double menüFiyat2 = 0;
         public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      //ÇIKIŞ BUTONU

        private void cleaner_Click(object sender, EventArgs e)
        {
            DialogResult bakSiliyorum = MessageBox.Show("Tümünü Silmek İstiyor musunuz? GERİ ALINAMAZ!!","BAK SİLİYORUM",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (bakSiliyorum == DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
        }         //SİPARİŞ LİSTESİNİ TEMİZLE

        private void deleteSiparis_Click(object sender, EventArgs e)
        {
            temp = listBox1.SelectedItem;
            listBox1.Items.Remove(listBox1.SelectedItem);
            btnTemp.Enabled = true;
        }           //HATALI SİPARİŞ İÇİN SİLMEK

        private void menü_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control kontrol in this.extras.Controls)
            {
                ((CheckBox) kontrol).Checked = false;
            }
            foreach (Control kontrol in this.drinks.Controls)
            {
                ((CheckBox)kontrol).Checked = false;
            }
            switch (menü.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = ımageList1.Images[0];
                    menüBoy.Enabled = true;
                    menüSecim = "Tavuk Döner";
                    menüFiyat = 6;
                    lblFiyat.Text = "00.00";
                    break;
                case 1:
                    pictureBox1.Image = ımageList1.Images[1];
                    menüBoy.Enabled = true;
                    menüSecim = "Et Döner";
                    menüFiyat = 11;
                    lblFiyat.Text = "00.00";
                    break;
                case 2:
                    pictureBox1.Image = ımageList1.Images[2];
                    menüBoy.Enabled = false;
                    menüSecim = "Tombik Döner";
                    menüFiyat = 25;
                    lblFiyat.Text = "00.00";
                    break;
                case 3:
                    pictureBox1.Image = ımageList1.Images[3];
                    menüBoy.Enabled = false;
                    menüSecim = "Lahmacun";
                    menüFiyat = 8;
                    lblFiyat.Text = "00.00";
                    break;
                case 4:
                    pictureBox1.Image = ımageList1.Images[4];
                    menüBoy.Enabled = false;
                    menüFiyat = 18;
                    lblFiyat.Text = "00.00";
                    menüSecim = "Adana Kebap";
                    break;
                case 5:
                    pictureBox1.Image = ımageList1.Images[5];
                    menüBoy.Enabled = false;
                    lblFiyat.Text = "00.00";
                    menüSecim = "Pirzola Menü";
                    menüFiyat = 45;
                    break;
            }
        }   //MENÜ SEÇİM
   
        private void btnTemp_Click(object sender, EventArgs e)
        {
                listBox1.Items.Add(temp);
                btnTemp.Enabled = false;
        }      //HATALI SİLME İÇİN TEMP

        void Hesap()
        {
                menüFiyat2 = 0;
                exAndDrunk = 0;

                foreach (Control kontrol in this.extras.Controls)
                {
                    if (kontrol is CheckBox)
                    {
                        if (((CheckBox)kontrol).Checked == true)
                        {
                            exAndDrunk += 2.50;
                        }
                    }
                }
                foreach (Control kontrol in this.drinks.Controls)
                {
                    if (kontrol is CheckBox)
                    {
                        if (((CheckBox)kontrol).Checked == true)
                        {
                            exAndDrunk += 2.50;
                        }
                    }
                }
                menüFiyat2 = menüFiyat * double.Parse(menüAdedi);
                menüFiyat2 += exAndDrunk * double.Parse(menüAdedi);
                lblFiyat.Text = string.Format("{0:c}", menüFiyat2);            
        }
        private void hesapYap_Click(object sender, EventArgs e)
        {
           Hesap();
        }
        private void siparisEkle_Click(object sender, EventArgs e)         //Listbox sipariş ekleme
        {
            if (menü.SelectedItem == null)
            {
                MessageBox.Show("LÜTFEN EKLEMEDEN ÖNCE MENÜ VE ADET BİLGİSİNİ GİRİNİZ!!");
            }
            else
            {
            string neExtras = string.Empty;
            string drinks = string.Empty;
            List<string> extrasTut = new List<string>();
            List<string> drinksTut = new List<string>();
            foreach (Control kontrol in this.extras.Controls)
            {
                if (kontrol is CheckBox)  
                {
                    if (((CheckBox)kontrol).Checked == true)
                    {
                       extrasTut.Add((((CheckBox)kontrol).Text));
                       neExtras = string.Join(" ", extrasTut.ToArray());
                       exAndDrunk++;
                    }
                }
            }   // Extraları Bir String'e koyuyorum
            foreach (Control kontrol in this.drinks.Controls)
            {
                if (kontrol is CheckBox)
                {
                    if (((CheckBox)kontrol).Checked == true)
                    {
                        drinksTut.Add((((CheckBox)kontrol).Text));
                        drinks = string.Join(" ", drinksTut.ToArray());
                        exAndDrunk++;
                    }
                }
            }   // İçecekleri Bir String'e koyuyorum
            string son = string.Format("Menü: {0} || Boyut: {1} || Ekstra: {2} || İçecek: {3} || Adet: {4} || Fiyat: {5:c} ", menüSecim, porsiyon, neExtras, drinks, menüAdedi, menüFiyat2);
            listBox1.Items.Add(son);
            porsiyon = "";
            }
            menü.SelectedItem = null;
            Hesap();
        }

        private void menüAdet_SelectedIndexChanged(object sender, EventArgs e)
        {
            menüAdedi = menüAdet.Text;
        }       //Menü adet seçim

        private void menüBoy_Leave(object sender, EventArgs e)
        {
            if (radioYarim.Checked == true)
            {
                porsiyon = "Yarım";
            }
            else if (radioTam.Checked == true)
            {
                porsiyon = "Tam";
                menüFiyat *= 2;
            }
            radioTam.Checked = false;
            radioYarim.Checked = false;
        }            //Menü boy seçim
    }
}
