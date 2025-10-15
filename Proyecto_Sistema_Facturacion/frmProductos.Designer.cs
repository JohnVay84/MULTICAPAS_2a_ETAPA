namespace Proyecto_Sistema_Facturacion
{
    partial class frmProductos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.StrNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtmFechaModifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrUsuarioModifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(311, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(464, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRACIÓN PRODUCTOS";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar Producto";
            this.txtBuscar.Location = new System.Drawing.Point(71, 103);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(264, 28);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(449, 95);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(88, 36);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(88, 497);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(78, 36);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(600, 497);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(69, 36);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StrNombre,
            this.strCodigo,
            this.NumPrecioCompra,
            this.NumPrecioVenta,
            this.IdCategoria,
            this.StrDetalle,
            this.NumStock,
            this.DtmFechaModifica,
            this.StrUsuarioModifica,
            this.btnEditar,
            this.btnBorrar});
            this.dgProductos.Location = new System.Drawing.Point(42, 172);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersWidth = 51;
            this.dgProductos.RowTemplate.Height = 24;
            this.dgProductos.Size = new System.Drawing.Size(804, 298);
            this.dgProductos.TabIndex = 3;
            // 
            // StrNombre
            // 
            this.StrNombre.HeaderText = "PRODUCTO";
            this.StrNombre.MinimumWidth = 6;
            this.StrNombre.Name = "StrNombre";
            this.StrNombre.Width = 125;
            // 
            // strCodigo
            // 
            this.strCodigo.HeaderText = "CODIGO REF";
            this.strCodigo.MinimumWidth = 6;
            this.strCodigo.Name = "strCodigo";
            this.strCodigo.Width = 125;
            // 
            // NumPrecioCompra
            // 
            this.NumPrecioCompra.HeaderText = "PRECIO COMPRA";
            this.NumPrecioCompra.MinimumWidth = 6;
            this.NumPrecioCompra.Name = "NumPrecioCompra";
            this.NumPrecioCompra.Width = 125;
            // 
            // NumPrecioVenta
            // 
            this.NumPrecioVenta.HeaderText = "PRECIO VENTA";
            this.NumPrecioVenta.MinimumWidth = 6;
            this.NumPrecioVenta.Name = "NumPrecioVenta";
            this.NumPrecioVenta.Width = 125;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "CATEGORIA";
            this.IdCategoria.MinimumWidth = 6;
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.Width = 125;
            // 
            // StrDetalle
            // 
            this.StrDetalle.HeaderText = "DETALLE";
            this.StrDetalle.MinimumWidth = 6;
            this.StrDetalle.Name = "StrDetalle";
            this.StrDetalle.Width = 125;
            // 
            // NumStock
            // 
            this.NumStock.HeaderText = "STOCK";
            this.NumStock.MinimumWidth = 6;
            this.NumStock.Name = "NumStock";
            this.NumStock.Width = 125;
            // 
            // DtmFechaModifica
            // 
            this.DtmFechaModifica.HeaderText = "Fecha Modificacion";
            this.DtmFechaModifica.MinimumWidth = 6;
            this.DtmFechaModifica.Name = "DtmFechaModifica";
            this.DtmFechaModifica.Visible = false;
            this.DtmFechaModifica.Width = 125;
            // 
            // StrUsuarioModifica
            // 
            this.StrUsuarioModifica.HeaderText = "USUARIO MODIFICA";
            this.StrUsuarioModifica.MinimumWidth = 6;
            this.StrUsuarioModifica.Name = "StrUsuarioModifica";
            this.StrUsuarioModifica.Visible = false;
            this.StrUsuarioModifica.Width = 125;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.MinimumWidth = 6;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 125;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.MinimumWidth = 6;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 125;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 559);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtmFechaModifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrUsuarioModifica;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}