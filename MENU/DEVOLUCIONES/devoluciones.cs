
using DocumentFormat.OpenXml.Spreadsheet;
using Punto_de_Venta;
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
    public partial class devoluciones : Form
    {
        public devoluciones()
        {
            InitializeComponent();
        }

        public float _dinerodevolucion = 0;

        int _cantidadregistros = 0;

        float _cantidaddevolucion = 0;

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ticket_Click(object sender, EventArgs e)
        {

            dataGridView_ventas.Rows.Clear();
            if (txt_ticket.Text != "")
            {


               

                dgDevolucion parametro2 = new dgDevolucion
                {
                    Id_Venta =Convert.ToInt16(txt_ticket.Text)

                };




                List<dgDevolucion> lista2 = c_devolucion.LeerDevolucion(1, parametro2);


                if (lista2.Count > 0)

                {
                    string idproducto = "";
                    string fechaventa;
                    float subtotal;
                    int cantidaddevolver;
                    int cantidadtotal;
                    float cantidadtotalsubtotal;
                    int contadormensaje = 0;
                    int cantidaddevolvida = 0;
                    float cantidaddevuelto = 0;
                    bool cuadrito = false;

                    foreach (dgDevolucion d in lista2)
                    {
                        idproducto = d.IdProducto.ToString();

                        dgDevolucion parametro = new dgDevolucion
                        {
                            Id_Venta = Convert.ToInt16(txt_ticket.Text),
                            IdProducto= Convert.ToString(idproducto)

                        };




                        List<dgDevolucion> lista = c_devolucion.LeerDevolucion(11, parametro);


                        cantidaddevolvida = 0;
                        cantidaddevuelto = 0;

                        if (lista.Count > 0)

                        {

                            foreach (dgDevolucion dd in lista)
                            {
                                cantidaddevolvida = cantidaddevolvida+ Convert.ToInt16(dd.CantidadProducto.ToString());
                                cantidaddevuelto = cantidaddevuelto+float.Parse(dd.CantidadDevolucion.ToString());

                            }


                        }
                        else
                        {
                            cantidaddevolvida = 0;
                            cantidaddevuelto = 0;
                        }

                        if (d.DescripcionTipoVenta.ToString()!="Credito")
                        {
                            cantidadtotalsubtotal = 0;
                            subtotal = float.Parse(d.SubTotalProducto.ToString());

                            subtotal = (float)Math.Round(subtotal, 2);

                            cantidaddevolver = Convert.ToInt16(d.CantidadProducto.ToString());
                            cantidadtotal = cantidaddevolver - cantidaddevolvida;

                            cantidadtotalsubtotal = subtotal - cantidaddevuelto;
                            fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");

                            if (cantidadtotal==0)
                            {
                                
                            }
                            else
                            {
                                _cantidadregistros = _cantidadregistros + 1;
                                dataGridView_ventas.Rows.Add(d.Id_Venta.ToString(), d.IdProducto.ToString(), d.NombreProducto.ToString(),
                                d.PrecioProducto.ToString(), Convert.ToString(cantidadtotal), Convert.ToString(cantidadtotalsubtotal), fechaventa, d.DescripcionTipoVenta.ToString(),
                                    false);
                            }

                           

                        }
                        else
                        {
                            contadormensaje = contadormensaje + 1;
                            
                        }
                      
                  



                    }

                    if (contadormensaje>=1)
                    {
                        MessageBox.Show("No se puede devolver productos si la venta fue por credito");
                        txt_ticket.Text = "";
                    }
                    //CargaTotalDevolver();
                }

                else
                {
                    dataGridView_ventas.Rows.Clear();
                    MessageBox.Show("No se Encontro el Numero de Venta");
                    txt_ticket.Text = "";
                }
            }

            else
            {
                dataGridView_ventas.Rows.Clear();
                MessageBox.Show("Ingrese el Numero de Ticket");
                txt_ticket.Text = "";
            }
        }


        private void CargaDevoluiones()
        {

          








        }

        private void btn_devolucion_Click(object sender, EventArgs e)
        {
            if (txt_ticket.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Ingrese el Numero de Ticket");
            }
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
                e.Handled = true;
            }
        }

        private void txt_ticket_TextChanged(object sender, EventArgs e)
        {

        }

        private void devoluciones_Load(object sender, EventArgs e)
        {
            
        }
        private void CargaTotalDevolver()
        {

            dgDevolucion parametro2 = new dgDevolucion
            {
                Id_Venta = Convert.ToInt16(txt_ticket.Text)

            };



            List<dgDevolucion> lista = c_devolucion.LeerDevolucion(4, parametro2);

            float preciodevolver = 0;

            if (lista.Count > 0)

            {
                
                foreach (dgDevolucion d in lista)
                {
                    preciodevolver = preciodevolver + float.Parse( d.SubTotalProducto.ToString());
                   
                }
                lbl_dinero_a_devolver.Text = Convert.ToString(preciodevolver);

            }
        }

        private void dataGridView_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int FilaActual;
            FilaActual = dataGridView_ventas.CurrentRow.Index;


            int idventa = Convert.ToInt16(dataGridView_ventas.CurrentRow.Cells["Col_Id_Venta"].Value.ToString());
            string idproducto = Convert.ToString(dataGridView_ventas.CurrentRow.Cells["Col_IdProducto"].Value.ToString());

            string tipoventa = Convert.ToString(dataGridView_ventas.CurrentRow.Cells["Col_Tipoventa"].Value.ToString());


            int cantidadrestante= Convert.ToInt16(dataGridView_ventas.CurrentRow.Cells["Col_CantidadProducto"].Value.ToString());

            float cantidadpreciorestante = float.Parse(dataGridView_ventas.CurrentRow.Cells["Col_SubTotalProducto"].Value.ToString());

            var valorcheckbox = true;
            dataGridView_ventas.CurrentCell.Value = dataGridView_ventas.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString() == "True" ? false : true;

            valorcheckbox = (bool)dataGridView_ventas.CurrentCell.Value;

            

            if (valorcheckbox=true)
            {
                AbrirVentanaDevolucion(idproducto, idventa,tipoventa, cantidadrestante, cantidadpreciorestante);



            }

            else
            {
                dataGridView_ventas.Rows[0].Cells[1].Value = 1;
            }
            

         
        }
       

        private void AbrirVentanaDevolucion(string idproducto, int idventa,string tipoventa,int cantidadrestante, float cantidadpreciorestante)
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
            devolucion_producto formulario = new devolucion_producto();
            formulario.lbl_id.Text = id;
            formulario.lbl_id_venta.Text = Convert.ToString(idventa);
            formulario.lbl_idProducto.Text = Convert.ToString(idproducto);
            formulario.lbl_tipoventa.Text = Convert.ToString(tipoventa);
            formulario.lbl_subtotal.Text = Convert.ToString(cantidadpreciorestante);
            formulario.lbl_cantidad_actual.Text = Convert.ToString(cantidadrestante);

            formulario.Show();
        }

        private void dataGridView_ventas_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void devoluciones_FormClosing(object sender, FormClosingEventArgs e)
        {
             System.Windows.Forms.Application.Exit();
        }

        private void TicketDevolucion()
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


                            Ticket1.TextoIzquierda("Recibo de Devolucion");
                            Ticket1.TextoIzquierda("Los Precios ya contienen IVA");



                            Ticket1.TextoIzquierda("");
                        }

                        Ticket1.TextoIzquierda("Recibo:" + txtticket);
                        Ticket1.TextoIzquierda("");
                        Ticket1.TextoIzquierda("Ventas");
                      
                        clsventas.CreaRecibo.EncabezadoVenta();
                        clsventas.CreaRecibo.LineasGuion();

                        string fechaventa;
                        float subtotal;

                        float sumaventa = 0;
                        float sumadevolucion = 0;

                       

                        foreach (dgReportes d in lista)
                        {
                            subtotal = float.Parse(d.SubTotalProducto.ToString());

                            subtotal = (float)Math.Round(subtotal, 2);

                            sumaventa = sumaventa + subtotal;

                            fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");

                            concatenacion =   d.NombreProducto.ToString();
                            Ticket1.TextoIzquierda(d.DescripcionTipoVenta.ToString());
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

                                    sumadevolucion = sumadevolucion + subtotal;
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

                        float sumarestanteventa = 0;

                        sumarestanteventa = sumaventa - sumadevolucion;

                        float sumadevolucionsinlonuevo = 0;




                        Ticket1.TextoIzquierda("Total Venta:" + Convert.ToString(sumaventa));

                        _cantidaddevolucion = (float)Math.Round(_cantidaddevolucion, 2);

                        Ticket1.TextoIzquierda("Cantidad a Devolver:" + _cantidaddevolucion);





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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ticket.Text != "")
                {




                    var confirmResult = MessageBox.Show("Desea  hacer la Devolucion?",
                        "Confirmar Devolucion!!",
                        MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {


                        string idproducto2 = "";

                        _cantidaddevolucion = 0;

                        float cantidaddevolucion = 0;

                        int idventa = 0;

                        int cantidadrestante = 0;
                        float cantidadpreciorestante = 0;

                        string control = "";



                        DataGridViewRow row = dataGridView_ventas.Rows[0];  // fila 



                        for (int i = 0; i < _cantidadregistros; i++)
                        {

                            row = dataGridView_ventas.Rows[i]; // fila 3

                            idventa = Convert.ToInt16(row.Cells[0].Value);

                           



                            idproducto2 = Convert.ToString(row.Cells[1].Value);

                           


                            cantidadpreciorestante = float.Parse((string)row.Cells[3].Value);

                         


                            cantidadrestante = Convert.ToInt16(row.Cells[4].Value);

                           


                            cantidaddevolucion = cantidadpreciorestante * cantidadrestante;



                            dgDevolucion parametro3 = new dgDevolucion
                            {
                                IdProducto = Convert.ToString(idproducto2),
                                Id_Venta = Convert.ToInt16(idventa),

                                Cantidad = Convert.ToInt16(cantidadrestante),

                                IdUsuario = Convert.ToInt16(lbl_id.Text),

                                PrecioVenta = cantidadpreciorestante,

                                FechaEntrada = DateTime.Now,

                                Stock = Convert.ToInt16(cantidadrestante),

                                CantidadDevolucion = cantidaddevolucion



                            };

                            _cantidaddevolucion += cantidaddevolucion;



                            control = c_devolucion.Devolucion(parametro3);
                        }

                        _cantidaddevolucion = (float)Math.Round(_cantidaddevolucion, 2);

                        MessageBox.Show("Cantidad A Devolver:" + Convert.ToString(_cantidaddevolucion));

                        var confirmResultticket = MessageBox.Show("Desea Imprimir Ticket?",
                        "Confirmar Ticket!!",
                        MessageBoxButtons.YesNo);

                        

                        if (confirmResultticket == DialogResult.Yes)
                        {
                            TicketDevolucion();

                        }

                       
                        RegresarVentana();

                    }






                }

                else
                {
                    dataGridView_ventas.Rows.Clear();
                    MessageBox.Show("Ingrese el Numero de Ticket");
                    txt_ticket.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Darle Click antes al boton de VER PRODUCTOS");
            }
            
        }
    }
}
