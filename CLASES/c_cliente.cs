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
    }
}
