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
using System.Data.Entity;

namespace Sistema_inventario
{
	public partial class Ventas : Form
	{
		sistemaEntities db = new sistemaEntities();
		public Ventas()
		{
			InitializeComponent();			
		}
		public cliente _cliente = new cliente();	

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			int cantidad = 0;

			int.TryParse(txtCantidad.Text,out cantidad);

			if (cantidad <= 0)
			{
				MessageBox.Show("Favor de ingresar cantidad", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			AgregarProducto();
			LimpiarDatosProducto();
		}

		private void LimpiarDatosProducto()
		{
			foreach (Control x in gbProductos.Controls)
			{
				if (x is TextBox)
					x.Text = "";
			}		
				
		
		}

		
		public void AgregarProducto()
		{			
			
				if (txtIdVendedor.Text.Count() > 0 && txtIdCLiente.Text.Count() > 0)
				{
					venta pVenta = new venta();
					int i = 0;
					pVenta.IdCliente = Int32.Parse(txtIdCLiente.Text);
					pVenta.IdUsuario = Int32.Parse(txtIdVendedor.Text);
					int id_producto = int.Parse(txtIdArticulo.Text);

					detalle_venta detalle_Venta = new detalle_venta();

					if (db.venta.Count()>0)
					detalle_Venta.IdVenta = db.venta.Max(x=>x.IdVenta) + 1;
					else
					detalle_Venta.IdVenta = 1;

				detalle_Venta.producto = db.producto.Where(x => x.IdProducto == id_producto).FirstOrDefault();
				if (int.Parse(txtCantidad.Text) > detalle_Venta.producto.Stock)
				{
					MessageBox.Show("La cantidad que ingreso es mayor al stock disponible", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				detalle_Venta.producto.Stock -= int.Parse(txtCantidad.Text);
				
				noDuplicarproducto(detalle_Venta.IdVenta.ToString(), txtIdArticulo.Text, txtPre.Text, txtCantidad.Text, txtSubtotal.Text);				
				
				i += 1;
				}
				else
					MessageBox.Show("Debe de ingresar un cliente y/o vendedor", "LLenar los datos correctamente",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
			
		}

		private void noDuplicarproducto(string idVenta, string id_producto, string precio, string cantidad, string subtotal)
		{
			int _cantidad = 0;
			decimal _subTotal = 0;
			if (dataGridView1.Rows.Count > 0)
			{
				bool validar = false;
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{					
					int productoID = int.Parse(row.Cells[1].Value.ToString());
					if (id_producto == productoID.ToString())
					{
						_cantidad = int.Parse(row.Cells[3].Value.ToString());
						 _subTotal = decimal.Parse(row.Cells[4].Value.ToString());

						_cantidad += int.Parse(cantidad);
						_subTotal += decimal.Parse(subtotal);
						row.Cells[3].Value = _cantidad.ToString();
						row.Cells[4].Value = _subTotal.ToString();
						validar = true;
					}					
						
				}
				if (validar)
					return;

				dataGridView1.Rows.Add(idVenta, txtIdArticulo.Text, txtPre.Text, txtCantidad.Text, txtSubtotal.Text);
			} else
				dataGridView1.Rows.Add(idVenta, txtIdArticulo.Text, txtPre.Text, txtCantidad.Text, txtSubtotal.Text);

		}

		

		private void btnCliente_Click(object sender, EventArgs e)
		{					
			BusquedaClientes b = new BusquedaClientes();
			BusquedaClientes.formulario = "ventas";
			BusquedaClientes._ventas = this;
			b.ShowDialog();
		}

		private void btnProducto_Click(object sender, EventArgs e)
		{
			BusquedaProductos p = new BusquedaProductos();
			BusquedaProductos.formulario = "ventas";
			BusquedaProductos._ventas = this;
			p.ShowDialog();
		}

		private void Ventas_Load(object sender, EventArgs e)
		{
			llenarCLientes();			
			llenarProductos();
			llenarVendedor();

		}

		private void llenarProductos()
		{
			cbProductos.DataSource = (from x in db.producto select x).ToList();
			cbProductos.DisplayMember = "Nombre";
			cbProductos.ValueMember = "IdProducto";
		}

		private void llenarVendedor()
		{
			try
			{
				usuarios busquedaVendedor = Menu_principal._usuario;
				txtNombreVendedor.Text = busquedaVendedor.Nombre;
				txtApeVendedor.Text = busquedaVendedor.Apellido;
				txtIdVendedor.Text = busquedaVendedor.IdUsuario.ToString();
			}
			catch { }
			
			
		}

		private void llenarCLientes()
		{
			cbClientes.DataSource = (from x in db.cliente select x).ToList();
			cbClientes.DisplayMember = "Nombre";
			cbClientes.ValueMember = "IdCLiente";
		}

		private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int id = int.Parse(cbClientes.SelectedValue.ToString());
				llenarTxtClientes(BusquedaCLientesCombo(id).FirstOrDefault());
			}
			catch
			{

			}
		
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
			cbClientes.SelectedValue = c.IdCliente;
		}


		public List<producto> BusquedaProductosComboProducto(int id)
		{
			return db.producto.Where(x => x.IdProducto == id).ToList();

		}

		public void llenarTxtProductos(producto p)
		{
			txtIdArticulo.Text = p.IdProducto.ToString();
			txtDescri.Text = p.Descripcion;
			txtPre.Text = p.PrecioUnitario.ToString();
			txtCantidad.Text = "0";
			txtStock.Text = p.Stock.ToString();
			cbProductos.SelectedValue = p.IdProducto;
		}

		private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int id = int.Parse(cbProductos.SelectedValue.ToString());
				llenarTxtProductos(BusquedaProductosComboProducto(id).FirstOrDefault());
			}
			catch { }
		}

