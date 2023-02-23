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
    public class c_cliente
    {
        public static string InsertarCliente(dgCliente Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_Nombre",Parametro.Nombre),
                    new SqlParameter("@P_Apellido_Paterno",Parametro.Apellido_Paterno),
                    new SqlParameter("@P_Apellido_Materno",Parametro.Apellido_Materno),
                    new SqlParameter("@P_Correo",Parametro.Correo),
                    new SqlParameter("@P_Telefono",Parametro.Telefono),
                    new SqlParameter("@P_Direccion",Parametro.Direccion)


                };

                tabla = bdContext.funcionStored("spCliente", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }


        public static string EliminarCliente(dgCliente Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",4),
                    new SqlParameter("@P_IdCliente",Parametro.Id_Cliente)


                };

                tabla = bdContext.funcionStored("spCliente", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static List<dgCliente> LeerCliente(int tipo, dgCliente Parametro)
        {

            List<dgCliente> lista = new List<dgCliente>();
            DataTable tabla = new DataTable();

            //5 = con descripcion
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",2)
                };

                tabla = bdContext.funcionStored("spCliente", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCliente
                             {
                                 Nombre = Convert.ToString(fila["Nombre"].ToString())



                             }
                   ).ToList();
                }


            }
            // 6 con Id_Cliente
            else if (tipo == 2)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_Nombre",Parametro.Nombre)
                };

                tabla = bdContext.funcionStored("spCliente", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCliente
                             {
                                 Id_Cliente = Convert.ToInt16(fila["Id_Cliente"].ToString())

                             }
                   ).ToList();
                }
            }






            return lista;




        }
        public static string ModificarCliente(dgCliente Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_IdCliente",Parametro.Id_Cliente),
                    new SqlParameter("@P_Nombre",Parametro.Nombre),
                    new SqlParameter("@P_Apellido_Paterno",Parametro.Apellido_Paterno),
                    new SqlParameter("@P_Apellido_Materno",Parametro.Apellido_Materno),
                    new SqlParameter("@P_Correo",Parametro.Correo),
                    new SqlParameter("@P_Telefono",Parametro.Telefono),
                    new SqlParameter("@P_Direccion",Parametro.Direccion)


                };

                tabla = bdContext.funcionStored("spCliente", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }
    }
}
