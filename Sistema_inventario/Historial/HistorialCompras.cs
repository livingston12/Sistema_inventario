using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_inventario.Historial
{
	public partial class HistorialCompras : Form
	{
		public HistorialCompras()
		{
			InitializeComponent();
		}
		sistemaEntities db = new sistemaEntities();

		private void HistorialCompras_Load(object sender, EventArgs e)
		{
			llenarHistorialCompras();
		}

		private void llenarHistorialCompras()
		{
			GvHistorialCompras.DataSource = db.vw_compras.ToList();
		}

		private void BusquedaProducto(string producto)
		{
			GvHistorialCompras.DataSource = db.vw_compras.Where(x => x.producto.StartsWith(producto) || x.categoria.StartsWith(producto) || x.proveedor.StartsWith(producto) || x.Descripcion.StartsWith(producto)).ToList();
		}

		private void txtProducto_TextChanged(object sender, EventArgs e)
		{
			BusquedaProducto(txtProducto.Text);
		}
	}
}
