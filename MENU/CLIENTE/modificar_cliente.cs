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

namespace PUNTOVENTA.MENU.CLIENTE
{
    public partial class modificar_cliente : Form
    {
        public modificar_cliente()
        {
            InitializeComponent();
        }

        private void modificar_cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
            menu_cliente formulario = new menu_cliente();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();





        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RegresarVentana();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_modificar_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (bx_cliente.Text!="")
                {
                    if (txt_nombre.Text == "")
                    {

                        MessageBox.Show("Ingrese el Nombre del Cliente");
                    }
                    else if (txt_apellidopaterno.Text == "")
                    {
                        MessageBox.Show("Ingrese el Apellido Paterno del Cliente ");
                    }
                    else if (txt_apellidomaterno.Text == "")
                    {
                        MessageBox.Show("Ingrese el Apellido Materno del Cliente");
                    }
                    else if (txt_telefono.Text == "")
                    {
                        MessageBox.Show("Ingrese el Telefono  del Cliente");
                    }
                    else if (txt_correo.Text == "")
                    {
                        MessageBox.Show("Ingrese el Correo del Cliente ");
                    }

                    else if (txt_estado.Text == "")
                    {

                        MessageBox.Show("Ingrese el Estado del cliente  ");
                    }

                    else if (txt_municipio.Text == "")
                    {

                        MessageBox.Show("Ingrese el Municipio del cliente  ");
                    }

                    else if (txt_colonia.Text == "")
                    {
                        MessageBox.Show("Ingrese la Colonia del Cliente ");
                    }

                    else if (txt_calle.Text == "")
                    {
                        MessageBox.Show("Ingrese la Calle del Cliente ");
                    }


                    else if (txt_numcasa.Text == "")
                    {
                        MessageBox.Show("Ingrese el Numero de Casa del Cliente ");
                    }

                    else
                    {
                        dgCliente parametro = new dgCliente
                        {
                            Id_Cliente = Convert.ToInt16(lbl_idcliente.Text),
                            Nombre = txt_nombre.Text.Trim().ToUpper(),
                            Apellido_Paterno = txt_apellidopaterno.Text.Trim().ToUpper(),
                            Apellido_Materno = txt_apellidomaterno.Text.Trim().ToUpper(),
                            Telefono = txt_telefono.Text.Trim(),
                            Correo = txt_correo.Text.Trim(),
                            Estado = txt_estado.Text.Trim().ToUpper(),
                            Municipio = txt_municipio.Text.Trim().ToUpper(),
                            Colonia = txt_colonia.Text.Trim().ToUpper(),
                            Calle = txt_calle.Text.Trim().ToUpper(),
                            NumCasa = txt_numcasa.Text.Trim().ToUpper(),


                        };



                        string control = "";

                        control = c_cliente.ModificarCliente(parametro);




                        MessageBox.Show("Cliente Modificado exitosamente", "Correcto");
                        RegresarVentana();



                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el Cliente a Modificar", "Advertencia");
                }
                
            }
            catch
            {
                MessageBox.Show("Seleccione el Cliente a Modificar", "Advertencia");
            }
        }

        private void bx_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string concatenacion = bx_cliente.Text;
            string[] words = concatenacion.Split(' ');
            string idcliente;
            idcliente = words[0];


            lbl_idcliente.Text = idcliente;


            dgCliente parametro2 = new dgCliente
            {
                Id_Cliente = Convert.ToInt16(lbl_idcliente.Text)
            };

            List<dgCliente> listacliente = c_cliente.LeerCliente(3, parametro2);

            if (listacliente.Count > 0)

            {

                foreach (dgCliente dg in listacliente)
                {

                    txt_nombre.Text = Convert.ToString(dg.Nombre.ToString());
                    txt_apellidopaterno.Text = Convert.ToString(dg.Apellido_Paterno.ToString());
                    txt_apellidomaterno.Text = Convert.ToString(dg.Apellido_Materno.ToString());
                    txt_telefono.Text = Convert.ToString(dg.Telefono.ToString());
                    txt_correo.Text = Convert.ToString(dg.Correo.ToString());
                    txt_estado.Text = Convert.ToString(dg.Estado.ToString());
                    txt_municipio.Text = Convert.ToString(dg.Municipio.ToString());
                    txt_colonia.Text = Convert.ToString(dg.Colonia.ToString());
                    txt_calle.Text = Convert.ToString(dg.Calle.ToString());
                    txt_numcasa.Text = Convert.ToString(dg.NumCasa.ToString());
                }
            }
        }

        private void modificar_cliente_Load(object sender, EventArgs e)
        {
            dgCliente parametro = new dgCliente();

            List<dgCliente> lista = c_cliente.LeerCliente(1, parametro);

            if (lista.Count > 0)

            {

                string concatenacion = "";
                foreach (dgCliente d in lista)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Cliente.ToString() + " " + d.Nombre.ToString() + " " + d.Apellido_Paterno.ToString() + " " + d.Apellido_Materno.ToString();

                    bx_cliente.Items.Add(concatenacion);
                }
            }
        }

        private void bx_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_nombre.Focus();
        }

       

       


        private void txt_telefono_modificarcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_correo.Focus();

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

       

       

        private void txt_numcasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_apellidopaterno.Focus();
        }

        private void txt_apellidopaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_apellidomaterno.Focus();
        }

        private void txt_apellidomaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_telefono.Focus();
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_correo.Focus();

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

        private void txt_correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_estado.Focus();

            txt_estado.Text = "NUEVO LEON";
        }



        private void txt_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_municipio.Focus();
        }

        private void txt_municipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_colonia.Focus();
        }


        private void txt_colonia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_calle.Focus();
        }

        private void txt_calle_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_numcasa.Focus();
        }

        private void txt_numcasa_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btn_modificar_cliente.Focus();

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
