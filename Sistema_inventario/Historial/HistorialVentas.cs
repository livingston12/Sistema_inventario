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
	public partial class HistorialVentas : Form
	{
		public HistorialVentas()
		{
			InitializeComponent();
		}

		sistemaEntities db = new sistemaEntities();
		private void HistoriaVentas_Load(object sender, EventArgs e)
		{
			llenarHistorialVentas();
		}

		private void llenarHistorialVentas()
		{
			GvHistorialVentas.DataSource = db.vw_ventas.ToList();
		}

		private void txtProducto_TextChanged(object sender, EventArgs e)
		{
			BusquedaProducto(txtProducto.Text);
		}

		private void BusquedaProducto(string producto)
		{
			GvHistorialVentas.DataSource = db.vw_ventas.Where(x => x.producto.StartsWith(producto)|| x.vendedor.StartsWith(producto) || x.cliente.StartsWith(producto)).ToList();
		}
	}
}
