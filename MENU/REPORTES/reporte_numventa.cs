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
                        escredito = d.DescripcionTipoVenta.ToString();

                    }
                    if (escredito=="Credito")
                    {
                        label10.Text = "";
                        dataGridView_devoluciones.Visible = false;
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
    }
}
