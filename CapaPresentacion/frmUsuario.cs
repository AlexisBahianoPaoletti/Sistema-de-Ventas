﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using System.Drawing.Text;

namespace CapaPresentacion
{
	public partial class frmUsuario : Form
	{
		public frmUsuario()
		{
			InitializeComponent();
		}

		private void frmUsuario_Load(object sender, EventArgs e)
		{
			cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
			cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

			cboestado.DisplayMember = "Texto";
			cboestado.ValueMember = "Valor";
			cboestado.SelectedIndex = 0;

			List<Rol> listaRol = new CN_Rol().Listar();

			foreach (Rol item in listaRol)
			{
				cborol.Items.Add(new OpcionCombo() { Valor = item.idRol, Texto = item.Descripcion });
			}
			cborol.DisplayMember = "Texto";
			cborol.ValueMember = "Valor";
			cborol.SelectedIndex = 0;

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

			txtdocumento.Focus();
		}

		private void btnguardar_Click(object sender, EventArgs e)
		{
			dgvdata.Rows.Add(new object[] 
			{
				"", txtid.Text, txtdocumento.Text, txtnombrecompleto.Text, txtcorreo.Text, txtclave.Text,
				((OpcionCombo)cborol.SelectedItem).Valor.ToString(),
				((OpcionCombo)cborol.SelectedItem).Texto.ToString(),
				((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
				((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
			});

			Limpiar();
		}

		private void Limpiar()
		{
			txtid.Text = "0";
			txtdocumento.Text = "";
			txtnombrecompleto.Text = "";
			txtcorreo.Text = "";
			txtclave.Text = "";
			txtconfirmarclave.Text = "";
			cborol.SelectedIndex = 0;
			cboestado.SelectedIndex = 0;

			txtdocumento.Focus();
		}


	}
}
