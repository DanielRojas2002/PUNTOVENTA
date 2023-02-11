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
            string usuario, tabla;


            if (bx_usuario.Text == "")
            {

                MessageBox.Show("Seleccione el usuario a eliminar ");
            }


            else
            {
                usuario = bx_usuario.Text;
                tabla = "USUARIO";

                List<string> listacampos = new List<string>();
                List<string> listatipodato = new List<string>();
                List<string> listavalores = new List<string>();

                listacampos.Add("Usuario");


                listatipodato.Add("string");

                listavalores.Add(usuario);



                c_crud log2 = new c_crud();
                log2.Delete(tabla, listacampos, listavalores, listatipodato);
                MessageBox.Show("Usuario Eliminado", "Correcto");


                string id;
                id = lbl_id.Text;
                string retorno1, retorno2;
                c_seguridad log = new c_seguridad();
                retorno1 = log.ChecarUsuario(id);
                txt_usuario.Text = "";

                c_seguridad log3 = new c_seguridad();
                retorno2 = log3.ChecarPerfil(id);
                lbl_perfil.Text = "";

                this.Hide();
                menu_seguridad formulario = new menu_seguridad();
                formulario.lbl_id.Text = id;
                formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                formulario.txt_usuario.Text = Convert.ToString(retorno1);
                formulario.Show();

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


            c_seguridad log3 = new c_seguridad();
            retorno2 = log3.ChecarPerfil(Convert.ToString(Lista[2]));
            lblperfil.Text = Convert.ToString(retorno2);
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

        private void eliminar_usuario_Activated(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
