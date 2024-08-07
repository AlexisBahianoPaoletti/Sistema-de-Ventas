﻿namespace CapaPresentacion
{
	partial class frmReporteVentas
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label9 = new System.Windows.Forms.Label();
			this.btnbuscarreporte = new FontAwesome.Sharp.IconButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtfechafin = new System.Windows.Forms.DateTimePicker();
			this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.btndescargarexcel = new FontAwesome.Sharp.IconButton();
			this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
			this.btnbuscar = new FontAwesome.Sharp.IconButton();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.cbobusqueda = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvdata = new System.Windows.Forms.DataGridView();
			this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DocumentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 9);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(2, 15, 0, 0);
			this.label9.Size = new System.Drawing.Size(1378, 110);
			this.label9.TabIndex = 56;
			this.label9.Text = "Reporte Ventas";
			// 
			// btnbuscarreporte
			// 
			this.btnbuscarreporte.BackColor = System.Drawing.Color.White;
			this.btnbuscarreporte.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnbuscarreporte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnbuscarreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnbuscarreporte.ForeColor = System.Drawing.Color.Black;
			this.btnbuscarreporte.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
			this.btnbuscarreporte.IconColor = System.Drawing.Color.Black;
			this.btnbuscarreporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnbuscarreporte.IconSize = 16;
			this.btnbuscarreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnbuscarreporte.Location = new System.Drawing.Point(430, 75);
			this.btnbuscarreporte.Name = "btnbuscarreporte";
			this.btnbuscarreporte.Size = new System.Drawing.Size(69, 28);
			this.btnbuscarreporte.TabIndex = 67;
			this.btnbuscarreporte.Text = "Buscar";
			this.btnbuscarreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnbuscarreporte.UseVisualStyleBackColor = false;
			this.btnbuscarreporte.Click += new System.EventHandler(this.btnbuscarreporte_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(241, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 66;
			this.label1.Text = "Fecha Fin:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(31, 83);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 13);
			this.label10.TabIndex = 65;
			this.label10.Text = "Fecha Inicio:";
			// 
			// txtfechafin
			// 
			this.txtfechafin.CustomFormat = "dd/MM/yyyy";
			this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtfechafin.Location = new System.Drawing.Point(304, 78);
			this.txtfechafin.Name = "txtfechafin";
			this.txtfechafin.Size = new System.Drawing.Size(95, 20);
			this.txtfechafin.TabIndex = 64;
			// 
			// txtfechainicio
			// 
			this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
			this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtfechainicio.Location = new System.Drawing.Point(105, 78);
			this.txtfechainicio.Name = "txtfechainicio";
			this.txtfechainicio.Size = new System.Drawing.Size(95, 20);
			this.txtfechainicio.TabIndex = 63;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 136);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(2, 15, 0, 0);
			this.label3.Size = new System.Drawing.Size(1378, 441);
			this.label3.TabIndex = 68;
			// 
			// btndescargarexcel
			// 
			this.btndescargarexcel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btndescargarexcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btndescargarexcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btndescargarexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btndescargarexcel.ForeColor = System.Drawing.Color.Black;
			this.btndescargarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
			this.btndescargarexcel.IconColor = System.Drawing.Color.Green;
			this.btndescargarexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btndescargarexcel.IconSize = 16;
			this.btndescargarexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btndescargarexcel.Location = new System.Drawing.Point(27, 155);
			this.btndescargarexcel.Name = "btndescargarexcel";
			this.btndescargarexcel.Size = new System.Drawing.Size(119, 27);
			this.btndescargarexcel.TabIndex = 76;
			this.btndescargarexcel.Text = "Descargar Excel";
			this.btndescargarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btndescargarexcel.UseVisualStyleBackColor = false;
			this.btndescargarexcel.Click += new System.EventHandler(this.btndescargarexcel_Click);
			// 
			// btnlimpiarbuscador
			// 
			this.btnlimpiarbuscador.BackColor = System.Drawing.Color.White;
			this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.Black;
			this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Eraser;
			this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
			this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnlimpiarbuscador.IconSize = 16;
			this.btnlimpiarbuscador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnlimpiarbuscador.Location = new System.Drawing.Point(1302, 157);
			this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
			this.btnlimpiarbuscador.Size = new System.Drawing.Size(69, 27);
			this.btnlimpiarbuscador.TabIndex = 75;
			this.btnlimpiarbuscador.Text = "Limpiar";
			this.btnlimpiarbuscador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
			this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
			// 
			// btnbuscar
			// 
			this.btnbuscar.BackColor = System.Drawing.Color.White;
			this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnbuscar.ForeColor = System.Drawing.Color.Black;
			this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
			this.btnbuscar.IconColor = System.Drawing.Color.Black;
			this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnbuscar.IconSize = 16;
			this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnbuscar.Location = new System.Drawing.Point(1227, 157);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(69, 27);
			this.btnbuscar.TabIndex = 74;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnbuscar.UseVisualStyleBackColor = false;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// txtbusqueda
			// 
			this.txtbusqueda.Location = new System.Drawing.Point(1014, 161);
			this.txtbusqueda.Name = "txtbusqueda";
			this.txtbusqueda.Size = new System.Drawing.Size(207, 20);
			this.txtbusqueda.TabIndex = 73;
			// 
			// cbobusqueda
			// 
			this.cbobusqueda.FormattingEnabled = true;
			this.cbobusqueda.Location = new System.Drawing.Point(801, 161);
			this.cbobusqueda.Name = "cbobusqueda";
			this.cbobusqueda.Size = new System.Drawing.Size(207, 21);
			this.cbobusqueda.TabIndex = 72;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(734, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 71;
			this.label4.Text = "Buscar por:";
			// 
			// dgvdata
			// 
			this.dgvdata.AllowUserToAddRows = false;
			this.dgvdata.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoCliente,
            this.NombreCliente,
            this.CodigoProducto,
            this.NombreProducto,
            this.Categoria,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
			this.dgvdata.Location = new System.Drawing.Point(27, 204);
			this.dgvdata.MultiSelect = false;
			this.dgvdata.Name = "dgvdata";
			this.dgvdata.ReadOnly = true;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvdata.RowTemplate.Height = 28;
			this.dgvdata.Size = new System.Drawing.Size(1344, 351);
			this.dgvdata.TabIndex = 77;
			// 
			// FechaRegistro
			// 
			this.FechaRegistro.HeaderText = "Fecha Registro";
			this.FechaRegistro.Name = "FechaRegistro";
			this.FechaRegistro.ReadOnly = true;
			// 
			// TipoDocumento
			// 
			this.TipoDocumento.HeaderText = "Tipo Documento";
			this.TipoDocumento.Name = "TipoDocumento";
			this.TipoDocumento.ReadOnly = true;
			// 
			// NumeroDocumento
			// 
			this.NumeroDocumento.HeaderText = "Número Documento";
			this.NumeroDocumento.Name = "NumeroDocumento";
			this.NumeroDocumento.ReadOnly = true;
			// 
			// MontoTotal
			// 
			this.MontoTotal.HeaderText = "Monto Total";
			this.MontoTotal.Name = "MontoTotal";
			this.MontoTotal.ReadOnly = true;
			// 
			// UsuarioRegistro
			// 
			this.UsuarioRegistro.HeaderText = "Usuario Registro";
			this.UsuarioRegistro.Name = "UsuarioRegistro";
			this.UsuarioRegistro.ReadOnly = true;
			// 
			// DocumentoCliente
			// 
			this.DocumentoCliente.HeaderText = "Documento Cliente";
			this.DocumentoCliente.Name = "DocumentoCliente";
			this.DocumentoCliente.ReadOnly = true;
			// 
			// NombreCliente
			// 
			this.NombreCliente.HeaderText = "Nombre Cliente";
			this.NombreCliente.Name = "NombreCliente";
			this.NombreCliente.ReadOnly = true;
			// 
			// CodigoProducto
			// 
			this.CodigoProducto.HeaderText = "Código Producto";
			this.CodigoProducto.Name = "CodigoProducto";
			this.CodigoProducto.ReadOnly = true;
			// 
			// NombreProducto
			// 
			this.NombreProducto.HeaderText = "Nombre Producto";
			this.NombreProducto.Name = "NombreProducto";
			this.NombreProducto.ReadOnly = true;
			// 
			// Categoria
			// 
			this.Categoria.HeaderText = "Categoría";
			this.Categoria.Name = "Categoria";
			this.Categoria.ReadOnly = true;
			// 
			// PrecioVenta
			// 
			this.PrecioVenta.HeaderText = "Precio Venta";
			this.PrecioVenta.Name = "PrecioVenta";
			this.PrecioVenta.ReadOnly = true;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			// 
			// SubTotal
			// 
			this.SubTotal.HeaderText = "Sub Total";
			this.SubTotal.Name = "SubTotal";
			this.SubTotal.ReadOnly = true;
			// 
			// frmReporteVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1402, 586);
			this.Controls.Add(this.dgvdata);
			this.Controls.Add(this.btndescargarexcel);
			this.Controls.Add(this.btnlimpiarbuscador);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtbusqueda);
			this.Controls.Add(this.cbobusqueda);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnbuscarreporte);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtfechafin);
			this.Controls.Add(this.txtfechainicio);
			this.Controls.Add(this.label9);
			this.Name = "frmReporteVentas";
			this.Text = "Reporte Ventas";
			this.Load += new System.EventHandler(this.frmReporteVentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label9;
		private FontAwesome.Sharp.IconButton btnbuscarreporte;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker txtfechafin;
		private System.Windows.Forms.DateTimePicker txtfechainicio;
		private System.Windows.Forms.Label label3;
		private FontAwesome.Sharp.IconButton btndescargarexcel;
		private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
		private FontAwesome.Sharp.IconButton btnbuscar;
		private System.Windows.Forms.TextBox txtbusqueda;
		private System.Windows.Forms.ComboBox cbobusqueda;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvdata;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
		private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
		private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
	}
}