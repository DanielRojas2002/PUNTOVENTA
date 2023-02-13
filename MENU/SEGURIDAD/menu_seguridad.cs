using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;

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
            string retorno = "", retorno2 = "";

            dgUsuario parametro = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)

            };

            List<dgUsuario> lista = c_usuario.LeerUsuario(2, parametro);

            if (lista.Count > 0)

            {

                foreach (dgUsuario d in lista)
                {
                    retorno = Convert.ToString(d.Usuario.ToString());
                }




                


            }



            dgUsuario parametro2 = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)

            };



            List<dgUsuario> lista2 = c_usuario.LeerUsuario(3, parametro);

            if (lista.Count > 0)

            {

                foreach (dgUsuario d in lista2)
                {
                    retorno2 = Convert.ToString(d.DescripcionPerfil.ToString());
                }


               


            }


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
