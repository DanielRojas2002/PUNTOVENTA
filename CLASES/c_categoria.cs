using PUNTOVENTA.Conexion;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;


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





        public static string EliminarCategoria(string IdCategoria)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_IdCategoria",Convert.ToInt16(IdCategoria))


                };

                tabla = bdContext.funcionStored("spCategoria", parametros);
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
