using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_projesi
{
    public partial class kontroller : Form
    {
        Bilgiler nesne;
        string ileri = "";
        string geri = "";
        string veri = "";
        bool calisma = true;
        public bool okumaKontrol = false;
        public int okumaSonuc = 0;
        public int okumaTip = -1;
        public int oncekiTip;
        int sonKontrol = -1;
        Thread thread1;
        udpserver udp = new udpserver(8989); // bu port ir remote dinlemesi yapacak
        public kontroller()
        {
            InitializeComponent();
        }
        private void kontroller_Load(object sender, EventArgs e)
        {
            timer1.Start();
            thread1 = new Thread(new ThreadStart(udpdinle));
      //      thread1.IsBackground = false;
            thread1.Start();
            nesne = new Bilgiler();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                lbGelenDeger.Text = "Gelen Değer = " + veri;
                labelisle(sonKontrol);
                
        }

        private void tsmiKontrolAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "kizilötesi kod dosyasi |*.kizil";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "lütfen bilgi dosyası Seçiniz..";
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
                   nesne = new Bilgiler();
                   nesne = (Bilgiler)BinaryDeserialize(bytes);
                    lblSag.Text = ileri = nesne.ileri;
                    lblSol.Text = geri = nesne.geri;
                }
                finally
                {
                    fileStream.Close(); // işlem bittikten sonra dosyamızı kapatmamız gerekmektedir
                }
            }
        }

        private void tsmiKontrolKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "kizilötesi kod dosyasi |*.kizil";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;


            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(save.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, nesne);
                fs.Close();
            }
        }

        private void btnKontrolSol_Click(object sender, EventArgs e)
        {
            if (btnKontrolSol.ForeColor == Color.Black)
            {
                komtrolAc(0);
                sonKontrol = 0;
            }
            else
            {
                komtrolAc(-1);
                sonKontrol = -1;
            }
        }

        private void btnKontrolSag_Click(object sender, EventArgs e)
        {

            if (btnKontrolSag.ForeColor == Color.Black)
            {
                komtrolAc(1);
                sonKontrol = 1;
            }
            else
            {
                komtrolAc(-1);
                sonKontrol = -1;
            }
        }
        private  void komtrolAc(int no)
        {
            btnKontrolSag.ForeColor = (no == 1) ?  Color.Blue : Color.Black;
            btnKontrolSol.ForeColor = (no == 0) ?  Color.Blue : Color.Black;
            labelisle(no);
        }// fonksiyon sonu
        void labelisle(int no)
        {
            if (veri != "")
            {
                switch (no)
                {
                    case 0: lblSol.Text = nesne.geri = geri = veri;  break;
                    case 1: lblSag.Text = nesne.ileri = ileri = veri; break;
                }// switch sonu
            }// veri ifi sonu
        }
        public void udpdinle()
        {
           while(calisma)
            {
                Thread.Sleep(50);
                if (okumaTip == 0)
                {
                    udp.Tara();
                    if (udp.durumKontrol())
                    {
                        veri = udp.GelenDeger();
                        //        lbGelenDeger.Text = "Gelen Değer = " + veri;
                    }
                }
                else if(okumaTip == 1)
                {
                    udp.Tara2(ileri,geri);
                    if (udp.durumKontrol())
                    {
                        okumaSonuc = udp.GelenKod();
                        okumaKontrol = true;
                        //        lbGelenDeger.Text = "Gelen Değer = " + veri;
                    }
                }
            }// sonsuz döngü
            MessageBox.Show("durdu");
        }// fonksiyon sonu

        private void tsmiKapat_Click(object sender, EventArgs e)
        {
            okumaTip = oncekiTip;
            this.Hide();

        }
        public static object BinaryDeserialize(byte[] buffer)
        {
            using (var stream = new MemoryStream(buffer))
            {
                var formatter = new BinaryFormatter();

                return formatter.Deserialize(stream);
            }
        }

        private void btnKontrolKaydet_Click(object sender, EventArgs e)
        {
            nesne.ileri = ileri;
            nesne.geri = geri;
        }

     
    }
}
