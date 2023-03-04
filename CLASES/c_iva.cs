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
    public class c_iva
    {
        public static List<dgIva> LeerIva(int tipo, dgIva Parametro)
        {

            List<dgIva> lista = new List<dgIva>();
            DataTable tabla = new DataTable();

            //5 = con descripcion
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",1)
                };

                tabla = bdContext.funcionStored("spIva", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgIva
                             {
                                

                                 Id_Iva = Convert.ToInt16(fila["Id_Iva"].ToString()),

                                 Porcentaje = float.Parse(fila["Porcentaje"].ToString()),

                             }
                   ).ToList();
                }


            }
           




            return lista;




        }
    }
}
