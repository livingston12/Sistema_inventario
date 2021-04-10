namespace Sistema_inventario
{
	partial class Compras
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
			this.dvProductos = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.preciocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbProductos = new System.Windows.Forms.GroupBox();
			this.txtventaPro = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPreProd = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.btnEliminarPro = new System.Windows.Forms.Button();
			this.btnAgregarPro = new System.Windows.Forms.Button();
			this.txtTotalPro = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtCantPro = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtDescriPro = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtIdPro = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.gbProveedores = new System.Windows.Forms.GroupBox();
			this.BtnBuscarProveedor = new System.Windows.Forms.Button();
			this.cbProveedor = new System.Windows.Forms.ComboBox();
			this.txtProveedor = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtIdUsuario = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnProducto = new System.Windows.Forms.Button();
			this.BtnNuevo = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.gbPagos = new System.Windows.Forms.GroupBox();
			this.txtSubtotalGen = new System.Windows.Forms.TextBox();
			this.txtTOtal_general = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.lbSubtotal = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dvProductos)).BeginInit();
			this.gbProductos.SuspendLayout();
			this.gbProveedores.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbPagos.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy-dd-MM";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(528, 29);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
			this.dateTimePicker1.TabIndex = 42;
			this.toolTip1.SetToolTip(this.dateTimePicker1, "Fecha de compra");
			// 
			// cbProductos
			// 
			this.cbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbProductos.FormattingEnabled = true;
			this.cbProductos.Location = new System.Drawing.Point(162, 166);
			this.cbProductos.Name = "cbProductos";
			this.cbProductos.Size = new System.Drawing.Size(97, 21);
			this.cbProductos.TabIndex = 41;
			this.cbProductos.SelectedValueChanged += new System.EventHandler(this.cbProductos_SelectedValueChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(31, 169);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(125, 13);
			this.label16.TabIndex = 40;
			this.label16.Text = "Seleccione Producto";
			// 
			// dvProductos
			// 
			this.dvProductos.AllowUserToAddRows = false;
			this.dvProductos.AllowUserToDeleteRows = false;
			this.dvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id_compra,
            this.producto,
            this.precio,
            this.preciocompra,
            this.cantidad,
            this.total});
			this.dvProductos.Location = new System.Drawing.Point(25, 273);
			this.dvProductos.Name = "dvProductos";
			this.dvProductos.ReadOnly = true;
			this.dvProductos.RowHeadersVisible = false;
			this.dvProductos.Size = new System.Drawing.Size(551, 150);
			this.dvProductos.TabIndex = 36;
			this.dvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvProductos_CellContentClick);
			this.dvProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvProductos_CellValueChanged);
			this.dvProductos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dvProductos_RowsAdded);
			this.dvProductos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dvProductos_RowsRemoved);
			// 
			// Column1
			// 
			this.Column1.FillWeight = 125.8883F;
			this.Column1.HeaderText = "Cod. prod.";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 81;
			// 
			// id_compra
			// 
			this.id_compra.FillWeight = 103.8963F;
			this.id_compra.HeaderText = "Cod. compra";
			this.id_compra.Name = "id_compra";
			this.id_compra.ReadOnly = true;
			this.id_compra.Width = 92;
			// 
			// producto
			// 
			this.producto.FillWeight = 78.52629F;
			this.producto.HeaderText = "Producto";
			this.producto.Name = "producto";
			this.producto.ReadOnly = true;
			this.producto.Width = 150;
			// 
			// precio
			// 
			this.precio.FillWeight = 103.8963F;
			this.precio.HeaderText = "PrecioVenta";
			this.precio.Name = "precio";
			this.precio.ReadOnly = true;
			this.precio.Width = 70;
			// 
			// preciocompra
			// 
			this.preciocompra.HeaderText = "PrecioCompra";
			this.preciocompra.Name = "preciocompra";
			this.preciocompra.ReadOnly = true;
			// 
			// cantidad
			// 
			this.cantidad.FillWeight = 103.8963F;
			this.cantidad.HeaderText = "Cantidad";
			this.cantidad.Name = "cantidad";
			this.cantidad.ReadOnly = true;
			this.cantidad.Width = 74;
			// 
			// total
			// 
			this.total.FillWeight = 103.8963F;
			this.total.HeaderText = "Total";
			this.total.Name = "total";
			this.total.ReadOnly = true;
			this.total.Width = 56;
			// 
			// gbProductos
			// 
			this.gbProductos.BackColor = System.Drawing.Color.Transparent;
			this.gbProductos.Controls.Add(this.txtventaPro);
			this.gbProductos.Controls.Add(this.label1);
			this.gbProductos.Controls.Add(this.txtPreProd);
			this.gbProductos.Controls.Add(this.label13);
			this.gbProductos.Controls.Add(this.btnEliminarPro);
			this.gbProductos.Controls.Add(this.btnAgregarPro);
			this.gbProductos.Controls.Add(this.txtTotalPro);
			this.gbProductos.Controls.Add(this.label15);
			this.gbProductos.Controls.Add(this.txtCantPro);
			this.gbProductos.Controls.Add(this.label14);
			this.gbProductos.Controls.Add(this.txtDescriPro);
			this.gbProductos.Controls.Add(this.label9);
			this.gbProductos.Controls.Add(this.txtIdPro);
			this.gbProductos.Controls.Add(this.label8);
			this.gbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbProductos.Location = new System.Drawing.Point(25, 191);
			this.gbProductos.Name = "gbProductos";
			this.gbProductos.Size = new System.Drawing.Size(613, 76);
			this.gbProductos.TabIndex = 35;
			this.gbProductos.TabStop = false;
			this.gbProductos.Text = "Datos de Articulo:";
			// 
			// txtventaPro
			// 
			this.txtventaPro.Location = new System.Drawing.Point(279, 41);
			this.txtventaPro.Name = "txtventaPro";
			this.txtventaPro.Size = new System.Drawing.Size(62, 20);
			this.txtventaPro.TabIndex = 4;
			this.txtventaPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantPro_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(276, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "P. Venta:";
			// 
			// txtPreProd
			// 
			this.txtPreProd.Location = new System.Drawing.Point(210, 41);
			this.txtPreProd.Name = "txtPreProd";
			this.txtPreProd.Size = new System.Drawing.Size(63, 20);
			this.txtPreProd.TabIndex = 3;
			this.txtPreProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantPro_KeyPress);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(207, 20);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(69, 13);
			this.label13.TabIndex = 14;
			this.label13.Text = "P. Compra:";
			// 
			// btnEliminarPro
			// 
			this.btnEliminarPro.BackColor = System.Drawing.Color.White;
			this.btnEliminarPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEliminarPro.ForeColor = System.Drawing.Color.White;
			this.btnEliminarPro.Image = global::Sistema_inventario.Properties.Resources.if_editor_trash_delete_recycle_bin_glyph_7633251;
			this.btnEliminarPro.Location = new System.Drawing.Point(557, 22);
			this.btnEliminarPro.Name = "btnEliminarPro";
			this.btnEliminarPro.Size = new System.Drawing.Size(48, 48);
			this.btnEliminarPro.TabIndex = 8;
			this.toolTip1.SetToolTip(this.btnEliminarPro, "Eliminar producto");
			this.btnEliminarPro.UseVisualStyleBackColor = false;
			this.btnEliminarPro.Click += new System.EventHandler(this.btnEliminarPro_Click);
			// 
			// btnAgregarPro
			// 
			this.btnAgregarPro.BackColor = System.Drawing.Color.White;
			this.btnAgregarPro.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_checkround_24_103183;
			this.btnAgregarPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAgregarPro.ForeColor = System.Drawing.Color.White;
			this.btnAgregarPro.Location = new System.Drawing.Point(503, 22);
			this.btnAgregarPro.Name = "btnAgregarPro";
			this.btnAgregarPro.Size = new System.Drawing.Size(48, 48);
			this.btnAgregarPro.TabIndex = 7;
			this.toolTip1.SetToolTip(this.btnAgregarPro, "Agregar producto");
			this.btnAgregarPro.UseVisualStyleBackColor = false;
			this.btnAgregarPro.Click += new System.EventHandler(this.btnAgregarPro_Click);
			// 
			// txtTotalPro
			// 
			this.txtTotalPro.Enabled = false;
			this.txtTotalPro.Location = new System.Drawing.Point(426, 41);
			this.txtTotalPro.Name = "txtTotalPro";
			this.txtTotalPro.Size = new System.Drawing.Size(66, 20);
			this.txtTotalPro.TabIndex = 6;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(423, 20);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(40, 13);
			this.label15.TabIndex = 8;
			this.label15.Text = "Total:";
			// 
			// txtCantPro
			// 
			this.txtCantPro.Location = new System.Drawing.Point(356, 41);
			this.txtCantPro.Name = "txtCantPro";
			this.txtCantPro.Size = new System.Drawing.Size(49, 20);
			this.txtCantPro.TabIndex = 5;
			this.txtCantPro.TextChanged += new System.EventHandler(this.txtCantPro_TextChanged);
			this.txtCantPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantPro_KeyPress);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(351, 20);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(61, 13);
			this.label14.TabIndex = 6;
			this.label14.Text = "Cantidad:";
			// 
			// txtDescriPro
			// 
			this.txtDescriPro.Enabled = false;
			this.txtDescriPro.Location = new System.Drawing.Point(72, 41);
			this.txtDescriPro.Name = "txtDescriPro";
			this.txtDescriPro.Size = new System.Drawing.Size(131, 20);
			this.txtDescriPro.TabIndex = 2;
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
			// txtIdPro
			// 
			this.txtIdPro.Enabled = false;
			this.txtIdPro.Location = new System.Drawing.Point(6, 41);
			this.txtIdPro.Name = "txtIdPro";
			this.txtIdPro.Size = new System.Drawing.Size(52, 20);
			this.txtIdPro.TabIndex = 1;
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
			// gbProveedores
			// 
			this.gbProveedores.BackColor = System.Drawing.Color.Transparent;
			this.gbProveedores.Controls.Add(this.BtnBuscarProveedor);
			this.gbProveedores.Controls.Add(this.cbProveedor);
			this.gbProveedores.Controls.Add(this.txtProveedor);
			this.gbProveedores.Controls.Add(this.label10);
			this.gbProveedores.Controls.Add(this.label12);
			this.gbProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbProveedores.Location = new System.Drawing.Point(410, 55);
			this.gbProveedores.Name = "gbProveedores";
			this.gbProveedores.Size = new System.Drawing.Size(228, 105);
			this.gbProveedores.TabIndex = 34;
			this.gbProveedores.TabStop = false;
			this.gbProveedores.Text = "Proveedor";
			// 
			// BtnBuscarProveedor
			// 
			this.BtnBuscarProveedor.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_67_111124;
			this.BtnBuscarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnBuscarProveedor.Location = new System.Drawing.Point(171, 46);
			this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
			this.BtnBuscarProveedor.Size = new System.Drawing.Size(35, 27);
			this.BtnBuscarProveedor.TabIndex = 33;
			this.toolTip1.SetToolTip(this.BtnBuscarProveedor, "Buscar proveedor");
			this.BtnBuscarProveedor.UseVisualStyleBackColor = true;
			this.BtnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarProveedor_Click);
			// 
			// cbProveedor
			// 
			this.cbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbProveedor.FormattingEnabled = true;
			this.cbProveedor.Location = new System.Drawing.Point(98, 50);
			this.cbProveedor.Name = "cbProveedor";
			this.cbProveedor.Size = new System.Drawing.Size(61, 21);
			this.cbProveedor.TabIndex = 0;
			// 
			// txtProveedor
			// 
			this.txtProveedor.Enabled = false;
			this.txtProveedor.Location = new System.Drawing.Point(79, 20);
			this.txtProveedor.Name = "txtProveedor";
			this.txtProveedor.Size = new System.Drawing.Size(127, 20);
			this.txtProveedor.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 53);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(86, 13);
			this.label10.TabIndex = 2;
			this.label10.Text = "ID Proveedor:";
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
			this.label7.Location = new System.Drawing.Point(476, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 33;
			this.label7.Text = "Fecha:";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txtIdUsuario);
			this.groupBox1.Controls.Add(this.txtApellido);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(22, 55);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(382, 105);
			this.groupBox1.TabIndex = 32;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Usuario";
			// 
			// txtIdUsuario
			// 
			this.txtIdUsuario.Enabled = false;
			this.txtIdUsuario.Location = new System.Drawing.Point(75, 73);
			this.txtIdUsuario.Name = "txtIdUsuario";
			this.txtIdUsuario.Size = new System.Drawing.Size(55, 20);
			this.txtIdUsuario.TabIndex = 5;
			// 
			// txtApellido
			// 
			this.txtApellido.Enabled = false;
			this.txtApellido.Location = new System.Drawing.Point(75, 46);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(145, 20);
			this.txtApellido.TabIndex = 4;
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Location = new System.Drawing.Point(75, 20);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(145, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "ID Usuario:";
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
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.White;
			this.btnSalir.BackgroundImage = global::Sistema_inventario.Properties.Resources.exit;
			this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.White;
			this.btnSalir.Location = new System.Drawing.Point(593, 381);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(48, 48);
			this.btnSalir.TabIndex = 39;
			this.toolTip1.SetToolTip(this.btnSalir, "Salir");
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnProducto
			// 
			this.btnProducto.BackColor = System.Drawing.Color.White;
			this.btnProducto.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_67_111124;
			this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnProducto.Location = new System.Drawing.Point(268, 164);
			this.btnProducto.Name = "btnProducto";
			this.btnProducto.Size = new System.Drawing.Size(33, 27);
			this.btnProducto.TabIndex = 43;
			this.toolTip1.SetToolTip(this.btnProducto, "Buscar Producto");
			this.btnProducto.UseVisualStyleBackColor = false;
			this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
			// 
			// BtnNuevo
			// 
			this.BtnNuevo.BackColor = System.Drawing.Color.White;
			this.BtnNuevo.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_new10_216291;
			this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnNuevo.ForeColor = System.Drawing.Color.White;
			this.BtnNuevo.Location = new System.Drawing.Point(593, 327);
			this.BtnNuevo.Name = "BtnNuevo";
			this.BtnNuevo.Size = new System.Drawing.Size(48, 48);
			this.BtnNuevo.TabIndex = 38;
			this.toolTip1.SetToolTip(this.BtnNuevo, "Nueva compra");
			this.BtnNuevo.UseVisualStyleBackColor = false;
			this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.White;
			this.btnGuardar.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_BT_save_905644__1_;
			this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.ForeColor = System.Drawing.Color.White;
			this.btnGuardar.Location = new System.Drawing.Point(593, 273);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(48, 48);
			this.btnGuardar.TabIndex = 37;
			this.toolTip1.SetToolTip(this.btnGuardar, "Facturar Compra");
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// gbPagos
			// 
			this.gbPagos.BackColor = System.Drawing.Color.Transparent;
			this.gbPagos.Controls.Add(this.txtSubtotalGen);
			this.gbPagos.Controls.Add(this.txtTOtal_general);
			this.gbPagos.Controls.Add(this.label22);
			this.gbPagos.Controls.Add(this.lbSubtotal);
			this.gbPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbPagos.Location = new System.Drawing.Point(644, 292);
			this.gbPagos.Name = "gbPagos";
			this.gbPagos.Size = new System.Drawing.Size(181, 102);
			this.gbPagos.TabIndex = 44;
			this.gbPagos.TabStop = false;
			// 
			// txtSubtotalGen
			// 
			this.txtSubtotalGen.Enabled = false;
			this.txtSubtotalGen.Location = new System.Drawing.Point(82, 25);
			this.txtSubtotalGen.Margin = new System.Windows.Forms.Padding(2);
			this.txtSubtotalGen.Name = "txtSubtotalGen";
			this.txtSubtotalGen.Size = new System.Drawing.Size(83, 20);
			this.txtSubtotalGen.TabIndex = 34;
			// 
			// txtTOtal_general
			// 
			this.txtTOtal_general.Enabled = false;
			this.txtTOtal_general.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTOtal_general.ForeColor = System.Drawing.Color.Red;
			this.txtTOtal_general.Location = new System.Drawing.Point(82, 54);
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
			this.label22.Location = new System.Drawing.Point(6, 58);
			this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(54, 20);
			this.label22.TabIndex = 23;
			this.label22.Text = "Total:";
			// 
			// lbSubtotal
			// 
			this.lbSubtotal.AutoSize = true;
			this.lbSubtotal.BackColor = System.Drawing.Color.Transparent;
			this.lbSubtotal.Location = new System.Drawing.Point(10, 30);
			this.lbSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbSubtotal.Name = "lbSubtotal";
			this.lbSubtotal.Size = new System.Drawing.Size(58, 13);
			this.lbSubtotal.TabIndex = 18;
			this.lbSubtotal.Text = "Subtotal:";
			// 
			// toolTip1
			// 
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Informacion";
			// 
			// Compras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Sistema_inventario.Properties.Resources.fondocliente3;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(837, 572);
			this.Controls.Add(this.gbPagos);
			this.Controls.Add(this.btnProducto);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cbProductos);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.BtnNuevo);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dvProductos);
			this.Controls.Add(this.gbProductos);
			this.Controls.Add(this.gbProveedores);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox1);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.Name = "Compras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Compras";
			this.Load += new System.EventHandler(this.Compras_Load);
			((System.ComponentModel.ISupportInitialize)(this.dvProductos)).EndInit();
			this.gbProductos.ResumeLayout(false);
			this.gbProductos.PerformLayout();
			this.gbProveedores.ResumeLayout(false);
			this.gbProveedores.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.Button BtnNuevo;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.DataGridView dvProductos;
		private System.Windows.Forms.GroupBox gbProductos;
		private System.Windows.Forms.TextBox txtventaPro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPreProd;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnEliminarPro;
		private System.Windows.Forms.Button btnAgregarPro;
		private System.Windows.Forms.TextBox txtTotalPro;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtCantPro;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtDescriPro;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtIdPro;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox gbProveedores;
		private System.Windows.Forms.ComboBox cbProveedor;
		private System.Windows.Forms.TextBox txtProveedor;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtIdUsuario;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnBuscarProveedor;
		private System.Windows.Forms.Button btnProducto;
		private System.Windows.Forms.GroupBox gbPagos;
		private System.Windows.Forms.TextBox txtSubtotalGen;
		private System.Windows.Forms.TextBox txtTOtal_general;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label lbSubtotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_compra;
		private System.Windows.Forms.DataGridViewTextBoxColumn producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn preciocompra;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn total;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}