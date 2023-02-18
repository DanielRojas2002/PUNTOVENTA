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
    public class c_entrada
    {

        public static string InsertarCategoria(dgCategoria Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",1),
                    new SqlParameter("@P_Descripcion",Parametro.Descripcion)


                };

                tabla = bdContext.funcionStored("spCategoria", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }


        public static string ModificarCategoria(dgCategoria Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",3),
                    new SqlParameter("@P_IdCategoria",Parametro.Id_Categoria),
                    new SqlParameter("@P_Descripcion",Parametro.Descripcion)


                };

                tabla = bdContext.funcionStored("spCategoria", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }
        public static string EliminarCategoria(dgCategoria Parametro)
        {


            string control = "";

            try
            {

                DataTable tabla = new DataTable();

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Accion",4),
                    new SqlParameter("@P_IdCategoria",Parametro.Id_Categoria)


                };

                tabla = bdContext.funcionStored("spCategoria", parametros);
                control = tabla.Rows[0][0].ToString();



            }

            catch (Exception error)
            {
                control = error.ToString();
            }
            return control;

        }

        public static List<dgCategoria> LeerCategoria(int tipo, dgCategoria Parametro)
        {

            List<dgCategoria> lista = new List<dgCategoria>();
            DataTable tabla = new DataTable();

            //5 = con descripcion
            if (tipo == 1)
            {

                SqlParameter[] Parametros =
                {
                new SqlParameter("@Accion",5)
                };

                tabla = bdContext.funcionStored("spCategoria", Parametros);

                if (tabla.Rows.Count > 0)
                {
                    lista = (from DataRow fila in tabla.Rows
                             select new dgCategoria
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
                             select new dgCategoria
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
                             select new dgCategoria
                             {
                                 Descripcion = Convert.ToString(fila["Descripcion"].ToString())



                             }
                   ).ToList();
                }
            }




            return lista;




        }
    }
}
