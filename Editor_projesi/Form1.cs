using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.Compression;
namespace Editor_projesi
{
    public partial class Form1 : Form
    {
        private bool udpDinleDurumu =false;
        private kontroller kontrol;
        private Bitmap SakliResim = new Bitmap(648, 476);
        private int acikGroup = -1;
        private Cizim cizim = new Cizim();
        private int Icerik_sonkonum = 0;
        private int Icerik_sonsecim = -1;
        private int sonsecim = -1;
        private int son_konum = 0;
        private bool durum = false;
        private List<Bitmap> resimlerim = new List<Bitmap>();
        private List<Sayfalar> Sayfalarimiz = new List<Sayfalar>();
        private List<Sayfa_index> SayfaIndexlerimiz = new List<Sayfa_index>();
        private List<String> DegerListesi = new List<string>();
        private Bitmap IcerikListesindekiResim = new Bitmap(128, 72);
        private ImageList IcerikResimListesi;
        private ImageList resimListesi = new ImageList();
        private int Sayfa_id = 0;
        private int max_sayfa = 0;
        private int Smax_sayfa = 0;
        private ListViewItem IceriklerListItem = new ListViewItem();
        private IcerikIslemleri icerikIslem = new IcerikIslemleri();
        private SayfaDuzen sayfaDuzen = new SayfaDuzen();
        private bool sunumdurumu = false;
        private Font SeciliFont; // Open dialogtaki çıkışı aklında tutsun diye gerekli kod
        private Color SeciliRenk;  // open dilalog color aklında tutsn diye
                                   // bazı durumlarda işlevsiz kılmak için
                                   /// <summary>
                                   /// Bu fonksiyon program.cs den gelen dosya ismiyle
                                   /// dosyayı çağırmamızı şağlıyor
                                   /// </summary>
                                   /// <param name="DosyaYolu"></param>
        public void DosyaAc(String DosyaYolu)
        {
            openStatus.Text = "Açılan dosya:" + DosyaYolu;
            // bu bir durum labeli içine bilgiyi ekliyoruz.
            Thread.Sleep(1000);
            // PRogram atfosmerini bozmamak için belli bir bekletme süresi ekliyoruz
            //Bu gecikmeyi eklememizin nedeni openStatusa bir bilgi daha ekleyeceğimiz
            // Eğer bu gecikmeyi eklemessek ilk bilgileri göremeyiz
            string s = File.ReadAllText(DosyaYolu);
            // tüm text verisini okuma kodu
            //   richTextBox1.Text = s;
            // Text içeriğini bütün olarak richtextbox' ekledik
            openStatus.Text = "Hazır";
            // Bittiğini label'le ekrana bastırıyoruz.

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kontrol = new kontroller();
            this.KeyPreview = true;
            //key preview durumu form üzerinde klavye basımlarının çalışmasını truya çevirir
            this.Location = new Point(0, 0);
            acilisBilgisi.Visible = false;
            GbOzellik.Visible = false;
            gbCizgiler.Visible = false;
            gbSayfaOzellikler.Visible = false;
            gbCizgiler.Location = new Point(168, 530);
            gbSayfaOzellikler.Location = new Point(168, 530);
            Color red = Color.FromArgb(128, 100, 82);
            labelTest.Text = ColorTranslator.ToHtml(red);

            resimListesi = new ImageList();
            resimListesi.ImageSize = new Size(128, 72);
            lvSayfalar.LargeImageList = resimListesi;
            lvSayfalar.Margin = new Padding(0);
            lvSayfalar.LargeImageList.ImageSize = new Size(128, 72);

            IcerikResimListesi = new ImageList();
            IcerikResimListesi.ImageSize = new Size(128, 72);
            LvIcerik.LargeImageList = IcerikResimListesi;
            LvIcerik.Margin = new Padding(0);
            LvIcerik.LargeImageList.ImageSize = new Size(128, 72);
        }


        /****************************************************************************
        * SAYFALAR LİSTELEME İLGİLİ KODLR BURADAN İTABAREN BAŞLAMAKTADIR
        * sON GÜNCELLEME 5 Aralık 2017
        * SİL BUTONU
        * LVSAYFALARCHANGED
        * SAYFALARTAZELE
        * SAYFALAR EKLE
        * İLERİ GERİ BUTONLARI
        *****************************************************************************/

