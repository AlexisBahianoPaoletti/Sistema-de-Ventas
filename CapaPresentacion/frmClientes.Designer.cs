﻿namespace CapaPresentacion
{
	partial class frmClientes
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtIndice = new System.Windows.Forms.TextBox();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.cbobusqueda = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dgvdata = new System.Windows.Forms.DataGridView();
			this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cboestado = new System.Windows.Forms.ComboBox();
			this.txttelefono = new System.Windows.Forms.TextBox();
			this.txtcorreo = new System.Windows.Forms.TextBox();
			this.txtnombrecompleto = new System.Windows.Forms.TextBox();
			this.txtdocumento = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
			this.btnbuscar = new FontAwesome.Sharp.IconButton();
			this.btneliminar = new FontAwesome.Sharp.IconButton();
			this.btnlimpiar = new FontAwesome.Sharp.IconButton();
			this.btnguardar = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
			this.SuspendLayout();
			// 
			// txtIndice
			// 
			this.txtIndice.Location = new System.Drawing.Point(135, 1);
			this.txtIndice.Name = "txtIndice";
			this.txtIndice.Size = new System.Drawing.Size(27, 20);
			this.txtIndice.TabIndex = 53;
			this.txtIndice.Text = "-1";
			this.txtIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtIndice.Visible = false;
			// 
			// txtbusqueda
			// 
			this.txtbusqueda.Location = new System.Drawing.Point(770, 53);
			this.txtbusqueda.Name = "txtbusqueda";
			this.txtbusqueda.Size = new System.Drawing.Size(207, 20);
			this.txtbusqueda.TabIndex = 50;
			// 
			// cbobusqueda
			// 
			this.cbobusqueda.FormattingEnabled = true;
			this.cbobusqueda.Location = new System.Drawing.Point(770, 21);
			this.cbobusqueda.Name = "cbobusqueda";
			this.cbobusqueda.Size = new System.Drawing.Size(207, 21);
			this.cbobusqueda.TabIndex = 49;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(703, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(61, 13);
			this.label10.TabIndex = 48;
			this.label10.Text = "Buscar por:";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(168, 1);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(27, 20);
			this.txtid.TabIndex = 47;
			this.txtid.Text = "0";
			this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtid.Visible = false;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(218, 9);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.label9.Size = new System.Drawing.Size(840, 73);
			this.label9.TabIndex = 46;
			this.label9.Text = "Lista de Clientes";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvdata
			// 
			this.dgvdata.AllowUserToAddRows = false;
			this.dgvdata.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Documento,
            this.NombreCompleto,
            this.Correo,
            this.Telefono,
            this.EstadoValor,
            this.Estado});
			this.dgvdata.Location = new System.Drawing.Point(218, 85);
			this.dgvdata.MultiSelect = false;
			this.dgvdata.Name = "dgvdata";
			this.dgvdata.ReadOnly = true;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvdata.RowTemplate.Height = 28;
			this.dgvdata.Size = new System.Drawing.Size(840, 397);
			this.dgvdata.TabIndex = 45;
			this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
			this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
			// 
			// btnseleccionar
			// 
			this.btnseleccionar.HeaderText = "";
			this.btnseleccionar.Name = "btnseleccionar";
			this.btnseleccionar.ReadOnly = true;
			this.btnseleccionar.Width = 30;
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// Documento
			// 
			this.Documento.HeaderText = "Nro Documento";
			this.Documento.Name = "Documento";
			this.Documento.ReadOnly = true;
			this.Documento.Width = 150;
			// 
			// NombreCompleto
			// 
			this.NombreCompleto.HeaderText = "Nombre Completo";
			this.NombreCompleto.Name = "NombreCompleto";
			this.NombreCompleto.ReadOnly = true;
			this.NombreCompleto.Width = 180;
			// 
			// Correo
			// 
			this.Correo.HeaderText = "Correo";
			this.Correo.Name = "Correo";
			this.Correo.ReadOnly = true;
			this.Correo.Width = 150;
			// 
			// Telefono
			// 
			this.Telefono.HeaderText = "Telefono";
			this.Telefono.Name = "Telefono";
			this.Telefono.ReadOnly = true;
			// 
			// EstadoValor
			// 
			this.EstadoValor.HeaderText = "EstadoValor";
			this.EstadoValor.Name = "EstadoValor";
			this.EstadoValor.ReadOnly = true;
			this.EstadoValor.Visible = false;
			// 
			// Estado
			// 
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			this.Estado.ReadOnly = true;
			// 
			// cboestado
			// 
			this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboestado.FormattingEnabled = true;
			this.cboestado.Location = new System.Drawing.Point(18, 228);
			this.cboestado.Name = "cboestado";
			this.cboestado.Size = new System.Drawing.Size(177, 21);
			this.cboestado.TabIndex = 41;
			// 
			// txttelefono
			// 
			this.txttelefono.Location = new System.Drawing.Point(18, 174);
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.Size = new System.Drawing.Size(177, 20);
			this.txttelefono.TabIndex = 38;
			// 
			// txtcorreo
			// 
			this.txtcorreo.Location = new System.Drawing.Point(18, 123);
			this.txtcorreo.Name = "txtcorreo";
			this.txtcorreo.Size = new System.Drawing.Size(177, 20);
			this.txtcorreo.TabIndex = 37;
			// 
			// txtnombrecompleto
			// 
			this.txtnombrecompleto.Location = new System.Drawing.Point(18, 72);
			this.txtnombrecompleto.Name = "txtnombrecompleto";
			this.txtnombrecompleto.Size = new System.Drawing.Size(177, 20);
			this.txtnombrecompleto.TabIndex = 36;
			// 
			// txtdocumento
			// 
			this.txtdocumento.Location = new System.Drawing.Point(18, 24);
			this.txtdocumento.Name = "txtdocumento";
			this.txtdocumento.Size = new System.Drawing.Size(177, 20);
			this.txtdocumento.TabIndex = 35;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(15, 211);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 13);
			this.label8.TabIndex = 34;
			this.label8.Text = "Estado:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(15, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 31;
			this.label5.Text = "Teléfono:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(15, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 30;
			this.label4.Text = "Correo:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(15, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 13);
			this.label3.TabIndex = 29;
			this.label3.Text = "Nombre Completo:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(15, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 28;
			this.label2.Text = "Nro Documento:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 496);
			this.label1.TabIndex = 27;
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
			this.btnlimpiarbuscador.Location = new System.Drawing.Point(983, 49);
			this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
			this.btnlimpiarbuscador.Size = new System.Drawing.Size(69, 27);
			this.btnlimpiarbuscador.TabIndex = 52;
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
			this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
			this.btnbuscar.IconColor = System.Drawing.Color.Black;
			this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnbuscar.IconSize = 16;
			this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnbuscar.Location = new System.Drawing.Point(983, 17);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(69, 27);
			this.btnbuscar.TabIndex = 51;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnbuscar.UseVisualStyleBackColor = false;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// btneliminar
			// 
			this.btneliminar.BackColor = System.Drawing.Color.Red;
			this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btneliminar.ForeColor = System.Drawing.Color.White;
			this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
			this.btneliminar.IconColor = System.Drawing.Color.White;
			this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btneliminar.IconSize = 18;
			this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btneliminar.Location = new System.Drawing.Point(18, 356);
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.Size = new System.Drawing.Size(177, 27);
			this.btneliminar.TabIndex = 44;
			this.btneliminar.Text = "Eliminar";
			this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btneliminar.UseVisualStyleBackColor = false;
			this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.BackColor = System.Drawing.Color.Blue;
			this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnlimpiar.ForeColor = System.Drawing.Color.White;
			this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
			this.btnlimpiar.IconColor = System.Drawing.Color.White;
			this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnlimpiar.IconSize = 18;
			this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnlimpiar.Location = new System.Drawing.Point(18, 314);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(177, 27);
			this.btnlimpiar.TabIndex = 43;
			this.btnlimpiar.Text = "Limpiar";
			this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnlimpiar.UseVisualStyleBackColor = false;
			this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
			// 
			// btnguardar
			// 
			this.btnguardar.BackColor = System.Drawing.Color.Green;
			this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnguardar.ForeColor = System.Drawing.Color.White;
			this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
			this.btnguardar.IconColor = System.Drawing.Color.White;
			this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnguardar.IconSize = 18;
			this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnguardar.Location = new System.Drawing.Point(18, 273);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(177, 27);
			this.btnguardar.TabIndex = 42;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnguardar.UseVisualStyleBackColor = false;
			this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
			// 
			// frmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 496);
			this.Controls.Add(this.txtIndice);
			this.Controls.Add(this.btnlimpiarbuscador);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtbusqueda);
			this.Controls.Add(this.cbobusqueda);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.btneliminar);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.btnguardar);
			this.Controls.Add(this.dgvdata);
			this.Controls.Add(this.cboestado);
			this.Controls.Add(this.txttelefono);
			this.Controls.Add(this.txtcorreo);
			this.Controls.Add(this.txtnombrecompleto);
			this.Controls.Add(this.txtdocumento);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmClientes";
			this.Text = "Clientes";
			this.Load += new System.EventHandler(this.frmClientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtIndice;
		private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
		private FontAwesome.Sharp.IconButton btnbuscar;
		private System.Windows.Forms.TextBox txtbusqueda;
		private System.Windows.Forms.ComboBox cbobusqueda;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtid;
		private FontAwesome.Sharp.IconButton btneliminar;
		private System.Windows.Forms.Label label9;
		private FontAwesome.Sharp.IconButton btnlimpiar;
		private FontAwesome.Sharp.IconButton btnguardar;
		private System.Windows.Forms.DataGridView dgvdata;
		private System.Windows.Forms.ComboBox cboestado;
		private System.Windows.Forms.TextBox txttelefono;
		private System.Windows.Forms.TextBox txtcorreo;
		private System.Windows.Forms.TextBox txtnombrecompleto;
		private System.Windows.Forms.TextBox txtdocumento;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
	}
}