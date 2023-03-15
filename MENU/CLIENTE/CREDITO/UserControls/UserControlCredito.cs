using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PROVEEDOR;
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

namespace PUNTOVENTA.MENU.CLIENTE.CREDITO.UserControls
{
    public partial class UserControlCredito : UserControl
    {
        public UserControlCredito()
        {
            InitializeComponent();
        }


        public string _idventa;
        public string _idcliente;
        public string _totalventa;
        public string _totalpagado;
        public string _faltaporpagar;





        public string IdCliente
        {
            get { return _idcliente; }
            set { _idcliente = value; lbl_id_cliente.Text = value; }
        }

        public string IdVenta
        {
            get { return _idventa; }
            set { _idventa = value; lbl_id_venta.Text = value; }
        }

        public string TotalVenta
        {
            get { return _totalventa; }
            set { _totalventa = value; lbl_total_venta.Text = value; }
        }

        public string TotalPagado
        {
            get { return _totalpagado; }
            set { _totalpagado = value; lbl_cantidad_pagada.Text = value; }
        }

        public string FaltaPagar
        {
            get { return _faltaporpagar; }
            set { _faltaporpagar = value; lbl_total_faltante.Text = value; }
        }



        private void CargaTipoVenta()
        {

            dgTipoVenta parametro = new dgTipoVenta();

            List<dgTipoVenta> lista = c_tipoventa.LeerTipoVenta(1, parametro);

            if (lista.Count > 0)

            {
                
                foreach (dgTipoVenta d in lista)
                {
                    if (d.Descripcion=="Credito")
                    {

                    }
                    else
                    {
                        bx_tipoventa.Items.Add(d.Descripcion.ToString());
                       
                    }
                    
                }
            }


        }


        private void UserControlCredito_Load(object sender, EventArgs e)
        {
            CargaTipoVenta();
           
            lbl_cambio.Text = "";
        }

        private void txt_paga_con_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float restante = float.Parse(lbl_total_faltante.Text);

                float pagar = float.Parse(txt_paga_con.Text);

                float cambio = pagar - restante;

                cambio = (float)Math.Round(cambio, 2);

                

                if (restante < pagar)
                {
                    lbl_cambio.ForeColor = Color.Yellow;
                    lbl_cambio.Text = Convert.ToString(cambio);
                }

