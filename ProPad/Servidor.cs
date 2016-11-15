using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ProPad
{
    class Servidor
    {
        IPEndPoint end;
        Socket sock;

        public Servidor()
        {
            end = new IPEndPoint(IPAddress.Any, 2014);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            sock.Bind(end);
        }

        public static string path;
        public static string MensajeActual = "Parado";

        public void StartServer()
        {
            try
            {
                MensajeActual = "Empezando...";
                sock.Listen(100);
                MensajeActual = "Funcionando y buscando archivos...";
                Socket clientSock = sock.Accept();
                byte[] clientData = new byte[1048576 * 50];
                int receivedByteLen = clientSock.Receive(clientData);
                MensajeActual = "Archivo entrante...";
                int fNameLen = BitConverter.ToInt32(clientData, 0);
                string fName = Encoding.ASCII.GetString(clientData, 4, fNameLen);

                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                    path = ofd.FileName;
                else
                {
                    MensajeActual = "Se ha rechazado el archivo";
                    return;
                }

                BinaryWriter write = new BinaryWriter(File.Open(path + "/" + fName, FileMode.Append));
                write.Write(clientData, 4 + fNameLen, receivedByteLen - 4 - fNameLen);
                MensajeActual = "Guardando archivo....";
                write.Close();
                clientSock.Close();
                MensajeActual = "El archivo fue recibido con exito";
            }
            catch
            {
                MensajeActual = "Error, el archivo no se ha recibido correctamente";
            }
        }

        public void Desconectar()
        {
            sock.Close();
            sock = null;
        }
    }
}