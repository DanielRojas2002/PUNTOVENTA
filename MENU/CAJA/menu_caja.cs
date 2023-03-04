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

namespace PUNTOVENTA.MENU.CAJA
{
    public partial class menu_caja : Form
    {
        public menu_caja()
        {
            InitializeComponent();
        }

        public float _dineroventas=0;

        private void menu_caja_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        
        private void CargaTotalVentas()
        {

        }

        private void CargarVentas()
        {
            

            dgCaja parametro = new dgCaja
            {
                FechaInicio = DateTime.Now
               
            };




            List<dgCaja> lista = c_caja.LeerCaja(1, parametro);


            if (lista.Count > 0)

            {
                string fechaventa;
                float subtotal;
                foreach (dgCaja d in lista)
                {
                    subtotal = float.Parse(d.SubTotalProducto.ToString());

                    subtotal= (float)Math.Round(subtotal, 2);

                    fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");
                    dataGridView_ventas.Rows.Add(d.Id_Venta.ToString(), d.IdProducto.ToString(), d.NombreProducto.ToString(),
                         d.PrecioProducto.ToString(), d.CantidadProducto.ToString(), Convert.ToString(subtotal), fechaventa, d.DescripcionTipoVenta.ToString(),d.Usuario.ToString());


                    _dineroventas = _dineroventas + float.Parse( d.SubTotalProducto.ToString());
                }
                _dineroventas = (float)Math.Round(_dineroventas,2);

                lbl_cantidad_vendida.Text = Convert.ToString(_dineroventas);

               
            }

            else
            {

                MessageBox.Show("No se encontró reporte de compra este día seleccionado");

            }
        }
        private void menu_caja_Load(object sender, EventArgs e)
        {
            CargarVentas();
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

        }

        private void txt_retirar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_caja_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_abonar_Click(object sender, EventArgs e)
        {

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
    }
}
