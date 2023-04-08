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
    public class c_caja
    {


        public static string InsertarCaja(dgCaja Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",2),
                    new SqlParameter("@P_CantidadAbonada",Parametro.CantidadAbonada),
                    new SqlParameter("@P_CantidadVenta",Parametro.CantidadVenta),
                    new SqlParameter("@P_CantidadRetirada",Parametro.CantidadRetirada),
                    new SqlParameter("@P_FechaCaja",Parametro.FechaCaja)



                };

                tabla = bdContext.funcionStored("spCaja", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static string ActualizarCaja(dgCaja Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",44),
                    new SqlParameter("@P_CantidadVenta",Parametro.CantidadVenta),
                    new SqlParameter("@P_CantidadTotal",Parametro.CantidadTotal),
                    
                    new SqlParameter("@P_FechaCaja",Parametro.FechaCaja)



                };

                tabla = bdContext.funcionStored("spCaja", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }


        public static string AbonarCaja(dgCaja Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_CantidadAbonada",Parametro.CantidadAbonada),
                    new SqlParameter("@P_FechaCaja",Parametro.FechaCaja)


                };

                tabla = bdContext.funcionStored("spCaja", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static string CajaEstatus(dgCaja Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",9),
                    new SqlParameter("@P_IdCajaEstatus",Parametro.IdCajaEstatus),
                    new SqlParameter("@P_FechaCaja",Parametro.FechaCaja)


                };

                tabla = bdContext.funcionStored("spCaja", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }



        public static string RetirarCaja(dgCaja Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",4),
                    new SqlParameter("@P_CantidadRetirada",Parametro.CantidadRetirada),
                    new SqlParameter("@P_FechaCaja",Parametro.FechaCaja)


                };

                tabla = bdContext.funcionStored("spCaja", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static string RetirarCajaTodo(dgCaja Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",11),
                    new SqlParameter("@P_FechaCaja",Parametro.FechaCaja)


                };

                tabla = bdContext.funcionStored("spCaja", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static List<dgCaja> LeerCaja(int tipo, dgCaja Parametro)
        {

            List<dgCaja> lista = new List<dgCaja>();
            DataTable tabla = new DataTable();

            //5 = con descripcion
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_FechaInicio",Parametro.FechaInicio),

                };

                tabla = bdContext.funcionStored("spCaja", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCaja
                             {
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 IdProducto = Convert.ToInt16(fila["IdProducto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["CantidadProducto"].ToString()),
                                 PrecioProducto = float.Parse(fila["PrecioProducto"].ToString()),
                                 SubTotalProducto = float.Parse(fila["SubTotalProducto"].ToString()),
                                 FechaVentaProducto = Convert.ToDateTime(fila["FechaVentaProducto"].ToString()),
                                 Usuario = Convert.ToString(fila["Usuario"].ToString()),
                                 DescripcionTipoVenta = Convert.ToString(fila["DescripcionTipoVenta"].ToString())


                             }
                   ).ToList();
                }

            }

            else if (tipo == 2)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",5),
                    new SqlParameter("@P_FechaCaja",Parametro.FechaCaja),

                };

                tabla = bdContext.funcionStored("spCaja", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCaja
                             {

                                 CantidadAbonada = float.Parse(fila["CantidadAbonada"].ToString()),

                             }
                   ).ToList();
                }

            }


            else if (tipo == 3)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",6),
                    new SqlParameter("@P_FechaCaja",Parametro.FechaCaja),

                };

                tabla = bdContext.funcionStored("spCaja", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCaja
                             {

                                 CantidadVA = float.Parse(fila["CantidadVA"].ToString()),

                             }
                   ).ToList();
                }

            }

            else if (tipo == 4)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",7),
                    new SqlParameter("@P_FechaCaja",Parametro.FechaCaja),

                };

                tabla = bdContext.funcionStored("spCaja", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCaja
                             {

                                 CantidadRetirada = float.Parse(fila["CantidadRetirada"].ToString()),

                             }
                   ).ToList();
                }

            }

            else if (tipo == 5)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",8),
                    new SqlParameter("@P_FechaCaja",Parametro.FechaCaja),

                };

                tabla = bdContext.funcionStored("spCaja", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCaja
                             {

                                 Id_CajaEstatus = Convert.ToInt16(fila["Id_CajaEstatus"].ToString())

                             }
                   ).ToList();
                }

            }

            else if (tipo == 6)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",11),
                    new SqlParameter("@P_FechaInicio",Parametro.FechaInicio),

                };

                tabla = bdContext.funcionStored("spCaja", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCaja
                             {
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 IdProducto = Convert.ToInt16(fila["IdProducto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["CantidadProducto"].ToString()),
                                 PrecioProducto = float.Parse(fila["PrecioProducto"].ToString()),
                                 SubTotalProducto = float.Parse(fila["SubTotalProducto"].ToString()),
                                 FechaVentaProducto = Convert.ToDateTime(fila["FechaVentaProducto"].ToString()),

                                 Usuario = Convert.ToString(fila["Usuario"].ToString()),
                                 DescripcionTipoVenta = Convert.ToString(fila["DescripcionTipoVenta"].ToString())

                             }
                   ).ToList();
                }

            }

            else if (tipo == 7)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",10),
                    new SqlParameter("P_FechaCaja",Parametro.FechaCaja)

                };

                tabla = bdContext.funcionStored("spCaja", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCaja
                             {
                                 Id_CajaEstatus = Convert.ToInt16(fila["Id_CajaEstatus"].ToString())
                                 
                               

                             }
                   ).ToList();
                }

            }

            else if (tipo == 8)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",111),
                    new SqlParameter("@P_FechaInicio",Parametro.FechaInicio),

                };

                tabla = bdContext.funcionStored("spCaja", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCaja
                             {
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),

                                 FechaVentaProducto = Convert.ToDateTime(fila["FechaVentaProducto"].ToString()),

                                 CantidadPagada = float.Parse(fila["CantidadPagada"].ToString())


                             }
                   ).ToList();
                }

            }

            else if (tipo == 9)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",12),
                    new SqlParameter("@P_FechaCaja",Parametro.FechaCaja)

                };

                tabla = bdContext.funcionStored("spCaja", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCaja
                             {
                                 Id_Devolucion = Convert.ToInt16(fila["Id_Devolucion"].ToString()),
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 IdProducto = Convert.ToInt16(fila["Id_Producto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["Cantidad"].ToString()),
                                 PrecioProducto = float.Parse(fila["Precio"].ToString()),
                                 SubTotalProducto = float.Parse(fila["SubTotalProducto"].ToString()),
                                 FechaDevolucion = Convert.ToDateTime(fila["FechaDevolucion"].ToString()),

                                 Usuario = Convert.ToString(fila["Usuario"].ToString())
                               

                             }
                   ).ToList();
                }

            }

            else if (tipo == 10)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",13),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta)

                };

                tabla = bdContext.funcionStored("spCaja", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCaja
                             {
                                 Id_Devolucion = Convert.ToInt16(fila["Id_Devolucion"].ToString()),
                                 Id_Venta = Convert.ToInt16(fila["Id_Venta"].ToString()),
                                 IdProducto = Convert.ToInt16(fila["Id_Producto"].ToString()),
                                 NombreProducto = Convert.ToString(fila["NombreProducto"].ToString()),
                                 CantidadProducto = Convert.ToInt16(fila["Cantidad"].ToString()),
                                 PrecioProducto = float.Parse(fila["Precio"].ToString()),
                                 SubTotalProducto = float.Parse(fila["SubTotalProducto"].ToString()),
                                 FechaDevolucion = Convert.ToDateTime(fila["FechaDevolucion"].ToString()),

                                 Usuario = Convert.ToString(fila["Usuario"].ToString())


                             }
                   ).ToList();
                }

            }


            return lista;
        }



    }
}
