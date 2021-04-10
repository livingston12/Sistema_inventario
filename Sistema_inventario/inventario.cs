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
	public partial class inventario : Form
	{
		public inventario()
		{
			InitializeComponent();
		}

		sistemaEntities db = new sistemaEntities();
		int idProducto = 0;
		int idCategoria = 0;
		int Idproveedor = 0;
		string mensaje = "";
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string mensaje = "";
				if (rdProducto.Checked == true)
				{
					int proveedor = 0;
					int categoria = 0;
					int.TryParse(cbProveedor.SelectedValue.ToString(), out proveedor);
					int.TryParse(cbCategoria.SelectedValue.ToString(), out categoria);

					if (proveedor > 0 && categoria > 0)
					{
						producto p = new producto();
						p.Nombre = txtNom.Text;
						p.Descripcion = txtDecrip.Text;
						p.PrecioUnitario = decimal.Parse(txtPrecio.Text);
						p.Stock = int.Parse(txtStock.Text);
						p.IdProveedor = proveedor;
						p.IdCategoria = categoria;
						db.producto.Add(p);
						mensaje = "Producto agregado correctamente !!";
					}
					else
						MessageBox.Show("Es obligatorio una categoria y un proveedor !!", "Llene los datos correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				

				db.SaveChanges();				
				BorrarFormularioProducto();			
				if (mensaje !="")
				MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch { }
		
		}

		public List<proveedor> BusquedaProveedor(int proveedorID)
		{
			return db.proveedor.Where(x => x.IdProveedor == proveedorID).ToList();
		}
		public void llenarTxtProveedores(proveedor p)
		{
			txtIdproveedor.Text = p.IdProveedor.ToString();
			txtProveedor.Text = p.Nombre;
			txtTel.Text = p.Telefono;
			txtEmail.Text = p.Email;
			txtCedula.Text = p.Numero_Documento;
			txtDireccion.Text = p.Direccion;
			
		}

		private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validacion v = new Validacion();
			v.Numeros(e);
		}

		private void inventario_Load(object sender, EventArgs e)
		{
			try
			{
				llenarProveedores();
				llenarCategorias();
			}
			catch
			{

			}

		
		}

		private void llenarCategorias()
		{
			categoria c = new categoria();
			c.IdCategoria = 0;
			c.Nombre = "--CATEGORIAS--";

			List<categoria> categoria = new List<categoria>();
			categoria.Add(c);
			categoria.AddRange(db.categoria.Select(x => x).ToList());
			cbCategoria.DataSource = categoria;
			cbCategoria.ValueMember = "idCategoria";
			cbCategoria.DisplayMember = "Nombre";
		}

		private void llenarProveedores()
		{

			proveedor c = new proveedor();
			c.IdProveedor = 0;
			c.Nombre = "--PROVEEDOR--";

			List<proveedor> proveedor = new List<proveedor>();
			proveedor.Add(c);
			proveedor.AddRange(db.proveedor.Select(x => x).ToList());

			cbProveedor.DataSource = proveedor;
			cbProveedor.ValueMember = "idProveedor";
			cbProveedor.DisplayMember = "Nombre";
		}

		void BorrarFormularioProducto()
		{
			foreach (Control x in gbProducto.Controls)
			{				
				if (x is TextBox)
					x.Text = "";
				if ( x is ComboBox)				
					((ComboBox)x).SelectedValue = 0;
				
					
			}
			
		}

		private void BorrarFormularioCategoria()
		{
			foreach (Control y in gbCategoria.Controls)
			{
				if (y is TextBox)
					y.Text = "";
			}
		}
		private void BorrarFormularioProveedores()
		{
			foreach (Control y in gbProveedores.Controls)
			{
				if (y is TextBox)
					y.Text = "";
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{

			if (rdCategoria.Checked == true)
			{
				categoria c = new categoria();
				c.Nombre = txtCategoria.Text;
				db.categoria.Add(c);

			}

			db.SaveChanges();
			BorrarFormularioCategoria();
			llenarCategorias();
			MessageBox.Show("Categoria agregada correctamente !!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnProducto_Click(object sender, EventArgs e)
		{
			BusquedaProductos p = new BusquedaProductos();
			BusquedaProductos.formulario = "inventario";
			BusquedaProductos._inventario = this;
			p.ShowDialog();
		}


		public List<producto> BusquedaProducto(int id)
		{
			return db.producto.Where(x => x.IdProducto == id).ToList();

		}
		public void llenarTxtProductos(producto p)
		{
			txtIdPro.Text = p.IdProducto.ToString();
			txtNom.Text = p.Nombre;
			txtPrecio.Text = p.PrecioUnitario.ToString();
			txtDecrip.Text = p.Descripcion;
			txtStock.Text = p.Stock.ToString();
			cbCategoria.SelectedValue = p.IdCategoria;
			cbProveedor.SelectedValue = p.IdProveedor;
		}
		public List<categoria> BusquedaCategoria(int id)
		{
			return db.categoria.Where(x => x.IdCategoria == id).ToList();

		}
		

		public void llenarTxtCategorias(categoria p)
		{
			txtidCategoria.Text = p.IdCategoria.ToString();
			txtCategoria.Text = p.Nombre;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			actualizar();
			limpiarTodo();
			
		}

		private void limpiarTodo()
		{
			BorrarFormularioProducto();
			BorrarFormularioCategoria();
			BorrarFormularioProveedores();
			llenarCategorias();
			llenarProveedores();
			
			
		}

		private void actualizar()
		{
			db = new sistemaEntities();
	

			if (rdProducto.Checked == true)
			{
				int.TryParse(txtIdPro.Text, out idProducto);
				if (idProducto > 0)
				{
					producto busqueda = BusquedaProducto(idProducto).FirstOrDefault();
					busqueda.Descripcion = txtDecrip.Text;
					busqueda.Nombre = txtNom.Text;
					busqueda.PrecioUnitario = decimal.Parse(txtPrecio.Text);
					busqueda.Stock = int.Parse(txtStock.Text);
					mensaje = "Producto actualizado correctamente !!";
					

				}
				else
					MessageBox.Show("Debe seleccionar un producto!! ", "Buscar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else if (rdCategoria.Checked == true)
			{
				int.TryParse(txtidCategoria.Text, out idCategoria);
				if (idCategoria > 0)
				{
					categoria busqueda = BusquedaCategoria(idCategoria).FirstOrDefault();
					busqueda.Nombre = txtCategoria.Text;
					mensaje = "Categoria acualizada correctamente !!";
					
				}
				else
					MessageBox.Show("Debe seleccionar una categoria!! ", "Buscar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (rdProveedor.Checked == true)
			{
				int.TryParse(txtIdproveedor.Text, out Idproveedor);
				if (Idproveedor > 0)
				{
					proveedor busqueda = BusquedaProveedor(Idproveedor).FirstOrDefault();
					busqueda.Nombre = txtProveedor.Text;
					busqueda.Numero_Documento = txtCedula.Text;
					busqueda.Telefono = txtTel.Text;
					busqueda.Email = txtEmail.Text;
					busqueda.Direccion = txtDireccion.Text; 
					mensaje = "Proveedor acualizado correctamente !!";

				}
				else
					MessageBox.Show("Debe seleccionar un proveedor!! ", "Buscar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			db.SaveChanges();
			if (mensaje != "")
				MessageBox.Show(mensaje, "Dato actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			eliminar();
			limpiarTodo();
		}

		private void eliminar()
		{
			db = new sistemaEntities();
		

			if (rdProducto.Checked == true)
			{
				int.TryParse(txtIdPro.Text, out idProducto);
				if (idProducto > 0)
				{
					producto busqueda = BusquedaProducto(idProducto).FirstOrDefault();
					db.producto.Remove(busqueda);
					mensaje = "Producto eliminado correctamente !!";
					
					
				}
				else
					MessageBox.Show("Debe seleccionar un producto!! ", "Buscar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else if (rdCategoria.Checked == true)
			{
				int.TryParse(txtidCategoria.Text, out idCategoria);
				if (idCategoria > 0)
				{
					categoria busqueda = BusquedaCategoria(idCategoria).FirstOrDefault();
					db.categoria.Remove(busqueda);
					mensaje = "Categoria eliminado correctamente !!";				
				}
				else
					MessageBox.Show("Debe seleccionar un producto!! ", "Buscar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (rdProveedor.Checked == true)
			{
				int.TryParse(txtIdproveedor.Text, out Idproveedor);
				if (Idproveedor > 0)
				{
					proveedor busqueda = BusquedaProveedor(Idproveedor).FirstOrDefault();
					db.proveedor.Remove(busqueda);
					mensaje = "Categoria eliminado correctamente !!";
				}
				else
					MessageBox.Show("Debe seleccionar un producto!! ", "Buscar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			db.SaveChanges();
			if (mensaje != "")
				MessageBox.Show(mensaje, "Dato eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void rdCategoria_CheckedChanged(object sender, EventArgs e)
		{
			if (rdCategoria.Checked == true)
			{
				activarControlesCategoria(true);
				activarControlesProducto(false);
				activarControlesProveedores(false);

			}
			else if (rdProducto.Checked==true)
			{
				activarControlesProducto(true);
				activarControlesProveedores(false);
				activarControlesCategoria(false);
			
			}
			else if (rdProveedor.Checked == true)
			{
				activarControlesProducto(false);
				activarControlesProveedores(true);
				activarControlesCategoria(false);
			}
		
				
		}		

		private void activarControlesProveedores(bool activar)
		{
			if (activar)
			{
				foreach (Control item in gbProveedores.Controls)
				{
					if (item.Name == "txtIdproveedor")					
						item.Enabled = false;					
					else					
						item.Enabled = true;
				
				}
				
										
			}
			else
			{
				foreach (Control item in gbProveedores.Controls)
				{
					if (item is Label)
						item.Enabled = true;
					else
						item.Enabled = false;
				}
			}
			
		}

		private void activarControlesProducto(bool activar)
		{
			if (activar)
			{
				foreach (Control item in gbProducto.Controls)
				{
					if (item.Name == "txtIdPro")					
						item.Enabled = false;					
					else					
						item.Enabled = true;
				
				}
			}
			else
			{
				foreach (Control item in gbProducto.Controls)
				{
					if (item is Label)
						item.Enabled = true;
					else
						item.Enabled = false;
				}
			}
		
		}

		private void activarControlesCategoria(bool activar)
		{
			if (activar)
			{
				foreach (Control item in gbCategoria.Controls)
				{
					if (item.Name == "txtidCategoria")					
						item.Enabled = false;					
					else					
						item.Enabled = true;					
				}
			}
			else
			{
				foreach (Control x in gbCategoria.Controls)
				{
					if (x is Label)
						x.Enabled = true;
					else
						x.Enabled = false;
				}
			}	
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			BusquedaCategorias p = new BusquedaCategorias();
			rdCategoria.Checked = true;
			BusquedaCategorias.formulario = "inventario";
			BusquedaCategorias._inventario = this;
			p.ShowDialog();
		}

		private void txtidCategoria_TextChanged(object sender, EventArgs e)
		{
			if (txtIdPro.Text.Count()>0 && txtidCategoria.Text.Count() > 0)
			{
				btnEliminar.Enabled = true;
				btnModificar.Enabled = true;
			}
			else
			{
				btnEliminar.Enabled = false;
				btnModificar.Enabled = false;
			}

		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			limpiarTodo();
		}

		private void rdProducto_CheckedChanged(object sender, EventArgs e)
		{
			if (rdCategoria.Checked == true)
			{
				activarControlesCategoria(true);
				activarControlesProducto(false);
				activarControlesProveedores(false);

			}
			else if (rdProducto.Checked == true)
			{
				activarControlesProducto(true);
				activarControlesProveedores(false);
				activarControlesCategoria(false);

			}
			else if (rdProveedor.Checked == true)
			{
				activarControlesProducto(false);
				activarControlesProveedores(true);
				activarControlesCategoria(false);
			}
		}

		private void rdProveedor_CheckedChanged(object sender, EventArgs e)
		{
			if (rdCategoria.Checked == true)
			{
				activarControlesCategoria(true);
				activarControlesProducto(false);
				activarControlesProveedores(false);

			}
			else if (rdProducto.Checked == true)
			{
				activarControlesProducto(true);
				activarControlesProveedores(false);
				activarControlesCategoria(false);

			}
			else if (rdProveedor.Checked == true)
			{
				activarControlesProducto(false);
				activarControlesProveedores(true);
				activarControlesCategoria(false);
			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			if (rdProveedor.Checked == true)
			{
				proveedor p = new proveedor {
					Nombre = txtProveedor.Text,
					Telefono = txtTel.Text,
					Direccion = txtDireccion.Text,
					Numero_Documento=txtCedula.Text,
					Email = txtEmail.Text	
					
				};
				db.proveedor.Add(p);

			}

			db.SaveChanges();
			BorrarFormularioProveedores();
			llenarProveedores();
			MessageBox.Show("Proveedor agregado correctamente !!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			BusquedaProveedores p = new BusquedaProveedores();
			BusquedaProveedores.formulario = "inventario";
			BusquedaProveedores._inventario = this;
			p.ShowDialog();
		}
	}
}
