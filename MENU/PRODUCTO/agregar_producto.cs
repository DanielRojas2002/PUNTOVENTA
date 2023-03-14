using Punto_de_Venta;
using Punto_de_Venta.Clases;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using System;
using System.Collections;
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


            dgCategoria parametro = new dgCategoria
            {

            };

            List<dgCategoria> lista = c_categoria.LeerCategoria(1, parametro);


            if (lista.Count > 0)

            {

                string concatenacion = "";
                foreach (dgCategoria d in lista)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Categoria.ToString() + " " + d.Descripcion.ToString();

                    bx_categoria.Items.Add(concatenacion);
                }
            }

            dgMedida parametro2 = new dgMedida();

            List<dgMedida> lista2 = c_medida.LeerMedida(1, parametro2);

            if (lista2.Count > 0)

            {

                string concatenacion = "";
                foreach (dgMedida d in lista2)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Medida.ToString() + " " + d.Descripcion.ToString();

                    bx_medida.Items.Add(concatenacion);
                }
            }


            dgProveedor parametro3 = new dgProveedor();

            List<dgProveedor> lista3 = c_proveedor.LeerProveedor(1, parametro3);

            if (lista3.Count > 0)

            {

                string concatenacion = "";
                foreach (dgProveedor d in lista3)
                {
                    concatenacion = "";
                    concatenacion = d.Id_Proveedor.ToString() + " " + d.Nombre.ToString();

                    bx_proveedor.Items.Add(concatenacion);
                }
            }



        }

     

        private void bx_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            string concatenacion = bx_categoria.Text;
            string[] words = concatenacion.Split(' ');
            string idcategoria;
            idcategoria = words[0];


            lbl_idcategoria.Text = idcategoria;

           

           


           


           
        }

        private void bx_medida_SelectedIndexChanged(object sender, EventArgs e)
        {
            string concatenacion = bx_medida.Text;
            string[] words = concatenacion.Split(' ');
            string idmedida;
            idmedida = words[0];


            lbl_idmedida.Text = idmedida;
        }

        private void btn_crear_producto_Click_1(object sender, EventArgs e)
        {

            if (txt_codigo.Text == "")
            {

                MessageBox.Show("Ingrese el Codigo del Producto ");
            }

            else if (txt_nombre.Text == "")
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
                //try
                //{
                    float preciocompra = float.Parse(txt_preciocompra.Text.Trim());
                    float precioventa = float.Parse(txt_precioventa.Text.Trim());


                    if (preciocompra > precioventa)
                    {
                        MessageBox.Show("Al hacer eso genera perdidas | No se puede", "Error");
                        txt_precioventa.Text = "";
                    }

                    else
                    {
                        dgIva parametroiva = new dgIva();

                        float porcentaje=0;
                        List<dgIva> listaiva = c_iva.LeerIva(1, parametroiva);

                        if (listaiva.Count > 0)

                        {

                            foreach (dgIva d in listaiva)
                            {
                                porcentaje = float.Parse(d.Porcentaje.ToString());
                            }

                            
                        }

                        float precioventaa = float.Parse(txt_precioventa.Text);

                      

                        dgProducto parametro = new dgProducto
                        {
                            Id_Producto = Convert.ToString(txt_codigo.Text.Trim()),
                            Id_Categoria = Convert.ToInt16(lbl_idcategoria.Text),
                            Id_Medida = Convert.ToInt16(lbl_idmedida.Text),
                            Id_Proveedor = Convert.ToInt16(lbl_proveedor.Text),
                            Id_Estatus_Producto=1,
                            Nombre = txt_nombre.Text.Trim(),
                            Descripcion = txt_descripcion.Text.Trim(),
                            PrecioCompra = float.Parse(txt_preciocompra.Text.Trim()),
                            PrecioVenta = float.Parse(txt_precioventa.Text.Trim()),
                            Iva= float.Parse(lbl_iva.Text)



                        };



                        string control = "";

                        control = c_producto.InsertarProducto(parametro);

                        if (control == "1")
                        {

                            MessageBox.Show("Ya Existe una Producto con este Codigo", "Error");
                        }

                        else if (control == "2")
                        {

                            MessageBox.Show("Ya Existe una Producto con este nombre", "Error");
                        }

                        else
                        {



                            MessageBox.Show("Producto Dado de alta", "Correcto");

                            RegresarVentana();
                        }
                    }

                    
                //}


                //catch 
                //{
                //    MessageBox.Show("Respete el valor de los Campos", "Error");
                //}

            }
        }

        private void bx_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string concatenacion = bx_proveedor.Text;
            string[] words = concatenacion.Split(' ');
            string idproveedor;
            idproveedor = words[0];


            lbl_proveedor.Text = idproveedor;
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void txt_preciocompra_TextChanged(object sender, EventArgs e)
        {
           
            



        }

        private void txt_precioventa_TextChanged(object sender, EventArgs e)
        {

            try
            {
                lbl_iva.Text = "";
                float precioventa = float.Parse(txt_precioventa.Text);

                dgIva parametroiva = new dgIva();

                float porcentaje = 0;
                float totalporcentaje = 0;
                List<dgIva> listaiva = c_iva.LeerIva(1, parametroiva);

                if (listaiva.Count > 0)

                {

                    foreach (dgIva d in listaiva)
                    {
                        porcentaje = float.Parse(d.Porcentaje.ToString());
                    }


                }
                totalporcentaje = precioventa * porcentaje;

                totalporcentaje=(float)Math.Round(totalporcentaje, 2);

                lbl_iva.Text = Convert.ToString(totalporcentaje);
            }

            catch
            {

            }
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
             
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_nombre.Focus();
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_precioventa.Focus();
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                bx_categoria.Focus();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_descripcion.Focus();
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_preciocompra.Focus();
        }

        private void bx_medida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                bx_proveedor.Focus();
        }

        private void bx_proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btn_crear_producto.Focus();
        }
    }
}
