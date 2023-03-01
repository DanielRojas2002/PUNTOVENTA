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
    public class c_reportes
    {
        public static List<dgReportes> LeerReporte(int tipo, dgReportes Parametro)
        {

            List<dgReportes> lista = new List<dgReportes>();
            DataTable tabla = new DataTable();

            //5 = con descripcion
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",1),
                new SqlParameter("@P_FechaInicio",Parametro.FechaInicio),
                new SqlParameter("@P_FechaFinal",Parametro.FechaFinal)
                };

                tabla = bdContext.funcionStored("spReportes", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgReportes
                             {
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 IdProducto = Convert.ToInt16(fila["IdProducto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["CantidadProducto"].ToString()),
                                 PrecioProducto = Convert.ToInt16(fila["PrecioProducto"].ToString()),
                                 SubTotalProducto = Convert.ToInt16(fila["SubTotalProducto"].ToString()),
                                 FechaVentaProducto = Convert.ToDateTime(fila["FechaVentaProducto"].ToString())


                             }
                   ).ToList();
                }

            }

            return lista;
        }
    }
}
