namespace Punto_de_Venta
{
    public partial class seguridad : Form
    {
        public seguridad()
        {
            InitializeComponent();
            List<string> listap = new List<string>();

            c_seguridad log = new c_seguridad();
            listap = log.ChecarPerfiles();
            int c_lista = listap.Count;
            string valorl;

            for (int i = 0; i < c_lista; i++)
            {
                valorl = listap[i];
                bx_permisos.Items.Add(valorl);
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            string id;
            id = lbl_id.Text;
            string retorno, retorno2;
            c_seguridad log = new c_seguridad();
            retorno = log.ChecarUsuario(id);
            txt_usuario.Text = "";

            c_seguridad log2 = new c_seguridad();
            retorno2 = log2.ChecarPerfil(id);
            lbl_perfil.Text = "";

            this.Hide();
            menu_seguridad formulario = new menu_seguridad();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();
        }

        private void seguridad_Activated(object sender, EventArgs e)
        {

        }

        private void btn_crear_usuario_Click(object sender, EventArgs e)
        {
            string usuario, contraseña, perfil, tabla;


            if (txt_usuarioo.Text == "")
            {

                MessageBox.Show("Ingrese el Usuario ha agregar ");
            }
            else if (txt_contraseña.Text == "")
            {

                MessageBox.Show("Ingrese la Contraseña ha agregar");

            }
            else if (bx_permisos.Text == "")
            {

                MessageBox.Show("Ingrese el perfil ");
            }


            else
            {
                usuario = txt_usuarioo.Text;
                contraseña = txt_contraseña.Text;
                perfil = bx_permisos.Text;
                if (perfil == "Administrador")
                {
                    perfil = "1";
                }
                else if (perfil == "Vendedor")
                {
                    perfil = "2";
                }



                else if (perfil == "Comprador")
                {
                    perfil = "3";
                }

                tabla = "USUARIO";

                List<string> listacampos = new List<string>();
                List<string> listatipodato = new List<string>();
                List<string> listavalores = new List<string>();

                listacampos.Add("Usuario");
                listacampos.Add("Contrasenia");
                listacampos.Add("Id_Perfil");

                listatipodato.Add("string");
                listatipodato.Add("string");
                listatipodato.Add("int");


                listavalores.Add(usuario);
                listavalores.Add(contraseña);
                listavalores.Add(perfil);

                try
                {
                    c_crud log = new c_crud();
                    log.Insert(tabla, listacampos, listavalores, listatipodato);
                    MessageBox.Show("Usuario Dado de alta", "Correcto");
                }
                catch
                {
                    MessageBox.Show("Error 203", "Incorrecto");
                }
                finally
                {
                    string id;
                    id = lbl_id.Text;
                    string retorno1, retorno2;
                    c_seguridad log = new c_seguridad();
                    retorno1 = log.ChecarUsuario(id);
                    txt_usuario.Text = "";

                    c_seguridad log2 = new c_seguridad();
                    retorno2 = log2.ChecarPerfil(id);
                    lbl_perfil.Text = "";

                    this.Hide();
                    menu_seguridad formulario = new menu_seguridad();
                    formulario.lbl_id.Text = id;
                    formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                    formulario.txt_usuario.Text = Convert.ToString(retorno1);
                    formulario.Show();
                }




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
    }
}
