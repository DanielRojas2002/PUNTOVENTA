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

namespace PUNTOVENTA.MENU.PRODUCTO
{
    public partial class modificar_eliminar_producto : Form
    {
        public modificar_eliminar_producto()
        {
            InitializeComponent();
        }

        private void modificar_eliminar_producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void modificar_eliminar_producto_Load(object sender, EventArgs e)
        {
            int idProducto;
            idProducto = Convert.ToInt16(lblidproducto.Text);

            

            dgProducto parametro = new dgProducto
            {
                Id_Producto = idProducto

            };



            List<dgProducto> lista = c_producto.LeerProducto(5, parametro);

            if (lista.Count > 0)

            {

                foreach (dgProducto d in lista)
                {
                    txt_nombre.Text = Convert.ToString(d.Nombre.ToString());
                    txt_descripcion.Text = Convert.ToString(d.Descripcion.ToString());
                    txt_preciocompra.Text = Convert.ToString(d.PrecioCompra.ToString());
                    txt_precioventa.Text = Convert.ToString(d.PrecioVenta.ToString());
                    txt_stockinicial.Text = Convert.ToString(d.StockInicial.ToString());
                    
                }

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            string id;
            id = lbl_id.Text;

            string retorno = "", retorno2 = "";

            dgUsuario parametro = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)

            };



            List<dgUsuario> lista = c_usuario.LeerUsuario(2, parametro);

            if (lista.Count > 0)

            {

                foreach (dgUsuario d in lista)
                {
                    retorno = Convert.ToString(d.Usuario.ToString());
                }

            }



            dgUsuario parametro2 = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)

            };



            List<dgUsuario> lista2 = c_usuario.LeerUsuario(3, parametro);

            if (lista.Count > 0)

            {

                foreach (dgUsuario d in lista2)
                {
                    retorno2 = Convert.ToString(d.DescripcionPerfil.ToString());
                }



            }


            this.Hide();
            menu_producto formulario = new menu_producto();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();
        }
    }
}
