using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Punto_de_Venta;
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
using Excel = ClosedXML.Excel;

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

            
            txtFechai.Text = FechaInicio.Value.ToString("dd/MM/yyyy");
            txtFechaf.Text = fechafinal.Value.ToString("dd/MM/yyyy");

            dgReportes parametro = new dgReportes();

            if (bx_categoria.Text != "" && bx_productos.Text != "")
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




            string fechainicio, fechafinal2;

          

            fechainicio = FechaInicio.Value.ToString("dd/MM/yyyy");
            fechafinal2 = fechafinal.Value.ToString("dd/MM/yyyy");

            string fechainicio3 = FechaInicio.Value.ToString("dd_MM_yyyy");
            string fechafinal3 = fechafinal.Value.ToString("dd_MM_yyyy");

            List<dgReportes> lista = c_reportes.LeerReporte(2, parametro);


            if (lista.Count > 0)

            {
                string ls_archivo_excel = "C:\\C#\\R_Compras" + fechainicio3 + "_" + fechafinal3 + ".xlsx";
                string fechaentrada;

                //Ruta del fichero Excel
                int contadorregistros = 7;

                var wb = new Excel.XLWorkbook();

                //create 'worksheet' object
                var ws = wb.Worksheets.Add("R_Compras" + fechainicio3 + "_" + fechafinal3);

                //read cells
                var a = ws.Cell("A1").Value;
                var b = ws.Cell("B1").Value;



                //write cells
                ws.Cell("A1").Value = "FILTROS";
                ws.Cell("G4").Value = "REPORTE COMPRAS ENTRADA";
                ws.Cell("A2").Value = "FECHA INICIO:";
                ws.Cell("B2").Value = fechainicio;
                ws.Cell("A3").Value = "FECHA FINAL:";
                ws.Cell("B3").Value = fechafinal2;

                ws.Cell("D2").Value = "CATEGORIA:";
                ws.Cell("D3").Value = "PRODUCTO:";

                ws.Cell("E2").Value = bx_categoria.Text;
                ws.Cell("E3").Value = bx_productos.Text;
                ws.Range("A5:G5").Value = "----------------------------------------";


                ws.Cell("A6").Value = "No.Entrada";
                ws.Cell("B6").Value = "No.Producto";

                ws.Cell("C6").Value = "Nombre Producto";

                ws.Cell("D6").Value = "Categoria";

                ws.Cell("E6").Value = "Cantidad";

                ws.Cell("F6").Value = "Fecha Entrada";

                ws.Cell("G6").Value = "Usuario";

                int contadorcolumnas = 1;

                foreach (dgReportes d in lista)
                {

                    contadorcolumnas = 1;
                    fechaentrada = d.FechaEntrada.Value.ToString("dd/MM/yyyy");
                   


                
                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.IdEntrada.ToString();
                    contadorcolumnas = contadorcolumnas + 1;
                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.IdProducto.ToString();
                    contadorcolumnas = contadorcolumnas + 1;
                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.NombreProducto.ToString();
                    contadorcolumnas = contadorcolumnas + 1;
                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.Categoria.ToString();
                    contadorcolumnas = contadorcolumnas + 1;
                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadProducto.ToString();
                    contadorcolumnas = contadorcolumnas + 1;
                    ws.Cell(contadorregistros, contadorcolumnas).Value = fechaentrada;
                    contadorcolumnas = contadorcolumnas + 1;

                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.Usuario.ToString();



                    contadorregistros = contadorregistros + 1;






                }

                wb.SaveAs(ls_archivo_excel);
                MessageBox.Show("Excel Reportado Satisfactoriamente en : "+ ls_archivo_excel);


            }

            else
            {

                MessageBox.Show("Genere antes el Reporte antes de Exportarlo al Excel");

            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
