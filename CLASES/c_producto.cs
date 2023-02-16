﻿using PUNTOVENTA.Conexion;
using PUNTOVENTA.ENTIDAD;
using System.Data.SqlClient;
using System.Data;

namespace Punto_de_Venta.Clases
{
    class c_producto
    {


        public static string InsertarProducto(dgProducto Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_IdCategoria",Parametro.Id_Categoria),
                    new SqlParameter("@P_IdMedida",Parametro.Id_Medida),
                    new SqlParameter("@P_IdProveedor",Parametro.Id_Proveedor),
                    new SqlParameter("@P_Nombre",Parametro.Nombre),
                    new SqlParameter("@P_Descripcion",Parametro.Descripcion),
                    new SqlParameter("@P_PrecioCompra",Parametro.PrecioCompra),
                    new SqlParameter("@P_PrecioVenta",Parametro.PrecioVenta),
                    new SqlParameter("@P_Stock",Parametro.StockInicial)
                   


                };

                tabla = bdContext.funcionStored("spProducto", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }


        public static string ModificarProducto(dgProducto Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_IdCategoria",Parametro.Id_Categoria),
                    new SqlParameter("@P_IdMedida",Parametro.Id_Medida),
                    new SqlParameter("@P_IdProveedor",Parametro.Id_Proveedor),
                    new SqlParameter("@P_Nombre",Parametro.Nombre),
                    new SqlParameter("@P_Descripcion",Parametro.Descripcion),
                    new SqlParameter("@P_PrecioCompra",Parametro.PrecioCompra),
                    new SqlParameter("@P_PrecioVenta",Parametro.PrecioVenta)
                    


                };

                tabla = bdContext.funcionStored("spProducto", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }
        public static string EliminarProducto(dgProducto Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",4),
                    new SqlParameter("@P_IdProducto",Parametro.Id_Producto)


                };

                tabla = bdContext.funcionStored("spProducto", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static List<dgProducto> LeerProducto(int tipo, dgProducto Parametro)
        {

            List<dgProducto> lista = new List<dgProducto>();
            DataTable tabla = new DataTable();

            //5 = con descripcion
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",5)
                };

                tabla = bdContext.funcionStored("spProducto", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProducto
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
                    new SqlParameter("@Accion",6),
                    new SqlParameter("@P_Descripcion",Parametro.Descripcion)
                };

                tabla = bdContext.funcionStored("spCategoria", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProducto
                             {
                                 Id_Categoria = Convert.ToInt16(fila["Id_Categoria"].ToString())



                             }
                   ).ToList();
                }
            }

            else if (tipo == 3)

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",7),
                    new SqlParameter("@P_IdCategoria",Parametro.Id_Categoria)
                };

                tabla = bdContext.funcionStored("spCategoria", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProducto
                             {
                                 Descripcion = Convert.ToString(fila["Descripcion"].ToString())



                             }
                   ).ToList();
                }
            }

            else if (tipo == 4) // select para el datagridview de productos

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",7),
                    
                };

                tabla = bdContext.funcionStored("spProducto", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProducto
                             {
                                 Id_Producto = Convert.ToInt16(fila["Id_Producto"].ToString()),
                                 Id_Categoria = Convert.ToInt16(fila["Id_Categoria"].ToString()),
                                 Id_Medida = Convert.ToInt16(fila["Id_Medida"].ToString()),
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 StockInicial = Convert.ToInt16(fila["Stock"].ToString())




                             }
                   ).ToList();
                }
            }




            return lista;




        }
    }
}
