using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02_Sayısal_Loto
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int[] sansliSayılar = new int[6];
        bool kontrol = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void SayıAl()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.KeyPress += İtem_KeyPress;
                }
            }
        }
        private void İtem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Basla() {
            TextBox txt;
            for (int i = 0; i < 24; i++)
            {
                txt = new TextBox();
                txt.Name = string.Format("txt{0}", (i + 1));
                txt.Text = (i + 1).ToString();
                txt.Width = 40;
                txt.Top = (i / 6) * 24 + 30;
                if (i / 6 == 0)
                {
                    txt.Left = i * 40 + 80;
                }
                else
                {
                    if (i < 12)
                    {
                        txt.Left = (i - 6) * 40 + 80;
                    }
                    else if (i < 18)
                    {
                        txt.Left = (i - 12) * 40 + 80;
                    }
                    else if (i < 24)
                    {
                        txt.Left = (i - 18) * 40 + 80;
                    }
                }
                this.Controls.Add(txt);
            }
            this.Width = this.Controls.Find("txt24", false)[0].Left + 70;
        }   //4 KOLON 6'LI OLARAK 24 TANE TEXTBOX YAPTIRIYORUM YÜKLENİRKEN
        private void RakamÜret()  //Kullanıcı kaç hafta girerse o kadar  sanslı rakam üretir..
        {
            while (listBox1.Items.Count < int.Parse(textBox1.Text))
            {
                string winner = string.Empty;
                for (int i = 0; i < 6; i++)
                {
                    sansliSayılar[i] = rnd.Next(1, 50);
                    for (int j = 0; j < i; j++)
                    {
                        if (sansliSayılar[j] == sansliSayılar[i])                // lotoda aynı sayıdan 2 kere olmaz o yüzden kontrol ediyorum eğeer varsa tekrardan random çalışıyor.
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        i--;
                        kontrol = false;
                    }
                }
                for (int i = 0; i < 6; i++)   //Sonunda tire olmasın diye yaptım.
                {
                    if (i == sansliSayılar.Length - 1)   
                    {
                        winner += sansliSayılar[i];
                    }
                    else
                    {
                        winner += sansliSayılar[i] + "-";
                    }
                }
                listBox1.Items.Add(winner);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Basla();
            SayıAl();
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text != "" && int.Parse(textBox1.Text) <= 52 && int.Parse(textBox1.Text) >= 10) // loto kuralları
            {
                RakamÜret();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("ÇEKİLİŞ HAFTASI EN AZ 10, EN FAZLA 52 OLMALIDIR!!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)   //TEXTBOX'A SADECE SAYI GİRMESİNİ İSTİYORUM!!
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

