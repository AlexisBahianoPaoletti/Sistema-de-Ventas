﻿namespace CapaPresentacion
{
	partial class frmCompras
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbotipodocumento = new System.Windows.Forms.ComboBox();
			this.txtfecha = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtidproveedor = new System.Windows.Forms.TextBox();
			this.btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
			this.txtnombreproveedor = new System.Windows.Forms.TextBox();
			this.txtdocproveedor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtcantidad = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.txtprecioventa = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtpreciocompra = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
			this.txtidproducto = new System.Windows.Forms.TextBox();
			this.txtproducto = new System.Windows.Forms.TextBox();
			this.txtcodproducto = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvdata = new System.Windows.Forms.DataGridView();
			this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.txttotalpagar = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnregistrar = new FontAwesome.Sharp.IconButton();
			this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(22, 23);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.label9.Size = new System.Drawing.Size(887, 633);
			this.label9.TabIndex = 20;
			this.label9.Text = "Registrar Compra";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.cbotipodocumento);
			this.groupBox1.Controls.Add(this.txtfecha);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(45, 65);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(319, 80);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información Compra";
			// 
			// cbotipodocumento
			// 
			this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbotipodocumento.FormattingEnabled = true;
			this.cbotipodocumento.Location = new System.Drawing.Point(145, 36);
			this.cbotipodocumento.Name = "cbotipodocumento";
			this.cbotipodocumento.Size = new System.Drawing.Size(155, 21);
			this.cbotipodocumento.TabIndex = 3;
			// 
			// txtfecha
			// 
			this.txtfecha.Location = new System.Drawing.Point(17, 36);
			this.txtfecha.Name = "txtfecha";
			this.txtfecha.ReadOnly = true;
			this.txtfecha.Size = new System.Drawing.Size(100, 20);
			this.txtfecha.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(142, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tipo Documento:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fecha:";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.txtidproveedor);
			this.groupBox2.Controls.Add(this.btnbuscarproveedor);
			this.groupBox2.Controls.Add(this.txtnombreproveedor);
			this.groupBox2.Controls.Add(this.txtdocproveedor);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(380, 65);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(512, 80);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Información Proveedor";
			// 
			// txtidproveedor
			// 
			this.txtidproveedor.Location = new System.Drawing.Point(468, 14);
			this.txtidproveedor.Name = "txtidproveedor";
			this.txtidproveedor.ReadOnly = true;
			this.txtidproveedor.Size = new System.Drawing.Size(30, 20);
			this.txtidproveedor.TabIndex = 26;
			this.txtidproveedor.Visible = false;
			// 
			// btnbuscarproveedor
			// 
			this.btnbuscarproveedor.BackColor = System.Drawing.Color.White;
			this.btnbuscarproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnbuscarproveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnbuscarproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnbuscarproveedor.ForeColor = System.Drawing.Color.Black;
			this.btnbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
			this.btnbuscarproveedor.IconColor = System.Drawing.Color.Black;
			this.btnbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnbuscarproveedor.IconSize = 16;
			this.btnbuscarproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnbuscarproveedor.Location = new System.Drawing.Point(154, 27);
			this.btnbuscarproveedor.Name = "btnbuscarproveedor";
			this.btnbuscarproveedor.Size = new System.Drawing.Size(73, 36);
			this.btnbuscarproveedor.TabIndex = 25;
			this.btnbuscarproveedor.Text = "Buscar";
			this.btnbuscarproveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnbuscarproveedor.UseVisualStyleBackColor = false;
			this.btnbuscarproveedor.Click += new System.EventHandler(this.btnbuscarproveedor_Click);
			// 
			// txtnombreproveedor
			// 
			this.txtnombreproveedor.Location = new System.Drawing.Point(236, 37);
			this.txtnombreproveedor.Name = "txtnombreproveedor";
			this.txtnombreproveedor.ReadOnly = true;
			this.txtnombreproveedor.Size = new System.Drawing.Size(262, 20);
			this.txtnombreproveedor.TabIndex = 3;
			// 
			// txtdocproveedor
			// 
			this.txtdocproveedor.Location = new System.Drawing.Point(22, 37);
			this.txtdocproveedor.Name = "txtdocproveedor";
			this.txtdocproveedor.ReadOnly = true;
			this.txtdocproveedor.Size = new System.Drawing.Size(122, 20);
			this.txtdocproveedor.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(233, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Razón Social:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Número Documento:";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.White;
			this.groupBox3.Controls.Add(this.txtcantidad);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.txtprecioventa);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.txtpreciocompra);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.btnbuscarproducto);
			this.groupBox3.Controls.Add(this.txtidproducto);
			this.groupBox3.Controls.Add(this.txtproducto);
			this.groupBox3.Controls.Add(this.txtcodproducto);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Location = new System.Drawing.Point(45, 151);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(571, 126);
			this.groupBox3.TabIndex = 23;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Información de Producto";
			// 
			// txtcantidad
			// 
			this.txtcantidad.Location = new System.Drawing.Point(482, 44);
			this.txtcantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txtcantidad.Name = "txtcantidad";
			this.txtcantidad.Size = new System.Drawing.Size(74, 20);
			this.txtcantidad.TabIndex = 32;
			this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(479, 29);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(52, 13);
			this.label10.TabIndex = 31;
			this.label10.Text = "Cantidad:";
			// 
			// txtprecioventa
			// 
			this.txtprecioventa.Location = new System.Drawing.Point(355, 89);
			this.txtprecioventa.Name = "txtprecioventa";
			this.txtprecioventa.Size = new System.Drawing.Size(100, 20);
			this.txtprecioventa.TabIndex = 30;
			this.txtprecioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioventa_KeyPress);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(352, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 13);
			this.label8.TabIndex = 29;
			this.label8.Text = "Precio Venta:";
			// 
			// txtpreciocompra
			// 
			this.txtpreciocompra.Location = new System.Drawing.Point(355, 45);
			this.txtpreciocompra.Name = "txtpreciocompra";
			this.txtpreciocompra.Size = new System.Drawing.Size(100, 20);
			this.txtpreciocompra.TabIndex = 28;
			this.txtpreciocompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciocompra_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(352, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 13);
			this.label7.TabIndex = 27;
			this.label7.Text = "Precio Compra:";
			// 
			// btnbuscarproducto
			// 
			this.btnbuscarproducto.BackColor = System.Drawing.Color.White;
			this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnbuscarproducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnbuscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnbuscarproducto.ForeColor = System.Drawing.Color.Black;
			this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
			this.btnbuscarproducto.IconColor = System.Drawing.Color.Black;
			this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnbuscarproducto.IconSize = 16;
			this.btnbuscarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnbuscarproducto.Location = new System.Drawing.Point(245, 36);
			this.btnbuscarproducto.Name = "btnbuscarproducto";
			this.btnbuscarproducto.Size = new System.Drawing.Size(74, 36);
			this.btnbuscarproducto.TabIndex = 25;
			this.btnbuscarproducto.Text = "Buscar";
			this.btnbuscarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnbuscarproducto.UseVisualStyleBackColor = false;
			this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
			// 
			// txtidproducto
			// 
			this.txtidproducto.Location = new System.Drawing.Point(156, 44);
			this.txtidproducto.Name = "txtidproducto";
			this.txtidproducto.ReadOnly = true;
			this.txtidproducto.Size = new System.Drawing.Size(30, 20);
			this.txtidproducto.TabIndex = 26;
			this.txtidproducto.Visible = false;
			// 
			// txtproducto
			// 
			this.txtproducto.Location = new System.Drawing.Point(20, 89);
			this.txtproducto.Name = "txtproducto";
			this.txtproducto.ReadOnly = true;
			this.txtproducto.Size = new System.Drawing.Size(299, 20);
			this.txtproducto.TabIndex = 3;
			// 
			// txtcodproducto
			// 
			this.txtcodproducto.Location = new System.Drawing.Point(17, 45);
			this.txtcodproducto.Name = "txtcodproducto";
			this.txtcodproducto.Size = new System.Drawing.Size(124, 20);
			this.txtcodproducto.TabIndex = 2;
			this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Producto:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(17, 29);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(106, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Código del Producto:";
			// 
			// dgvdata
			// 
			this.dgvdata.AllowUserToAddRows = false;
			this.dgvdata.BackgroundColor = System.Drawing.Color.White;
			this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
			this.dgvdata.Location = new System.Drawing.Point(45, 295);
			this.dgvdata.Name = "dgvdata";
			this.dgvdata.ReadOnly = true;
			this.dgvdata.Size = new System.Drawing.Size(690, 343);
			this.dgvdata.TabIndex = 24;
			this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
			this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
			// 
			// IdProducto
			// 
			this.IdProducto.HeaderText = "IdProducto";
			this.IdProducto.Name = "IdProducto";
			this.IdProducto.ReadOnly = true;
			this.IdProducto.Visible = false;
			// 
			// Producto
			// 
			this.Producto.HeaderText = "Producto";
			this.Producto.Name = "Producto";
			this.Producto.ReadOnly = true;
			this.Producto.Width = 300;
			// 
			// PrecioCompra
			// 
			this.PrecioCompra.HeaderText = "Precio Compra";
			this.PrecioCompra.Name = "PrecioCompra";
			this.PrecioCompra.ReadOnly = true;
			// 
			// PrecioVenta
			// 
			this.PrecioVenta.HeaderText = "PrecioVenta";
			this.PrecioVenta.Name = "PrecioVenta";
			this.PrecioVenta.ReadOnly = true;
			this.PrecioVenta.Visible = false;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			this.Cantidad.Width = 65;
			// 
			// SubTotal
			// 
			this.SubTotal.HeaderText = "Sub Total";
			this.SubTotal.Name = "SubTotal";
			this.SubTotal.ReadOnly = true;
			this.SubTotal.Width = 135;
			// 
			// btneliminar
			// 
			this.btneliminar.HeaderText = "";
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.ReadOnly = true;
			this.btneliminar.Width = 50;
			// 
			// txttotalpagar
			// 
			this.txttotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttotalpagar.Location = new System.Drawing.Point(741, 552);
			this.txttotalpagar.Name = "txttotalpagar";
			this.txttotalpagar.ReadOnly = true;
			this.txttotalpagar.Size = new System.Drawing.Size(151, 26);
			this.txttotalpagar.TabIndex = 34;
			this.txttotalpagar.Text = "0,00";
			this.txttotalpagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.White;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(738, 532);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(98, 17);
			this.label11.TabIndex = 33;
			this.label11.Text = "Total a Pagar:";
			// 
			// btnregistrar
			// 
			this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
			this.btnregistrar.IconColor = System.Drawing.Color.DodgerBlue;
			this.btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnregistrar.IconSize = 40;
			this.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnregistrar.Location = new System.Drawing.Point(741, 584);
			this.btnregistrar.Name = "btnregistrar";
			this.btnregistrar.Size = new System.Drawing.Size(151, 54);
			this.btnregistrar.TabIndex = 35;
			this.btnregistrar.Text = "REGISTRAR";
			this.btnregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnregistrar.UseVisualStyleBackColor = true;
			this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
			// 
			// btnagregarproducto
			// 
			this.btnagregarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
			this.btnagregarproducto.IconColor = System.Drawing.Color.Green;
			this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnagregarproducto.Location = new System.Drawing.Point(623, 158);
			this.btnagregarproducto.Name = "btnagregarproducto";
			this.btnagregarproducto.Size = new System.Drawing.Size(113, 116);
			this.btnagregarproducto.TabIndex = 25;
			this.btnagregarproducto.Text = "Agregar";
			this.btnagregarproducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnagregarproducto.UseVisualStyleBackColor = true;
			this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
			// 
			// frmCompras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 671);
			this.Controls.Add(this.btnregistrar);
			this.Controls.Add(this.txttotalpagar);
			this.Controls.Add(this.btnagregarproducto);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.dgvdata);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label9);
			this.Name = "frmCompras";
			this.Text = "Compras";
			this.Load += new System.EventHandler(this.frmCompras_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbotipodocumento;
		private System.Windows.Forms.TextBox txtfecha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtnombreproveedor;
		private System.Windows.Forms.TextBox txtdocproveedor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtidproveedor;
		private FontAwesome.Sharp.IconButton btnbuscarproveedor;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtprecioventa;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtpreciocompra;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtidproducto;
		private FontAwesome.Sharp.IconButton btnbuscarproducto;
		private System.Windows.Forms.TextBox txtproducto;
		private System.Windows.Forms.TextBox txtcodproducto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown txtcantidad;
		private System.Windows.Forms.DataGridView dgvdata;
		private FontAwesome.Sharp.IconButton btnagregarproducto;
		private System.Windows.Forms.TextBox txttotalpagar;
		private System.Windows.Forms.Label label11;
		private FontAwesome.Sharp.IconButton btnregistrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
		private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
	}
}