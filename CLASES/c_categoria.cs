using System.Data.SqlClient;

namespace PUNTOVENTA.CLASES
{
    class c_categoria
    {
        string servidor = "DANIELROJAS";
        public int Checar_id(string descripcion)
        {
            // funcion para retornar el id cuando le demos el nombre de la descripcion categoria
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            string sql = "select Id_Categoria from CATEGORIA where Descripcion=@descrip";
            conexion.Open();
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@descrip", descripcion);

            SqlDataReader registro = comando.ExecuteReader();

            int id;


            try
            {
                while (registro.Read())
                {

                    id = (int)registro["Id_Categoria"];
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


        public List<string> ChecarDescripcion(string id)
        {
            // funcion para retornar una lista de descripcion cuando le demos el id 
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            string sql = "select Descripcion,Id_Categoria from CATEGORIA where Id_Categoria=@idd";
            conexion.Open();
            SqlCommand comando = new SqlCommand(sql, conexion);

            int idd;
            idd = Int16.Parse(id);
            comando.Parameters.AddWithValue("@idd", idd);

            SqlDataReader registro = comando.ExecuteReader();

            string descripcion;

            string idCategoria;

            List<string> Lista = new List<string>();
            try
            {
                while (registro.Read())
                {

                    descripcion = (string)registro["Descripcion"];

                    idCategoria = Convert.ToString(registro["Id_Categoria"]);

                    Lista.Add(descripcion);
                    Lista.Add(idCategoria);
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

        public string ChecarDescrip(string id)
        {
            // funcion para retornar la descripcion cuando le demos el id 
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            string sql = "select Descripcion from CATEGORIA where Id_Categoria=@idd";
            conexion.Open();
            SqlCommand comando = new SqlCommand(sql, conexion);

            int idd;
            idd = Int16.Parse(id);
            comando.Parameters.AddWithValue("@idd", idd);

            SqlDataReader registro = comando.ExecuteReader();

            string descripcion;


            try
            {
                while (registro.Read())
                {

                    descripcion = (string)registro["Descripcion"];
                    conexion.Close();
                    return descripcion;

                }
            }

            catch
            {
                conexion.Close();
                return "";
            }
            return "";





        }

        public List<string> ChecarCategoriaTodos()
        {
            // funcion para retornar las categorias de todos los usuarios
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            string sql = "select Descripcion from CATEGORIA";
            conexion.Open();
            SqlCommand comando = new SqlCommand(sql, conexion);

            List<string> ListaCategorias = new List<string>();


            SqlDataReader registro = comando.ExecuteReader();

            string descripcion;


            try
            {
                while (registro.Read())
                {

                    descripcion = (string)registro["Descripcion"];
                    ListaCategorias.Add(descripcion);


                }
                conexion.Close();
                return ListaCategorias;
            }

            catch
            {
                conexion.Close();
                return ListaCategorias;
            }






        }
    }
}
