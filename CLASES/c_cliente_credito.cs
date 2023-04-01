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

        public static string SeleccionarClienteSeleccionado(dgClienteCredito Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",44),
                    



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
                                 Estado = Convert.ToString(fila["Estado"].ToString()),
                                 Municipio = Convert.ToString(fila["Municipio"].ToString()),
                                 Colonia = Convert.ToString(fila["Colonia"].ToString()),
                                 Calle = Convert.ToString(fila["Calle"].ToString()),
                                 NumCasa = Convert.ToString(fila["NumCasa"].ToString())





                             }
                   ).ToList();
                }


            }

            else if (tipo == 33)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",33),
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
                                 Estado = Convert.ToString(fila["Estado"].ToString()),
                                 Municipio = Convert.ToString(fila["Municipio"].ToString()),
                                 Colonia = Convert.ToString(fila["Colonia"].ToString()),
                                 Calle = Convert.ToString(fila["Calle"].ToString()),
                                 NumCasa = Convert.ToString(fila["NumCasa"].ToString()),

                                
                                 Correo = Convert.ToString(fila["Correo"].ToString()),
                                 Telefono = Convert.ToString(fila["Telefono"].ToString())
                                 
                                 


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
                                 Id_Cliente=Convert.ToInt16(fila["IdCliente"].ToString()),
                                 

                                 Id_Venta = Convert.ToInt16(fila["IdVenta"].ToString()),
                                 CantidadPagada = float.Parse(fila["CantidadPagada"].ToString()),
                                 Total = float.Parse(fila["Total"].ToString())




                             }
                   ).ToList();
                }
            }

            else if (tipo == 333)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",333),
                    new SqlParameter("@P_IdCliente",Parametro.Id_Cliente),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta)

                };

                tabla = bdContext.funcionStored("spCredito", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgClienteCredito
                             {
                                 Id_Cliente = Convert.ToInt16(fila["IdCliente"].ToString()),
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 Apellido_Paterno = Convert.ToString(fila["Apellido_Paterno"].ToString()),

                                 Apellido_Materno = Convert.ToString(fila["Apellido_Materno"].ToString()),
                                 Direccion = Convert.ToString(fila["Direccion"].ToString()),
                                 Correo = Convert.ToString(fila["Correo"].ToString()),
                                 Telefono = Convert.ToString(fila["Telefono"].ToString()),

                                 Id_Venta = Convert.ToInt16(fila["IdVenta"].ToString()),
                                 CantidadPagada = float.Parse(fila["CantidadPagada"].ToString()),
                                 Total = float.Parse(fila["Total"].ToString())




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

            else if (tipo == 7)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",7),
                    new SqlParameter("@P_IdCliente",Parametro.Id_Cliente)


                };

                tabla = bdContext.funcionStored("spCredito", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgClienteCredito
                             {
                                 CantidadCreditos = Convert.ToInt16(fila["CantidadCreditos"].ToString()),




                             }
                   ).ToList();
                }
            }

            else if (tipo == 8)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",8),

                };

                tabla = bdContext.funcionStored("spCredito", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgClienteCredito
                             {
                                 CantidadClientes = Convert.ToInt16(fila["CantidadClientes"].ToString()),




                             }
                   ).ToList();
                }
            }





            return lista;




        }


        public static string ActualizarCreditoPago(int tipo, dgClienteCredito Parametro)
        {

            string control = "";

            if (tipo == 0) // 0 = ´PAGADO PARCIAL EFECTIVO
            {

                try
                {

                    DataTable tabla = new DataTable();

                    SqlParameter[] parametros =
                    {
                        new SqlParameter("@Accion",9),
                        new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                        new SqlParameter("@P_IdCliente",Parametro.Id_Cliente),
                        new SqlParameter("@P_FechaPago",Parametro.FechaPago),
                        new SqlParameter("@P_CantidadPagada",Parametro.CantidadPagada),
                      
                        new SqlParameter("@P_Validacion",Parametro.Validacion)




                    };


                    tabla = bdContext.funcionStored("spCredito", parametros);
                    control = tabla.Rows[0][0].ToString();



                }

                catch (Exception error)
                {
                    control = error.ToString();
                }

            }



            else if (tipo == 1) // 1= PAGADO COMPLETO EFECTIVO
            {

                try
                {

                    DataTable tabla = new DataTable();

                    SqlParameter[] parametros =
                    {
                        new SqlParameter("@Accion",9),
                        new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                        new SqlParameter("@P_IdCliente",Parametro.Id_Cliente),
                        new SqlParameter("@P_FechaPago",Parametro.FechaPago),
                        new SqlParameter("@P_CantidadPagada",Parametro.CantidadPagada),
                     
                        new SqlParameter("@P_Validacion",Parametro.Validacion),
                        new SqlParameter("@P_Cambio",Parametro.Cambio)




                    };


                    tabla = bdContext.funcionStored("spCredito", parametros);
                    control = tabla.Rows[0][0].ToString();



                }

                catch (Exception error)
                {
                    control = error.ToString();
                }

            }



            return control;





        }
    }
}
