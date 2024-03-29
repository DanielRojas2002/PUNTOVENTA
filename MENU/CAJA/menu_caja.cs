﻿using Punto_de_Venta;
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

namespace PUNTOVENTA.MENU.CAJA
{
    public partial class menu_caja : Form
    {
        public menu_caja()
        {
            InitializeComponent();
        }

        public float _dineroventas = 0;

        private void menu_caja_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

       

        private void CargarVentas()
        {

          dataGridView_ventas.Rows.Clear();
          dataGridView_p_credito.Rows.Clear();
          _dineroventas = 0;

          dgCaja parametro = new dgCaja
          {
            FechaInicio = DateTime.Now

          };

          int fila = 0;


            List<dgCaja> lista = c_caja.LeerCaja(1, parametro);


            if (lista.Count > 0)

            {
                string fechaventa;
                float subtotal;
                foreach (dgCaja d in lista)
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

            dgCaja parametro2 = new dgCaja
            {
                FechaInicio = DateTime.Now

            };




            List<dgCaja> lista2 = c_caja.LeerCaja(6, parametro2);


            if (lista2.Count > 0)

            {
                string fechaventa,fechaultimopago;
                float subtotal,cantidadpagada;

                foreach (dgCaja d in lista2)
                {


                    fila = fila + 1;
                    subtotal = float.Parse(d.SubTotalProducto.ToString());

                    subtotal = (float)Math.Round(subtotal, 2);



                    fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");


                    dataGridView_p_credito.Rows.Add(d.Id_Venta.ToString(), d.IdProducto.ToString(), d.NombreProducto.ToString(),
                         d.PrecioProducto.ToString(), d.CantidadProducto.ToString(), Convert.ToString(subtotal), Convert.ToString(""), fechaventa, d.DescripcionTipoVenta.ToString(), d.Usuario.ToString());



                }



            }

            else
            {

              

            }


            dgCaja parametro3 = new dgCaja
            {
                FechaInicio = DateTime.Now

            };

            
          



            List<dgCaja> lista3 = c_caja.LeerCaja(8, parametro2);
           

            if (lista3.Count > 0)

            {
                string fechaventa, fechaultimopago;
                float subtotal, cantidadpagada;

                foreach (dgCaja d in lista3)
                {
                   
                  
                   

                    cantidadpagada = float.Parse(d.CantidadPagada.ToString());

                    cantidadpagada = (float)Math.Round(cantidadpagada, 2);

                    fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");

                  

                    dataGridView_p_credito.Rows.Add(d.Id_Venta.ToString(), "", "",
                       "", "", "", Convert.ToString(cantidadpagada), fechaventa, "", "");

                  

                    _dineroventas = _dineroventas + float.Parse(d.CantidadPagada.ToString());

                }

                foreach (dgCaja d in lista3)
                {

                    dataGridView_p_credito.Rows[fila].DefaultCellStyle.BackColor = Color.LightYellow;
                    fila = fila + 1;

                }



                }

            else
            {



            }

            dataGridView_devoluciones.Rows.Clear();


            dgCaja parametro4 = new dgCaja
            {
                FechaCaja = DateTime.Now

            };




            List<dgCaja> lista4 = c_caja.LeerCaja(9, parametro4);

            float cantidaddevuelta = 0;
            if (lista4.Count > 0)

            {
                string fechadevolucion;
                float subtotal;
                
                foreach (dgCaja d in lista4)
                {
                    subtotal = float.Parse(d.SubTotalProducto.ToString());

                    subtotal = (float)Math.Round(subtotal, 2);

                    fechadevolucion = d.FechaDevolucion.Value.ToString("dd/MM/yyyy");
                    dataGridView_devoluciones.Rows.Add(d.Id_Devolucion.ToString(), d.Id_Venta.ToString(), d.IdProducto.ToString(), d.NombreProducto.ToString(),
                         d.CantidadProducto.ToString(), d.PrecioProducto.ToString(), Convert.ToString(subtotal), d.Usuario.ToString(), fechadevolucion);


                   

                    cantidaddevuelta = cantidaddevuelta + float.Parse(d.SubTotalProducto.ToString());
                }

              
            }

            else
            {



            }

            cantidaddevuelta = (float)Math.Round(cantidaddevuelta, 2);

           
            lbl_devolucion.Text = Convert.ToString(cantidaddevuelta);









            _dineroventas = (float)Math.Round(_dineroventas, 2);

            lbl_cantidad_vendida.Text = Convert.ToString(_dineroventas);

        }

        private void CargaAbono()
        {


            dgCaja parametro = new dgCaja
            {
                FechaCaja = DateTime.Now

            };




            List<dgCaja> lista = c_caja.LeerCaja(2, parametro);


            if (lista.Count > 0)

            {
                
                foreach (dgCaja d in lista)
                {
                    

                    lbl_abonado_total.Text = Convert.ToString(d.CantidadAbonada.ToString());
                }
                


            }

            else
            {

               // MessageBox.Show("No a abonado en Caja");

            }
        }


        private void CargaRetiro()
        {


            dgCaja parametro = new dgCaja
            {
                FechaCaja = DateTime.Now

            };




            List<dgCaja> lista = c_caja.LeerCaja(4, parametro);


            if (lista.Count > 0)

            {

                foreach (dgCaja d in lista)
                {


                    lbl_retirado.Text = Convert.ToString(d.CantidadRetirada.ToString());
                }



            }

            else
            {

                //MessageBox.Show("No a Retirado Nada");

            }
        }

        private void CargaVentaAbonos()
        {


            dgCaja parametro = new dgCaja
            {
                FechaCaja = DateTime.Now

            };




            List<dgCaja> lista = c_caja.LeerCaja(3, parametro);


            if (lista.Count > 0)

            {
                float suma;
                float cantidadva ;
                foreach (dgCaja d in lista)
                {
                    cantidadva = float.Parse(d.CantidadVA.ToString());
                    suma = (float)Math.Round(cantidadva, 2);

                    lbl_caja.Text = Convert.ToString(suma);
                }



            }

            else
            {

                //MessageBox.Show("No a abonado en Caja");

            }
        }

        private void Caja(int estatuscaja)
        {
            if (estatuscaja==1)
            {
                dgCaja parametro = new dgCaja
                {
                    FechaCaja = DateTime.Now,
                    IdCajaEstatus=1

                };

                string control = "";

                control = c_caja.CajaEstatus(parametro);

                MessageBox.Show("Caja Abierta");


            }

            else if (estatuscaja == 2)
            {

                dgCaja parametro = new dgCaja
                {
                    FechaCaja = DateTime.Now,
                    IdCajaEstatus = 2

                };

                string control = "";

                control = c_caja.CajaEstatus(parametro);

                MessageBox.Show("Caja Cerrada");
            }
            CargaEstatusCaja();
        }
        private void CargaEstatusCaja()
        {


            dgCaja parametro = new dgCaja
            {
                FechaCaja = DateTime.Now

            };




            List<dgCaja> lista = c_caja.LeerCaja(5, parametro);


            if (lista.Count > 0)

            {

                foreach (dgCaja d in lista)
                {
                    lbl_id_caja.Text = d.Id_CajaEstatus.ToString();
                }


                if (lbl_id_caja.Text == "1")
                {
                    btn_caja.Text = "CERRAR";
                    btn_caja.ForeColor = Color.Red;

                   

                }

                else if (lbl_id_caja.Text == "2")
                {
                    btn_caja.Text = "ABRIR";
                    btn_caja.ForeColor = Color.Green;
                  

                }

            }

            else
            {

               // MessageBox.Show("No a abonado en Caja");

            }
        }
        private void InsertCaja()
        {


            dgCaja parametro = new dgCaja
            {
                CantidadAbonada = 0,
                CantidadRetirada = 0,
                CantidadVenta = float.Parse(lbl_cantidad_vendida.Text),
                FechaCaja = DateTime.Now

            };

            string control = ""; 

            control=c_caja.InsertarCaja(parametro);

           

        }

        private void ActualizarCaja()
        {

            float cantidad_vendida;
            float abonado;
            float retirado;
            float cajatotal;
            float devolucion;

            cantidad_vendida = float.Parse(lbl_cantidad_vendida.Text);
            abonado = float.Parse(lbl_abonado_total.Text);
            retirado = float.Parse(lbl_retirado.Text);
            devolucion = float.Parse(lbl_devolucion.Text);

            cajatotal = cantidad_vendida + abonado - retirado-devolucion;

         

            dgCaja parametro = new dgCaja
            {

                CantidadTotal = cajatotal,
                CantidadVenta= cantidad_vendida,


                FechaCaja = DateTime.Now

            };

            string control = "";

            control = c_caja.ActualizarCaja(parametro);



        }

        private void AbonarCaja()
        {

            float cantidadabonada;

            cantidadabonada = float.Parse(txt_abonar.Text);

            cantidadabonada = (float)Math.Round(cantidadabonada, 2);


            dgCaja parametro = new dgCaja
            {
                CantidadAbonada = cantidadabonada,
                FechaCaja = DateTime.Now

            };

            string control = "";

            control = c_caja.AbonarCaja(parametro);

            MessageBox.Show("Cantidad Abonada Satiscatoriamente");

            txt_abonar.Text = "";

            CargarVentas();
            InsertCaja();

            CargaAbono();
            CargaVentaAbonos();
            CargaRetiro();
            CargaEstatusCaja();

            ActualizarCaja();
            CargaVentaAbonos();
           



        }

        private void RetirarCaja()
        {
            float totalcaja = float.Parse(lbl_caja.Text);
            float retirar = float.Parse(txt_retirar.Text);

            if (txt_retirar.Text!="")
            {
                if (retirar < totalcaja)
                {
                    dgCaja parametro = new dgCaja
                    {
                        CantidadRetirada = float.Parse(txt_retirar.Text),
                        FechaCaja = DateTime.Now

                    };

                    string control = "";

                    control = c_caja.RetirarCaja(parametro);

                    MessageBox.Show("Cantidad Retirada Satiscatoriamente");

                    txt_retirar.Text = "";

                    CargaAbono();
                    CargaVentaAbonos();
                 
                }

                else
                {
                    MessageBox.Show("No se puede retirar tal fondo");
                    txt_retirar.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ingrese la Cantidad a Retirar");
            }
            



        }

     
        private void menu_caja_Load(object sender, EventArgs e)
        {

            
               
            

           

            try
            {
               
                CargarVentas();
                InsertCaja();



                CargaAbono();
              
                CargaRetiro();
                CargaEstatusCaja();

                
                CargaVentaAbonos();
                

                ActualizarCaja();
                CargaVentaAbonos();

            }
            catch
            {

            } 




           
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_abonado_total_Click(object sender, EventArgs e)
        {

        }

        private void txt_abonar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_retirar_TextChanged(object sender, EventArgs e)
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

        private void txt_retirar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_caja_Click(object sender, EventArgs e)
        {

            if (lbl_id_caja.Text == "1")
            {
               

                Caja(2);


                var confirmResultticket = MessageBox.Show("Desea imprimit Ticket?",
               "Ticket Caja",
               MessageBoxButtons.YesNo);

                if (confirmResultticket == DialogResult.Yes)
                {
                    TicketCaja();
                }



                   

            }

            else if (lbl_id_caja.Text == "2")
            {
               
                Caja(1);



            }
        }

        private void TicketCaja()
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
                    Ticket1.TextoCentro( d.Telefono.ToString());
                    Ticket1.TextoIzquierda("");
                }


                Ticket1.TextoIzquierda("Recibo de Ventas");
                Ticket1.TextoIzquierda("Los Precios ya contienen IVA");
               

                Ticket1.TextoIzquierda("Fecha de Caja: " + DateTime.Now.ToShortDateString());
                Ticket1.TextoIzquierda("");
            }


           

            dgTicket parametroticket = new dgTicket
            {
                FechaVenta = DateTime.Now
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
                double subtotal, sub,cantidadcomprada,preciocomprado;
                foreach (dgTicket d in listaProductosVenta)
                {
                    preciocomprado = double.Parse(d.PrecioComprado.ToString());

                    cantidadcomprada = Convert.ToInt16(d.CantidadComprada.ToString());

                    sub = preciocomprado*cantidadcomprada;

                    subtotal = (double)Math.Round(sub, 2);


                    concatenacion =  d.NombreProducto.ToString();



                    Ticket1.TextoIzquierda(d.DescripcionTipoVenta.ToString());
                    Ticket1.TextoIzquierda(concatenacion);
                    Ticket1.AgregaArticulo("(" + d.Id_Producto.ToString() + ")" , double.Parse(d.PrecioComprado.ToString()), Convert.ToInt16(d.CantidadComprada.ToString()), double.Parse(subtotal.ToString()));
                    clsventas.CreaRecibo.LineasGuion();
                }
            }

            Ticket1.TextoIzquierda("");




            dgTicket parametroticket2 = new dgTicket
            {
                FechaVenta = DateTime.Now
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
                FechaVenta = DateTime.Now
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


                    concatenacion =  d.NombreProducto.ToString();
                 
                    Ticket1.TextoIzquierda(d.DescripcionTipoVenta.ToString() );
                    Ticket1.TextoIzquierda(concatenacion);
                    Ticket1.AgregaArticulo("(" + d.Id_Producto.ToString() + ")", double.Parse(d.PrecioComprado.ToString()), Convert.ToInt16(d.CantidadComprada.ToString()), double.Parse(subtotal.ToString()));
                    clsventas.CreaRecibo.LineasGuion();
                }
            }



