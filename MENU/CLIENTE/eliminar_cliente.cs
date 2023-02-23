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
    public partial class eliminar_cliente : Form
    {
        public eliminar_cliente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargaCliente()
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eliminar_cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_eliminar_cliente_Click(object sender, EventArgs e)
        {

            if (bx_cliente.Text == "" && idCliente.Text == "")
            {

                MessageBox.Show("Seleccione el Cliente a eliminar ");
            }

            else 
            {
                int idcliente = Convert.ToInt16(idCliente.Text);

                dgCliente parametro = new dgCliente
                {
                    Id_Cliente = idcliente
                };

                string control = "";

                control = c_cliente.EliminarCliente(parametro);

                if (control == "1")
                {

                    MessageBox.Show("No se puede eliminar este Cliente ya que cuenta con Credito sin liquidar", "Error");
                }

                else
                {
                    MessageBox.Show("Cliente Eliminado", "Correcto");

                    RegresarVentana();
                }
            } 
            



        }

        private void eliminar_cliente_Load(object sender, EventArgs e)
        {
            CargaCliente();
        }

        private void bx_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            string concatenacion = bx_cliente.Text;
            string[] words = concatenacion.Split(' ');
            string idcliente;
            idcliente = words[0];


            idCliente.Text = idcliente;

           




        }
    }
}
