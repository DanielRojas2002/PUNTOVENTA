using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;

namespace PUNTOVENTA.MENU.PROVEEDOR
{
    public partial class menu_proveedor : Form
    {
        public menu_proveedor()
        {
            InitializeComponent();
        }

        private void menu_proveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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




                txt_usuario.Text = ("Bievenido usuario: " + retorno);


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


                lbl_perfil.Text = ("Perfil: " + retorno2);


            }


            this.Hide();
            Inicio formulario = new Inicio();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();
        }

        private void btn_agregarProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregar_proveedor forms = new agregar_proveedor();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_modificar_proveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            modificar_proveedor forms = new modificar_proveedor();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_eliminar_proveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            eliminar_proveedor forms = new eliminar_proveedor();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
