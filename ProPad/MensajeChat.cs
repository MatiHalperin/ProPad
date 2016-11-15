using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProPad
{
    public partial class MensajeChat : Form
    {
        public MensajeChat()
        {
            InitializeComponent();
        }

        private void btnExistente_Click(object sender, EventArgs e)
        {
            new Chat_Cliente().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Chat_Servidor().Show();
        }
    }
}