        private void EkleButton_Click(object sender, EventArgs e)
        {
            GrouplariKapa();
            Color color = Color.FromArgb(200, 200, 200);
            Sayfalar sayfalar = new Sayfalar();
            sayfalar.Id = Sayfa_id;
            sayfalar.anaYapi.ArkaPlan = color;
            Sayfalarimiz.Add(sayfalar);
            resimlerim.Add(sayfaDuzen.SayfaResmiDondur(Sayfa_id));
            max_sayfa++;
            Sayfa_id++;
            Smax_sayfa++;
            tmsayfalar.Start();
            //        IcerikListesiTazele(max_sayfa-1);
            //          sonsecim = max_sayfa - 1;
            acikGroup = -1;
            Groupackapa();
        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            if (lvSayfalar.SelectedIndices.Count > 0)
            { //Secili satır varmı yokmu kontrol ediliyor.
                int d = lvSayfalar.SelectedItems[0].Index;
                son_konum = (d == 0) ? ((max_sayfa == 1) ? -1 : 1) : ((max_sayfa == d) ? d : d - 1);
                resimlerim.RemoveAt(d);
                Sayfalarimiz.RemoveAt(d);
                max_sayfa--;
                tmsayfalar.Start();
                sonsecim = -1;
                Bitmap sifir = new Bitmap(648, 476);
                LvIcerik.Clear();
                pictureBox1.Image = sifir;
                labelTest.Text = "Seçili sayfa yok";
            }//if sonu
            acikGroup = -1;
            Groupackapa();
        }// sil butonu sonu

        private void ileriButton_Click(object sender, EventArgs e)
        {
            if (lvSayfalar.SelectedIndices.Count > 0)
            {
                int rb = lvSayfalar.SelectedItems[0].Index;
                if (rb < max_sayfa - 1)
                {
                    Sayfalar anlik = Sayfalarimiz[rb + 1];
                    Sayfalarimiz[rb + 1] = Sayfalarimiz[rb];
                    Sayfalarimiz[rb] = anlik;
                    Bitmap bitlendik = resimlerim[rb + 1];
                    resimlerim[rb + 1] = resimlerim[rb];
                    resimlerim[rb] = bitlendik;
                    son_konum = rb;
                    tmsayfalar.Start();
                }
                acikGroup = -1;
                Groupackapa();
            }

        }// fonksiyon sonu

        private void geriButton_Click(object sender, EventArgs e)
        {
            if (lvSayfalar.SelectedIndices.Count > 0)
            {
                int rb = lvSayfalar.SelectedItems[0].Index;
                if (rb > 0)
                {
                    Sayfalar anlik = Sayfalarimiz[rb - 1];
                    Sayfalarimiz[rb - 1] = Sayfalarimiz[rb];
                    Sayfalarimiz[rb] = anlik;
                    Bitmap bitlendik = resimlerim[rb - 1];
                    resimlerim[rb - 1] = resimlerim[rb];
                    resimlerim[rb] = bitlendik;
                    son_konum = rb;
                    tmsayfalar.Start();
                }
                acikGroup = -1;
                Groupackapa();
            }
        }// fonksiyon sonu

        private void LvSayfalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrouplariKapa();
            if (lvSayfalar.SelectedIndices.Count > 0) //Secili satır varmı yokmu kontrol ediliyor.
            {

                labelTest.Text = "Secili sayfa = " + lvSayfalar.SelectedItems[0].Index.ToString();
                IcerikListesiTazele(lvSayfalar.SelectedItems[0].Index);
                sonsecim = lvSayfalar.SelectedItems[0].Index;
            } // if sonu
            acikGroup = -1;
            Groupackapa();
        }

        private void SayfalarTazele()
        {
            if (lvSayfalar.SelectedIndices.Count > 0) //Secili satır varmı yokmu kontrol ediliyor.
            {
                durum = true;
            }
            lvSayfalar.Clear();
            resimListesi.Images.Clear();
            for (int i = 0; i < max_sayfa; i++)
            {
                resimListesi.Images.Add(resimlerim[i]);
            }
            for (int i = 0; i < max_sayfa; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.ImageIndex = i;
                lvSayfalar.Items.Add(item);
            }
            if (durum && son_konum > 1)
            {
                lvSayfalar.EnsureVisible(son_konum);
                durum = false;
            }

        }// fonksiyon sonu

