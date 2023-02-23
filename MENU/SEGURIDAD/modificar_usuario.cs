using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PRODUCTO;

namespace Punto_de_Venta
{
    public partial class modificar_usuario : Form
    {
        public modificar_usuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void modificar_usuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
     

            try
            {

                if (txt_usuarioo.Text == "")
                {
                    MessageBox.Show("Ingrese el nuevo nombre de usuario");
                }
                else if (txt_contraseña.Text == "")
                {
                    MessageBox.Show("Ingrese la nueva contraseña");
                }
                else if (bx_usuario.Text == "")
                {

                    MessageBox.Show("Seleccione el usuario a cambiar ");
                }

                else
                {

                    dgUsuario parametro = new dgUsuario
                    {
                        Id_Usuario = Convert.ToInt16(bl_id_combobox.Text),

                        Usuario = Convert.ToString(txt_usuarioo.Text.Trim()),

                        Contrasenia = Convert.ToString(txt_contraseña.Text.Trim())
                    };

                    string control = "";

                    control = c_usuario.ModificarUsuario(parametro);

                    if (control == "1")
                    {

                        MessageBox.Show("No se puede modificar esta Medida", "Error");
                    }

                    else
                    {
                        MessageBox.Show("Usuario Modificado", "Correcto");
                        RegresarVentana();
                    }






                }
            }
            catch
            {
                MessageBox.Show("Seleccione un Usuario a Modificar", "Error");
            }

            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.UseSystemPasswordChar == true)
            {
                txt_contraseña.UseSystemPasswordChar = false;
            }

            else
            {
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void modificar_usuario_Activated(object sender, EventArgs e)
        {
     
            
            int id;
            string descripcion;
            descripcion = bx_usuario.Text;

            dgUsuario parametro = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)


            };

            List<dgUsuario> lista = c_usuario.LeerUsuario(4, parametro);

            if (lista.Count > 0)

            {

                foreach (dgUsuario d in lista)
                {

                    bx_usuario.Items.Add(d.Usuario);



                }
            }

            else

            {

            }
        }

        private void bx_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            string descripcion;
            descripcion = bx_usuario.Text;



            // acceder al valor del combobox 




            descripcioncb.Text = bx_usuario.Text;


            dgUsuario parametro2 = new dgUsuario
            {
                Usuario = Convert.ToString(descripcioncb.Text)
            };

            List<dgUsuario> lista2 = c_usuario.LeerUsuario(5, parametro2);

            if (lista2.Count > 0)

            {

                foreach (dgUsuario d in lista2)
                {
                    bl_id_combobox.Text = d.Id_Usuario.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Usuarios Agregadas", "Advertencia");
            }






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
                MessageBox.Show("No tiene Usuarios Agregadas", "Advertencia");
            }

            int idusuario = Convert.ToInt16(bl_id_combobox.Text);




            dgUsuario parametro4 = new dgUsuario
            {
                Id_Usuario = idusuario
            };

            List<dgUsuario> lista4 = c_usuario.LeerUsuario(2, parametro4);

            if (lista3.Count > 0)

            {

                foreach (dgUsuario d in lista4)
                {
                    txt_usuarioo.Text = d.Usuario.ToString();
                    txt_contraseña.Text = d.Contrasenia.ToString();

                }
            }

            else

            {
                MessageBox.Show("No tiene Usuarios Agregadas", "Advertencia");
            }



        }

        private void lbl_perfil_Click(object sender, EventArgs e)
        {

        }

      

        private void modificar_usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
