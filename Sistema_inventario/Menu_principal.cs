using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_inventario.Busquedas;

namespace Sistema_inventario
{
	public partial class Menu_principal : Form
	{

		public static usuarios _usuario;
		public Menu_principal(usuarios usu)
		{
			InitializeComponent();
			_usuario = usu;
		}

		private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta Seguro que desea cerrar La aplicacion !!", "Desea cerrar la aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes) 
				Application.Exit();		
		}

		private void label3_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void vENTASPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Ventas v = new Ventas();
			v.ShowDialog();
		}

		private void cOMPRASPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Compras c = new Compras();
			c.ShowDialog();
		}

		private void iNVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			inventario i = new inventario();
			i.ShowDialog();
		}

		private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BusquedaClientes c = new BusquedaClientes();
			c.ShowDialog();

		}

		private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clientes c = new Clientes();
			c.ShowDialog();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Historial.HistorialVentas ventas= new Historial.HistorialVentas();
			ventas.ShowDialog();
		}

		private void comprasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Historial.HistorialCompras compras = new Historial.HistorialCompras();
			compras.ShowDialog();
		}
	}
}
