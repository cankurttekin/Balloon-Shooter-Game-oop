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
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class Balon
    {
        private static readonly Random rnd = new Random();
        private int balonX;
        private int balonY;
        private int balonHiz = 1;
        public PictureBox yeniBalon;
        Timer balonTimer = new Timer();
        private string balonrenk = "green1";

        public string BalonRenk
        {
            set { balonrenk = value; }
        }

        public int BalonHizi
        {
            set { balonHiz = value; }
        }

        public Control BalonOlustur(int x, int y, Form form)
        {
            balonX = x;
            balonY = y;
            yeniBalon = new PictureBox();
            yeniBalon.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(balonrenk);
            yeniBalon.Location = new Point(rnd.Next(120, form.Width - 70), rnd.Next(0, 400) * -1); // ekranin gozukmeyen ust kismindan dusuyor gibi olmasi icin y eksenini 0-400 araliginde olusturup - ile carptim.
            yeniBalon.Size = new Size(balonX, balonY);
            yeniBalon.SizeMode = PictureBoxSizeMode.StretchImage;
            yeniBalon.Visible = true;
            balonTimer.Tick += balonOlusturTimer_Tick;
            balonTimer.Interval = 1;
            balonTimer.Start();

            void balonOlusturTimer_Tick(object sender, EventArgs e)
            {
                yeniBalon.Top += balonHiz; // balonun hizi
                // oyun alaninin sinirlarini asti ise timer'i ve picturebox'i yok ediyor.
                if (yeniBalon.Top > form.Height)
                {
                    balonTimer.Stop();
                    balonTimer.Dispose();
                    yeniBalon.Dispose();
                }
            }
            return yeniBalon;
        }
    }
}