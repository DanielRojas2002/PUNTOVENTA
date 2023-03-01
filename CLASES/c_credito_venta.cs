using PUNTOVENTA.Conexion;
using PUNTOVENTA.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.CLASES
{
    public class c_credito_venta
    {
        public static string InsertarCreditoVenta(dgCredito Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                    new SqlParameter("@P_IdCliente",Parametro.Id_Cliente),
                    new SqlParameter("@P_IdEstatus",Parametro.Id_Estatus),
                    new SqlParameter("@P_FechaRegistro",Parametro.FechaRegistro),
                    new SqlParameter("@P_CantidadPagada",Parametro.CantidadPagada)




                };

                tabla = bdContext.funcionStored("spCredito", parametros);
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
