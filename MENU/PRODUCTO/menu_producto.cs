using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.CATEGORIA;
using PUNTOVENTA.MENU.MEDIDA;

namespace PUNTOVENTA.MENU.PRODUCTO
{
    public partial class menu_producto : Form
    {
        public menu_producto()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregar_categoria forms = new agregar_categoria();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void modificarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            modificar_categoria forms = new modificar_categoria();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void eliminarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            eliminar_categoria forms = new eliminar_categoria();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        
        

        private void menu_producto_Load(object sender, EventArgs e)
        {

        }
     

        private void menu_producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void agregarMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregar_medida forms = new agregar_medida();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void modificarMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            modificar_medida forms = new modificar_medida();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void eliminarMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            eliminar_medida forms = new eliminar_medida();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
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
    }
}
