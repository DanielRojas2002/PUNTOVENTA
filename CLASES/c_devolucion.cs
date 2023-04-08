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

        public static string Devolucion(dgDevolucion Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                    new SqlParameter("@P_IdProducto",Parametro.IdProducto),
                    new SqlParameter("@P_Cantidad",Parametro.Cantidad),
                    new SqlParameter("@P_Id_Usuario",Parametro.IdUsuario),
                    new SqlParameter("@P_Stock",Parametro.Stock),
                    new SqlParameter("@P_Precio",Parametro.PrecioVenta),
                    new SqlParameter("@P_CantidadDevolucion",Parametro.CantidadDevolucion),
                    new SqlParameter("@P_FechaEntrada",Parametro.FechaEntrada)
            



                };

                tabla = bdContext.funcionStored("spDevoluciones", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static string Rebaje(dgDevolucion Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",6),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                    new SqlParameter("@P_CantidadPagada",Parametro.CantidadDevolucion),
                    new SqlParameter("@P_FechaPago",Parametro.FechaEntrada)




                };

                tabla = bdContext.funcionStored("spDevoluciones", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

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

            if (tipo == 11)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",11),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                    new SqlParameter("@P_IdProducto",Parametro.IdProducto)
                };

                tabla = bdContext.funcionStored("spDevoluciones", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgDevolucion
                             {
                                 
                                 CantidadProducto = Convert.ToInt16(fila["CantidadDevuelta"].ToString()),
                                 CantidadDevolucion = float.Parse(fila["SubTotalDevuelto"].ToString())
                                 



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

            else if (tipo == 4)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",4),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                  
                };

                tabla = bdContext.funcionStored("spDevoluciones", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgDevolucion
                             {
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                
                                 CantidadProducto = Convert.ToInt16(fila["Cantidad"].ToString()),
                                 PrecioProducto = float.Parse(fila["Precio"].ToString()),
                                 SubTotalProducto = float.Parse(fila["SubTotalProducto"].ToString()),




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

                tabla = bdContext.funcionStored("spDevoluciones", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgDevolucion
                             {
                               
                                 CantidadPagada = float.Parse(fila["CantidadPagada"].ToString())
                                 




                             }
                   ).ToList();
                }


            }



            return lista;




        }
    }
}
