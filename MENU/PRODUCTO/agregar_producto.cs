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
    public partial class agregar_producto : Form
    {
        public agregar_producto()
        {
            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregar_producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void agregar_producto_Load(object sender, EventArgs e)
        {


            bx_categoria.Items.Clear();
            dgCategoria parametro = new dgCategoria();

            parametro.Descripcion = "no";

            List<dgCategoria> lista = c_categoria.LeerCategoria(1, parametro);

            if (lista.Count > 0)

            {

                foreach (dgCategoria d in lista)
                {
                    bx_categoria.Items.Add(d.Descripcion.ToString());
                }





            }



            bx_medida.Items.Clear();

            dgMedida parametro2 = new dgMedida
            {
                Descripcion = "no"
            };

            List<dgMedida> lista2 = c_medida.LeerMedida(1, parametro2);

            if (lista2.Count > 0)

            {

                foreach (dgMedida d in lista2)
                {
                    bx_medida.Items.Add(d.Descripcion.ToString());
                }





            }


           
        }

        private void btn_crear_producto_Click(object sender, EventArgs e)
        {

            if (txt_nombre.Text == "")
            {

                MessageBox.Show("Ingrese el Nombre del Producto ");
            }

            else if (txt_descripcion.Text == "")
            {
                MessageBox.Show("Ingrese la Descripcion del Producto ");
            }

            else if (txt_preciocompra.Text == "")
            {
                MessageBox.Show("Ingrese el precio de compra del Producto ");
            }


            else if (txt_precioventa.Text == "")
            {
                MessageBox.Show("Ingrese el precio de venta del Producto ");
            }

            else if (txt_stockinicial.Text == "")
            {
                MessageBox.Show("Ingrese el stock inicial del Producto ");
            }


            else if (bx_categoria.Text == "")
            {
                MessageBox.Show("Seleccione la categoria del Producto ");
            }



            else if (bx_medida.Text == "")
            {
                MessageBox.Show("Seleccione la medida del Producto");
            }

            else if (bx_proveedor.Text == "")
            {
                MessageBox.Show("Seleccione el proveedor del Producto ");
            }

            else
            {
                dgProducto parametro = new dgProducto
                {
                    Id_Categoria = Convert.ToInt16(lbl_idcategoria.Text),
                    Id_Medida = Convert.ToInt16(lbl_idmedida.Text),
                    Id_Proveedor = Convert.ToInt16(lbl_proveedor.Text),
                    Nombre = txt_nombre.Text.Trim(),
                    Descripcion = txt_descripcion.Text.Trim(),
                    PrecioCompra = Convert.ToInt16(txt_preciocompra.Text.Trim()),
                    PrecioVenta = Convert.ToInt16(txt_preciocompra.Text.Trim()),
                };



                string control = "";

                control = c_producto.InsertarProducto(parametro);

                if (control == "1")
                {

                    MessageBox.Show("Ya Existe una Producto Similar", "Error");
                }

                else
                {













                    MessageBox.Show("Producto Dado de alta", "Correcto");
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
                    menu_producto formulario = new menu_producto();
                    formulario.lbl_id.Text = id;
                    formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                    formulario.txt_usuario.Text = Convert.ToString(retorno);
                    formulario.Show();
                }

            }
        }

        private void bx_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            string descripcion;
            descripcion = bx_categoria.Text;

            dgCategoria parametro = new dgCategoria
            {
                Descripcion = descripcion
            };

            List<dgCategoria> lista = c_categoria.LeerCategoria(2, parametro);

            if (lista.Count > 0)

            {

                foreach (dgCategoria d in lista)
                {
                    lbl_idcategoria.Text = d.Id_Categoria.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Categorias Agregadas", "Advertencia");
            }
        }

        private void bx_medida_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            string descripcion;
            descripcion = bx_medida.Text;

            dgMedida parametro = new dgMedida
            {
                Descripcion = descripcion
            };

            List<dgMedida> lista = c_medida.LeerMedida(2, parametro);

            if (lista.Count > 0)

            {

                foreach (dgMedida d in lista)
                {
                    lbl_idmedida.Text = d.Id_Medida.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Medidas Agregadas", "Advertencia");
            }
        }
    }
}
