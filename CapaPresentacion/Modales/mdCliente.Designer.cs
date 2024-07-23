namespace CapaPresentacion.Modales
{
	partial class mdCliente
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
			this.label9 = new System.Windows.Forms.Label();
			this.dgvdata = new System.Windows.Forms.DataGridView();
			this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
			this.btnbuscar = new FontAwesome.Sharp.IconButton();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.cbobusqueda = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.label9.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.label9.Size = new System.Drawing.Size(642, 73);
			this.label9.TabIndex = 47;
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
            this.Documento,
            this.NombreCompleto});
			this.dgvdata.Location = new System.Drawing.Point(12, 85);
			this.dgvdata.MultiSelect = false;
			this.dgvdata.Name = "dgvdata";
			this.dgvdata.ReadOnly = true;
			this.dgvdata.RowTemplate.Height = 28;
			this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvdata.Size = new System.Drawing.Size(642, 353);
			this.dgvdata.TabIndex = 48;
			this.dgvdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellDoubleClick);
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
			this.btnlimpiarbuscador.Location = new System.Drawing.Point(577, 49);
			this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
			this.btnlimpiarbuscador.Size = new System.Drawing.Size(69, 27);
			this.btnlimpiarbuscador.TabIndex = 57;
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
			this.btnbuscar.Location = new System.Drawing.Point(577, 17);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(69, 27);
			this.btnbuscar.TabIndex = 56;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnbuscar.UseVisualStyleBackColor = false;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// txtbusqueda
			// 
			this.txtbusqueda.Location = new System.Drawing.Point(364, 53);
			this.txtbusqueda.Name = "txtbusqueda";
			this.txtbusqueda.Size = new System.Drawing.Size(207, 20);
			this.txtbusqueda.TabIndex = 55;
			// 
			// cbobusqueda
			// 
			this.cbobusqueda.FormattingEnabled = true;
			this.cbobusqueda.Location = new System.Drawing.Point(364, 21);
			this.cbobusqueda.Name = "cbobusqueda";
			this.cbobusqueda.Size = new System.Drawing.Size(207, 21);
			this.cbobusqueda.TabIndex = 54;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(297, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(61, 13);
			this.label10.TabIndex = 53;
			this.label10.Text = "Buscar por:";
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
			this.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NombreCompleto.HeaderText = "Nombre Completo";
			this.NombreCompleto.Name = "NombreCompleto";
			this.NombreCompleto.ReadOnly = true;
			// 
			// mdCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 450);
			this.Controls.Add(this.btnlimpiarbuscador);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtbusqueda);
			this.Controls.Add(this.cbobusqueda);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dgvdata);
			this.Controls.Add(this.label9);
			this.Name = "mdCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "mdCliente";
			this.Load += new System.EventHandler(this.mdCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView dgvdata;
		private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
		private FontAwesome.Sharp.IconButton btnbuscar;
		private System.Windows.Forms.TextBox txtbusqueda;
		private System.Windows.Forms.ComboBox cbobusqueda;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
	}
}