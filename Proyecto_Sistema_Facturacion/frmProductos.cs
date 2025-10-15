using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Capa_LogicaDeNegocios;


namespace Proyecto_Sistema_Facturacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            llenar_grid();  
        }

        private void llenar_grid()
        {
            
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarProductos editarProducto = new frmEditarProductos();
            editarProducto.ShowDialog();
        }
    }
}
