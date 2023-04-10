
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
                            IdProducto= Convert.ToInt16(idproducto)

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
            int idproducto = Convert.ToInt16(dataGridView_ventas.CurrentRow.Cells["Col_IdProducto"].Value.ToString());

            string tipoventa = Convert.ToString(dataGridView_ventas.CurrentRow.Cells["Col_Tipoventa"].Value.ToString());


            int cantidadrestante= Convert.ToInt16(dataGridView_ventas.CurrentRow.Cells["Col_CantidadProducto"].Value.ToString());

            float cantidadpreciorestante = Convert.ToInt16(dataGridView_ventas.CurrentRow.Cells["Col_SubTotalProducto"].Value.ToString());

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
       

        private void AbrirVentanaDevolucion(int idproducto, int idventa,string tipoventa,int cantidadrestante, float cantidadpreciorestante)
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


                        int idproducto2 = 0;

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

                            MessageBox.Show(Convert.ToString(idventa));



                            idproducto2 = Convert.ToInt16(row.Cells[1].Value);

                            MessageBox.Show(Convert.ToString(idproducto2));


                            cantidadpreciorestante = float.Parse((string)row.Cells[3].Value);

                            MessageBox.Show(Convert.ToString(cantidadpreciorestante));


                            cantidadrestante = Convert.ToInt16(row.Cells[4].Value);

                            MessageBox.Show(Convert.ToString(cantidadrestante));


                            cantidaddevolucion = cantidadpreciorestante * cantidadrestante;



                            dgDevolucion parametro3 = new dgDevolucion
                            {
                                IdProducto = Convert.ToInt16(idproducto2),
                                Id_Venta = Convert.ToInt16(idventa),

                                Cantidad = Convert.ToInt16(cantidadrestante),

                                IdUsuario = Convert.ToInt16(lbl_id.Text),

                                PrecioVenta = cantidadpreciorestante,

                                FechaEntrada = DateTime.Now,

                                Stock = Convert.ToInt16(cantidadrestante),

                                CantidadDevolucion = cantidaddevolucion



                            };

                            cantidaddevolucion += cantidadrestante * cantidadpreciorestante;



                            control = c_devolucion.Devolucion(parametro3);
                        }

                        var confirmResultticket = MessageBox.Show("Desea Imprimir Ticket?",
                        "Confirmar Ticket!!",
                        MessageBoxButtons.YesNo);

                        MessageBox.Show("Cantidad A Devolver:"+ Convert.ToString(cantidaddevolucion));

                        if (confirmResultticket == DialogResult.Yes)
                        {
                            // HACER UN TICKET DE LO QUE DEVOLVIO POR EL NUMERO TIKECT Y PASARLE CUANTO DINERO VA A DEVOLVER cantidaddevolucion

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
