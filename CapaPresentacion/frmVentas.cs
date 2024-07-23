﻿using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
	public partial class frmVentas : Form
	{
		private Usuario _Usuario;
		public frmVentas(Usuario oUsuario = null)
		{
			_Usuario = oUsuario;
			InitializeComponent();
		}

		private void frmVentas_Load(object sender, EventArgs e)
		{
			cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
			cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
			cbotipodocumento.DisplayMember = "Texto";
			cbotipodocumento.ValueMember = "Valor";
			cbotipodocumento.SelectedIndex = 0;

			txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

			txtidcliente.Text = "0";
			txtidproducto.Text = "0";

			txtpagacon.Text = "";
			txtcambio.Text = "";
			txtidcliente.Text = "0";
		}

		private void btnbuscarcliente_Click(object sender, EventArgs e)
		{
			using (var modal = new mdCliente())
			{
				var result = modal.ShowDialog();

				if (result == DialogResult.OK)
				{
					txtdoccliente.Text = modal._Cliente.Documento;
					txtnombrecliente.Text = modal._Cliente.NombreCompleto;
					txtcodproducto.Select();
				}
				else
				{
					txtdoccliente.Select();
				}
			}
		}

		private void btnbuscarproducto_Click(object sender, EventArgs e)
		{
			using (var modal = new mdProducto())
			{
				var result = modal.ShowDialog();

				if (result == DialogResult.OK)
				{
					txtidproducto.Text = modal._Producto.idProducto.ToString();
					txtcodproducto.Text = modal._Producto.Codigo;
					txtproducto.Text = modal._Producto.Nombre;
					txtprecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
					txtstock.Text = modal._Producto.Stock.ToString();
					txtcantidad.Select();
				}
				else
				{
					txtcodproducto.Select();
				}
			}
		}

		private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtcodproducto.Text && p.Estado == true).FirstOrDefault();

				if (oProducto != null)
				{
					txtcodproducto.BackColor = Color.Honeydew;
					txtidproducto.Text = oProducto.idProducto.ToString();
					txtproducto.Text = oProducto.Nombre;
					txtprecio.Text = oProducto.PrecioVenta.ToString("0.00");
					txtstock.Text = oProducto.Stock.ToString();
					txtcantidad.Select();
				}
				else
				{
					txtcodproducto.BackColor = Color.MistyRose;
					txtidproducto.Text = "0";
					txtproducto.Text = "";
					txtprecio.Text = "";
					txtstock.Text = "";
					txtcantidad.Value = 1;
				}
			}
		}

		private void btnagregarproducto_Click(object sender, EventArgs e)
		{
			decimal precio = 0;
			bool producto_existe = false;

			if (int.Parse(txtidproducto.Text) == 0)
			{
				MessageBox.Show("Debe seleccionar un producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (!decimal.TryParse(txtprecio.Text, out precio))
			{
				MessageBox.Show("Precio - Formato de moneda incorrecto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtprecio.Select();
				return;
			}

			if (Convert.ToInt32(txtstock.Text) < Convert.ToInt32(txtcantidad.Value.ToString()))
			{
				MessageBox.Show("La cantidad no puede ser mayor al stock.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			foreach (DataGridViewRow fila in dgvdata.Rows)
			{
				if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
				{
					producto_existe = true;
					break;
				}
			}

			if (!producto_existe)
			{
				dgvdata.Rows.Add(new object[]
				{
					txtidproducto.Text,
					txtproducto.Text,
					precio.ToString("0.00"),
					txtcantidad.Value.ToString(),
					(txtcantidad.Value * precio).ToString("0.00")
				});

				calcularTotal();
				limpiarProducto();
				txtcodproducto.Select();
			}
		}

		private void limpiarProducto()
		{
			txtidproducto.Text = "0";
			txtcodproducto.Text = "";
			txtcodproducto.BackColor = Color.White;
			txtproducto.Text = "";
			txtprecio.Text = "";
			txtstock.Text = "";
			txtcantidad.Value = 1;
		}

		private void calcularTotal()
		{
			decimal total = 0;
			if (dgvdata.Rows.Count > 0)
			{
				foreach (DataGridViewRow row in dgvdata.Rows)
				{
					total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
				}
			}
			txttotalpagar.Text = total.ToString("0.00");
		}

		private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}

			if (e.ColumnIndex == 5)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);

				var w = Properties.Resources.iconedelete24.Width;
				var h = Properties.Resources.iconedelete24.Height;
				var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
				var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

				e.Graphics.DrawImage(Properties.Resources.iconedelete24, new Rectangle(x, y, w, h));
				e.Handled = true;

			}
		}

		private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
			{
				int indice = e.RowIndex;
				if (indice >= 0)
				{
					dgvdata.Rows.RemoveAt(indice);
					calcularTotal();
				}
			}
		}

		private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				if (txtprecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
				{
					e.Handled = true;
				}
				else
				{
					if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
					{
						e.Handled = false;
					}
					else
					{
						e.Handled = true;
					}
				}
			}
		}

		private void txtpagacon_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				if (txtpagacon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
				{
					e.Handled = true;
				}
				else
				{
					if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
					{
						e.Handled = false;
					}
					else
					{
						e.Handled = true;
					}
				}
			}
		}

		private void calcularcambio()
		{
			if (txttotalpagar.Text.Trim() == "")
			{
				MessageBox.Show("No existen productos en la venta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			decimal pagacon;
			decimal total = Convert.ToDecimal(txttotalpagar.Text);

			if (txtpagacon.Text.Trim() == "")
			{
				txtpagacon.Text = "0";
			}

			if (decimal.TryParse(txtpagacon.Text.Trim(), out pagacon))
			{
				if (pagacon < total)
				{
					txtcambio.Text = "0.00";
				}
				else
				{
					decimal cambio = pagacon - total;
					txtcambio.Text = cambio.ToString("0.00");
				}
			}
		}

		private void txtpagacon_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				calcularcambio();
			}
		}
	}
}
