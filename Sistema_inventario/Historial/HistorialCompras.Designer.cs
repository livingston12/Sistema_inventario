namespace Sistema_inventario.Historial
{
	partial class HistorialCompras
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
			this.GvHistorialCompras = new System.Windows.Forms.DataGridView();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.GvHistorialCompras)).BeginInit();
			this.SuspendLayout();
			// 
			// GvHistorialCompras
			// 
			this.GvHistorialCompras.BackgroundColor = System.Drawing.Color.White;
			this.GvHistorialCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GvHistorialCompras.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.GvHistorialCompras.Location = new System.Drawing.Point(0, 72);
			this.GvHistorialCompras.Name = "GvHistorialCompras";
			this.GvHistorialCompras.Size = new System.Drawing.Size(878, 417);
			this.GvHistorialCompras.TabIndex = 1;
			// 
			// txtProducto
			// 
			this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProducto.Location = new System.Drawing.Point(191, 21);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(444, 27);
			this.txtProducto.TabIndex = 4;
			this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(89, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Producto";
			// 
			// HistorialCompras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Sistema_inventario.Properties.Resources.menuPrincipal;
			this.ClientSize = new System.Drawing.Size(878, 489);
			this.Controls.Add(this.txtProducto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GvHistorialCompras);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HistorialCompras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HistorialCompras";
			this.Load += new System.EventHandler(this.HistorialCompras_Load);
			((System.ComponentModel.ISupportInitialize)(this.GvHistorialCompras)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView GvHistorialCompras;
		private System.Windows.Forms.TextBox txtProducto;
		private System.Windows.Forms.Label label1;
	}
}