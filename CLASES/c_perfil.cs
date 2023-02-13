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
    public class c_perfil
    {
        public static List<dgPerfil> LeerPerfil(int tipo, dgPerfil Parametro)
        {

            List<dgPerfil> lista = new List<dgPerfil>();
            DataTable tabla = new DataTable();

            //1 = SELECT * FROM PERFIL;
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",1)
                   
                };

                tabla = bdContext.funcionStored("spPerfil", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgPerfil
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
