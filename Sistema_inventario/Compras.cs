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
	public partial class Compras : Form
	{
		public Compras()
		{
			InitializeComponent();
		}
		sistemaEntities db = new sistemaEntities();
		inventario _inventario = new inventario();
		private void BtnBuscarProveedor_Click(object sender, EventArgs e)
		{
			BusquedaProveedores p = new BusquedaProveedores();
			BusquedaProveedores.formulario = "compras";
			BusquedaProveedores._compras = this;
			p.ShowDialog();
		}

		public List<proveedor> BusquedaProveedor(int proveedorID)
		{
			return db.proveedor.Where(x => x.IdProveedor == proveedorID).ToList();
		}
		public void llenarTxtProveedores(proveedor p)
		{
			txtProveedor.Text = p.Nombre;
			cbProveedor.SelectedValue = p.IdProveedor;

		}

		private void Compras_Load(object sender, EventArgs e)
		{
			llenarTxtProveedores();
			llenarUsuario();
			llenarTxtProductos();

		}

		private void llenarTxtProductos()
		{
			cbProductos.DataSource = db.producto.ToList();			
			cbProductos.ValueMember = "idProducto";
			cbProductos.DisplayMember = "Nombre";
		}

		private void llenarUsuario()
		{
			try
			{
				usuarios busquedaVendedor = Menu_principal._usuario;
				txtNombre.Text = busquedaVendedor.Nombre;
				txtApellido.Text = busquedaVendedor.Apellido;
				txtIdUsuario.Text = busquedaVendedor.IdUsuario.ToString();
			}
			catch { }
		}

		private void llenarTxtProveedores()
		{
			cbProveedor.DataSource = db.proveedor.ToList();
			cbProveedor.ValueMember = "idProveedor";
			cbProveedor.DisplayMember = "idProveedor";
		}
		public List<producto> BusquedaProducto(int id)
		{
			return db.producto.Where(x => x.IdProducto == id).ToList();

		}
		public void llenarTxtProductos(producto p)
		{
			txtIdPro.Text = p.IdProducto.ToString();
			txtDescriPro.Text = p.Nombre + " (" + p.Descripcion +")";
			txtventaPro.Text = p.PrecioUnitario.ToString();			
			cbProductos.SelectedValue = p.IdProveedor;
		}
		private void btnProducto_Click(object sender, EventArgs e)
		{
			BusquedaProductos p = new BusquedaProductos();
			BusquedaProductos.formulario = "compras";
			BusquedaProductos._compras = this;
			p.ShowDialog();
		}

		private void txtCantPro_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validacion val = new Validacion();
			val.Numeros(e);
		}

		private void txtCantPro_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int cantidad = 0;
				decimal precioVenta = 0,total=0;

				precioVenta = decimal.Parse(txtPreProd.Text);
				cantidad = int.Parse(txtCantPro.Text);
				total = (precioVenta * cantidad);
				txtTotalPro.Text = total.ToString();
			}
			catch (Exception)
			{
				txtTotalPro.Text = "0";				
			}
		}

		private void btnAgregarPro_Click(object sender, EventArgs e)
		{
			int cantidad = 0,precio=0;
			int.TryParse(txtCantPro.Text, out cantidad);
			int.TryParse(txtPreProd.Text, out precio);
			if (cantidad <= 0)
			{
				MessageBox.Show("Favor de ingresar cantidad", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (precio <= 0)
			{
				MessageBox.Show("Favor de ingresar un precio", "precio incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			AgregarProducto();
			LimpiarDatosProducto();

		}

		List<detalle_venta> lista_detalle_Venta = new List<detalle_venta>();
		public void AgregarProducto()
		{

			if (txtIdUsuario.Text.Count() > 0 && txtProveedor.Text.Count() > 0)
			{
				compra compra = new compra();
				int i = 0;
				compra.Precio_Compra = decimal.Parse(txtPreProd.Text);
				compra.Precio_Venta = decimal.Parse(txtventaPro.Text);
				compra.Fecha_Compra = dateTimePicker1.Value.ToString();
				compra.Proveedor_IdProveedor = int.Parse(cbProveedor.SelectedValue.ToString());

				detalle_compra detalle_compra = new detalle_compra();
				if (db.compra.Count() > 0)
					detalle_compra.IdCompra = db.compra.Max(x => x.IdCompra) + 1;
				else
					detalle_compra.IdCompra = 1;

				detalle_compra.IdProducto = int.Parse(txtIdPro.Text);
				detalle_compra.producto = db.producto.Where(x => x.IdProducto == detalle_compra.IdProducto).FirstOrDefault();
				detalle_compra.producto.Stock += int.Parse(txtCantPro.Text);

				noDuplicarproducto(detalle_compra.IdProducto, detalle_compra.IdCompra, txtDescriPro.Text,decimal.Parse(txtventaPro.Text),decimal.Parse(txtPreProd.Text),int.Parse(txtCantPro.Text),decimal.Parse(txtTotalPro.Text));
				

				i += 1;
			}
			else
				MessageBox.Show("Debe de ingresar un cliente y/o vendedor", "LLenar los datos correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);


		}

		private void noDuplicarproducto(int idProducto, int id_Compra, string Descripcion,decimal precio,decimal precio_compra, int cantidad, decimal subtotal)
		{
			int _cantidad = 0;
			decimal _subTotal = 0;
			if (dvProductos.Rows.Count > 0)
			{
				bool validar = false;
				foreach (DataGridViewRow row in dvProductos.Rows)
				{
					int productoID = int.Parse(row.Cells[0].Value.ToString());
					if (idProducto == productoID)
					{
						_cantidad = int.Parse(row.Cells["cantidad"].Value.ToString());
						_subTotal = decimal.Parse(row.Cells["total"].Value.ToString());
						_cantidad += cantidad;
						_subTotal += subtotal;
						row.Cells["cantidad"].Value = _cantidad.ToString();
						row.Cells["total"].Value = _subTotal.ToString();
						validar = true;
					}

				}
				if (validar)
					return;

				dvProductos.Rows.Add(idProducto, id_Compra, Descripcion, precio, precio_compra, cantidad, subtotal);
			}
			else
				dvProductos.Rows.Add(idProducto, id_Compra, Descripcion, precio, precio_compra, cantidad, subtotal);

		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			decimal total = 0;
			Compra_pago p = new Compra_pago();
			Compra_pago.formulario = "compras";
			Compra_pago._compras = this;
			decimal.TryParse(txtTOtal_general.Text, out total);
			p.total = total;
			p.ShowDialog();
		}

		private void btnEliminarPro_Click(object sender, EventArgs e)
		{

		}
		private void eliminarProducto()
		{
			Int32 celdasSeleccionadas = dvProductos.SelectedRows.Count;

			if (celdasSeleccionadas > 0)
			{
				foreach (DataGridViewRow r in dvProductos.SelectedRows)
				{
					dvProductos.Rows.Remove(r);
					DisminuirStock(r);
				}

			}
			else
				MessageBox.Show("Debe seleccionar por lo menos 1 producto", "Seleccion invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void DisminuirStock(DataGridViewRow row)
		{		
				detalle_venta detalle_Venta = new detalle_venta();
				int productoID = int.Parse(row.Cells[0].Value.ToString());
				int _cantidad = int.Parse(row.Cells["cantidad"].Value.ToString());
				producto _producto = db.producto.Where(x => x.IdProducto == productoID).FirstOrDefault();
				_producto.Stock -= _cantidad;			
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnNuevo_Click(object sender, EventArgs e)
		{

			db = new sistemaEntities();
			LimpiarDatosProducto();
			LimpiarDatosProveedor();
			LimpiarDatosPagos();
			dvProductos.Rows.Clear();
		}

		private void LimpiarDatosProducto()
		{
			foreach (Control x in gbProductos.Controls)
			{
				if (x is TextBox)
					x.Text = "";
			}


		}

		private void LimpiarDatosPagos()
		{
			foreach (Control x in gbPagos.Controls)
			{
				if (x is TextBox)
					x.Text = "";
			}
		}

		private void LimpiarDatosProveedor()
		{
			foreach (Control x in gbProveedores.Controls)
			{
				if (x is TextBox)
					x.Text = "";
				if (x is ComboBox)
					((ComboBox)x).SelectedValue = 0;
			}
		}

		private void dvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int id_producto;

			id_producto = int.Parse(dvProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
			llenarTxtProductos(_inventario.BusquedaProducto(id_producto).FirstOrDefault());

			txtPreProd.Text =  dvProductos.Rows[e.RowIndex].Cells["preciocompra"].Value.ToString();
			txtCantPro.Text = dvProductos.Rows[e.RowIndex].Cells["cantidad"].Value.ToString();

		}

		private void dvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			calcularPago();
		}

		private void calcularPago()
		{
			decimal subtotalGeneral = 0;
			foreach (DataGridViewRow r in dvProductos.Rows)
			{
				subtotalGeneral += decimal.Parse(r.Cells["total"].Value.ToString());
			}
			txtSubtotalGen.Text = subtotalGeneral.ToString();
			txtTOtal_general.Text = subtotalGeneral.ToString();
		}

		private void dvProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			calcularPago();
		}

		private void dvProductos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			calcularPago();
		}

		public async void facturarProducto(int id_tipoPago)
		{


			compra compra = new compra()
			{
				Precio_Compra = decimal.Parse(txtTOtal_general.Text),
				Precio_Venta = decimal.Parse(txtTOtal_general.Text),
				Fecha_Compra = dateTimePicker1.Value.ToShortDateString(),
				Proveedor_IdProveedor = int.Parse(cbProveedor.SelectedValue.ToString())
			};
			db.compra.Add(compra);
			db.SaveChanges();

			agregardetalleCompras(id_tipoPago);
			await db.SaveChangesAsync();
			
			MessageBox.Show("Factura generada correctamente", "Factura generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

			LimpiarDatosProducto();
			LimpiarDatosProveedor();
			LimpiarDatosPagos();
			dvProductos.Rows.Clear();


		}

		private void agregardetalleCompras(int id_tipoPago)
		{
			if (dvProductos.Rows.Count > 0)
			{
				
				foreach (DataGridViewRow row in dvProductos.Rows)
				{
					int detalleID = 0;
					int productoID = int.Parse(row.Cells[0].Value.ToString());
					decimal precioVenta = decimal.Parse(row.Cells["precio"].Value.ToString());
					producto pro = db.producto.Where(x => x.IdProducto == productoID).FirstOrDefault();
					

					if (precioVenta > pro.PrecioUnitario)
					{
						pro.PrecioUnitario = precioVenta;						
						db.SaveChanges();
					}
					if (db.detalle_compra.Any())
					{
						detalleID = db.detalle_compra.Max(x => x.IdDetalle_Compra) + 1;
					}
					else
						detalleID = 1;
						

					detalle_compra detalle = new detalle_compra()
					{
					IdDetalle_Compra = 	detalleID,
						IdProducto = productoID,
						IdCompra = int.Parse(row.Cells[1].Value.ToString()),
						precio_compra = decimal.Parse(row.Cells["preciocompra"].Value.ToString()),
						precio_venta = precioVenta,						
						IdReporte = id_tipoPago						

					};
					db.detalle_compra.Add(detalle);					
				}


			}
		}

		private void cbProductos_SelectedValueChanged(object sender, EventArgs e)
		{
			int id = int.Parse(cbProductos.SelectedValue.ToString());
			llenarTxtProductos(BusquedaProducto(id).FirstOrDefault());
		}
	}
}
