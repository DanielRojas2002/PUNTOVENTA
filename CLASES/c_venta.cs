using PUNTOVENTA.Conexion;
using PUNTOVENTA.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.CLASES
{
    public class c_venta
    {

        public static string InsertarVentaEfectivo(dgVenta Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                    new SqlParameter("@P_IdUsuario",Parametro.Id_Usuario),
                    new SqlParameter("@P_Total",Parametro.Total),
                    new SqlParameter("@P_Cambio",Parametro.Cambio),
                    new SqlParameter("@P_FechaVenta",Parametro.FechaVenta),
                    


                };

                tabla = bdContext.funcionStored("spVenta", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static string InsertarVentaTransferencia(dgVenta Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",4),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                    new SqlParameter("@P_IdUsuario",Parametro.Id_Usuario),
                    new SqlParameter("@P_Total",Parametro.Total),
                    new SqlParameter("@P_Cambio",Parametro.Cambio),
                    new SqlParameter("@P_FechaVenta",Parametro.FechaVenta),
                    new SqlParameter("@P_NombreTransferencia",Parametro.NombreTransferencia)



                };

                tabla = bdContext.funcionStored("spVenta", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }


        public static string InsertarVentaCredito(dgVenta Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",5),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                    new SqlParameter("@P_IdUsuario",Parametro.Id_Usuario),
                    new SqlParameter("@P_IdCliente",Parametro.Id_Cliente),
                    new SqlParameter("@P_Total",Parametro.Total),
                    new SqlParameter("@P_Cambio",Parametro.Cambio),
                    new SqlParameter("@P_FechaVenta",Parametro.FechaVenta)




                };

                tabla = bdContext.funcionStored("spVenta", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static string ReducirStockProductos(dgVenta Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_IdProducto",Parametro.Id_Producto),
                    new SqlParameter("@P_Stock",Parametro.Stock)




                };

                tabla = bdContext.funcionStored("spVenta", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }




        public static List<dgVenta> LeerVenta(int tipo, dgVenta Parametro)
        {

            List<dgVenta> lista = new List<dgVenta>();
            DataTable tabla = new DataTable();

            //5 = con descripcion
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",2),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta)
                };

                tabla = bdContext.funcionStored("spVenta", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgVenta
                             {
                                 Id_Producto = Convert.ToString(fila["Id_Producto"].ToString()),
                                 Stock = Convert.ToInt16(fila["Cantidad"].ToString())



                             }
                   ).ToList();
                }


            }

           










            return lista;




        }
    }
}
