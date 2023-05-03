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
                                 IdProducto = Convert.ToString  (fila["IdProducto"].ToString()),
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
                                 IdProducto = Convert.ToString(fila["Id_Producto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["Nombre"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["Cantidad"].ToString()),
                                 FechaEntrada = Convert.ToDateTime(fila["FechaEntrada"].ToString()),
                                 Categoria = Convert.ToString(fila["Categoria"].ToString()),
                                 Usuario = Convert.ToString(fila["Usuario"].ToString()),
                                 TipoEntrada= Convert.ToString(fila["TipoEntrada"].ToString())



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

                                 DescripcionEstatus = Convert.ToString(fila["Descripcion"].ToString()),

                                 Usuario = Convert.ToString(fila["Usuario"].ToString()),

                                 FechaVentaProducto = Convert.ToDateTime(fila["FechaVenta"].ToString())


                             }
                   ).ToList();
                }

            }

            else if (tipo == 4)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",4),
                new SqlParameter("@P_FechaCaja",Parametro.FechaCaja),

                };

                tabla = bdContext.funcionStored("spReportes", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgReportes
                             {
                                 IdCaja = Convert.ToInt16(fila["Id_Caja"].ToString()),

                                 CantidadAbonada = float.Parse(fila["CantidadAbonada"].ToString()),
                                 CantidadVenta = float.Parse(fila["CantidadVenta"].ToString()),
                                 CantidadRetirada = float.Parse(fila["CantidadRetirada"].ToString()),
                                 CantidadTotal = float.Parse(fila["CantidadTotal"].ToString()),
                                 CantidadDevolucion = float.Parse(fila["CantidadDevolucion"].ToString()),
                                 DescripcionCaja = Convert.ToString(fila["DescripcionCaja"].ToString()),


                                 FechaCaja = Convert.ToDateTime(fila["FechaCaja"].ToString())


                             }
                   ).ToList();
                }

            }

            else if (tipo == 44)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",6),
                new SqlParameter("@P_FechaInicio",Parametro.FechaInicio),

                };

                tabla = bdContext.funcionStored("spReportes", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgReportes
                             {
                                 IdDevolucion= Convert.ToInt16(fila["Id_Devolucion"].ToString()),

                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),

                                 CantidadPagada = float.Parse(fila["Cantidad"].ToString()),

                                 PrecioVenta = float.Parse(fila["Precio"].ToString()),

                                 SubTotalProducto = float.Parse(fila["SubTotalProducto"].ToString()),

                                 Usuario = Convert.ToString(fila["Usuario"].ToString()),
                              

                                 FechaInicio = Convert.ToDateTime(fila["FechaDevolucion"].ToString())


                             }
                   ).ToList();
                }

            }

            else if (tipo == 5)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",5),
                new SqlParameter("@P_IdVenta",Parametro.Id_Venta),

                };

                tabla = bdContext.funcionStored("spReportes", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgReportes
                             {
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 IdProducto = Convert.ToString(fila["IdProducto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["CantidadProducto"].ToString()),
                                 PrecioProducto = float.Parse(fila["PrecioProducto"].ToString()),
                                 SubTotalProducto = float.Parse(fila["SubTotalProducto"].ToString()),
                                 FechaVentaProducto = Convert.ToDateTime(fila["FechaVentaProducto"].ToString()),
                                
                                 DescripcionTipoVenta = Convert.ToString(fila["DescripcionTipoVenta"].ToString())


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
                                 IdProducto = Convert.ToString(fila["IdProducto"].ToString()),
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
                               
                                 CantidadPagada = float.Parse(fila["CantidadPagada"].ToString())

                             }
                   ).ToList();
                }

            }

            else if (tipo == 9)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",12),
                    new SqlParameter("@P_FechaInicio",Parametro.FechaInicio),
                    new SqlParameter("@P_FechaFinal",Parametro.FechaFinal),

                };

                tabla = bdContext.funcionStored("spReportes", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgReportes
                             {
                                 Id_Devolucion = Convert.ToInt16(fila["Id_Devolucion"].ToString()),
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 IdProducto = Convert.ToString(fila["Id_Producto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["Cantidad"].ToString()),
                                 PrecioProducto = float.Parse(fila["Precio"].ToString()),
                                 SubTotalProducto = float.Parse(fila["SubTotalProducto"].ToString()),
                                 FechaDevolucion = Convert.ToDateTime(fila["FechaDevolucion"].ToString()),

                                 Usuario = Convert.ToString(fila["Usuario"].ToString())


                             }
                   ).ToList();
                }

            }

            else if (tipo == 10)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",13),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                  

                };

                tabla = bdContext.funcionStored("spReportes", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgReportes
                             {
                                 IdPago = Convert.ToInt16(fila["Id_Pago"].ToString()),
                                 IdCliente = Convert.ToInt16(fila["Id_Cliente"].ToString()),
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 NombreCliente = Convert.ToString(fila["NombreCliente"].ToString()),
                                 DescripcionAbono = Convert.ToString(fila["DescripcionAbono"].ToString()),
                                 CantidadPagada = float.Parse(fila["CantidadPagada"].ToString()),                             
                                 FechaPago = Convert.ToDateTime(fila["FechaPago"].ToString()),

                                 


                             }
                   ).ToList();
                }

            }

            else if (tipo == 11)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",14),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),


                };

                tabla = bdContext.funcionStored("spReportes", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgReportes
                             {
                                 Total = float.Parse(fila["Total"].ToString())
                               



                             }
                   ).ToList();
                }

            }

            return lista;
        }
    }
}
