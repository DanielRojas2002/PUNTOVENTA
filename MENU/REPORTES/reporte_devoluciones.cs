using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Punto_de_Venta;
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
    public partial class reporte_devoluciones : Form
    {
        public reporte_devoluciones()
        {
            InitializeComponent();
            Fechadevolucion.Value = DateTime.Now;
        }

        public float _dinerodevolucion { get; set; }

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
            menu_reportes formulario = new menu_reportes();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();





        }

        private void reporte_devoluciones_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            _dinerodevolucion = 0;
            dataGridView_devoluciones.Rows.Clear();

            CargarDevoluciones();
        }

        private void CargarDevoluciones()
        {

            dataGridView_devoluciones.Rows.Clear();

            try
            {




                txtFechai.Text = Fechadevolucion.Value.ToString("dd/MM/yyyy");




                dgReportes parametro = new dgReportes
                {
                    FechaInicio = Convert.ToDateTime(txtFechai.Text)

                };




                List<dgReportes> lista = c_reportes.LeerReporte(44, parametro);


                if (lista.Count > 0)

                {
                    string fechadevolucion;
                    float subtotal;
                    foreach (dgReportes d in lista)
                    {


                        subtotal = float.Parse(d.SubTotalProducto.ToString());
                        subtotal = (float)Math.Round(subtotal, 2);

                        fechadevolucion = d.FechaInicio.Value.ToString("dd/MM/yyyy");
                        dataGridView_devoluciones.Rows.Add(d.IdDevolucion.ToString(), d.Id_Venta.ToString(), d.NombreProducto.ToString(),
                             d.PrecioVenta.ToString(), d.CantidadPagada.ToString(), subtotal, d.Usuario.ToString(), fechadevolucion);


                        _dinerodevolucion = _dinerodevolucion + subtotal;
                    }


                }

                else
                {
                    MessageBox.Show("No se Encontraron Devoluciones en el dia seleccionado");


                }

                lbl_devolucion.Text = Convert.ToString(_dinerodevolucion);

            }
            catch
            {

                MessageBox.Show("Error en  Fechas");

            }


        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {



            string fechainicio = Fechadevolucion.Value.ToString("dd/MM/yyyy");
           

            string fechainicio3 = Fechadevolucion.Value.ToString("dd_MM_yyyy");
           

           
            string ls_archivo_excel = "C:\\C#\\R_Devolucion" + fechainicio3  + ".xlsx";


            int contadorcolumnas = 1;
            int contadorregistros = 7;

            var wb = new Excel.XLWorkbook();

            //create 'worksheet' object
            var ws = wb.Worksheets.Add("R_Devolucion" + fechainicio3 );

            //read cells
            var a = ws.Cell("A1").Value;
            var b = ws.Cell("B1").Value;



            //write cells
            ws.Cell("A1").Value = "FILTROS";
            ws.Cell("G4").Value = "REPORTE DE DEVOLUCIONES";
            ws.Cell("A2").Value = "FECHA INICIO:";
            ws.Cell("B2").Value = fechainicio;
          

            ws.Range("A5:G5").Value = "----------------------------------------";


            ws.Cell("A6").Value = "No.Devolucion";
            ws.Cell("B6").Value = "No.Venta";

            ws.Cell("C6").Value = "No.Producto";

            ws.Cell("D6").Value = "Nombre Producto";

            ws.Cell("E6").Value = "Precio";

            ws.Cell("F6").Value = "Cantidad";




            ws.Cell("G6").Value = "Subtotal";

            ws.Cell("H6").Value = "Usuario";

            ws.Cell("I6").Value = "FechaDevolucion";


            ws.Cell("G2").Value = "TOTAL DEVOLUCION :" +_dinerodevolucion  ;



            dgReportes parametrodevoluciones = new dgReportes
            {
                FechaInicio = Convert.ToDateTime(txtFechai.Text),
                FechaFinal = Convert.ToDateTime(txtFechai.Text)
            };




            List<dgReportes> listadevoluciones = c_reportes.LeerReporte(9, parametrodevoluciones);





            if (listadevoluciones.Count > 0)

            {
                string fechadevolucion;
                float subtotal;
                foreach (dgReportes d in listadevoluciones)
                {
                    subtotal = float.Parse(d.SubTotalProducto.ToString());

                    subtotal = (float)Math.Round(subtotal, 2);

                    fechadevolucion = d.FechaDevolucion.Value.ToString("dd/MM/yyyy");

                    contadorcolumnas = 1;

                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.Id_Devolucion.ToString();
                    contadorcolumnas = contadorcolumnas + 1;

                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.Id_Venta.ToString();
                    contadorcolumnas = contadorcolumnas + 1;

                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.IdProducto.ToString();
                    contadorcolumnas = contadorcolumnas + 1;

                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.NombreProducto.ToString();
                    contadorcolumnas = contadorcolumnas + 1;

                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.PrecioProducto.ToString();
                    contadorcolumnas = contadorcolumnas + 1;

                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadProducto.ToString();
                    contadorcolumnas = contadorcolumnas + 1;

                    ws.Cell(contadorregistros, contadorcolumnas).Value = subtotal;
                    contadorcolumnas = contadorcolumnas + 1;

                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.Usuario.ToString();
                    contadorcolumnas = contadorcolumnas + 1;

                    ws.Cell(contadorregistros, contadorcolumnas).Value = Convert.ToString(fechadevolucion);




                    contadorregistros = contadorregistros + 1;
                }


            }

            else
            {



            }



            wb.SaveAs(ls_archivo_excel);
            MessageBox.Show("Excel Reportado Satisfactoriamente en : " + ls_archivo_excel);

        }

        private void reporte_devoluciones_Load(object sender, EventArgs e)
        {

        }
    }
}
