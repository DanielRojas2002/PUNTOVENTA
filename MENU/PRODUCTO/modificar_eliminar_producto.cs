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
                    txt_stock.Text = Convert.ToString(d.StockInicial.ToString());

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


                // SEPARADOR

                bx_proveedor.Items.Clear();

                string descripcionproveedor = "";

                dgProveedor parametro6 = new dgProveedor
                {
                    Id_Proveedor = Convert.ToInt16(lblidproveedor.Text)
                };

                List<dgProveedor> descripcionproveedores = c_proveedor.LeerProveedor(5, parametro6);

                if (descripcionproveedores.Count > 0)

                {

                    foreach (dgProveedor d in descripcionproveedores)
                    {
                        descripcionproveedor = Convert.ToString(d.Nombre.ToString());
                    }

                }




                dgProveedor parametro6_5 = new dgProveedor
                {

                };

                List<dgProveedor> listaproveedortodas = c_proveedor.LeerProveedor(1, parametro6_5);

                if (listaproveedortodas.Count > 0)

                {

                    foreach (dgProveedor d in listaproveedortodas)
                    {
                        bx_proveedor.Items.Add(d.Nombre.ToString());
                    }

                    bx_proveedor.SelectedItem = descripcionproveedor;





                }

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void bx_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string nombre;
            nombre = bx_proveedor.Text;


            dgProveedor parametro = new dgProveedor
            {
                Nombre = nombre
            };

            List<dgProveedor> lista = c_proveedor.LeerProveedor(6, parametro);

            if (lista.Count > 0)

            {

                foreach (dgProveedor d in lista)
                {
                    lblidproveedor.Text = d.Id_Proveedor.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Categorias Agregadas", "Advertencia");
            }
        }

        private void btn_eliminar_producto_Click(object sender, EventArgs e)
        {
            try
            {

                dgProducto parametro = new dgProducto
                {
                    Id_Producto = Convert.ToInt16(lblidproducto.Text)
                };


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

                string control = "";

                var confirmResult = MessageBox.Show("Esta seguro de Eliminar este Producto",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    control = c_producto.EliminarProducto(parametro);

                    MessageBox.Show("Producto Eliminado", "Correcto");

                    this.Hide();
                    menu_producto formulario = new menu_producto();
                    formulario.lbl_id.Text = id;
                    formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                    formulario.txt_usuario.Text = Convert.ToString(retorno);
                    formulario.Show();
                }
                

                
               

                

            }
            catch
            {
                MessageBox.Show("Seleccione una Categoria", "Error");
            }
        }

        private void btn_modificar_producto_Click(object sender, EventArgs e)
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
                try
                {
                    int preciocompra = Convert.ToInt16(txt_preciocompra.Text.Trim());
                    int precioventa = Convert.ToInt16(txt_precioventa.Text.Trim());


                    if (preciocompra > precioventa)
                    {
                        MessageBox.Show("Al hacer eso genera perdidas | No se puede", "Error");
                        txt_precioventa.Text = "";
                    }

                    else
                    {

                        dgProducto parametro = new dgProducto
                        {
                            Id_Producto = Convert.ToInt16(lblidproducto.Text),
                            Id_Categoria = Convert.ToInt16(lblidcategoria.Text),
                            Id_Medida = Convert.ToInt16(lblidmedida.Text),
                            Id_Proveedor = Convert.ToInt16(lblidproveedor.Text),
                            Nombre = Convert.ToString(txt_nombre.Text),
                            Descripcion = Convert.ToString(txt_descripcion.Text),
                            PrecioCompra = Convert.ToInt16(txt_preciocompra.Text),
                            PrecioVenta = Convert.ToInt16(txt_precioventa.Text),
                        };

                       


                        string control = "";

                        control = c_producto.ModificarProducto(parametro);

                        if (control == "1")
                        {

                            MessageBox.Show("Ya Existe una Producto Similar", "Error");
                        }

                        else
                        {



                            MessageBox.Show("Producto Modificado", "Correcto");
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


                catch
                {
                    MessageBox.Show("Respete el valor de los Campos", "Error");
                }

            }

           
        }

        private void bx_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                    lblidcategoria.Text = d.Id_Categoria.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Categorias Agregadas", "Advertencia");
            }

          
        }

        private void bx_medida_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    lblidmedida.Text = d.Id_Medida.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Categorias Agregadas", "Advertencia");
            }
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_agregar_stock_Click(object sender, EventArgs e)
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
            agregar_stock formulario = new agregar_stock();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.lblidproducto.Text = lblidproducto.Text;
            formulario.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
