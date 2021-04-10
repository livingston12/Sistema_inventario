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
	public partial class BusquedaProveedores : Form
	{


		public BusquedaProveedores()
		{
			InitializeComponent();
		}
		public static string formulario;
		sistemaEntities db = new sistemaEntities();
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
			int proveedorID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

			proveedor ProductoSelecionado = (from x in db.proveedor where x.IdProveedor == proveedorID select x).FirstOrDefault();
			this.Hide();

			if (ProductoSelecionado != null)
			{
				_compras.llenarTxtProveedores(_inventario.BusquedaProveedor(proveedorID).FirstOrDefault());
				
			}
		}

		private void llenarFormularioInventario()
		{
			int proveedorID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

			proveedor ProductoSelecionado = (from x in db.proveedor where x.IdProveedor == proveedorID select x).FirstOrDefault();
			this.Hide();

			if (ProductoSelecionado != null)
			{
				_inventario.llenarTxtProveedores(_inventario.BusquedaProveedor(proveedorID).FirstOrDefault());
				_inventario.btnModificar.Enabled = true;
				_inventario.btnEliminar.Enabled = true;
			}
		}

		private void txtBusqueda_TextChanged(object sender, EventArgs e)
		{
			db = new sistemaEntities();
			if (txtBusqueda.Text.Count() > 0)
				dataGridView1.DataSource = (from x in db.proveedor
											where (x.Nombre.StartsWith(txtBusqueda.Text) || x.Numero_Documento.StartsWith(txtBusqueda.Text))
											select new
											{
												x.IdProveedor,
												x.Nombre,
												x.Numero_Documento,
												x.Email,
												x.Direccion,
												x.Telefono

											}).ToList();
			else
				llenarProveedores();
		}

		private void llenarProveedores()
		{
			dataGridView1.DataSource = (from x in db.proveedor
										select new
										{
											x.IdProveedor,
											x.Nombre,
											x.Numero_Documento,
											x.Email,
											x.Direccion,
											x.Telefono
										}).ToList();
		}

		private void BusquedaProveedores_Load(object sender, EventArgs e)
		{
			llenarProveedores();

		}
	}
}
