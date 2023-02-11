namespace Punto_de_Venta
{
    public partial class menu_seguridad : Form
    {
        public menu_seguridad()
        {
            InitializeComponent();
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
            Inicio formulario = new Inicio();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string id;
            id = lbl_id.Text;
            this.Hide();
            seguridad forms = new seguridad();
            forms.lbl_id.Text = id;
            forms.Show();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            modificar_usuario forms = new modificar_usuario();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            this.Hide();
            eliminar_usuario forms = new eliminar_usuario();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void menu_seguridad_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
