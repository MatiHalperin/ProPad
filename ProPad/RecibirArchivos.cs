using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ProPad
{
    public partial class RecibirArchivos : Form
    {
        Servidor server = new Servidor();
        string IP;

        public RecibirArchivos()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblEstado.Text = Servidor.MensajeActual;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            server.StartServer();
        }

        private void RecibirArchivos_Load(object sender, EventArgs e)
        {
            lblIP.Text = GetLocalIP();
            backgroundWorker1.RunWorkerAsync();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    IP = ip.ToString();

            return IP;
        }

        private void RecibirArchivos_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Desconectar();
        }
    }
}
