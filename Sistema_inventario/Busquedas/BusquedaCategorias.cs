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
	public partial class BusquedaCategorias : Form
	{
		public BusquedaCategorias()
		{
			InitializeComponent();
		}
		public static string formulario;
		sistemaEntities db = new sistemaEntities();
		public static inventario _inventario = new inventario();


		private void lbCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

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
				}


			}
			else
				MessageBox.Show("Debe seleccionar una fila completa", "Solo se acepta 1 fila", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void llenarFormularioInventario()
		{
			int categoriaID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

			categoria ProductoSelecionado = (from x in db.categoria where x.IdCategoria == categoriaID select x).FirstOrDefault();
			this.Hide();

			if (ProductoSelecionado != null)
			{
				_inventario.llenarTxtCategorias(_inventario.BusquedaCategoria(categoriaID).FirstOrDefault());
				_inventario.btnModificar.Enabled = true;
				_inventario.btnEliminar.Enabled = true;
			}
		}

		private void txtBusqueda_TextChanged(object sender, EventArgs e)
		{
			db = new sistemaEntities();
			if (txtBusqueda.Text.Count() > 0)
				dataGridView1.DataSource = (from x in db.categoria
											where x.Nombre.StartsWith(txtBusqueda.Text)
											select new
											{
												x.IdCategoria,
												x.Nombre
											}).ToList();
			else
				llenarCategorias();


		}

		private void BusquedaCategorias_Load(object sender, EventArgs e)
		{
			llenarCategorias();
		}

		private void llenarCategorias()
		{
			dataGridView1.DataSource = (from x in db.categoria
										select new
										{
											x.IdCategoria,
											x.Nombre
										}).ToList();
		}
	}
}
