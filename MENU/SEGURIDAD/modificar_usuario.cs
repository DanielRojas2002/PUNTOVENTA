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

        private void modificar_usuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string tabla;

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
                int id;
                string ids;

                string usuario, usuarioo, contraseña;
                usuarioo = txt_usuarioo.Text;
                usuario = bx_usuario.Text;
                contraseña = txt_contraseña.Text;

                c_seguridad log = new c_seguridad();
                id = log.Checar_id(usuario);

                ids = Convert.ToString(id);

                tabla = "USUARIO";

                List<string> listacampos = new List<string>();
                List<string> listatipodato = new List<string>();
                List<string> listavalores = new List<string>();

                List<string> listacamposwhere = new List<string>();
                List<string> listacamposwheretipodato = new List<string>();
                List<string> listavaloreswhere = new List<string>();

                listacampos.Add("Usuario");
                listacampos.Add("Contrasenia");


                listatipodato.Add("string");
                listatipodato.Add("string");




                listavalores.Add(usuarioo);
                listavalores.Add(contraseña);

                listacamposwhere.Add("Id_Usuario");
                listacamposwheretipodato.Add("int");
                listavaloreswhere.Add(ids);


                c_crud log2 = new c_crud();
                log2.Update(tabla, listacampos, listavalores, listatipodato, listacamposwhere, listacamposwheretipodato, listavaloreswhere);
                MessageBox.Show("Usuario Actualizado", "Correcto");


                string idd;
                idd = lbl_id.Text;
                string retorno1, retorno2;
                c_seguridad log1 = new c_seguridad();
                retorno1 = log1.ChecarUsuario(idd);
                txt_usuario.Text = "";

                c_seguridad log3 = new c_seguridad();
                retorno2 = log3.ChecarPerfil(idd);
                lbl_perfil.Text = "";

                this.Hide();
                menu_seguridad formulario = new menu_seguridad();
                formulario.lbl_id.Text = idd;
                formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                formulario.txt_usuario.Text = Convert.ToString(retorno1);
                formulario.Show();
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
            string id;
            int c_Listausuarios = 0;
            string usuario = "";

            id = lbl_id.Text;



            c_seguridad log = new c_seguridad();
            usuario = log.ChecarUsuario(id);



            List<string> Listausuarios = new List<string>();
            c_seguridad log2 = new c_seguridad();
            Listausuarios = log2.ChecarUsuarioTodos();

            c_Listausuarios = Listausuarios.Count();

            for (int i = 0; i < c_Listausuarios; i++)
            {
                if (Listausuarios[i] != usuario)
                {
                    bx_usuario.Items.Add(Listausuarios[i]);
                }

            }
        }

        private void bx_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            string usuario;
            string retorno2;
            usuario = bx_usuario.Text;
            c_seguridad log = new c_seguridad();
            id = log.Checar_id(usuario);

            string idd;
            idd = Convert.ToString(id);
            List<string> Lista = new List<string>();


            c_seguridad log2 = new c_seguridad();
            Lista = log2.ChecarUC(idd);
            txt_usuarioo.Text = Lista[0];
            txt_contraseña.Text = Lista[1];


            c_seguridad log3 = new c_seguridad();
            retorno2 = log3.ChecarPerfil(Convert.ToString(Lista[2]));
            lblperfil.Text = Convert.ToString(retorno2);






        }

        private void lbl_perfil_Click(object sender, EventArgs e)
        {

        }
    }
}
