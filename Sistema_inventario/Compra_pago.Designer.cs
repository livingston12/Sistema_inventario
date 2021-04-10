namespace Sistema_inventario
{
	partial class Compra_pago
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
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtEfectivo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnPago = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.cbMetodo = new System.Windows.Forms.ComboBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblDevuelta = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Dock = System.Windows.Forms.DockStyle.Right;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(355, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "X";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(15, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "Total";
			// 
			// txtTotal
			// 
			this.txtTotal.Enabled = false;
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.ForeColor = System.Drawing.Color.Red;
			this.txtTotal.Location = new System.Drawing.Point(87, 132);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(102, 29);
			this.txtTotal.TabIndex = 14;
			// 
			// txtEfectivo
			// 
			this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEfectivo.ForeColor = System.Drawing.Color.Red;
			this.txtEfectivo.Location = new System.Drawing.Point(186, 48);
			this.txtEfectivo.Name = "txtEfectivo";
			this.txtEfectivo.Size = new System.Drawing.Size(185, 29);
			this.txtEfectivo.TabIndex = 16;
			this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
			this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 20);
			this.label2.TabIndex = 15;
			this.label2.Text = "Cantidad Efectivo";
			// 
			// btnPago
			// 
			this.btnPago.BackgroundImage = global::Sistema_inventario.Properties.Resources.pago;
			this.btnPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPago.ForeColor = System.Drawing.Color.Black;
			this.btnPago.Location = new System.Drawing.Point(9, 42);
			this.btnPago.Name = "btnPago";
			this.btnPago.Size = new System.Drawing.Size(80, 57);
			this.btnPago.TabIndex = 17;
			this.btnPago.UseVisualStyleBackColor = true;
			this.btnPago.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 20);
			this.label3.TabIndex = 18;
			this.label3.Text = "Metodo pago";
			// 
			// cbMetodo
			// 
			this.cbMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMetodo.FormattingEnabled = true;
			this.cbMetodo.Location = new System.Drawing.Point(186, 89);
			this.cbMetodo.Name = "cbMetodo";
			this.cbMetodo.Size = new System.Drawing.Size(121, 28);
			this.cbMetodo.TabIndex = 19;
			// 
			// btnSalir
			// 
			this.btnSalir.BackgroundImage = global::Sistema_inventario.Properties.Resources.exit;
			this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.Black;
			this.btnSalir.Location = new System.Drawing.Point(286, 42);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(80, 57);
			this.btnSalir.TabIndex = 22;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel1
			// 
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.btnPago);
			this.panel1.Controls.Add(this.btnSalir);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 168);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(378, 105);
			this.panel1.TabIndex = 23;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(378, 21);
			this.panel2.TabIndex = 24;
			// 
			// lblDevuelta
			// 
			this.lblDevuelta.AutoSize = true;
			this.lblDevuelta.BackColor = System.Drawing.Color.Transparent;
			this.lblDevuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDevuelta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblDevuelta.Location = new System.Drawing.Point(308, 139);
			this.lblDevuelta.Name = "lblDevuelta";
			this.lblDevuelta.Size = new System.Drawing.Size(21, 24);
			this.lblDevuelta.TabIndex = 24;
			this.lblDevuelta.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(211, 137);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 24);
			this.label5.TabIndex = 23;
			this.label5.Text = "Devuelta";
			// 
			// Compra_pago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(378, 273);
			this.Controls.Add(this.lblDevuelta);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cbMetodo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEfectivo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Compra_pago";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Compra_pago";
			this.Load += new System.EventHandler(this.Compra_pago_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtEfectivo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnPago;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbMetodo;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblDevuelta;
		private System.Windows.Forms.Label label5;
	}
}