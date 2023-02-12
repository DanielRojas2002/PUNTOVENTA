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
    public class c_usuario
    {

        public static string InsertarUsuario(dgUsuario Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_Usuario",Parametro.Usuario),
                    new SqlParameter("@P_Contrasenia",Parametro.Contrasenia),
                    new SqlParameter("@P_IdPerfil",Parametro.Id_Perfil)


                };

                tabla = bdContext.funcionStored("spUsuario", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }


        public static string ModificarUsuario(dgUsuario Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_Usuario",Parametro.Usuario),
                    new SqlParameter("@P_Contrasenia",Parametro.Contrasenia),
                    new SqlParameter("@P_IdPerfil",Parametro.Id_Perfil)


                };

                tabla = bdContext.funcionStored("spUsuario", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }
        public static string EliminarUsuario(dgUsuario Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",4),
                    new SqlParameter("@P_IdUsuario",Parametro.Id_Usuario)


                };

                tabla = bdContext.funcionStored("spUsuario", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static List<dgUsuario> LeerUsuario(int tipo, dgUsuario Parametro)
        {

            List<dgUsuario> lista = new List<dgUsuario>();
            DataTable tabla = new DataTable();

            //5 = LOGIN
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",5),
                    new SqlParameter("@P_Usuario",Parametro.Usuario),
                    new SqlParameter("@P_Contrasenia",Parametro.Contrasenia)
                };

                tabla = bdContext.funcionStored("spUsuario", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgUsuario
                             {
                                 Id_Usuario = Convert.ToInt16(fila["Id_Usuario"].ToString())



                             }
                   ).ToList();
                }
               


            }
           

            return lista;




        }
    }
}
