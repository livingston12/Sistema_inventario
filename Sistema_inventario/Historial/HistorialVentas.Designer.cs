﻿namespace Sistema_inventario.Historial
{
	partial class HistorialVentas
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
			this.GvHistorialVentas = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProducto = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.GvHistorialVentas)).BeginInit();
			this.SuspendLayout();
			// 
			// GvHistorialVentas
			// 
			this.GvHistorialVentas.BackgroundColor = System.Drawing.Color.White;
			this.GvHistorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GvHistorialVentas.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.GvHistorialVentas.Location = new System.Drawing.Point(0, 72);
			this.GvHistorialVentas.Name = "GvHistorialVentas";
			this.GvHistorialVentas.Size = new System.Drawing.Size(878, 417);
			this.GvHistorialVentas.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(88, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Producto";
			// 
			// txtProducto
			// 
			this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProducto.Location = new System.Drawing.Point(190, 28);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(444, 27);
			this.txtProducto.TabIndex = 2;
			this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
			// 
			// HistorialVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Sistema_inventario.Properties.Resources.menuPrincipal;
			this.ClientSize = new System.Drawing.Size(878, 489);
			this.Controls.Add(this.txtProducto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GvHistorialVentas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HistorialVentas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Historial de Ventas";
			this.Load += new System.EventHandler(this.HistoriaVentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.GvHistorialVentas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView GvHistorialVentas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtProducto;
	}
}