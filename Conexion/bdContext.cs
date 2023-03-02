using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.Conexion
{
    class bdContext
    {
        static private readonly string servidor = "localhost";
       
        
       
        // Se ejecuta stored con paramaetros
        public static DataTable funcionStored(string sentencia, SqlParameter[] parametroSQL)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor)))
                {
                    conn.Open();
                    using (var comando = new SqlCommand(sentencia, conn))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddRange(parametroSQL);
                        using (var adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Se ejecuta stored sin parametros
        public static DataTable funcionStored(string sentencia)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor)))
                {
                    conn.Open();
                    using (var comando = new SqlCommand(sentencia, conn))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (var adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
