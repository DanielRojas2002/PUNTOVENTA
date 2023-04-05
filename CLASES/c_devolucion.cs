using PUNTOVENTA.Conexion;
using PUNTOVENTA.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.CLASES
{
    public class c_devolucion
    {
        public static List<dgDevolucion> LeerDevolucion(int tipo, dgDevolucion Parametro)
        {

            List<dgDevolucion> lista = new List<dgDevolucion>();
            DataTable tabla = new DataTable();

            //5 = con descripcion
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta)
                };

                tabla = bdContext.funcionStored("spDevoluciones", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgDevolucion
                             {
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 IdProducto = Convert.ToInt16(fila["IdProducto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["CantidadProducto"].ToString()),
                                 PrecioProducto = float.Parse(fila["PrecioProducto"].ToString()),
                                 SubTotalProducto = float.Parse(fila["SubTotalProducto"].ToString()),
                                 FechaVentaProducto = Convert.ToDateTime(fila["FechaVentaProducto"].ToString()),
                                 Usuario = Convert.ToString(fila["Usuario"].ToString()),
                                 DescripcionTipoVenta = Convert.ToString(fila["DescripcionTipoVenta"].ToString())



                             }
                   ).ToList();
                }


            }

            else if (tipo == 2)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",2),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                    new SqlParameter("@P_IdProducto",Parametro.IdProducto)
                };

                tabla = bdContext.funcionStored("spDevoluciones", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgDevolucion
                             {
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 IdProducto = Convert.ToInt16(fila["IdProducto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["CantidadProducto"].ToString()),
                                 PrecioProducto = float.Parse(fila["PrecioProducto"].ToString()),
                                 SubTotalProducto = float.Parse(fila["SubTotalProducto"].ToString()),
                                



                             }
                   ).ToList();
                }


            }



            return lista;




        }
    }
}
