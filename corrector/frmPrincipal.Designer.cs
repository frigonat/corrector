
namespace corrector
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslCantidadDeLineas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslFormSizeAndLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLineas = new System.Windows.Forms.DataGridView();
            this.colNroLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoteCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoteSAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarDatosInterfaz = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.lblFechaDeCorrida = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNumeroDeCorrida = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUsuarioDeAlta = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFechaHoraDeAlta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.lblNumeroDePedido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroDePedido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaBusqueda = new System.Windows.Forms.Button();
            this.fraCabecera = new System.Windows.Forms.GroupBox();
            this.fraLineas = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBaseDeDatos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).BeginInit();
            this.fraCabecera.SuspendLayout();
            this.fraLineas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslCantidadDeLineas,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.tslFormSizeAndLocation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 698);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            // 
            // tslCantidadDeLineas
            // 
            this.tslCantidadDeLineas.AutoSize = false;
            this.tslCantidadDeLineas.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslCantidadDeLineas.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tslCantidadDeLineas.Name = "tslCantidadDeLineas";
            this.tslCantidadDeLineas.Size = new System.Drawing.Size(118, 17);
            this.tslCantidadDeLineas.Text = "...";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            // 
            // tslFormSizeAndLocation
            // 
            this.tslFormSizeAndLocation.AutoSize = false;
            this.tslFormSizeAndLocation.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslFormSizeAndLocation.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tslFormSizeAndLocation.Name = "tslFormSizeAndLocation";
            this.tslFormSizeAndLocation.Size = new System.Drawing.Size(200, 17);
            this.tslFormSizeAndLocation.Text = "...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dgvLineas
            // 
            this.dgvLineas.AllowUserToAddRows = false;
            this.dgvLineas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLineas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLineas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroLinea,
            this.colSKU,
            this.colCantidad,
            this.colUOM,
            this.colLoteCliente,
            this.colLoteSAP,
            this.colFechaVencimiento});
            this.dgvLineas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLineas.Location = new System.Drawing.Point(11, 20);
            this.dgvLineas.Name = "dgvLineas";
            this.dgvLineas.RowHeadersVisible = false;
            this.dgvLineas.RowTemplate.Height = 25;
            this.dgvLineas.ShowCellErrors = false;
            this.dgvLineas.ShowCellToolTips = false;
            this.dgvLineas.ShowEditingIcon = false;
            this.dgvLineas.ShowRowErrors = false;
            this.dgvLineas.Size = new System.Drawing.Size(737, 316);
            this.dgvLineas.TabIndex = 0;
            // 
            // colNroLinea
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.colNroLinea.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNroLinea.HeaderText = "# Línea";
            this.colNroLinea.Name = "colNroLinea";
            // 
            // colSKU
            // 
            this.colSKU.HeaderText = "SKU";
            this.colSKU.Name = "colSKU";
            this.colSKU.Width = 125;
            // 
            // colCantidad
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 75;
            // 
            // colUOM
            // 
            this.colUOM.HeaderText = "UOM";
            this.colUOM.Name = "colUOM";
            this.colUOM.Width = 50;
            // 
            // colLoteCliente
            // 
            this.colLoteCliente.HeaderText = "Lote Cliente";
            this.colLoteCliente.Name = "colLoteCliente";
            // 
            // colLoteSAP
            // 
            this.colLoteSAP.HeaderText = "Lote SAP";
            this.colLoteSAP.Name = "colLoteSAP";
            // 
            // colFechaVencimiento
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.colFechaVencimiento.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.colFechaVencimiento.Name = "colFechaVencimiento";
            this.colFechaVencimiento.Width = 150;
            // 
            // btnActualizarDatosInterfaz
            // 
            this.btnActualizarDatosInterfaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarDatosInterfaz.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarDatosInterfaz.Image")));
            this.btnActualizarDatosInterfaz.Location = new System.Drawing.Point(679, 103);
            this.btnActualizarDatosInterfaz.Name = "btnActualizarDatosInterfaz";
            this.btnActualizarDatosInterfaz.Size = new System.Drawing.Size(71, 66);
            this.btnActualizarDatosInterfaz.TabIndex = 22;
            this.btnActualizarDatosInterfaz.Text = "&Liberar";
            this.btnActualizarDatosInterfaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizarDatosInterfaz.UseVisualStyleBackColor = true;
            this.btnActualizarDatosInterfaz.Click += new System.EventHandler(this.btnActualizarDatosInterfaz_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescar.Image = global::corrector.Properties.Resources.Refresh_icon_32;
            this.btnRefrescar.Location = new System.Drawing.Point(679, 15);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(71, 66);
            this.btnRefrescar.TabIndex = 21;
            this.btnRefrescar.Text = "&Refrescar";
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFechaDeCorrida
            // 
            this.lblFechaDeCorrida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaDeCorrida.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaDeCorrida.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFechaDeCorrida.Location = new System.Drawing.Point(477, 126);
            this.lblFechaDeCorrida.Name = "lblFechaDeCorrida";
            this.lblFechaDeCorrida.Size = new System.Drawing.Size(149, 21);
            this.lblFechaDeCorrida.TabIndex = 19;
            this.lblFechaDeCorrida.Text = "label15";
            this.lblFechaDeCorrida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(393, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Fecha Corrida:";
            // 
            // lblNumeroDeCorrida
            // 
            this.lblNumeroDeCorrida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumeroDeCorrida.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroDeCorrida.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNumeroDeCorrida.Location = new System.Drawing.Point(89, 126);
            this.lblNumeroDeCorrida.Name = "lblNumeroDeCorrida";
            this.lblNumeroDeCorrida.Size = new System.Drawing.Size(281, 23);
            this.lblNumeroDeCorrida.TabIndex = 17;
            this.lblNumeroDeCorrida.Text = "label13";
            this.lblNumeroDeCorrida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Nro. Corrida:";
            // 
            // lblUsuarioDeAlta
            // 
            this.lblUsuarioDeAlta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuarioDeAlta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarioDeAlta.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUsuarioDeAlta.Location = new System.Drawing.Point(393, 73);
            this.lblUsuarioDeAlta.Name = "lblUsuarioDeAlta";
            this.lblUsuarioDeAlta.Size = new System.Drawing.Size(101, 23);
            this.lblUsuarioDeAlta.TabIndex = 15;
            this.lblUsuarioDeAlta.Text = "label11";
            this.lblUsuarioDeAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Usuario de Alta:";
            // 
            // lblEstado
            // 
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEstado.Location = new System.Drawing.Point(501, 23);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(113, 23);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "label9";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estado:";
            // 
            // lblFechaHoraDeAlta
            // 
            this.lblFechaHoraDeAlta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaHoraDeAlta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaHoraDeAlta.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFechaHoraDeAlta.Location = new System.Drawing.Point(123, 73);
            this.lblFechaHoraDeAlta.Name = "lblFechaHoraDeAlta";
            this.lblFechaHoraDeAlta.Size = new System.Drawing.Size(149, 21);
            this.lblFechaHoraDeAlta.TabIndex = 11;
            this.lblFechaHoraDeAlta.Text = "label7";
            this.lblFechaHoraDeAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha/Hora de Alta:";
            // 
            // lblPropietario
            // 
            this.lblPropietario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPropietario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPropietario.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPropietario.Location = new System.Drawing.Point(76, 59);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(92, 21);
            this.lblPropietario.TabIndex = 9;
            this.lblPropietario.Text = "label5";
            this.lblPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumeroDePedido
            // 
            this.lblNumeroDePedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumeroDePedido.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroDePedido.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNumeroDePedido.Location = new System.Drawing.Point(75, 23);
            this.lblNumeroDePedido.Name = "lblNumeroDePedido";
            this.lblNumeroDePedido.Size = new System.Drawing.Size(124, 21);
            this.lblNumeroDePedido.TabIndex = 7;
            this.lblNumeroDePedido.Text = "label3";
            this.lblNumeroDePedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número:";
            // 
            // txtNumeroDePedido
            // 
            this.txtNumeroDePedido.Location = new System.Drawing.Point(275, 26);
            this.txtNumeroDePedido.Name = "txtNumeroDePedido";
            this.txtNumeroDePedido.Size = new System.Drawing.Size(117, 21);
            this.txtNumeroDePedido.TabIndex = 5;
            this.txtNumeroDePedido.Enter += new System.EventHandler(this.txtNumeroDePedido_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(411, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 22);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nro. de Pedido:";
            // 
            // btnNuevaBusqueda
            // 
            this.btnNuevaBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaBusqueda.Location = new System.Drawing.Point(638, 24);
            this.btnNuevaBusqueda.Name = "btnNuevaBusqueda";
            this.btnNuevaBusqueda.Size = new System.Drawing.Size(111, 22);
            this.btnNuevaBusqueda.TabIndex = 8;
            this.btnNuevaBusqueda.Text = "Nueva Búsqueda";
            this.btnNuevaBusqueda.UseVisualStyleBackColor = true;
            this.btnNuevaBusqueda.Click += new System.EventHandler(this.btnNuevaBusqueda_Click);
            // 
            // fraCabecera
            // 
            this.fraCabecera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fraCabecera.Controls.Add(this.btnActualizarDatosInterfaz);
            this.fraCabecera.Controls.Add(this.label2);
            this.fraCabecera.Controls.Add(this.btnRefrescar);
            this.fraCabecera.Controls.Add(this.lblNumeroDePedido);
            this.fraCabecera.Controls.Add(this.lblFechaDeCorrida);
            this.fraCabecera.Controls.Add(this.label14);
            this.fraCabecera.Controls.Add(this.lblNumeroDeCorrida);
            this.fraCabecera.Controls.Add(this.label12);
            this.fraCabecera.Controls.Add(this.label6);
            this.fraCabecera.Controls.Add(this.lblFechaHoraDeAlta);
            this.fraCabecera.Controls.Add(this.lblEstado);
            this.fraCabecera.Controls.Add(this.lblUsuarioDeAlta);
            this.fraCabecera.Controls.Add(this.label8);
            this.fraCabecera.Controls.Add(this.label10);
            this.fraCabecera.Location = new System.Drawing.Point(12, 151);
            this.fraCabecera.Name = "fraCabecera";
            this.fraCabecera.Size = new System.Drawing.Size(766, 184);
            this.fraCabecera.TabIndex = 9;
            this.fraCabecera.TabStop = false;
            this.fraCabecera.Text = "Datos de Cabecera";
            // 
            // fraLineas
            // 
            this.fraLineas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fraLineas.Controls.Add(this.dgvLineas);
            this.fraLineas.Location = new System.Drawing.Point(13, 341);
            this.fraLineas.Name = "fraLineas";
            this.fraLineas.Size = new System.Drawing.Size(764, 354);
            this.fraLineas.TabIndex = 10;
            this.fraLineas.TabStop = false;
            this.fraLineas.Text = "Líneas";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblBaseDeDatos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblAlmacen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbClientes);
            this.groupBox1.Controls.Add(this.txtNumeroDePedido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnNuevaBusqueda);
            this.groupBox1.Controls.Add(this.lblPropietario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lblBaseDeDatos
            // 
            this.lblBaseDeDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBaseDeDatos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBaseDeDatos.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblBaseDeDatos.Location = new System.Drawing.Point(459, 59);
            this.lblBaseDeDatos.Name = "lblBaseDeDatos";
            this.lblBaseDeDatos.Size = new System.Drawing.Size(92, 21);
            this.lblBaseDeDatos.TabIndex = 26;
            this.lblBaseDeDatos.Text = "label5";
            this.lblBaseDeDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Base de Datos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Almacén:";
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlmacen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlmacen.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAlmacen.Location = new System.Drawing.Point(249, 59);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(92, 21);
            this.lblAlmacen.TabIndex = 23;
            this.lblAlmacen.Text = "label5";
            this.lblAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Propietario:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(56, 26);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(121, 21);
            this.cmbClientes.TabIndex = 10;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 720);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fraLineas);
            this.Controls.Add(this.fraCabecera);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "corrector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.LocationChanged += new System.EventHandler(this.frmPrincipal_LocationChanged);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).EndInit();
            this.fraCabecera.ResumeLayout(false);
            this.fraCabecera.PerformLayout();
            this.fraLineas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslCantidadDeLineas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tslFormSizeAndLocation;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblFechaDeCorrida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNumeroDeCorrida;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblUsuarioDeAlta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFechaHoraDeAlta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label lblNumeroDePedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroDePedido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLineas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoteCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoteSAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVencimiento;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnNuevaBusqueda;
        private System.Windows.Forms.Button btnActualizarDatosInterfaz;
        private System.Windows.Forms.GroupBox fraCabecera;
        private System.Windows.Forms.GroupBox fraLineas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAlmacen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblBaseDeDatos;
        private System.Windows.Forms.Label label7;
    }
}

