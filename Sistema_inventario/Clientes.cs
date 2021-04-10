using Sistema_inventario.Busquedas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_inventario
{
	public partial class Clientes : Form
	{
		public Clientes()
		{
			InitializeComponent();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			limpiarCLientes();
		}
		sistemaEntities db = new sistemaEntities();

		private void limpiarCLientes()
		{
			foreach (Control y in gbCLientes.Controls)
			{
				if (y is TextBox)
					y.Text = "";
			}
			btnAgregar.Enabled = true;
			btnModificar.Enabled = false;
			btnEliminar.Enabled = false;
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			limpiarCLientes();
		}

		private void btnCliente_Click(object sender, EventArgs e)
		{
			BusquedaClientes b = new BusquedaClientes();
			BusquedaClientes._clientes = this;
			BusquedaClientes.formulario = "cliente";
			b.ShowDialog();
		}
		public List<cliente> BusquedaCLientesCombo(int id)
		{
			return db.cliente.Where(x => x.IdCliente == id).ToList();

		}

		public void llenarTxtClientes(cliente c)
		{
			txtNombre.Text = c.Nombre;
			txtApellido.Text = c.Apellido;
			txtIdCLiente.Text = c.IdCliente.ToString();
			txtDireccionCli.Text = c.Direccion;
			txtDUICli.Text = c.DUI;
			txtCorreo.Text = c.Correo;
			txtTel.Text = c.Telefono;
			btnModificar.Enabled = true;
			btnEliminar.Enabled = true;
			btnAgregar.Enabled = false;			
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			try
			{
				int idCLiente = 0;

				int.TryParse(txtIdCLiente.Text, out idCLiente);
				if (idCLiente <= 0)
				{
					MessageBox.Show("Debe seleccionar un cliente !!", "Cliente invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				ModificarCliente(idCLiente);
				limpiarCLientes();
			}
			catch (Exception)
			{

			}

		}

		private void ModificarCliente(int idCLiente)
		{
			cliente cliente = BusquedaCLientesCombo(idCLiente).FirstOrDefault();
			cliente.Nombre = txtNombre.Text;
			cliente.Apellido = txtApellido.Text;
			cliente.Direccion = txtDireccionCli.Text;
			cliente.Correo = txtCorreo.Text;
			cliente.DUI = txtDUICli.Text;
			cliente.Telefono = txtTel.Text;
			db.SaveChanges();
			MessageBox.Show("Cliente modificado correctamente !!", "Cliente modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{			
				agregarCliente();
				limpiarCLientes();
			}
			catch
			{

			}
		}

		private void agregarCliente()
		{
			cliente cliente = new cliente();
			cliente.Nombre = txtNombre.Text;
			cliente.Apellido = txtApellido.Text;
			cliente.Direccion = txtDireccionCli.Text;
			cliente.Correo = txtCorreo.Text;
			cliente.DUI = txtDUICli.Text;
			cliente.Telefono = txtTel.Text;
			cliente.NIT = "";
			db.cliente.Add(cliente);
			db.SaveChanges();
			MessageBox.Show("Cliente agregado correctamente !!", "Cliente agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				int idCLiente = 0;

				int.TryParse(txtIdCLiente.Text, out idCLiente);
				if (idCLiente <= 0)
				{
					MessageBox.Show("Debe seleccionar un cliente !!", "Cliente invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				eliminarCliente(idCLiente);
				limpiarCLientes();
			}
			catch (Exception)
			{

			}
		}

		private void eliminarCliente(int idCliente)
		{
			cliente cliente = BusquedaCLientesCombo(idCliente).FirstOrDefault();
			db.cliente.Remove(cliente);
			db.SaveChanges();
			MessageBox.Show("Cliente eliminado correctamente !!", "Cliente eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
