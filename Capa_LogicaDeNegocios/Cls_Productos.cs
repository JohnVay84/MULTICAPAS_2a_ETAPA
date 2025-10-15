using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class CLS_Productos
    {
        // Propiedades que corresponden a las columnas de la tabla TBLPRODUCTO
        public int C_IdProducto { get; set; }
        public string C_StrNombre { get; set; }
        public string C_StrCodigo { get; set; }
        public decimal C_NumPrecioCompra { get; set; }
        public decimal C_NumPrecioVenta { get; set; }
        public int C_IdCategoria { get; set; }
        public string C_StrDetalle { get; set; }
        public string C_StrFoto { get; set; }
        public int C_NumStock { get; set; }
        public DateTime C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        // Instancia del acceso a datos
        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public DataTable ConsultarProductoPorId(int idProducto)
        {
            string consulta = $"EXEC SpConsultarProductoPorId {idProducto}";
            return AccesoDatos.EjecutarConsulta(consulta);
        }

        public string ActualizarProducto()
        {
            try
            {
                // Lista de parámetros para el procedimiento almacenado
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdProducto", C_IdProducto));
                lst.Add(new Cls_parametros("@StrNombre", C_StrNombre));
                lst.Add(new Cls_parametros("@StrCodigo", C_StrCodigo));
                lst.Add(new Cls_parametros("@NumPrecioCompra", C_NumPrecioCompra));
                lst.Add(new Cls_parametros("@NumPrecioVenta", C_NumPrecioVenta));
                lst.Add(new Cls_parametros("@IdCategoria", C_IdCategoria));
                lst.Add(new Cls_parametros("@StrDetalle", C_StrDetalle));
                lst.Add(new Cls_parametros("@StrFoto", C_StrFoto));
                lst.Add(new Cls_parametros("@NumStock", C_NumStock));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", C_StrUsuarioModifica));

                // Ejecutar el procedimiento
                return AccesoDatos.Ejecutar_procedimientos("actualizar_Producto", lst);
            }
            catch (Exception ex)
            {
                return "Error al actualizar el producto: " + ex.Message;
            }
        }

        // Eliminar producto
        public string EliminarProducto()
        {
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdProducto", C_IdProducto));

                return AccesoDatos.Ejecutar_procedimientos("Eliminar_Producto", lst);
            }
            catch (Exception ex)
            {
                return "Error al eliminar el producto: " + ex.Message;
            }
        }

        // Consultar todos los productos
        public DataTable ConsultarProducto()
        {
            try
            {
                string consulta = "SELECT * FROM TBLPRODUCTO";
                return AccesoDatos.EjecutarConsulta(consulta);
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Filtrar productos por nombre o código
        public DataTable FiltrarProducto(string filtro)
        {
            try
            {
                string consulta = $"SELECT * FROM TBLPRODUCTO WHERE StrNombre LIKE '%{filtro}%' OR StrCodigo LIKE '%{filtro}%'";
                return AccesoDatos.EjecutarConsulta(consulta);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}