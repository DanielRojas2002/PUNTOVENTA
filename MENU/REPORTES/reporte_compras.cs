﻿using Punto_de_Venta;
using Punto_de_Venta.Clases;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.MENU.REPORTES
{
    public partial class reporte_compras : Form
    {
        public reporte_compras()
        {
            InitializeComponent();
        }

        private void RegresarVentana()
        {

            string id;
            id = lbl_id.Text;

            string retorno = "", retorno2 = "";

            dgUsuario parametro2 = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)

            };



            List<dgUsuario> lista = c_usuario.LeerUsuario(2, parametro2);

            if (lista.Count > 0)

            {

                foreach (dgUsuario d in lista)
                {
                    retorno = Convert.ToString(d.Usuario.ToString());
                }


            }



            dgUsuario parametro3 = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)

            };



            List<dgUsuario> lista2 = c_usuario.LeerUsuario(3, parametro3);

            if (lista.Count > 0)

            {

                foreach (dgUsuario d in lista2)
                {
                    retorno2 = Convert.ToString(d.DescripcionPerfil.ToString());
                }


            }

            this.Hide();
            Inicio formulario = new Inicio();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();





        }

        private void CargaCategoria()
        {
            dgCategoria parametro = new dgCategoria
            {

            };

            List<dgCategoria> lista = c_categoria.LeerCategoria(1, parametro);


            if (lista.Count > 0)

            {

                string concatenacion = "";
                foreach (dgCategoria d in lista)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Categoria.ToString() + " " + d.Descripcion.ToString();

                    bx_categoria.Items.Add(concatenacion);
                }
            }
        }
        private void reporte_compras_Load(object sender, EventArgs e)
        {
            CargaCategoria();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
        }

        private void reporte_compras_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtFechai.Text = FechaInicio.Value.ToString("dd/MM/yyyy");
            txtFechaf.Text = fechafinal.Value.ToString("dd/MM/yyyy");

            dgReportes parametro = new dgReportes();

            if (bx_categoria.Text!=""  && bx_productos.Text!="")
            {

                parametro.FechaInicio = Convert.ToDateTime(txtFechai.Text);
                parametro.FechaFinal = Convert.ToDateTime(txtFechaf.Text);

                parametro.IdCategoria = Convert.ToInt16(lbl_id_categoria.Text);
                parametro.IdProducto = Convert.ToInt16(lbl_id_producto.Text);

               
            }

            else if (bx_categoria.Text != "" && bx_productos.Text == "")
            {

                parametro.FechaInicio = Convert.ToDateTime(txtFechai.Text);
                parametro.FechaFinal = Convert.ToDateTime(txtFechaf.Text);

                parametro.IdCategoria = Convert.ToInt16(lbl_id_categoria.Text);
                parametro.IdProducto = 0;

               

            }

            else
            {

                parametro.FechaInicio = Convert.ToDateTime(txtFechai.Text);
                parametro.FechaFinal = Convert.ToDateTime(txtFechaf.Text);

                parametro.IdCategoria = 0;
                parametro.IdProducto = 0;

              
            }


           




            List<dgReportes> lista = c_reportes.LeerReporte(2, parametro);


            if (lista.Count > 0)

            {
                string fechaentrada;
                foreach (dgReportes d in lista)
                {

                    fechaentrada = d.FechaEntrada.Value.ToString("dd/MM/yyyy");
                    dataGridView1.Rows.Add(d.IdEntrada.ToString(), d.IdProducto.ToString(), d.NombreProducto.ToString(),
                       d.Categoria.ToString(), d.CantidadProducto.ToString(), fechaentrada, d.Usuario.ToString());



                }

            }

            else
            {

                MessageBox.Show("No se encontró reporte de compras con los filtros seleccionado");

            }
        }
        private void CargaProductos(string idcategoria)
        {
            bx_productos.Items.Clear();
            dgProducto parametro = new dgProducto
            {
                Id_Categoria=Convert.ToInt16(idcategoria)
            };

            List<dgProducto> lista = c_producto.LeerProducto(13, parametro);


            if (lista.Count > 0)

            {

                string concatenacion = "";
                foreach (dgProducto d in lista)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Producto.ToString() + " " + d.Nombre.ToString();

                    bx_productos.Items.Add(concatenacion);
                }
            }
        }
        private void bx_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            string concatenacion = bx_categoria.Text;
            string[] words = concatenacion.Split(' ');
            string descripcion, idcategoria;
            idcategoria = words[0];
            descripcion = words[1];

            lbl_id_categoria.Text = idcategoria;

            CargaProductos(idcategoria);

        }

        private void bx_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string concatenacion = bx_productos.Text;
            string[] words = concatenacion.Split(' ');
            string descripcion, idproducto;
            idproducto = words[0];
            descripcion = words[1];

            lbl_id_producto.Text = idproducto;

      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<List<string>> ListadeListas = new List<List<string>>();
           

            List<string> ListaDatos = new List<string>();


            string v1 = "";
            string v2 = "";
            string v3 = "";
            string v4 = "";
            string v5 = "";
            string v6 = "";
            string v7 = "";





            for (int fila = 0; fila < dataGridView1.Rows.Count - 1; fila++)
            {
                for (int col = 0; col < dataGridView1.Rows[fila].Cells.Count; col++)
                {
                    string valor = dataGridView1.Rows[fila].Cells[col].Value.ToString();
                   


                    ListaDatos.Add(valor);
                  

                   
                }
                ListadeListas.Add(ListaDatos);
                ListaDatos.Clear();
            }
           


            string fechainicio, fechafinal2;

          

            fechainicio = FechaInicio.Value.ToString("dd_MM_yyyy");
            fechafinal2 = fechafinal.Value.ToString("dd_MM_yyyy");



            //foreach (string list in ListadeListas)
            //{
            //    MessageBox.Show(list);
                
              

            //}

            string control = "";
            string ls_archivo_excel = "C:\\C#\\R_Compras"+fechainicio+"_"+fechafinal2 + ".xlsx";
            control = c_excel.ReporteCompras(ls_archivo_excel,fechainicio,fechafinal2, ListadeListas);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
