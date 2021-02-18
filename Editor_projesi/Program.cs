using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_projesi
{
    static class Program
    {
        /// <summary>
        /// Başvurunun ana giriş noktası
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Evet bu noktadan sonra gelen arg dizisinin boş mu dolu mu
            // geldiğini sorguluyoruz
            if (args != null && args.Length > 0)
            {
                // if sorgumuzda args dizinin null yani boş değilse ve
                // uzunluğu 0' dan büyükse if bloğunu çalıştır diyoruz

                // Gelen dosya bilgisini DosyaAdi adli string verimize kaydediyoruz
                string DosyaAdi = args[0];
                //Dosyayi kontrol et, Gerçekten bir dosya mı
                if (File.Exists(DosyaAdi))
                {
                    Application.EnableVisualStyles();
                    // görsel efektleri aktifleştir diyor
                    Application.SetCompatibleTextRenderingDefault(false);
                    //Sistem tarafından default renderi kapat diyoruz
                    // yukardaki kodlar hazır bir mantıkla kendisi gelir

                    Form1 AnaForm = new Form1();
                    // form geçişleri için oluşturduğumuz bir method
                    AnaForm.DosyaAc(DosyaAdi);
                    // Anaform açılmadan önce DosyaAc fonksiyonumuzun  çalışmasını söyledik
                    Application.Run(AnaForm);
                    //programı ana form üzerinden başlat dedik
                }// iç if sonu
                else
                {
                    MessageBox.Show("Üzgünüz dosya bulunamadı. Yada dosya tipi desteklenmiyor");
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
            }// ana if sonu

            /* Şimdi aşşağıdaki kodlara gelecek olursak onlar orjinal normal bir proje
               açtığımızda gelen kodlar bizim yaptığımız tek şey onları else bloğuna almak
               zaten aşşağıdaki kodların tek lüksü programımız başlangıç formu olan form1 
               çalıştırmak */
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }// else sonu
        }// main fonksiyonu sonu
    }
}
    

