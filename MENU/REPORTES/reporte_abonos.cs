using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = ClosedXML.Excel;

namespace PUNTOVENTA.MENU.REPORTES
{
    public partial class reporte_abonos : Form
    {
        public reporte_abonos()
        {
            InitializeComponent();

            lbl_totaldeuda.Text = "";
            lbl_cantidad_vendida.Text = "";
        }

        public float _dineroventas = 0; 

        

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
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
        }

        private void btn_abono_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_abonos.Rows.Clear();
                _dineroventas = 0;
                if (txt_ticket.Text != "")
                {


                  

                    dgReportes parametro = new dgReportes
                    {
                        Id_Venta = Convert.ToInt16(txt_ticket.Text),
                       
                    };




                    List<dgReportes> lista = c_reportes.LeerReporte(10, parametro);

                 
                    if (lista.Count > 0)

                    {
                        string fechapago;
                        float cantidadpago;

                        foreach (dgReportes d in lista)
                        {
                            cantidadpago = float.Parse(d.CantidadPagada.ToString());

                            cantidadpago = (float)Math.Round(cantidadpago, 2);



                            fechapago = d.FechaPago.Value.ToString("dd/MM/yyyy");
                            dataGridView_abonos.Rows.Add(d.IdPago.ToString(), d.NombreCliente.ToString(), d.Id_Venta.ToString(),d.DescripcionAbono.ToString(), Convert.ToString(cantidadpago), fechapago);



                            _dineroventas = _dineroventas + cantidadpago;

                            _dineroventas = (float)Math.Round(_dineroventas, 2);

                           

                        }
                        lbl_cantidad_vendida.Text = Convert.ToString(_dineroventas);


                        dgReportes parametro1 = new dgReportes
                        {
                            Id_Venta = Convert.ToInt16(txt_ticket.Text),

                        };




                        List<dgReportes> lista1 = c_reportes.LeerReporte(11, parametro1);


                        if (lista1.Count > 0)

                        {

                            foreach (dgReportes dd in lista1)
                            {
                                lbl_totaldeuda.Text = Convert.ToString(dd.Total.ToString());
                            }


                        }


                    }

                    else
                    {
                        dataGridView_abonos.Rows.Clear();
                        MessageBox.Show("No se a Abonado a este ticket o este ticket no es de Credito");
                        txt_ticket.Text = "";
                        lbl_totaldeuda.Text = "";
                        lbl_cantidad_vendida.Text = "";
                    }
                }

                else
                {
                    dataGridView_abonos.Rows.Clear();
                    lbl_cantidad_vendida.Text = "";
                    lbl_totaldeuda.Text = "";
                    MessageBox.Show("Ingrese el Numero de Ticket");
                    txt_ticket.Text = "";
                }
            }
            catch
            {
                dataGridView_abonos.Rows.Clear();
                lbl_cantidad_vendida.Text = "";
                
                lbl_totaldeuda.Text = "";
                MessageBox.Show("Respete la sintaxis");
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reporte_abonos_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void reporte_abonos_Load(object sender, EventArgs e)
        {

        }

        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            if (lbl_cantidad_vendida.Text!="")
            {
                try
                {


                

                    string ls_archivo_excel = "C:\\C#\\R_Abonos" + txt_ticket.Text + ".xlsx";
                    string fechaentrada;




                    var wb = new Excel.XLWorkbook();

                    //create 'worksheet' object
                    var ws = wb.Worksheets.Add("R_Abonos" + txt_ticket.Text);

                    //read cells




                    //write cells
                    ws.Cell("A1").Value = "FILTROS";
                    ws.Cell("C4").Value = "REPORTE DE ABONOS";
                    ws.Cell("A2").Value = "Ticket::";
                    ws.Cell("B2").Value = txt_ticket.Text;



                    ws.Range("A5:G5").Value = "----------------------------------------";


                    ws.Cell("A6").Value = "Id.Pago";
                    ws.Cell("B6").Value = "Cliente";

                    ws.Cell("C6").Value = "Id Venta";

                    ws.Cell("D6").Value = "Abono";

                    ws.Cell("E6").Value = "Fecha Abono";




                    int contadorcolumnas = 1;
                    int contadorregistros = 7;


                    dgReportes parametro = new dgReportes
                    {
                        Id_Venta = Convert.ToInt16(txt_ticket.Text),

                    };




                    List<dgReportes> lista = c_reportes.LeerReporte(10, parametro);


                    if (lista.Count > 0)

                    {
                        string fechapago;
                        float cantidadpago;

                        foreach (dgReportes d in lista)
                        {
                            contadorcolumnas = 1;
                            fechapago = d.FechaPago.Value.ToString("dd/MM/yyyy");

                            ws.Cell(contadorregistros, contadorcolumnas).Value = d.IdPago.ToString();
                            contadorcolumnas = contadorcolumnas + 1;

                            ws.Cell(contadorregistros, contadorcolumnas).Value = d.NombreCliente.ToString();
                            contadorcolumnas = contadorcolumnas + 1;

                            ws.Cell(contadorregistros, contadorcolumnas).Value = d.Id_Venta.ToString();
                            contadorcolumnas = contadorcolumnas + 1;

                            ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadPagada.ToString();
                            contadorcolumnas = contadorcolumnas + 1;

                            ws.Cell(contadorregistros, contadorcolumnas).Value = fechapago;
                            contadorcolumnas = contadorcolumnas + 1;


                            contadorregistros = contadorregistros + 1;


                        }
                        lbl_cantidad_vendida.Text = Convert.ToString(_dineroventas);


                        dgReportes parametro1 = new dgReportes
                        {
                            Id_Venta = Convert.ToInt16(txt_ticket.Text),

                        };




                        List<dgReportes> lista1 = c_reportes.LeerReporte(11, parametro1);


                        if (lista1.Count > 0)

                        {

                            foreach (dgReportes dd in lista1)
                            {
                                ws.Cell("C3").Value = "Cantidad Deuda";
                                ws.Cell("D3").Value = Convert.ToString(dd.Total.ToString());
                              
                            }


                        }

                        ws.Cell("F3").Value = "Cantidad Abonada";
                        ws.Cell("G3").Value = lbl_cantidad_vendida.Text;


                    }

                    else
                    {
                        dataGridView_abonos.Rows.Clear();
                        MessageBox.Show("No se a Abonado a este ticket o este ticket no es de Credito");
                        txt_ticket.Text = "";
                        lbl_totaldeuda.Text = "";
                        lbl_cantidad_vendida.Text = "";
                    }




                    wb.SaveAs(ls_archivo_excel);
                    MessageBox.Show("Excel Reportado Satisfactoriamente en : " + ls_archivo_excel);
                }

                catch
                {
                    MessageBox.Show("Genere antes el Reporte antes de Exportarlo al Excel");
                }
            }
            else
            {
                MessageBox.Show("Debe de hacer la busqueda primero");
            }
        }
    }
}
