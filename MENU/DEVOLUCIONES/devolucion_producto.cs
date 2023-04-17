using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Punto_de_Venta;
using Punto_de_Venta.Clases;
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

namespace PUNTOVENTA.MENU.DEVOLUCIONES
{
    public partial class devolucion_producto : Form
    {
        public devolucion_producto()
        {
            InitializeComponent();
           
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
            devoluciones formulario = new devoluciones();
            formulario.lbl_id.Text = id;

           
            formulario.Show();





        }

        private void CargarDatosProducto()
        {
            


            dgDevolucion parametro3 = new dgDevolucion
            {
                Id_Venta = Convert.ToInt16(lbl_id_venta.Text),
                IdProducto = Convert.ToString(lbl_idProducto.Text)
                
            };



            List<dgDevolucion> lista2 = c_devolucion.LeerDevolucion(2, parametro3);

            if (lista2.Count > 0)

            {
                float subtotal,sub;
                foreach (dgDevolucion d in lista2)
                {
                    lbl_producto.Text = Convert.ToString(d.IdProducto.ToString() + " " + d.NombreProducto.ToString());
                    lbl_precio.Text = d.PrecioProducto.ToString();
                    

                   
                }

                

            }
        }

        private void TicketDevolucion()
        {
            try
            {
                if (lbl_id_venta.Text != "")
                {
                    string txtticket = lbl_id_venta.Text;
                    string impresora = "";



                    dgReportes parametro = new dgReportes
                    {
                        Id_Venta = Convert.ToInt16(lbl_id_venta.Text)

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


                                Ticket1.TextoIzquierda(d.Colonia.ToUpper().ToString());
                                Ticket1.TextoIzquierda(d.Calle.ToUpper().ToString());
                                Ticket1.TextoIzquierda(d.Telefono.ToString());
                                Ticket1.TextoIzquierda("");
                            }


                            Ticket1.TextoIzquierda("Recibo de Devolucion");
                            Ticket1.TextoIzquierda("Los Precios ya contienen IVA");



                            Ticket1.TextoIzquierda("");
                        }

                        Ticket1.TextoIzquierda("Recibo:" + txtticket);
                        clsventas.CreaRecibo.EncabezadoVenta();
                        clsventas.CreaRecibo.LineasGuion();

                        string fechaventa;
                        float subtotal;

                        float sumaventa = 0;
                        float sumadevolucion = 0;

                        Ticket1.TextoIzquierda("Ventas");

                        foreach (dgReportes d in lista)
                        {
                            subtotal = float.Parse(d.SubTotalProducto.ToString());

                            subtotal = (float)Math.Round(subtotal, 2);

                            sumaventa = sumaventa + subtotal;

                            fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");

                            concatenacion = "(" + d.IdProducto.ToString() + ")" + " " + d.NombreProducto.ToString();
                            Ticket1.TextoIzquierda(" ");
                            Ticket1.TextoIzquierda(d.DescripcionTipoVenta.ToString());
                            Ticket1.AgregaArticulo(concatenacion, double.Parse(d.PrecioProducto.ToString()), Convert.ToInt16(d.CantidadProducto.ToString()), double.Parse(subtotal.ToString()));
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
                                Id_Venta = Convert.ToInt16(lbl_id_venta.Text)

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

                                    sumadevolucion = sumadevolucion + subtotal;
                                    fechadevolucion = d.FechaDevolucion.Value.ToString("dd/MM/yyyy");

                                    concatenacion = "(" + d.IdProducto.ToString() + ")" + " " + d.NombreProducto.ToString();
                                    Ticket1.TextoIzquierda(" ");

                                    Ticket1.AgregaArticulo(concatenacion, double.Parse(d.PrecioProducto.ToString()), Convert.ToInt16(d.CantidadProducto.ToString()), double.Parse(subtotal.ToString()));
                                    clsventas.CreaRecibo.LineasGuion();
                                }


                            }

                            else
                            {



                            }

                        }

                        float sumarestanteventa = 0;

                        sumarestanteventa = sumaventa - sumadevolucion;

                        float sumadevolucionsinlonuevo = 0;

                        sumadevolucionsinlonuevo = sumadevolucion - float.Parse(lbl_cantidad_regresar.Text);



                        Ticket1.TextoIzquierda("Total Venta:" + Convert.ToString(sumaventa));

                        Ticket1.TextoIzquierda("Cantidad a Devolver:" + lbl_cantidad_regresar.Text);

                       

                    

                        Ticket1.TextoCentro("==================================");
                        Ticket1.TextoCentro("TICKET DE DEVOLUCION ");
                        Ticket1.TextoCentro("==================================");

                        Ticket1.ImprimirTiket(impresora);
                        MessageBox.Show("Ticket Generado Satisfactoriamente");

                    }

                   
                }

            }
            catch
            {
                MessageBox.Show("Respete la Sintaxis");
            }




        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {
            int cantidadactual = Convert.ToInt16( lbl_cantidad_actual.Text);

            
           
            if (cantidadactual >= txt_num_regresar.Value)
            {
                var confirmResult = MessageBox.Show("Desea  hacer la Devolucion?",
                    "Confirmar Devolucion!!",
                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {

                    int cantidadregresar = (int)txt_num_regresar.Value;
                    float precio = float.Parse(lbl_precio.Text);


                    float cantidaddevolucion = cantidadregresar * precio;
                    dgDevolucion parametro = new dgDevolucion
                    {
                        IdProducto = Convert.ToString(lbl_idProducto.Text),
                        Id_Venta = Convert.ToInt16(lbl_id_venta.Text),

                        Cantidad = Convert.ToInt16(txt_num_regresar.Value),

                        IdUsuario = Convert.ToInt16(lbl_id.Text),

                        PrecioVenta = float.Parse(lbl_precio.Text),

                        FechaEntrada = DateTime.Now,

                        Stock = Convert.ToInt16(txt_num_regresar.Value),

                        CantidadDevolucion = cantidaddevolucion



                    };



                    string control = "";

                    control = c_devolucion.Devolucion(parametro);

                    TicketDevolucion();

                    RegresarVentana();

                }
            }
            else
            {
                MessageBox.Show("No se puede regresar mas Cantidad de la comprada");
            }
            
          
        }

        private void devolucion_producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void devolucion_producto_Load(object sender, EventArgs e)
        {
            CargarDatosProducto();
        }

        private void txt_num_regresar_ValueChanged(object sender, EventArgs e)
        {
            float precio = float.Parse(lbl_precio.Text);

            int cantidad = Convert.ToInt16(txt_num_regresar.Value);

            float subtotalregresar = precio * cantidad;

            float subtotal = (float)Math.Round(subtotalregresar, 2);


            lbl_cantidad_regresar.Text = Convert.ToString(subtotal);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