        public Bitmap KucukResimTazele()
        {
            Bitmap cek = new Bitmap(SakliResim);
            Bitmap donustur = new Bitmap(cek, new Size(128, 72));
            return donustur;
        }
        private void tmsayfalar_Tick(object sender, EventArgs e)
        {
            if (!sunumdurumu)
            {
                SayfalarTazele();
            }
            tmsayfalar.Stop();
        }
        private void kucukresim()
        {
            if (sonsecim >= 0)
            { tmsayfalar.Start();
            }
        }
        /****************************************************************************
       * İÇERİK LİSTELEME İLE İLGİLİ KODLR BURADAN İTABAREN BAŞLAMAKTADIR
       * sON GÜNCELLEME 5 Aralık 2017
       *****************************************************************************/

        /// <summary>
        /// Bu fonksiyon çok amaçlı çalışan her ekleme silinme vb durumlarda
        /// Sürekli olarak çalışacak olan kısımdır bundan dolayı burası oldukça dinamik
        /// bi yapıda hazırlanmaya çalışılmıştır.
        /// </summary>
        /// <param name="id"></param>
        private void btnicerikileri_Click(object sender, EventArgs e)
        {
            if (LvIcerik.SelectedIndices.Count > 0)
            {
                int rb = LvIcerik.SelectedItems[0].Index;
                if (rb < Sayfalarimiz[sonsecim].IcerikSayisi && rb > 0)
                {
                    Sayfalar.Icerikler anlik = Sayfalarimiz[sonsecim].IceriklerListesi[rb - 1];
                    Sayfalarimiz[sonsecim].IceriklerListesi[rb - 1] = Sayfalarimiz[sonsecim].IceriklerListesi[rb];
                    Sayfalarimiz[sonsecim].IceriklerListesi[rb] = anlik;
                    Image bitlendik = IcerikResimListesi.Images[rb - 1];
                    IcerikResimListesi.Images[rb - 1] = IcerikResimListesi.Images[rb];
                    IcerikResimListesi.Images[rb] = bitlendik;
                    Icerik_sonkonum = rb;
                    tmicerikler.Start();
                }//if sonu
            }//son if sonu

        }

        private void btnicerikgeri_Click(object sender, EventArgs e)
        {
            if (LvIcerik.SelectedIndices.Count > 0)
            {
                int rb = LvIcerik.SelectedItems[0].Index;
                if (rb > 1)
                {
                    Sayfalar.Icerikler anlik = Sayfalarimiz[sonsecim].IceriklerListesi[rb - 1];
                    Sayfalarimiz[sonsecim].IceriklerListesi[rb - 1] = Sayfalarimiz[sonsecim].IceriklerListesi[rb - 2];
                    Sayfalarimiz[sonsecim].IceriklerListesi[rb - 2] = anlik;
                    Image bitlendik = IcerikResimListesi.Images[rb - 1];
                    IcerikResimListesi.Images[rb - 1] = IcerikResimListesi.Images[rb - 2];
                    IcerikResimListesi.Images[rb - 2] = bitlendik;
                    Icerik_sonkonum = rb;
                    tmicerikler.Start();
                }//if sonu
            }//son if sonu
        }
        private void IcerikListesiTazele(int id)
        {
            LvIcerik.Clear();
            IcerikResimListesi.Images.Clear();
            IcerikListesindekiResim = icerikIslem.AnaYapiResimOlustur(IcerikListesindekiResim);
            IcerikResimListesi.Images.Add(IcerikListesindekiResim);
            IceriklerListItem.Text = "0";
            IceriklerListItem.ImageIndex = 0;
            LvIcerik.Items.Add(IceriklerListItem);

            icerikIslem.Sayfa = Sayfalarimiz[id];
            icerikIslem.GelenResim = IcerikListesindekiResim;
            for (int i = 0; i < Sayfalarimiz[id].IceriklerListesi.Count; i++)
            {
                switch (Sayfalarimiz[id].IceriklerListesi[i].Tipi)
                {
                    case 0: icerikIslem.YaziResmiOlustur(Sayfalarimiz[id].IceriklerListesi[i].ListeId); break;
                    case 1: icerikIslem.CizgiResmiOlustur(Sayfalarimiz[id].IceriklerListesi[i].ListeId); break;
                }
                IcerikListesindekiResim = icerikIslem.GelenResim;
                IcerikResimListesi.Images.Add(IcerikListesindekiResim);
            }
            for (int i = 0; i < Sayfalarimiz[id].IceriklerListesi.Count; i++)
            {
                ListViewItem IceriklerListItem2 = new ListViewItem();
                IceriklerListItem2.Text = (i + 1).ToString();
                IceriklerListItem2.ImageIndex = i + 1;
                LvIcerik.Items.Add(IceriklerListItem2);
            }
            cizim.SayfaDegistir(Sayfalarimiz[id]);
            cizim.ResimIsle();
            pictureBox1.Image = cizim.ResimCek();
            SakliResim = cizim.ResimCek();

        }// fonksiyon sonu

