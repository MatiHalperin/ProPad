using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ProPad
{
    public partial class frmProPad : Form
    {
        Color Verde = Color.FromArgb(76, 175, 80);
        Color VerdeClaro = Color.FromArgb(165, 214, 167);
        Color VerdeOscuro = Color.FromArgb(46, 125, 50);

        int checkPrint;

        string NombreArchivo;

        public frmProPad()
        {
            InitializeComponent();

            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void frmProPad_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Width + 200;

            foreach (Control x in this.Controls)
                if (x.GetType() != typeof(ComboBox) && x.Name.IndexOf("Separador") == -1)
                    x.BackColor = Verde;

            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            contextMenuStrip1.BackColor = pictureBox1.BackColor;

            richTextBox1.Font = new Font("Calibri", 11);

            richTextBox1.SelectionIndent = 110;
            richTextBox1.SelectionRightIndent = 110;

            this.BackColor = VerdeClaro;

            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Height = this.ClientSize.Height - pictureBox1.Bottom - 30;

            InstalledFontCollection InstalledFonts = new InstalledFontCollection();

            foreach (FontFamily fnt in InstalledFonts.Families)
                cmbFuente.Items.Add(fnt.Name);

            cmbFuente.SelectedIndex = cmbFuente.Items.IndexOf("Calibri");
            cmbTamañoFuente.SelectedIndex = 3;

            richTextBox1.Modified = false;
        }

        private void frmProPad_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Height = this.ClientSize.Height - pictureBox1.Bottom - 30;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.Text == "ProPad")
            {
                SaveFileDialog Guardar = new SaveFileDialog();

                Guardar.DefaultExt = "*.rtf";
                Guardar.Filter = "Formato RTF|*.rtf|Documento de texto|*.txt|Todos los arhivos|*.";

                if (Guardar.ShowDialog() == DialogResult.OK && Guardar.FileName.Length > 0)
                {
                    if (Guardar.FilterIndex == 0)
                        richTextBox1.SaveFile(Guardar.FileName, RichTextBoxStreamType.RichText);
                    else
                        richTextBox1.SaveFile(Guardar.FileName, RichTextBoxStreamType.UnicodePlainText);

                    richTextBox1.Modified = false;

                    NombreArchivo = Guardar.FileName;
                    this.Text = Guardar.FileName;
                }
            }
            else
            {
                richTextBox1.SaveFile(NombreArchivo);
                richTextBox1.Modified = false;
                MessageBox.Show("Guardado correctamente");
            }

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();

            Abrir.DefaultExt = "*.rtf";
            Abrir.Filter = "Formato RTF|*.rtf|Documento de texto|*.txt|Todos los arhivos|*.";

            if (Abrir.ShowDialog() == System.Windows.Forms.DialogResult.OK && Abrir.FileName.Length > 0)
                richTextBox1.LoadFile(Abrir.FileName, RichTextBoxStreamType.RichText);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                DialogResult resultado = MessageBox.Show("¿Desea ver una vista previa de como va a quedar?", "Imprimir", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    printPreviewDialog1.ShowDialog();

                    if (printDialog1.ShowDialog() == DialogResult.OK)
                        printDocument1.Print();
                }
                else if (resultado == DialogResult.No)
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                        printDocument1.Print();
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            checkPrint = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            checkPrint = richTextBox1.Print(checkPrint, richTextBox1.TextLength, e);

            if (checkPrint < richTextBox1.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            EspacioDePortapapeles.Accion = 'V';
            EspacioDePortapapeles.EspacioAPegar = 0;
            new Portapapeles().ShowDialog();
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            EspacioDePortapapeles.Accion = 'C';
            EspacioDePortapapeles.EspacioAPegar = 0;
            new Portapapeles().ShowDialog();
        }

        private void cmbTamañoFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionFont = new Font(cmbFuente.SelectedItem.ToString(), Convert.ToInt32(cmbTamañoFuente.SelectedItem), richTextBox1.Font.Style);
            }
            catch
            {
                MessageBox.Show("No es posible usar esa combinación de fuente, tamaño y estilo");
            }
        }

        private void cmbFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionFont = new Font(cmbFuente.SelectedItem.ToString(), richTextBox1.SelectionFont.Size, richTextBox1.Font.Style);
            }
            catch
            {
                MessageBox.Show("No es posible usar esa combinación de fuente, tamaño y estilo");
            }
        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x.Name.Contains("Formato") && !x.Name.Contains("Viñetas"))
                    x.BackColor = Verde;

            if (richTextBox1.SelectionFont.Bold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
                btnFormatoNegrita.BackColor = Verde;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
                btnFormatoNegrita.BackColor = VerdeOscuro;
            }

            richTextBox1.Focus();
        }

        private void btnItalica_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x.Name.Contains("Formato") && !x.Name.Contains("Viñetas"))
                    x.BackColor = Verde;

            if (richTextBox1.SelectionFont.Italic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
                btnFormatoItalica.BackColor = Verde;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
                btnFormatoItalica.BackColor = VerdeOscuro;
            }

            richTextBox1.Focus();
        }

        private void btnSubrayado_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x.Name.Contains("Formato") && !x.Name.Contains("Viñetas"))
                    x.BackColor = Verde;

            if (richTextBox1.SelectionFont.Underline)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
                btnFormatoSubrayado.BackColor = Verde;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
                btnFormatoSubrayado.BackColor = VerdeOscuro;
            }

            richTextBox1.Focus();
        }

        private void btnTachado_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x.Name.Contains("Formato") && !x.Name.Contains("Viñetas"))
                    x.BackColor = Verde;

            if (richTextBox1.SelectionFont.Strikeout)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
                btnFormatoTachado.BackColor = Verde;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout);
                btnFormatoTachado.BackColor = VerdeOscuro;
            }

            richTextBox1.Focus();
        }

        private void btnResaltado_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionBackColor = colorDialog1.Color;

            richTextBox1.Focus();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;

            richTextBox1.Focus();
        }

        private void btnViñetas_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;

            if (richTextBox1.SelectionBullet)
                btnFormatoViñetas.BackColor = VerdeOscuro;

            else
                btnFormatoViñetas.BackColor = Verde;

            richTextBox1.Focus();
        }

        private void btnAlineacionIzquierda_Click(object sender, EventArgs e)
        {
            btnAlineacionIzquierda.BackColor = VerdeOscuro;
            btnAlineacionCentro.BackColor = Verde;
            btnAlineacionDerecha.BackColor = Verde;

            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

            richTextBox1.Focus();
        }

        private void btnAlineacionCentro_Click(object sender, EventArgs e)
        {
            if (btnAlineacionCentro.BackColor == Verde)
            {
                btnAlineacionCentro.BackColor = VerdeOscuro;
                btnAlineacionIzquierda.BackColor = Verde;
                btnAlineacionDerecha.BackColor = Verde;

                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }

            richTextBox1.Focus();
        }

        private void btnAlineacionDerecha_Click(object sender, EventArgs e)
        {
            if (btnAlineacionDerecha.BackColor == Verde)
            {
                btnAlineacionDerecha.BackColor = VerdeOscuro;
                btnAlineacionIzquierda.BackColor = Verde;
                btnAlineacionCentro.BackColor = Verde;

                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }

            richTextBox1.Focus();
        }

        private void btnInsertarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog RutaDeImagen = new OpenFileDialog();
            RutaDeImagen.Filter = "Archivos de imagen (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg*.png";
            RutaDeImagen.Title = "Elija la ruta de la imagen";

            if (RutaDeImagen.ShowDialog() == DialogResult.OK)
            {
                IDataObject ContenidoPortapapeles = Clipboard.GetDataObject();
                Clipboard.Clear();

                Clipboard.SetImage(Image.FromFile(RutaDeImagen.FileName));
                richTextBox1.Paste();

                Clipboard.Clear();
                Clipboard.SetDataObject(ContenidoPortapapeles);

                ContenidoPortapapeles = null;
            }
        }

        private void btnCompartir_Click(object sender, EventArgs e)
        {
            new EnvioDeArchivos().ShowDialog();
        }

        private void btnRecibirArhivo_Click(object sender, EventArgs e)
        {
            new RecibirArchivos().ShowDialog();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            new MensajeChat().ShowDialog();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCortar.PerformClick();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCopiar.PerformClick();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPegar.PerformClick();
        }

        private void insertarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnInsertarImagen.PerformClick();
        }

        private void estiloDeTextoToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            negritaToolStripMenuItem.BackColor = btnFormatoNegrita.BackColor;
            italicaToolStripMenuItem.BackColor = btnFormatoItalica.BackColor;
            subrayadoToolStripMenuItem.BackColor = btnFormatoSubrayado.BackColor;
            tachadoToolStripMenuItem.BackColor = btnFormatoTachado.BackColor;
            resaltadoToolStripMenuItem.BackColor = btnFormatoResaltado.BackColor;
            colorDeTextoToolStripMenuItem.BackColor = btnFormatoColor.BackColor;
        }

        private void alineaciónDelTextoToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            izquierdaToolStripMenuItem.BackColor = btnAlineacionIzquierda.BackColor;
            centroToolStripMenuItem.BackColor = btnAlineacionCentro.BackColor;
            derechaToolStripMenuItem.BackColor = btnAlineacionDerecha.BackColor;
        }

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFormatoNegrita.PerformClick();
        }

        private void itálicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFormatoItalica.PerformClick();
        }

        private void subrayadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFormatoSubrayado.PerformClick();
        }

        private void tachadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFormatoTachado.PerformClick();
        }

        private void resaltadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFormatoResaltado.PerformClick();
        }

        private void colorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFormatoColor.PerformClick();
        }

        private void izquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAlineacionIzquierda.PerformClick();
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAlineacionCentro.PerformClick();
        }

        private void derechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAlineacionDerecha.PerformClick();
        }

        private void frmProPad_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Salir = MessageBox.Show("¿Desea cerrar el programa? \n En caso de elegir no, el programa permanecera corriendo en segundo plano", "ProPad", MessageBoxButtons.YesNoCancel);

            switch (Salir)
            {
                case DialogResult.Yes:
                    if (richTextBox1.Modified)
                    {
                        DialogResult Guardar = MessageBox.Show("¿Desea guardar los cambios?", "ProPad", MessageBoxButtons.YesNoCancel);

                        switch (Guardar)
                        {
                            case DialogResult.Yes:
                                btnGuardar.PerformClick();
                                break;
                            case DialogResult.Cancel:
                                e.Cancel = true;
                                break;
                        }
                    }
                    break;
                case DialogResult.No:
                    notifyIcon1.Icon = this.Icon;
                    notifyIcon1.Text = Application.ProductName;
                    notifyIcon1.Visible = true;
                    this.Visible = false;
                    e.Cancel = true;
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void frmProPad_Activated(object sender, EventArgs e)
        {
            if (EspacioDePortapapeles.Accion == 'C')
            {
                switch (EspacioDePortapapeles.EspacioAPegar)
                {
                    case 1:
                        EspacioDePortapapeles.Espacio1 = richTextBox1.SelectedRtf;
                        break;
                    case 2:
                        EspacioDePortapapeles.Espacio2 = richTextBox1.SelectedRtf;
                        break;
                    case 3:
                        EspacioDePortapapeles.Espacio3 = richTextBox1.SelectedRtf;
                        break;
                    case 4:
                        EspacioDePortapapeles.Espacio4 = richTextBox1.SelectedRtf;
                        break;
                    case 5:
                        EspacioDePortapapeles.Espacio5 = richTextBox1.SelectedRtf;
                        break;
                }
            }
            else if (EspacioDePortapapeles.Accion == 'V')
            {
                switch (EspacioDePortapapeles.EspacioAPegar)
                {
                    case 1:
                        richTextBox1.SelectedRtf = EspacioDePortapapeles.Espacio1;
                        break;
                    case 2:
                        richTextBox1.SelectedRtf = EspacioDePortapapeles.Espacio2;
                        break;
                    case 3:
                        richTextBox1.SelectedRtf = EspacioDePortapapeles.Espacio3;
                        break;
                    case 4:
                        richTextBox1.SelectedRtf = EspacioDePortapapeles.Espacio4;
                        break;
                    case 5:
                        richTextBox1.SelectedRtf = EspacioDePortapapeles.Espacio5;
                        break;
                }
            }

            EspacioDePortapapeles.Accion = 'X';
            EspacioDePortapapeles.EspacioAPegar = 0;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            Activate();
            notifyIcon1.Visible = false;
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                btnAbrir.PerformClick();

            else if (e.Control && e.KeyCode == Keys.E)
                richTextBox1.SelectAll();

            else if (e.Control && e.KeyCode == Keys.G)
                btnGuardar.PerformClick();

            else if (e.Control && e.KeyCode == Keys.I)
                btnFormatoItalica.PerformClick();

            else if (e.Control && e.KeyCode == Keys.N)
                btnFormatoNegrita.PerformClick();

            else if (e.Control && e.KeyCode == Keys.S)
                btnFormatoSubrayado.PerformClick();

            else if (e.Control && e.KeyCode == Keys.T)
                btnFormatoTachado.PerformClick();

            else if (e.Control && e.KeyCode == Keys.X)
                richTextBox1.Cut();

            else if (e.Control && e.KeyCode == Keys.Left)
                btnAlineacionIzquierda.PerformClick();

            else if (e.Control && e.KeyCode == Keys.Down)
                btnAlineacionCentro.PerformClick();

            else if (e.Control && e.KeyCode == Keys.Right)
                btnAlineacionDerecha.PerformClick();

            else if (e.Control && e.Alt && e.KeyCode == Keys.D1)
                EspacioDePortapapeles.Espacio1 = richTextBox1.SelectedRtf;

            else if (e.Control && e.Alt && e.KeyCode == Keys.D2)
                EspacioDePortapapeles.Espacio2 = richTextBox1.SelectedRtf;

            else if (e.Control && e.Alt && e.KeyCode == Keys.D3)
                EspacioDePortapapeles.Espacio3 = richTextBox1.SelectedRtf;

            else if (e.Control && e.Alt && e.KeyCode == Keys.D4)
                EspacioDePortapapeles.Espacio4 = richTextBox1.SelectedRtf;

            else if (e.Control && e.Alt && e.KeyCode == Keys.D5)
                EspacioDePortapapeles.Espacio5 = richTextBox1.SelectedRtf;

            else if (e.Control && e.Shift && e.KeyCode == Keys.D1)
                richTextBox1.SelectedRtf = EspacioDePortapapeles.Espacio1;

            else if (e.Control && e.Shift && e.KeyCode == Keys.D2)
                richTextBox1.SelectedRtf = EspacioDePortapapeles.Espacio2;

            else if (e.Control && e.Shift && e.KeyCode == Keys.D3)
                richTextBox1.SelectedRtf = EspacioDePortapapeles.Espacio3;

            else if (e.Control && e.Shift && e.KeyCode == Keys.D4)
                richTextBox1.SelectedRtf = EspacioDePortapapeles.Espacio4;

            else if (e.Control && e.Shift && e.KeyCode == Keys.D5)
                richTextBox1.SelectedRtf = EspacioDePortapapeles.Espacio5;

            else if (e.Control && e.Alt && e.KeyCode == Keys.C)
            {
                EspacioDePortapapeles.Accion = 'C';
                new Portapapeles().ShowDialog();
            }

            else if (e.Control && e.Shift && e.KeyCode == Keys.V)
            {
                EspacioDePortapapeles.Accion = 'V';
                new Portapapeles().ShowDialog();
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            btnFormatoNegrita.BackColor = Verde;
            btnFormatoItalica.BackColor = Verde;
            btnFormatoSubrayado.BackColor = Verde;
            btnFormatoTachado.BackColor = Verde;
            btnFormatoViñetas.BackColor = Verde;

            try
            {
                if (richTextBox1.SelectionFont.Bold)
                    btnFormatoNegrita.BackColor = VerdeOscuro;

                else if (richTextBox1.SelectionFont.Italic)
                    btnFormatoItalica.BackColor = VerdeOscuro;

                else if (richTextBox1.SelectionFont.Underline)
                    btnFormatoSubrayado.BackColor = VerdeOscuro;

                else if (richTextBox1.SelectionFont.Strikeout)
                    btnFormatoTachado.BackColor = VerdeOscuro;

                if (richTextBox1.SelectionAlignment == HorizontalAlignment.Left)
                {
                    btnAlineacionIzquierda.BackColor = VerdeOscuro;
                    btnAlineacionCentro.BackColor = Verde;
                    btnAlineacionDerecha.BackColor = Verde;
                }
                else if (richTextBox1.SelectionAlignment == HorizontalAlignment.Center)
                {
                    btnAlineacionCentro.BackColor = VerdeOscuro;
                    btnAlineacionIzquierda.BackColor = Verde;
                    btnAlineacionDerecha.BackColor = Verde;
                }
                else if (richTextBox1.SelectionAlignment == HorizontalAlignment.Right)
                {
                    btnAlineacionDerecha.BackColor = VerdeOscuro;
                    btnAlineacionIzquierda.BackColor = Verde;
                    btnAlineacionDerecha.BackColor = Verde;
                }

                if (richTextBox1.SelectionBullet)
                    btnFormatoViñetas.BackColor = VerdeOscuro;
            }
            catch { }

            richTextBox1.Focus();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Form Navegador = new Form();
            Navegador.WindowState = FormWindowState.Maximized;
            Navegador.Text = e.LinkText;

            WebBrowser WebBrowser = new WebBrowser();
            WebBrowser.ScriptErrorsSuppressed = true;
            WebBrowser.Parent = Navegador;
            WebBrowser.Dock = DockStyle.Fill;
            WebBrowser.Navigate(e.LinkText);

            Navegador.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.Width.ToString());
        }
    }
}