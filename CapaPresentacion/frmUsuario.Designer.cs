﻿namespace CapaPresentacion
{
	partial class frmUsuario
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtdocumento = new System.Windows.Forms.TextBox();
			this.txtnombrecompleto = new System.Windows.Forms.TextBox();
			this.txtcorreo = new System.Windows.Forms.TextBox();
			this.txtclave = new System.Windows.Forms.TextBox();
			this.txtconfirmarclave = new System.Windows.Forms.TextBox();
			this.cborol = new System.Windows.Forms.ComboBox();
			this.cboestado = new System.Windows.Forms.ComboBox();
			this.btnguardar = new FontAwesome.Sharp.IconButton();
			this.btneditar = new FontAwesome.Sharp.IconButton();
			this.btneliminar = new FontAwesome.Sharp.IconButton();
			this.dgvdata = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label10 = new System.Windows.Forms.Label();
			this.cbobusqueda = new System.Windows.Forms.ComboBox();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.btnlimpiar = new FontAwesome.Sharp.IconButton();
			this.btnbuscar = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 496);
			this.label1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(9, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nro Documento:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(9, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre Completo:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(9, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Correo:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(9, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Contraseña:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(9, 212);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Confirmar Contraseña";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(9, 260);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(26, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Rol:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(9, 310);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Estado:";
			// 
			// txtdocumento
			// 
			this.txtdocumento.Location = new System.Drawing.Point(12, 24);
			this.txtdocumento.Name = "txtdocumento";
			this.txtdocumento.Size = new System.Drawing.Size(177, 20);
			this.txtdocumento.TabIndex = 8;
			// 
			// txtnombrecompleto
			// 
			this.txtnombrecompleto.Location = new System.Drawing.Point(12, 72);
			this.txtnombrecompleto.Name = "txtnombrecompleto";
			this.txtnombrecompleto.Size = new System.Drawing.Size(177, 20);
			this.txtnombrecompleto.TabIndex = 9;
			// 
			// txtcorreo
			// 
			this.txtcorreo.Location = new System.Drawing.Point(12, 123);
			this.txtcorreo.Name = "txtcorreo";
			this.txtcorreo.Size = new System.Drawing.Size(177, 20);
			this.txtcorreo.TabIndex = 10;
			// 
			// txtclave
			// 
			this.txtclave.Location = new System.Drawing.Point(12, 174);
			this.txtclave.Name = "txtclave";
			this.txtclave.PasswordChar = '*';
			this.txtclave.Size = new System.Drawing.Size(177, 20);
			this.txtclave.TabIndex = 11;
			// 
			// txtconfirmarclave
			// 
			this.txtconfirmarclave.Location = new System.Drawing.Point(12, 228);
			this.txtconfirmarclave.Name = "txtconfirmarclave";
			this.txtconfirmarclave.PasswordChar = '*';
			this.txtconfirmarclave.Size = new System.Drawing.Size(177, 20);
			this.txtconfirmarclave.TabIndex = 12;
			// 
			// cborol
			// 
			this.cborol.FormattingEnabled = true;
			this.cborol.Location = new System.Drawing.Point(12, 277);
			this.cborol.Name = "cborol";
			this.cborol.Size = new System.Drawing.Size(177, 21);
			this.cborol.TabIndex = 13;
			// 
			// cboestado
			// 
			this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboestado.FormattingEnabled = true;
			this.cboestado.Location = new System.Drawing.Point(12, 327);
			this.cboestado.Name = "cboestado";
			this.cboestado.Size = new System.Drawing.Size(177, 21);
			this.cboestado.TabIndex = 14;
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
			this.btnguardar.IconSize = 16;
			this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnguardar.Location = new System.Drawing.Point(12, 372);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(177, 27);
			this.btnguardar.TabIndex = 15;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnguardar.UseVisualStyleBackColor = false;
			this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
			// 
			// btneditar
			// 
			this.btneditar.BackColor = System.Drawing.Color.Blue;
			this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btneditar.ForeColor = System.Drawing.Color.White;
			this.btneditar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
			this.btneditar.IconColor = System.Drawing.Color.White;
			this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btneditar.IconSize = 16;
			this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btneditar.Location = new System.Drawing.Point(12, 413);
			this.btneditar.Name = "btneditar";
			this.btneditar.Size = new System.Drawing.Size(177, 27);
			this.btneditar.TabIndex = 16;
			this.btneditar.Text = "Editar";
			this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btneditar.UseVisualStyleBackColor = false;
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
			this.btneliminar.IconSize = 16;
			this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btneliminar.Location = new System.Drawing.Point(12, 455);
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.Size = new System.Drawing.Size(177, 27);
			this.btneliminar.TabIndex = 17;
			this.btneliminar.Text = "Eliminar";
			this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btneliminar.UseVisualStyleBackColor = false;
			// 
			// dgvdata
			// 
			this.dgvdata.AllowUserToAddRows = false;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.IdUsuario,
            this.Documento,
            this.NombreCompleto,
            this.Correo,
            this.Clave,
            this.IdRol,
            this.Rol,
            this.EstadoValor,
            this.Estado});
			this.dgvdata.Location = new System.Drawing.Point(212, 85);
			this.dgvdata.MultiSelect = false;
			this.dgvdata.Name = "dgvdata";
			this.dgvdata.ReadOnly = true;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvdata.RowTemplate.Height = 28;
			this.dgvdata.Size = new System.Drawing.Size(840, 397);
			this.dgvdata.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(207, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(845, 73);
			this.label9.TabIndex = 19;
			this.label9.Text = "Lista de Usuarios";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(162, 1);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(27, 20);
			this.txtid.TabIndex = 20;
			this.txtid.Text = "0";
			this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnseleccionar
			// 
			this.btnseleccionar.HeaderText = "";
			this.btnseleccionar.Name = "btnseleccionar";
			this.btnseleccionar.ReadOnly = true;
			this.btnseleccionar.Width = 30;
			// 
			// IdUsuario
			// 
			this.IdUsuario.HeaderText = "IdUsuario";
			this.IdUsuario.Name = "IdUsuario";
			this.IdUsuario.ReadOnly = true;
			this.IdUsuario.Visible = false;
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
			// Clave
			// 
			this.Clave.HeaderText = "Clave";
			this.Clave.Name = "Clave";
			this.Clave.ReadOnly = true;
			this.Clave.Visible = false;
			// 
			// IdRol
			// 
			this.IdRol.HeaderText = "Id Rol";
			this.IdRol.Name = "IdRol";
			this.IdRol.ReadOnly = true;
			this.IdRol.Visible = false;
			// 
			// Rol
			// 
			this.Rol.HeaderText = "Rol";
			this.Rol.Name = "Rol";
			this.Rol.ReadOnly = true;
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
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(697, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(61, 13);
			this.label10.TabIndex = 21;
			this.label10.Text = "Buscar por:";
			// 
			// cbobusqueda
			// 
			this.cbobusqueda.FormattingEnabled = true;
			this.cbobusqueda.Location = new System.Drawing.Point(764, 21);
			this.cbobusqueda.Name = "cbobusqueda";
			this.cbobusqueda.Size = new System.Drawing.Size(207, 21);
			this.cbobusqueda.TabIndex = 22;
			// 
			// txtbusqueda
			// 
			this.txtbusqueda.Location = new System.Drawing.Point(764, 53);
			this.txtbusqueda.Name = "txtbusqueda";
			this.txtbusqueda.Size = new System.Drawing.Size(207, 20);
			this.txtbusqueda.TabIndex = 23;
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.BackColor = System.Drawing.Color.White;
			this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
			this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
			this.btnlimpiar.IconColor = System.Drawing.Color.Black;
			this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnlimpiar.IconSize = 16;
			this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnlimpiar.Location = new System.Drawing.Point(977, 49);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(69, 27);
			this.btnlimpiar.TabIndex = 25;
			this.btnlimpiar.Text = "Limpiar";
			this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnlimpiar.UseVisualStyleBackColor = false;
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
			this.btnbuscar.Location = new System.Drawing.Point(977, 17);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(69, 27);
			this.btnbuscar.TabIndex = 24;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnbuscar.UseVisualStyleBackColor = false;
			// 
			// frmUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1064, 496);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtbusqueda);
			this.Controls.Add(this.cbobusqueda);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dgvdata);
			this.Controls.Add(this.btneliminar);
			this.Controls.Add(this.btneditar);
			this.Controls.Add(this.btnguardar);
			this.Controls.Add(this.cboestado);
			this.Controls.Add(this.cborol);
			this.Controls.Add(this.txtconfirmarclave);
			this.Controls.Add(this.txtclave);
			this.Controls.Add(this.txtcorreo);
			this.Controls.Add(this.txtnombrecompleto);
			this.Controls.Add(this.txtdocumento);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmUsuario";
			this.Text = "Usuario";
			this.Load += new System.EventHandler(this.frmUsuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtdocumento;
		private System.Windows.Forms.TextBox txtnombrecompleto;
		private System.Windows.Forms.TextBox txtcorreo;
		private System.Windows.Forms.TextBox txtclave;
		private System.Windows.Forms.TextBox txtconfirmarclave;
		private System.Windows.Forms.ComboBox cborol;
		private System.Windows.Forms.ComboBox cboestado;
		private FontAwesome.Sharp.IconButton btnguardar;
		private FontAwesome.Sharp.IconButton btneditar;
		private FontAwesome.Sharp.IconButton btneliminar;
		private System.Windows.Forms.DataGridView dgvdata;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
		private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbobusqueda;
		private System.Windows.Forms.TextBox txtbusqueda;
		private FontAwesome.Sharp.IconButton btnlimpiar;
		private FontAwesome.Sharp.IconButton btnbuscar;
	}
}