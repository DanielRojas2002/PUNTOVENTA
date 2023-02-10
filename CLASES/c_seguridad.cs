using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Punto_de_Venta
{
    class c_seguridad
    {
        string servidor = "DANIELROJAS";
        public int Identificacion_Login(string usuario, string contraseña)
        {
            // funcion para ingresar al sistema
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            
            string sql = "select Id_Usuario from USUARIO where Usuario=@usu and Contrasenia=@contra";
            conexion.Open();
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usu", usuario);
            comando.Parameters.AddWithValue("@contra", contraseña);
            SqlDataReader registro = comando.ExecuteReader();

            int id;


            try
            {
                while (registro.Read())
                {

                    id = (int)registro["Id_Usuario"];
                    conexion.Close();
                    return id;

                }
            }

            catch
            {
                conexion.Close();
                return 0;
            }
            return 0;





        }

        public int Checar_id(string usuario)
        {
            // funcion para retornar el id cuando le demos el nombre de usuario
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            string sql = "select Id_Usuario from USUARIO where Usuario=@usu";
            conexion.Open();
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usu", usuario);

            SqlDataReader registro = comando.ExecuteReader();

            int id;


            try
            {
                while (registro.Read())
                {

                    id = (int)registro["Id_Usuario"];
                    conexion.Close();
                    return id;

                }
            }

            catch
            {
                conexion.Close();
                return 0;
            }
            return 0;





        }

        public string ChecarUsuario(string id)
        {
            // funcion para retornar el usuario cuando le demos el id 
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            string sql = "select Usuario from USUARIO where Id_Usuario=@idd";
            conexion.Open();
            SqlCommand comando = new SqlCommand(sql, conexion);

            int idd;
            idd = Int16.Parse(id);
            comando.Parameters.AddWithValue("@idd", idd);

            SqlDataReader registro = comando.ExecuteReader();

            string usuario0;


            try
            {
                while (registro.Read())
                {

                    usuario0 = (string)registro["Usuario"];
                    conexion.Close();
                    return usuario0;

                }
            }

            catch
            {
                conexion.Close();
                return "";
            }
            return "";





        }
        public List<string> ChecarUC(string id)
        {
            // funcion para retornar una lista de usaurio y contraseña cuando le demos el id 
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            string sql = "select Usuario,Contrasenia,Id_Usuario from USUARIO where Id_Usuario=@idd";
            conexion.Open();
            SqlCommand comando = new SqlCommand(sql, conexion);

            int idd;
            idd = Int16.Parse(id);
            comando.Parameters.AddWithValue("@idd", idd);

            SqlDataReader registro = comando.ExecuteReader();

            string usuario0;
            string contra;
            string idUsuario;

            List<string> Lista = new List<string>();
            try
            {
                while (registro.Read())
                {

                    usuario0 = (string)registro["Usuario"];
                    contra = (string)registro["Contrasenia"];
                    idUsuario = Convert.ToString(registro["Id_Usuario"]);

                    Lista.Add(usuario0);
                    Lista.Add(contra);
                    Lista.Add(idUsuario);
                    conexion.Close();
                    return Lista;

                }
            }

            catch
            {
                conexion.Close();
                return Lista;
            }
            return Lista;





        }
        public List<string> ChecarUsuarioTodos()
        {
            // funcion para retornar el usuario de todos los usuarios
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            string sql = "select Usuario from USUARIO";
            conexion.Open();
            SqlCommand comando = new SqlCommand(sql, conexion);

            List<string> Listausuarios = new List<string>();


            SqlDataReader registro = comando.ExecuteReader();

            string usuario0;


            try
            {
                while (registro.Read())
                {

                    usuario0 = (string)registro["Usuario"];
                    Listausuarios.Add(usuario0);


                }
                conexion.Close();
                return Listausuarios;
            }

            catch
            {
                conexion.Close();
                return Listausuarios;
            }






        }

        public string ChecarPerfil(string id)
        {
            // funcion para reotrnar la categoria textual cuando le demos el id del usuario
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));

            string sqlc = "select Id_Perfil from USUARIO where Id_Usuario=@idd ";

            conexion.Open();
            SqlCommand comando = new SqlCommand(sqlc, conexion);

            int idd;
            idd = Int16.Parse(id);
      
            comando.Parameters.AddWithValue("@idd", idd);
            

            SqlDataReader registro = comando.ExecuteReader();

            int categoria;
            List<int> Listacategoria = new List<int>();


            while (registro.Read())
            {

                categoria = (int)registro["Id_Perfil"];
                Listacategoria.Add(categoria);



            }
            conexion.Close();

            SqlConnection conexion2 = new SqlConnection("server = DANIELROJAS; database = PUNTOVENTA; integrated security = true ");

            conexion2.Open();
            string sql = "select Descripcion from PERFIL where Id_Perfil=@id";
            SqlCommand comando2 = new SqlCommand(sql, conexion2);
            int categoria0 = Listacategoria[0];

            string categoria1 = "";

            comando2.Parameters.AddWithValue("@id", categoria0);

            SqlDataReader registro2 = comando2.ExecuteReader();

            while (registro2.Read())

            {
                categoria1 = (string)registro2["descripcion"];


                conexion2.Close();
                return categoria1;
            }
            return categoria1;




        }

        public List<string> ChecarPerfiles()
        {
            // funcion para retornar todos los perfiles del sistema
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            string sql = "select Descripcion from PERFIL";
            conexion.Open();
            SqlCommand comando = new SqlCommand(sql, conexion);

            List<string> Listaperfiles = new List<string>();

            SqlDataReader registro = comando.ExecuteReader();

            string descripcion0;


            try
            {
                while (registro.Read())
                {

                    descripcion0 = (string)registro["Descripcion"];
                    Listaperfiles.Add(descripcion0);



                }
                conexion.Close();
                return Listaperfiles;
            }

            catch
            {
                conexion.Close();
                return Listaperfiles;
            }
            return Listaperfiles;

        }
    }
}
