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
            string idProducto;
            idProducto = Convert.ToString(lblidproducto.Text);

            lbl_id_estatus.Text = "";


            txt_codigo.Text = Convert.ToString(idProducto);
            dgProducto parametro = new dgProducto
            {
                Id_Producto = Convert.ToString(idProducto)

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
                    lbl_id_estatus.Text=Convert.ToString(d.Id_Estatus_Producto.ToString());

                   

                }



                if (lbl_id_estatus.Text == "1")
                {
                    btn_eliminar_producto.Text = "DESACTIVAR";
                    btn_eliminar_producto.ForeColor = Color.Red;

                }

                else if (lbl_id_estatus.Text == "2")
                {
                    btn_eliminar_producto.Text = "ACTIVAR";
                    btn_eliminar_producto.ForeColor = Color.Green;

                }


                bx_medida.Items.Clear();

                string descripciocategoria = "";
                string descripciomedida = "";

                dgMedida parametro4 = new dgMedida
                {
                    Id_Medida = Convert.ToInt16(lblidmedida.Text)
                };

                List<dgMedida> listamedidas = c_medida.LeerMedida(3, parametro4);

                if (listamedidas.Count > 0)

                {

                    foreach (dgMedida d in listamedidas)
                    {
                        descripciomedida = Convert.ToString(d.Descripcion.ToString());
                    }

                }

                string concatenacion = "";
                dgMedida parametro2 = new dgMedida();

                List<dgMedida> lista2 = c_medida.LeerMedida(1, parametro2);

                if (lista2.Count > 0)

                {

                    concatenacion = "";
                    foreach (dgMedida d in lista2)
                    {
                        concatenacion = "";

                        concatenacion = d.Id_Medida.ToString() + " " + d.Descripcion.ToString();

                        bx_medida.Items.Add(concatenacion);
                    }

                    bx_medida.SelectedItem = lblidmedida.Text + " " + descripciomedida;

                }
               






                // SEPARADOR

                bx_categoria.Items.Clear();

                

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
               
                dgCategoria parametro3 = new dgCategoria
                {

                };

                List<dgCategoria> listac = c_categoria.LeerCategoria(1, parametro3);


                if (listac.Count > 0)

                {

                    concatenacion = "";
                    foreach (dgCategoria d in listac)
                    {
                        concatenacion = "";

                        concatenacion = d.Id_Categoria.ToString() + " " + d.Descripcion.ToString();
                        bx_categoria.Items.Add(concatenacion);

                    }
                    bx_categoria.SelectedItem = lblidcategoria.Text + " " + descripciocategoria;
                }







                // SEPARADOR

                bx_proveedor.Items.Clear();

                string descripcionproveedor = "";

                dgProveedor parametro6 = new dgProveedor
                {
                    Id_Proveedor = Convert.ToInt16(lblidproveedor.Text)
                };

                List<dgProveedor> descripcionproveedores = c_proveedor.LeerProveedor(3, parametro6);

                if (descripcionproveedores.Count > 0)

                {

                    foreach (dgProveedor d in descripcionproveedores)
                    {
                        descripcionproveedor = Convert.ToString(d.Nombre.ToString());
                    }

                }


                dgProveedor parametro61 = new dgProveedor();

                List<dgProveedor> listap = c_proveedor.LeerProveedor(1, parametro61);

              
                if (lista.Count > 0)

                {

                    concatenacion = "";
                    foreach (dgProveedor d in listap)
                    {
                        concatenacion = "";
                        concatenacion = d.Id_Proveedor.ToString() + " " + d.Nombre.ToString();

                        bx_proveedor.Items.Add(concatenacion);
                    }
                    bx_proveedor.SelectedItem = lblidproveedor.Text + " " + descripcionproveedor;
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

            this.Hide();
            menu_producto formulario = new menu_producto();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();



        }
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
        }

        private void bx_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            string concatenacion = bx_proveedor.Text;
            string[] words = concatenacion.Split(' ');
            string idproveedor;
            idproveedor = words[0];


            lblidproveedor.Text = idproveedor;
        }

        private void btn_eliminar_producto_Click(object sender, EventArgs e)
        {
            try
            {
                string msj = "";
                string msj2 = "";
                string msj3 = "";

               

                int id_estatus = 0;
                if (lbl_id_estatus.Text == "1")
                {
                    
                    msj = "Producto Desactivado";
                    msj2 = "Esta seguro de Desactivar este Producto";
                    msj3 = "Desactivar Producto";
                    
                    id_estatus = 2;

                  

                    
                }

                else if (lbl_id_estatus.Text == "2")
                {
                    
                    msj = "Producto Activado";
                    msj2 = "Esta seguro de Activar este Producto";
                    msj3 = "Activar Producto";
                    id_estatus = 1;

                   
                }

                dgProducto parametro = new dgProducto
                {
                    Id_Producto = Convert.ToString(lblidproducto.Text),
                    Id_Estatus_Producto = id_estatus
                };


                

                string control = "";

                var confirmResult = MessageBox.Show(msj2,msj3,MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    control = c_producto.DesactivaroActivarProducto(parametro);

                    MessageBox.Show(msj, "Correcto");

                    RegresarVentana();
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
                    float preciocompra = float.Parse(txt_preciocompra.Text.Trim());
                    float precioventa = float.Parse(txt_precioventa.Text.Trim());


                    if (preciocompra > precioventa)
                    {
                        MessageBox.Show("Al hacer eso genera perdidas | No se puede", "Error");
                        txt_precioventa.Text = "";
                    }

                    else
                    {

                        dgProducto parametro = new dgProducto
                        {
                            Id_Producto = Convert.ToString(lblidproducto.Text),
                            Id_Categoria = Convert.ToInt16(lblidcategoria.Text),
                            Id_Medida = Convert.ToInt16(lblidmedida.Text),
                            Id_Proveedor = Convert.ToInt16(lblidproveedor.Text),
                            Nombre = Convert.ToString(txt_nombre.Text),
                            Descripcion = Convert.ToString(txt_descripcion.Text),
                            PrecioCompra = float.Parse(txt_preciocompra.Text),
                            PrecioVenta = float.Parse(txt_precioventa.Text),
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


                            RegresarVentana();
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

            string concatenacion = bx_categoria.Text;
            string[] words = concatenacion.Split(' ');
            string idcategoria;
            idcategoria = words[0];


            lblidcategoria.Text = idcategoria;


        }

        private void bx_medida_SelectedIndexChanged(object sender, EventArgs e)
        {
            string concatenacion = bx_medida.Text;
            string[] words = concatenacion.Split(' ');
            string idmedida;
            idmedida = words[0];


            lblidmedida.Text = idmedida;
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

        private void txt_preciocompra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_precioventa_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
