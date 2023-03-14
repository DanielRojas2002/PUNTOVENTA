using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.CLIENTE;
using PUNTOVENTA.MENU.PRODUCTO;

namespace Punto_de_Venta
{
    public partial class eliminar_usuario : Form
    {
        public eliminar_usuario()
        {
            InitializeComponent();

           

        }

        private void btn_eliminar_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (bx_usuario.Text == "" && lbl_perfil.Text == "")
                {

                    MessageBox.Show("Seleccione el Usuario a eliminar ");
                }


                else
                {
                    dgUsuario parametro = new dgUsuario
                    {
                        Id_Usuario = Convert.ToInt16(bl_id_combobox.Text)
                    };




                    string control = "";

                    control = c_usuario.EliminarUsuario(parametro);

                    if (control == "1")
                    {

                        MessageBox.Show("No se puede eliminar esta Usuario", "Error");
                    }

                    else
                    {
                        MessageBox.Show("Usuario Eliminado", "Correcto");

                        RegresarVentana();
                    }






                }
            }
            catch
            {
                MessageBox.Show("Seleccione una Usuario a Eliminar", "Error");
            }


        }

        private void bx_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            string concatenacion = bx_usuario.Text;
            string[] words = concatenacion.Split(' ');
            string idusuario;
            idusuario = words[0];





            bl_id_combobox.Text = idusuario;


            dgUsuario parametro3 = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(bl_id_combobox.Text)
            };

            List<dgUsuario> lista3 = c_usuario.LeerUsuario(3, parametro3);

            if (lista3.Count > 0)

            {

                foreach (dgUsuario d in lista3)
                {
                    lblperfil.Text = d.DescripcionPerfil.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Medidas Agregadas", "Advertencia");
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
            menu_seguridad formulario = new menu_seguridad();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();





        }
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
        }

        private void eliminar_usuario_Activated(object sender, EventArgs e)
        {



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
      

        private void eliminar_usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bl_id_combobox_Click(object sender, EventArgs e)
        {

        }

        private void descripcioncb_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eliminar_usuario_Load(object sender, EventArgs e)
        {
            dgUsuario parametro = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)
            };

            List<dgUsuario> lista = c_usuario.LeerUsuario(4, parametro);

            if (lista.Count > 0)

            {

                string concatenacion = "";
                foreach (dgUsuario d in lista)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Usuario.ToString() + " " + d.Usuario.ToString();

                    bx_usuario.Items.Add(concatenacion);
                }
            }



           
        }

        private void bx_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                panel_eliminarusuario.Focus();
        }
    }
}
