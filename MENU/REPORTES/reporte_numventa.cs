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
    public partial class reporte_numventa : Form
    {
        public reporte_numventa()
        {
            InitializeComponent();

            label10.Text = "";
            dataGridView_devoluciones.Visible = false;
        }

        public float _dineroventas = 0;


        private void btn_ticket_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_numventa.Rows.Clear();
                _dineroventas = 0;
                if (txt_ticket.Text != "")
                {
                    dgReportes parametro = new dgReportes
                    {
                        Id_Venta = Convert.ToInt16(txt_ticket.Text)

                    };




                    List<dgReportes> lista = c_reportes.LeerReporte(5, parametro);

                    string escredito = "";
                    if (lista.Count > 0)

                    {
                        string fechaventa;
                        float subtotal;

                        foreach (dgReportes d in lista)
                        {
                            subtotal = float.Parse(d.SubTotalProducto.ToString());

                            subtotal = (float)Math.Round(subtotal, 2);



                            fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");
                            dataGridView_numventa.Rows.Add(d.Id_Venta.ToString(), d.IdProducto.ToString(), d.NombreProducto.ToString(),
                                 d.PrecioProducto.ToString(), d.CantidadProducto.ToString(), Convert.ToString(subtotal), fechaventa, d.DescripcionTipoVenta.ToString());



                            _dineroventas = _dineroventas + subtotal;

                            _dineroventas = (float)Math.Round(_dineroventas, 2);

                            escredito = d.DescripcionTipoVenta.ToString();

                        }
                        if (escredito == "Credito")
                        {
                            label10.Text = "";
                            dataGridView_devoluciones.Visible = false;
                            lbl_cantidad_vendida.Text = Convert.ToString(_dineroventas);
                        }
                        else
                        {
                            label10.Text = "DEVOLUCIONES";
                            dataGridView_devoluciones.Visible = true;
                            CargaDevoluiones();
                        }

                    }

                    else
                    {
                        dataGridView_numventa.Rows.Clear();
                        MessageBox.Show("No se Encontro el Numero de Venta");
                        txt_ticket.Text = "";
                        dataGridView_devoluciones.Rows.Clear();
                        lbl_cantidad_vendida.Text = "";
                    }
                }

                else
                {
                    dataGridView_devoluciones.Rows.Clear();
                    lbl_cantidad_vendida.Text = "";
                    dataGridView_numventa.Rows.Clear();
                    MessageBox.Show("Ingrese el Numero de Ticket");
                    txt_ticket.Text = "";
                }
            }
            catch
            {
                dataGridView_devoluciones.Rows.Clear();
                lbl_cantidad_vendida.Text = "";
                dataGridView_numventa.Rows.Clear();
                MessageBox.Show("Respete la sintaxis");
            }
           
        }

        private void reporte_numventa_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void reporte_numventa_Load(object sender, EventArgs e)
        {

        }

        private void CargaDevoluiones()
        {

            dataGridView_devoluciones.Rows.Clear();


            dgCaja parametro = new dgCaja
            {
                Id_Venta = Convert.ToInt16(txt_ticket.Text)

            };




            List<dgCaja> lista = c_caja.LeerCaja(10, parametro);


            if (lista.Count > 0)

            {
                string fechadevolucion;
                float subtotal;
                foreach (dgCaja d in lista)
                {
                    subtotal = float.Parse(d.SubTotalProducto.ToString());

                    subtotal = (float)Math.Round(subtotal, 2);

                    fechadevolucion = d.FechaDevolucion.Value.ToString("dd/MM/yyyy");
                    dataGridView_devoluciones.Rows.Add(d.Id_Devolucion.ToString(), d.Id_Venta.ToString(), d.IdProducto.ToString(), d.NombreProducto.ToString(),
                         d.CantidadProducto.ToString(), d.PrecioProducto.ToString(), Convert.ToString(subtotal), d.Usuario.ToString(), fechadevolucion);

                    
                    _dineroventas = _dineroventas - subtotal;
                    _dineroventas = (float)Math.Round(_dineroventas, 2);

                }

                lbl_cantidad_vendida.Text = Convert.ToString(_dineroventas);
            }

            else
            {
                lbl_cantidad_vendida.Text = Convert.ToString(_dineroventas);


            }






        }

        private void dataGridView_devoluciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ticket.Text != "")
                {


                    var wb = new Excel.XLWorkbook();

                    string ls_archivo_excel = "C:\\C#\\R_NumVenta" + txt_ticket.Text + ".xlsx";

                    //create 'worksheet' object
                    var ws = wb.Worksheets.Add("R_NumVenta" + txt_ticket.Text);

                    //read cells
                    var a = ws.Cell("A1").Value;
                    var b = ws.Cell("B1").Value;



                    //write cells
                    ws.Cell("A1").Value = "FILTROS";
                    ws.Cell("G4").Value = "REPORTE DE NUM VENTA";
                    ws.Cell("A2").Value = "NO.VENTA:";
                    ws.Cell("B2").Value = txt_ticket.Text;

                    ws.Cell("M2").Value = "Cantidad Vendida:" + lbl_cantidad_vendida.Text;


                    ws.Range("A5:G5").Value = "----------------------------------------";


                    ws.Cell("A6").Value = "No.Venta";
                    ws.Cell("B6").Value = "No.Producto";

                    ws.Cell("C6").Value = "Nombre Producto";

                    ws.Cell("D6").Value = "Precio";


                    ws.Cell("E6").Value = "Cantidad";


                    ws.Cell("F6").Value = "SubTotal";

                    ws.Cell("G6").Value = "Fecha Venta";

                    ws.Cell("H6").Value = "Tipo Venta";



                    dgReportes parametro = new dgReportes
                    {
                        Id_Venta = Convert.ToInt16(txt_ticket.Text)

                    };

                    int contadorcolumnas = 1;
                    int contadorregistros = 7;


                    List<dgReportes> lista = c_reportes.LeerReporte(5, parametro);

                    string escredito = "";
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

                            ws.Cell(contadorregistros, contadorcolumnas).Value = fechaventa;
                            contadorcolumnas = contadorcolumnas + 1;

                            ws.Cell(contadorregistros, contadorcolumnas).Value = d.DescripcionTipoVenta.ToString();
                            contadorcolumnas = contadorcolumnas + 1;


                            contadorregistros = contadorregistros + 1;
                            escredito = d.DescripcionTipoVenta.ToString();

                        }
                        if (escredito == "Credito")
                        {

                        }
                        else
                        {
                            contadorcolumnas = 1;
                            contadorregistros = contadorregistros + 3;


                            ws.Cell(contadorregistros, contadorcolumnas).Value = "No.Devolucion";
                            contadorcolumnas = contadorcolumnas + 1;

                            ws.Cell(contadorregistros, contadorcolumnas).Value = "No.Venta";
                            contadorcolumnas = contadorcolumnas + 1;

                            ws.Cell(contadorregistros, contadorcolumnas).Value = "No.Producto";
                            contadorcolumnas = contadorcolumnas + 1;


                            ws.Cell(contadorregistros, contadorcolumnas).Value = "Nombre Producto";
                            contadorcolumnas = contadorcolumnas + 1;

                            ws.Cell(contadorregistros, contadorcolumnas).Value = "Cantidad";
                            contadorcolumnas = contadorcolumnas + 1;

                            ws.Cell(contadorregistros, contadorcolumnas).Value = "Precio";
                            contadorcolumnas = contadorcolumnas + 1;

                            ws.Cell(contadorregistros, contadorcolumnas).Value = "SubTotal";
                            contadorcolumnas = contadorcolumnas + 1;


                            ws.Cell(contadorregistros, contadorcolumnas).Value = "Usuario";
                            contadorcolumnas = contadorcolumnas + 1;

                            ws.Cell(contadorregistros, contadorcolumnas).Value = "FechaDevolucion";
                            contadorcolumnas = contadorcolumnas + 1;


                            contadorregistros = contadorregistros + 1;
                            dgCaja parametro2 = new dgCaja
                            {
                                Id_Venta = Convert.ToInt16(txt_ticket.Text)

                            };




                            List<dgCaja> lista2 = c_caja.LeerCaja(10, parametro2);


                            if (lista2.Count > 0)

                            {
                                string fechadevolucion;

                                foreach (dgCaja d in lista2)
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

                                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.CantidadProducto.ToString();
                                    contadorcolumnas = contadorcolumnas + 1;

                                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.PrecioProducto.ToString();
                                    contadorcolumnas = contadorcolumnas + 1;

                                    ws.Cell(contadorregistros, contadorcolumnas).Value = subtotal;
                                    contadorcolumnas = contadorcolumnas + 1;



                                    ws.Cell(contadorregistros, contadorcolumnas).Value = d.Usuario.ToString();
                                    contadorcolumnas = contadorcolumnas + 1;

                                    ws.Cell(contadorregistros, contadorcolumnas).Value = fechadevolucion;
                                    contadorcolumnas = contadorcolumnas + 1;


                                    contadorregistros = contadorregistros + 1;
                                }


                            }

                            else
                            {



                            }

                        }

                        wb.SaveAs(ls_archivo_excel);
                        MessageBox.Show("Excel Reportado Satisfactoriamente en : " + ls_archivo_excel);

                    }

                    else
                    {
                        dataGridView_numventa.Rows.Clear();
                        MessageBox.Show("No se Encontro el Numero de Venta");
                        txt_ticket.Text = "";
                        dataGridView_devoluciones.Rows.Clear();
                        lbl_cantidad_vendida.Text = "";
                    }
                }

                else
                {
                    dataGridView_devoluciones.Rows.Clear();
                    lbl_cantidad_vendida.Text = "";
                    dataGridView_numventa.Rows.Clear();
                    MessageBox.Show("Ingrese el Numero de Ticket");
                    txt_ticket.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Respete la Sintaxis");
            }
           

           
        }

        private void TicketNumVenta()
        {
            try
            {
                if (txt_ticket.Text != "")
                {
                    string txtticket = txt_ticket.Text;
                    string impresora = "";
                   


                    dgReportes parametro = new dgReportes
                    {
                        Id_Venta = Convert.ToInt16(txt_ticket.Text)

                    };




                    List<dgReportes> lista = c_reportes.LeerReporte(5, parametro);


                  

                    string escredito = "";
                    string concatenacion = "";
                    if (lista.Count > 0)

                    {

                        dgImpresora parametroimpresora = new dgImpresora
                        {



                        };

                        List<dgImpresora> listaimpresora = c_impresora.LeerImpresora(1, parametroimpresora);

                        if (listaimpresora.Count > 0)

                        {


                            foreach (dgImpresora d in listaimpresora)
                            {

                                impresora = d.NombreImpresora.ToString();

                            }
                        }

                        clsventas.CreaRecibo Ticket1 = new clsventas.CreaRecibo();



                        dgTicket parametroticketinfo = new dgTicket
                        {
                        };

                        List<dgTicket> listaticketinfo = c_ticket.Ticket(0, parametroticketinfo);




                        if (listaticketinfo.Count > 0)

                        {


                            foreach (dgTicket d in listaticketinfo)
                            {
                                Ticket1.TextoCentro(d.NombreEmpresa.ToUpper().ToString());


                                Ticket1.TextoCentro(d.Colonia.ToUpper().ToString());
                                Ticket1.TextoCentro(d.Calle.ToUpper().ToString());
                                Ticket1.TextoCentro(d.Telefono.ToString());
                                Ticket1.TextoIzquierda("");
                            }


                            Ticket1.TextoIzquierda("Recibo de Venta");
                            Ticket1.TextoIzquierda("Los Precios ya contienen IVA");



                            Ticket1.TextoIzquierda("");
                        }

                        Ticket1.TextoIzquierda("Recibo:" + txtticket);
                        Ticket1.TextoIzquierda("");
                        clsventas.CreaRecibo.EncabezadoVenta();
                        clsventas.CreaRecibo.LineasGuion();

                        string fechaventa;
                        float subtotal;
                        foreach (dgReportes d in lista)
                        {
                            Ticket1.TextoIzquierda(d.DescripcionTipoVenta.ToString());
                            break;
                        }
                        Ticket1.TextoIzquierda("");

                        foreach (dgReportes d in lista)
                        {
                            subtotal = float.Parse(d.SubTotalProducto.ToString());

                            subtotal = (float)Math.Round(subtotal, 2);

                            fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");

                            concatenacion =d.NombreProducto.ToString();
                           
                           
                            Ticket1.TextoIzquierda(concatenacion);
                            Ticket1.AgregaArticulo("(" + d.IdProducto.ToString() + ")", double.Parse(d.PrecioProducto.ToString()), Convert.ToInt16(d.CantidadProducto.ToString()), double.Parse(subtotal.ToString()));
                            clsventas.CreaRecibo.LineasGuion();

                            escredito = d.DescripcionTipoVenta.ToString();

                        }



                        if (escredito == "Credito")
                        {

                        }
                        else
                        {






                            dgCaja parametro2 = new dgCaja
                            {
                                Id_Venta = Convert.ToInt16(txt_ticket.Text)

                            };




                            List<dgCaja> lista2 = c_caja.LeerCaja(10, parametro2);

                            Ticket1.TextoIzquierda("");

                            Ticket1.TextoIzquierda("Devoluciones");

                            clsventas.CreaRecibo.EncabezadoVenta();
                            clsventas.CreaRecibo.LineasGuion();


                            if (lista2.Count > 0)

                            {
                                string fechadevolucion;

                                foreach (dgCaja d in lista2)
                                {
                                    subtotal = float.Parse(d.SubTotalProducto.ToString());

                                    subtotal = (float)Math.Round(subtotal, 2);

                                    fechadevolucion = d.FechaDevolucion.Value.ToString("dd/MM/yyyy");

                                    concatenacion =  d.NombreProducto.ToString();
                                    Ticket1.TextoIzquierda(concatenacion);

                                    Ticket1.AgregaArticulo("(" + d.IdProducto.ToString() + ")", double.Parse(d.PrecioProducto.ToString()), Convert.ToInt16(d.CantidadProducto.ToString()), double.Parse(subtotal.ToString()));
                                    clsventas.CreaRecibo.LineasGuion();
                                }


                            }

                            else
                            {



                            }

                        }

                        Ticket1.TextoIzquierda("Cantidad Vendida:" + lbl_cantidad_vendida.Text);

                        Ticket1.TextoCentro("------------");
                        Ticket1.TextoCentro("TICKET DE VENTA NUMVENTA ");
                        Ticket1.TextoCentro("------------");

                        Ticket1.ImprimirTiket(impresora);
                        MessageBox.Show("Ticket Generado Satisfactoriamente");

                    }

                    else
                    {
                        dataGridView_numventa.Rows.Clear();
                        MessageBox.Show("No se Encontro el Numero de Venta");
                        txt_ticket.Text = "";
                        dataGridView_devoluciones.Rows.Clear();
                        lbl_cantidad_vendida.Text = "";
                    }
                }

                else
                {
                    dataGridView_devoluciones.Rows.Clear();
                    lbl_cantidad_vendida.Text = "";
                    dataGridView_numventa.Rows.Clear();
                    MessageBox.Show("Ingrese el Numero de Ticket");
                    txt_ticket.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Respete la Sintaxis");
            }
           
            
           
               









            


        }

        private void btn_generar_ticket_Click(object sender, EventArgs e)
        {
            TicketNumVenta();
        }

        private void txt_ticket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = false;
            }
          
        }
    }
}
