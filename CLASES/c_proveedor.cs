using PUNTOVENTA.Conexion;
using PUNTOVENTA.ENTIDAD;
using System.Data.SqlClient;
using System.Data;

namespace PUNTOVENTA.CLASES
{
    public class c_proveedor
    {

        public static string InsertarProveedor(dgProveedor Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_Nombre",Parametro.Nombre),
                    new SqlParameter("@P_Correo",Parametro.Correo),
                    new SqlParameter("@P_Telefono",Parametro.Telefono),
                    new SqlParameter("@P_FechaEntrada",Parametro.FechaEntrada)


                };

                tabla = bdContext.funcionStored("spProveedor", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }


        public static string ModificarProveedor(dgProveedor Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_IdProveedor",Parametro.Id_Proveedor),
                    new SqlParameter("@P_Nombre",Parametro.Nombre),
                    new SqlParameter("@P_Correo",Parametro.Correo),
                    new SqlParameter("@P_Telefono",Parametro.Telefono),
                    new SqlParameter("@P_FechaModificacion",Parametro.FechaModificacion)


                };

                tabla = bdContext.funcionStored("spProveedor", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }
        public static string EliminarProveedor(dgProveedor Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",4),
                    new SqlParameter("@P_IdProveedor",Parametro.Id_Proveedor)


                };

                tabla = bdContext.funcionStored("spProveedor", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static List<dgProveedor> LeerProveedor(int tipo, dgProveedor Parametro)
        {

            List<dgProveedor> lista = new List<dgProveedor>();
            DataTable tabla = new DataTable();

            //5 = con nombre
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",6)
                };

                tabla = bdContext.funcionStored("spProveedor", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProveedor
                             {
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 Id_Proveedor = Convert.ToInt16(fila["Id_Proveedor"].ToString())



                             }
                   ).ToList();
                }


            }





            else if (tipo == 7)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",10),
                    new SqlParameter("@P_IdProveedor",Parametro.Id_Proveedor)
                };

                tabla = bdContext.funcionStored("spProveedor", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProveedor
                             {
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 Correo = Convert.ToString(fila["Correo"].ToString()),
                                 Telefono = Convert.ToString(fila["Telefono"].ToString()),


                             }
                   ).ToList();
                }
            }


            return lista;




        }
    }
}
