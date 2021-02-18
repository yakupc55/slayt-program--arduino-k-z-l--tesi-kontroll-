using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_projesi
{
    class IcerikIslemleri
    {
        private Sayfalar.Cizgiler _GelenCizgi;

        public Sayfalar.Cizgiler GelenCizgi
        {
            get { return _GelenCizgi; }
            set { _GelenCizgi = value; }
        }

        private Sayfalar.Yazilar _GelenYazi;

        public Sayfalar.Yazilar GelenYazi
        {
            get { return _GelenYazi; }
            set { _GelenYazi = value; }
        }

        private Sayfalar _Sayfa;
        public Sayfalar Sayfa
        {
            get { return _Sayfa; }
            set { _Sayfa = value; }
        }
        private Bitmap _GelenResim;

        public Bitmap GelenResim
        {
            get { return _GelenResim; }
            set { _GelenResim = value; }
        }

        public Bitmap AnaYapiResimOlustur(Bitmap resim)
        {
            Bitmap YapiResmi = resim;
            Graphics gh = Graphics.FromImage(YapiResmi);
            gh.Clear(Color.Azure);
            Font yazi = new Font("Georgia", 18, FontStyle.Italic);
            Brush firca = new SolidBrush(Color.Black);
            gh.DrawString("Sayfa \n Yapısı", yazi, firca, new Point(0, 0));
            return YapiResmi;
        }// fonksiyon sonu
        public void YaziResmiOlustur(int Yaziid)
        {
            Yaziid--;
            Bitmap YapiResmi = GelenResim;
            Graphics gh = Graphics.FromImage(YapiResmi);
            gh.Clear(Color.Azure);
            Font yazifontu = Sayfa.YazilarListesi[Yaziid].YaziFont;
            Color yaziRengi = Sayfa.YazilarListesi[Yaziid].YaziRengi;
            Brush firca = new SolidBrush(yaziRengi);
            String yazigetir = Sayfa.YazilarListesi[Yaziid].YaziMetni;
            String grafikyazisi = (yazigetir.Length < 10) ? yazigetir : yazigetir.Substring(0, 10);
            int xkonum = 0;
            int ykonum = 0;
            gh.DrawString(grafikyazisi, yazifontu, firca, new Point(xkonum, ykonum));
            GelenResim = YapiResmi;
        }
        /// <summary>
        /// Çizginin içerik listesine eklenmesi için onu temsil eden bir
        /// resmin olması gerekmektedir işte bu durumlarda çalışacak bir yapı
        /// olan bu fonksiyon çizgiye ait temsili bir resim oluşturmaktadır.
        /// </summary>
        /// <param name="Sayfaid"></param>
        /// <param name="Cizgiid"></param>
        public void CizgiResmiOlustur(int Cizgiid)
        {
            Cizgiid--; // listeden bir fazla döndüğü için eksiltme yaptık
            Bitmap YapiResmi = GelenResim;
            Graphics gh = Graphics.FromImage(YapiResmi);
            gh.Clear(Color.Azure); // arka plan rengi verdik
            Color CizgiRengi =Sayfa.CizgilerListesi[Cizgiid].KalemRengi;
            int CizgiBoyutu = Sayfa.CizgilerListesi[Cizgiid].KalemBoyutu;
            Pen kalem = new Pen(CizgiRengi, CizgiBoyutu);
            int x1konum = 0;
            int x2konum = 10;
            int y1konum = 10;
            int y2konum = 10;
            gh.DrawLine(kalem, new Point(x1konum, y1konum), new Point(x2konum, y2konum));
            Font yazifontu = new Font("Times New Roman", 18, FontStyle.Italic);
            Color yaziRengi = CizgiRengi;
            Brush firca = new SolidBrush(yaziRengi);
            String Yazi = "Cizgi =" + (Cizgiid + 1).ToString();
            gh.DrawString(Yazi, yazifontu, firca, new Point(10, 30));
            GelenResim = YapiResmi;
        }// fonksiyon sonu
        public Sayfalar.Yazilar YaziNitelikleriDegistir(Sayfalar.Yazilar Yazi, int x,int y,String yazi,Font font,Color renk)
        {
            GelenYazi = Yazi;
            GelenYazi.YaziXKonum = x;
            GelenYazi.YaziYKonum = y;
            GelenYazi.YaziMetni = yazi;
            GelenYazi.YaziFont = font;
            GelenYazi.YaziRengi = renk;
            return GelenYazi;
        }
        public Sayfalar.Cizgiler CizgiNitelikleriDegistir(Sayfalar.Cizgiler Cizgi, int x1, int x2,int y1,int y2, int boyut,Color renk)
        {
            GelenCizgi = Cizgi;
            GelenCizgi.CizgiX1 = x1;
            GelenCizgi.CizgiX2 = x2;
            GelenCizgi.CizgiY1 = y1;
            GelenCizgi.CizgiY2 = y2;
            GelenCizgi.KalemBoyutu = boyut;
            GelenCizgi.KalemRengi = renk;
            return GelenCizgi;
        }
        
        }// class sonu

}
