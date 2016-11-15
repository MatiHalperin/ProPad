using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProPad
{
    public class clsCliente
    {
        private Socket cliente;
        private Thread clienteListener;
        private bool finClienteListener;

        private Chat_Cliente form1;

        public clsCliente(Chat_Cliente f)
        {
            form1 = f;
        }

        public void Enviar(byte[] data)
        {
            if (cliente != null)
                cliente.Send(data);
            else
                MessageBox.Show("No se pudo conectar", "Enviar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Conectar(string ipAddr, string port)
        {
            try
            {
                cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ipAddr), Convert.ToInt32(port));
                cliente.Connect(ipe);

                clienteListener = new Thread(DatoRecibido);
                finClienteListener = false;
                clienteListener.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Desconectar()
        {
            finClienteListener = true;
            cliente.Close();
            cliente = null;
            clienteListener.Abort();
        }

        private void DatoRecibido()
        {
            try
            {
                while (finClienteListener == false)
                {
                    byte[] receiveData = new byte[cliente.ReceiveBufferSize];
                    int iRx = cliente.Receive(receiveData);

                    if (iRx != 0)
                    {
                        if (iRx < receiveData.Length)
                        {
                            byte[] tempData = new byte[iRx];
                            for (int i = 0; i < iRx; i++)
                                tempData[i] = receiveData[i];
                            receiveData = tempData;
                        }

                        char[] chars = new char[iRx];
                        int charLength = Encoding.GetEncoding("ISO-8859-1").GetDecoder().GetChars(receiveData, 0, iRx, chars, 0);
                        String szData = new String(chars);
                        form1.UpdateText(szData + "\r\n");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Socket cerrado\n" + e.Message, "Cliente desconectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}