		private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validacion val = new Validacion();
			val.Numeros(e);
		}

		private void txtCantidad_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int cantidad = int.Parse(txtCantidad.Text);
				decimal precio = decimal.Parse(txtPre.Text);
				decimal total = cantidad * precio;
				int stock = int.Parse(txtStock.Text);
				txtSubtotal.Text = total.ToString();
				//if (cantidad > stock)
				//{
				//	MessageBox.Show("No tiene esta cantidad disponible","cantidad no aceptada",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				//	txtCantidad.Text = stock.ToString();
				//}
			}
			catch {
				txtSubtotal.Text = "0";
			}
			
		}

		private void BtnEliminar_Click(object sender, EventArgs e)
		{
			eliminarProducto();
			LimpiarDatosProducto();
		}

		private void eliminarProducto()
		{
			Int32 celdasSeleccionadas = dataGridView1.SelectedRows.Count;

			if (celdasSeleccionadas > 0)
			{
				foreach (DataGridViewRow r in dataGridView1.SelectedRows)
				{
					dataGridView1.Rows.Remove(r);
					aumentarStock(r);
				}

			}
			else
				MessageBox.Show("Debe seleccionar por lo menos 1 producto", "Seleccion invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void aumentarStock(DataGridViewRow row)
		{

			detalle_venta detalle_Venta = new detalle_venta();
			int productoID = int.Parse(row.Cells[1].Value.ToString());			
			int _cantidad = int.Parse(row.Cells[3].Value.ToString());

			producto _producto= db.producto.Where(x => x.IdProducto == productoID).FirstOrDefault();
			_producto.Stock += _cantidad;
			
				
			
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int id_producto;

			id_producto = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
			llenarTxtProductos(BusquedaProductosComboProducto(id_producto).FirstOrDefault());

			txtCantidad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

		}

		private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			calcularPago();
		}

		private void calcularPago()
		{
			decimal subtotalGeneral = 0;
			foreach (DataGridViewRow r in dataGridView1.Rows)
			{
			  subtotalGeneral +=decimal.Parse(r.Cells[4].Value.ToString());
			}
			txtSubtotalGen.Text = subtotalGeneral.ToString();
			txtSubtotalGeneral.Text = subtotalGeneral.ToString();
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			calcularPago();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (int.Parse(txtDescuento.Text) > 50)
				{
					txtDescuento.Text = "50";
					MessageBox.Show("No se puede aplicar un descuento mayor al 50%", "Descuento excedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				int descuento = int.Parse(txtDescuento.Text);
				if (descuento > 0)
				{
					decimal subtotal = decimal.Parse(txtSubtotalGen.Text);
					decimal totalDescuento = (subtotal * descuento) /100;
					txtSubtotalGeneral.Text = (subtotal - totalDescuento).ToString();

					decimal subtotalgeneral = decimal.Parse(txtSubtotalGeneral.Text);
					decimal itebis = decimal.Parse(txtItebis.Text);
					txtTOtal_general.Text = (subtotalgeneral + itebis).ToString();
				}
			}
			catch (Exception)
			{
				txtSubtotalGeneral.Text = txtSubtotalGen.Text;
				
			}

		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validacion val = new Validacion();
			val.Numeros(e);
		}

		private void txtSubtotalGeneral_TextChanged(object sender, EventArgs e)
		{

			try
			{
				decimal subtotalgeneral = decimal.Parse(txtSubtotalGen.Text);
				decimal itebis = decimal.Parse(txtItebis.Text);
				txtTOtal_general.Text = (subtotalgeneral + itebis).ToString();
			}
			catch (Exception)
			{

			}

		}

		private void txtSubtotalGen_TextChanged(object sender, EventArgs e)
		{
			try
			{
				decimal itebis = 0;
				itebis = ((decimal.Parse(txtSubtotalGen.Text) * 18) / 100);
				txtItebis.Text = itebis.ToString();

			}
			catch (Exception)
			{

			
			}
		
		}

		private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			calcularPago();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			db = new sistemaEntities();
			LimpiarDatosProducto();
			LimpiarDatosCliente();
			LimpiarDatosPagos();
			dataGridView1.Rows.Clear();
		}

		private void LimpiarDatosPagos()
		{
			foreach (Control x in gbPagos.Controls)
			{
				if (x is TextBox)
					x.Text = "";
			}
		}

		private void LimpiarDatosCliente()
		{
			foreach (Control x in gbCLientes.Controls)
			{
				if (x is TextBox)
					x.Text = "";
				if (x is ComboBox)
					((ComboBox)x).SelectedValue = 0;
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			decimal total = 0;
			Compra_pago p = new Compra_pago();
			Compra_pago.formulario = "ventas";
			Compra_pago._ventas = this;
			decimal.TryParse(txtTOtal_general.Text,out total);
			p.total = total;			
			p.ShowDialog();
		}

		public async void facturarProducto(int id_tipoPago)
		{
			string tipo_venta = "";

			if (rdCliente.Checked)
				tipo_venta = rdCliente.Text;
			else
				tipo_venta = "Cliente" + rdCasual.Text;
			
			
			venta venta = new venta() {
				IdCliente = int.Parse(txtIdCLiente.Text),
				IdUsuario = int.Parse(txtIdVendedor.Text),
				Fecha_Venta = dateTimePicker1.Value.ToShortDateString(),
				Tipo_Documento = tipo_venta
			};
			db.venta.Add(venta);
			db.SaveChanges();

			agregardetalleventas(id_tipoPago);			
			await db.SaveChangesAsync();

			MessageBox.Show("Factura generada correctamente", "Factura generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

			LimpiarDatosProducto();
			LimpiarDatosCliente();
			LimpiarDatosPagos();
			dataGridView1.Rows.Clear();
			

		}		

		private void agregardetalleventas(int id_tipoPago)
		{
			if (dataGridView1.Rows.Count > 0)
			{
				int descuento;
				int.TryParse(txtDescuento.Text, out descuento);
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{

					detalle_venta detalle = new detalle_venta() {
						IdVenta = int.Parse(row.Cells[0].Value.ToString()),
						IdProducto = int.Parse(row.Cells[1].Value.ToString()),
						Precio_Unitario = decimal.Parse(row.Cells[2].Value.ToString()),
						Cantidad = int.Parse(row.Cells[3].Value.ToString()),
						Descuento = descuento,
						IdReporte = id_tipoPago						
					};
					db.detalle_venta.Add(detalle);
				}
				

			}
		}
	}
}
