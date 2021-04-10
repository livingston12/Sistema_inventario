using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Sistema_inventario
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		sistemaEntities db = new sistemaEntities();
		private void btnSesion_Click(object sender, EventArgs e)
		{
			var busquedaUsuario = from x in db.usuarios where x.Usuario == txtUsuario.Text.Trim() && x.Password == txtContra.Text select x;
			if (busquedaUsuario.Any())
			{
				Menu_principal m = new Menu_principal(busquedaUsuario.FirstOrDefault());
				this.Hide();
				m.Show();
			}
			else
				MessageBox.Show("Usuario o Contraseña incorrectos !!", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}
	}
}
