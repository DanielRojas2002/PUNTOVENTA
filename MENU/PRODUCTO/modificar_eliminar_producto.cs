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

                    lblidcategoria.Text=Convert.ToString(d.Id_Categoria.ToString());
                    lblidmedida.Text = Convert.ToString(d.Id_Medida.ToString());
                    lblidproveedor.Text = Convert.ToString(d.Id_Proveedor.ToString());

                }



                bx_medida.Items.Clear();

                string descripcionmedida = "";
                dgMedida parametro4 = new dgMedida
                {
                    Id_Medida = Convert.ToInt16(lblidmedida.Text)
                };

                List<dgMedida> listamedidas = c_medida.LeerMedida(3, parametro4);

                if (listamedidas.Count > 0)

                {

                    foreach (dgMedida d in listamedidas)
                    {
                        descripcionmedida = Convert.ToString(d.Descripcion.ToString());
                    }

                }


               

                dgMedida parametro4_5 = new dgMedida
                {

                };

                List<dgMedida> listamedidastodas = c_medida.LeerMedida(1, parametro4_5);

                if (listamedidas.Count > 0)

                {

                    foreach (dgMedida d in listamedidastodas)
                    {
                        bx_medida.Items.Add(d.Descripcion.ToString());
                    }

                    bx_medida.SelectedItem = descripcionmedida;





                }

                // SEPARADOR

                bx_categoria.Items.Clear();

                string descripciocategoria = "";

                dgCategoria parametro5 = new dgCategoria
                {
                    Id_Categoria = Convert.ToInt16(lblidcategoria.Text)
                };

                List<dgCategoria> listacategorias = c_categoria.LeerCategoria(3, parametro5);

                if (listacategorias.Count > 0)

                {

                    foreach (dgCategoria d in listacategorias)
                    {
                        descripciocategoria = Convert.ToString(d.Descripcion.ToString());
                    }

                }


              

                dgCategoria parametro5_5 = new dgCategoria
                {

                };

                List<dgCategoria> listacategoriastodas = c_categoria.LeerCategoria(1, parametro5_5);

                if (listacategoriastodas.Count > 0)

                {

                    foreach (dgCategoria d in listacategoriastodas)
                    {
                        bx_categoria.Items.Add(d.Descripcion.ToString());
                    }

                    bx_categoria.SelectedItem = descripciocategoria;





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
