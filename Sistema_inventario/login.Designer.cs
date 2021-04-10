namespace Sistema_inventario
{
	partial class login
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
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContra = new System.Windows.Forms.TextBox();
			this.BtnSalir = new System.Windows.Forms.Button();
			this.btnSesion = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtUsuario
			// 
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsuario.Location = new System.Drawing.Point(203, 72);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(153, 13);
			this.txtUsuario.TabIndex = 0;
			// 
			// txtContra
			// 
			this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtContra.Location = new System.Drawing.Point(203, 114);
			this.txtContra.Name = "txtContra";
			this.txtContra.Size = new System.Drawing.Size(153, 13);
			this.txtContra.TabIndex = 1;
			this.txtContra.UseSystemPasswordChar = true;
			// 
			// BtnSalir
			// 
			this.BtnSalir.BackColor = System.Drawing.Color.Azure;
			this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSalir.Location = new System.Drawing.Point(282, 160);
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(75, 37);
			this.BtnSalir.TabIndex = 8;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.UseVisualStyleBackColor = false;
			// 
			// btnSesion
			// 
			this.btnSesion.BackColor = System.Drawing.Color.Azure;
			this.btnSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSesion.Location = new System.Drawing.Point(170, 160);
			this.btnSesion.Name = "btnSesion";
			this.btnSesion.Size = new System.Drawing.Size(85, 37);
			this.btnSesion.TabIndex = 7;
			this.btnSesion.Text = "Iniciar Sesión";
			this.btnSesion.UseVisualStyleBackColor = false;
			this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.BackgroundImage = global::Sistema_inventario.Properties.Resources.Login_1;
			this.ClientSize = new System.Drawing.Size(449, 249);
			this.Controls.Add(this.BtnSalir);
			this.Controls.Add(this.btnSesion);
			this.Controls.Add(this.txtContra);
			this.Controls.Add(this.txtUsuario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TransparencyKey = System.Drawing.Color.Teal;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtContra;
		private System.Windows.Forms.Button BtnSalir;
		private System.Windows.Forms.Button btnSesion;
	}
}

