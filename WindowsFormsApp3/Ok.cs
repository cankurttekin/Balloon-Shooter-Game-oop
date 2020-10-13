/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**			    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**			   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 YAZ DÖNEMİ
**	
**	 			ÖDEV NUMARASI..........: Proje 1
**				ÖĞRENCİ ADI............: Can Kurttekin
**				ÖĞRENCİ NUMARASI.......: s191210679
**              DERSİN ALINDIĞI GRUP...: 1.Öğretim A
****************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class Ok
    {
        private int oyuncuX; // okun oyuncunun bulundugu yerden...
        private int oyuncuY; // çıkması için değişkenler
        public PictureBox okCikti = new PictureBox();
        Timer tm = new Timer();

        // oyuncux oyuncuy degerlerini constructor ile aldim
        public Ok(Form form, int xEksen, int yEksen)
        {
            oyuncuX = xEksen;
            oyuncuY = yEksen;
            okCikti.BackColor = System.Drawing.Color.Transparent; // background'un seffaf yapimi
            okCikti.Image = Properties.Resources.ok; // ok.png 
            okCikti.Size = new Size(60, 15); // ok boyutu ayari
            okCikti.SizeMode = PictureBoxSizeMode.StretchImage;
            okCikti.Left = oyuncuX;
            okCikti.Top = oyuncuY;
            okCikti.BringToFront();
            form.Controls.Add(okCikti);
            tm.Interval = 1;
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();

            void tm_Tick(object sender, EventArgs e)
            {
                okCikti.Left += 15; // okun saga dogru hareketi.
                if (okCikti.Left > form.Width) // ok form penceresinin sinirlarini asip asmadigini kontrol ediyor eger astiysa oku yok ediyor.
                {
                    tm.Stop();
                    tm.Dispose();
                    okCikti.Dispose();
                }
            }
        }
    }
}
