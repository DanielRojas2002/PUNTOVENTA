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
                    new SqlParameter("@P_IdProveedor", Parametro.Id_Proveedor)


                };

                tabla = bdContext.funcionStored("spNombre", parametros);
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
                                 Nombre = Convert.ToString(fila["Nombre"].ToString())



                             }
                   ).ToList();
                }


            }


            // 6 con Id_Proveedor
            else if (tipo == 2)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",2)
                  
                };

                tabla = bdContext.funcionStored("spProveedor", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProveedor
                             {
                                 Nombre = Convert.ToString(fila["Nombre"].ToString())



                             }
                   ).ToList();
                }
            }

            else if (tipo == 3)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",5),
                    new SqlParameter("@P_Nombre",Parametro.Nombre)
                };

                tabla = bdContext.funcionStored("spProveedor", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProveedor
                             {
                                 Id_Proveedor = Convert.ToInt16(fila["Id_Proveedor"].ToString())



                             }
                   ).ToList();
                }
            }


            else if (tipo == 4)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",7),
                    new SqlParameter("@P_Nombre",Parametro.Nombre)
                };

                tabla = bdContext.funcionStored("spProveedor", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProveedor
                             {
                                 Id_Proveedor = Convert.ToInt16(fila["Id_Proveedor"].ToString())



                             }
                   ).ToList();
                }
            }




            return lista;




        }
    }
}
