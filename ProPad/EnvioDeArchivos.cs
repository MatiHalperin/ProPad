using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ProPad
{
    public partial class EnvioDeArchivos : Form
    {
        IPEndPoint end;

        public EnvioDeArchivos()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
                txtArchivo.Text = ofd.FileName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblEstado.Text = Cliente.MensajeActual;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtArchivo.Text != "" && txtIP.Text != "")
                try
                {
                    end = new IPEndPoint(IPAddress.Parse(txtIP.Text), 2014);
                    Cliente.SendFile(txtArchivo.Text, end);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            else
                MessageBox.Show("Por favor complete los campos");
        }

        private void EnvioDeArchivos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cliente.MensajeActual = "Esperando...";
        }
    }
}
