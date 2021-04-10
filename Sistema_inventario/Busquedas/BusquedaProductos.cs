using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_inventario.Busquedas
{
	public partial class BusquedaProductos : Form
	{
		public static string formulario;
		public BusquedaProductos()
		{
			InitializeComponent();
		}
		sistemaEntities db = new sistemaEntities();
		public static Ventas _ventas = new Ventas();
		public static inventario _inventario = new inventario();
		public static Compras _compras = new Compras();
		private void label4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

			Int32 FilasSeleccionadas = dataGridView1.SelectedRows.Count;

			if (FilasSeleccionadas == 1)
			{
				switch (formulario)
				{
					case "ventas":
						llenarFormularioVentas();
						break;
					case "inventario":
						llenarFormularioInventario();
						break;
					case "compras":
						llenarFormularioCompras();
						break;
				}
					
				
			}
			else
				MessageBox.Show("Debe seleccionar una fila completa", "Solo se acepta 1 fila", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void llenarFormularioCompras()
		{
			int ProductoID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

			producto ProductoSelecionado = (from x in db.producto where x.IdProducto == ProductoID select x).FirstOrDefault();
			this.Hide();

			if (ProductoSelecionado != null)
			{
				_compras.llenarTxtProductos(_inventario.BusquedaProducto(ProductoID).FirstOrDefault());
				
			}
		}

		private void llenarFormularioInventario()
		{
			int ProductoID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

			producto ProductoSelecionado = (from x in db.producto where x.IdProducto == ProductoID select x).FirstOrDefault();
			this.Hide();

			if (ProductoSelecionado != null)
			{
				_inventario.llenarTxtProductos(_inventario.BusquedaProducto(ProductoID).FirstOrDefault());
				_inventario.btnModificar.Enabled = true;
				_inventario.btnEliminar.Enabled = true;
			}
		}

		private void llenarFormularioVentas()
		{
			int ProductoID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

			producto ProductoSelecionado = (from x in db.producto where x.IdProducto == ProductoID select x).FirstOrDefault();
			this.Hide();

			if (ProductoSelecionado != null)
			{
				_ventas.llenarTxtProductos(_ventas.BusquedaProductosComboProducto(ProductoID).FirstOrDefault());
				
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void BusquedaProductos_Load(object sender, EventArgs e)
		{
			llenarProductos();
		}

		private void llenarProductos()
		{
			dataGridView1.DataSource = (from x in db.producto
										join b in db.proveedor on x.IdProveedor equals b.IdProveedor
										join c in db.categoria on x.IdCategoria equals c.IdCategoria
										select new
										{
											x.IdProducto,
											x.Nombre,
											x.Descripcion,
											x.Stock,
											x.PrecioUnitario,
											proveedor = b.Nombre,
											categoria = c.Nombre
										}).ToList();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			db = new sistemaEntities();
			if (textBox1.Text.Count() > 0)
				dataGridView1.DataSource = (from x in db.producto
											join b in db.proveedor on x.IdProveedor equals b.IdProveedor
											join c in db.categoria on x.IdCategoria equals c.IdCategoria
											where x.Nombre.StartsWith(textBox1.Text) || x.Descripcion.StartsWith(textBox1.Text)
											select new
											{
												x.IdProducto,
												x.Nombre,
												x.Descripcion,
												x.Stock,
												x.PrecioUnitario,
												proveedor = b.Nombre,
												categoria = c.Nombre

											}).ToList();
			else
				llenarProductos();
		}
	}
}
