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
    public class c_ticket
    {

        public static List<dgTicket> Ticket(int tipo, dgTicket Parametro)
        {

            List<dgTicket> lista = new List<dgTicket>();
            DataTable tabla = new DataTable();

            if (tipo == 0) // Ticket Efectivo
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",11)
                     
                };

                tabla = bdContext.funcionStored("spTicket", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgTicket
                             {
                                


                                 NombreEmpresa = Convert.ToString(fila["NombreEmpresa"].ToString()),
                                 Colonia = Convert.ToString(fila["Colonia"].ToString()),
                                 Calle = Convert.ToString(fila["Calle"].ToString()),
                                 Telefono = Convert.ToString(fila["Telefono"].ToString()),
                                 Mensaje = Convert.ToString(fila["Mensaje"].ToString())






                             }
                   ).ToList();
                }


            }

            else if (tipo == 1) // Ticket Efectivo
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",1),
                     new SqlParameter("@P_IdVenta",Parametro.Id_Venta)
                };

                tabla = bdContext.funcionStored("spTicket", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgTicket
                             {
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 Id_Producto = Convert.ToString(fila["IdProducto"].ToString()),
                                 Usuario = Convert.ToString(fila["UsuarioVenta"].ToString()),



                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),

                                 CantidadComprada = Convert.ToInt16(fila["CantidadProducto"].ToString()),

                                 PrecioComprado = float.Parse(fila["PrecioProducto"].ToString()),

                                 SubTotal = float.Parse(fila["SubTotalProducto"].ToString()),

                                 Total = float.Parse(fila["TotalVenta"].ToString()),

                                 Cambio = float.Parse(fila["CambioVenta"].ToString()),

                                 FechaVenta = Convert.ToDateTime(fila["FechaVentaProducto"].ToString())




                             }
                   ).ToList();
                }


            }


            else if (tipo == 3) // Ticket Caja
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_FechaVenta",Parametro.FechaVenta)
                };

                tabla = bdContext.funcionStored("spTicket", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgTicket
                             {
                                
                                 Id_Producto = Convert.ToString(fila["Id_Producto"].ToString()),
                                
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),

                                 CantidadComprada = Convert.ToInt16(fila["CantidadVendida"].ToString()),

                                 PrecioComprado = float.Parse(fila["PrecioProducto"].ToString()),
                                 
                                

                                 DescripcionTipoVenta = Convert.ToString(fila["DescripcionTipoVenta"].ToString()),

                             }
                   ).ToList();
                }


            }


            else if (tipo == 4) // Ticket Caja creditos
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",4),
                     new SqlParameter("@P_FechaVenta",Parametro.FechaVenta)
                };

                tabla = bdContext.funcionStored("spTicket", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgTicket
                             {
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                               
                                 Nombre= Convert.ToString(fila["Nombre"].ToString()),

                                 Apellido_Materno = Convert.ToString(fila["Apellido_Materno"].ToString()),


                                 Apellido_Paterno = Convert.ToString(fila["Apellido_Paterno"].ToString()),

                                 SubTotal = float.Parse(fila["CantidadPagada"].ToString()),

                              
                                 Usuario = Convert.ToString(fila["Usuario"].ToString()),

                                 DescripcionTipoVenta = Convert.ToString(fila["DescripcionTipoVenta"].ToString()),







                             }
                   ).ToList();
                }


            }

            else if (tipo == 5) // Ticket Caja DEVOLUCION
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",5),
                    new SqlParameter("@P_FechaVenta",Parametro.FechaVenta)
                };

                tabla = bdContext.funcionStored("spTicket", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgTicket
                             {

                                 Id_Producto = Convert.ToString(fila["Id_Producto"].ToString()),

                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),

                                 CantidadComprada = Convert.ToInt16(fila["CantidadDevolucion"].ToString()),

                                 PrecioComprado = float.Parse(fila["PrecioProducto"].ToString()),



                                 DescripcionTipoVenta = Convert.ToString(fila["DescripcionTipoVenta"].ToString()),

                             }
                   ).ToList();
                }


            }









            return lista;




        }
    }
}
