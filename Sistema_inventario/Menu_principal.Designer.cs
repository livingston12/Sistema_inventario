namespace Sistema_inventario
{
	partial class Menu_principal
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.vENTASPRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cOMPRASPRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iNVENTARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vENTASREALIZADASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comprasRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
			this.flowLayoutPanel1.BackgroundImage = global::Sistema_inventario.Properties.Resources.fondocliente3;
			this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(831, 479);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENTASPRODUCTOSToolStripMenuItem,
            this.cOMPRASPRODUCTOSToolStripMenuItem,
            this.cLIENTESToolStripMenuItem,
            this.iNVENTARIOToolStripMenuItem,
            this.vENTASREALIZADASToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(711, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// vENTASPRODUCTOSToolStripMenuItem
			// 
			this.vENTASPRODUCTOSToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.vENTASPRODUCTOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.vENTASPRODUCTOSToolStripMenuItem.Image = global::Sistema_inventario.Properties.Resources.VENTAS;
			this.vENTASPRODUCTOSToolStripMenuItem.Name = "vENTASPRODUCTOSToolStripMenuItem";
			this.vENTASPRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
			this.vENTASPRODUCTOSToolStripMenuItem.Text = "&VENTAS PRODUCTOS";
			this.vENTASPRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.vENTASPRODUCTOSToolStripMenuItem_Click);
			// 
			// cOMPRASPRODUCTOSToolStripMenuItem
			// 
			this.cOMPRASPRODUCTOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.cOMPRASPRODUCTOSToolStripMenuItem.Image = global::Sistema_inventario.Properties.Resources.COMPRAS2;
			this.cOMPRASPRODUCTOSToolStripMenuItem.Name = "cOMPRASPRODUCTOSToolStripMenuItem";
			this.cOMPRASPRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
			this.cOMPRASPRODUCTOSToolStripMenuItem.Text = "COMPRAS &PRODUCTOS";
			this.cOMPRASPRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.cOMPRASPRODUCTOSToolStripMenuItem_Click);
			// 
			// cLIENTESToolStripMenuItem
			// 
			this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarClientesToolStripMenuItem,
            this.agregarClientesToolStripMenuItem});
			this.cLIENTESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.cLIENTESToolStripMenuItem.Image = global::Sistema_inventario.Properties.Resources.CLIENTES;
			this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
			this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.cLIENTESToolStripMenuItem.Text = "&CLIENTES";
			// 
			// consultarClientesToolStripMenuItem
			// 
			this.consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
			this.consultarClientesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
			this.consultarClientesToolStripMenuItem.Click += new System.EventHandler(this.consultarClientesToolStripMenuItem_Click);
			// 
			// agregarClientesToolStripMenuItem
			// 
			this.agregarClientesToolStripMenuItem.Name = "agregarClientesToolStripMenuItem";
			this.agregarClientesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.agregarClientesToolStripMenuItem.Text = "Agregar Clientes";
			this.agregarClientesToolStripMenuItem.Click += new System.EventHandler(this.agregarClientesToolStripMenuItem_Click);
			// 
			// iNVENTARIOToolStripMenuItem
			// 
			this.iNVENTARIOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.iNVENTARIOToolStripMenuItem.Image = global::Sistema_inventario.Properties.Resources.INVENTARIO2;
			this.iNVENTARIOToolStripMenuItem.Name = "iNVENTARIOToolStripMenuItem";
			this.iNVENTARIOToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
			this.iNVENTARIOToolStripMenuItem.Text = "&INVENTARIO";
			this.iNVENTARIOToolStripMenuItem.Click += new System.EventHandler(this.iNVENTARIOToolStripMenuItem_Click);
			// 
			// vENTASREALIZADASToolStripMenuItem
			// 
			this.vENTASREALIZADASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.comprasRealizadasToolStripMenuItem});
			this.vENTASREALIZADASToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.vENTASREALIZADASToolStripMenuItem.Image = global::Sistema_inventario.Properties.Resources.VENTAS;
			this.vENTASREALIZADASToolStripMenuItem.Name = "vENTASREALIZADASToolStripMenuItem";
			this.vENTASREALIZADASToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
			this.vENTASREALIZADASToolStripMenuItem.Text = "&HISTORIAL";
			// 
			// ventaToolStripMenuItem
			// 
			this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
			this.ventaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.ventaToolStripMenuItem.Text = "Ventas realizadas";
			this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
			// 
			// comprasRealizadasToolStripMenuItem
			// 
			this.comprasRealizadasToolStripMenuItem.Name = "comprasRealizadasToolStripMenuItem";
			this.comprasRealizadasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.comprasRealizadasToolStripMenuItem.Text = "Compras realizadas";
			this.comprasRealizadasToolStripMenuItem.Click += new System.EventHandler(this.comprasRealizadasToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(3, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(194, 21);
			this.panel1.TabIndex = 4;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Right;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(156, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "-";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Right;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(173, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "X";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new System.Drawing.Point(3, 54);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(813, 419);
			this.panel2.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::Sistema_inventario.Properties.Resources._20751357_1613907158639675_2069124028_n;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(813, 419);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// Menu_principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(155)))), ((int)(((byte)(14)))));
			this.ClientSize = new System.Drawing.Size(831, 479);
			this.ControlBox = false;
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Menu_principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu_principal";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem vENTASPRODUCTOSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cOMPRASPRODUCTOSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iNVENTARIOToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStripMenuItem consultarClientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarClientesToolStripMenuItem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem vENTASREALIZADASToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem comprasRealizadasToolStripMenuItem;
	}
}