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
            if (txt_correo_modificarcliente.Text == "")
            {

                MessageBox.Show("Ingrese el correo del Cliente");
            }
            else if (txt_nombre_modificarcliente.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del Cliente ");
            }
            else if (txt_apellidopaterno_modificarcliente.Text == "") 
            {
                MessageBox.Show("Ingrese el apellido paterno del Cliente");
            }
            else if (txt_apellidomaterno_modificarcliente.Text == "")
            {
                MessageBox.Show("Ingrese el apellido materno del Cliente");
            }
            else if (txt_telefono_modificarcliente.Text == "")
            {
                MessageBox.Show("Ingrese el telefono del Cliente ");
            }
            else if (txt_direccion_modificarcliente.Text == "")
            {
                MessageBox.Show("Ingrese la direccion del Cliente ");
            }

            else
            {
                dgCliente parametro = new dgCliente
                {
                    Id_Cliente = Convert.ToInt16(lbl_idcliente.Text),
                    Correo = txt_correo_modificarcliente.Text.Trim(),
                    Nombre = txt_nombre_modificarcliente.Text.Trim().ToUpper(),
                    Apellido_Paterno = txt_apellidopaterno_modificarcliente.Text.Trim().ToUpper(),
                    Apellido_Materno = txt_apellidomaterno_modificarcliente.Text.Trim().ToUpper(),
                    Telefono = txt_telefono_modificarcliente.Text.Trim(),
                    Direccion = txt_direccion_modificarcliente.Text.Trim().ToUpper(),


                };



                string control = "";

                control = c_cliente.ModificarCliente(parametro);




                MessageBox.Show("Cliente Modificado exitosamente", "Correcto");
                RegresarVentana();



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

                    txt_nombre_modificarcliente.Text = Convert.ToString(dg.Nombre.ToString());
                    txt_apellidopaterno_modificarcliente.Text = Convert.ToString(dg.Apellido_Paterno.ToString());
                    txt_apellidomaterno_modificarcliente.Text = Convert.ToString(dg.Apellido_Materno.ToString());
                    txt_correo_modificarcliente.Text = Convert.ToString(dg.Correo.ToString());
                    txt_telefono_modificarcliente.Text = Convert.ToString(dg.Telefono.ToString());
                    txt_direccion_modificarcliente.Text = Convert.ToString(dg.Direccion.ToString());
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
                txt_nombre_modificarcliente.Focus();
        }

        private void txt_nombre_modificarcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_apellidopaterno_modificarcliente.Focus();
        }

        private void txt_apellidopaterno_modificarcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_apellidomaterno_modificarcliente.Focus();
        }

        private void txt_apellidomaterno_modificarcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_telefono_modificarcliente.Focus();
        }

        private void txt_telefono_modificarcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_correo_modificarcliente.Focus();
        }

        private void txt_correo_modificarcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_direccion_modificarcliente.Focus();
        }

        private void txt_direccion_modificarcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btn_modificar_cliente.Focus();
        }
    }
}
