﻿namespace Conversor_A
{
	partial class Alquileres
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
			this.grbNavegar = new System.Windows.Forms.GroupBox();
			this.lblRegistros = new System.Windows.Forms.Label();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnPrimero = new System.Windows.Forms.Button();
			this.grbEdicionAlquileres = new System.Windows.Forms.GroupBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.grbAlquileres = new System.Windows.Forms.GroupBox();
			this.cboIdCliente = new System.Windows.Forms.ComboBox();
			this.cboIdPelicula = new System.Windows.Forms.ComboBox();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.lblValor = new System.Windows.Forms.Label();
			this.txtFDevolucion = new System.Windows.Forms.TextBox();
			this.txtFPrestamo = new System.Windows.Forms.TextBox();
			this.lblIdAlquiler = new System.Windows.Forms.Label();
			this.lblFechaDevolucion = new System.Windows.Forms.Label();
			this.lblFechaPrestamo = new System.Windows.Forms.Label();
			this.lblIdPelicula = new System.Windows.Forms.Label();
			this.lblIdCliente = new System.Windows.Forms.Label();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.btnBuscarPelicula = new System.Windows.Forms.Button();
			this.grbNavegar.SuspendLayout();
			this.grbEdicionAlquileres.SuspendLayout();
			this.grbAlquileres.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbNavegar
			// 
			this.grbNavegar.Controls.Add(this.lblRegistros);
			this.grbNavegar.Controls.Add(this.btnUltimo);
			this.grbNavegar.Controls.Add(this.btnSiguiente);
			this.grbNavegar.Controls.Add(this.btnAnterior);
			this.grbNavegar.Controls.Add(this.btnPrimero);
			this.grbNavegar.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbNavegar.Location = new System.Drawing.Point(12, 347);
			this.grbNavegar.Name = "grbNavegar";
			this.grbNavegar.Size = new System.Drawing.Size(575, 72);
			this.grbNavegar.TabIndex = 14;
			this.grbNavegar.TabStop = false;
			this.grbNavegar.Text = "Navegar";
			// 
			// lblRegistros
			// 
			this.lblRegistros.AutoSize = true;
			this.lblRegistros.Location = new System.Drawing.Point(250, 29);
			this.lblRegistros.Name = "lblRegistros";
			this.lblRegistros.Size = new System.Drawing.Size(0, 15);
			this.lblRegistros.TabIndex = 11;
			// 
			// btnUltimo
			// 
			this.btnUltimo.BackColor = System.Drawing.Color.Transparent;
			this.btnUltimo.Location = new System.Drawing.Point(517, 25);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(40, 23);
			this.btnUltimo.TabIndex = 10;
			this.btnUltimo.Text = ">|";
			this.btnUltimo.UseVisualStyleBackColor = false;
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
			this.btnSiguiente.Location = new System.Drawing.Point(393, 25);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(40, 23);
			this.btnSiguiente.TabIndex = 9;
			this.btnSiguiente.Text = ">";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
			this.btnAnterior.Location = new System.Drawing.Point(138, 25);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(40, 23);
			this.btnAnterior.TabIndex = 8;
			this.btnAnterior.Text = "<";
			this.btnAnterior.UseVisualStyleBackColor = false;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnPrimero
			// 
			this.btnPrimero.BackColor = System.Drawing.Color.Transparent;
			this.btnPrimero.Location = new System.Drawing.Point(17, 25);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(40, 23);
			this.btnPrimero.TabIndex = 7;
			this.btnPrimero.Text = "|<";
			this.btnPrimero.UseVisualStyleBackColor = false;
			this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
			// 
			// grbEdicionAlquileres
			// 
			this.grbEdicionAlquileres.Controls.Add(this.btnEliminar);
			this.grbEdicionAlquileres.Controls.Add(this.btnBuscar);
			this.grbEdicionAlquileres.Controls.Add(this.btnModificar);
			this.grbEdicionAlquileres.Controls.Add(this.btnNuevo);
			this.grbEdicionAlquileres.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbEdicionAlquileres.Location = new System.Drawing.Point(593, 12);
			this.grbEdicionAlquileres.Name = "grbEdicionAlquileres";
			this.grbEdicionAlquileres.Size = new System.Drawing.Size(104, 407);
			this.grbEdicionAlquileres.TabIndex = 13;
			this.grbEdicionAlquileres.TabStop = false;
			this.grbEdicionAlquileres.Text = "Editar Alquiler";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(6, 314);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(92, 31);
			this.btnEliminar.TabIndex = 4;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(6, 230);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(92, 31);
			this.btnBuscar.TabIndex = 3;
			this.btnBuscar.Text = "&Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(6, 148);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(92, 31);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "&Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Location = new System.Drawing.Point(6, 60);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(92, 31);
			this.btnNuevo.TabIndex = 1;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// grbAlquileres
			// 
			this.grbAlquileres.BackColor = System.Drawing.Color.Transparent;
			this.grbAlquileres.Controls.Add(this.btnBuscarPelicula);
			this.grbAlquileres.Controls.Add(this.btnBuscarCliente);
			this.grbAlquileres.Controls.Add(this.cboIdCliente);
			this.grbAlquileres.Controls.Add(this.cboIdPelicula);
			this.grbAlquileres.Controls.Add(this.txtValor);
			this.grbAlquileres.Controls.Add(this.lblValor);
			this.grbAlquileres.Controls.Add(this.txtFDevolucion);
			this.grbAlquileres.Controls.Add(this.txtFPrestamo);
			this.grbAlquileres.Controls.Add(this.lblIdAlquiler);
			this.grbAlquileres.Controls.Add(this.lblFechaDevolucion);
			this.grbAlquileres.Controls.Add(this.lblFechaPrestamo);
			this.grbAlquileres.Controls.Add(this.lblIdPelicula);
			this.grbAlquileres.Controls.Add(this.lblIdCliente);
			this.grbAlquileres.Enabled = false;
			this.grbAlquileres.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbAlquileres.Location = new System.Drawing.Point(12, 12);
			this.grbAlquileres.Name = "grbAlquileres";
			this.grbAlquileres.Size = new System.Drawing.Size(575, 329);
			this.grbAlquileres.TabIndex = 12;
			this.grbAlquileres.TabStop = false;
			this.grbAlquileres.Text = "Alquileres";
			// 
			// cboIdCliente
			// 
			this.cboIdCliente.FormattingEnabled = true;
			this.cboIdCliente.Location = new System.Drawing.Point(201, 36);
			this.cboIdCliente.Name = "cboIdCliente";
			this.cboIdCliente.Size = new System.Drawing.Size(221, 23);
			this.cboIdCliente.TabIndex = 12;
			// 
			// cboIdPelicula
			// 
			this.cboIdPelicula.FormattingEnabled = true;
			this.cboIdPelicula.Location = new System.Drawing.Point(201, 101);
			this.cboIdPelicula.Name = "cboIdPelicula";
			this.cboIdPelicula.Size = new System.Drawing.Size(221, 23);
			this.cboIdPelicula.TabIndex = 11;
			// 
			// txtValor
			// 
			this.txtValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValor.Location = new System.Drawing.Point(201, 289);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(143, 22);
			this.txtValor.TabIndex = 10;
			// 
			// lblValor
			// 
			this.lblValor.AutoSize = true;
			this.lblValor.Location = new System.Drawing.Point(85, 293);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(59, 15);
			this.lblValor.TabIndex = 9;
			this.lblValor.Text = "Valor$:";
			// 
			// txtFDevolucion
			// 
			this.txtFDevolucion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFDevolucion.Location = new System.Drawing.Point(201, 230);
			this.txtFDevolucion.Name = "txtFDevolucion";
			this.txtFDevolucion.Size = new System.Drawing.Size(221, 22);
			this.txtFDevolucion.TabIndex = 8;
			// 
			// txtFPrestamo
			// 
			this.txtFPrestamo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFPrestamo.Location = new System.Drawing.Point(201, 169);
			this.txtFPrestamo.Multiline = true;
			this.txtFPrestamo.Name = "txtFPrestamo";
			this.txtFPrestamo.Size = new System.Drawing.Size(221, 22);
			this.txtFPrestamo.TabIndex = 7;
			// 
			// lblIdAlquiler
			// 
			this.lblIdAlquiler.AutoSize = true;
			this.lblIdAlquiler.Location = new System.Drawing.Point(429, 13);
			this.lblIdAlquiler.Name = "lblIdAlquiler";
			this.lblIdAlquiler.Size = new System.Drawing.Size(22, 15);
			this.lblIdAlquiler.TabIndex = 4;
			this.lblIdAlquiler.Text = "ID:";
			// 
			// lblFechaDevolucion
			// 
			this.lblFechaDevolucion.AutoSize = true;
			this.lblFechaDevolucion.Location = new System.Drawing.Point(-2, 234);
			this.lblFechaDevolucion.Name = "lblFechaDevolucion";
			this.lblFechaDevolucion.Size = new System.Drawing.Size(148, 15);
			this.lblFechaDevolucion.TabIndex = 3;
			this.lblFechaDevolucion.Text = "Fecha de Devolución:";
			// 
			// lblFechaPrestamo
			// 
			this.lblFechaPrestamo.AutoSize = true;
			this.lblFechaPrestamo.Location = new System.Drawing.Point(6, 173);
			this.lblFechaPrestamo.Name = "lblFechaPrestamo";
			this.lblFechaPrestamo.Size = new System.Drawing.Size(140, 15);
			this.lblFechaPrestamo.TabIndex = 2;
			this.lblFechaPrestamo.Text = "Fecha de Prestamo:";
			// 
			// lblIdPelicula
			// 
			this.lblIdPelicula.AutoSize = true;
			this.lblIdPelicula.Location = new System.Drawing.Point(76, 104);
			this.lblIdPelicula.Name = "lblIdPelicula";
			this.lblIdPelicula.Size = new System.Drawing.Size(70, 15);
			this.lblIdPelicula.TabIndex = 1;
			this.lblIdPelicula.Text = "Película:";
			// 
			// lblIdCliente
			// 
			this.lblIdCliente.AutoSize = true;
			this.lblIdCliente.Location = new System.Drawing.Point(85, 39);
			this.lblIdCliente.Name = "lblIdCliente";
			this.lblIdCliente.Size = new System.Drawing.Size(61, 15);
			this.lblIdCliente.TabIndex = 0;
			this.lblIdCliente.Text = "Cliente:";
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarCliente.Location = new System.Drawing.Point(428, 30);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.Size = new System.Drawing.Size(129, 30);
			this.btnBuscarCliente.TabIndex = 13;
			this.btnBuscarCliente.Text = "Buscar Cliente";
			this.btnBuscarCliente.UseVisualStyleBackColor = true;
			this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
			// 
			// btnBuscarPelicula
			// 
			this.btnBuscarPelicula.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarPelicula.Location = new System.Drawing.Point(428, 94);
			this.btnBuscarPelicula.Name = "btnBuscarPelicula";
			this.btnBuscarPelicula.Size = new System.Drawing.Size(141, 32);
			this.btnBuscarPelicula.TabIndex = 14;
			this.btnBuscarPelicula.Text = "Buscar Película";
			this.btnBuscarPelicula.UseVisualStyleBackColor = true;
			// 
			// Alquileres
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(711, 433);
			this.Controls.Add(this.grbNavegar);
			this.Controls.Add(this.grbEdicionAlquileres);
			this.Controls.Add(this.grbAlquileres);
			this.Name = "Alquileres";
			this.Text = "Alquileres";
			this.Load += new System.EventHandler(this.Alquileres_Load);
			this.grbNavegar.ResumeLayout(false);
			this.grbNavegar.PerformLayout();
			this.grbEdicionAlquileres.ResumeLayout(false);
			this.grbAlquileres.ResumeLayout(false);
			this.grbAlquileres.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbNavegar;
		private System.Windows.Forms.Label lblRegistros;
		private System.Windows.Forms.Button btnUltimo;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnPrimero;
		private System.Windows.Forms.GroupBox grbEdicionAlquileres;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.GroupBox grbAlquileres;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.TextBox txtFDevolucion;
		private System.Windows.Forms.TextBox txtFPrestamo;
		private System.Windows.Forms.Label lblIdAlquiler;
		private System.Windows.Forms.Label lblFechaDevolucion;
		private System.Windows.Forms.Label lblFechaPrestamo;
		private System.Windows.Forms.Label lblIdPelicula;
		private System.Windows.Forms.Label lblIdCliente;
		private System.Windows.Forms.ComboBox cboIdCliente;
		private System.Windows.Forms.ComboBox cboIdPelicula;
		private System.Windows.Forms.Button btnBuscarPelicula;
		private System.Windows.Forms.Button btnBuscarCliente;
	}
}