using PUNTOVENTA.Conexion;
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
                     new SqlParameter("@P_IdProducto",Parametro.Id_Producto),
                    new SqlParameter("@P_IdCategoria",Parametro.Id_Categoria),
                    new SqlParameter("@P_IdMedida",Parametro.Id_Medida),
                    new SqlParameter("@P_IdProveedor",Parametro.Id_Proveedor),
                    new SqlParameter("@P_IdEstatus",Parametro.Id_Estatus_Producto),
                    new SqlParameter("@P_Nombre",Parametro.Nombre),
                    new SqlParameter("@P_Descripcion",Parametro.Descripcion),
                    new SqlParameter("@P_PrecioCompra",Parametro.PrecioCompra),
                    new SqlParameter("@P_PrecioVenta",Parametro.PrecioVenta),
                    new SqlParameter("@P_Iva",Parametro.Iva)




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
                    new SqlParameter("@P_IdProducto",Parametro.Id_Producto),
                    new SqlParameter("@P_IdCategoria",Parametro.Id_Categoria),
                    new SqlParameter("@P_IdMedida",Parametro.Id_Medida),
                    new SqlParameter("@P_IdProveedor",Parametro.Id_Proveedor),
                    new SqlParameter("@P_Nombre",Parametro.Nombre),
                    new SqlParameter("@P_Descripcion",Parametro.Descripcion),
                    new SqlParameter("@P_PrecioCompra",Parametro.PrecioCompra),
                    new SqlParameter("@P_PrecioVenta",Parametro.PrecioVenta),
                    new SqlParameter("@P_Iva",Parametro.Iva)



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
        public static string DesactivaroActivarProducto(dgProducto Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",4),
                    new SqlParameter("@P_IdProducto",Parametro.Id_Producto),
                    new SqlParameter("@P_IdEstatus",Parametro.Id_Estatus_Producto)


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
                                 Id_Producto = Convert.ToString(fila["Id_Producto"].ToString()),
                                 Id_Categoria = Convert.ToInt16(fila["Id_Categoria"].ToString()),
                                 Id_Medida = Convert.ToInt16(fila["Id_Medida"].ToString()),
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 StockInicial = Convert.ToInt16(fila["Stock"].ToString()),
                                 Id_Estatus_Producto = Convert.ToInt16(fila["Id_Estatus"].ToString())




                             }
                   ).ToList();
                }
            }


            else if (tipo == 5) // select todos los campos cuando le de el idproducto

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",2),
                    new SqlParameter("@P_IdProducto",Parametro.Id_Producto)

                };

                tabla = bdContext.funcionStored("spProducto", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProducto
                             {
                                 Id_Categoria = Convert.ToInt16(fila["Id_Categoria"].ToString()),
                                 Id_Medida = Convert.ToInt16(fila["Id_Medida"].ToString()),
                               
                                 Id_Proveedor = Convert.ToInt16(fila["Id_Proveedor"].ToString()),
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 Descripcion = Convert.ToString(fila["Descripcion"].ToString()),
                                 StockInicial = Convert.ToInt16(fila["Stock"].ToString()),
                                 PrecioCompra = float.Parse(fila["PrecioCompra"].ToString()),
                                 PrecioVenta = float.Parse(fila["PrecioVenta"].ToString()),
                                 Id_Estatus_Producto = Convert.ToInt16(fila["Id_Estatus"].ToString())





                             }
                   ).ToList();
                }
            }

            else if (tipo == 6) // FILTRADO DATAGRIDVIEW

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",8),
                    new SqlParameter("@P_IdProducto",Parametro.Id_Producto),
                    new SqlParameter("@P_IdCategoria",Parametro.Id_Categoria),
                    new SqlParameter("@P_IdMedida",Parametro.Id_Medida),
                    new SqlParameter("@P_IdProveedor",Parametro.Id_Proveedor),
                    new SqlParameter("@P_Nombre",Parametro.Nombre)

                };

                tabla = bdContext.funcionStored("spProducto", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProducto
                             {

                                 Id_Producto = Convert.ToString(fila["Id_Producto"].ToString()),
                                 Id_Categoria = Convert.ToInt16(fila["Id_Categoria"].ToString()),
                                 Id_Medida = Convert.ToInt16(fila["Id_Medida"].ToString()),
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 StockInicial = Convert.ToInt16(fila["Stock"].ToString())
                                



                             }
                   ).ToList();
                }
            }

            else if (tipo == 7) // select para el datagridview de productos para venta

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",9),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta),
                    new SqlParameter("@P_validacion2",Parametro.Id_Validacion2)

                };

                tabla = bdContext.funcionStored("spProducto", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProducto
                             {
                                 Id_Producto = Convert.ToString(fila["Id_Producto"].ToString()),
                                 Descripcion = Convert.ToString(fila["Descripcion"].ToString()),
                                 Id_Categoria = Convert.ToInt16(fila["Id_Categoria"].ToString()),
                                 Id_Medida = Convert.ToInt16(fila["Id_Medida"].ToString()),
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 StockInicial = Convert.ToInt16(fila["Stock"].ToString()),
                                 PrecioVenta = float.Parse(fila["PrecioVenta"].ToString())




                             }
                   ).ToList();
                }
            }

            else if (tipo == 8) // select para el datagridview de productos para venta cuando usa el filtrado

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",10),
                     new SqlParameter("@P_IdProducto",Parametro.Id_Producto),
                    new SqlParameter("@P_IdCategoria",Parametro.Id_Categoria),
                    new SqlParameter("@P_IdMedida",Parametro.Id_Medida),
                    new SqlParameter("@P_Nombre",Parametro.Nombre),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta)
               

                };

                tabla = bdContext.funcionStored("spProducto", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProducto
                             {
                                 Id_Producto = Convert.ToString(fila["Id_Producto"].ToString()),
                                 Descripcion = Convert.ToString(fila["Descripcion"].ToString()),
                                 Id_Categoria = Convert.ToInt16(fila["Id_Categoria"].ToString()),
                                 Id_Medida = Convert.ToInt16(fila["Id_Medida"].ToString()),
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 StockInicial = Convert.ToInt16(fila["Stock"].ToString()),
                                 PrecioVenta = float.Parse(fila["PrecioVenta"].ToString())




                             }
                   ).ToList();
                }
            }

            else if (tipo == 9) // FILTRADO DATAGRIDVIEW INACTIVOS

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",11),
                    new SqlParameter("@P_IdCategoria",Parametro.Id_Categoria),
                    new SqlParameter("@P_IdMedida",Parametro.Id_Medida),
                    new SqlParameter("@P_IdProveedor",Parametro.Id_Proveedor),
                    new SqlParameter("@P_Nombre",Parametro.Nombre)

                };

                tabla = bdContext.funcionStored("spProducto", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProducto
                             {

                                 Id_Producto = Convert.ToString(fila["Id_Producto"].ToString()),
                                 Id_Categoria = Convert.ToInt16(fila["Id_Categoria"].ToString()),
                                 Id_Medida = Convert.ToInt16(fila["Id_Medida"].ToString()),
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 StockInicial = Convert.ToInt16(fila["Stock"].ToString())




                             }
                   ).ToList();
                }
            }

            else if (tipo == 10) // select para el datagridview de productos inactivos

            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",77),

                };

                tabla = bdContext.funcionStored("spProducto", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProducto
                             {
                                 Id_Producto = Convert.ToString(fila["Id_Producto"].ToString()),
                                 Id_Categoria = Convert.ToInt16(fila["Id_Categoria"].ToString()),
                                 Id_Medida = Convert.ToInt16(fila["Id_Medida"].ToString()),
                                 Nombre = Convert.ToString(fila["Nombre"].ToString()),
                                 StockInicial = Convert.ToInt16(fila["Stock"].ToString()),
                                 Id_Estatus_Producto = Convert.ToInt16(fila["Id_Estatus"].ToString())




                             }
                   ).ToList();
                }
            }

            else if (tipo == 12)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",12),
                    new SqlParameter("@P_IdVenta",Parametro.Id_Venta)

                };

                tabla = bdContext.funcionStored("spProducto", Parametros);

                if (tabla.Rows.Count > 0)
                {

                    lista = (from DataRow fila in tabla.Rows
                             select new dgProducto
                             {

                                 CantidadProductos = Convert.ToInt16(fila["CantidadProductos"].ToString())
                             }
                    ).ToList();




                }


            }


            if (tipo == 13)
            {

                SqlParameter[] Parametros =
                {
                    new SqlParameter("@Accion",13),
                    new SqlParameter("@P_IdCategoria",Parametro.Id_Categoria)
                };

                tabla = bdContext.funcionStored("spProducto", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgProducto
                             {
                                 Id_Producto = Convert.ToString(fila["Id_Producto"].ToString()),
                                 Nombre = Convert.ToString(fila["Nombre"].ToString())



                             }
                   ).ToList();
                }


            }



            return lista;




        }
    }
}
