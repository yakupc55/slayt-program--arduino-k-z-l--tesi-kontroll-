using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Editor_projesi
{
    [Serializable]
    class Sayfalar
    {

        public AnaYapi anaYapi;
        public Yazilar yazilar;
        public Cizgiler cizgiler;
        public Icerikler icerikler;
        public List<Icerikler> IceriklerListesi;
        public List<Yazilar> YazilarListesi;
        public List<Cizgiler> CizgilerListesi;
   
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
       public Sayfalar()
        {
            anaYapi = new AnaYapi();
            yazilar = new Yazilar();
            cizgiler = new Cizgiler();
            icerikler = new Icerikler();
            IceriklerListesi = new List<Icerikler>();
            YazilarListesi = new List<Yazilar>();
            CizgilerListesi = new List<Cizgiler>();
            Yazisayisi = 0;
            IcerikSayisi = 0;
            CizgiSayisi = 0;
            
        }     
        private int _IcerikSayisi;
        public int IcerikSayisi
        {
            get { return _IcerikSayisi; }
            set { _IcerikSayisi = value; }
        }
        private int _YaziSayisi;

        public int Yazisayisi
        {
            get { return _YaziSayisi; }
            set { _YaziSayisi = value; }
        }
        private int _CizgiSayisi;

        public int CizgiSayisi
        {
            get { return _CizgiSayisi; }
            set { _CizgiSayisi = value; }
        }
        [Serializable]
        public class AnaYapi
        {
            private Color _ArkaPlan;
            public Color ArkaPlan
            {
                get { return _ArkaPlan; }
                set { _ArkaPlan = value; }
            }
        } // class sonu
        [Serializable]
        public class Yazilar { 
            private Color _YaziRengi;

             public Color YaziRengi
             {
            get { return _YaziRengi; }
            set { _YaziRengi = value; }
            }

            
            private Font _YaziFont;

            public Font YaziFont
            {
                get { return _YaziFont; }
                set { _YaziFont = value; }
            }

            private int _YaziXKonum;

                public int YaziXKonum
                {
                    get { return _YaziXKonum; }
                    set { _YaziXKonum = value; }
                }
                private int _YaziYKonum;

                public int YaziYKonum
                {
                    get { return _YaziYKonum; }
                    set { _YaziYKonum = value; }
                }
                private String _YaziMetni;

                public String YaziMetni
                {
                    get { return _YaziMetni; }
                    set { _YaziMetni = value; }
                }
            } // class sonu
        [Serializable]
        public class Cizgiler
        {
            private int _KalemBoyutu;
            public int KalemBoyutu
            {
                get { return _KalemBoyutu; }
                set { _KalemBoyutu = value; }
            }
            private Color _KalemRengi;

            public Color KalemRengi
            {
                get { return _KalemRengi; }
                set { _KalemRengi = value; }
            }

            private int _CizgiX1;

            public int CizgiX1
            {
                get { return _CizgiX1; }
                set { _CizgiX1 = value; }
            }
            private int _CizgiX2;

            public int CizgiX2
            {
                get { return _CizgiX2; }
                set { _CizgiX2 = value; }
            }
            private int _CizgiY1;

            public int CizgiY1
            {
                get { return _CizgiY1; }
                set { _CizgiY1 = value; }
            }
            private int _CizgiY2;

            public int CizgiY2
            {
                get { return _CizgiY2; }
                set { _CizgiY2 = value; }
            }

        }//class sonu
        [Serializable]
        public class Icerikler
        {
            public Icerikler()
            {

            }
            public Icerikler(int tip,int ListedId)
            {
                _Tipi = tip;
                _ListeId = ListedId;

            }
            private int _Tipi;

            public int Tipi
            {
                get { return _Tipi; }
                set { _Tipi = value; }
            }
            private int _ListeId;

            public int ListeId
            {
                get { return _ListeId; }
                set { _ListeId = value; }
            }
        }//  class sonu
        public void listeye_ekle()
        {
            Yazisayisi++;
            IcerikSayisi++;
            IceriklerListesi.Add(new Icerikler(0,Yazisayisi));
        }// fonksiyon sonu
        public void IlkYaziOlustur()
        {
            Yazilar yazilar2 = new Yazilar();
           yazilar2.YaziFont= new Font(FontFamily.GenericSansSerif,
             12.0F, FontStyle.Bold);
            yazilar2.YaziRengi = Color.FromArgb(0, 0, 0);
            yazilar2.YaziMetni = "Yazi = "+Yazisayisi.ToString();
            yazilar2.YaziXKonum = 0;
            yazilar2.YaziYKonum = 0;
            YazilarListesi.Add(yazilar2);
        } 
        /// <summary>
        /// Bu kısım bir çizgi içeriğinin olduğunu içerikler
        /// kısmına ekleyen kısımdır
        /// </summary>
        public void Cizgiyi_listeye_ekle()
        {
            CizgiSayisi++;
            IcerikSayisi++;
            IceriklerListesi.Add(new Icerikler(1, CizgiSayisi));
            // 1 cizgiyi ifade eden bir tiptir
        }// fonksiyon sonu
        /// <summary>
        /// Bu fonksiyon yeni eklenen bir çizginin ilk değerlerini
        /// tanımlayıp çizgiler listesine eklemesini yapıyor
        /// </summary>
        public void CizgiOlustur()
        {
            Cizgiler cizgi = new Cizgiler();
            // Burada listeye eklemek için yeni değer belirtiyoruz
            Color color = Color.FromArgb(0, 0, 0);
            cizgi.KalemRengi = color;
            cizgi.KalemBoyutu = 2;
            cizgi.CizgiX1 = 0;
            cizgi.CizgiX2 = 10;
            cizgi.CizgiY1 = 10;
            cizgi.CizgiY2 = 10;
            CizgilerListesi.Add(cizgi);
        }// fonksiyon sounu
        /// <summary>
        /// Bu fonksiyon Birden fazla iceri tipi olduğu için onları düzene
        /// koymaya yarayan teknik bir koddur
        /// </summary>
        /// <param name="id"></param>
        public void IcerikSilme(int id)
        {
            if (id >= 0)
            {
                int tipi = IceriklerListesi[id].Tipi;
                switch (tipi)
                {
                    case 0: YazilarListesi.RemoveAt(IceriklerListesi[id].ListeId - 1); Yazisayisi--; break;
                    case 1: CizgilerListesi.RemoveAt(IceriklerListesi[id].ListeId - 1); CizgiSayisi--; break;
                }
                IceriklerListesi.RemoveAt(id);
                for (int i = id; i < IceriklerListesi.Count; i++)
                {
                    if (IceriklerListesi[i].Tipi == tipi)
                    {
                        IceriklerListesi[i].ListeId--;
                    }// if sonu

                }// for sonu
                IcerikSayisi--;
               
            }//if sonu
        }// fonksiyon sonu
     
        } // Ana class sonu
}
