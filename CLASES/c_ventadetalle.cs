using PUNTOVENTA.Conexion;
using PUNTOVENTA.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punto_de_Venta.Clases;
using PUNTOVENTA.MENU.VENTA.PRODUCTO;

namespace PUNTOVENTA.CLASES
{
    public class c_ventadetalle
    {

        public static string InsertarVentaDetalle(dgVentaDetalle Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                    new SqlParameter("@P_IdProducto",Parametro.Id_Producto),
                    new SqlParameter("@P_CantidadAComprar",Parametro.CantidadAComprar), 
                    new SqlParameter("@P_PrecioVenta",Parametro.PrecioVenta),
                    new SqlParameter("@P_Validacion",Parametro.Validacion)


                };

                tabla = bdContext.funcionStored("spVentaDetalle", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }


      
        public static string EliminarVentaDetalleTodos(dgVentaDetalle Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",4),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta)
                  


                };

                tabla = bdContext.funcionStored("spVentaDetalle", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }


        public static string EliminarVentaDetalle(dgVentaDetalle Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",5),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                    new SqlParameter("@P_IdProducto",Parametro.Id_Producto),


                };

                tabla = bdContext.funcionStored("spVentaDetalle", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }
        public static List<dgVentaDetalle> LeerVentaDetalle(int tipo, dgVentaDetalle Parametro)
        {

            List<dgVentaDetalle> lista = new List<dgVentaDetalle>();
            DataTable tabla = new DataTable();

            //2= saber cual fue la ultima idventa y traerla + 1
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",2)
                };

                tabla = bdContext.funcionStored("spVentaDetalle", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    try
                    {
                        lista = (from DataRow fila in tabla.Rows
                                 select new dgVentaDetalle
                                 {

                                     Id_Venta = Convert.ToInt16(fila["Id_Venta_Proxima"].ToString())
                                 }
                        ).ToList();
                    }

                    catch
                    {
                        lista = (from DataRow fila in tabla.Rows
                                 select new dgVentaDetalle
                                 {

                                     Id_Venta = 1
                                 }
                        ).ToList();
                    }
                   
                }


            }

            else if (tipo == 2) // mostrar la orden
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta)

                };

                tabla = bdContext.funcionStored("spVentaDetalle", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    try
                    {
                        lista = (from DataRow fila in tabla.Rows
                                 select new dgVentaDetalle
                                 {
                                     Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                     Id_Producto = Convert.ToString(fila["Id_Producto"].ToString()),
                                     CantidadAComprar = Convert.ToInt16(fila["Cantidad"].ToString()),
                                     PrecioVenta = float.Parse(fila["Precio"].ToString()),
                                     Nombre = Convert.ToString(fila["Nombre"].ToString())
                                    
                                 }
                        ).ToList();
                    }

                    catch
                    {
                        lista = (from DataRow fila in tabla.Rows
                                 select new dgVentaDetalle
                                 {
                                     Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                     Id_Producto = Convert.ToString(fila["Id_Producto"].ToString()),
                                     CantidadAComprar = Convert.ToInt16(fila["Cantidad"].ToString()),
                                     PrecioVenta = float.Parse(fila["Precio"].ToString()),
                                     


                                 }
                        ).ToList();
                    }

                }


            }




            return lista;




        }


      
    }
}
