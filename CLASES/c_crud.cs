using System.Data.SqlClient;
namespace Punto_de_Venta
{
    class c_crud
    {
        string servidor = "DANIELROJAS";
        public List<string> SelectNormal(string tabla, List<string> Listacampos, List<string> Listatipodato)
        {
            // funcion para retornar el usuario cuando le demos el id 
            // tabla para hacer el Select
            // listacampos lista que debes de poner los nombres de los campos a buscar
            // lista tipo de dato de los campos a buscar 
            // es un select * from pero sin el asterisco asi: select nombre,apellido los campos que le pidas from tabla
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));

            string s1 = "select ";
            string s2 = "";
            string s3 = "";


            int c_Listacampos = Listacampos.Count;


            for (int x = 0; x < c_Listacampos; x++)
            {


                if (c_Listacampos == x + 1)
                {
                    s3 = Listacampos[x];


                }
                else
                {
                    s3 = Listacampos[x] + ",";


                }


                s2 = s2 + s3;


            }



            string sql = s1 + s2 + " from " + tabla;

            conexion.Open();
            SqlCommand comando = new SqlCommand(sql, conexion);



            SqlDataReader registro = comando.ExecuteReader();

            int contador = 0;

            string dato = "";
            int datoint = 0;
            double datofloat = 0;

            List<string> Listareturn1 = new List<string>();
            List<string> listaglobal = new List<string>();

            while (registro.Read())
            {

                contador = 0;

                for (int x = 0; x < c_Listacampos; x++)
                {

                    if (Listatipodato[contador] == "int")
                    {
                        datoint = (int)(registro[Listacampos[contador]]);
                        dato = Convert.ToString(datoint);

                        Listareturn1.Add(dato);

                    }

                    else if (Listatipodato[contador] == "float")
                    {
                        datofloat = (double)(registro[Listacampos[contador]]);
                        dato = Convert.ToString(datofloat);

                        Listareturn1.Add(dato);
                    }
                    else
                    {
                        dato = (string)(registro[Listacampos[contador]]);


                        Listareturn1.Add(dato);

                    }

                    contador = contador + 1;



                }

            }







