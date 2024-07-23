namespace CapaPresentacion
{
	partial class frmNegocio
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.txtruc = new System.Windows.Forms.TextBox();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnguardar = new FontAwesome.Sharp.IconButton();
			this.btnsubir = new FontAwesome.Sharp.IconButton();
			this.label3 = new System.Windows.Forms.Label();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(575, 317);
			this.label1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.txtdireccion);
			this.groupBox1.Controls.Add(this.txtruc);
			this.groupBox1.Controls.Add(this.txtnombre);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnguardar);
			this.groupBox1.Controls.Add(this.btnsubir);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.picLogo);
			this.groupBox1.Location = new System.Drawing.Point(22, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(527, 238);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// txtdireccion
			// 
			this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtdireccion.Location = new System.Drawing.Point(190, 148);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(320, 23);
			this.txtdireccion.TabIndex = 9;
			// 
			// txtruc
			// 
			this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtruc.Location = new System.Drawing.Point(190, 91);
			this.txtruc.Name = "txtruc";
			this.txtruc.Size = new System.Drawing.Size(320, 23);
			this.txtruc.TabIndex = 8;
			// 
			// txtnombre
			// 
			this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnombre.Location = new System.Drawing.Point(190, 36);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(320, 23);
			this.txtnombre.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(187, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Dirección:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(187, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Nombre Negocio:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(187, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "R.U.C:";
			// 
			// btnguardar
			// 
			this.btnguardar.BackColor = System.Drawing.SystemColors.Control;
			this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
			this.btnguardar.IconColor = System.Drawing.Color.Black;
			this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnguardar.IconSize = 18;
			this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnguardar.Location = new System.Drawing.Point(190, 192);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(320, 27);
			this.btnguardar.TabIndex = 3;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnguardar.UseVisualStyleBackColor = false;
			this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
			// 
			// btnsubir
			// 
			this.btnsubir.BackColor = System.Drawing.SystemColors.Control;
			this.btnsubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnsubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
			this.btnsubir.IconColor = System.Drawing.Color.Black;
			this.btnsubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnsubir.IconSize = 18;
			this.btnsubir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnsubir.Location = new System.Drawing.Point(27, 192);
			this.btnsubir.Name = "btnsubir";
			this.btnsubir.Size = new System.Drawing.Size(150, 27);
			this.btnsubir.TabIndex = 2;
			this.btnsubir.Text = "Subir";
			this.btnsubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnsubir.UseVisualStyleBackColor = false;
			this.btnsubir.Click += new System.EventHandler(this.btnsubir_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Logo:";
			// 
			// picLogo
			// 
			this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picLogo.Location = new System.Drawing.Point(27, 36);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(150, 150);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLogo.TabIndex = 0;
			this.picLogo.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Detalles Negocio";
			// 
			// frmNegocio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 317);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "frmNegocio";
			this.Text = "Negocio";
			this.Load += new System.EventHandler(this.frmNegocio_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox picLogo;
		private FontAwesome.Sharp.IconButton btnsubir;
		private FontAwesome.Sharp.IconButton btnguardar;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.TextBox txtruc;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
	}
}