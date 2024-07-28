﻿namespace UI
{
    partial class SaleForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupProducto = new System.Windows.Forms.GroupBox();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnVerStock = new System.Windows.Forms.Button();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();
            this.btnVerPedido = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.GroupProductoFiltro = new System.Windows.Forms.GroupBox();
            this.CboxFiltroMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.CboxFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            this.lblFiltrarPorCategoria = new System.Windows.Forms.Label();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.GroupPedido = new System.Windows.Forms.GroupBox();
            this.btnGenerarPedido = new System.Windows.Forms.Button();
            this.GroupCliente = new System.Windows.Forms.GroupBox();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.btnAgregarNuevoCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtBuscarPorIdNumber = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.GroupProducto.SuspendLayout();
            this.GroupProductoFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.GroupPedido.SuspendLayout();
            this.GroupCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupProducto
            // 
            this.GroupProducto.Controls.Add(this.lblCantidad);
            this.GroupProducto.Controls.Add(this.btnCancelarPedido);
            this.GroupProducto.Controls.Add(this.txtCantidadProducto);
            this.GroupProducto.Controls.Add(this.btnVerStock);
            this.GroupProducto.Controls.Add(this.btnConfirmarPedido);
            this.GroupProducto.Controls.Add(this.btnVerPedido);
            this.GroupProducto.Controls.Add(this.btnAgregarProducto);
            this.GroupProducto.Controls.Add(this.GroupProductoFiltro);
            this.GroupProducto.Controls.Add(this.gridProducts);
            this.GroupProducto.Enabled = false;
            this.GroupProducto.Location = new System.Drawing.Point(292, 12);
            this.GroupProducto.Name = "GroupProducto";
            this.GroupProducto.Size = new System.Drawing.Size(942, 485);
            this.GroupProducto.TabIndex = 0;
            this.GroupProducto.TabStop = false;
            this.GroupProducto.Text = "Producto";
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(822, 394);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(98, 34);
            this.btnCancelarPedido.TabIndex = 14;
            this.btnCancelarPedido.Text = "CANCELAR PEDIDO";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // btnVerStock
            // 
            this.btnVerStock.Location = new System.Drawing.Point(718, 348);
            this.btnVerStock.Name = "btnVerStock";
            this.btnVerStock.Size = new System.Drawing.Size(202, 32);
            this.btnVerStock.TabIndex = 13;
            this.btnVerStock.Text = "VER STOCK";
            this.btnVerStock.UseVisualStyleBackColor = true;
            this.btnVerStock.Click += new System.EventHandler(this.btnVerStock_Click);
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.Location = new System.Drawing.Point(718, 437);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(202, 33);
            this.btnConfirmarPedido.TabIndex = 12;
            this.btnConfirmarPedido.Text = "CONFIRMAR PEDIDO";
            this.btnConfirmarPedido.UseVisualStyleBackColor = true;
            // 
            // btnVerPedido
            // 
            this.btnVerPedido.Location = new System.Drawing.Point(718, 394);
            this.btnVerPedido.Name = "btnVerPedido";
            this.btnVerPedido.Size = new System.Drawing.Size(98, 34);
            this.btnVerPedido.TabIndex = 11;
            this.btnVerPedido.Text = "VER PEDIDO";
            this.btnVerPedido.UseVisualStyleBackColor = true;
            this.btnVerPedido.Click += new System.EventHandler(this.btnVerPedido_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(718, 297);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(154, 39);
            this.btnAgregarProducto.TabIndex = 10;
            this.btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // GroupProductoFiltro
            // 
            this.GroupProductoFiltro.Controls.Add(this.btnLimpiarFiltros);
            this.GroupProductoFiltro.Controls.Add(this.CboxFiltroMarca);
            this.GroupProductoFiltro.Controls.Add(this.label1);
            this.GroupProductoFiltro.Controls.Add(this.btnBuscarProducto);
            this.GroupProductoFiltro.Controls.Add(this.txtNombreProducto);
            this.GroupProductoFiltro.Controls.Add(this.CboxFiltroCategoria);
            this.GroupProductoFiltro.Controls.Add(this.lblFiltroMarca);
            this.GroupProductoFiltro.Controls.Add(this.lblFiltrarPorCategoria);
            this.GroupProductoFiltro.Location = new System.Drawing.Point(708, 19);
            this.GroupProductoFiltro.Name = "GroupProductoFiltro";
            this.GroupProductoFiltro.Size = new System.Drawing.Size(222, 256);
            this.GroupProductoFiltro.TabIndex = 9;
            this.GroupProductoFiltro.TabStop = false;
            this.GroupProductoFiltro.Text = "Filtro";
            // 
            // CboxFiltroMarca
            // 
            this.CboxFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxFiltroMarca.FormattingEnabled = true;
            this.CboxFiltroMarca.Location = new System.Drawing.Point(26, 89);
            this.CboxFiltroMarca.Name = "CboxFiltroMarca";
            this.CboxFiltroMarca.Size = new System.Drawing.Size(166, 21);
            this.CboxFiltroMarca.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(26, 176);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(166, 30);
            this.btnBuscarProducto.TabIndex = 1;
            this.btnBuscarProducto.Text = "BUSCAR PRODUCTO";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(26, 144);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(166, 20);
            this.txtNombreProducto.TabIndex = 7;
            // 
            // CboxFiltroCategoria
            // 
            this.CboxFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxFiltroCategoria.FormattingEnabled = true;
            this.CboxFiltroCategoria.Location = new System.Drawing.Point(26, 35);
            this.CboxFiltroCategoria.Name = "CboxFiltroCategoria";
            this.CboxFiltroCategoria.Size = new System.Drawing.Size(166, 21);
            this.CboxFiltroCategoria.TabIndex = 3;
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Location = new System.Drawing.Point(23, 73);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(37, 13);
            this.lblFiltroMarca.TabIndex = 6;
            this.lblFiltroMarca.Text = "Marca";
            // 
            // lblFiltrarPorCategoria
            // 
            this.lblFiltrarPorCategoria.AutoSize = true;
            this.lblFiltrarPorCategoria.Location = new System.Drawing.Point(23, 19);
            this.lblFiltrarPorCategoria.Name = "lblFiltrarPorCategoria";
            this.lblFiltrarPorCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblFiltrarPorCategoria.TabIndex = 5;
            this.lblFiltrarPorCategoria.Text = "Categoria";
            // 
            // gridProducts
            // 
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(6, 19);
            this.gridProducts.MultiSelect = false;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.Size = new System.Drawing.Size(691, 451);
            this.gridProducts.TabIndex = 0;
            // 
            // GroupPedido
            // 
            this.GroupPedido.Controls.Add(this.btnGenerarPedido);
            this.GroupPedido.Location = new System.Drawing.Point(12, 12);
            this.GroupPedido.Name = "GroupPedido";
            this.GroupPedido.Size = new System.Drawing.Size(261, 102);
            this.GroupPedido.TabIndex = 1;
            this.GroupPedido.TabStop = false;
            this.GroupPedido.Text = "Pedido";
            // 
            // btnGenerarPedido
            // 
            this.btnGenerarPedido.Location = new System.Drawing.Point(12, 31);
            this.btnGenerarPedido.Name = "btnGenerarPedido";
            this.btnGenerarPedido.Size = new System.Drawing.Size(237, 42);
            this.btnGenerarPedido.TabIndex = 13;
            this.btnGenerarPedido.Text = "GENERAR PEDIDO";
            this.btnGenerarPedido.UseVisualStyleBackColor = true;
            this.btnGenerarPedido.Click += new System.EventHandler(this.btnGenerarPedido_Click);
            // 
            // GroupCliente
            // 
            this.GroupCliente.Controls.Add(this.btnActualizarCliente);
            this.GroupCliente.Controls.Add(this.btnAgregarNuevoCliente);
            this.GroupCliente.Controls.Add(this.button2);
            this.GroupCliente.Controls.Add(this.lblEmailCliente);
            this.GroupCliente.Controls.Add(this.lblNombreCliente);
            this.GroupCliente.Controls.Add(this.lblApellidoCliente);
            this.GroupCliente.Controls.Add(this.lblIdNumber);
            this.GroupCliente.Controls.Add(this.btnBuscarCliente);
            this.GroupCliente.Controls.Add(this.txtEmailCliente);
            this.GroupCliente.Controls.Add(this.txtNombreCliente);
            this.GroupCliente.Controls.Add(this.txtApellidoCliente);
            this.GroupCliente.Controls.Add(this.txtBuscarPorIdNumber);
            this.GroupCliente.Enabled = false;
            this.GroupCliente.Location = new System.Drawing.Point(12, 120);
            this.GroupCliente.Name = "GroupCliente";
            this.GroupCliente.Size = new System.Drawing.Size(261, 377);
            this.GroupCliente.TabIndex = 2;
            this.GroupCliente.TabStop = false;
            this.GroupCliente.Text = "Cliente";
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.Location = new System.Drawing.Point(39, 131);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(166, 27);
            this.btnActualizarCliente.TabIndex = 20;
            this.btnActualizarCliente.Text = "ACTUALIZAR DATOS";
            this.btnActualizarCliente.UseVisualStyleBackColor = true;
            // 
            // btnAgregarNuevoCliente
            // 
            this.btnAgregarNuevoCliente.Location = new System.Drawing.Point(39, 98);
            this.btnAgregarNuevoCliente.Name = "btnAgregarNuevoCliente";
            this.btnAgregarNuevoCliente.Size = new System.Drawing.Size(166, 27);
            this.btnAgregarNuevoCliente.TabIndex = 19;
            this.btnAgregarNuevoCliente.Text = "AGREGAR NUEVO CLIENTE";
            this.btnAgregarNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "ASIGNAR CLIENTE AL PEDIDO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(36, 278);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(32, 13);
            this.lblEmailCliente.TabIndex = 18;
            this.lblEmailCliente.Text = "Email";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(36, 232);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCliente.TabIndex = 17;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(36, 183);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoCliente.TabIndex = 16;
            this.lblApellidoCliente.Text = "Apellido";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(77, 23);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(91, 13);
            this.lblIdNumber.TabIndex = 9;
            this.lblIdNumber.Text = "DNI | CUIL | CUIT";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(39, 65);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(166, 27);
            this.btnBuscarCliente.TabIndex = 15;
            this.btnBuscarCliente.Text = "BUSCAR CLIENTE";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(39, 294);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.ReadOnly = true;
            this.txtEmailCliente.Size = new System.Drawing.Size(166, 20);
            this.txtEmailCliente.TabIndex = 12;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(39, 248);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(166, 20);
            this.txtNombreCliente.TabIndex = 11;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(39, 199);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.ReadOnly = true;
            this.txtApellidoCliente.Size = new System.Drawing.Size(166, 20);
            this.txtApellidoCliente.TabIndex = 10;
            // 
            // txtBuscarPorIdNumber
            // 
            this.txtBuscarPorIdNumber.Location = new System.Drawing.Point(39, 39);
            this.txtBuscarPorIdNumber.Name = "txtBuscarPorIdNumber";
            this.txtBuscarPorIdNumber.Size = new System.Drawing.Size(166, 20);
            this.txtBuscarPorIdNumber.TabIndex = 9;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(26, 212);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(166, 30);
            this.btnLimpiarFiltros.TabIndex = 9;
            this.btnLimpiarFiltros.Text = "LIMPIAR FILTROS";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(878, 296);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(881, 316);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(39, 20);
            this.txtCantidadProducto.TabIndex = 10;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1241, 507);
            this.Controls.Add(this.GroupCliente);
            this.Controls.Add(this.GroupPedido);
            this.Controls.Add(this.GroupProducto);
            this.Name = "SaleForm";
            this.Text = "Form1";
            this.GroupProducto.ResumeLayout(false);
            this.GroupProducto.PerformLayout();
            this.GroupProductoFiltro.ResumeLayout(false);
            this.GroupProductoFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.GroupPedido.ResumeLayout(false);
            this.GroupCliente.ResumeLayout(false);
            this.GroupCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupProducto;
        private System.Windows.Forms.GroupBox GroupPedido;
        private System.Windows.Forms.GroupBox GroupCliente;
        private System.Windows.Forms.ComboBox CboxFiltroMarca;
        private System.Windows.Forms.ComboBox CboxFiltroCategoria;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Label lblFiltroMarca;
        private System.Windows.Forms.Label lblFiltrarPorCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Button btnGenerarPedido;
        private System.Windows.Forms.Button btnConfirmarPedido;
        private System.Windows.Forms.Button btnVerPedido;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.GroupBox GroupProductoFiltro;
        private System.Windows.Forms.Button btnVerStock;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtBuscarPorIdNumber;
        private System.Windows.Forms.Button btnAgregarNuevoCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Button btnActualizarCliente;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidadProducto;
    }
}

