using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ProPad
{
    class Cliente
    {
        public static string MensajeActual = "Esperando...";
        public static string IPLocal;

        public static string GetLocalIPAddress()
        {
            IPHostEntry Host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress IP in Host.AddressList)
                if (IP.AddressFamily == AddressFamily.InterNetwork)
                    IPLocal = IP.ToString();

            return IPLocal;
        }

        public static void SendFile(string fName, IPEndPoint end)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(GetLocalIPAddress());
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string path = "";
                fName = fName.Replace("\\", "/");

                while (fName.IndexOf("/") > -1)
                {
                    path += fName.Substring(0, fName.IndexOf("/") + 1);
                    fName = fName.Substring(fName.IndexOf("/") + 1);
                }

                byte[] fNameByte = Encoding.ASCII.GetBytes(fName);

                if (fNameByte.Length > 850 * 1024)
                {
                    MensajeActual = "El archivo es mayor que 850 kb";
                    return;
                }

                MensajeActual = "Buffering...";
                byte[] fileData = File.ReadAllBytes(path + fName);
                byte[] clientData = new byte[4 + fNameByte.Length + fileData.Length];
                byte[] fNameLen = BitConverter.GetBytes(fNameByte.Length);
                fNameLen.CopyTo(clientData, 0);
                fNameByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + fNameByte.Length);
                MensajeActual = "Conectando con el servidor...";
                sock.Connect(end);
                MensajeActual = "Enviando archivo...";
                sock.Send(clientData);
                MensajeActual = "Desconectandose...";
                sock.Close();
                MensajeActual = "El archivo fue enviado con exito";
            }
            catch (Exception ex)
            {
                MensajeActual = "Esperando...";
                MessageBox.Show(ex.Message);
            }
        }
    }
}
