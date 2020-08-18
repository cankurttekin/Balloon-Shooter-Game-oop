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
    class KirmiziBalon : Balon
    {
        public KirmiziBalon() : base()
        {
            base.BalonRenk = "red1"; // balon sinifindaki yesil balon dosyasi bu sinif icin kirmizi balona cevrildi
            base.BalonHizi = 1;
        }
    }
}
