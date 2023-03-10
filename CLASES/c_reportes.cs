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
                    new SqlParameter("@P_FechaFinal",Parametro.FechaFinal),

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
                                 Usuario = Convert.ToString(fila["Usuario"].ToString()),
                                 DescripcionTipoVenta = Convert.ToString(fila["DescripcionTipoVenta"].ToString())


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

                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 Apellido_Paterno = Convert.ToString(fila["Apellido_Paterno"].ToString()),
                                 Apellido_Materno = Convert.ToString(fila["Apellido_Materno"].ToString()),
                                
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 CantidadPagada = float.Parse(fila["CantidadPagada"].ToString()),
                                 Total = float.Parse(fila["Total"].ToString()),

                                 DescripcionEstatus= Convert.ToString(fila["Descripcion"].ToString()),

                                 Usuario = Convert.ToString(fila["Usuario"].ToString())


                             }
                   ).ToList();
                }

            }


            else if (tipo == 6)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",11),
                    new SqlParameter("@P_FechaInicio",Parametro.FechaInicio),
                    new SqlParameter("@P_FechaFinal",Parametro.FechaFinal),

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
                                 Usuario = Convert.ToString(fila["Usuario"].ToString()),
                                 DescripcionTipoVenta = Convert.ToString(fila["DescripcionTipoVenta"].ToString()),
                                 CantidadPagada = float.Parse(fila["CantidadPagada"].ToString())

                             }
                   ).ToList();
                }

            }

            else if (tipo == 8)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",111),
                    new SqlParameter("@P_FechaInicio",Parametro.FechaInicio),
                    new SqlParameter("@P_FechaFinal",Parametro.FechaFinal),

                };

                tabla = bdContext.funcionStored("spReportes", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgReportes
                             {
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),

                                 FechaVentaProducto = Convert.ToDateTime(fila["FechaVentaProducto"].ToString()),
                                 Usuario = Convert.ToString(fila["Usuario"].ToString()),
                                 DescripcionTipoVenta = Convert.ToString(fila["DescripcionTipoVenta"].ToString()),
                                 CantidadPagada = float.Parse(fila["CantidadPagada"].ToString())

                             }
                   ).ToList();
                }

            }

            return lista;
        }
    }
}