        private void BtnYaziEkle_Click(object sender, EventArgs e)
        {
            if (sonsecim >= 0) //Secili satır varmı yokmu kontrol ediliyor.
            {
                int r = sonsecim;
                //  Sayfalarimiz[r].IceriklerListesi.Add(new Sayfalar.Icerikler(0, 1));
                Sayfalarimiz[r].listeye_ekle();
                Sayfalarimiz[r].IlkYaziOlustur();
                IcerikListesiTazele(r);
                Icerik_sonsecim = -1;
                kucukresim();
            }// if sonu

        }
        /// <summary>
        /// Bu Çizgi ekle kodunun direk çalıştığı bir fonksiyondur
        /// ama ismi kara olarak kamış şimdilik onu problem etmenin bir anlamı yok 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCizgiEkle_Click(object sender, EventArgs e)
        {

            if (sonsecim >= 0) //Secili satır varmı yokmu kontrol ediliyor.
            {
                int r = sonsecim;
                Sayfalarimiz[r].Cizgiyi_listeye_ekle();
                Sayfalarimiz[r].CizgiOlustur();
                IcerikListesiTazele(r);
                kucukresim();
            }// if sonu

        }

        private void LvIcerik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvIcerik.SelectedIndices.Count > 0 && sonsecim >= 0) {
                Icerik_sonsecim = LvIcerik.SelectedItems[0].Index;
                if (Icerik_sonsecim > 0) {
                    int tip = Sayfalarimiz[sonsecim].IceriklerListesi[Icerik_sonsecim - 1].Tipi;
                    acikGroup = tip;
                    Groupackapa();
                    switch (tip)
                    {
                        case 0: YaziGrubaAta(Sayfalarimiz[sonsecim].IceriklerListesi[Icerik_sonsecim - 1].ListeId); break;
                        case 1: CizgiGrubaAta(Sayfalarimiz[sonsecim].IceriklerListesi[Icerik_sonsecim - 1].ListeId); break;
                    }
                }// if sonu
                else if (Icerik_sonsecim == 0)
                {
                    acikGroup = 100;
                    Groupackapa();
                    SayfaGrubaAta();
                }
            }// ilk if sonu


        }
        private void BtnIcerikSil_Click(object sender, EventArgs e)
        {

            if (LvIcerik.SelectedIndices.Count > 0)
            {
                int d = LvIcerik.SelectedItems[0].Index - 1;
                Icerik_sonkonum = (Sayfalarimiz[sonsecim].IcerikSayisi == d) ? d + 1 : d;
                IcerikResimListesi.Images.RemoveAt(d + 1);
                Sayfalarimiz[sonsecim].IcerikSilme(d);
                tmicerikler.Start();
                GrouplariKapa();
            }
        }
        private void tmicerikler_Tick(object sender, EventArgs e)
        {
            if (!sunumdurumu)
            {
                IcerikListesiTazele(sonsecim);
                resimlerim[sonsecim] = KucukResimTazele();
                kucukresim();
            }
            tmicerikler.Stop();
        }


        /****************************************************************************
      * öZELLİK MENULERİ İLE İLGİLİ KODLR BURADAN İTABAREN BAŞLAMAKTADIR
      * sON GÜNCELLEME 5 Aralık 2017
      *****************************************************************************/
        private void Groupackapa()
        {
            GbOzellik.Visible = (acikGroup == 0) ? true : false;
            gbCizgiler.Visible = (acikGroup == 1) ? true : false;
            gbSayfaOzellikler.Visible = (acikGroup == 100) ? true : false;
        }
        private void GrouplariKapa()
        {
            GbOzellik.Visible = false;
            gbCizgiler.Visible = false;
            gbSayfaOzellikler.Visible = false;
        }
        private void SayfaGrubaAta()
        {
            SeciliRenk = btnRenkSecSayfa.BackColor = Sayfalarimiz[sonsecim].anaYapi.ArkaPlan;
        }
        private void YaziGrubaAta(int id)
        {
            tbYazix.Text = Sayfalarimiz[sonsecim].YazilarListesi[id - 1].YaziXKonum.ToString();
            tbYaziy.Text = Sayfalarimiz[sonsecim].YazilarListesi[id - 1].YaziYKonum.ToString();
            rchYazi.Text = Sayfalarimiz[sonsecim].YazilarListesi[id - 1].YaziMetni;
            SeciliFont = btnFontSec.Font = Sayfalarimiz[sonsecim].YazilarListesi[id - 1].YaziFont;
            SeciliRenk = btnRenkSecYazi.BackColor = Sayfalarimiz[sonsecim].YazilarListesi[id - 1].YaziRengi;
        }
        private void CizgiGrubaAta(int id)
        {
            tbcizgix1.Text = Sayfalarimiz[sonsecim].CizgilerListesi[id - 1].CizgiX1.ToString();
            tbcizgix2.Text = Sayfalarimiz[sonsecim].CizgilerListesi[id - 1].CizgiX2.ToString();
            tbcizgiy1.Text = Sayfalarimiz[sonsecim].CizgilerListesi[id - 1].CizgiY1.ToString();
            tbcizgiy2.Text = Sayfalarimiz[sonsecim].CizgilerListesi[id - 1].CizgiY2.ToString();
            tbCizgiKalinlik.Text = Sayfalarimiz[sonsecim].CizgilerListesi[id - 1].KalemBoyutu.ToString();
            SeciliRenk = btnRenkSecCizgi.BackColor = Sayfalarimiz[sonsecim].CizgilerListesi[id - 1].KalemRengi;
        }
        private void btnSayfaKaydet_Click(object sender, EventArgs e)
        {
            Sayfalarimiz[sonsecim].anaYapi.ArkaPlan = SeciliRenk;
            tmicerikler.Start();
        }
        private void BtnYazikaydet_Click(object sender, EventArgs e)
        {
            int ListeId = Sayfalarimiz[sonsecim].IceriklerListesi[Icerik_sonsecim - 1].ListeId;
            Sayfalar.Yazilar yz = Sayfalarimiz[sonsecim].YazilarListesi[ListeId - 1];
            int Gelenx = Convert.ToInt16(tbYazix.Text);
            int Geleny = Convert.ToInt16(tbYaziy.Text);
            String GelenYazi = rchYazi.Text;
            Sayfalarimiz[sonsecim].YazilarListesi[ListeId - 1] = icerikIslem.YaziNitelikleriDegistir(yz, Gelenx, Geleny, GelenYazi, SeciliFont, SeciliRenk);
            /*  cizim.SayfaDegistir(Sayfalarimiz[sonsecim]);
              cizim.ResimIsle();
              pictureBox1.Image = cizim.ResimCek();*/
            btnFontSec.Font = SeciliFont;
            tmicerikler.Start();
        }
        private void btCizgiKaydet_Click(object sender, EventArgs e)
        {
            int ListeId = Sayfalarimiz[sonsecim].IceriklerListesi[Icerik_sonsecim - 1].ListeId;
            Sayfalar.Cizgiler cz = Sayfalarimiz[sonsecim].CizgilerListesi[ListeId - 1];
            int Gelenx1 = Convert.ToInt16(tbcizgix1.Text);
            int Gelenx2 = Convert.ToInt16(tbcizgix2.Text);
            int Geleny1 = Convert.ToInt16(tbcizgiy1.Text);
            int Geleny2 = Convert.ToInt16(tbcizgiy2.Text);
            int boyut = Convert.ToInt16(tbCizgiKalinlik.Text);
            Sayfalarimiz[sonsecim].CizgilerListesi[ListeId - 1] = icerikIslem.CizgiNitelikleriDegistir(cz, Gelenx1, Gelenx2, Geleny1, Geleny2, boyut, SeciliRenk);
            tmicerikler.Start();
        }
        private void btnFontSec_Click(object sender, EventArgs e)
        {
            FontDialog Font = new FontDialog();
            Font.Font = SeciliFont;
            Font.ShowDialog();
            btnFontSec.Font = SeciliFont = Font.Font;
        }
        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            ColorDialog Renk = new ColorDialog();
            Renk.Color = SeciliRenk;
            Renk.ShowDialog();
            btnRenkSecYazi.BackColor = SeciliRenk = Renk.Color;
        }
        private void btnRenkSecCizgi_Click(object sender, EventArgs e)
        {
            ColorDialog Renk = new ColorDialog();
            Renk.Color = SeciliRenk;
            Renk.ShowDialog();
            btnRenkSecCizgi.BackColor = SeciliRenk = Renk.Color;
        }
        private void btnRenkSecSayfa_Click(object sender, EventArgs e)
        {
            ColorDialog Renk = new ColorDialog();
            Renk.Color = SeciliRenk;
            Renk.ShowDialog();
            btnRenkSecSayfa.BackColor = SeciliRenk = Renk.Color;
        }
        /****************************************************************************
      * Menu sistemleri için gerekli kodlar buradan itibaren başlamaktadır
      * SON GÜNCELLEME 8 Ocak 2018
      *****************************************************************************/
        private void Gbekleme_Enter(object sender, EventArgs e)
        {

        }
        private void Tstxkaydet_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Gehos dosyasi|*.ghs";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;


            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(save.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, Sayfalarimiz);
                fs.Close();
            }
        }

        private void otsmAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası |*.ghs";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Gehos Dosyası Seçiniz..";
            file.Multiselect = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;
                FileStream fileStream = new FileStream(DosyaYolu, FileMode.Open);
                try
                {

                    // dosyadan okuma veya yazma işlemi yapabiliriz

                    byte[] bytes = new byte[fileStream.Length];
                    int numBytesToRead = (int)fileStream.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fileStream.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    Sayfalarimiz = (List<Sayfalar>)BinaryDeserialize(bytes);
                }
                finally
                {
                    fileStream.Close(); // işlem bittikten sonra dosyamızı kapatmamız gerekmektedir
                }
            }
            SistemKapat();
            int z = Sayfalarimiz.Count;
            double yuzdelik = 100 / z;
            resimlerim.Clear();
            max_sayfa = z;
            Sayfa_id = z;
            Smax_sayfa = z;
            for (int i = 0; i < z; i++)
            {

                cizim.SayfaDegistir(Sayfalarimiz[i]);
                cizim.ResimIsle();
                SakliResim = cizim.ResimCek();
                resimlerim.Add(KucukResimTazele());
                acilisBilgisi.Text = "Aciliyor %" + (i + 1) * yuzdelik;
            }
            SayfalarTazele();
            SistemAc();
            lvSayfalar.Show();
        }

        public static object BinaryDeserialize(byte[] buffer)
        {
            using (var stream = new MemoryStream(buffer))
            {
                var formatter = new BinaryFormatter();

                return formatter.Deserialize(stream);
            }
        }
        private void DosyaAcma()
        {
            SistemKapat();
        }
        private void SistemKapat()
        {
            pictureBox1.Visible = false;
            sistemlerikapat();
            acilisBilgisi.Visible = true;
        }
        private void SistemAc()
        {
            pictureBox1.Visible = true;
            sistemleriac();
            acilisBilgisi.Visible = false;
        }

        private void tsmiKizilOtesi_Click(object sender, EventArgs e)
        {
            kontrol.oncekiTip = kontrol.okumaTip;
            kontrol.okumaTip = 0;
            kontrol.Show();
        }


        /****************************************************************************
       * Sunum modu için gerekli kodlar buradan itibaren başlamaktadır.
       * sON GÜNCELLEME 5 Aralık 2017
       *****************************************************************************/
        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = Screen.PrimaryScreen.Bounds.Size;
            Bitmap sakla = new Bitmap(SakliResim, Screen.PrimaryScreen.Bounds.Size);
            pictureBox1.Image = sakla;
            sistemlerikapat();
            // sunum durumunu kontrol eden mekanizma bu kod satırından itibaren başlıyor
            sunumdurumu = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                sunumdurumu = false;
                sistemleriac();
                pictureBox1.Image = SakliResim;
                pictureBox1.Size = new Size(684, 466);
                pictureBox1.Location = new Point(167, 63);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            //burada sadece sunum durumu açıkken olacak olaylar listeleniyor

            if (sunumdurumu)
            {
                if (e.KeyCode == Keys.Left && sonsecim > 0)
                {
                    sonsecim--;
                    ekranitazele(sonsecim);
                }
                if (e.KeyCode == Keys.Right && sonsecim < max_sayfa - 1)
                {
                    sonsecim++;
                    ekranitazele(sonsecim);
                }

            }
        }
        // aşşağıdaki fonkisyonun amacı sunum modundayken sayfa değişimlerini uygulamasıdır.
        private void ekranitazele(int sonsecim)
        {
            cizim.SayfaDegistir(Sayfalarimiz[sonsecim]);
            cizim.ResimIsle();
            SakliResim = cizim.ResimCek();
            ResimOlcekle();
        }
        private void ResimOlcekle()
        {
            Bitmap sakla = new Bitmap(SakliResim, Screen.PrimaryScreen.Bounds.Size);
            pictureBox1.Image = sakla;
        }
        private void sistemlerikapat()
        {
            LvIcerik.Visible = false;
            lvSayfalar.Visible = false;
            Gbekleme.Visible = false;
            GrouplariKapa();
            menuStrip1.Visible = false;
            MenuGrup.Visible = false;
            Gbekleme.Visible = false;
            GbIcerıkMenu.Visible = false;
        }
        private void sistemleriac()
        {
            LvIcerik.Visible = true;
            lvSayfalar.Visible = true;
            Gbekleme.Visible = true;
            GrouplariKapa();
            menuStrip1.Visible = true;
            MenuGrup.Visible = true;
            Gbekleme.Visible = true;
            GbIcerıkMenu.Visible = true;

        }

        /****************************************************************************
        * Dışardan müdaheleye izin veren kodlar burdan itibaren başlamaktadır
        * sON GÜNCELLEME 9 Ocak 2018
        *****************************************************************************/
        private void umdDinle_Tick(object sender, EventArgs e)
        {
            if (sunumdurumu)
           {
                if (kontrol.okumaKontrol)
                {
                    switch (kontrol.okumaSonuc)
                    {
                        //-1 geri veya sol durum anlamına gelmektedir
                        case -1:
                            if (sonsecim > 0)
                            {
                                sonsecim--;
                                ekranitazele(sonsecim);
                            }
                            break;

                        //1 ileri veya sağ durum anlamına gelmektedir
                        case 1:
                            if (sonsecim < max_sayfa - 1)
                            {
                                sonsecim++;
                                ekranitazele(sonsecim);
                            }
                            break;

                    }// switch sonu
                    kontrol.okumaKontrol = false;
                } // okuma durumu kontro
             }//sunum durumu kontrol 


        }// fonksiyon sonu

        private void tsmiKizilDurum_Click(object sender, EventArgs e)
        {
            if (udpDinleDurumu)
            {
                udpDinleDurumu = false;
                tsmiKizilDurum.Text = " Kızılötesi Kullan";
                tsmiKizilDurum.Checked = false;
                kontrol.okumaTip = -1;
                umdDinle.Stop();
            }
            else
            {
                udpDinleDurumu = true;
                tsmiKizilDurum.Text = " Kızılötesi Kullan";
                tsmiKizilDurum.Checked = true;
                kontrol.okumaTip = 1;
                umdDinle.Start();
            }
        }


        /****************************************************************************
        * İçeriklerin iç harektini sağlayan kodlar burdan itibaren başlamaktadır
        * sON GÜNCELLEME 8 Ocak 2018
        *****************************************************************************/
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
        //    pictureBox1.Cursor = Cursors.Hand;
            labelTest.Text=  MousePosition.ToString();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        //    pictureBox1.Cursor = Cursors.No;
        }

      




        /****************************************************************************
        * NE OLDUĞU BELİRSİZ KODLR BURADAN İTABAREN BAŞLAMAKTADIR
        * sON GÜNCELLEME 31 EKİM 2017
        *****************************************************************************/

    }// sınıf sonu
}
