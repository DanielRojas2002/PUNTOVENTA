using Punto_de_Venta;
using Punto_de_Venta.Clases;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PROVEEDOR;
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
    public partial class reporte_venta : Form
    {
        public reporte_venta()
        {
            InitializeComponent();
        }

        private void reporte_venta_Load(object sender, EventArgs e)
        {

        }

        public float _dineroventas { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView_ventas.Rows.Clear();
            dataGridView_p_credito.Rows.Clear();
            CargarVentas();

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
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarVentas()
        {

            dataGridView_ventas.Rows.Clear();
            dataGridView_p_credito.Rows.Clear();
            _dineroventas = 0;


            txtFechai.Text = FechaInicio.Value.ToString("dd/MM/yyyy");
            txtFechaf.Text = fechafinal.Value.ToString("dd/MM/yyyy");

            dgReportes parametro = new dgReportes
            {
                FechaInicio = Convert.ToDateTime(txtFechai.Text),
                FechaFinal = Convert.ToDateTime(txtFechaf.Text)
            };




            List<dgReportes> lista = c_reportes.LeerReporte(1, parametro);


            if (lista.Count > 0)

            {
                string fechaventa;
                float subtotal;
                foreach (dgReportes d in lista)
                {
                    subtotal = float.Parse(d.SubTotalProducto.ToString());

                    subtotal = (float)Math.Round(subtotal, 2);

                    fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");
                    dataGridView_ventas.Rows.Add(d.Id_Venta.ToString(), d.IdProducto.ToString(), d.NombreProducto.ToString(),
                         d.PrecioProducto.ToString(), d.CantidadProducto.ToString(), Convert.ToString(subtotal), fechaventa, d.DescripcionTipoVenta.ToString(), d.Usuario.ToString());


                    _dineroventas = _dineroventas + float.Parse(d.SubTotalProducto.ToString());
                }


            }

            else
            {



            }

            dgReportes parametro2 = new dgReportes
            {
                FechaInicio = Convert.ToDateTime(txtFechai.Text),
                FechaFinal = Convert.ToDateTime(txtFechaf.Text)
            };




            List<dgReportes> lista2 = c_reportes.LeerReporte(6, parametro2);


            if (lista2.Count > 0)

            {
                string fechaventa;
                float subtotal, cantidadpagada;

                foreach (dgReportes d in lista2)
                {



                    subtotal = float.Parse(d.SubTotalProducto.ToString());

                    subtotal = (float)Math.Round(subtotal, 2);

                    cantidadpagada = float.Parse(d.CantidadPagada.ToString());
                    cantidadpagada = (float)Math.Round(cantidadpagada, 2);

                    fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");
                    dataGridView_p_credito.Rows.Add(d.Id_Venta.ToString(), d.IdProducto.ToString(), d.NombreProducto.ToString(),
                         d.PrecioProducto.ToString(), d.CantidadProducto.ToString(), Convert.ToString(subtotal), Convert.ToString("-"), fechaventa, d.DescripcionTipoVenta.ToString(), d.Usuario.ToString());



                }



            }

            else
            {



            }


            dgReportes parametro3 = new dgReportes
            {
                FechaInicio = Convert.ToDateTime(txtFechai.Text),
                FechaFinal = Convert.ToDateTime(txtFechaf.Text)

            };




            List<dgReportes> lista3 = c_reportes.LeerReporte(8, parametro3);


            if (lista3.Count > 0)

            {
                string fechaventa;
                float subtotal, cantidadpagada;

                foreach (dgReportes d in lista3)
                {


                    fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");
                    dataGridView_p_credito.Rows.Add(d.Id_Venta.ToString(), "-", "-",
                       "-", "-", "-", Convert.ToString(d.CantidadPagada.ToString()), fechaventa, d.DescripcionTipoVenta.ToString(), d.Usuario.ToString());

                    _dineroventas = _dineroventas + float.Parse(d.CantidadPagada.ToString());

                }



            }

            else
            {



            }

            _dineroventas = (float)Math.Round(_dineroventas, 2);

            lbl_cantidad_vendida.Text = Convert.ToString(_dineroventas);
        }
        private void reporte_venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FechaInicio_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_p_credito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
              

                dgReportes parametro = new dgReportes
                {
                    FechaInicio = Convert.ToDateTime(txtFechai.Text),
                    FechaFinal = Convert.ToDateTime(txtFechaf.Text)
                };

                string fechainicio = FechaInicio.Value.ToString("dd/MM/yyyy");
                string fechafinal2 = fechafinal.Value.ToString("dd/MM/yyyy");

                string fechainicio3 = FechaInicio.Value.ToString("dd_MM_yyyy");
                string fechafinal3 = fechafinal.Value.ToString("dd_MM_yyyy");


                List<dgReportes> lista = c_reportes.LeerReporte(1, parametro);

                string ls_archivo_excel = "C:\\C#\\R_Ventas" + fechainicio3 + "_" + fechafinal3 + ".xlsx";
                string fechaentrada;




                var wb = new Excel.XLWorkbook();

                //create 'worksheet' object
                var ws = wb.Worksheets.Add("R_Ventas" + fechainicio3 + "_" + fechafinal3);

                //read cells
                var a = ws.Cell("A1").Value;
                var b = ws.Cell("B1").Value;



                //write cells
                ws.Cell("A1").Value = "FILTROS";
                ws.Cell("G4").Value = "REPORTE DE VENTAS";
                ws.Cell("A2").Value = "FECHA INICIO:";
                ws.Cell("B2").Value = fechainicio;
                ws.Cell("A3").Value = "FECHA FINAL:";
                ws.Cell("B3").Value = fechafinal2;


                ws.Range("A5:G5").Value = "----------------------------------------";


                ws.Cell("A6").Value = "No.Venta";
                ws.Cell("B6").Value = "No.Producto";

                ws.Cell("C6").Value = "Nombre Producto";

                ws.Cell("D6").Value = "Precio";

                ws.Cell("E6").Value = "Cantidad";

                ws.Cell("F6").Value = "SubTotal";

                ws.Cell("G6").Value = "Cantidad Pagada";


                ws.Cell("H6").Value = "FechaVenta";

                ws.Cell("I6").Value = "Tipo Venta";

                ws.Cell("J6").Value = "Usuario";

                ws.Cell("G2").Value = "TOTAL VENTA :";

                ws.Cell("H2").Value = lbl_cantidad_vendida.Text;

                int contadorcolumnas = 1;
                int contadorregistros = 7;
                if (lista.Count > 0)

                {
                    string fechaventa;
                    float subtotal;
                    foreach (dgReportes d in lista)
                    {
                        subtotal = float.Parse(d.SubTotalProducto.ToString());

                        subtotal = (float)Math.Round(subtotal, 2);

                        fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");




                        contadorcolumnas = 1;
                        fechaentrada = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");




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
                        ws.Cell(contadorregistros, contadorcolumnas).Value = "";
                        contadorcolumnas = contadorcolumnas + 1;
                        ws.Cell(contadorregistros, contadorcolumnas).Value = fechaventa;
                        contadorcolumnas = contadorcolumnas + 1;
                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.DescripcionTipoVenta.ToString();
                        contadorcolumnas = contadorcolumnas + 1;
                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.Usuario.ToString();




                        contadorregistros = contadorregistros + 1;

                    }


                }



                dgReportes parametro2 = new dgReportes
                {
                    FechaInicio = Convert.ToDateTime(txtFechai.Text),
                    FechaFinal = Convert.ToDateTime(txtFechaf.Text)
                };




                List<dgReportes> lista2 = c_reportes.LeerReporte(6, parametro2);


                if (lista2.Count > 0)

                {
                    string fechaventa;
                    float subtotal, cantidadpagada;

                    foreach (dgReportes d in lista2)
                    {



                        subtotal = float.Parse(d.SubTotalProducto.ToString());

                        subtotal = (float)Math.Round(subtotal, 2);

                        cantidadpagada = float.Parse(d.CantidadPagada.ToString());
                        cantidadpagada = (float)Math.Round(cantidadpagada, 2);




                        fechaentrada = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");


                        contadorcolumnas = 1;

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
                        ws.Cell(contadorregistros, contadorcolumnas).Value = "";
                        contadorcolumnas = contadorcolumnas + 1;
                        ws.Cell(contadorregistros, contadorcolumnas).Value = fechaentrada;
                        contadorcolumnas = contadorcolumnas + 1;
                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.DescripcionTipoVenta.ToString();
                        contadorcolumnas = contadorcolumnas + 1;
                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.Usuario.ToString();




                        contadorregistros = contadorregistros + 1;


                    }



                }


                dgReportes parametro3 = new dgReportes
                {
                    FechaInicio = Convert.ToDateTime(txtFechai.Text),
                    FechaFinal = Convert.ToDateTime(txtFechaf.Text)

                };




                List<dgReportes> lista3 = c_reportes.LeerReporte(8, parametro3);


                if (lista3.Count > 0)

                {
                    string fechaventa;
                    float subtotal, cantidadpagada;

                    foreach (dgReportes d in lista3)
                    {


                        fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");




                        contadorcolumnas = 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.Id_Venta.ToString();

                        contadorcolumnas = 6;


                        contadorcolumnas = contadorcolumnas + 1;
                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadPagada.ToString();

                        contadorcolumnas = contadorcolumnas + 1;
                        ws.Cell(contadorregistros, contadorcolumnas).Value = fechaventa;

                        contadorcolumnas = contadorcolumnas + 1;
                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.DescripcionTipoVenta.ToString();

                        contadorcolumnas = contadorcolumnas + 1;
                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.Usuario.ToString();


                        contadorregistros = contadorregistros + 1;



                    }



                }


                wb.SaveAs(ls_archivo_excel);
                MessageBox.Show("Excel Reportado Satisfactoriamente en : " + ls_archivo_excel);
            }

            catch
            {
                MessageBox.Show("Genere antes el Reporte antes de Exportarlo al Excel");
            }
            





        }
    }
}
