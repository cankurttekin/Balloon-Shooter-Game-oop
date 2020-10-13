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
    class Okcu
    {
        private int oyuncuX = 95;
        private int oyuncuY = 130;
        public PictureBox okcuKarakter = new PictureBox();

        public Okcu(Form form, string okcuresim)
        {
            okcuKarakter.BackColor = System.Drawing.Color.Transparent;
            okcuKarakter.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(okcuresim);
            okcuKarakter.Size = new Size(oyuncuX, oyuncuY);
            okcuKarakter.SizeMode = PictureBoxSizeMode.StretchImage;
            okcuKarakter.Left = 11;
            okcuKarakter.Top = 310;
            form.Controls.Add(okcuKarakter);
        }
    }
}
