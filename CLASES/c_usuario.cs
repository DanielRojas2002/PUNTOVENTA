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

            else if (tipo==2) // 6 Buscar el Usuario por el Id_Usuario
            {
                SqlParameter[] Parametros =
              {
                    new SqlParameter("@Accion",6),
                    new SqlParameter("@P_IdUsuario",Parametro.Id_Usuario)
                   
                };

                tabla = bdContext.funcionStored("spUsuario", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgUsuario
                             {
                                 Usuario = Convert.ToString(fila["Usuario"].ToString())



                             }
                   ).ToList();
                }
            }

            else if (tipo == 3) // 7 Buscar el su Perfil por su Id_Usuario y luego buscar la descripcion por la Id_Perfil
            {
                SqlParameter[] Parametros =
              {
                    new SqlParameter("@Accion",7),
                    new SqlParameter("@P_IdUsuario",Parametro.Id_Usuario)

                };

                tabla = bdContext.funcionStored("spUsuario", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgUsuario
                             {
                                 DescripcionPerfil = Convert.ToString(fila["Descripcion"].ToString())



                             }
                   ).ToList();
                }
            }

            else if (tipo == 4) // 8 SELECT * FROM USUARIO WHERE ID_USUARIO <> Id logeado
            {
                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",8),
                    new SqlParameter("@P_IdUsuario",Parametro.Id_Usuario)

                };

                tabla = bdContext.funcionStored("spUsuario", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgUsuario
                             {
                                
                                 Usuario = Convert.ToString(fila["Usuario"].ToString())



                             }
                   ).ToList();
                }
            }

            else if (tipo == 5) // 9 SELECT Id_Usuario FROM USUARIO WHERE Usuario= @PUsuario
            {
                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",9),
                    new SqlParameter("@P_Usuario",Parametro.Usuario)

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
