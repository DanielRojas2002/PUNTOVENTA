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
    public partial class reporte_caja : Form
    {
        public reporte_caja()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reporte_caja_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void reporte_caja_Load(object sender, EventArgs e)
        {

        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            dataGridView_caja.Rows.Clear();

            CargarCaja();
        }

        private void CargarCaja()
        {

            dataGridView_caja.Rows.Clear();

            try
            {




                txtFechai.Text = Fechacaja.Value.ToString("dd/MM/yyyy");
              



                dgReportes parametro = new dgReportes
                {
                    FechaCaja = Convert.ToDateTime(txtFechai.Text)
                  
                };




                List<dgReportes> lista = c_reportes.LeerReporte(4, parametro);


                if (lista.Count > 0)

                {
                    string fechacaja;
                  
                    foreach (dgReportes d in lista)
                    {
                       

                        fechacaja = d.FechaCaja.Value.ToString("dd/MM/yyyy");
                        dataGridView_caja.Rows.Add(d.IdCaja.ToString(), d.CantidadVenta.ToString(), d.CantidadAbonada.ToString(),
                             d.CantidadDevolucion.ToString(), d.CantidadRetirada.ToString(), d.CantidadTotal.ToString(), fechacaja, d.DescripcionCaja.ToString());


                        
                    }


                }

                else
                {
                    MessageBox.Show("No se Encontro Caja en el dia seleccionado");


                }

            }
            catch
            {


                txtFechai.Text = Fechacaja.Value.ToString("");
               

                string fechadiferenteinicio = txtFechai.Text;
                string[] words = fechadiferenteinicio.Split('/');
                string dia, mes, ano;

                mes = words[0];
                dia = words[1];
                ano = words[2];


                txtFechai.Text = dia + "/" + mes + "/" + ano;


             



                dgReportes parametro = new dgReportes
                {
                    FechaCaja = Convert.ToDateTime(txtFechai.Text),
                   
                };




                List<dgReportes> lista = c_reportes.LeerReporte(4, parametro);


                if (lista.Count > 0)

                {
                    string fechacaja;

                    foreach (dgReportes d in lista)
                    {


                        fechacaja = d.FechaCaja.Value.ToString("dd/MM/yyyy");
                        dataGridView_caja.Rows.Add(d.IdCaja.ToString(), d.CantidadAbonada.ToString(), d.CantidadVenta.ToString(),
                             d.CantidadRetirada.ToString(), d.CantidadTotal.ToString(), fechacaja, d.DescripcionCaja.ToString());



                    }


                }

                else
                {
                    MessageBox.Show("No se Encontro Caja en el dia seleccionado");
                }

             


            }


        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
           

            try
            {
               

                string fechainicio = Fechacaja.Value.ToString("dd/MM/yyyy");
              

                string fechainicio3 = Fechacaja.Value.ToString("dd_MM_yyyy");
               



                string ls_archivo_excel = "C:\\C#\\R_Caja" + fechainicio3  + ".xlsx";
                string fechaentrada;




                var wb = new Excel.XLWorkbook();

                //create 'worksheet' object
                var ws = wb.Worksheets.Add("R_Caja" + fechainicio3 );

                //read cells
                var a = ws.Cell("A1").Value;
                var b = ws.Cell("B1").Value;



                //write cells
                ws.Cell("A1").Value = "FILTROS";
                ws.Cell("G4").Value = "REPORTE DE CAJA";
                ws.Cell("A2").Value = "FECHA INICIO:";
                ws.Cell("B2").Value = fechainicio;
                

                ws.Range("A5:G5").Value = "----------------------------------------";


                ws.Cell("A6").Value = "No.Caja";
                ws.Cell("B6").Value = "Venta";

                ws.Cell("C6").Value = "Abonado";

                ws.Cell("D6").Value = "Devolucion";


                ws.Cell("E6").Value = "Retirado";


                ws.Cell("F6").Value = "Cantidad Total";

                ws.Cell("G6").Value = "Fecha Caja";

                ws.Cell("H6").Value = "Descripcion Caja";



                txtFechai.Text = Fechacaja.Value.ToString("dd/MM/yyyy");


                int contadorcolumnas = 1;
                int contadorregistros = 7;

                dgReportes parametro = new dgReportes
                {
                    FechaCaja = Convert.ToDateTime(txtFechai.Text)

                };




                List<dgReportes> lista = c_reportes.LeerReporte(4, parametro);

                contadorregistros = contadorregistros + 1;

                if (lista.Count > 0)

                {
                    string fechacaja;

                    foreach (dgReportes d in lista)
                    {

                        contadorcolumnas = 1;

                        fechacaja = d.FechaCaja.Value.ToString("dd/MM/yyyy");
                       
                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.IdCaja.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadVenta.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadAbonada.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadDevolucion.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadRetirada.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadTotal.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = fechacaja;
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.DescripcionCaja.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        contadorregistros = contadorregistros + 1;

                    }


                }

                else
                {
                    MessageBox.Show("No se Encontro Caja en el dia seleccionado");


                }

                wb.SaveAs(ls_archivo_excel);
                MessageBox.Show("Excel Reportado Satisfactoriamente en : " + ls_archivo_excel);

            }
            catch
            {


                txtFechai.Text = Fechacaja.Value.ToString("");


                string fechadiferenteinicio = txtFechai.Text;
                string[] words = fechadiferenteinicio.Split('/');
                string dia, mes, ano;

                mes = words[0];
                dia = words[1];
                ano = words[2];


                txtFechai.Text = dia + "/" + mes + "/" + ano;








                string ls_archivo_excel = "C:\\C#\\R_Caja" + txtFechai.Text + ".xlsx";
               



                var wb = new Excel.XLWorkbook();

                //create 'worksheet' object
                var ws = wb.Worksheets.Add("R_Caja" + txtFechai.Text);

                //read cells
                var a = ws.Cell("A1").Value;
                var b = ws.Cell("B1").Value;



                //write cells
                ws.Cell("A1").Value = "FILTROS";
                ws.Cell("G4").Value = "REPORTE DE CAJA";
                ws.Cell("A2").Value = "FECHA INICIO:";
                ws.Cell("B2").Value = txtFechai.Text;


                ws.Range("A5:G5").Value = "----------------------------------------";


                ws.Cell("A6").Value = "No.Caja";
                ws.Cell("B6").Value = "Venta";

                ws.Cell("C6").Value = "Abonado";

                ws.Cell("D6").Value = "Devolucion";


                ws.Cell("E6").Value = "Retirado";


                ws.Cell("F6").Value = "Cantidad Total";

                ws.Cell("G6").Value = "Fecha Caja";

                ws.Cell("H6").Value = "Descripcion Caja";



                txtFechai.Text = Fechacaja.Value.ToString("dd/MM/yyyy");


                int contadorcolumnas = 1;
                int contadorregistros = 7;



                dgReportes parametro = new dgReportes
                {
                    FechaCaja = Convert.ToDateTime(txtFechai.Text),

                };




                List<dgReportes> lista = c_reportes.LeerReporte(4, parametro);


                if (lista.Count > 0)

                {
                    string fechacaja;

                    foreach (dgReportes d in lista)
                    {


                        contadorcolumnas = 1;

                        fechacaja = d.FechaCaja.Value.ToString("dd/MM/yyyy");

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.IdCaja.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadVenta.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadAbonada.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadDevolucion.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadRetirada.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadTotal.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = fechacaja;
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = d.DescripcionCaja.ToString();
                        contadorcolumnas = contadorcolumnas + 1;

                        contadorregistros = contadorregistros + 1;



                    }


                }

                else
                {
                    MessageBox.Show("No se Encontro Caja en el dia seleccionado");
                }

                wb.SaveAs(ls_archivo_excel);
                MessageBox.Show("Excel Reportado Satisfactoriamente en : " + ls_archivo_excel);


            }
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
    }
}
