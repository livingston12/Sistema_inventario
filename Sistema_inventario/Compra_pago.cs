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
	public partial class Compra_pago : Form
	{
		public Compra_pago()
		{
			InitializeComponent();
		}
		sistemaEntities db = new sistemaEntities();
		public static string formulario;
		public static Ventas _ventas;
		public static Compras _compras;
		public decimal total { get; set; }
		private void label4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Compra_pago_Load(object sender, EventArgs e)
		{
			cargarControles();
			validarDatosEnBaseDatos();
			llenarMetodosPagos();
		}

		private void cargarControles()
		{
			if (formulario == "ventas")
			{
				label2.Text = "Cantidad a cobrar";
				panel1.BackgroundImage = Properties.Resources.VENTAS;
			}
			
			else if (formulario == "compras")
			{
				label2.Text = "Cantidad a pagar";
				panel1.BackgroundImage = Properties.Resources.COMPRAS2;
			}
			txtTotal.Text = total.ToString();
				
		}

		private void llenarMetodosPagos()
		{
			try
			{
				cbMetodo.DataSource = db.reporte.ToList();
				cbMetodo.DisplayMember = "tipo_documento";
				cbMetodo.ValueMember = "idReporte";
			}
			catch (Exception)
			{
			}
			

		}

		private void validarDatosEnBaseDatos()
		{
			try
			{
				List<reporte> busquedaMetodoPago = db.reporte.ToList();
				List<string> metodos = new List<string> { "Efectivo", "Tarjeta de credito", "Cheque" };

				if (busquedaMetodoPago.Any() == false)
				{
					for (int i = 0; i < 3; i++)
					{
						reporte reporte = new reporte();
						reporte.IdReporte = i + 1;
						reporte.Tipo_Documento = metodos[i];
						busquedaMetodoPago.Add(reporte);
					}
					db.reporte.AddRange(busquedaMetodoPago);
					db.SaveChanges();
				}
			}
			catch
			{

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			switch (formulario)
			{
				case "ventas":					
					_ventas.facturarProducto(int.Parse(cbMetodo.SelectedValue.ToString()) );					
					this.Hide();
					break;
				case "compras":
					_compras.facturarProducto(int.Parse(cbMetodo.SelectedValue.ToString()));
					this.Hide();
					break;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtEfectivo_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int efectivo = int.Parse(txtEfectivo.Text);
				decimal devuelta=0;
				if (efectivo < total)
				{
					txtEfectivo.ForeColor = Color.Red;
					btnPago.Enabled = false;
				}

				else
				{
					txtEfectivo.ForeColor = Color.Green;
					btnPago.Enabled = true;
					devuelta = decimal.Subtract(efectivo,total);					
					lblDevuelta.Text = devuelta.ToString();
				}
					
			}
			catch (Exception)
			{
			
			}
			
		}

		private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validacion val = new Validacion();
			val.Numeros(e);
		}
	}
}
