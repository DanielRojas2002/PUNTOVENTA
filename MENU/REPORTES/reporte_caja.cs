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
            Fechacaja.Value = DateTime.Now;
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
                    float totalcaja;


                    foreach (dgReportes d in lista)
                    {
                        totalcaja = float.Parse(d.CantidadTotal.ToString());

                        totalcaja = (float)Math.Round(totalcaja, 2);

                        fechacaja = d.FechaCaja.Value.ToString("dd/MM/yyyy");
                        dataGridView_caja.Rows.Add(d.IdCaja.ToString(), d.CantidadVenta.ToString(), d.CantidadAbonada.ToString(),
                             d.CantidadDevolucion.ToString(), d.CantidadRetirada.ToString(),Convert.ToString(totalcaja), fechacaja, d.DescripcionCaja.ToString());


                        
                    }


                }

                else
                {
                    MessageBox.Show("No se Encontro Caja en el dia seleccionado");


                }

            }
            catch
            {



               
                MessageBox.Show("Error en  Fechas");
             
             


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

                    float totalcaja;

                    foreach (dgReportes d in lista)
                    {

                        totalcaja = float.Parse(d.CantidadTotal.ToString());

                        totalcaja = (float)Math.Round(totalcaja, 2);

                        contadorcolumnas = 1;

                        fechacaja = d.FechaCaja.Value.ToString("dd/MM/yyyy");
                       
                        ws.Cell(contadorregistros, contadorcolumnas).Value = Convert.ToString(d.IdCaja.ToString());
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = Convert.ToString(d.CantidadVenta.ToString());
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = Convert.ToString(d.CantidadAbonada.ToString());
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = Convert.ToString(d.CantidadDevolucion.ToString());
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = Convert.ToString(d.CantidadRetirada.ToString());
                        contadorcolumnas = contadorcolumnas + 1;

                        ws.Cell(contadorregistros, contadorcolumnas).Value = Convert.ToString(totalcaja);
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

                MessageBox.Show("Error en  Fechas");

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

        private void btn_ticket_Click(object sender, EventArgs e)
        {

            TicketCaja();
        }

        private void TicketCaja()
        {

            txtFechai.Text = Fechacaja.Value.ToString("dd/MM/yyyy");

            string impresora = "";
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


                Ticket1.TextoIzquierda("Recibo de Ventas");
                Ticket1.TextoIzquierda("Los Precios ya contienen IVA");


                Ticket1.TextoIzquierda("Fecha de Caja: " + txtFechai.Text);
                Ticket1.TextoIzquierda("");
            }




            dgTicket parametroticket = new dgTicket
            {
                FechaVenta = Convert.ToDateTime(txtFechai.Text)
            };

            List<dgTicket> listaProductosVenta = c_ticket.Ticket(3, parametroticket);



            if (listaProductosVenta.Count > 0)

            {
                Ticket1.TextoIzquierda("VENTAS");
                Ticket1.TextoIzquierda("");
                clsventas.CreaRecibo.LineasGuion();

                clsventas.CreaRecibo.EncabezadoVenta();
                Ticket1.TextoIzquierda("");


                string concatenacion = "";
                double subtotal, sub, cantidadcomprada, preciocomprado;
                foreach (dgTicket d in listaProductosVenta)
                {
                    preciocomprado = double.Parse(d.PrecioComprado.ToString());

                    cantidadcomprada = Convert.ToInt16(d.CantidadComprada.ToString());

                    sub = preciocomprado * cantidadcomprada;

                    subtotal = (double)Math.Round(sub, 2);


                    concatenacion = d.NombreProducto.ToString();



                    Ticket1.TextoIzquierda(d.DescripcionTipoVenta.ToString());
                    Ticket1.TextoIzquierda(concatenacion);
                    Ticket1.AgregaArticulo("(" + d.Id_Producto.ToString() + ")", double.Parse(d.PrecioComprado.ToString()), Convert.ToInt16(d.CantidadComprada.ToString()), double.Parse(subtotal.ToString()));
                    clsventas.CreaRecibo.LineasGuion();
                }
            }

            Ticket1.TextoIzquierda("");




            dgTicket parametroticket2 = new dgTicket
            {
                FechaVenta = Convert.ToDateTime(txtFechai.Text)
            };

            List<dgTicket> listaProductosVenta2 = c_ticket.Ticket(4, parametroticket);





            if (listaProductosVenta2.Count > 0)

            {

                Ticket1.TextoIzquierda("ABONOS CREDITO");
                Ticket1.TextoIzquierda("");
                clsventas.CreaRecibo.LineasGuion();


                clsventas.CreaRecibo.EncabezadoVenta();




                double subtotal, sub;
                foreach (dgTicket d in listaProductosVenta2)
                {
                    sub = double.Parse(d.SubTotal.ToString());

                    subtotal = (double)Math.Round(sub, 2);



                    Ticket1.TextoIzquierda(" ");
                    Ticket1.TextoIzquierda("Num Venta: " + d.Id_Venta.ToString() + " " + d.DescripcionTipoVenta.ToString() + " " + d.Usuario.ToString());
                    Ticket1.TextoIzquierda("Cliente: " + " " + d.Nombre.ToString() + " " + d.Apellido_Paterno.ToString() + " " + d.Apellido_Materno.ToString());
                    Ticket1.AgregaArticulo("", 0, 0, double.Parse(subtotal.ToString()));
                    clsventas.CreaRecibo.LineasGuion();
                }
            }

            Ticket1.TextoIzquierda("");


            dgTicket parametroticketdevolucion = new dgTicket
            {
                FechaVenta = Convert.ToDateTime(txtFechai.Text)
            };

            List<dgTicket> listaProductosVentadevolucion = c_ticket.Ticket(5, parametroticketdevolucion);


            if (listaProductosVentadevolucion.Count > 0)

            {
                Ticket1.TextoIzquierda("DEVOLUCIONES");
                Ticket1.TextoIzquierda("");
                clsventas.CreaRecibo.LineasGuion();


                clsventas.CreaRecibo.EncabezadoVenta();

                string concatenacion = "";
                double subtotal, sub, cantidadcomprada, preciocomprado;
                foreach (dgTicket d in listaProductosVentadevolucion)
                {
                    preciocomprado = double.Parse(d.PrecioComprado.ToString());

                    cantidadcomprada = Convert.ToInt16(d.CantidadComprada.ToString());

                    sub = preciocomprado * cantidadcomprada;

                    subtotal = (double)Math.Round(sub, 2);


                    concatenacion = d.NombreProducto.ToString();

                    Ticket1.TextoIzquierda(d.DescripcionTipoVenta.ToString());
                    Ticket1.TextoIzquierda(concatenacion);
                    Ticket1.AgregaArticulo("(" + d.Id_Producto.ToString() + ")", double.Parse(d.PrecioComprado.ToString()), Convert.ToInt16(d.CantidadComprada.ToString()), double.Parse(subtotal.ToString()));
                    clsventas.CreaRecibo.LineasGuion();
                }
            }

            float cantidadventa=0, cantidadabonada=0, cantidaddevolucion=0, cantidadretirada=0, cantidadtotal=0;

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
                        cantidadventa = float.Parse(d.CantidadVenta.ToString());
                        cantidadabonada = float.Parse(d.CantidadAbonada.ToString());
                        cantidaddevolucion = float.Parse(d.CantidadDevolucion.ToString());
                        cantidadretirada = float.Parse(d.CantidadRetirada.ToString());
                        cantidadtotal = float.Parse(d.CantidadTotal.ToString());





                    }


                }

                else
                {
                    MessageBox.Show("No se Encontro Caja en el dia seleccionado");


                }

            }
            catch
            {

                MessageBox.Show("Error en  Fechas");




            }
           

            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total Venta", cantidadventa);
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Abonado con :", cantidadabonada);

            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Devolucion :", cantidaddevolucion);

            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Retirado Caja", cantidadretirada);

            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total Caja ", cantidadtotal);



            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("========================");
            Ticket1.TextoCentro("TICKET DE CAJA ");
            Ticket1.TextoCentro("========================");
            Ticket1.TextoIzquierda(" ");




            Ticket1.ImprimirTiket(impresora);
            MessageBox.Show("Ticket Generado Satisfactoriamente");

            RegresarVentana();
        }

       
    }
}
