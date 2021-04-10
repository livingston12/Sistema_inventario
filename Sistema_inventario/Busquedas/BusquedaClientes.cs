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
	public partial class BusquedaClientes : Form
	{
		public BusquedaClientes()
		{
			InitializeComponent();			
		}		
		
		public static Ventas _ventas = new Ventas();
		public static Clientes _clientes = new Clientes();
		public static string formulario;
		sistemaEntities db = new sistemaEntities();

		private void label4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			db = new sistemaEntities();
			if (textBox1.Text.Count() > 0)
				dataGridView1.DataSource = (from x in db.cliente
											where x.Nombre.StartsWith(textBox1.Text) || x.Apellido.StartsWith(textBox1.Text) || x.IdCliente.ToString().StartsWith(textBox1.Text)
											select new
											{
												x.IdCliente,
												x.Nombre,
												x.Apellido,
												x.Correo,
												x.Direccion,
												x.Telefono,
												cedula = x.DUI
											}).ToList();
			else
				llenarClientes();

		}

		private void llenarClientes()
		{
			dataGridView1.DataSource = (from x in db.cliente
										select new
										{
											x.IdCliente,
											x.Nombre,
											x.Apellido,
											x.Correo,
											x.Direccion,
											x.Telefono,
											cedula = x.DUI
										}).ToList();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Int32 celdasSeleccionadas = dataGridView1.SelectedRows.Count;

			if (celdasSeleccionadas == 1)
			{									
					int clienteID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
				
				cliente ClienteSelecionado = (from x in db.cliente where x.IdCliente == clienteID select x).FirstOrDefault();
					this.Hide();
					
					if (ClienteSelecionado != null)
					{
					switch (formulario)
					{
						case "cliente":
							_clientes.llenarTxtClientes(_clientes.BusquedaCLientesCombo(clienteID).FirstOrDefault());							
							break;
						case "ventas":
							_ventas.llenarTxtClientes(_ventas.BusquedaCLientesCombo(clienteID).FirstOrDefault());
					break;
						
							
					}
					
					}
				
			} else
				MessageBox.Show("Debe seleccionar una fila", "Solo se acepta 1 fila", MessageBoxButtons.OK, MessageBoxIcon.Information);
		
		}

		private void BusquedaClientes_Load(object sender, EventArgs e)
		{
			llenarClientes();
		}
	}
}
