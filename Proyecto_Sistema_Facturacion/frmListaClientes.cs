using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Proyecto_Sistema_Facturacion
{
    public partial class frmListaClientes : Form
    {
        public Cls_Clientes objCliente = new Cls_Clientes();

        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void llenar_grid()
        {
            try
            {
                dgClientes.Rows.Clear();
                DataTable dt = objCliente.Consulta_Cliente();

                foreach (DataRow fila in dt.Rows)
                {
                    dgClientes.Rows.Add(
                        fila["IdCliente"],
                        fila["StrNombre"],
                        fila["NumDocumento"],
                        fila["StrTelefono"],
                        fila["StrEmail"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = materialSingleLineTextField1.Text.Trim();
                dgClientes.Rows.Clear();
                DataTable dt;

                if (string.IsNullOrEmpty(criterio))
                {
                    dt = objCliente.Consulta_Cliente();
                }
                else
                {
                    dt = objCliente.Filtrar_Clientes(criterio);
                }

                foreach (DataRow fila in dt.Rows)
                {
                    dgClientes.Rows.Add(
                        fila["IdCliente"],
                        fila["StrNombre"],
                        fila["NumDocumento"],
                        fila["StrTelefono"],
                        fila["StrEmail"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCliente cliente = new frmEditarCliente();
            cliente.ShowDialog();
            llenar_grid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0) return;

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int idCliente = Convert.ToInt32(dgClientes.Rows[e.RowIndex].Cells["IdCliente"].Value);
                if (MessageBox.Show("¿Seguro de borrar este cliente?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string resultado = objCliente.EliminarCliente(idCliente);
                    MessageBox.Show(resultado);
                    llenar_grid();
                }
            }

            //  EDITAR CLIENTE
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgClientes.CurrentRow.Index;
                // Abrimos el formulario de edición (asegúrate de que frmEditarCliente existe y está referenciado)
                frmEditarCliente cliente = new frmEditarCliente();

                //cliente.IdClienteValue = int.Parse(dgClientes[0, posActual].Value.ToString());
                cliente.ShowDialog();
                
                if (int.TryParse(dgClientes.Rows[posActual].Cells[0].Value?.ToString(), out int idCliente))
                {
                    cliente.IdCliente = idCliente;
                }
                else
                {
                    MessageBox.Show("Invalid client ID format.");
                    //}
                    //cliente.IdCliente = Convert.ToInt32(dgClientes.Rows[posActual].Cells[0].Value);
                    //cliente.ShowDialog();
                    llenar_grid(); // Actualizamos la lista después de editar
                                   //return;
                }

                // Siempre actualiza el grid después de cualquier acción
                llenar_grid();


            }
        }
    }
}
