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
    public class c_impresora
    {
        public static List<dgImpresora> LeerImpresora(int tipo, dgImpresora Parametro)
        {

            List<dgImpresora> lista = new List<dgImpresora>();
            DataTable tabla = new DataTable();

            //1 = SELECT NOMBREIMPRESORA FROM IMPRESORA;
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",1)

                };

                tabla = bdContext.funcionStored("spImpresora", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgImpresora
                             {
                                 NombreImpresora = Convert.ToString(fila["NombreConexion"].ToString())



                             }
                   ).ToList();
                }



            }




            return lista;




        }
    }
}
