using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PRODUCTO;
using PUNTOVENTA.MENU.PROVEEDOR;
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
    public partial class agregar_cliente : Form
    {
        public agregar_cliente()
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
            menu_cliente formulario = new menu_cliente();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();





        }
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
        }

        private void agregar_cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_crear_cliente_Click(object sender, EventArgs e)
        {

            if (txt_nombre_agregarcliente.Text == "")
            {

                MessageBox.Show("Ingrese el Nombre del cliente ha agregar ");
            }
            else if (txt_apellidopaterno_agregarcliente.Text == "")
            {

                MessageBox.Show("Ingrese el apellido paterno ha agregar ");
            }

            else if (txt_apellidomaterno_agregarcliente.Text == "")
            {

                MessageBox.Show("Ingrese el apellido materno ha agregar ");
            }

            else if (txt_telefono_agregarcliente.Text == "")
            {

                MessageBox.Show("Ingrese el telefono del cliente ha agregar ");
            }
            else if (txt_correo_agregarcliente.Text == "")
            {

                MessageBox.Show("Ingrese el correo del cliente ha agregar ");
            }
            else if (txtx_direccion_agregarcliente.Text == "")
            {

                MessageBox.Show("Ingrese la Direccion del cliente ha agregar ");
            }

            else
            {
                dgCliente parametro = new dgCliente
                {
                    Nombre = txt_nombre_agregarcliente.Text.Trim().ToUpper(),
                    Apellido_Paterno = txt_apellidopaterno_agregarcliente.Text.Trim().ToUpper(),
                    Apellido_Materno = txt_apellidomaterno_agregarcliente.Text.Trim().ToUpper(),
                    Telefono = txt_telefono_agregarcliente.Text.Trim().ToUpper(),
                    Correo = txt_correo_agregarcliente.Text.Trim().ToUpper(),
                    Direccion = txtx_direccion_agregarcliente.Text.Trim().ToUpper()

                };



                string control = "";

                control = c_cliente.InsertarCliente(parametro);

                if (control == "2")
                {

                    MessageBox.Show("Ya Existe un Cliente con ese Telefono", "Error");
                }
                else if (control == "3")
                {
                    MessageBox.Show("Ya existe un Cliente con ese Correo", "Error");
                }
                else
                {
                    MessageBox.Show("Cliente Dado de alta", "Correcto");
                    RegresarVentana();
                }

            }
        }
    }
}
