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
                                 Direccion = Convert.ToString(fila["Direccion"].ToString()),
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
                                 Id_Producto = Convert.ToInt16(fila["IdProducto"].ToString()),
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

          





            return lista;




        }
    }
}