                else
                {
                    lbl_cambio.ForeColor = Color.Red;

                    lbl_cambio.Text = "0";


                }

            }
            catch
            {

            }







        }

        private void txt_paga_con_KeyPress(object sender, KeyPressEventArgs e)
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


                lbl_cambio.Visible= true;
                label11.Visible = true;
                txt_paga_con.Visible = true;
                label2.Visible = true;

            }

            else if (lbl_id_tipoventa.Text == "2") // transferencia
            {
             
                label11.Visible = false;
                lbl_cambio.Visible = false;
                txt_paga_con.Visible = false;
                label2.Visible = false;
                txt_paga_con.Text = "";
                lbl_cambio.Text = "";

            }
        }

        private void btn_realizar_venta_Click(object sender, EventArgs e)
        {

            string opcion = "";
            string concatanacionnombre = "", concatenacionotrosdatos = "", titulomsj = "", carateres = "--------------------------------------";

            string concatenacionfinal = "", concatenaciondatosventa = "";

            float restante, pagar, cambio;

            opcion = bx_tipoventa.Text;




            if (opcion == "Efectivo")
            {
                restante = float.Parse(lbl_total_faltante.Text);

                pagar = float.Parse(txt_paga_con.Text);

                cambio = pagar - restante;

                cambio = (float)Math.Round(cambio, 2);

                lbl_cambio.Text = Convert.ToString(cambio);

                

                if (restante < pagar)
                {

                    dgClienteCredito parametro2 = new dgClienteCredito
                    {
                        Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                        Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                    };

                    List<dgClienteCredito> lista2 = c_cliente_credito.LeerClienteCredito(333, parametro2);



                    if (lista2.Count > 0)
                    {
                        float debemsj;

                        foreach (dgClienteCredito d in lista2)
                        {
                            debemsj = float.Parse(lbl_total_venta.Text) - float.Parse(d.CantidadPagada.ToString());

                            titulomsj = "PAGAR TOTAL DEL CREDITO " + "\n";
                            concatanacionnombre = "Nombre Completo: " + d.Nombre.ToString() + " " + d.Apellido_Paterno.ToString() + " " + d.Apellido_Materno.ToString() + "\n";
                            concatenacionotrosdatos = "Domicilio: " + d.Direccion.ToString() + "\n" + "Telefono: " + d.Telefono.ToString() + "\n" + "Correo: " + d.Correo.ToString() + "\n";
                            concatenaciondatosventa = "Total del Credito: " + lbl_total_venta.Text + "\n" + "Cantidad Faltante:" + lbl_total_faltante.Text + "\n"+ "Cantidad a Abonar:"+ txt_paga_con.Text+ "\n"+ "Cambio: " + lbl_cambio.Text;

                            concatenacionfinal = titulomsj + carateres + "\n" + concatanacionnombre + concatenacionotrosdatos + carateres + "\n" + concatenaciondatosventa;
                        }
                    }



                    var confirmResult = MessageBox.Show(concatenacionfinal,
                        "Confirmar Venta Por Efectivo(Credito)!!",
                        MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {


                        dgClienteCredito parametro = new dgClienteCredito
                        {
                            Id_Venta = Convert.ToInt16(lbl_id_venta.Text),
                            CantidadPagada = float.Parse(lbl_total_faltante.Text),
                            CantidadPagadaUltima = float.Parse(lbl_total_faltante.Text),
                            FechaPago = DateTime.Now,
                            Validacion = 1,
                            Cambio = float.Parse(lbl_cambio.Text)
                        };



                        string control = "";

                        control = c_cliente_credito.ActualizarCreditoPago(1, parametro); // YA SE CARGO LO ABONADO EL TOTAL


                        dgClienteCredito parametro3 = new dgClienteCredito
                        {
                            Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                            Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                        };

                        List<dgClienteCredito> lista3 = c_cliente_credito.LeerClienteCredito(333, parametro3);



                        int contadorcreditos = 0;



                        if (lista3.Count > 0)
                        {
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


                                    Ticket1.TextoIzquierda("Direccion: " + d.Direccion.ToUpper().ToString());
                                    Ticket1.TextoIzquierda("Celular: " + d.Telefono.ToString());
                                    Ticket1.TextoCentro("==================================");
                                    Ticket1.TextoIzquierda("");
                                    Ticket1.TextoIzquierda("Numero de Venta: " + lbl_id_venta.Text);
                                    Ticket1.TextoIzquierda("");
                                    Ticket1.TextoCentro("==================================");

                                }


                                Ticket1.TextoCentro("Recibo de venta (Credito) (Liquidado)");
                                Ticket1.TextoCentro("Los Precios ya contienen IVA");

                                Ticket1.TextoIzquierda(" -> Fecha de Pago: " + DateTime.Now.ToShortDateString() + "  ->Hora: " + DateTime.Now.ToShortTimeString());
                                Ticket1.TextoIzquierda("");
                            }


                            dgClienteCredito parametro5 = new dgClienteCredito
                            {
                                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                                Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                            };

                            List<dgClienteCredito> lista5 = c_cliente_credito.LeerClienteCredito(333, parametro5);



                            if (lista5.Count > 0)

                            {
                                foreach (dgClienteCredito d in lista5)
                                {

                                    Ticket1.TextoIzquierda("Nombre del Cliente: " + d.Nombre.ToString() + " " + d.Apellido_Paterno.ToString() + " " + d.Apellido_Materno.ToString());
                                    Ticket1.TextoCentro("==================================");
                                }
                            }


                            clsventas.CreaRecibo.LineasGuion();

                            clsventas.CreaRecibo.EncabezadoVenta();


                            dgTicket parametroticket = new dgTicket
                            {
                                Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                            };

                            List<dgTicket> listaProductosVenta = c_ticket.Ticket(1, parametroticket);


                            if (listaProductosVenta.Count > 0)

                            {

                                string concatenacion = "";
                                double subtotal, sub;
                                foreach (dgTicket d in listaProductosVenta)
                                {
                                    sub = double.Parse(d.SubTotal.ToString());

                                    subtotal = (double)Math.Round(sub, 2);


                                    concatenacion = "(" + d.Id_Producto.ToString() + ")" + " " + d.NombreProducto.ToString();
                                    Ticket1.AgregaArticulo(concatenacion, double.Parse(d.PrecioComprado.ToString()), Convert.ToInt16(d.CantidadComprada.ToString()), double.Parse(subtotal.ToString()));
                                    clsventas.CreaRecibo.LineasGuion();
                                }
                            }

                            Ticket1.TextoIzquierda(" ");
                            Ticket1.AgregaTotales("Total", double.Parse(lbl_total_venta.Text));



                            dgClienteCredito parametro4 = new dgClienteCredito
                            {
                                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                                Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                            };

                            List<dgClienteCredito> lista4 = c_cliente_credito.LeerClienteCredito(333, parametro4);



                            if (lista4.Count > 0)

                            {
                                foreach (dgClienteCredito d in lista4)
                                {

                                    Ticket1.TextoIzquierda(" ");
                                    Ticket1.AgregaTotales("Abonado con :", double.Parse(d.CantidadPagada.ToString()));

                                    Ticket1.TextoIzquierda(" ");

                                    float debe = float.Parse(lbl_total_venta.Text) - float.Parse(d.CantidadPagada.ToString());
                                    Ticket1.AgregaTotales("Cantidad que falta por pagar: ", debe);



                                    Ticket1.TextoIzquierda(" ");
                                    Ticket1.AgregaTotales("Cambio :", double.Parse(lbl_cambio.Text));

                                    Ticket1.TextoIzquierda(" ");

                                    Ticket1.TextoCentro("****** LIQUIDADO   ******");
                                }

                            }





                            if (listaticketinfo.Count > 0)

                            {
                                Ticket1.TextoIzquierda(" ");
                                Ticket1.TextoCentro("=================================================");

                                foreach (dgTicket d in listaticketinfo)
                                {

                                    Ticket1.TextoCentro(d.Mensaje.ToUpper().ToString());



                                }
                                Ticket1.TextoCentro("===================================================");
                                Ticket1.TextoIzquierda(" ");


                            }



                            string impresora = "Microsoft XPS Document Writer";
                            Ticket1.ImprimirTiket(impresora);


                            MessageBox.Show("Abono Realizada Por Efectivo Liquidado");
                        }




                    }



                }

                else
                {




                    dgClienteCredito parametro2 = new dgClienteCredito
                    {
                        Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                        Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                    };

                    List<dgClienteCredito> lista2 = c_cliente_credito.LeerClienteCredito(333, parametro2);



                    if (lista2.Count > 0)
                    {
                        float debemsj;

                        foreach (dgClienteCredito d in lista2)
                        {
                            debemsj = float.Parse(lbl_total_venta.Text) - float.Parse(d.CantidadPagada.ToString());

                            titulomsj = "PAGAR ABONO DEL CREDITO " + "\n";
                            concatanacionnombre = "Nombre Completo: " + d.Nombre.ToString() + " " + d.Apellido_Paterno.ToString() + " " + d.Apellido_Materno.ToString() + "\n";
                            concatenacionotrosdatos = "Domicilio: " + d.Direccion.ToString() + "\n" + "Telefono: " + d.Telefono.ToString() + "\n" + "Correo: " + d.Correo.ToString() + "\n";
                            concatenaciondatosventa = "Total del Credito: " + lbl_total_venta.Text + "\n" +"Credito faltante:"+lbl_total_faltante.Text+"\n"+ "Abono: "+txt_paga_con.Text.ToString();

                            concatenacionfinal = titulomsj + carateres + "\n" + concatanacionnombre + concatenacionotrosdatos + carateres + "\n" + concatenaciondatosventa;
                        }
                    }



                    var confirmResult = MessageBox.Show(concatenacionfinal,
                        "Confirmar Venta Por Efectivo(Credito)!!",
                        MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {


                        lbl_cambio.Text = "0";

                        dgClienteCredito parametro = new dgClienteCredito
                        {
                            Id_Venta = Convert.ToInt16(lbl_id_venta.Text),
                            CantidadPagada = float.Parse(txt_paga_con.Text.Trim()),
                            CantidadPagadaUltima = float.Parse(txt_paga_con.Text.Trim()),
                            FechaUltimoPago = DateTime.Now,
                            Validacion = 0
                        };



                        string control = "";

                        control = c_cliente_credito.ActualizarCreditoPago(0, parametro); //ABONO 



                        dgClienteCredito parametro3 = new dgClienteCredito
                        {
                            Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                            Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                        };

                        List<dgClienteCredito> lista3 = c_cliente_credito.LeerClienteCredito(333, parametro3);



                        int contadorcreditos = 0;



                        if (lista3.Count > 0)
                        {
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


                                    Ticket1.TextoIzquierda("Direccion: " + d.Direccion.ToUpper().ToString());
                                    Ticket1.TextoIzquierda("Celular: " + d.Telefono.ToString());
                                    Ticket1.TextoCentro("==================================");
                                    Ticket1.TextoIzquierda("");
                                    Ticket1.TextoIzquierda("Numero de Venta: " + lbl_id_venta.Text);
                                    Ticket1.TextoIzquierda("");
                                    Ticket1.TextoCentro("==================================");

                                }


                                Ticket1.TextoCentro("Recibo de venta (Credito) (Abono)");


                                Ticket1.TextoIzquierda(" -> Fecha de Abono: " + DateTime.Now.ToShortDateString() + "  ->Hora: " + DateTime.Now.ToShortTimeString());
                                Ticket1.TextoIzquierda("");
                            }


                            dgClienteCredito parametro5 = new dgClienteCredito
                            {
                                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                                Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                            };

                            List<dgClienteCredito> lista5 = c_cliente_credito.LeerClienteCredito(333, parametro5);



                            if (lista5.Count > 0)

                            {
                                foreach (dgClienteCredito d in lista5)
                                {

                                    Ticket1.TextoIzquierda("Nombre del Cliente: " + d.Nombre.ToString() + " " + d.Apellido_Paterno.ToString() + " " + d.Apellido_Materno.ToString());
                                    Ticket1.TextoCentro("==================================");
                                }
                            }


                            clsventas.CreaRecibo.LineasGuion();

                            clsventas.CreaRecibo.EncabezadoVenta();


                            dgTicket parametroticket = new dgTicket
                            {
                                Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                            };

                            List<dgTicket> listaProductosVenta = c_ticket.Ticket(1, parametroticket);


                            if (listaProductosVenta.Count > 0)

                            {

                                string concatenacion = "";
                                double subtotal, sub;
                                foreach (dgTicket d in listaProductosVenta)
                                {
                                    sub = double.Parse(d.SubTotal.ToString());

                                    subtotal = (double)Math.Round(sub, 2);


                                    concatenacion = "(" + d.Id_Producto.ToString() + ")" + " " + d.NombreProducto.ToString();
                                    Ticket1.AgregaArticulo(concatenacion, double.Parse(d.PrecioComprado.ToString()), Convert.ToInt16(d.CantidadComprada.ToString()), double.Parse(subtotal.ToString()));
                                    clsventas.CreaRecibo.LineasGuion();
                                }
                            }

                            Ticket1.TextoIzquierda(" ");
                            Ticket1.AgregaTotales("Total", double.Parse(lbl_total_venta.Text));



                            dgClienteCredito parametro4 = new dgClienteCredito
                            {
                                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                                Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                            };

                            List<dgClienteCredito> lista4 = c_cliente_credito.LeerClienteCredito(333, parametro4);



                            if (lista4.Count > 0)

                            {
                                foreach (dgClienteCredito d in lista4)
                                {

                                    Ticket1.TextoIzquierda(" ");
                                    Ticket1.AgregaTotales("Total Abono :", double.Parse(d.CantidadPagada.ToString()));

                                    Ticket1.TextoIzquierda(" ");

                                    float debe = float.Parse(lbl_total_venta.Text) - float.Parse(d.CantidadPagada.ToString());
                                    Ticket1.AgregaTotales("Cantidad que falta por pagar: ", debe);
                                    Ticket1.TextoCentro("****** ABONADO   ******");
                                }

                            }





                            if (listaticketinfo.Count > 0)

                            {
                                Ticket1.TextoIzquierda(" ");
                                Ticket1.TextoCentro("=================================================");

                                foreach (dgTicket d in listaticketinfo)
                                {

                                    Ticket1.TextoCentro(d.Mensaje.ToUpper().ToString());



                                }
                                Ticket1.TextoCentro("===================================================");
                                Ticket1.TextoIzquierda(" ");


                            }



                            string impresora = "Microsoft XPS Document Writer";
                            Ticket1.ImprimirTiket(impresora);


                            MessageBox.Show("Abono Realizada Por Efectivo Abonado");
                        }




                    }





















                }

                ((Form)this.TopLevelControl).Close();


               
            }

            else if (opcion == "Transferencia")
            {




                dgClienteCredito parametro2 = new dgClienteCredito
                {
                    Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                    Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                };

                List<dgClienteCredito> lista2 = c_cliente_credito.LeerClienteCredito(333, parametro2);



                if (lista2.Count > 0)
                {
                    float debemsj;

                    foreach (dgClienteCredito d in lista2)
                    {
                        debemsj = float.Parse(lbl_total_venta.Text) - float.Parse(d.CantidadPagada.ToString());

                        titulomsj = "PAGAR TOTAL DEL CREDITO " + "\n";
                        concatanacionnombre = " Transferencia por:Nombre Completo: " + d.Nombre.ToString() + " " + d.Apellido_Paterno.ToString() + " " + d.Apellido_Materno.ToString() + "\n";
                        concatenacionotrosdatos = "Domicilio: " + d.Direccion.ToString() + "\n" + "Telefono: " + d.Telefono.ToString() + "\n" + "Correo: " + d.Correo.ToString() + "\n";
                        concatenaciondatosventa = "Total del Credito: " + lbl_total_venta.Text + "\n" + "Credito Faltante: " + lbl_total_faltante.Text + "\n"+ "Abono:" + lbl_total_faltante.Text;

                        concatenacionfinal = titulomsj + carateres + "\n" + concatanacionnombre + concatenacionotrosdatos + carateres + "\n" + concatenaciondatosventa;
                    }
                }



                var confirmResult = MessageBox.Show(concatenacionfinal,
                    "Confirmar Venta Por Transferencia(Credito)!!",
                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {


                    dgClienteCredito parametro = new dgClienteCredito
                    {
                        Id_Venta = Convert.ToInt16(lbl_id_venta.Text),
                        CantidadPagada = float.Parse(lbl_total_faltante.Text),
                        FechaPago = DateTime.Now,
                        Validacion = 2,

                    };



                    string control = "";

                    control = c_cliente_credito.ActualizarCreditoPago(0, parametro); // YA SE CARGO LO ABONADO EL TOTAL


                    dgClienteCredito parametro3 = new dgClienteCredito
                    {
                        Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                        Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                    };

                    List<dgClienteCredito> lista3 = c_cliente_credito.LeerClienteCredito(333, parametro3);



                    int contadorcreditos = 0;



                    if (lista3.Count > 0)
                    {
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


                                Ticket1.TextoIzquierda("Direccion: " + d.Direccion.ToUpper().ToString());
                                Ticket1.TextoIzquierda("Celular: " + d.Telefono.ToString());
                                Ticket1.TextoCentro("==================================");
                                Ticket1.TextoIzquierda("");
                                Ticket1.TextoIzquierda("Numero de Venta: " + lbl_id_venta.Text);
                                Ticket1.TextoIzquierda("");
                                Ticket1.TextoCentro("==================================");

                            }


                            Ticket1.TextoCentro("Recibo de Transferencia (Credito) (Liquidado)");


                            Ticket1.TextoIzquierda(" -> Fecha de Transferencia: " + DateTime.Now.ToShortDateString() + "  ->Hora: " + DateTime.Now.ToShortTimeString());
                            Ticket1.TextoIzquierda("");
                        }


                        dgClienteCredito parametro5 = new dgClienteCredito
                        {
                            Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                            Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                        };

                        List<dgClienteCredito> lista5 = c_cliente_credito.LeerClienteCredito(333, parametro5);



                        if (lista5.Count > 0)

                        {
                            foreach (dgClienteCredito d in lista5)
                            {

                                Ticket1.TextoIzquierda("Nombre del Cliente: " + d.Nombre.ToString() + " " + d.Apellido_Paterno.ToString() + " " + d.Apellido_Materno.ToString());
                                Ticket1.TextoCentro("==================================");
                            }
                        }


                        clsventas.CreaRecibo.LineasGuion();

                        clsventas.CreaRecibo.EncabezadoVenta();


                        dgTicket parametroticket = new dgTicket
                        {
                            Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                        };

                        List<dgTicket> listaProductosVenta = c_ticket.Ticket(1, parametroticket);


                        if (listaProductosVenta.Count > 0)

                        {

                            string concatenacion = "";
                            double subtotal, sub;
                            foreach (dgTicket d in listaProductosVenta)
                            {
                                sub = double.Parse(d.SubTotal.ToString());

                                subtotal = (double)Math.Round(sub, 2);


                                concatenacion = "(" + d.Id_Producto.ToString() + ")" + " " + d.NombreProducto.ToString();
                                Ticket1.AgregaArticulo(concatenacion, double.Parse(d.PrecioComprado.ToString()), Convert.ToInt16(d.CantidadComprada.ToString()), double.Parse(subtotal.ToString()));
                                clsventas.CreaRecibo.LineasGuion();
                            }
                        }

                        Ticket1.TextoIzquierda(" ");
                        Ticket1.AgregaTotales("Total", double.Parse(lbl_total_venta.Text));



                        dgClienteCredito parametro4 = new dgClienteCredito
                        {
                            Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                            Id_Venta = Convert.ToInt16(lbl_id_venta.Text)
                        };

                        List<dgClienteCredito> lista4 = c_cliente_credito.LeerClienteCredito(333, parametro4);



                        if (lista4.Count > 0)

                        {
                            foreach (dgClienteCredito d in lista4)
                            {

                                Ticket1.TextoIzquierda(" ");
                                Ticket1.AgregaTotales("Abonado con :", double.Parse(d.CantidadPagada.ToString()));

                                Ticket1.TextoIzquierda(" ");

                                float debe = float.Parse(lbl_total_venta.Text) - float.Parse(d.CantidadPagada.ToString());
                                Ticket1.AgregaTotales("Cantidad que falta por pagar: ", debe);




                                Ticket1.TextoIzquierda(" ");
                                Ticket1.TextoCentro("****** TRANSFERENCIA    ******");
                                Ticket1.TextoCentro("****** LIQUIDADO    ******");
                            }

                        }





                        if (listaticketinfo.Count > 0)

                        {
                            Ticket1.TextoIzquierda(" ");
                            Ticket1.TextoCentro("=================================================");

                            foreach (dgTicket d in listaticketinfo)
                            {

                                Ticket1.TextoCentro(d.Mensaje.ToUpper().ToString());



                            }
                            Ticket1.TextoCentro("===================================================");
                            Ticket1.TextoIzquierda(" ");


                        }



                        string impresora = "Microsoft XPS Document Writer";
                        Ticket1.ImprimirTiket(impresora);


                        MessageBox.Show("Abono Realizada Por Tranferencia Liquidado");
                        ((Form)this.TopLevelControl).Close();
                    }




                }
            }

           
            //}
            //catch
            //{
            //    MessageBox.Show("LLene el campo de pago ");
            //}
        }

        private void lbl_total_faltante_Click(object sender, EventArgs e)
        {

        }
    }
}