            conexion.Close();
            return Listareturn1;








        }

        public List<string> Select(string tabla, List<string> listacampos, List<string> listacamposwhere, List<string> listavaloreswhere, List<string> listatipodatowhere)
        {
            // select normal  con where
            // tabla nombre de la tabla ha afectar
            // listacampos lista para almacenar los nombres de los campos
            // listavalores lista para almacenar los valores de los campos 
            // listatipodato lista para almacenar los tipos de datos de los campos
            string sqlfinal = "";
            string s1 = "select ";

            string s5 = " where ";
            var s3 = "";
            var ss3 = "";
            var s4 = "";
            var ss4 = "";
            var s8 = "";
            var s9 = "";
            var s10 = "";

            int c_listacampos = listacampos.Count;
            int c_listacamposw = listacamposwhere.Count;
            int c_listavaloresw = listavaloreswhere.Count;
            int c_listatipodatow = listatipodatowhere.Count;



            for (int x = 0; x < c_listacampos; x++)
            {


                if (c_listacampos == x + 1)
                {
                    s9 = listacampos[x];

                }
                else
                {
                    s9 = listacampos[x] + ",";


                }


                s10 = s10 + s9;
            }

            for (int x = 0; x < c_listacamposw; x++)
            {

                s3 = listacamposwhere[x] + " = ";

                if (c_listacamposw == x + 1)
                {
                    ss4 = "@" + listacamposwhere[x];
                    s4 = ss4;
                }
                else
                {
                    ss4 = "@" + listacamposwhere[x] + "and";
                    s4 = ss4;

                }


                s8 = s8 + s3 + s4;
            }

            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            conexion.Open();
            sqlfinal = s1 + s10 + "from " + tabla + s5 + s8;
            MessageBox.Show(sqlfinal, sqlfinal);

            SqlCommand comando = new SqlCommand(sqlfinal, conexion);


            List<string> Listacamposr = new List<string>();
            int c_Listacamposr = Listacamposr.Count;

            for (int x = 0; x < c_listacampos; x++)
            {
                Listacamposr.Add("@" + listacampos[x]);
            }

            string valor0;
            int valor;
            for (int x = 0; x < c_listatipodatow; x++)
            {
                if (listatipodatowhere[x] == "int")
                {

                    valor = Int16.Parse(listavaloreswhere[x]);
                    comando.Parameters.AddWithValue(Listacamposr[x], valor);

                }
                else
                {

                    valor0 = listavaloreswhere[x];
                    comando.Parameters.AddWithValue(Listacamposr[x], valor0);
                }
            }

            SqlDataReader registro = comando.ExecuteReader();

            List<string> Listaselect = new List<string>();

            string dato;
            int contador = 0;
            try
            {
                while (registro.Read())
                {
                    dato = (string)registro[listacampos[contador]];
                    Listaselect.Add(dato);
                    contador = contador++;



                }
                return Listaselect;

            }

            catch
            {
                conexion.Close();
                return Listaselect;
            }
            finally
            {
                conexion.Close();
            }




        }
        public string Insert(string tabla, List<string> listacampos, List<string> listavalores, List<string> listatipodato)
        {
            // insert normal sin where 
            // tabla nombre de la tabla ha afectar
            // listacampos lista para almacenar los nombres de los campos
            // listavalores lista para almacenar los valores de los campos a insertar
            // listatipodato lista para almacenar los tipos de datos de los campos
            string sqlfinal = "";
            string s1 = "insert into ";
            string izq = " ( ";
            string der = " ) ";
            string s5 = " values ";
            var s3 = "";
            var ss3 = "";
            var s4 = "";
            var ss4 = "";

            int c_listacampos = listacampos.Count;
            int c_listavalores = listavalores.Count;
            int c_listatipodato = listatipodato.Count;

            for (int x = 0; x < c_listacampos; x++)
            {
                if (c_listacampos == x + 1)
                {
                    s3 = s3 + listacampos[x];
                }
                else
                {
                    ss3 = listacampos[x] + ",";
                    s3 = s3 + ss3;

                }

            }
            for (int x = 0; x < c_listacampos; x++)
            {
                if (c_listacampos == x + 1)
                {
                    ss4 = "@" + listacampos[x];
                    s4 = s4 + ss4;
                }
                else
                {
                    ss4 = "@" + listacampos[x] + ",";
                    s4 = s4 + ss4;

                }

            }
            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            conexion.Open();
            sqlfinal = s1 + tabla + izq + s3 + der + s5 + izq + s4 + der;
            SqlCommand comando = new SqlCommand(sqlfinal, conexion);




            List<string> Listacamposr = new List<string>();
            int c_Listacamposr = Listacamposr.Count;

            for (int x = 0; x < c_listacampos; x++)
            {
                Listacamposr.Add("@" + listacampos[x]);
            }





            string valor0;
            int valor;
            for (int x = 0; x < c_listatipodato; x++)
            {
                if (listatipodato[x] == "int")
                {

                    valor = Int16.Parse(listavalores[x]);
                    comando.Parameters.AddWithValue(Listacamposr[x], valor);

                }
                else
                {

                    valor0 = listavalores[x];
                    comando.Parameters.AddWithValue(Listacamposr[x], valor0);
                }
            }

            comando.ExecuteNonQuery();
            conexion.Close();


            return "1";





        }


        public string Delete(string tabla, List<string> listacampos, List<string> listavalores, List<string> listatipodato)
        {
            // delete normal  con where
            // tabla nombre de la tabla ha afectar
            // listacampos lista para almacenar los nombres de los campos
            // listavalores lista para almacenar los valores de los campos 
            // listatipodato lista para almacenar los tipos de datos de los campos
            string sqlfinal = "";
            string s1 = "delete ";

            string s5 = " where ";
            var s3 = "";
            var ss3 = "";
            var s4 = "";
            var ss4 = "";
            var s8 = "";

            int c_listacampos = listacampos.Count;
            int c_listavalores = listavalores.Count;
            int c_listatipodato = listatipodato.Count;



            for (int x = 0; x < c_listacampos; x++)
            {

                s3 = listacampos[x] + " = ";

                if (c_listacampos == x + 1)
                {
                    ss4 = "@" + listacampos[x];
                    s4 = ss4;
                }
                else
                {
                    ss4 = "@" + listacampos[x] + "and";
                    s4 = ss4;

                }


                s8 = s8 + s3 + s4;
            }

            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            conexion.Open();
            sqlfinal = s1 + tabla + s5 + s8;
            MessageBox.Show(sqlfinal, sqlfinal);

            SqlCommand comando = new SqlCommand(sqlfinal, conexion);


            List<string> Listacamposr = new List<string>();
            int c_Listacamposr = Listacamposr.Count;

            for (int x = 0; x < c_listacampos; x++)
            {
                Listacamposr.Add("@" + listacampos[x]);
            }

            string valor0;
            int valor;
            for (int x = 0; x < c_listatipodato; x++)
            {
                if (listatipodato[x] == "int")
                {

                    valor = Int16.Parse(listavalores[x]);
                    comando.Parameters.AddWithValue(Listacamposr[x], valor);

                }
                else
                {

                    valor0 = listavalores[x];
                    comando.Parameters.AddWithValue(Listacamposr[x], valor0);
                }
            }

            comando.ExecuteNonQuery();
            conexion.Close();


            return "1";


        }

        public string Update(string tabla, List<string> listacampos, List<string> listavalores, List<string> listatipodato, List<string> listacamposwhere, List<string> listacamposwheretipodato, List<string> listavaloreswhere)
        {
            // update normal con where y and o sin and
            // tabla nombre de la tabla ha afectar
            // listacampos lista para almacenar los nombres de los campos
            // listavalores lista para almacenar los valores de los campos 
            // listatipodato lista para almacenar los tipos de datos de los campos

            //listacamposwhere lista para almacenar los campos que contendra el where 
            //listacamposwheretipodato lista para alamacenar los tipos de datos de los campos where
            //listavaloreswhere lista para alamacenar los valores del where

            string sqlfinal = "";
            string s1 = "update ";

            string s5 = " where ";
            var s3 = "";
            var ss3 = "";
            var s4 = "";
            var ss4 = "";
            var s8 = "";
            var s9 = "";
            var s10 = "";
            var s11 = "";
            var s12 = "";

            int c_listacampos = listacampos.Count;
            int c_listavalores = listavalores.Count;
            int c_listatipodato = listatipodato.Count;
            int c_listacamposwhere = listacamposwhere.Count;
            int c_listacamposwheretipodato = listacamposwheretipodato.Count();


            for (int x = 0; x < c_listacampos; x++)
            {

                s3 = listacampos[x] + " = ";

                if (c_listacampos == x + 1)
                {
                    ss4 = "@" + listacampos[x];
                    s4 = ss4;
                }
                else
                {
                    ss4 = "@" + listacampos[x] + ",";
                    s4 = ss4;

                }


                s8 = s8 + s3 + s4;
            }

            for (int x = 0; x < c_listacamposwhere; x++)
            {

                s10 = listacamposwhere[x] + " = ";

                if (c_listacamposwhere == x + 1)
                {
                    s12 = "@" + listacamposwhere[x];
                    s11 = s12;
                }
                else
                {
                    s12 = "@" + listacamposwhere[x] + " and ";
                    s11 = s12;

                }


                s9 = s9 + s10 + s11;
            }

            SqlConnection conexion = new SqlConnection(string.Format("server = {0}; database = PUNTOVENTA; integrated security = true ", servidor));
            conexion.Open();
            sqlfinal = s1 + tabla + " set " + s8 + s5 + s9;


            SqlCommand comando = new SqlCommand(sqlfinal, conexion);


            List<string> Listacamposr = new List<string>();
            int c_Listacamposr = Listacamposr.Count;

            for (int x = 0; x < c_listacampos; x++)
            {
                Listacamposr.Add("@" + listacampos[x]);
            }

            List<string> Listacamposrw = new List<string>();
            int c_Listacamposrw = Listacamposrw.Count;

            for (int x = 0; x < c_listacamposwhere; x++)
            {
                Listacamposrw.Add("@" + listacamposwhere[x]);
            }

            string valor0;
            int valor;
            for (int x = 0; x < c_listatipodato; x++)
            {
                if (listatipodato[x] == "int")
                {

                    valor = Int16.Parse(listavalores[x]);
                    comando.Parameters.AddWithValue(Listacamposr[x], valor);

                }
                else
                {

                    valor0 = listavalores[x];
                    comando.Parameters.AddWithValue(Listacamposr[x], valor0);
                }
            }


            for (int x = 0; x < c_listacamposwheretipodato; x++)
            {
                if (listacamposwheretipodato[x] == "int")
                {

                    valor = Int16.Parse(listavaloreswhere[x]);
                    comando.Parameters.AddWithValue(Listacamposrw[x], valor);

                }
                else
                {

                    valor0 = listavaloreswhere[x];
                    comando.Parameters.AddWithValue(Listacamposrw[x], valor0);
                }
            }

            comando.ExecuteNonQuery();
            conexion.Close();


            return "1";





        }
    }
}
