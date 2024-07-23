namespace CapaPresentacion
{
	partial class frmVentas
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtcantidad = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.txtstock = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtprecio = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
			this.txtidproducto = new System.Windows.Forms.TextBox();
			this.txtproducto = new System.Windows.Forms.TextBox();
			this.txtcodproducto = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtidcliente = new System.Windows.Forms.TextBox();
			this.btnbuscarcliente = new FontAwesome.Sharp.IconButton();
			this.txtnombrecliente = new System.Windows.Forms.TextBox();
			this.txtdoccliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbotipodocumento = new System.Windows.Forms.ComboBox();
			this.txtfecha = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
			this.dgvdata = new System.Windows.Forms.DataGridView();
			this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnregistrar = new FontAwesome.Sharp.IconButton();
			this.txttotalpagar = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtpagacon = new System.Windows.Forms.TextBox();
			this.txtcambio = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
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
			this.label9.TabIndex = 21;
			this.label9.Text = "Registrar Venta";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.White;
			this.groupBox3.Controls.Add(this.txtcantidad);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.txtstock);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.txtprecio);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.btnbuscarproducto);
			this.groupBox3.Controls.Add(this.txtidproducto);
			this.groupBox3.Controls.Add(this.txtproducto);
			this.groupBox3.Controls.Add(this.txtcodproducto);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Location = new System.Drawing.Point(45, 149);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(571, 126);
			this.groupBox3.TabIndex = 26;
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
			// txtstock
			// 
			this.txtstock.Location = new System.Drawing.Point(355, 89);
			this.txtstock.Name = "txtstock";
			this.txtstock.ReadOnly = true;
			this.txtstock.Size = new System.Drawing.Size(100, 20);
			this.txtstock.TabIndex = 30;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(352, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 29;
			this.label8.Text = "Stock:";
			// 
			// txtprecio
			// 
			this.txtprecio.Location = new System.Drawing.Point(355, 45);
			this.txtprecio.Name = "txtprecio";
			this.txtprecio.Size = new System.Drawing.Size(100, 20);
			this.txtprecio.TabIndex = 28;
			this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(352, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 27;
			this.label7.Text = "Precio:";
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
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.txtidcliente);
			this.groupBox2.Controls.Add(this.btnbuscarcliente);
			this.groupBox2.Controls.Add(this.txtnombrecliente);
			this.groupBox2.Controls.Add(this.txtdoccliente);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(380, 63);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(512, 80);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Información Cliente";
			// 
			// txtidcliente
			// 
			this.txtidcliente.Location = new System.Drawing.Point(468, 14);
			this.txtidcliente.Name = "txtidcliente";
			this.txtidcliente.ReadOnly = true;
			this.txtidcliente.Size = new System.Drawing.Size(30, 20);
			this.txtidcliente.TabIndex = 26;
			this.txtidcliente.Visible = false;
			// 
			// btnbuscarcliente
			// 
			this.btnbuscarcliente.BackColor = System.Drawing.Color.White;
			this.btnbuscarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnbuscarcliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnbuscarcliente.ForeColor = System.Drawing.Color.Black;
			this.btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
			this.btnbuscarcliente.IconColor = System.Drawing.Color.Black;
			this.btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnbuscarcliente.IconSize = 16;
			this.btnbuscarcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnbuscarcliente.Location = new System.Drawing.Point(154, 27);
			this.btnbuscarcliente.Name = "btnbuscarcliente";
			this.btnbuscarcliente.Size = new System.Drawing.Size(73, 36);
			this.btnbuscarcliente.TabIndex = 25;
			this.btnbuscarcliente.Text = "Buscar";
			this.btnbuscarcliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnbuscarcliente.UseVisualStyleBackColor = false;
			this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
			// 
			// txtnombrecliente
			// 
			this.txtnombrecliente.Location = new System.Drawing.Point(236, 37);
			this.txtnombrecliente.Name = "txtnombrecliente";
			this.txtnombrecliente.ReadOnly = true;
			this.txtnombrecliente.Size = new System.Drawing.Size(262, 20);
			this.txtnombrecliente.TabIndex = 3;
			// 
			// txtdoccliente
			// 
			this.txtdoccliente.Location = new System.Drawing.Point(22, 37);
			this.txtdoccliente.Name = "txtdoccliente";
			this.txtdoccliente.ReadOnly = true;
			this.txtdoccliente.Size = new System.Drawing.Size(122, 20);
			this.txtdoccliente.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(233, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Nombre Completo:";
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
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.cbotipodocumento);
			this.groupBox1.Controls.Add(this.txtfecha);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(45, 63);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(319, 80);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información Venta";
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
			// btnagregarproducto
			// 
			this.btnagregarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
			this.btnagregarproducto.IconColor = System.Drawing.Color.Green;
			this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnagregarproducto.Location = new System.Drawing.Point(622, 157);
			this.btnagregarproducto.Name = "btnagregarproducto";
			this.btnagregarproducto.Size = new System.Drawing.Size(113, 116);
			this.btnagregarproducto.TabIndex = 27;
			this.btnagregarproducto.Text = "Agregar";
			this.btnagregarproducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnagregarproducto.UseVisualStyleBackColor = true;
			this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
			// 
			// dgvdata
			// 
			this.dgvdata.AllowUserToAddRows = false;
			this.dgvdata.BackgroundColor = System.Drawing.Color.White;
			this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
			this.dgvdata.Location = new System.Drawing.Point(45, 292);
			this.dgvdata.Name = "dgvdata";
			this.dgvdata.ReadOnly = true;
			this.dgvdata.Size = new System.Drawing.Size(690, 343);
			this.dgvdata.TabIndex = 28;
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
			// Precio
			// 
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			this.Precio.ReadOnly = true;
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
			// btnregistrar
			// 
			this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
			this.btnregistrar.IconColor = System.Drawing.Color.DodgerBlue;
			this.btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnregistrar.IconSize = 40;
			this.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnregistrar.Location = new System.Drawing.Point(741, 581);
			this.btnregistrar.Name = "btnregistrar";
			this.btnregistrar.Size = new System.Drawing.Size(151, 54);
			this.btnregistrar.TabIndex = 38;
			this.btnregistrar.Text = "REGISTRAR";
			this.btnregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnregistrar.UseVisualStyleBackColor = true;
			// 
			// txttotalpagar
			// 
			this.txttotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttotalpagar.Location = new System.Drawing.Point(741, 549);
			this.txttotalpagar.Name = "txttotalpagar";
			this.txttotalpagar.ReadOnly = true;
			this.txttotalpagar.Size = new System.Drawing.Size(151, 26);
			this.txttotalpagar.TabIndex = 37;
			this.txttotalpagar.Text = "0,00";
			this.txttotalpagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.White;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(738, 529);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(98, 17);
			this.label11.TabIndex = 36;
			this.label11.Text = "Total a Pagar:";
			// 
			// txtpagacon
			// 
			this.txtpagacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpagacon.Location = new System.Drawing.Point(741, 400);
			this.txtpagacon.Name = "txtpagacon";
			this.txtpagacon.Size = new System.Drawing.Size(151, 26);
			this.txtpagacon.TabIndex = 39;
			this.txtpagacon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtpagacon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpagacon_KeyDown);
			this.txtpagacon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagacon_KeyPress);
			// 
			// txtcambio
			// 
			this.txtcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcambio.Location = new System.Drawing.Point(741, 470);
			this.txtcambio.Name = "txtcambio";
			this.txtcambio.ReadOnly = true;
			this.txtcambio.Size = new System.Drawing.Size(151, 26);
			this.txtcambio.TabIndex = 40;
			this.txtcambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.White;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(741, 380);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 17);
			this.label12.TabIndex = 41;
			this.label12.Text = "Paga con:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.White;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(738, 450);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(59, 17);
			this.label13.TabIndex = 42;
			this.label13.Text = "Cambio:";
			// 
			// frmVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 671);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtcambio);
			this.Controls.Add(this.txtpagacon);
			this.Controls.Add(this.btnregistrar);
			this.Controls.Add(this.txttotalpagar);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.dgvdata);
			this.Controls.Add(this.btnagregarproducto);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label9);
			this.Name = "frmVentas";
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.frmVentas_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
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
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.NumericUpDown txtcantidad;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtstock;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtprecio;
		private System.Windows.Forms.Label label7;
		private FontAwesome.Sharp.IconButton btnbuscarproducto;
		private System.Windows.Forms.TextBox txtidproducto;
		private System.Windows.Forms.TextBox txtproducto;
		private System.Windows.Forms.TextBox txtcodproducto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtidcliente;
		private FontAwesome.Sharp.IconButton btnbuscarcliente;
		private System.Windows.Forms.TextBox txtnombrecliente;
		private System.Windows.Forms.TextBox txtdoccliente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbotipodocumento;
		private System.Windows.Forms.TextBox txtfecha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private FontAwesome.Sharp.IconButton btnagregarproducto;
		private System.Windows.Forms.DataGridView dgvdata;
		private FontAwesome.Sharp.IconButton btnregistrar;
		private System.Windows.Forms.TextBox txttotalpagar;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtpagacon;
		private System.Windows.Forms.TextBox txtcambio;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
		private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
	}
}