using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProPad
{
    public partial class Chat_Servidor : Form
    {
        public clsServidor server;

        public delegate void UpdateTextCallback(string text);
        private delegate void ReconnectCallback();

        public Chat_Servidor()
        {
            InitializeComponent();

            IPHostEntry Host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in Host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    txtIP.Text = ip.ToString();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string ipAddr = txtIP.Text;
            string port = txtPuerto.Text;

            if (IsValidIPAddress(ipAddr) == true)
            {
                try
                {
                    if (server == null)
                        server = new clsServidor(this);

                    server.Conectar(ipAddr, port);

                    btnConectar.Enabled = false;
                    btnDesconectar.Enabled = true;
                    txtDato.Focus();
                }
                catch (SocketException se)
                {
                    MessageBox.Show("Error al conectarse.\r\n" + se.ToString());
                }
            }
            else
                MessageBox.Show("Ip invalida");
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                server.Desconectar();

                if (btnConectar.Enabled == false)
                {
                    btnConectar.Enabled = true;
                    btnDesconectar.Enabled = false;
                }
            }
            catch 
            {
                MessageBox.Show("Error al desconectar");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "")
            {
                try
                {
                    if (server != null)
                    {
                        byte[] bytes = Encoding.GetEncoding(0).GetBytes(txtDato.Text);

                        server.Enviar(bytes);
                        string str = "";
                        str = "\r\nServer dice: (@" + DateTime.Now.ToString() + ")\r\n" + txtDato.Text;

                        lblMensajes.Text = lblMensajes.Text + str + "\r\n";
                        txtDato.Clear();
                    }
                }
                catch (SocketException se)
                {
                    MessageBox.Show("Enviando error en server!\r\n" + se.Message);
                }
            }
        }

        private void btnReconectar_Click(object sender, EventArgs e)
        {
            if (btnDesconectar.Enabled == true)
                btnDesconectar_Click(sender, e);

            Thread.Sleep(200);
            btnConectar_Click(sender, e);
        }

        public void UpdateText(string text)
        {
            if (this.lblMensajes.InvokeRequired)
            {
                ProPad.Chat_Cliente.UpdateTextCallback temp = new ProPad.Chat_Cliente.UpdateTextCallback(UpdateText);
                this.Invoke(temp, new object[] { text });
            }
            else
            {
                string str = "";
                str = "\r\nClient said: (@" + DateTime.Now.ToString() + ")\r\n" + text;
                lblMensajes.Text = lblMensajes.Text + str;
            }
        }

        private bool IsValidIPAddress(string ipaddr)
        {
            try
            {
                IPAddress.Parse(ipaddr);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "IsValidIPAddress Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Reconnect()
        {
            try
            {
                if (btnReconectar.InvokeRequired)
                {
                    ReconnectCallback r = new ReconnectCallback(Reconnect);
                    this.Invoke(r, new object[] { });
                }
                else
                    btnReconectar_Click(null, null);
            }
            catch (Exception e)
            {
                MessageBox.Show("Reconnect failed.  Please restart.\r\n" + e.Message, "Reconnect Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEnviar.PerformClick();
        }

        private void Chat_Servidor_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(76, 175, 80);
            lblMensajes.ForeColor = Color.White;
        }
    }

    public class aKeyValuePair
    {
        public Socket socket;
        public byte[] dataBuffer = new byte[1];
    }
}