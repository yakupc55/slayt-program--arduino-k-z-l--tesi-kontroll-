using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_projesi
{
    
    class Cizim
    {
       private Sayfalar Sayfa;
       private Bitmap Anaresim = new Bitmap(648, 476);
        public Cizim(Sayfalar sayfa)
        {
            Sayfa = sayfa;
        }
        public Cizim()
        {

        }
        private void ResimOlustur()
        {
            Graphics gr = Graphics.FromImage(Anaresim);
            Color Arkaplan = Sayfa.anaYapi.ArkaPlan;
            gr.Clear(Arkaplan);
            for(int i=0; i < Sayfa.IcerikSayisi; i++)
            {
                int tipi = Sayfa.IceriklerListesi[i].Tipi;
                int list = Sayfa.IceriklerListesi[i].ListeId-1;
                switch (tipi)
                {
                    
                    case 0: Yaziyi_Ekle(gr,list); break;
                    case 1: Cizgiyi_Ekle(gr,list); break;
                }// switch sonu
            }// for sonu
        }// fonksiyon sonu
        public void SayfaDegistir(Sayfalar sayfa)
        {
            Sayfa = sayfa;
        }
        private void Yaziyi_Ekle(Graphics gr,int id)
        {
            
            Font yazifontu = Sayfa.YazilarListesi[id].YaziFont;
            Color yaziRengi = Sayfa.YazilarListesi[id].YaziRengi;
            Brush firca = new SolidBrush(yaziRengi);
            String yazi = Sayfa.YazilarListesi[id].YaziMetni;
            int xkonum = Sayfa.YazilarListesi[id].YaziXKonum;
            int ykonum = Sayfa.YazilarListesi[id].YaziYKonum;
            gr.DrawString(yazi, yazifontu, firca, new Point(xkonum, ykonum));
        }
        private void Cizgiyi_Ekle(Graphics gr,int id)
        {
            Color CizgiRengi = Sayfa.CizgilerListesi[id].KalemRengi;
            int CizgiBoyutu = Sayfa.CizgilerListesi[id].KalemBoyutu;
            Pen kalem = new Pen(CizgiRengi, CizgiBoyutu);
            int x1konum = Sayfa.CizgilerListesi[id].CizgiX1;
            int x2konum = Sayfa.CizgilerListesi[id].CizgiX2;
            int y1konum = Sayfa.CizgilerListesi[id].CizgiY1;
            int y2konum = Sayfa.CizgilerListesi[id].CizgiY2;
            gr.DrawLine(kalem, new Point(x1konum, y1konum), new Point(x2konum, y2konum));
        }
        public Bitmap ResimCek()
        {
            return Anaresim;
        }
        public void ResimIsle()
        {
            ResimOlustur();
        }
    }
}
