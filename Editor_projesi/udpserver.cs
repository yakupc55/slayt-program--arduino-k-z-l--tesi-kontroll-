using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Editor_projesi
{
   class udpserver
    {
        private int gelenKod = 0;
        private int islemkodu = 0;
        private int DinlenenPort;
        private  string okuma = "";
        private bool durum = false;
        private static UdpClient listener ;
        private IPEndPoint groupEP;
        public udpserver(int port)
        {
            DinlenenPort = port;
        }
    
        public void Tara()
        {
            okuma = "";
            listener = new UdpClient(DinlenenPort);
            while (okuma=="") {
                groupEP = new IPEndPoint(IPAddress.Any, DinlenenPort);
                string received_data;
                byte[] receive_byte_array;
                receive_byte_array = listener.Receive(ref groupEP);
                received_data = Encoding.UTF8.GetString(receive_byte_array, 0, receive_byte_array.Length);
                okuma = received_data;
                    }
            durum = true;
            listener.Close();
            groupEP.Port = 8989;
        }// fonksiyon sonu
        public void Tara2(string ileri,string geri)
        {
            durum = false;
            okuma = "";
            listener = new UdpClient(DinlenenPort);
            while (okuma == "")
            {
                groupEP = new IPEndPoint(IPAddress.Any, DinlenenPort);
                string received_data;
                byte[] receive_byte_array;
                receive_byte_array = listener.Receive(ref groupEP);
                received_data = Encoding.UTF8.GetString(receive_byte_array, 0, receive_byte_array.Length);
                okuma = received_data;
            }
            if (okuma.Equals(ileri))
            {
                durum = true;
                gelenKod = 1;
            }
            else if (okuma.Equals(geri))
            {
                durum = true;
                gelenKod = -1;
            }
            listener.Close();
        }
        
        
        public string GelenDeger()
        {
            durum = false;
            return okuma;
        }
        public int GelenKod()
        {
            return gelenKod;
        }
        public bool durumKontrol()
        {
            return durum;
        }
    }
}