            Ticket1.TextoIzquierda(" "); 
            Ticket1.AgregaTotales("Total Venta", double.Parse(lbl_cantidad_vendida.Text));
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Abonado con :", double.Parse(lbl_abonado_total.Text));

            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Devolucion :", double.Parse(lbl_devolucion.Text));

            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Retirado Caja", double.Parse(lbl_retirado.Text));

            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total Caja ", double.Parse(lbl_caja.Text));




            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("========================");
            Ticket1.TextoCentro("TICKET DE CAJA ");
            Ticket1.TextoCentro("========================");
            Ticket1.TextoIzquierda(" ");
           


            
            Ticket1.ImprimirTiket(impresora);
            MessageBox.Show("Ticket Generado Satisfactoriamente");

            RegresarVentana();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_abonar_Click(object sender, EventArgs e)
        {

            if (txt_abonar.Text != "")
            {

                if (lbl_id_caja.Text == "2")
                {
                    MessageBox.Show("Caja Cerrada");
                    txt_abonar.Text = "";
                }

                else
                {
                    AbonarCaja();
                }
            }
            else
            {
                MessageBox.Show("Ingrese la Cantidad a Abonar");
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
            Inicio formulario = new Inicio();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();



        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {

            if (txt_retirar.Text != "" )
            {

                if (lbl_id_caja.Text == "2")
                {
                    MessageBox.Show("Caja Cerrada");
                    txt_retirar.Text = "";
                }

                else
                {
                    RetirarCaja();
                    CargaAbono();
                    CargaVentaAbonos();
                    CargaRetiro();
                }
               
            } 


            else
            {
                MessageBox.Show("Ingrese la Cantidad a Retirar");
            }

           
        }

        private void RetirarCajaTodo()
        {
           
            dgCaja parametro = new dgCaja
            {
                FechaCaja = DateTime.Now

            };

            string control = "";

            control = c_caja.RetirarCajaTodo(parametro);

            txt_retirar.Text = "";

            
            RegresarVentana();






        }

        private void btn_retirar_todo_caja_Click(object sender, EventArgs e)
        {
            if (lbl_id_caja.Text == "2")
            {
                MessageBox.Show("Caja Cerrada");
                txt_retirar.Text = "";
            }

            else
            {

                var confirmResult = MessageBox.Show("Desea retirar todos los fondos de la Caja?",
                    "Retirar Fondos !",
                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    RetirarCajaTodo();
                    ActualizarCaja();
                }


                  
               
            }
        }

        private void dataGridView_p_credito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_devoluciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
