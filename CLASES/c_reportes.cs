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
    public class c_reportes
    {
        public static List<dgReportes> LeerReporte(int tipo, dgReportes Parametro)
        {

            List<dgReportes> lista = new List<dgReportes>();
            DataTable tabla = new DataTable();

            //5 = con descripcion
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",1),
                new SqlParameter("@P_FechaInicio",Parametro.FechaInicio),
                new SqlParameter("@P_FechaFinal",Parametro.FechaFinal)
                };

                tabla = bdContext.funcionStored("spReportes", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgReportes
                             {
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 IdProducto = Convert.ToInt16(fila["IdProducto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["CantidadProducto"].ToString()),
                                 PrecioProducto = float.Parse(fila["PrecioProducto"].ToString()),
                                 SubTotalProducto = float.Parse(fila["SubTotalProducto"].ToString()),
                                 FechaVentaProducto = Convert.ToDateTime(fila["FechaVentaProducto"].ToString()),
                                 Usuario = Convert.ToString(fila["Usuario"].ToString())


                             }
                   ).ToList();
                }

            }

            

            //6 = con descripcion
            else if (tipo == 2)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",2),
                    new SqlParameter("@P_FechaInicio",Parametro.FechaInicio),
                    new SqlParameter("@P_FechaFinal",Parametro.FechaFinal),
                    new SqlParameter("@P_Id_Categoria",Parametro.IdCategoria),
                    new SqlParameter("@P_Id_Producto",Parametro.IdProducto)
                };

                tabla = bdContext.funcionStored("spReportes", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgReportes
                             {
                                 IdEntrada = Convert.ToInt16(fila["Id_Entrada"].ToString()),
                                 IdProducto = Convert.ToInt16(fila["Id_Producto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["Nombre"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["Cantidad"].ToString()),
                                 FechaEntrada = Convert.ToDateTime(fila["FechaEntrada"].ToString()),
                                 Categoria = Convert.ToString(fila["Categoria"].ToString()),
                                 Usuario = Convert.ToString(fila["Usuario"].ToString())



                             }
                   ).ToList();
                }

            }

            else if (tipo == 3)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",3),
                new SqlParameter("@P_IdCliente",Parametro.IdCliente),

                };

                tabla = bdContext.funcionStored("spReportes", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgReportes
                             {
                                 IdCliente = Convert.ToInt16(fila["Id_Cliente"].ToString()),
                                 PrecioCompra = Convert.ToInt16(fila["IdProducto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["CantidadProducto"].ToString()),
                                 
                                 PrecioVenta = float.Parse(fila["PrecioVentaProducto"].ToString()),
                                 SubTotalProducto = float.Parse(fila["SubTotalProducto"].ToString()),
                                 FechaCompraProducto = Convert.ToDateTime(fila["FechaCompraProducto"].ToString()),
                                 Usuario = Convert.ToString(fila["Usuario"].ToString())


                             }
                   ).ToList();
                }

            }

            return lista;
        }
    }
}
