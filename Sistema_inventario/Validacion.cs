using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_inventario
{
public	class Validacion
	{
		public void Letras(KeyPressEventArgs e)
		{
			try
			{
				if (Char.IsLetter(e.KeyChar))
				{
					e.Handled = false;
				}
				else if (Char.IsControl(e.KeyChar))
				{
					e.Handled = false;
				}
				else if (Char.IsSeparator(e.KeyChar))
				{
					e.Handled = false;
				}
				else
				{
					e.Handled = true;
					MessageBox.Show("No se permiten numeros");
				}
			}
			catch (Exception ex)
			{

			}
		}

		public void Numeros(KeyPressEventArgs e)
		{
			try
			{
				if (Char.IsNumber(e.KeyChar))
				{
					e.Handled = false;
				}
				else if (Char.IsControl(e.KeyChar))
				{
					e.Handled = false;
				}
				else if (Char.IsSeparator(e.KeyChar))
				{
					e.Handled = false;
				}
				else
				{
					e.Handled = true;
					MessageBox.Show("No se permiten letras");
				}
			}
			catch (Exception ex)
			{

			}
		}
	}
}
