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
    public partial class Chat_Cliente : Form
    {
        public clsCliente cliente;

        public delegate void UpdateTextCallback(string text);
        private delegate void ReconnectCallback();

        public Chat_Cliente()
        {
            InitializeComponent();

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
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
                    if (cliente == null)
                        cliente = new clsCliente(this);

                    cliente.Conectar(ipAddr, port);

                    string data = "Modo cliente";
                    cliente.Enviar(Encoding.GetEncoding("ISO-8859-1").GetBytes(data));
                    lblMensajes.Text = lblMensajes.Text + "\r\nCliente: (@" + DateTime.Now.ToString() + ")\r\n" + data + "\r\n";
                    btnConectar.Enabled = false;
                    btnDesconectar.Enabled = true;
                    txtDato.Focus();
                }
                catch (SocketException se)
                {
                    MessageBox.Show("Error al conectar cliente.\r\n" + se.ToString());
                }
            }
            else
                MessageBox.Show("Ip invalida");
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Desconectar();

                if (btnConectar.Enabled == false)
                {
                    btnConectar.Enabled = true;
                    btnDesconectar.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Error al reconectar");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "")
            {
                try
                {
                    if (cliente != null)
                    {
                        byte[] bytes = Encoding.GetEncoding("ISO-8859-1").GetBytes(txtDato.Text);
                        cliente.Enviar(bytes);
                        string str = "";
                        str = "\r\nCliente dice: (@" + DateTime.Now.ToString() + ")\r\n" + txtDato.Text;

                        lblMensajes.Text = lblMensajes.Text + str + "\r\n";
                        txtDato.Clear();
                    }
                }
                catch (SocketException se)
                {
                    MessageBox.Show("Enviando error cliente!\r\n" + se.Message);
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

        public void UpdateText(string text)//Cambiar textbox
        {
            if (this.lblMensajes.InvokeRequired)
            {
                UpdateTextCallback temp = new UpdateTextCallback(UpdateText);
                this.Invoke(temp, new object[] { text });
            }
            else
            {
                string str = "";
                str = "\r\nServer said: (@" + DateTime.Now.ToString() + ")\r\n" + text;
                lblMensajes.Text = lblMensajes.Text + str;
            }
        }

        private bool IsValidIPAddress(string ipaddr)//Validar direccion ip
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

        private void Reconnect()//Reconectar
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

        private void Chat_Cliente_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(76, 175, 80);
            lblMensajes.ForeColor = Color.White;
        }
    }

    public class KeyValuePair
    {
        public Socket socket;
        public byte[] dataBuffer = new byte[1];
    }
}