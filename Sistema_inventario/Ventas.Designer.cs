namespace Sistema_inventario
{
	partial class Ventas
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cbProductos = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbProductos = new System.Windows.Forms.GroupBox();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtPre = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtDescri = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtIdArticulo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtIdVendedor = new System.Windows.Forms.TextBox();
			this.txtApeVendedor = new System.Windows.Forms.TextBox();
			this.txtNombreVendedor = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.rdCliente = new System.Windows.Forms.RadioButton();
			this.rdCasual = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.gbCLientes = new System.Windows.Forms.GroupBox();
			this.btnCliente = new System.Windows.Forms.Button();
			this.txtDUICli = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbClientes = new System.Windows.Forms.ComboBox();
			this.txtDireccionCli = new System.Windows.Forms.TextBox();
			this.txtIdCLiente = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnProducto = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.gbPagos = new System.Windows.Forms.GroupBox();
			this.txtSubtotalGen = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.txtTOtal_general = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtItebis = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.txtSubtotalGeneral = new System.Windows.Forms.TextBox();
			this.lbSubtotal = new System.Windows.Forms.Label();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.gbProductos.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.gbCLientes.SuspendLayout();
			this.gbPagos.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy-dd-MM";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(528, 36);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
			this.dateTimePicker1.TabIndex = 33;
			// 
			// cbProductos
			// 
			this.cbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbProductos.FormattingEnabled = true;
			this.cbProductos.ItemHeight = 13;
			this.cbProductos.Location = new System.Drawing.Point(146, 244);
			this.cbProductos.Name = "cbProductos";
			this.cbProductos.Size = new System.Drawing.Size(97, 21);
			this.cbProductos.TabIndex = 32;
			this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.cbProductos_SelectedIndexChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(15, 247);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(125, 13);
			this.label16.TabIndex = 31;
			this.label16.Text = "Seleccione Producto";
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.White;
			this.btnSalir.BackgroundImage = global::Sistema_inventario.Properties.Resources.exit;
			this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(581, 464);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(48, 48);
			this.btnSalir.TabIndex = 30;
			this.toolTip1.SetToolTip(this.btnSalir, "Salir");
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.White;
			this.btnNuevo.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_new10_216291;
			this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Location = new System.Drawing.Point(581, 410);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(48, 48);
			this.btnNuevo.TabIndex = 29;
			this.toolTip1.SetToolTip(this.btnNuevo, "Nueva Venta");
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.White;
			this.btnGuardar.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_BT_save_905644__1_;
			this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(581, 356);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(48, 48);
			this.btnGuardar.TabIndex = 28;
			this.toolTip1.SetToolTip(this.btnGuardar, "Guardar ventas");
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
			this.dataGridView1.Location = new System.Drawing.Point(18, 356);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(554, 181);
			this.dataGridView1.TabIndex = 27;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
			this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
			this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Id_dVenta";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "IdProducto";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Precio_Unitario";
			this.Column4.Name = "Column4";
			this.Column4.Width = 108;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Cantidad";
			this.Column5.Name = "Column5";
			// 
			// Column7
			// 
			this.Column7.HeaderText = "SubTotal";
			this.Column7.Name = "Column7";
			// 
			// gbProductos
			// 
			this.gbProductos.BackColor = System.Drawing.Color.Transparent;
			this.gbProductos.Controls.Add(this.txtStock);
			this.gbProductos.Controls.Add(this.label17);
			this.gbProductos.Controls.Add(this.BtnEliminar);
			this.gbProductos.Controls.Add(this.btnAgregar);
			this.gbProductos.Controls.Add(this.txtSubtotal);
			this.gbProductos.Controls.Add(this.label15);
			this.gbProductos.Controls.Add(this.txtCantidad);
			this.gbProductos.Controls.Add(this.label14);
			this.gbProductos.Controls.Add(this.txtPre);
			this.gbProductos.Controls.Add(this.label13);
			this.gbProductos.Controls.Add(this.txtDescri);
			this.gbProductos.Controls.Add(this.label9);
			this.gbProductos.Controls.Add(this.txtIdArticulo);
			this.gbProductos.Controls.Add(this.label8);
			this.gbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbProductos.Location = new System.Drawing.Point(18, 274);
			this.gbProductos.Name = "gbProductos";
			this.gbProductos.Size = new System.Drawing.Size(685, 76);
			this.gbProductos.TabIndex = 26;
			this.gbProductos.TabStop = false;
			this.gbProductos.Text = "Datos de Articulo:";
			// 
			// txtStock
			// 
			this.txtStock.Enabled = false;
			this.txtStock.Location = new System.Drawing.Point(445, 41);
			this.txtStock.Margin = new System.Windows.Forms.Padding(2);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(76, 20);
			this.txtStock.TabIndex = 7;
			this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(442, 20);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(44, 13);
			this.label17.TabIndex = 12;
			this.label17.Text = "Stock:";
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.BackColor = System.Drawing.Color.White;
			this.BtnEliminar.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_editor_trash_delete_recycle_bin_glyph_7633251;
			this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnEliminar.Location = new System.Drawing.Point(626, 19);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(48, 48);
			this.BtnEliminar.TabIndex = 9;
			this.toolTip1.SetToolTip(this.BtnEliminar, "Eliminar producto");
			this.BtnEliminar.UseVisualStyleBackColor = false;
			this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.White;
			this.btnAgregar.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_checkround_24_103183;
			this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAgregar.Location = new System.Drawing.Point(563, 19);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(48, 48);
			this.btnAgregar.TabIndex = 8;
			this.toolTip1.SetToolTip(this.btnAgregar, "Agregar producto");
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Enabled = false;
			this.txtSubtotal.Location = new System.Drawing.Point(371, 41);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(66, 20);
			this.txtSubtotal.TabIndex = 6;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(368, 20);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(58, 13);
			this.label15.TabIndex = 8;
			this.label15.Text = "Subtotal:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(306, 41);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(49, 20);
			this.txtCantidad.TabIndex = 5;
			this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
			this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(303, 20);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(61, 13);
			this.label14.TabIndex = 6;
			this.label14.Text = "Cantidad:";
			// 
			// txtPre
			// 
			this.txtPre.Enabled = false;
			this.txtPre.Location = new System.Drawing.Point(211, 41);
			this.txtPre.Name = "txtPre";
			this.txtPre.Size = new System.Drawing.Size(74, 20);
			this.txtPre.TabIndex = 4;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(208, 20);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(93, 13);
			this.label13.TabIndex = 4;
			this.label13.Text = "Precio unitario:";
			// 
			// txtDescri
			// 
			this.txtDescri.Enabled = false;
			this.txtDescri.Location = new System.Drawing.Point(72, 41);
			this.txtDescri.Name = "txtDescri";
			this.txtDescri.Size = new System.Drawing.Size(131, 20);
			this.txtDescri.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(69, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(132, 13);
			this.label9.TabIndex = 2;
			this.label9.Text = "Descripción producto:";
			// 
			// txtIdArticulo
			// 
			this.txtIdArticulo.Enabled = false;
			this.txtIdArticulo.Location = new System.Drawing.Point(6, 41);
			this.txtIdArticulo.Name = "txtIdArticulo";
			this.txtIdArticulo.Size = new System.Drawing.Size(52, 20);
			this.txtIdArticulo.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(24, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "ID:";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.txtIdVendedor);
			this.groupBox2.Controls.Add(this.txtApeVendedor);
			this.groupBox2.Controls.Add(this.txtNombreVendedor);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(400, 69);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(228, 105);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Vendedor";
			// 
			// txtIdVendedor
			// 
			this.txtIdVendedor.Enabled = false;
			this.txtIdVendedor.Location = new System.Drawing.Point(89, 72);
			this.txtIdVendedor.Name = "txtIdVendedor";
			this.txtIdVendedor.Size = new System.Drawing.Size(55, 20);
			this.txtIdVendedor.TabIndex = 5;
			// 
			// txtApeVendedor
			// 
			this.txtApeVendedor.Enabled = false;
			this.txtApeVendedor.Location = new System.Drawing.Point(79, 46);
			this.txtApeVendedor.Name = "txtApeVendedor";
			this.txtApeVendedor.Size = new System.Drawing.Size(127, 20);
			this.txtApeVendedor.TabIndex = 4;
			// 
			// txtNombreVendedor
			// 
			this.txtNombreVendedor.Enabled = false;
			this.txtNombreVendedor.Location = new System.Drawing.Point(79, 20);
			this.txtNombreVendedor.Name = "txtNombreVendedor";
			this.txtNombreVendedor.Size = new System.Drawing.Size(127, 20);
			this.txtNombreVendedor.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 76);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(82, 13);
			this.label10.TabIndex = 2;
			this.label10.Text = "ID Vendedor:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(5, 49);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 13);
			this.label11.TabIndex = 1;
			this.label11.Text = "Apellidos:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 23);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 13);
			this.label12.TabIndex = 0;
			this.label12.Text = "Nombres:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(476, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 24;
			this.label7.Text = "Fecha:";
			// 
			// rdCliente
			// 
			this.rdCliente.AutoSize = true;
			this.rdCliente.BackColor = System.Drawing.Color.Transparent;
			this.rdCliente.Checked = true;
			this.rdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdCliente.Location = new System.Drawing.Point(159, 46);
			this.rdCliente.Name = "rdCliente";
			this.rdCliente.Size = new System.Drawing.Size(122, 17);
			this.rdCliente.TabIndex = 23;
			this.rdCliente.TabStop = true;
			this.rdCliente.Text = "Cliente frecuente";
			this.rdCliente.UseVisualStyleBackColor = false;
			// 
			// rdCasual
			// 
			this.rdCasual.AutoSize = true;
			this.rdCasual.BackColor = System.Drawing.Color.Transparent;
			this.rdCasual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdCasual.Location = new System.Drawing.Point(96, 46);
			this.rdCasual.Name = "rdCasual";
			this.rdCasual.Size = new System.Drawing.Size(63, 17);
			this.rdCasual.TabIndex = 22;
			this.rdCasual.TabStop = true;
			this.rdCasual.Text = "Casual";
			this.rdCasual.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = "Tipo de Venta:";
			// 
			// gbCLientes
			// 
			this.gbCLientes.BackColor = System.Drawing.Color.Transparent;
			this.gbCLientes.Controls.Add(this.btnCliente);
			this.gbCLientes.Controls.Add(this.txtDUICli);
			this.gbCLientes.Controls.Add(this.label18);
			this.gbCLientes.Controls.Add(this.label6);
			this.gbCLientes.Controls.Add(this.cbClientes);
			this.gbCLientes.Controls.Add(this.txtDireccionCli);
			this.gbCLientes.Controls.Add(this.txtIdCLiente);
			this.gbCLientes.Controls.Add(this.txtApellido);
			this.gbCLientes.Controls.Add(this.label5);
			this.gbCLientes.Controls.Add(this.txtNombre);
			this.gbCLientes.Controls.Add(this.label4);
			this.gbCLientes.Controls.Add(this.label3);
			this.gbCLientes.Controls.Add(this.label2);
			this.gbCLientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbCLientes.Location = new System.Drawing.Point(12, 69);
			this.gbCLientes.Name = "gbCLientes";
			this.gbCLientes.Size = new System.Drawing.Size(382, 160);
			this.gbCLientes.TabIndex = 20;
			this.gbCLientes.TabStop = false;
			this.gbCLientes.Text = "Cliente";
			// 
			// btnCliente
			// 
			this.btnCliente.BackColor = System.Drawing.Color.White;
			this.btnCliente.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_67_111124;
			this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCliente.Location = new System.Drawing.Point(131, 67);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(33, 27);
			this.btnCliente.TabIndex = 14;
			this.toolTip1.SetToolTip(this.btnCliente, "Buscar Cliente");
			this.btnCliente.UseVisualStyleBackColor = false;
			this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
			// 
			// txtDUICli
			// 
			this.txtDUICli.Location = new System.Drawing.Point(71, 125);
			this.txtDUICli.Name = "txtDUICli";
			this.txtDUICli.Size = new System.Drawing.Size(146, 20);
			this.txtDUICli.TabIndex = 11;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(6, 128);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(50, 13);
			this.label18.TabIndex = 10;
			this.label18.Text = "Cedula:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(255, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Seleccione cliente";
			// 
			// cbClientes
			// 
			this.cbClientes.FormattingEnabled = true;
			this.cbClientes.Items.AddRange(new object[] {
            "\" \" "});
			this.cbClientes.Location = new System.Drawing.Point(255, 45);
			this.cbClientes.Name = "cbClientes";
			this.cbClientes.Size = new System.Drawing.Size(121, 21);
			this.cbClientes.TabIndex = 8;
			this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
			// 
			// txtDireccionCli
			// 
			this.txtDireccionCli.Location = new System.Drawing.Point(72, 99);
			this.txtDireccionCli.Name = "txtDireccionCli";
			this.txtDireccionCli.Size = new System.Drawing.Size(180, 20);
			this.txtDireccionCli.TabIndex = 7;
			// 
			// txtIdCLiente
			// 
			this.txtIdCLiente.Enabled = false;
			this.txtIdCLiente.Location = new System.Drawing.Point(73, 71);
			this.txtIdCLiente.Name = "txtIdCLiente";
			this.txtIdCLiente.Size = new System.Drawing.Size(55, 20);
			this.txtIdCLiente.TabIndex = 5;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(73, 45);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(145, 20);
			this.txtApellido.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 102);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Dirección:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(72, 20);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(145, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "ID Cliente:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Apellidos:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nombres:";
			// 
			// btnProducto
			// 
			this.btnProducto.BackColor = System.Drawing.Color.White;
			this.btnProducto.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_67_111124;
			this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnProducto.Location = new System.Drawing.Point(249, 242);
			this.btnProducto.Name = "btnProducto";
			this.btnProducto.Size = new System.Drawing.Size(33, 27);
			this.btnProducto.TabIndex = 15;
			this.toolTip1.SetToolTip(this.btnProducto, "Buscar Producto especifico");
			this.btnProducto.UseVisualStyleBackColor = false;
			this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Informacion";
			// 
			// gbPagos
			// 
			this.gbPagos.BackColor = System.Drawing.Color.Transparent;
			this.gbPagos.Controls.Add(this.txtSubtotalGen);
			this.gbPagos.Controls.Add(this.label23);
			this.gbPagos.Controls.Add(this.txtTOtal_general);
			this.gbPagos.Controls.Add(this.label22);
			this.gbPagos.Controls.Add(this.txtItebis);
			this.gbPagos.Controls.Add(this.label21);
			this.gbPagos.Controls.Add(this.label20);
			this.gbPagos.Controls.Add(this.txtSubtotalGeneral);
			this.gbPagos.Controls.Add(this.lbSubtotal);
			this.gbPagos.Controls.Add(this.txtDescuento);
			this.gbPagos.Controls.Add(this.label19);
			this.gbPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbPagos.Location = new System.Drawing.Point(636, 356);
			this.gbPagos.Name = "gbPagos";
			this.gbPagos.Size = new System.Drawing.Size(181, 181);
			this.gbPagos.TabIndex = 26;
			this.gbPagos.TabStop = false;
			// 
			// txtSubtotalGen
			// 
			this.txtSubtotalGen.Enabled = false;
			this.txtSubtotalGen.Location = new System.Drawing.Point(81, 84);
			this.txtSubtotalGen.Margin = new System.Windows.Forms.Padding(2);
			this.txtSubtotalGen.Name = "txtSubtotalGen";
			this.txtSubtotalGen.Size = new System.Drawing.Size(83, 20);
			this.txtSubtotalGen.TabIndex = 34;
			this.txtSubtotalGen.TextChanged += new System.EventHandler(this.txtSubtotalGen_TextChanged);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Location = new System.Drawing.Point(-2, 126);
			this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(85, 13);
			this.label23.TabIndex = 25;
			this.label23.Text = "Subtotal Gen:";
			// 
			// txtTOtal_general
			// 
			this.txtTOtal_general.Enabled = false;
			this.txtTOtal_general.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTOtal_general.ForeColor = System.Drawing.Color.Red;
			this.txtTOtal_general.Location = new System.Drawing.Point(81, 151);
			this.txtTOtal_general.Margin = new System.Windows.Forms.Padding(2);
			this.txtTOtal_general.Name = "txtTOtal_general";
			this.txtTOtal_general.Size = new System.Drawing.Size(85, 26);
			this.txtTOtal_general.TabIndex = 24;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.ForeColor = System.Drawing.Color.Red;
			this.label22.Location = new System.Drawing.Point(5, 155);
			this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(54, 20);
			this.label22.TabIndex = 23;
			this.label22.Text = "Total:";
			// 
			// txtItebis
			// 
			this.txtItebis.Enabled = false;
			this.txtItebis.Location = new System.Drawing.Point(81, 47);
			this.txtItebis.Margin = new System.Windows.Forms.Padding(2);
			this.txtItebis.Name = "txtItebis";
			this.txtItebis.Size = new System.Drawing.Size(83, 20);
			this.txtItebis.TabIndex = 22;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(9, 50);
			this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(51, 13);
			this.label21.TabIndex = 21;
			this.label21.Text = "ITEBIS:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(133, 17);
			this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(16, 13);
			this.label20.TabIndex = 20;
			this.label20.Text = "%";
			// 
			// txtSubtotalGeneral
			// 
			this.txtSubtotalGeneral.Enabled = false;
			this.txtSubtotalGeneral.Location = new System.Drawing.Point(81, 123);
			this.txtSubtotalGeneral.Margin = new System.Windows.Forms.Padding(2);
			this.txtSubtotalGeneral.Name = "txtSubtotalGeneral";
			this.txtSubtotalGeneral.Size = new System.Drawing.Size(83, 20);
			this.txtSubtotalGeneral.TabIndex = 19;
			this.txtSubtotalGeneral.TextChanged += new System.EventHandler(this.txtSubtotalGeneral_TextChanged);
			// 
			// lbSubtotal
			// 
			this.lbSubtotal.AutoSize = true;
			this.lbSubtotal.BackColor = System.Drawing.Color.Transparent;
			this.lbSubtotal.Location = new System.Drawing.Point(9, 87);
			this.lbSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbSubtotal.Name = "lbSubtotal";
			this.lbSubtotal.Size = new System.Drawing.Size(58, 13);
			this.lbSubtotal.TabIndex = 18;
			this.lbSubtotal.Text = "Subtotal:";
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(81, 13);
			this.txtDescuento.Margin = new System.Windows.Forms.Padding(2);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(44, 20);
			this.txtDescuento.TabIndex = 17;
			this.txtDescuento.Text = "0";
			this.txtDescuento.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(9, 13);
			this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(72, 13);
			this.label19.TabIndex = 16;
			this.label19.Text = "Descuento:";
			// 
			// Ventas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Sistema_inventario.Properties.Resources.fondocliente3;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(819, 572);
			this.Controls.Add(this.gbPagos);
			this.Controls.Add(this.btnProducto);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cbProductos);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.gbProductos);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.rdCliente);
			this.Controls.Add(this.rdCasual);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gbCLientes);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Ventas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.Ventas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.gbProductos.ResumeLayout(false);
			this.gbProductos.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.gbCLientes.ResumeLayout(false);
			this.gbCLientes.PerformLayout();
			this.gbPagos.ResumeLayout(false);
			this.gbPagos.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cbProductos;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.GroupBox gbProductos;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtPre;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtDescri;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtIdArticulo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtIdVendedor;
		private System.Windows.Forms.TextBox txtApeVendedor;
		private System.Windows.Forms.TextBox txtNombreVendedor;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton rdCliente;
		private System.Windows.Forms.RadioButton rdCasual;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbCLientes;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbClientes;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.Button btnProducto;
		private System.Windows.Forms.ToolTip toolTip1;
		public System.Windows.Forms.TextBox txtDUICli;
		public System.Windows.Forms.TextBox txtDireccionCli;
		public System.Windows.Forms.TextBox txtIdCLiente;
		public System.Windows.Forms.TextBox txtApellido;
		public System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.GroupBox gbPagos;
		private System.Windows.Forms.TextBox txtTOtal_general;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtItebis;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtSubtotalGeneral;
		private System.Windows.Forms.Label lbSubtotal;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox txtSubtotalGen;
	}
}