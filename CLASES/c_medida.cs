using PUNTOVENTA.Conexion;
using PUNTOVENTA.ENTIDAD;
using System.Data.SqlClient;
using System.Data;

namespace PUNTOVENTA.CLASES
{
    public class c_medida
    {
       


        public static string InsertarMedida(dgMedida Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_Descripcion",Parametro.Descripcion)


                };

                tabla = bdContext.funcionStored("spMedida", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }


        public static string ModificarMedida(dgMedida Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_IdMedida",Parametro.Id_Medida),
                    new SqlParameter("@P_Descripcion",Parametro.Descripcion)


                };

                tabla = bdContext.funcionStored("spMedida", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }
        public static string EliminarMedida(dgMedida Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",4),
                    new SqlParameter("@P_IdMedida",Parametro.Id_Medida)


                };

                tabla = bdContext.funcionStored("spMedida", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static List<dgMedida> LeerMedida(int tipo, dgMedida Parametro)
        {

            List<dgMedida> lista = new List<dgMedida>();
            DataTable tabla = new DataTable();

            //5 = con descripcion
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",5)
                };

                tabla = bdContext.funcionStored("spMedida", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgMedida
                             {
                                 Descripcion = Convert.ToString(fila["Descripcion"].ToString()),

                                 Id_Medida = Convert.ToInt16(fila["Id_Medida"].ToString()),

                             }
                   ).ToList();
                }


            }
            // 6 con Id_Categoria


            else if (tipo == 2)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",6),
                    new SqlParameter("@P_Descripcion",Parametro.Descripcion)
                };

                tabla = bdContext.funcionStored("spMedida", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgMedida
                             {
                                 Id_Medida = Convert.ToInt16(fila["Id_Medida"].ToString())



                             }
                   ).ToList();
                }
            }

            else if (tipo == 3)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",7),
                    new SqlParameter("@P_IdMedida",Parametro.Id_Medida)
                };

                tabla = bdContext.funcionStored("spMedida", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgMedida
                             {
                                 Descripcion = Convert.ToString(fila["Descripcion"].ToString())



                             }
                   ).ToList();
                }
            }




            return lista;




        }
    }
}
