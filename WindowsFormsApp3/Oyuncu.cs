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

namespace WindowsFormsApp3
{
    class Oyuncu
    {
        private string guncelOyuncu;
        private string oncekiOyuncu;
        private int guncelOyuncuPuan;
        private int oncekiOyuncuPuan;

        public string GuncelOyuncu { get => guncelOyuncu; set => guncelOyuncu = value; }
        public string OncekiOyuncu { get => oncekiOyuncu; set => oncekiOyuncu = value; }
        public int GuncelOyuncuPuan { get => guncelOyuncuPuan; set => guncelOyuncuPuan = value; }
        public int OncekiOyuncuPuan { get => oncekiOyuncuPuan; set => oncekiOyuncuPuan = value; }
    }
}
