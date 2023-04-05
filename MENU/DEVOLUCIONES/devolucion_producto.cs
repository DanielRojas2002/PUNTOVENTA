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
                IdProducto = Convert.ToInt16(lbl_idProducto.Text)
                
            };



            List<dgDevolucion> lista2 = c_devolucion.LeerDevolucion(2, parametro3);

            if (lista2.Count > 0)

            {
                float subtotal,sub;
                foreach (dgDevolucion d in lista2)
                {
                    lbl_producto.Text = Convert.ToString(d.IdProducto.ToString() + " " + d.NombreProducto.ToString());
                    lbl_precio.Text = d.PrecioProducto.ToString();
                    lbl_cantidad_actual.Text = d.CantidadProducto.ToString();

                    sub = float.Parse(d.SubTotalProducto.ToString());

                    subtotal = (float)Math.Round(sub, 2);
                   
                    lbl_subtotal.Text = Convert.ToString(subtotal);
                }


            }
        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {

        }

        private void devolucion_producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void devolucion_producto_Load(object sender, EventArgs e)
        {
            CargarDatosProducto();
        }
    }
}
