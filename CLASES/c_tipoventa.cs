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
    public class c_tipoventa
    {

        public static List<dgTipoVenta> LeerTipoVenta(int tipo, dgTipoVenta Parametro)
        {

            List<dgTipoVenta> lista = new List<dgTipoVenta>();
            DataTable tabla = new DataTable();

            //5 = con descripcion
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",1)
                };

                tabla = bdContext.funcionStored("spTipoVenta", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgTipoVenta
                             {
                                 Descripcion = Convert.ToString(fila["Descripcion"].ToString())



                             }
                   ).ToList();
                }


            }
            // 6 con Id_Categoria
            else if (tipo == 2)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",2),
                    new SqlParameter("@P_Descripcion",Parametro.Descripcion)
                };

                tabla = bdContext.funcionStored("spTipoVenta", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgTipoVenta
                             {
                                 Id_TipoVenta = Convert.ToInt16(fila["Id_TipoVenta"].ToString())

                             }
                   ).ToList();
                }
            }

           




            return lista;




        }
    }
}
