using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProPad
{
    public class clsServidor
    {
        private Socket server;
        private Socket tempSocket;
        private AsyncCallback asyncCallBack;

        private Chat_Servidor form1;

        public clsServidor (Chat_Servidor f)
        {
            form1 = f;
        }

        public void Enviar(byte[] data)
        {
            if (tempSocket != null)
                tempSocket.Send(data);
            else
                MessageBox.Show("No hay clientes conectados\r\nOr server no se conecta", "Enviar Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Conectar(string ipAddr, string port)
        {
            try
            {
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, Convert.ToInt32(port));

                server.Bind(ipLocal);
                server.Listen(5);

                server.BeginAccept(new AsyncCallback(ClienteConectado), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Desconectar()
        {
            server.Close();
            server = null;
            tempSocket = null;
        }

        public void ClienteConectado(IAsyncResult asyn)
        {
            try
            {
                if (server != null)
                {
                    tempSocket = server.EndAccept(asyn);

                    EsperandoDato(tempSocket);

                    server.BeginAccept(new AsyncCallback(ClienteConectado), null);
                }
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("ClienteConectado: Socket se cerro");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ClienteConectado, Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EsperandoDato (Socket soc)
        {
            try
            {
                if (asyncCallBack == null)
                    asyncCallBack = new AsyncCallback(DatoRecibido);

                KeyValuePair aKeyValuePair = new KeyValuePair();
                aKeyValuePair.socket = soc;
                aKeyValuePair.dataBuffer = new byte[soc.ReceiveBufferSize];

                soc.BeginReceive(aKeyValuePair.dataBuffer, 0, aKeyValuePair.dataBuffer.Length, SocketFlags.None, asyncCallBack, aKeyValuePair);
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.Message, "error EsperandoDato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DatoRecibido (IAsyncResult asyn)
        {
            try
            {
                if (tempSocket != null)
                {
                    KeyValuePair aKeyValuePair = (KeyValuePair)asyn.AsyncState;

                    int iRx = 0;
                    iRx = aKeyValuePair.socket.EndReceive(asyn);

                    if (iRx != 0)
                    {
                        char[] chars = new char[iRx];
                                
                        int charLength = Encoding.GetEncoding(0).GetDecoder().GetChars(aKeyValuePair.dataBuffer, 0, iRx, chars, 0);
                        String text = new String(chars);
                        form1.UpdateText(text + "\r\n");

                        EsperandoDato(tempSocket);
                    }
                }
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show( "\nDato recibido: Socket cerrado\n");
            }
            catch (SocketException e)
            {
                if (e.ErrorCode == 10054)
                {
                    string text = "Cliente desconectado \r\n";
                    form1.UpdateText(text + "\r\n");
                    tempSocket = null;
                }
            }
        }
    }
}