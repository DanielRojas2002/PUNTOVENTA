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
    public class c_abonoTotal
    {

        public static List<dgAbonoTotal> LeerAbonoTotal(int tipo, dgAbonoTotal Parametro)
        {

            List<dgAbonoTotal> lista = new List<dgAbonoTotal>();
            DataTable tabla = new DataTable();

            //1= lectura de deuda total
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_IdCliente",Parametro.Id_Cliente)
                };

                tabla = bdContext.funcionStored("spAbonoCredito", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgAbonoTotal
                             {
                                 TotalVenta = float.Parse(fila["TotalVenta"].ToString()),
                                 CantidadPagadaTotal = float.Parse(fila["CantidadPagada"].ToString()),
                                 CantidadFaltanteTotal = float.Parse(fila["CantidadFaltante"].ToString())
                               



                             }
                   ).ToList();
                }


            }

            else if (tipo == 2)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",2),
                    new SqlParameter("@P_IdCliente",Parametro.Id_Cliente)
                };

                tabla = bdContext.funcionStored("spAbonoCredito", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgAbonoTotal
                             {
                                 Id_Venta = Convert.ToInt32(fila["Id_Venta"].ToString()),
                                 Id_Credito = Convert.ToInt32(fila["Id_Credito"].ToString()),
                                 Id_Cliente = Convert.ToInt32(fila["Id_Cliente"].ToString()),
                                 TotalVenta = float.Parse(fila["TotalVenta"].ToString()),
                                 CantidadPagadaTotal = float.Parse(fila["CantidadPagada"].ToString()),
                                 CantidadFaltanteTotal = float.Parse(fila["CantidadFaltante"].ToString())




                             }
                   ).ToList();
                }


            }












            return lista;




        }
    }
}
