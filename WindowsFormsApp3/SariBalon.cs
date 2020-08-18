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

namespace WindowsFormsApp3
{
    class SariBalon : Balon
    {
        public SariBalon() : base()
        {
            base.BalonRenk = "yellow1"; // balon sinifindaki yesil balon dosyasi bu sinif icin sari balona cevrildi
            base.BalonHizi = 5; // sari balon odul oldugundan hizli olmasi icin 5 olarak ayarladim
        }
    }
}
