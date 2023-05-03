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
            lbl_cambio.Visible = false;
            txt_abonar.Visible = false;
            label6.Visible = false;
            label10.Visible = false;
            btn_liquidar.Visible = false;

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
        private void CargaTipoVenta()
        {

            dgTipoVenta parametro = new dgTipoVenta();

            List<dgTipoVenta> lista = c_tipoventa.LeerTipoVenta(1, parametro);

            if (lista.Count > 0)

            {

                foreach (dgTipoVenta d in lista)
                {
                    if (d.Descripcion == "Credito")
                    {

                    }
                    else if (d.Descripcion == "Tarjeta Credito")
                    {

                    }
                    else if (d.Descripcion == "Tarjeta Debito")
                    {

                    }
                    else
                    {
                        bx_tipoventa.Items.Add(d.Descripcion.ToString());
                       

                    }

                }

               
            }


        }
        private void cliente_credito_Load(object sender, EventArgs e)
        {


            CargaTipoVenta();
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

                if (lbl_id_tipoventa.Text == "1")
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
                   

                if (lbl_id_tipoventa.Text == "4" ) // transferencia
                {

                    lbl_cambio.Text = "";

                    float total = float.Parse(lbl_deuda.Text);

                    float pago = float.Parse(txt_abonar.Text);




                    if (pago > total)
                    {

                        MessageBox.Show("No puede hacer una transferencia mayor a la deuda", "Advertencia");
                        txt_abonar.Text = "";
                    }

                    else
                    {


                    }

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

                dgUsuario parametrousuario = new dgUsuario
                {

                    Id_Usuario = Convert.ToInt16(lbl_idusuario.Text)

                };

                List<dgUsuario> listausuariovendedor = c_usuario.LeerUsuario(2, parametrousuario);

                if (listausuariovendedor.Count > 0)

                {

                    foreach (dgUsuario d in listausuariovendedor)
                    {

                        Ticket1.TextoIzquierda("Cajero:" + d.Usuario.ToString());
                    }
                }



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


            if (bx_tipoventa.Text!="")
            {
                //efectivo
                if (lbl_id_tipoventa.Text=="1")
                {
                    if (txt_abonar.Text != "")
                    {
                        var confirmabono = MessageBox.Show("Confirmar Abono?",
                        "Abono Deuda Efectivo",
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
                                                Id_TipoVenta = 1,
                                                FechaPago = DateTime.Now,
                                                Validacion = 1,
                                                Cambio = 0
                                            };

                                            string control = "";

                                            control = c_cliente_credito.ActualizarCreditoPago(1, parametro2); // YA SE CARGO LO ABONADO EL TOTAL
                                        }

                                        else if (cantidadAbonar < cantidadFaltanteTotal)
                                        {
                                            if (cantidadAbonar <= 0)
                                            {

                                            }
                                            else
                                            {
                                                dgClienteCredito parametro2 = new dgClienteCredito
                                                {
                                                    Id_Venta = Convert.ToInt16(d.Id_Venta.ToString()),
                                                    CantidadPagada = cantidadAbonar,
                                                    Id_Cliente = Convert.ToInt16(d.Id_Cliente.ToString()),
                                                    Id_TipoVenta = 1,
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
                                            Id_TipoVenta = 1,
                                            Validacion = 1,
                                            Cambio = 0
                                        };

                                        string control = "";

                                        control = c_cliente_credito.ActualizarCreditoPago(1, parametro2); // YA SE CARGO LO ABONADO EL TOTAL


                                    }
                                }

                            }


                            var confirmaticket = MessageBox.Show("Desea Imprimir Ticket?",
                            "Ticket Efectivo",
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
                    else
                    {
                        MessageBox.Show("Debe de Ingresar la Cantidad a Abonar");
                    }
                }



                //transferencia
                else if (lbl_id_tipoventa.Text == "4")
                {
                    if (txt_abonar.Text != "")
                    {
                        var confirmabono = MessageBox.Show("Confirmar Abono?",
                        "Abono Deuda Transferencia",
                        MessageBoxButtons.YesNo);

                        if (confirmabono == DialogResult.Yes)
                        {
                            int tipoticket = 0;

                            // si ticket
                            float totaldeuda = float.Parse(lbl_deuda.Text);

                            float pago = float.Parse(txt_abonar.Text);
                          
                            



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

                                    float cantidadAbonar=float.Parse(txt_abonar.Text);

                                    cantidadAbonar = (float)Math.Round(cantidadAbonar, 2);

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
                                                Id_TipoVenta = 4,
                                                FechaPago = DateTime.Now,
                                                Validacion = 2,
                                                Cambio = 0
                                            };

                                            string control = "";

                                            control = c_cliente_credito.ActualizarCreditoPago(1, parametro2); // YA SE CARGO LO ABONADO EL TOTAL
                                        }

                                        else if (cantidadAbonar < cantidadFaltanteTotal)
                                        {
                                            if (cantidadAbonar <= 0)
                                            {

                                            }
                                            else
                                            {
                                                dgClienteCredito parametro2 = new dgClienteCredito
                                                {
                                                    Id_Venta = Convert.ToInt16(d.Id_Venta.ToString()),
                                                    CantidadPagada = cantidadAbonar,
                                                    Id_Cliente = Convert.ToInt16(d.Id_Cliente.ToString()),
                                                    Id_TipoVenta = 4,
                                                    FechaPago = DateTime.Now,
                                                    Validacion = 3

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

                            


                            var confirmaticket = MessageBox.Show("Desea Imprimir Ticket?",
                            "Ticket Transferencia ",
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
                    else
                    {
                        MessageBox.Show("Debe de Ingresar la Cantidad a Abonar");
                    }
                }
               

            }

            else
            {
                MessageBox.Show("Debe de Seleccionar el Tipo Venta");
            }
           



          


        }

        private void btn_liquidar_Click(object sender, EventArgs e)
        {
            //liquidacion efectivo
            if (lbl_id_tipoventa.Text=="6")
            {
                var confirmabono = MessageBox.Show("Confirmar Liquidacion Efectivo?",
                 "Abono Liquidacion Efectivo",
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
                                Id_TipoVenta = 1,
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


            //liquidacion transferencia
            else if (lbl_id_tipoventa.Text == "7")
            {
                var confirmabono = MessageBox.Show("Confirmar Liquidacion Transferencia?",
               "Abono Liquidacion Transferencia",
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
                                Id_TipoVenta = 4,
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
            else
            {
                MessageBox.Show("Debe de tener seleccionado la opcion Liquidacion en Tipo Venta");
            }
            
        }

        private void bx_tipoventa_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgTipoVenta parametro = new dgTipoVenta
            {
                Descripcion = bx_tipoventa.Text
            };

            List<dgTipoVenta> lista = c_tipoventa.LeerTipoVenta(2, parametro);


            if (lista.Count > 0)

            {

                foreach (dgTipoVenta d in lista)
                {
                    lbl_id_tipoventa.Text = d.Id_TipoVenta.ToString();

                    
                }


            }

            if (lbl_id_tipoventa.Text == "1") // efectivo
            {


                lbl_cambio.Visible = true;
                txt_abonar.Visible = true;
                label6.Visible = true;
                label10.Visible = true;
                btn_abonar.Visible = true;
                btn_liquidar.Visible = false;



            }

            else if (lbl_id_tipoventa.Text == "4") // transferencia
            {


                lbl_cambio.Visible = false;
                txt_abonar.Visible = true;
                label6.Visible = true;
                label10.Visible = false;
                btn_abonar.Visible = true;
                btn_liquidar.Visible = false;


            }


            else if (lbl_id_tipoventa.Text == "6") // Liquidacion efectivo
            {


                lbl_cambio.Visible = false;
                txt_abonar.Visible = false;

                label6.Visible = false;
                label10.Visible = false;
                btn_abonar.Visible = false;
                btn_liquidar.Visible = true;


            }


            else if (lbl_id_tipoventa.Text == "7") // Liquidacion transferencia
            {


                lbl_cambio.Visible = false;
                txt_abonar.Visible = false;

                label6.Visible = false;
                label10.Visible = false;
                btn_abonar.Visible = false;
                btn_liquidar.Visible = true;


            }


        }
    }
}
