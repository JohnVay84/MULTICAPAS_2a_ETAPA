using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Clientes
    {
        public int C_IdCliente { get; set; }
        public string C_StrNombre { get; set; }
        public long C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public DateTime C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        // Método para consultar todos los clientes
        public DataTable Consulta_Cliente()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLCLIENTES"; // sentencia SQL
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia); // ejecuta la consulta
                return dt; // retorna los datos
            }
            catch (Exception)
            {
                return null; // si hay error, retorna null
            }
        }

        // Método para consultar un cliente por su ID
        public DataTable Consulta_Cliente(int IdCliente)
        {
            string sentencia = "";
            try
            {
                sentencia = $"SELECT * FROM TBLCLIENTES WHERE IdCliente = {IdCliente}";
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Método para filtrar clientes por nombre o documento
        public DataTable Filtrar_Clientes(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLCLIENTES WHERE StrNombre LIKE '%{filtro}%' OR NumDocumento LIKE '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Método para eliminar un cliente
        public string EliminarCliente(int idCliente)
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                // Agregamos el parámetro requerido por el procedimiento almacenado
                lst.Add(new Cls_parametros("@IdCliente", C_IdCliente));

                // Ejecutamos el procedimiento almacenado
                mensaje = AccesoDatos.Ejecutar_procedimientos("Eliminar_Cliente", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Error al eliminar el cliente: " + ex.Message;
            }
            return mensaje;
        }

        // Método para insertar o actualizar un cliente
        public string ActualizarCliente()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                // Agregamos los parámetros requeridos
                lst.Add(new Cls_parametros("@IdCliente", C_IdCliente));
                lst.Add(new Cls_parametros("@StrNombre", C_StrNombre));
                lst.Add(new Cls_parametros("@NumDocumento", C_NumDocumento));
                lst.Add(new Cls_parametros("@StrDireccion", C_StrDireccion));
                lst.Add(new Cls_parametros("@StrTelefono", C_StrTelefono));
                lst.Add(new Cls_parametros("@StrEmail", C_StrEmail));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", C_StrUsuarioModifica));

                // Ejecutamos el procedimiento almacenado
                mensaje = AccesoDatos.Ejecutar_procedimientos("Actualizar_Cliente", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Error al actualizar el cliente: " + ex.Message;
            }
            return mensaje;
        }
    }
}