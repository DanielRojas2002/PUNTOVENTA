﻿
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
                dgDevolucion parametro = new dgDevolucion
                {
                    Id_Venta =Convert.ToInt16(txt_ticket.Text)

                };




                List<dgDevolucion> lista = c_devolucion.LeerDevolucion(1, parametro);


                if (lista.Count > 0)

                {
                    string fechaventa;
                    float subtotal;
                    int cantidaddevolver;
                    foreach (dgDevolucion d in lista)
                    {
                        subtotal = float.Parse(d.SubTotalProducto.ToString());

                        subtotal = (float)Math.Round(subtotal, 2);

                        cantidaddevolver = Convert.ToInt16(d.CantidadProducto.ToString());

                        fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");
                        dataGridView_ventas.Rows.Add(d.Id_Venta.ToString(), d.IdProducto.ToString(), d.NombreProducto.ToString(),
                             d.PrecioProducto.ToString(), d.CantidadProducto.ToString(), Convert.ToString(subtotal), fechaventa, d.DescripcionTipoVenta.ToString(),
                                 false);

                  



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


         

            var valorcheckbox = true;
            dataGridView_ventas.CurrentCell.Value = dataGridView_ventas.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString() == "True" ? false : true;

            valorcheckbox = (bool)dataGridView_ventas.CurrentCell.Value;

            

            if (valorcheckbox=true)
            {
                AbrirVentanaDevolucion(idproducto, idventa);



            }

            else
            {
                dataGridView_ventas.Rows[0].Cells[1].Value = 1;
            }
            

         
        }
       

        private void AbrirVentanaDevolucion(int idproducto, int idventa)
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

        }
    }
}
