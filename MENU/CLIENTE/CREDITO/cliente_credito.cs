using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.CLIENTE.CREDITO.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.MENU.CLIENTE.CREDITO
{
    public partial class cliente_credito : Form
    {
        public cliente_credito()
        {
            InitializeComponent();
        }

        public int _cantidad_creditos;

        public void CargaClientesCredito(int cantidacreditos)
        {

         
            dgClienteCredito parametro = new dgClienteCredito
            {
                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text)
            };

            List<dgClienteCredito> lista = c_cliente_credito.LeerClienteCredito(33, parametro);


            if (lista.Count > 0)

            {
                string colonia,calle,numcasa;
               
                foreach (dgClienteCredito d in lista)
                {

                    colonia = d.Colonia;
                    calle = d.Calle;
                    numcasa = d.NumCasa;
                    lbl_nombre.Text = Convert.ToString(d.Nombre.ToString());
                    lbl_ap.Text = Convert.ToString(d.Apellido_Paterno.ToString());
                    lbl_am.Text = Convert.ToString(d.Apellido_Materno.ToString());
                    lbl_domicilio.Text = colonia + " " + calle + " " + numcasa;
                    lbl_telefono.Text = Convert.ToString(d.Telefono.ToString());
                    lbl_correo.Text = Convert.ToString(d.Correo.ToString());
                    




                }

            }


            flowLayoutPanel_creditos.Controls.Clear();

            dgClienteCredito parametro2 = new dgClienteCredito
            {
                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text)
            };

            List<dgClienteCredito> lista2 = c_cliente_credito.LeerClienteCredito(3, parametro2);



            int contadorcreditos = 0;



            if (lista2.Count > 0)

            {

                int idventa,idcliente;
                float cantidadpagada, total,cantidadfaltante;
                string fecharegistro ;

                DateTime fecharegistrofecha;




                foreach (dgClienteCredito d in lista2)
                {

                    idcliente = Convert.ToInt16(d.Id_Cliente.ToString());
                    idventa = Convert.ToInt16(d.Id_Venta.ToString());
                    cantidadpagada = float.Parse(d.CantidadPagada.ToString());

                    cantidadpagada = (float)Math.Round(cantidadpagada, 2);
                    total = float.Parse(d.Total.ToString());
                    fecharegistrofecha = Convert.ToDateTime(d.FechaRegistro.ToString());

                    fecharegistro= fecharegistrofecha.ToString("dd/MM/yyyy");

                    cantidadfaltante = total - cantidadpagada;


                    cantidadfaltante = (float)Math.Round(cantidadfaltante, 2);

                  


                    total = (float)Math.Round(total, 2);

                    UserControlCredito[] Creditos = new UserControlCredito[cantidacreditos];


                    contadorcreditos = contadorcreditos + 1;

                    Creditos[contadorcreditos] = new UserControlCredito();


                    Creditos[contadorcreditos].IdCliente = Convert.ToString(idcliente);

                    Creditos[contadorcreditos].IdVenta = Convert.ToString(idventa);

                    Creditos[contadorcreditos].TotalPagado = Convert.ToString(cantidadpagada);

                    Creditos[contadorcreditos].TotalVenta = Convert.ToString(total);

                    Creditos[contadorcreditos].FaltaPagar = Convert.ToString(cantidadfaltante);

                    Creditos[contadorcreditos].FechaRegistro = Convert.ToString(fecharegistro);


                    Creditos[contadorcreditos].Usuario = lbl_idusuario.Text;





                    flowLayoutPanel_creditos.Controls.Add(Creditos[contadorcreditos]);






                }

            }


        }


        private void CargaCantidadCreditos()
        {
            
            dgClienteCredito parametro = new dgClienteCredito
            {
                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text)
            };

            List<dgClienteCredito> cantidadcreditos = c_cliente_credito.LeerClienteCredito(7, parametro);


            if (cantidadcreditos.Count > 0)

            {

                foreach (dgClienteCredito d in cantidadcreditos)
                {

                    _cantidad_creditos = Convert.ToInt16(d.CantidadCreditos.ToString()) + 1;

                }
            }
           

        }

        private void CargaTotalDeuda()
        {

            dgAbonoTotal parametro = new dgAbonoTotal
            {
                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text)
            };

            List<dgAbonoTotal> cantidadeudatotal = c_abonoTotal.LeerAbonoTotal(1, parametro);


            if (cantidadeudatotal.Count > 0)

            {
                float cantidaddeudafaltante = 0;

                foreach (dgAbonoTotal d in cantidadeudatotal)
                {
                    cantidaddeudafaltante = float.Parse(d.CantidadFaltanteTotal.ToString());
                    cantidaddeudafaltante = (float)Math.Round(cantidaddeudafaltante, 2);

                    lbl_deuda.Text = Convert.ToString(cantidaddeudafaltante);

                }
            }


        }

        private void cliente_credito_Load(object sender, EventArgs e)
        {

            

            dgClienteCredito parametro = new dgClienteCredito();


            List<dgClienteCredito> lista = c_cliente_credito.LeerClienteCredito(4, parametro);

            if (lista.Count > 0)

            {

                foreach (dgClienteCredito d in lista)
                {
                    lbl_id_cliente.Text=d.Id_Cliente.ToString();
                    lbl_idusuario.Text=d.Id_Usuario.ToString();
                }


            }
            CargaCantidadCreditos();
            CargaClientesCredito(_cantidad_creditos);
            CargaTotalDeuda();



        }
         
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Cerrar()
        {
            this.Close();  
        }


        private void flowLayoutPanel_creditos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_id_cliente_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel_creditos_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void txt_deuda_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_abonar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_abonar_TextChanged(object sender, EventArgs e)
        {

            try
            {
                float totaldeuda = float.Parse(lbl_deuda.Text);

                float pago = float.Parse(txt_abonar.Text);
                float cambio = pago - totaldeuda;
                cambio = (float)Math.Round(cambio, 2);

                if (pago < totaldeuda)
                {

                    lbl_cambio.Text = "0";


                }

                else
                {
                    
                    lbl_cambio.Text = Convert.ToString(cambio);

                }
            }
            catch
            {
                lbl_cambio.Text = "";
            }
        }


        private void CargaDeudaTicket()
        {

            dgAbonoTotal parametro = new dgAbonoTotal
            {
                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text)
            };

            List<dgAbonoTotal> cantidadeudatotalticket = c_abonoTotal.LeerAbonoTotal(2, parametro);


            if (cantidadeudatotalticket.Count > 0)

            {
                float cantidaddeudafaltante = 0;

                foreach (dgAbonoTotal d in cantidadeudatotalticket)
                {
                    cantidaddeudafaltante = float.Parse(d.CantidadFaltanteTotal.ToString());
                    cantidaddeudafaltante = (float)Math.Round(cantidaddeudafaltante, 2);

                    lbl_deuda.Text = Convert.ToString(cantidaddeudafaltante);

                }
            }


        }


        private void TicketCaja(int tipoticket)
        {

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


                Ticket1.TextoIzquierda("Recibo de Abono");
                Ticket1.TextoIzquierda("Los Precios ya contienen IVA");
                Ticket1.TextoIzquierda("Cajero:" + lbl_idusuario.Text);


                Ticket1.TextoIzquierda("Fecha de Abono: " + DateTime.Now.ToShortDateString());
                Ticket1.TextoIzquierda("");
            }





            dgCliente parametrodatosclientee = new dgCliente
            {
                Id_Cliente = Convert.ToInt32(lbl_id_cliente.Text)
            };

            List<dgCliente> listaticketinfocliente = c_cliente.LeerCliente(3, parametrodatosclientee);



            if (listaticketinfocliente.Count > 0)

            {


                foreach (dgCliente d in listaticketinfocliente)
                {

                    Ticket1.TextoIzquierda("Nombre:" + d.Nombre.ToUpper().ToString());
                    Ticket1.TextoIzquierda("Apellido 1:" + d.Apellido_Paterno.ToUpper().ToString());
                    Ticket1.TextoIzquierda("Apellido 2:" + d.Apellido_Materno.ToUpper().ToString());
                    Ticket1.TextoIzquierda("Estado:" + d.Estado.ToUpper().ToString());
                    Ticket1.TextoIzquierda("Municipio:" + d.Municipio.ToUpper().ToString());
                    Ticket1.TextoIzquierda("Colonia:" + d.Colonia.ToUpper().ToString());
                    Ticket1.TextoIzquierda("Calle:" + d.Calle.ToUpper().ToString());
                    Ticket1.TextoIzquierda("NumCasa:" + d.NumCasa.ToUpper().ToString());
                    Ticket1.TextoIzquierda("");
                }
            }


            if (tipoticket==1)
            {
                Ticket1.TextoIzquierda("");



                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Abonado con:", double.Parse(txt_abonar.Text));

                Ticket1.TextoIzquierda(" ");



                Ticket1.AgregaTotales("Deuda por Liquidar:", double.Parse(lbl_deuda.Text) - double.Parse(txt_abonar.Text));



                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Cambio :", double.Parse(lbl_cambio.Text));



                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("========================");
                Ticket1.TextoCentro("TICKET DE ABONO ");
                Ticket1.TextoCentro("========================");
                Ticket1.TextoIzquierda(" ");
            }
            else if (tipoticket==2)
            {
                Ticket1.TextoIzquierda("");



                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Abonado con:", double.Parse(txt_abonar.Text));

                Ticket1.TextoIzquierda(" ");



                Ticket1.AgregaTotales("Deuda por Liquidar:", 0);



                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Cambio :", double.Parse(lbl_cambio.Text));



                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("========================");
                Ticket1.TextoCentro("TICKET DE ABONO ");
                Ticket1.TextoCentro("DEUDA LIQUIDADA ");
                Ticket1.TextoCentro("========================");
                Ticket1.TextoIzquierda(" ");

            }

            else if (tipoticket == 3)
            {
                Ticket1.TextoIzquierda("");



                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Abonado con:", double.Parse(lbl_deuda.Text));

                Ticket1.TextoIzquierda(" ");



                Ticket1.AgregaTotales("Deuda por Liquidar:", 0);



                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Cambio :", 0);



                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("========================");
                Ticket1.TextoCentro("TICKET DE ABONO ");
                Ticket1.TextoCentro("DEUDA LIQUIDADA ");
                Ticket1.TextoCentro("========================");
                Ticket1.TextoIzquierda(" ");

            }










            Ticket1.ImprimirTiket(impresora);
            MessageBox.Show("Ticket Generado Satisfactoriamente");

            Cerrar();
        }


        private void btn_abonar_Click(object sender, EventArgs e)
        {
            var confirmabono = MessageBox.Show("Confirmar Abono?",
              "Abono Deuda",
              MessageBoxButtons.YesNo);

            if (confirmabono == DialogResult.Yes)
            {
                int tipoticket = 0;
                
                // si ticket
                float totaldeuda = float.Parse(lbl_deuda.Text);

                float pago = float.Parse(txt_abonar.Text);
                float cambio = pago - totaldeuda;
                cambio = (float)Math.Round(cambio, 2);



                dgAbonoTotal parametro = new dgAbonoTotal
                {
                    Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text)
                };

                List<dgAbonoTotal> cantidadeudatotalticket = c_abonoTotal.LeerAbonoTotal(2, parametro);

                // seguro venta


                if (pago <= totaldeuda)
                {

                    lbl_cambio.Text = "0";


                    // logica de ver cuanto pago y aplicarselo a pago historial y al pago mas tarde 
                    if (cantidadeudatotalticket.Count > 0)

                    {
                        tipoticket = 1;

                        float cantidadFaltanteTotal;

                        float cantidadAbonar;

                        cantidadAbonar = float.Parse(txt_abonar.Text);
                        foreach (dgAbonoTotal d in cantidadeudatotalticket)
                        {
                            cantidadFaltanteTotal = float.Parse(d.CantidadFaltanteTotal.ToString());


                            if (cantidadAbonar >= cantidadFaltanteTotal)
                            {
                                dgClienteCredito parametro2 = new dgClienteCredito
                                {
                                    Id_Venta = Convert.ToInt16(d.Id_Venta.ToString()),
                                    CantidadPagada = cantidadFaltanteTotal,
                                    Id_Cliente = Convert.ToInt16(d.Id_Cliente.ToString()),
                                    FechaPago = DateTime.Now,
                                    Validacion = 1,
                                    Cambio = 0
                                };

                                string control = "";

                                control = c_cliente_credito.ActualizarCreditoPago(1, parametro2); // YA SE CARGO LO ABONADO EL TOTAL
                            }

                            else if (cantidadAbonar < cantidadFaltanteTotal)
                            {
                                if (cantidadAbonar<=0)
                                {

                                }
                                else
                                {
                                    dgClienteCredito parametro2 = new dgClienteCredito
                                    {
                                        Id_Venta = Convert.ToInt16(d.Id_Venta.ToString()),
                                        CantidadPagada = cantidadAbonar,
                                        Id_Cliente = Convert.ToInt16(d.Id_Cliente.ToString()),
                                        FechaPago = DateTime.Now,
                                        Validacion = 0

                                    };

                                    string control = "";

                                    control = c_cliente_credito.ActualizarCreditoPago(1, parametro2); // YA SE CARGO LO ABONADO EL TOTAL
                                }
                            }

                            try
                            {
                                cantidadAbonar = cantidadAbonar - cantidadFaltanteTotal;
                              
                            }
                            catch
                            {

                            }




                        }
                    }
                    
                       

                }

                else
                {
                    // mayor a la deuda 


                    // logica de ver cuanto pago y aplicarselo a pago historial y al pago mas tarde 
                    if (cantidadeudatotalticket.Count > 0)

                    {
                        tipoticket = 2;
                        float cantidadFaltanteTotal;

                        float cantidadAbonar;

                        cantidadAbonar = float.Parse(txt_abonar.Text);
                        foreach (dgAbonoTotal d in cantidadeudatotalticket)
                        {
                            cantidadFaltanteTotal = float.Parse(d.CantidadFaltanteTotal.ToString());


                            
                            dgClienteCredito parametro2 = new dgClienteCredito
                            {
                                Id_Venta = Convert.ToInt16(d.Id_Venta.ToString()),
                                CantidadPagada = cantidadFaltanteTotal,
                                Id_Cliente = Convert.ToInt16(d.Id_Cliente.ToString()),
                                FechaPago = DateTime.Now,
                                Validacion = 1,
                                Cambio = 0
                            };

                            string control = "";

                            control = c_cliente_credito.ActualizarCreditoPago(1, parametro2); // YA SE CARGO LO ABONADO EL TOTAL
                           

                        }
                    }

                }


                var confirmaticket = MessageBox.Show("Desea Imprimir Ticket?",
                "Ticket ",
                MessageBoxButtons.YesNo);

                // si ticket
                if (confirmaticket == DialogResult.Yes)
                {
                    TicketCaja(tipoticket);
                }

                // no ticket
                else
                {
                    Cerrar();
                }

            }



          


        }

        private void btn_liquidar_Click(object sender, EventArgs e)
        {
            var confirmabono = MessageBox.Show("Confirmar Liquidacion?",
             "Abono Liquidacion",
             MessageBoxButtons.YesNo);

            if (confirmabono == DialogResult.Yes)
            {
                int tipoticket = 3;

                // si ticket
                




                dgAbonoTotal parametro = new dgAbonoTotal
                {
                    Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text)
                };

                List<dgAbonoTotal> cantidadeudatotalticket = c_abonoTotal.LeerAbonoTotal(2, parametro);



                // logica de ver cuanto pago y aplicarselo a pago historial y al pago mas tarde 
                if (cantidadeudatotalticket.Count > 0)

                {
                    tipoticket = 3;
                    float cantidadFaltanteTotal;

                
                    foreach (dgAbonoTotal d in cantidadeudatotalticket)
                    {
                        cantidadFaltanteTotal = float.Parse(d.CantidadFaltanteTotal.ToString());



                        dgClienteCredito parametro2 = new dgClienteCredito
                        {
                            Id_Venta = Convert.ToInt16(d.Id_Venta.ToString()),
                            CantidadPagada = cantidadFaltanteTotal,
                            Id_Cliente = Convert.ToInt16(d.Id_Cliente.ToString()),
                            FechaPago = DateTime.Now,
                            Validacion = 1,
                            Cambio = 0
                        };

                        string control = "";

                        control = c_cliente_credito.ActualizarCreditoPago(1, parametro2); // YA SE CARGO LO ABONADO EL TOTAL


                    }
                }


                var confirmaticket = MessageBox.Show("Desea Imprimir Ticket?",
                "Ticket ",
                MessageBoxButtons.YesNo);

                // si ticket
                if (confirmaticket == DialogResult.Yes)
                {
                    TicketCaja(tipoticket);
                }

                // no ticket
                else
                {
                    Cerrar();
                }

            }
        }
    }
}
