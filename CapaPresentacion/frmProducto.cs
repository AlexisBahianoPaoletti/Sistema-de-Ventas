﻿using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
	public partial class frmProducto : Form
	{
		public frmProducto()
		{
			InitializeComponent();
		}

		private void frmProducto_Load(object sender, EventArgs e)
		{
			cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
			cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
			cboestado.DisplayMember = "Texto";
			cboestado.ValueMember = "Valor";
			cboestado.SelectedIndex = 0;

			List<Categoria> listacategoria = new CN_Categoria().Listar();

			foreach (Categoria item in listacategoria)
			{
				cbocategoria.Items.Add(new OpcionCombo() { Valor = item.idCategoria, Texto = item.Descripcion });
			}
			cbocategoria.DisplayMember = "Texto";
			cbocategoria.ValueMember = "Valor";
			cbocategoria.SelectedIndex = 0;

			foreach (DataGridViewColumn columna in dgvdata.Columns)
			{
				if (columna.Visible == true && columna.Name != "btnseleccionar")
				{
					cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });

				}
			}
			cbobusqueda.DisplayMember = "Texto";
			cbobusqueda.ValueMember = "Valor";
			cbobusqueda.SelectedIndex = 0;

			List<Producto> listaProducto = new CN_Producto().Listar();

			foreach (Producto item in listaProducto)
			{
				dgvdata.Rows.Add(new object[] {
				"",
				item.idProducto,
				item.Codigo,
				item.Nombre,
				item.Descripcion,
				item.oCategoria.idCategoria,
				item.oCategoria.Descripcion,
				item.Stock,
				item.PrecioCompra,
				item.PrecioVenta,
				item.Estado == true ? 1:0,
				item.Estado == true ? "Activo":"No Activo"
				});

			}




			txtcodigo.Focus();
		}

		private void btnguardar_Click(object sender, EventArgs e)
		{
			string mensasje = string.Empty;

			Producto objProducto = new Producto()
			{
				idProducto = Convert.ToInt32(txtid.Text),
				Codigo = txtcodigo.Text,
				Nombre = txtnombre.Text,
				Descripcion = txtdescripcion.Text,
				oCategoria = new Categoria() { idCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor) },
				Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
			};

			if (objProducto.idProducto == 0)
			{
				int idproductogenerado = new CN_Producto().Registrar(objProducto, out mensasje);

				if (idproductogenerado != 0)
				{
					dgvdata.Rows.Add(new object[]
					{
				"", idproductogenerado, txtcodigo.Text, txtnombre.Text, txtdescripcion.Text,
				((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString(),
				((OpcionCombo)cbocategoria.SelectedItem).Texto.ToString(),
				"0",
				"0.00",
				"0.00",
				((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
				((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
					});

					Limpiar();
				}
				else
				{
					MessageBox.Show(mensasje);
				}

			}
			else
			{
				bool resultado = new CN_Producto().Editar(objProducto, out mensasje);

				if (resultado)
				{
					DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtIndice.Text)];
					row.Cells["Id"].Value = txtid.Text;
					row.Cells["Codigo"].Value = txtcodigo.Text;
					row.Cells["Nombre"].Value = txtnombre.Text;
					row.Cells["Descripcion"].Value = txtdescripcion.Text;
					row.Cells["IdCategoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString();
					row.Cells["Categoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Texto.ToString();
					row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
					row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();

					Limpiar();
				}
				else
				{
					MessageBox.Show(mensasje);
				}

			}
		}

		private void Limpiar()
		{
			txtIndice.Text = "-1";
			txtid.Text = "0";
			txtcodigo.Text = "";
			txtnombre.Text = "";
			txtdescripcion.Text = "";
			cbocategoria.SelectedIndex = 0;
			cboestado.SelectedIndex = 0;

			txtcodigo.Focus();
		}

		private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}

			if (e.ColumnIndex == 0)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);

				var w = Properties.Resources.iconecheck24.Width;
				var h = Properties.Resources.iconecheck24.Height;
				var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
				var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

				e.Graphics.DrawImage(Properties.Resources.iconecheck24, new Rectangle(x, y, w, h));
				e.Handled = true;

			}
		}

		private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
			{
				int indice = e.RowIndex;

				if (indice >= 0)
				{
					txtIndice.Text = indice.ToString();
					txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
					txtcodigo.Text = dgvdata.Rows[indice].Cells["Codigo"].Value.ToString();
					txtnombre.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
					txtdescripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();


					foreach (OpcionCombo oc in cbocategoria.Items)
					{
						if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["idCateggoria"].Value))
						{
							int indice_combo = cbocategoria.Items.IndexOf(oc);
							cbocategoria.SelectedIndex = indice_combo;
							break;
						}
					}

					foreach (OpcionCombo oc in cboestado.Items)
					{
						if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
						{
							int indice_combo = cboestado.Items.IndexOf(oc);
							cboestado.SelectedIndex = indice_combo;
							break;
						}
					}
				}
			}

		}

		private void btneliminar_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt32(txtid.Text) != 0)
			{
				if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					string mensaje = string.Empty;
					Producto objProducto = new Producto()
					{
						idProducto = Convert.ToInt32(txtid.Text)
					};

					bool respuesta = new CN_Producto().Eliminar(objProducto, out mensaje);

					if (respuesta)
					{
						dgvdata.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
						Limpiar();

					}
					else
					{
						MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

					}

				}
			}
		}

		private void btnlimpiar_Click(object sender, EventArgs e)
		{
			Limpiar();
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

			if (dgvdata.Rows.Count > 0)
			{
				foreach (DataGridViewRow row in dgvdata.Rows)
				{
					if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
						row.Visible = true;
					else
						row.Visible = false;
				}
			}
		}

		private void btnlimpiarbuscador_Click(object sender, EventArgs e)
		{
			txtbusqueda.Text = "";
			foreach (DataGridViewRow row in dgvdata.Rows)
			{
				row.Visible = true;
			}
		}

		private void btndescargarexcel_Click(object sender, EventArgs e)
		{
			if (dgvdata.Rows.Count < 1)
			{
				MessageBox.Show("No hay datos para exportar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				DataTable dt = new DataTable();

				foreach (DataGridViewColumn column in dgvdata.Columns)
				{
					if (column.HeaderText != "" && column.Visible)
						dt.Columns.Add(column.HeaderText, typeof(string));
				}

				foreach (DataGridViewRow row in dgvdata.Rows)
				{
					if (row.Visible)
						dt.Rows.Add(new object[]
						{
							row.Cells[2].Value.ToString(),
							row.Cells[3].Value.ToString(),
							row.Cells[4].Value.ToString(),
							row.Cells[6].Value.ToString(),
							row.Cells[7].Value.ToString(),
							row.Cells[8].Value.ToString(),
							row.Cells[9].Value.ToString(),
							row.Cells[11].Value.ToString(),

						});
				}

				SaveFileDialog savefile = new SaveFileDialog();
				savefile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
				savefile.Filter = "Excel Files | *.xlsx";

				if (savefile.ShowDialog() == DialogResult.OK)
				{
					try
					{
						XLWorkbook wb = new XLWorkbook();
						var hoja = wb.Worksheets.Add(dt, "Informe");
						hoja.ColumnsUsed().AdjustToContents();
						wb.SaveAs(savefile.FileName);
						MessageBox.Show("Reporte generado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch
					{
						MessageBox.Show("Error al generar el reporte.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

					}
				}

			}
		}
	}
}
