using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProPad
{
    public partial class Portapapeles : Form
    {
        bool EstadoCheckbox1 = false, EstadoCheckbox2 = false, EstadoCheckbox3 = false, EstadoCheckbox4 = false, EstadoCheckbox5 = false;
        bool Eliminando;

        public Portapapeles()
        {
            InitializeComponent();
        }

        private void Portapapeles_Load(object sender, EventArgs e)
        {
            btnCancelar.Hide();
            lblCancelar.Hide();
            btnSeleccionarTodo.Hide();
            lblSeleccionarTodo.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!Eliminando)
            {
                Eliminando = true;

                btnCancelar.Show();
                lblCancelar.Show();
                btnSeleccionarTodo.Show();
                lblSeleccionarTodo.Show();

                btnAccion1.Image = Image.FromFile("Iconos/Checkbox_Unchecked.png");
                btnAccion2.Image = Image.FromFile("Iconos/Checkbox_Unchecked.png");
                btnAccion3.Image = Image.FromFile("Iconos/Checkbox_Unchecked.png");
                btnAccion4.Image = Image.FromFile("Iconos/Checkbox_Unchecked.png");
                btnAccion5.Image = Image.FromFile("Iconos/Checkbox_Unchecked.png");
            }
            else
            {
                if (EstadoCheckbox1)
                    EspacioDePortapapeles.Espacio1 = "";
                if (EstadoCheckbox2)
                    EspacioDePortapapeles.Espacio2 = "";
                if (EstadoCheckbox3)
                    EspacioDePortapapeles.Espacio3 = "";
                if (EstadoCheckbox4)
                    EspacioDePortapapeles.Espacio4 = "";
                if (EstadoCheckbox5)
                    EspacioDePortapapeles.Espacio5 = "";

                btnCancelar.PerformClick();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Eliminando = false;

            btnCancelar.Hide();
            lblCancelar.Hide();
            btnSeleccionarTodo.Hide();
            lblSeleccionarTodo.Hide();

            btnAccion1.Image = Image.FromFile("Iconos/Ver.png");
            btnAccion2.Image = Image.FromFile("Iconos/Ver.png");
            btnAccion3.Image = Image.FromFile("Iconos/Ver.png");
            btnAccion4.Image = Image.FromFile("Iconos/Ver.png");
            btnAccion5.Image = Image.FromFile("Iconos/Ver.png");
        }

        private void Checkbox_Click(Button btnCheckbox, bool Checkeado)
        {
            if (!Checkeado)
            {
                btnCheckbox.Image = Image.FromFile("Iconos/Chechbox_Checked.png");
            }
            else if (Checkeado)
            {
                btnCheckbox.Image = Image.FromFile("Iconos/Checkbox_Unchecked.png");
            }
        }

        private void btnSeleccionarTodo_Click(object sender, EventArgs e)
        {
            EstadoCheckbox1 = EstadoCheckbox2 = EstadoCheckbox3 = EstadoCheckbox4 = EstadoCheckbox5 = true;
            btnAccion1.Image = Image.FromFile("Iconos/Chechbox_Checked.png");
            btnAccion2.Image = Image.FromFile("Iconos/Chechbox_Checked.png");
            btnAccion3.Image = Image.FromFile("Iconos/Chechbox_Checked.png");
            btnAccion4.Image = Image.FromFile("Iconos/Chechbox_Checked.png");
            btnAccion5.Image = Image.FromFile("Iconos/Chechbox_Checked.png");
        }

        private void lblLugar1_Click(object sender, EventArgs e)
        {
            EspacioDePortapapeles.EspacioAPegar = 1;
            this.Close();
        }

        private void lblLugar2_Click(object sender, EventArgs e)
        {
            EspacioDePortapapeles.EspacioAPegar = 2;
            this.Close();
        }

        private void lblLugar3_Click(object sender, EventArgs e)
        {
            EspacioDePortapapeles.EspacioAPegar = 3;
            this.Close();
        }

        private void lblLugar4_Click(object sender, EventArgs e)
        {
            EspacioDePortapapeles.EspacioAPegar = 4;
            this.Close();
        }

        private void lblLugar5_Click(object sender, EventArgs e)
        {
            EspacioDePortapapeles.EspacioAPegar = 5;
            this.Close();
        }

        private void Ver(string Contenido)
        {
            Form frmVer = new Form();
            RichTextBox rtbVer = new RichTextBox();
            frmVer.Controls.Add(rtbVer);
            rtbVer.SelectedRtf = Contenido;
            rtbVer.Enabled = false;
            rtbVer.Dock = DockStyle.Fill;
            frmVer.ShowDialog();
        }

        private void btnAccion1_Click(object sender, EventArgs e)
        {
            if (Eliminando)
            {
                Checkbox_Click(btnAccion1, EstadoCheckbox1);
                EstadoCheckbox1 = !EstadoCheckbox1;
            }
            else
                Ver(EspacioDePortapapeles.Espacio1);
        }

        private void btnAccion2_Click(object sender, EventArgs e)
        {
            if (Eliminando)
            {
                Checkbox_Click(btnAccion2, EstadoCheckbox2);
                EstadoCheckbox2 = !EstadoCheckbox2;
            }
            else
                Ver(EspacioDePortapapeles.Espacio2);
        }

        private void btnAccion3_Click(object sender, EventArgs e)
        {
            if (Eliminando)
            {
                Checkbox_Click(btnAccion3, EstadoCheckbox3);
                EstadoCheckbox3 = !EstadoCheckbox3;
            }
            else
                Ver(EspacioDePortapapeles.Espacio3);
        }

        private void btnAccion4_Click(object sender, EventArgs e)
        {
            if (Eliminando)
            {
                Checkbox_Click(btnAccion4, EstadoCheckbox4);
                EstadoCheckbox4 = !EstadoCheckbox4;
            }
            else
                Ver(EspacioDePortapapeles.Espacio4);
        }

        private void btnAccion5_Click(object sender, EventArgs e)
        {
            if (Eliminando)
            {
                Checkbox_Click(btnAccion5, EstadoCheckbox5);
                EstadoCheckbox5 = !EstadoCheckbox5;
            }
            else
                Ver(EspacioDePortapapeles.Espacio5);
        }
    }
}