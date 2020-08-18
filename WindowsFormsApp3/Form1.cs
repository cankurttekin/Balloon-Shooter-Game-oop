/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**			    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**			   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 YAZ DÖNEMİ
**	
**	 			ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Can Kurttekin
**				ÖĞRENCİ NUMARASI.......: s191210679
**              DERSİN ALINDIĞI GRUP...: 1.Öğretim A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int balonAdetYesil;
        private int balonAdetSari;
        private int balonAdetKirmizi;
        private int level;
        private bool seviyeBittiMi;
        public string balonDosyasi;
        public List<PictureBox> balons = new List<PictureBox>();
        public List<Balon> olusanBalonlar = new List<Balon>();
        public List<Ok> atilanOklar = new List<Ok>();
        Oyuncu OyuncuObj = new Oyuncu();
        bool yPozitif, yNegatif, oyunBittiMi;
        int puan;
        int oyuncuHiz = 12; // oyuncu hizina mudahale edilmek istenirse diye degisken
        int balonHiz;
        int okSayisi = 0;
        PictureBox oyuncu;

        public Form1()
        {
            InitializeComponent();
            this.textBox1.Enter += new EventHandler(textBox1_Enter);
            this.textBox1.Leave += new EventHandler(textBox1_Leave);
            textBox1_SetText();

            // okcu combo box ayarlari
            Dictionary<string, string> okcusec = new Dictionary<string, string>();
            okcusec.Add("okcumavi1", "Mavi Okçu");
            okcusec.Add("okcukirmizi1", "Kırmızı Okçu");
            okcusec.Add("okcuyesil1", "Yeşil Okçu");
            okcuComboBox.DataSource = new BindingSource(okcusec, null);
            okcuComboBox.DisplayMember = "Value";
            okcuComboBox.ValueMember = "Key";

            // balon combo box ayarlari
            Dictionary<string, string> balonsec = new Dictionary<string, string>();
            balonsec.Add("green1", "Yeşil Balon");
            balonsec.Add("mavi", "Mavi Balon");
            balonsec.Add("mor", "Mor Balon");
            balonComboBox.DataSource = new BindingSource(balonsec, null);
            balonComboBox.DisplayMember = "Value";
            balonComboBox.ValueMember = "Key";
        }

        private void timerOyun(object sender, EventArgs e)
        {
            OyuncuObj.GuncelOyuncuPuan = puan;
            skorGoster.Text = OyuncuObj.GuncelOyuncuPuan.ToString();
            skorGoster.SendToBack();
            foreach (PictureBox i in balons)
            {
                if (i.Top > this.Height && (string)i.Tag != "vuruldu") // vurulmamis balon yere dusunce oyunu bitirmek icin kontrol
                {
                    oyunBitir();
                    break;
                }
            }

            oyunAyar();
            seviyeGosterge.Text = "SEVİYE: " + level.ToString();
            // oyuncu hareket ayarlari, form penceresinin sinirlari icinde haraket etmesi icin kontrol
            if (yPozitif == true && oyuncu.Top > 0)
            {
                oyuncu.Top -= oyuncuHiz;
            }
            if (yNegatif == true && oyuncu.Top < this.Height - 170)
            {
                oyuncu.Top += oyuncuHiz;
            }
            CarpismaKontrol(); // her tick ile cagirarak carpisma kontrolu yapilmasi icin timer icerisinden cagiriliyor.
        }

        private void bas(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                yNegatif = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                yPozitif = true;
            }
        }

        private void cek(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                yNegatif = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                yPozitif = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (level == 3 && okSayisi > 0) // seviye 3 icin 50 ok hakki oldugundan burada her Space'e basisimizda ates etmek icin seviye 3 mu ve okumuz var mi kontrolu yapiliyor.
                {
                    okSayisi--;
                    okgosterge.Text = "OK: " + okSayisi.ToString();
                    ates();
                }
                if (level < 3) // eger seviye 3 degilse kac ok oldugunu kontrol etmeye gerek olmadan ates fonksiyonunu cagirabiliriz.
                {
                    ates();
                }
            }
            if (e.KeyCode == Keys.Enter && oyunBittiMi == true) // oyunbitti ise ve oyun bitti ekraninda Enter'e basarsak baslangic panelinin tekrar gozukmesini sagliyor.
            {
                skorGoster.SendToBack(); // oyun bitti yazan ekrani geriye atiyoruz ki panel gozuksun
                panel1.Enabled = true;
                panel1.Visible = true;
            }
        }

        private void resetOyun()
        {
            // oyun tekrar oynanacagi zaman gerekli degiskenleri ve objeleri sifirlamak icin reset fonksiyonu
            oyunSeviye.Stop();
            foreach (var x in balons)
            {
                x.Dispose();
            }
            balons.Clear();
            timer1.Start();
            level = 1;
            puan = 0;
            balonAdetYesil = 0;
            balonAdetSari = 0;
            balonAdetKirmizi = 0;
            skorGoster.Text = puan.ToString();
            seviyeBittiMi = true;
            oyunBittiMi = false;
            olusanBalonlar.Clear();
            atilanOklar.Clear();
        }

        private void oyunAyar()
        {
            if (level <= 3 && seviyeBittiMi == true) // bir sonraki seviye icin seviye 3'ten dusuk ve seviyeyi de tamamlamis miyiz kontrolu.
            {
                switch (level)
                {
                    case 1: // seviye 1
                        balonAdetYesil = 20;
                        oyunSeviye.Interval = 2500; // balonlari ureten timer'in tick hizi
                        balonHiz = 1; // balonun hareket hizi
                        oyunSeviye.Start();
                        seviyeBittiMi = false;
                        break;
                    case 2: // seviye 2
                        balonAdetYesil = 20; // seviye 2 ve 3 icin yesil balon sayisi belirtilmediginden her seviyede 20 olarak aldim
                        balonAdetSari = balonAdetYesil * 30 / 100;
                        balonAdetKirmizi = 0;
                        oyunSeviye.Interval = 2300; // daha zor olması icin daha hizli uretiliyor balonlar
                        balonHiz = 2;
                        oyunSeviye.Start();
                        seviyeBittiMi = false;
                        break;
                    case 3: // seviye 3
                        okSayisi = 50;
                        okgosterge.Text = "OK: " + okSayisi.ToString();
                        balonAdetYesil = 20;
                        balonAdetSari = balonAdetYesil * 20 / 100;
                        balonAdetKirmizi = balonAdetYesil * 20 / 100;
                        oyunSeviye.Interval = 2100;
                        balonHiz = 3;
                        oyunSeviye.Start();
                        seviyeBittiMi = false;
                        break;
                }
            }
        }

        private void oyunBitir()
        {
            oyunBittiMi = true;
            timer1.Stop();
            oyuncu.Dispose(); //yeni oyun diyince eski okcu ekranda kalmasin diye siliyorum
            OyuncuObj.OncekiOyuncu = OyuncuObj.GuncelOyuncu;
            OyuncuObj.OncekiOyuncuPuan = OyuncuObj.GuncelOyuncuPuan;
            oncekiOyuncuLabel.Text = "ÖNCEKİ OYUNCU: " + OyuncuObj.OncekiOyuncu + " " + "PUAN: " + OyuncuObj.OncekiOyuncuPuan.ToString();
            oncekiOyuncuButton.Enabled = true;
            skorGoster.Text += Environment.NewLine + "Oyun bitti" + Environment.NewLine + "Devam etmek için ENTER'e bas";
            skorGoster.BringToFront();
        }

        private void ates()
        {
            int oyuncuX = oyuncu.Left + (oyuncu.Width / 2); // okcu gorsellerine uygun, okun yayin ucundan
            int oyuncuY = oyuncu.Top + (oyuncu.Height / 2) - 4; // cikiyor gibi gozukmesi için konum ayari
            Ok okAtes = new Ok(this, oyuncuX, oyuncuY, 1);
            okAtes.okCikti.Tag = "ok"; // carpisma kontrol ederken ok oldugunu anlamak icin tag eklendi
            atilanOklar.Add(okAtes);
        }

        public void CarpismaKontrol()
        {
            foreach (Control balonlar in this.Controls)
            {
                foreach (Control oklar in this.Controls)
                {
                    if (balonlar is PictureBox && oklar is PictureBox && (string)oklar.Tag == "ok")// balonlar ve oklar picturebox mi ve bu picturebox "ok" mu kontrolu
                    {
                        switch ((string)balonlar.Tag)
                        {
                            case "yesilbalon": // eger yesilbalon tag'i olan bir picturebox ile ok carpisti ise puan verip balonu ve oku kaldiriyor
                                if (oklar.Bounds.IntersectsWith(balonlar.Bounds))
                                {
                                    puan += 5;
                                    Controls.Remove(oklar);
                                    Controls.Remove(balonlar);
                                    balonlar.Tag = "vuruldu";
                                }
                                break;
                            case "kirmizibalon": // eger kirmizibalon tag'i olan bir picturebox ile ok carpisti ise puani sifirliyor, balonu ve oku kaldiriyor.
                                if (oklar.Bounds.IntersectsWith(balonlar.Bounds))
                                {
                                    puan = 0;
                                    Controls.Remove(oklar);
                                    Controls.Remove(balonlar);
                                    balonlar.Tag = "vuruldu";
                                }
                                break;
                            case "saribalon": // eger saribalon tag'i olan bir picturebox ile ok carpisti ise 15 puan veriyor, balonu ve oku kaldiriyor.
                                if (oklar.Bounds.IntersectsWith(balonlar.Bounds))
                                {
                                    puan += 15;
                                    Controls.Remove(oklar);
                                    Controls.Remove(balonlar);
                                    balonlar.Tag = "vuruldu";
                                }
                                break;
                        }
                    }
                }
            }
        }

        protected void textBox1_SetText()
        {
            this.textBox1.Text = "Oyuncu Adı Girin...";
            textBox1.ForeColor = Color.Gray;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.Black)
            {
                return;
            }
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
                textBox1_SetText();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                yeniOyunButton.PerformClick();
                textBox1.Text = "";
            }
        }

        private void yeniOyunButton_Click(object sender, EventArgs e)
        {
            // yeni oyuncu butonuna basilinca oyun resetleniyor, combobox ile secilen sekilde yeni bir okcu olusturuluyor ve panel gizleniyor.
            resetOyun();
            Okcu karakter = new Okcu(this, ((KeyValuePair<string, string>)okcuComboBox.SelectedItem).Key);
            oyuncu = karakter.okcuKarakter;
            OyuncuObj.GuncelOyuncu = textBox1.Text;
            label1.Text = "OYUNCU: " + OyuncuObj.GuncelOyuncu;
            panel1.Enabled = false;
            panel1.Visible = false;
        }

        private void oncekiOyuncuButton_Click(object sender, EventArgs e)
        {
            // onceki oyuncu butonuna basilinca onceki oyuncunun adi ve parantez icerisinde puani sol ust koseye yaziliyor.
            resetOyun();
            Okcu karakter = new Okcu(this, ((KeyValuePair<string, string>)okcuComboBox.SelectedItem).Key);
            oyuncu = karakter.okcuKarakter;
            label1.Text = "OYUNCU: " + OyuncuObj.OncekiOyuncu + "(" + OyuncuObj.OncekiOyuncuPuan.ToString() + ")";
            panel1.Enabled = false;
            panel1.Visible = false;
        }

        private void renkButton_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            renkOnizlemePb.BackColor = cdlg.Color;
            this.BackColor = cdlg.Color;
        }

        private void ayarlarButton_Click(object sender, EventArgs e)
        {
            groupBoxAyarlar.Visible = !(groupBoxAyarlar.Visible); // her tiklanildiginda acilip kapanmasi icin onceki boolean degerinin degili alindi.
        }

        private void oyunSeviye_Tick(object sender, EventArgs e)
        {
            if (balonAdetYesil > 0)
            {
                Balon yslbln = new Balon();
                yslbln.BalonHizi = balonHiz;
                yslbln.BalonRenk = ((KeyValuePair<string, string>)balonComboBox.SelectedItem).Key;
                var x = yslbln.BalonOlustur(50, 90, this);
                x.Tag = "yesilbalon";
                Controls.Add(x);
                balons.Add(yslbln.yeniBalon);
                balonAdetYesil--;
                olusanBalonlar.Add(yslbln);
            }
            if (balonAdetSari > 0)
            {
                Balon srbln = new SariBalon();
                var y = srbln.BalonOlustur(50, 90, this);
                y.Tag = "saribalon";
                Controls.Add(y);
                balonAdetSari--;
                olusanBalonlar.Add(srbln);
            }
            if (balonAdetKirmizi > 0)
            {
                Balon krmzbln = new KirmiziBalon();
                krmzbln.BalonHizi = balonHiz;
                var z = krmzbln.BalonOlustur(50, 90, this);
                z.Tag = "kirmizibalon";
                Controls.Add(z);
                balonAdetKirmizi--;
                olusanBalonlar.Add(krmzbln);
            }

            switch (olusanBalonlar.Count)
            {
                case 20:
                    oyunSeviye.Stop();
                    seviyeBittiMi = true;
                    level++;
                    break;
                case 46: // seviye 2: 20yesil 20sari. yesil balon hep sabit oldugu icin % hesabi ile kontrol etmeyi gerek gormedim
                    oyunSeviye.Stop();
                    seviyeBittiMi = true;
                    level++;
                    break;
                case 74: // seviye 3: 20yesil 4sari 4kirmizi
                    oyunSeviye.Stop();
                    oyunBitir();
                    seviyeBittiMi = true;
                    level++;
                    break;
            }
        }
    }
}
