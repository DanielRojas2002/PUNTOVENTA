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
    public class c_cliente_credito
    {

        public static string InsertarClienteSeleccionado(dgClienteCredito Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",4),
                    new SqlParameter("@P_IdCliente",Parametro.Id_Cliente)
                   


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

        public static List<dgClienteCredito> LeerClienteCredito(int tipo, dgClienteCredito Parametro)
        {

            List<dgClienteCredito> lista = new List<dgClienteCredito>();
            DataTable tabla = new DataTable();

            //5 = con nombre
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",2)
                };

                tabla = bdContext.funcionStored("spCredito", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgClienteCredito
                             {
                            
                                 Id_Cliente = Convert.ToInt16(fila["Id_Cliente"].ToString()),
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 Apellido_Paterno = Convert.ToString(fila["Apellido_Paterno"].ToString()),
                                 Apellido_Materno = Convert.ToString(fila["Apellido_Materno"].ToString()),
                                 Telefono = Convert.ToString(fila["Telefono"].ToString()),
                                 Correo = Convert.ToString(fila["Correo"].ToString()),
                                 Direccion = Convert.ToString(fila["Direccion"].ToString())



                             }
                   ).ToList();
                }


            }

            else if (tipo == 3)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_IdCliente",Parametro.Id_Cliente)
                };

                tabla = bdContext.funcionStored("spCredito", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgClienteCredito
                             {
                                 Id_Cliente = Convert.ToInt16(fila["Id_Cliente"].ToString()),
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 Apellido_Paterno = Convert.ToString(fila["Apellido_Paterno"].ToString()),
                                 Apellido_Materno = Convert.ToString(fila["Apellido_Materno"].ToString()),
                                 Telefono = Convert.ToString(fila["Telefono"].ToString()),
                                 Correo = Convert.ToString(fila["Correo"].ToString()),
                                 Direccion = Convert.ToString(fila["Direccion"].ToString())



                             }
                   ).ToList();
                }
            }

            else if (tipo == 4)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",5),
                   
                };

                tabla = bdContext.funcionStored("spCredito", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgClienteCredito
                             {
                                 Id_Cliente = Convert.ToInt16(fila["Id_Cliente"].ToString()),
                                 



                             }
                   ).ToList();
                }
            }





            return lista;




        }
    }
}
