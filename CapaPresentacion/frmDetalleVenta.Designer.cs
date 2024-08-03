namespace CapaPresentacion
{
	partial class frmDetalleVenta
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
			this.label9 = new System.Windows.Forms.Label();
			this.btnborrar = new FontAwesome.Sharp.IconButton();
			this.btnbuscar = new FontAwesome.Sharp.IconButton();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtnumerodocumento = new System.Windows.Forms.TextBox();
			this.txtnombrecliente = new System.Windows.Forms.TextBox();
			this.txtdoccliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txttipodocumento = new System.Windows.Forms.TextBox();
			this.txtusuario = new System.Windows.Forms.TextBox();
			this.txtfecha = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btndescargarpdf = new FontAwesome.Sharp.IconButton();
			this.txtmontototal = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.dgvdata = new System.Windows.Forms.DataGridView();
			this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtmontopago = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtmontocambio = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(25, 19);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.label9.Size = new System.Drawing.Size(887, 633);
			this.label9.TabIndex = 22;
			this.label9.Text = "Detalle Venta";
			// 
			// btnborrar
			// 
			this.btnborrar.BackColor = System.Drawing.Color.White;
			this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnborrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnborrar.ForeColor = System.Drawing.Color.Black;
			this.btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
			this.btnborrar.IconColor = System.Drawing.Color.Black;
			this.btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnborrar.IconSize = 16;
			this.btnborrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnborrar.Location = new System.Drawing.Point(822, 32);
			this.btnborrar.Name = "btnborrar";
			this.btnborrar.Size = new System.Drawing.Size(69, 27);
			this.btnborrar.TabIndex = 56;
			this.btnborrar.Text = "Limpiar";
			this.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnborrar.UseVisualStyleBackColor = false;
			this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
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
			this.btnbuscar.Location = new System.Drawing.Point(747, 32);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(69, 27);
			this.btnbuscar.TabIndex = 55;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnbuscar.UseVisualStyleBackColor = false;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// txtbusqueda
			// 
			this.txtbusqueda.Location = new System.Drawing.Point(621, 36);
			this.txtbusqueda.Name = "txtbusqueda";
			this.txtbusqueda.Size = new System.Drawing.Size(120, 20);
			this.txtbusqueda.TabIndex = 54;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(514, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 13);
			this.label6.TabIndex = 53;
			this.label6.Text = "Número Documento:";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.txtnumerodocumento);
			this.groupBox2.Controls.Add(this.txtnombrecliente);
			this.groupBox2.Controls.Add(this.txtdoccliente);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(45, 152);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(846, 80);
			this.groupBox2.TabIndex = 52;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Información Cliente";
			// 
			// txtnumerodocumento
			// 
			this.txtnumerodocumento.Location = new System.Drawing.Point(702, 36);
			this.txtnumerodocumento.Name = "txtnumerodocumento";
			this.txtnumerodocumento.Size = new System.Drawing.Size(120, 20);
			this.txtnumerodocumento.TabIndex = 45;
			this.txtnumerodocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtnumerodocumento.Visible = false;
			// 
			// txtnombrecliente
			// 
			this.txtnombrecliente.Location = new System.Drawing.Point(419, 36);
			this.txtnombrecliente.Name = "txtnombrecliente";
			this.txtnombrecliente.ReadOnly = true;
			this.txtnombrecliente.Size = new System.Drawing.Size(262, 20);
			this.txtnombrecliente.TabIndex = 3;
			// 
			// txtdoccliente
			// 
			this.txtdoccliente.Location = new System.Drawing.Point(159, 37);
			this.txtdoccliente.Name = "txtdoccliente";
			this.txtdoccliente.ReadOnly = true;
			this.txtdoccliente.Size = new System.Drawing.Size(122, 20);
			this.txtdoccliente.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(416, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Nombre Cliente:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(156, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Documento Cliente:";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txttipodocumento);
			this.groupBox1.Controls.Add(this.txtusuario);
			this.groupBox1.Controls.Add(this.txtfecha);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(45, 65);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(846, 80);
			this.groupBox1.TabIndex = 51;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información Venta";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(516, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Usuario:";
			// 
			// txttipodocumento
			// 
			this.txttipodocumento.Location = new System.Drawing.Point(272, 37);
			this.txttipodocumento.Name = "txttipodocumento";
			this.txttipodocumento.ReadOnly = true;
			this.txttipodocumento.Size = new System.Drawing.Size(155, 20);
			this.txttipodocumento.TabIndex = 5;
			// 
			// txtusuario
			// 
			this.txtusuario.Location = new System.Drawing.Point(519, 36);
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.ReadOnly = true;
			this.txtusuario.Size = new System.Drawing.Size(262, 20);
			this.txtusuario.TabIndex = 4;
			// 
			// txtfecha
			// 
			this.txtfecha.Location = new System.Drawing.Point(85, 32);
			this.txtfecha.Name = "txtfecha";
			this.txtfecha.ReadOnly = true;
			this.txtfecha.Size = new System.Drawing.Size(100, 20);
			this.txtfecha.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(269, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tipo Documento:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fecha:";
			// 
			// btndescargarpdf
			// 
			this.btndescargarpdf.BackColor = System.Drawing.Color.White;
			this.btndescargarpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btndescargarpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndescargarpdf.ForeColor = System.Drawing.Color.Black;
			this.btndescargarpdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
			this.btndescargarpdf.IconColor = System.Drawing.Color.Red;
			this.btndescargarpdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btndescargarpdf.IconSize = 25;
			this.btndescargarpdf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btndescargarpdf.Location = new System.Drawing.Point(45, 598);
			this.btndescargarpdf.Name = "btndescargarpdf";
			this.btndescargarpdf.Size = new System.Drawing.Size(127, 40);
			this.btndescargarpdf.TabIndex = 50;
			this.btndescargarpdf.Text = "Descargar PDF";
			this.btndescargarpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btndescargarpdf.UseVisualStyleBackColor = false;
			this.btndescargarpdf.Click += new System.EventHandler(this.btndescargarpdf_Click);
			// 
			// txtmontototal
			// 
			this.txtmontototal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmontototal.Location = new System.Drawing.Point(740, 606);
			this.txtmontototal.Name = "txtmontototal";
			this.txtmontototal.ReadOnly = true;
			this.txtmontototal.Size = new System.Drawing.Size(151, 26);
			this.txtmontototal.TabIndex = 49;
			this.txtmontototal.Text = "0,00";
			this.txtmontototal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.White;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(625, 609);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(109, 20);
			this.label11.TabIndex = 48;
			this.label11.Text = "Monto Total:";
			// 
			// dgvdata
			// 
			this.dgvdata.AllowUserToAddRows = false;
			this.dgvdata.BackgroundColor = System.Drawing.Color.White;
			this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
			this.dgvdata.Location = new System.Drawing.Point(45, 238);
			this.dgvdata.Name = "dgvdata";
			this.dgvdata.ReadOnly = true;
			this.dgvdata.Size = new System.Drawing.Size(846, 354);
			this.dgvdata.TabIndex = 47;
			// 
			// Producto
			// 
			this.Producto.HeaderText = "Producto";
			this.Producto.Name = "Producto";
			this.Producto.ReadOnly = true;
			this.Producto.Width = 403;
			// 
			// Precio
			// 
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			this.Precio.ReadOnly = true;
			this.Precio.Width = 130;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			this.Cantidad.Width = 110;
			// 
			// SubTotal
			// 
			this.SubTotal.HeaderText = "Sub Total";
			this.SubTotal.Name = "SubTotal";
			this.SubTotal.ReadOnly = true;
			this.SubTotal.Width = 160;
			// 
			// txtmontopago
			// 
			this.txtmontopago.Location = new System.Drawing.Point(343, 611);
			this.txtmontopago.Name = "txtmontopago";
			this.txtmontopago.ReadOnly = true;
			this.txtmontopago.Size = new System.Drawing.Size(83, 20);
			this.txtmontopago.TabIndex = 58;
			this.txtmontopago.Text = "0,00";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(272, 614);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 13);
			this.label7.TabIndex = 57;
			this.label7.Text = "Monto Pago:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(447, 614);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 13);
			this.label8.TabIndex = 59;
			this.label8.Text = "Monto Cambio:";
			// 
			// txtmontocambio
			// 
			this.txtmontocambio.Location = new System.Drawing.Point(531, 611);
			this.txtmontocambio.Name = "txtmontocambio";
			this.txtmontocambio.ReadOnly = true;
			this.txtmontocambio.Size = new System.Drawing.Size(83, 20);
			this.txtmontocambio.TabIndex = 60;
			this.txtmontocambio.Text = "0,00";
			// 
			// frmDetalleVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 671);
			this.Controls.Add(this.txtmontocambio);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtmontopago);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnborrar);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtbusqueda);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btndescargarpdf);
			this.Controls.Add(this.txtmontototal);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.dgvdata);
			this.Controls.Add(this.label9);
			this.Name = "frmDetalleVenta";
			this.Text = "Detalles Venta";
			this.Load += new System.EventHandler(this.frmDetalleVenta_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label9;
		private FontAwesome.Sharp.IconButton btnborrar;
		private FontAwesome.Sharp.IconButton btnbuscar;
		private System.Windows.Forms.TextBox txtbusqueda;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtnumerodocumento;
		private System.Windows.Forms.TextBox txtnombrecliente;
		private System.Windows.Forms.TextBox txtdoccliente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txttipodocumento;
		private System.Windows.Forms.TextBox txtusuario;
		private System.Windows.Forms.TextBox txtfecha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private FontAwesome.Sharp.IconButton btndescargarpdf;
		private System.Windows.Forms.TextBox txtmontototal;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DataGridView dgvdata;
		private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
		private System.Windows.Forms.TextBox txtmontopago;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtmontocambio;
	}
}