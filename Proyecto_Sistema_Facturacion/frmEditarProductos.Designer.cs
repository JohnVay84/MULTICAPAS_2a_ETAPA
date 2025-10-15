namespace Proyecto_Sistema_Facturacion
{
    partial class frmEditarProductos
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
            this.lblAdminProductos = new MaterialSkin.Controls.MaterialLabel();
            this.IdProducto = new System.Windows.Forms.TextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.txtDetallesProducto = new MaterialSkin.Controls.MaterialLabel();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdminProductos
            // 
            this.lblAdminProductos.AutoSize = true;
            this.lblAdminProductos.Depth = 0;
            this.lblAdminProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminProductos.Location = new System.Drawing.Point(245, 44);
            this.lblAdminProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminProductos.Name = "lblAdminProductos";
            this.lblAdminProductos.Size = new System.Drawing.Size(306, 24);
            this.lblAdminProductos.TabIndex = 0;
            this.lblAdminProductos.Text = "ADMINISTRACION DE PRODUCTOS";
            // 
            // IdProducto
            // 
            this.IdProducto.Location = new System.Drawing.Point(67, 112);
            this.IdProducto.Margin = new System.Windows.Forms.Padding(4);
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Size = new System.Drawing.Size(53, 22);
            this.IdProducto.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre Producto";
            this.txtNombre.Location = new System.Drawing.Point(67, 23);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(333, 28);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TabStop = false;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDetalles);
            this.panel1.Controls.Add(this.txtDetallesProducto);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.cboCategoria);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.txtPrecioVenta);
            this.panel1.Controls.Add(this.txtPrecioCompra);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(26, 142);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 289);
            this.panel1.TabIndex = 3;
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(427, 191);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(350, 69);
            this.txtDetalles.TabIndex = 5;
            // 
            // txtDetallesProducto
            // 
            this.txtDetallesProducto.AutoSize = true;
            this.txtDetallesProducto.Depth = 0;
            this.txtDetallesProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtDetallesProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDetallesProducto.Location = new System.Drawing.Point(423, 143);
            this.txtDetallesProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDetallesProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDetallesProducto.Name = "txtDetallesProducto";
            this.txtDetallesProducto.Size = new System.Drawing.Size(150, 24);
            this.txtDetallesProducto.TabIndex = 4;
            this.txtDetallesProducto.Text = "Detalle Producto";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(423, 23);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(91, 24);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(530, 23);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(260, 24);
            this.cboCategoria.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Depth = 0;
            this.txtStock.Hint = "Cantidad Stock";
            this.txtStock.Location = new System.Drawing.Point(67, 223);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.MaxLength = 32767;
            this.txtStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.Size = new System.Drawing.Size(236, 28);
            this.txtStock.TabIndex = 2;
            this.txtStock.TabStop = false;
            this.txtStock.UseSystemPasswordChar = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Hint = "Precio Venta";
            this.txtPrecioVenta.Location = new System.Drawing.Point(67, 174);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.MaxLength = 32767;
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.SelectionLength = 0;
            this.txtPrecioVenta.SelectionStart = 0;
            this.txtPrecioVenta.Size = new System.Drawing.Size(236, 28);
            this.txtPrecioVenta.TabIndex = 2;
            this.txtPrecioVenta.TabStop = false;
            this.txtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Hint = "Precio Compra";
            this.txtPrecioCompra.Location = new System.Drawing.Point(67, 124);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCompra.MaxLength = 32767;
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.SelectionLength = 0;
            this.txtPrecioCompra.SelectionStart = 0;
            this.txtPrecioCompra.Size = new System.Drawing.Size(236, 28);
            this.txtPrecioCompra.TabIndex = 2;
            this.txtPrecioCompra.TabStop = false;
            this.txtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "Código Referencia";
            this.txtCodigo.Location = new System.Drawing.Point(67, 74);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(236, 28);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Location = new System.Drawing.Point(26, 460);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 106);
            this.panel2.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(633, 27);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(69, 36);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(123, 27);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // frmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IdProducto);
            this.Controls.Add(this.lblAdminProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEditarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarProductos";
            this.Load += new System.EventHandler(this.formProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblAdminProductos;
        private System.Windows.Forms.TextBox IdProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private MaterialSkin.Controls.MaterialLabel txtDetallesProducto;
        private System.Windows.Forms.TextBox txtDetalles;
    }
}