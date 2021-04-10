namespace Sistema_inventario
{
	partial class inventario
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
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.rdCategoria = new System.Windows.Forms.RadioButton();
			this.gbCategoria = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.txtCategoria = new System.Windows.Forms.TextBox();
			this.txtidCategoria = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnAgregarCategoria = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.gbProducto = new System.Windows.Forms.GroupBox();
			this.btnProducto = new System.Windows.Forms.Button();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbCategoria = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbProveedor = new System.Windows.Forms.ComboBox();
			this.txtDecrip = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtIdPro = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rdProducto = new System.Windows.Forms.RadioButton();
			this.rdProveedor = new System.Windows.Forms.RadioButton();
			this.gbProveedores = new System.Windows.Forms.GroupBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtProveedor = new System.Windows.Forms.TextBox();
			this.txtIdproveedor = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.gbCategoria.SuspendLayout();
			this.gbProducto.SuspendLayout();
			this.gbProveedores.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.White;
			this.btnLimpiar.BackgroundImage = global::Sistema_inventario.Properties.Resources.limpiar;
			this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
			this.btnLimpiar.Location = new System.Drawing.Point(776, 112);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(48, 48);
			this.btnLimpiar.TabIndex = 32;
			this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar");
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// rdCategoria
			// 
			this.rdCategoria.AutoSize = true;
			this.rdCategoria.BackColor = System.Drawing.Color.Transparent;
			this.rdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdCategoria.Location = new System.Drawing.Point(393, 33);
			this.rdCategoria.Margin = new System.Windows.Forms.Padding(2);
			this.rdCategoria.Name = "rdCategoria";
			this.rdCategoria.Size = new System.Drawing.Size(126, 17);
			this.rdCategoria.TabIndex = 31;
			this.rdCategoria.Text = "Agregar categoria";
			this.rdCategoria.UseVisualStyleBackColor = false;
			this.rdCategoria.CheckedChanged += new System.EventHandler(this.rdCategoria_CheckedChanged);
			// 
			// gbCategoria
			// 
			this.gbCategoria.BackColor = System.Drawing.Color.Transparent;
			this.gbCategoria.Controls.Add(this.button6);
			this.gbCategoria.Controls.Add(this.label9);
			this.gbCategoria.Controls.Add(this.txtCategoria);
			this.gbCategoria.Controls.Add(this.txtidCategoria);
			this.gbCategoria.Controls.Add(this.label8);
			this.gbCategoria.Controls.Add(this.btnAgregarCategoria);
			this.gbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbCategoria.Location = new System.Drawing.Point(393, 54);
			this.gbCategoria.Margin = new System.Windows.Forms.Padding(2);
			this.gbCategoria.Name = "gbCategoria";
			this.gbCategoria.Padding = new System.Windows.Forms.Padding(2);
			this.gbCategoria.Size = new System.Drawing.Size(306, 84);
			this.gbCategoria.TabIndex = 30;
			this.gbCategoria.TabStop = false;
			this.gbCategoria.Text = "Datos Categoria";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.White;
			this.button6.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_67_111124;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button6.Location = new System.Drawing.Point(168, 25);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(33, 27);
			this.button6.TabIndex = 22;
			this.toolTip1.SetToolTip(this.button6, "Buscar categorias");
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(5, 61);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(54, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Nombre:";
			// 
			// txtCategoria
			// 
			this.txtCategoria.Enabled = false;
			this.txtCategoria.Location = new System.Drawing.Point(59, 58);
			this.txtCategoria.Margin = new System.Windows.Forms.Padding(2);
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Size = new System.Drawing.Size(167, 20);
			this.txtCategoria.TabIndex = 8;
			// 
			// txtidCategoria
			// 
			this.txtidCategoria.Enabled = false;
			this.txtidCategoria.Location = new System.Drawing.Point(87, 29);
			this.txtidCategoria.Margin = new System.Windows.Forms.Padding(2);
			this.txtidCategoria.Name = "txtidCategoria";
			this.txtidCategoria.Size = new System.Drawing.Size(76, 20);
			this.txtidCategoria.TabIndex = 7;
			this.txtidCategoria.TextChanged += new System.EventHandler(this.txtidCategoria_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(5, 32);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 13);
			this.label8.TabIndex = 1;
			this.label8.Text = "ID Categoria";
			// 
			// btnAgregarCategoria
			// 
			this.btnAgregarCategoria.BackColor = System.Drawing.Color.White;
			this.btnAgregarCategoria.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_new10_216291;
			this.btnAgregarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAgregarCategoria.Location = new System.Drawing.Point(253, 39);
			this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2);
			this.btnAgregarCategoria.Name = "btnAgregarCategoria";
			this.btnAgregarCategoria.Size = new System.Drawing.Size(40, 40);
			this.btnAgregarCategoria.TabIndex = 9;
			this.toolTip1.SetToolTip(this.btnAgregarCategoria, "Agregar categoria");
			this.btnAgregarCategoria.UseVisualStyleBackColor = false;
			this.btnAgregarCategoria.Click += new System.EventHandler(this.button5_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.White;
			this.btnSalir.BackgroundImage = global::Sistema_inventario.Properties.Resources.exit;
			this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(751, 166);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(48, 48);
			this.btnSalir.TabIndex = 28;
			this.toolTip1.SetToolTip(this.btnSalir, "Salir");
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.White;
			this.btnEliminar.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_editor_trash_delete_recycle_bin_glyph_763325;
			this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(722, 112);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(48, 48);
			this.btnEliminar.TabIndex = 27;
			this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar");
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.White;
			this.btnModificar.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_files_folders_04_808645;
			this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnModificar.Enabled = false;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(776, 58);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(48, 48);
			this.btnModificar.TabIndex = 26;
			this.toolTip1.SetToolTip(this.btnModificar, "Editar");
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.White;
			this.btnAgregar.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_BT_save_905644__1_;
			this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(722, 58);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(48, 48);
			this.btnAgregar.TabIndex = 25;
			this.toolTip1.SetToolTip(this.btnAgregar, "Agregar producto");
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
			// 
			// gbProducto
			// 
			this.gbProducto.BackColor = System.Drawing.Color.Transparent;
			this.gbProducto.Controls.Add(this.btnProducto);
			this.gbProducto.Controls.Add(this.txtStock);
			this.gbProducto.Controls.Add(this.label5);
			this.gbProducto.Controls.Add(this.label4);
			this.gbProducto.Controls.Add(this.cbCategoria);
			this.gbProducto.Controls.Add(this.label2);
			this.gbProducto.Controls.Add(this.cbProveedor);
			this.gbProducto.Controls.Add(this.txtDecrip);
			this.gbProducto.Controls.Add(this.label7);
			this.gbProducto.Controls.Add(this.txtPrecio);
			this.gbProducto.Controls.Add(this.label6);
			this.gbProducto.Controls.Add(this.txtIdPro);
			this.gbProducto.Controls.Add(this.label3);
			this.gbProducto.Controls.Add(this.txtNom);
			this.gbProducto.Controls.Add(this.label1);
			this.gbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbProducto.Location = new System.Drawing.Point(5, 53);
			this.gbProducto.Name = "gbProducto";
			this.gbProducto.Size = new System.Drawing.Size(383, 292);
			this.gbProducto.TabIndex = 24;
			this.gbProducto.TabStop = false;
			this.gbProducto.Text = "Datos Producto";
			// 
			// btnProducto
			// 
			this.btnProducto.BackColor = System.Drawing.Color.White;
			this.btnProducto.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_67_111124;
			this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnProducto.Location = new System.Drawing.Point(169, 27);
			this.btnProducto.Name = "btnProducto";
			this.btnProducto.Size = new System.Drawing.Size(33, 27);
			this.btnProducto.TabIndex = 21;
			this.toolTip1.SetToolTip(this.btnProducto, "Buscar productos");
			this.btnProducto.UseVisualStyleBackColor = false;
			this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(85, 162);
			this.txtStock.Margin = new System.Windows.Forms.Padding(2);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(90, 20);
			this.txtStock.TabIndex = 4;
			this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 166);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 19;
			this.label5.Text = "Stock:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(216, 189);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Seleccione Categoria";
			// 
			// cbCategoria
			// 
			this.cbCategoria.FormattingEnabled = true;
			this.cbCategoria.ItemHeight = 13;
			this.cbCategoria.Location = new System.Drawing.Point(219, 217);
			this.cbCategoria.Margin = new System.Windows.Forms.Padding(2);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(121, 21);
			this.cbCategoria.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Seleccione Proveedor";
			// 
			// cbProveedor
			// 
			this.cbProveedor.FormattingEnabled = true;
			this.cbProveedor.ItemHeight = 13;
			this.cbProveedor.Location = new System.Drawing.Point(8, 217);
			this.cbProveedor.Name = "cbProveedor";
			this.cbProveedor.Size = new System.Drawing.Size(121, 21);
			this.cbProveedor.TabIndex = 15;
			// 
			// txtDecrip
			// 
			this.txtDecrip.Location = new System.Drawing.Point(84, 130);
			this.txtDecrip.Name = "txtDecrip";
			this.txtDecrip.Size = new System.Drawing.Size(141, 20);
			this.txtDecrip.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 133);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Descripcion:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.Location = new System.Drawing.Point(107, 97);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(118, 20);
			this.txtPrecio.TabIndex = 2;
			this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Precio Unitario:";
			// 
			// txtIdPro
			// 
			this.txtIdPro.Enabled = false;
			this.txtIdPro.Location = new System.Drawing.Point(85, 31);
			this.txtIdPro.Name = "txtIdPro";
			this.txtIdPro.Size = new System.Drawing.Size(78, 20);
			this.txtIdPro.TabIndex = 0;
			this.txtIdPro.TextChanged += new System.EventHandler(this.txtidCategoria_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "ID Producto:";
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(85, 65);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(140, 20);
			this.txtNom.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// rdProducto
			// 
			this.rdProducto.AutoSize = true;
			this.rdProducto.BackColor = System.Drawing.Color.Transparent;
			this.rdProducto.Checked = true;
			this.rdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdProducto.Location = new System.Drawing.Point(5, 28);
			this.rdProducto.Name = "rdProducto";
			this.rdProducto.Size = new System.Drawing.Size(123, 17);
			this.rdProducto.TabIndex = 23;
			this.rdProducto.TabStop = true;
			this.rdProducto.Text = "Agregar producto";
			this.rdProducto.UseVisualStyleBackColor = false;
			this.rdProducto.CheckedChanged += new System.EventHandler(this.rdProducto_CheckedChanged);
			// 
			// rdProveedor
			// 
			this.rdProveedor.AutoSize = true;
			this.rdProveedor.BackColor = System.Drawing.Color.Transparent;
			this.rdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdProveedor.Location = new System.Drawing.Point(401, 142);
			this.rdProveedor.Margin = new System.Windows.Forms.Padding(2);
			this.rdProveedor.Name = "rdProveedor";
			this.rdProveedor.Size = new System.Drawing.Size(130, 17);
			this.rdProveedor.TabIndex = 34;
			this.rdProveedor.Text = "Agregar proveedor";
			this.rdProveedor.UseVisualStyleBackColor = false;
			this.rdProveedor.CheckedChanged += new System.EventHandler(this.rdProveedor_CheckedChanged);
			// 
			// gbProveedores
			// 
			this.gbProveedores.BackColor = System.Drawing.Color.Transparent;
			this.gbProveedores.Controls.Add(this.txtEmail);
			this.gbProveedores.Controls.Add(this.label15);
			this.gbProveedores.Controls.Add(this.txtTel);
			this.gbProveedores.Controls.Add(this.label14);
			this.gbProveedores.Controls.Add(this.label13);
			this.gbProveedores.Controls.Add(this.txtDireccion);
			this.gbProveedores.Controls.Add(this.label12);
			this.gbProveedores.Controls.Add(this.txtCedula);
			this.gbProveedores.Controls.Add(this.button1);
			this.gbProveedores.Controls.Add(this.label10);
			this.gbProveedores.Controls.Add(this.txtProveedor);
			this.gbProveedores.Controls.Add(this.txtIdproveedor);
			this.gbProveedores.Controls.Add(this.label11);
			this.gbProveedores.Controls.Add(this.button2);
			this.gbProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbProveedores.Location = new System.Drawing.Point(401, 163);
			this.gbProveedores.Margin = new System.Windows.Forms.Padding(2);
			this.gbProveedores.Name = "gbProveedores";
			this.gbProveedores.Padding = new System.Windows.Forms.Padding(2);
			this.gbProveedores.Size = new System.Drawing.Size(298, 182);
			this.gbProveedores.TabIndex = 33;
			this.gbProveedores.TabStop = false;
			this.gbProveedores.Text = "Datos Categoria";
			// 
			// txtEmail
			// 
			this.txtEmail.Enabled = false;
			this.txtEmail.Location = new System.Drawing.Point(74, 156);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(167, 20);
			this.txtEmail.TabIndex = 15;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(5, 159);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(37, 13);
			this.label15.TabIndex = 29;
			this.label15.Text = "Email";
			// 
			// txtTel
			// 
			this.txtTel.Enabled = false;
			this.txtTel.Location = new System.Drawing.Point(74, 132);
			this.txtTel.Margin = new System.Windows.Forms.Padding(2);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(167, 20);
			this.txtTel.TabIndex = 14;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(5, 135);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(57, 13);
			this.label14.TabIndex = 27;
			this.label14.Text = "Telefono";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(5, 109);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(61, 13);
			this.label13.TabIndex = 26;
			this.label13.Text = "Direccion";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Enabled = false;
			this.txtDireccion.Location = new System.Drawing.Point(74, 106);
			this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(167, 20);
			this.txtDireccion.TabIndex = 13;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(5, 85);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(50, 13);
			this.label12.TabIndex = 24;
			this.label12.Text = "Cedula:";
			// 
			// txtCedula
			// 
			this.txtCedula.Enabled = false;
			this.txtCedula.Location = new System.Drawing.Point(74, 82);
			this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(167, 20);
			this.txtCedula.TabIndex = 12;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_67_111124;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(168, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(33, 27);
			this.button1.TabIndex = 22;
			this.toolTip1.SetToolTip(this.button1, "Buscar proveedores");
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(5, 59);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "Nombre:";
			// 
			// txtProveedor
			// 
			this.txtProveedor.Enabled = false;
			this.txtProveedor.Location = new System.Drawing.Point(74, 56);
			this.txtProveedor.Margin = new System.Windows.Forms.Padding(2);
			this.txtProveedor.Name = "txtProveedor";
			this.txtProveedor.Size = new System.Drawing.Size(167, 20);
			this.txtProveedor.TabIndex = 11;
			// 
			// txtIdproveedor
			// 
			this.txtIdproveedor.Enabled = false;
			this.txtIdproveedor.Location = new System.Drawing.Point(87, 29);
			this.txtIdproveedor.Margin = new System.Windows.Forms.Padding(2);
			this.txtIdproveedor.Name = "txtIdproveedor";
			this.txtIdproveedor.Size = new System.Drawing.Size(76, 20);
			this.txtIdproveedor.TabIndex = 10;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(5, 32);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 13);
			this.label11.TabIndex = 1;
			this.label11.Text = "ID Proveedor";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.BackgroundImage = global::Sistema_inventario.Properties.Resources.if_new10_216291;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Location = new System.Drawing.Point(245, 67);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 35);
			this.button2.TabIndex = 16;
			this.toolTip1.SetToolTip(this.button2, "Agregar cedula");
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// toolTip1
			// 
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Informacion";
			// 
			// inventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Sistema_inventario.Properties.Resources.fondocliente3;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(834, 368);
			this.Controls.Add(this.rdProveedor);
			this.Controls.Add(this.gbProveedores);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.rdCategoria);
			this.Controls.Add(this.gbCategoria);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.gbProducto);
			this.Controls.Add(this.rdProducto);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "inventario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "inventario";
			this.Load += new System.EventHandler(this.inventario_Load);
			this.gbCategoria.ResumeLayout(false);
			this.gbCategoria.PerformLayout();
			this.gbProducto.ResumeLayout(false);
			this.gbProducto.PerformLayout();
			this.gbProveedores.ResumeLayout(false);
			this.gbProveedores.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.RadioButton rdCategoria;
		private System.Windows.Forms.GroupBox gbCategoria;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCategoria;
		private System.Windows.Forms.TextBox txtidCategoria;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnAgregarCategoria;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.GroupBox gbProducto;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbCategoria;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbProveedor;
		private System.Windows.Forms.TextBox txtDecrip;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtIdPro;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdProducto;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btnProducto;
		public System.Windows.Forms.Button btnEliminar;
		public System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.RadioButton rdProveedor;
		private System.Windows.Forms.GroupBox gbProveedores;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtProveedor;
		private System.Windows.Forms.TextBox txtIdproveedor;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}