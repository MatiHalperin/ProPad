namespace ProPad
{
    partial class frmProPad
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProPad));
            this.lblPegar = new System.Windows.Forms.Label();
            this.lblCortar = new System.Windows.Forms.Label();
            this.lblCopiar = new System.Windows.Forms.Label();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.lblAbrir = new System.Windows.Forms.Label();
            this.lblImprimir = new System.Windows.Forms.Label();
            this.cmbFuente = new System.Windows.Forms.ComboBox();
            this.cmbTamañoFuente = new System.Windows.Forms.ComboBox();
            this.lblInsertarImagen = new System.Windows.Forms.Label();
            this.lblCompartir = new System.Windows.Forms.Label();
            this.lblRecibirArhivo = new System.Windows.Forms.Label();
            this.lblChat = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.insertarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.estiloDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subrayadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tachadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resaltadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alineaciónDelTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new RichTextBoxPrintCtrl.RichTextBoxPrintCtrl();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Separador6 = new System.Windows.Forms.PictureBox();
            this.Separador5 = new System.Windows.Forms.PictureBox();
            this.Separador4 = new System.Windows.Forms.PictureBox();
            this.Separador3 = new System.Windows.Forms.PictureBox();
            this.Separador2 = new System.Windows.Forms.PictureBox();
            this.Separador1 = new System.Windows.Forms.PictureBox();
            this.btnFormatoResaltado = new System.Windows.Forms.Button();
            this.btnFormatoViñetas = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnFormatoColor = new System.Windows.Forms.Button();
            this.btnRecibirArhivo = new System.Windows.Forms.Button();
            this.btnCompartir = new System.Windows.Forms.Button();
            this.btnInsertarImagen = new System.Windows.Forms.Button();
            this.btnAlineacionDerecha = new System.Windows.Forms.Button();
            this.btnAlineacionCentro = new System.Windows.Forms.Button();
            this.btnAlineacionIzquierda = new System.Windows.Forms.Button();
            this.btnFormatoTachado = new System.Windows.Forms.Button();
            this.btnFormatoSubrayado = new System.Windows.Forms.Button();
            this.btnFormatoItalica = new System.Windows.Forms.Button();
            this.btnFormatoNegrita = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnCortar = new System.Windows.Forms.Button();
            this.btnPegar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Separador6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPegar
            // 
            this.lblPegar.AutoSize = true;
            this.lblPegar.ForeColor = System.Drawing.Color.White;
            this.lblPegar.Location = new System.Drawing.Point(234, 71);
            this.lblPegar.Name = "lblPegar";
            this.lblPegar.Size = new System.Drawing.Size(76, 13);
            this.lblPegar.TabIndex = 1;
            this.lblPegar.Text = "Pegar desde...";
            // 
            // lblCortar
            // 
            this.lblCortar.AutoSize = true;
            this.lblCortar.ForeColor = System.Drawing.Color.White;
            this.lblCortar.Location = new System.Drawing.Point(338, 20);
            this.lblCortar.Name = "lblCortar";
            this.lblCortar.Size = new System.Drawing.Size(35, 13);
            this.lblCortar.TabIndex = 4;
            this.lblCortar.Text = "Cortar";
            // 
            // lblCopiar
            // 
            this.lblCopiar.AutoSize = true;
            this.lblCopiar.ForeColor = System.Drawing.Color.White;
            this.lblCopiar.Location = new System.Drawing.Point(337, 51);
            this.lblCopiar.Name = "lblCopiar";
            this.lblCopiar.Size = new System.Drawing.Size(55, 13);
            this.lblCopiar.TabIndex = 5;
            this.lblCopiar.Text = "Copiar a...";
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.ForeColor = System.Drawing.Color.White;
            this.lblGuardar.Location = new System.Drawing.Point(18, 71);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(45, 13);
            this.lblGuardar.TabIndex = 7;
            this.lblGuardar.Text = "Guardar";
            // 
            // lblAbrir
            // 
            this.lblAbrir.AutoSize = true;
            this.lblAbrir.ForeColor = System.Drawing.Color.White;
            this.lblAbrir.Location = new System.Drawing.Point(90, 71);
            this.lblAbrir.Name = "lblAbrir";
            this.lblAbrir.Size = new System.Drawing.Size(28, 13);
            this.lblAbrir.TabIndex = 9;
            this.lblAbrir.Text = "Abrir";
            // 
            // lblImprimir
            // 
            this.lblImprimir.AutoSize = true;
            this.lblImprimir.ForeColor = System.Drawing.Color.White;
            this.lblImprimir.Location = new System.Drawing.Point(146, 71);
            this.lblImprimir.Name = "lblImprimir";
            this.lblImprimir.Size = new System.Drawing.Size(42, 13);
            this.lblImprimir.TabIndex = 11;
            this.lblImprimir.Text = "Imprimir";
            // 
            // cmbFuente
            // 
            this.cmbFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFuente.FormattingEnabled = true;
            this.cmbFuente.Location = new System.Drawing.Point(410, 16);
            this.cmbFuente.Name = "cmbFuente";
            this.cmbFuente.Size = new System.Drawing.Size(166, 21);
            this.cmbFuente.TabIndex = 12;
            this.cmbFuente.SelectedIndexChanged += new System.EventHandler(this.cmbFuente_SelectedIndexChanged);
            // 
            // cmbTamañoFuente
            // 
            this.cmbTamañoFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamañoFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTamañoFuente.FormattingEnabled = true;
            this.cmbTamañoFuente.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cmbTamañoFuente.Location = new System.Drawing.Point(582, 16);
            this.cmbTamañoFuente.Name = "cmbTamañoFuente";
            this.cmbTamañoFuente.Size = new System.Drawing.Size(38, 21);
            this.cmbTamañoFuente.TabIndex = 13;
            this.cmbTamañoFuente.SelectedIndexChanged += new System.EventHandler(this.cmbTamañoFuente_SelectedIndexChanged);
            // 
            // lblInsertarImagen
            // 
            this.lblInsertarImagen.AutoSize = true;
            this.lblInsertarImagen.ForeColor = System.Drawing.Color.White;
            this.lblInsertarImagen.Location = new System.Drawing.Point(866, 71);
            this.lblInsertarImagen.Name = "lblInsertarImagen";
            this.lblInsertarImagen.Size = new System.Drawing.Size(79, 13);
            this.lblInsertarImagen.TabIndex = 22;
            this.lblInsertarImagen.Text = "Insertar imagen";
            // 
            // lblCompartir
            // 
            this.lblCompartir.AutoSize = true;
            this.lblCompartir.ForeColor = System.Drawing.Color.White;
            this.lblCompartir.Location = new System.Drawing.Point(976, 71);
            this.lblCompartir.Name = "lblCompartir";
            this.lblCompartir.Size = new System.Drawing.Size(51, 13);
            this.lblCompartir.TabIndex = 24;
            this.lblCompartir.Text = "Compartir";
            // 
            // lblRecibirArhivo
            // 
            this.lblRecibirArhivo.AutoSize = true;
            this.lblRecibirArhivo.ForeColor = System.Drawing.Color.White;
            this.lblRecibirArhivo.Location = new System.Drawing.Point(1032, 71);
            this.lblRecibirArhivo.Name = "lblRecibirArhivo";
            this.lblRecibirArhivo.Size = new System.Drawing.Size(78, 13);
            this.lblRecibirArhivo.TabIndex = 26;
            this.lblRecibirArhivo.Text = "Recibir archivo";
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.ForeColor = System.Drawing.Color.White;
            this.lblChat.Location = new System.Drawing.Point(1140, 71);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(72, 13);
            this.lblChat.TabIndex = 41;
            this.lblChat.Text = "Chat personal";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.insertarImagenToolStripMenuItem,
            this.toolStripMenuItem2,
            this.estiloDeTextoToolStripMenuItem,
            this.alineaciónDelTextoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 148);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cortarToolStripMenuItem.Image = global::ProPad.Properties.Resources.Menu_Cortar;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.copiarToolStripMenuItem.Image = global::ProPad.Properties.Resources.Menu_Copiar;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.copiarToolStripMenuItem.Text = "Copiar a..";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pegarToolStripMenuItem.Image = global::ProPad.Properties.Resources.Menu_Pegar;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pegarToolStripMenuItem.Text = "Pegar desde...";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // insertarImagenToolStripMenuItem
            // 
            this.insertarImagenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.insertarImagenToolStripMenuItem.Image = global::ProPad.Properties.Resources.Menu_Imagen;
            this.insertarImagenToolStripMenuItem.Name = "insertarImagenToolStripMenuItem";
            this.insertarImagenToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.insertarImagenToolStripMenuItem.Text = "Insertar imagen";
            this.insertarImagenToolStripMenuItem.Click += new System.EventHandler(this.insertarImagenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(175, 6);
            // 
            // estiloDeTextoToolStripMenuItem
            // 
            this.estiloDeTextoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritaToolStripMenuItem,
            this.italicaToolStripMenuItem,
            this.subrayadoToolStripMenuItem,
            this.tachadoToolStripMenuItem,
            this.resaltadoToolStripMenuItem,
            this.colorDeTextoToolStripMenuItem});
            this.estiloDeTextoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.estiloDeTextoToolStripMenuItem.Image = global::ProPad.Properties.Resources.Menu_EstiloDeTexto;
            this.estiloDeTextoToolStripMenuItem.Name = "estiloDeTextoToolStripMenuItem";
            this.estiloDeTextoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.estiloDeTextoToolStripMenuItem.Text = "Estilo de texto";
            this.estiloDeTextoToolStripMenuItem.MouseEnter += new System.EventHandler(this.estiloDeTextoToolStripMenuItem_MouseEnter);
            // 
            // negritaToolStripMenuItem
            // 
            this.negritaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.negritaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.negritaToolStripMenuItem.Image = global::ProPad.Properties.Resources.Negrita;
            this.negritaToolStripMenuItem.Name = "negritaToolStripMenuItem";
            this.negritaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.negritaToolStripMenuItem.Text = "Negrita";
            this.negritaToolStripMenuItem.Click += new System.EventHandler(this.negritaToolStripMenuItem_Click);
            // 
            // italicaToolStripMenuItem
            // 
            this.italicaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.italicaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.italicaToolStripMenuItem.Image = global::ProPad.Properties.Resources.Italica;
            this.italicaToolStripMenuItem.Name = "italicaToolStripMenuItem";
            this.italicaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.italicaToolStripMenuItem.Text = "Italica";
            this.italicaToolStripMenuItem.Click += new System.EventHandler(this.itálicaToolStripMenuItem_Click);
            // 
            // subrayadoToolStripMenuItem
            // 
            this.subrayadoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.subrayadoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.subrayadoToolStripMenuItem.Image = global::ProPad.Properties.Resources.Subrayado;
            this.subrayadoToolStripMenuItem.Name = "subrayadoToolStripMenuItem";
            this.subrayadoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.subrayadoToolStripMenuItem.Text = "Subrayado";
            this.subrayadoToolStripMenuItem.Click += new System.EventHandler(this.subrayadoToolStripMenuItem_Click);
            // 
            // tachadoToolStripMenuItem
            // 
            this.tachadoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tachadoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tachadoToolStripMenuItem.Image = global::ProPad.Properties.Resources.Tachado;
            this.tachadoToolStripMenuItem.Name = "tachadoToolStripMenuItem";
            this.tachadoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.tachadoToolStripMenuItem.Text = "Tachado";
            this.tachadoToolStripMenuItem.Click += new System.EventHandler(this.tachadoToolStripMenuItem_Click);
            // 
            // resaltadoToolStripMenuItem
            // 
            this.resaltadoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.resaltadoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.resaltadoToolStripMenuItem.Image = global::ProPad.Properties.Resources.Resaltado;
            this.resaltadoToolStripMenuItem.Name = "resaltadoToolStripMenuItem";
            this.resaltadoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.resaltadoToolStripMenuItem.Text = "Resaltado";
            this.resaltadoToolStripMenuItem.Click += new System.EventHandler(this.resaltadoToolStripMenuItem_Click);
            // 
            // colorDeTextoToolStripMenuItem
            // 
            this.colorDeTextoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colorDeTextoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.colorDeTextoToolStripMenuItem.Image = global::ProPad.Properties.Resources.Color;
            this.colorDeTextoToolStripMenuItem.Name = "colorDeTextoToolStripMenuItem";
            this.colorDeTextoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.colorDeTextoToolStripMenuItem.Text = "Color de texto";
            this.colorDeTextoToolStripMenuItem.Click += new System.EventHandler(this.colorDeTextoToolStripMenuItem_Click);
            // 
            // alineaciónDelTextoToolStripMenuItem
            // 
            this.alineaciónDelTextoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izquierdaToolStripMenuItem,
            this.centroToolStripMenuItem,
            this.derechaToolStripMenuItem});
            this.alineaciónDelTextoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.alineaciónDelTextoToolStripMenuItem.Image = global::ProPad.Properties.Resources.Menu_AlineacionDeTexto;
            this.alineaciónDelTextoToolStripMenuItem.Name = "alineaciónDelTextoToolStripMenuItem";
            this.alineaciónDelTextoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.alineaciónDelTextoToolStripMenuItem.Text = "Alineación del texto";
            this.alineaciónDelTextoToolStripMenuItem.MouseEnter += new System.EventHandler(this.alineaciónDelTextoToolStripMenuItem_MouseEnter);
            // 
            // izquierdaToolStripMenuItem
            // 
            this.izquierdaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.izquierdaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.izquierdaToolStripMenuItem.Image = global::ProPad.Properties.Resources.Alineacion_Izquierda;
            this.izquierdaToolStripMenuItem.Name = "izquierdaToolStripMenuItem";
            this.izquierdaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.izquierdaToolStripMenuItem.Text = "Izquierda";
            this.izquierdaToolStripMenuItem.Click += new System.EventHandler(this.izquierdaToolStripMenuItem_Click);
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.centroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.centroToolStripMenuItem.Image = global::ProPad.Properties.Resources.Alineacion_Centro;
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.centroToolStripMenuItem.Text = "Centro";
            this.centroToolStripMenuItem.Click += new System.EventHandler(this.centroToolStripMenuItem_Click);
            // 
            // derechaToolStripMenuItem
            // 
            this.derechaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.derechaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.derechaToolStripMenuItem.Image = global::ProPad.Properties.Resources.Alineacion_Derecha;
            this.derechaToolStripMenuItem.Name = "derechaToolStripMenuItem";
            this.derechaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.derechaToolStripMenuItem.Text = "Derecha";
            this.derechaToolStripMenuItem.Click += new System.EventHandler(this.derechaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 148);
            this.panel1.TabIndex = 38;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(788, 146);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Separador6
            // 
            this.Separador6.BackColor = System.Drawing.Color.White;
            this.Separador6.Location = new System.Drawing.Point(1125, 12);
            this.Separador6.Name = "Separador6";
            this.Separador6.Size = new System.Drawing.Size(2, 70);
            this.Separador6.TabIndex = 50;
            this.Separador6.TabStop = false;
            // 
            // Separador5
            // 
            this.Separador5.BackColor = System.Drawing.Color.White;
            this.Separador5.Location = new System.Drawing.Point(957, 12);
            this.Separador5.Name = "Separador5";
            this.Separador5.Size = new System.Drawing.Size(2, 70);
            this.Separador5.TabIndex = 49;
            this.Separador5.TabStop = false;
            // 
            // Separador4
            // 
            this.Separador4.BackColor = System.Drawing.Color.White;
            this.Separador4.Location = new System.Drawing.Point(847, 12);
            this.Separador4.Name = "Separador4";
            this.Separador4.Size = new System.Drawing.Size(2, 70);
            this.Separador4.TabIndex = 48;
            this.Separador4.TabStop = false;
            // 
            // Separador3
            // 
            this.Separador3.BackColor = System.Drawing.Color.White;
            this.Separador3.Location = new System.Drawing.Point(635, 12);
            this.Separador3.Name = "Separador3";
            this.Separador3.Size = new System.Drawing.Size(2, 70);
            this.Separador3.TabIndex = 47;
            this.Separador3.TabStop = false;
            // 
            // Separador2
            // 
            this.Separador2.BackColor = System.Drawing.Color.White;
            this.Separador2.Location = new System.Drawing.Point(395, 12);
            this.Separador2.Name = "Separador2";
            this.Separador2.Size = new System.Drawing.Size(2, 70);
            this.Separador2.TabIndex = 46;
            this.Separador2.TabStop = false;
            // 
            // Separador1
            // 
            this.Separador1.BackColor = System.Drawing.Color.White;
            this.Separador1.Location = new System.Drawing.Point(214, 12);
            this.Separador1.Name = "Separador1";
            this.Separador1.Size = new System.Drawing.Size(2, 70);
            this.Separador1.TabIndex = 45;
            this.Separador1.TabStop = false;
            // 
            // btnFormatoResaltado
            // 
            this.btnFormatoResaltado.BackColor = System.Drawing.Color.Transparent;
            this.btnFormatoResaltado.FlatAppearance.BorderSize = 0;
            this.btnFormatoResaltado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatoResaltado.Image = global::ProPad.Properties.Resources.Resaltado;
            this.btnFormatoResaltado.Location = new System.Drawing.Point(530, 50);
            this.btnFormatoResaltado.Name = "btnFormatoResaltado";
            this.btnFormatoResaltado.Size = new System.Drawing.Size(30, 25);
            this.btnFormatoResaltado.TabIndex = 43;
            this.btnFormatoResaltado.UseVisualStyleBackColor = false;
            this.btnFormatoResaltado.Click += new System.EventHandler(this.btnResaltado_Click);
            // 
            // btnFormatoViñetas
            // 
            this.btnFormatoViñetas.BackColor = System.Drawing.Color.Transparent;
            this.btnFormatoViñetas.FlatAppearance.BorderSize = 0;
            this.btnFormatoViñetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatoViñetas.Image = global::ProPad.Properties.Resources.Viñetas;
            this.btnFormatoViñetas.Location = new System.Drawing.Point(590, 50);
            this.btnFormatoViñetas.Name = "btnFormatoViñetas";
            this.btnFormatoViñetas.Size = new System.Drawing.Size(30, 25);
            this.btnFormatoViñetas.TabIndex = 42;
            this.btnFormatoViñetas.UseVisualStyleBackColor = false;
            this.btnFormatoViñetas.Click += new System.EventHandler(this.btnViñetas_Click);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.Transparent;
            this.btnChat.FlatAppearance.BorderSize = 0;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.Image = global::ProPad.Properties.Resources.Chat;
            this.btnChat.Location = new System.Drawing.Point(1147, 10);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(56, 58);
            this.btnChat.TabIndex = 40;
            this.btnChat.UseVisualStyleBackColor = false;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnFormatoColor
            // 
            this.btnFormatoColor.BackColor = System.Drawing.Color.Transparent;
            this.btnFormatoColor.FlatAppearance.BorderSize = 0;
            this.btnFormatoColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatoColor.Image = global::ProPad.Properties.Resources.Color;
            this.btnFormatoColor.Location = new System.Drawing.Point(560, 50);
            this.btnFormatoColor.Name = "btnFormatoColor";
            this.btnFormatoColor.Size = new System.Drawing.Size(30, 25);
            this.btnFormatoColor.TabIndex = 27;
            this.btnFormatoColor.UseVisualStyleBackColor = false;
            this.btnFormatoColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnRecibirArhivo
            // 
            this.btnRecibirArhivo.BackColor = System.Drawing.Color.Transparent;
            this.btnRecibirArhivo.FlatAppearance.BorderSize = 0;
            this.btnRecibirArhivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibirArhivo.Image = global::ProPad.Properties.Resources.Recibir_archivo;
            this.btnRecibirArhivo.Location = new System.Drawing.Point(1041, 10);
            this.btnRecibirArhivo.Name = "btnRecibirArhivo";
            this.btnRecibirArhivo.Size = new System.Drawing.Size(56, 58);
            this.btnRecibirArhivo.TabIndex = 25;
            this.btnRecibirArhivo.UseVisualStyleBackColor = false;
            this.btnRecibirArhivo.Click += new System.EventHandler(this.btnRecibirArhivo_Click);
            // 
            // btnCompartir
            // 
            this.btnCompartir.BackColor = System.Drawing.Color.Transparent;
            this.btnCompartir.FlatAppearance.BorderSize = 0;
            this.btnCompartir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompartir.Image = global::ProPad.Properties.Resources.Compartir;
            this.btnCompartir.Location = new System.Drawing.Point(973, 10);
            this.btnCompartir.Name = "btnCompartir";
            this.btnCompartir.Size = new System.Drawing.Size(56, 58);
            this.btnCompartir.TabIndex = 23;
            this.btnCompartir.UseVisualStyleBackColor = false;
            this.btnCompartir.Click += new System.EventHandler(this.btnCompartir_Click);
            // 
            // btnInsertarImagen
            // 
            this.btnInsertarImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertarImagen.FlatAppearance.BorderSize = 0;
            this.btnInsertarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarImagen.Image = global::ProPad.Properties.Resources.Insertar_imagen;
            this.btnInsertarImagen.Location = new System.Drawing.Point(875, 10);
            this.btnInsertarImagen.Name = "btnInsertarImagen";
            this.btnInsertarImagen.Size = new System.Drawing.Size(56, 58);
            this.btnInsertarImagen.TabIndex = 21;
            this.btnInsertarImagen.UseVisualStyleBackColor = false;
            this.btnInsertarImagen.Click += new System.EventHandler(this.btnInsertarImagen_Click);
            // 
            // btnAlineacionDerecha
            // 
            this.btnAlineacionDerecha.BackColor = System.Drawing.Color.Transparent;
            this.btnAlineacionDerecha.FlatAppearance.BorderSize = 0;
            this.btnAlineacionDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlineacionDerecha.Image = global::ProPad.Properties.Resources.Alineacion_Derecha;
            this.btnAlineacionDerecha.Location = new System.Drawing.Point(774, 13);
            this.btnAlineacionDerecha.Name = "btnAlineacionDerecha";
            this.btnAlineacionDerecha.Size = new System.Drawing.Size(56, 58);
            this.btnAlineacionDerecha.TabIndex = 20;
            this.btnAlineacionDerecha.UseVisualStyleBackColor = false;
            this.btnAlineacionDerecha.Click += new System.EventHandler(this.btnAlineacionDerecha_Click);
            // 
            // btnAlineacionCentro
            // 
            this.btnAlineacionCentro.BackColor = System.Drawing.Color.Transparent;
            this.btnAlineacionCentro.FlatAppearance.BorderSize = 0;
            this.btnAlineacionCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlineacionCentro.Image = global::ProPad.Properties.Resources.Alineacion_Centro;
            this.btnAlineacionCentro.Location = new System.Drawing.Point(712, 13);
            this.btnAlineacionCentro.Name = "btnAlineacionCentro";
            this.btnAlineacionCentro.Size = new System.Drawing.Size(56, 58);
            this.btnAlineacionCentro.TabIndex = 19;
            this.btnAlineacionCentro.UseVisualStyleBackColor = false;
            this.btnAlineacionCentro.Click += new System.EventHandler(this.btnAlineacionCentro_Click);
            // 
            // btnAlineacionIzquierda
            // 
            this.btnAlineacionIzquierda.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAlineacionIzquierda.FlatAppearance.BorderSize = 0;
            this.btnAlineacionIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlineacionIzquierda.Image = global::ProPad.Properties.Resources.Alineacion_Izquierda;
            this.btnAlineacionIzquierda.Location = new System.Drawing.Point(650, 13);
            this.btnAlineacionIzquierda.Name = "btnAlineacionIzquierda";
            this.btnAlineacionIzquierda.Size = new System.Drawing.Size(56, 58);
            this.btnAlineacionIzquierda.TabIndex = 18;
            this.btnAlineacionIzquierda.UseVisualStyleBackColor = false;
            this.btnAlineacionIzquierda.Click += new System.EventHandler(this.btnAlineacionIzquierda_Click);
            // 
            // btnFormatoTachado
            // 
            this.btnFormatoTachado.BackColor = System.Drawing.Color.Transparent;
            this.btnFormatoTachado.FlatAppearance.BorderSize = 0;
            this.btnFormatoTachado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatoTachado.Image = global::ProPad.Properties.Resources.Tachado;
            this.btnFormatoTachado.Location = new System.Drawing.Point(500, 50);
            this.btnFormatoTachado.Name = "btnFormatoTachado";
            this.btnFormatoTachado.Size = new System.Drawing.Size(30, 25);
            this.btnFormatoTachado.TabIndex = 17;
            this.btnFormatoTachado.UseVisualStyleBackColor = false;
            this.btnFormatoTachado.Click += new System.EventHandler(this.btnTachado_Click);
            // 
            // btnFormatoSubrayado
            // 
            this.btnFormatoSubrayado.BackColor = System.Drawing.Color.Transparent;
            this.btnFormatoSubrayado.FlatAppearance.BorderSize = 0;
            this.btnFormatoSubrayado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatoSubrayado.Image = global::ProPad.Properties.Resources.Subrayado;
            this.btnFormatoSubrayado.Location = new System.Drawing.Point(470, 50);
            this.btnFormatoSubrayado.Name = "btnFormatoSubrayado";
            this.btnFormatoSubrayado.Size = new System.Drawing.Size(30, 25);
            this.btnFormatoSubrayado.TabIndex = 16;
            this.btnFormatoSubrayado.UseVisualStyleBackColor = false;
            this.btnFormatoSubrayado.Click += new System.EventHandler(this.btnSubrayado_Click);
            // 
            // btnFormatoItalica
            // 
            this.btnFormatoItalica.BackColor = System.Drawing.Color.Transparent;
            this.btnFormatoItalica.FlatAppearance.BorderSize = 0;
            this.btnFormatoItalica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatoItalica.Image = global::ProPad.Properties.Resources.Italica;
            this.btnFormatoItalica.Location = new System.Drawing.Point(440, 50);
            this.btnFormatoItalica.Name = "btnFormatoItalica";
            this.btnFormatoItalica.Size = new System.Drawing.Size(30, 25);
            this.btnFormatoItalica.TabIndex = 15;
            this.btnFormatoItalica.UseVisualStyleBackColor = false;
            this.btnFormatoItalica.Click += new System.EventHandler(this.btnItalica_Click);
            // 
            // btnFormatoNegrita
            // 
            this.btnFormatoNegrita.BackColor = System.Drawing.Color.Transparent;
            this.btnFormatoNegrita.FlatAppearance.BorderSize = 0;
            this.btnFormatoNegrita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatoNegrita.Image = global::ProPad.Properties.Resources.Negrita;
            this.btnFormatoNegrita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormatoNegrita.Location = new System.Drawing.Point(410, 50);
            this.btnFormatoNegrita.Name = "btnFormatoNegrita";
            this.btnFormatoNegrita.Size = new System.Drawing.Size(30, 25);
            this.btnFormatoNegrita.TabIndex = 14;
            this.btnFormatoNegrita.UseVisualStyleBackColor = false;
            this.btnFormatoNegrita.Click += new System.EventHandler(this.btnNegrita_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::ProPad.Properties.Resources.Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(138, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(56, 58);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Image = global::ProPad.Properties.Resources.Abrir;
            this.btnAbrir.Location = new System.Drawing.Point(76, 10);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(56, 58);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::ProPad.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(12, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 58);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.Transparent;
            this.btnCopiar.FlatAppearance.BorderSize = 0;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Image = global::ProPad.Properties.Resources.Copiar;
            this.btnCopiar.Location = new System.Drawing.Point(301, 44);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(33, 27);
            this.btnCopiar.TabIndex = 3;
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnCortar
            // 
            this.btnCortar.BackColor = System.Drawing.Color.Transparent;
            this.btnCortar.FlatAppearance.BorderSize = 0;
            this.btnCortar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCortar.Image = global::ProPad.Properties.Resources.Cortar;
            this.btnCortar.Location = new System.Drawing.Point(301, 13);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(33, 27);
            this.btnCortar.TabIndex = 2;
            this.btnCortar.UseVisualStyleBackColor = false;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // btnPegar
            // 
            this.btnPegar.BackColor = System.Drawing.Color.Transparent;
            this.btnPegar.FlatAppearance.BorderSize = 0;
            this.btnPegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPegar.Image = global::ProPad.Properties.Resources.Pegar;
            this.btnPegar.Location = new System.Drawing.Point(239, 10);
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(56, 58);
            this.btnPegar.TabIndex = 0;
            this.btnPegar.UseVisualStyleBackColor = false;
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1255, 105);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // frmProPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 261);
            this.Controls.Add(this.Separador6);
            this.Controls.Add(this.Separador5);
            this.Controls.Add(this.Separador4);
            this.Controls.Add(this.Separador3);
            this.Controls.Add(this.Separador2);
            this.Controls.Add(this.Separador1);
            this.Controls.Add(this.btnFormatoResaltado);
            this.Controls.Add(this.btnFormatoViñetas);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFormatoColor);
            this.Controls.Add(this.lblRecibirArhivo);
            this.Controls.Add(this.btnRecibirArhivo);
            this.Controls.Add(this.lblCompartir);
            this.Controls.Add(this.btnCompartir);
            this.Controls.Add(this.lblInsertarImagen);
            this.Controls.Add(this.btnInsertarImagen);
            this.Controls.Add(this.btnAlineacionDerecha);
            this.Controls.Add(this.btnAlineacionCentro);
            this.Controls.Add(this.btnAlineacionIzquierda);
            this.Controls.Add(this.btnFormatoTachado);
            this.Controls.Add(this.btnFormatoSubrayado);
            this.Controls.Add(this.btnFormatoItalica);
            this.Controls.Add(this.btnFormatoNegrita);
            this.Controls.Add(this.cmbTamañoFuente);
            this.Controls.Add(this.cmbFuente);
            this.Controls.Add(this.lblImprimir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblAbrir);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCopiar);
            this.Controls.Add(this.lblCortar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnCortar);
            this.Controls.Add(this.lblPegar);
            this.Controls.Add(this.btnPegar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProPad";
            this.Text = "ProPad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmProPad_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProPad_FormClosing);
            this.Load += new System.EventHandler(this.frmProPad_Load);
            this.Resize += new System.EventHandler(this.frmProPad_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Separador6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPegar;
        private System.Windows.Forms.Label lblPegar;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label lblCortar;
        private System.Windows.Forms.Label lblCopiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblAbrir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblImprimir;
        private System.Windows.Forms.ComboBox cmbFuente;
        private System.Windows.Forms.ComboBox cmbTamañoFuente;
        private System.Windows.Forms.Button btnFormatoNegrita;
        private System.Windows.Forms.Button btnFormatoItalica;
        private System.Windows.Forms.Button btnFormatoSubrayado;
        private System.Windows.Forms.Button btnFormatoTachado;
        private System.Windows.Forms.Button btnAlineacionIzquierda;
        private System.Windows.Forms.Button btnAlineacionCentro;
        private System.Windows.Forms.Button btnAlineacionDerecha;
        private System.Windows.Forms.Button btnInsertarImagen;
        private System.Windows.Forms.Label lblInsertarImagen;
        private System.Windows.Forms.Button btnCompartir;
        private System.Windows.Forms.Label lblCompartir;
        private System.Windows.Forms.Button btnRecibirArhivo;
        private System.Windows.Forms.Label lblRecibirArhivo;
        private System.Windows.Forms.Button btnFormatoColor;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem estiloDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subrayadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tachadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alineaciónDelTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derechaToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFormatoViñetas;
        private System.Windows.Forms.Button btnFormatoResaltado;
        private System.Windows.Forms.ToolStripMenuItem resaltadoToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Separador1;
        private System.Windows.Forms.PictureBox Separador2;
        private System.Windows.Forms.PictureBox Separador3;
        private System.Windows.Forms.PictureBox Separador4;
        private System.Windows.Forms.PictureBox Separador5;
        private System.Windows.Forms.PictureBox Separador6;
        private RichTextBoxPrintCtrl.RichTextBoxPrintCtrl richTextBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;

    }
}

