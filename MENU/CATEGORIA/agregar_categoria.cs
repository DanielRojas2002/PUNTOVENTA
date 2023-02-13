using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PRODUCTO;

namespace PUNTOVENTA.MENU.CATEGORIA
{
    public partial class agregar_categoria : Form
    {
        public agregar_categoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void agregar_categoria_Load(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_Click(object sender, EventArgs e)
        {

        }

        private void lbl_perfil_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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
            menu_producto formulario = new menu_producto();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();
        }

        private void btn_crear_categoria_Click(object sender, EventArgs e)
        {

            


            if (txt_descripcion.Text == "")
            {

                MessageBox.Show("Ingrese la Descripcion de la Categoria ha agregar ");
            }

            else
            {
                dgCategoria parametro = new dgCategoria();

                parametro.Descripcion= txt_descripcion.Text.Trim().ToUpper();
               


                string control = "";

                control = c_categoria.InsertarCategoria(parametro);

                if (control == "1")
                {
                    
                    MessageBox.Show("Ya Existe una Categoria Similar", "Error");
                }

                else
                {
                    MessageBox.Show("Categoria Dado de alta", "Correcto");
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
                    menu_producto formulario = new menu_producto();
                    formulario.lbl_id.Text = id;
                    formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                    formulario.txt_usuario.Text = Convert.ToString(retorno1);
                    formulario.Show();
                }
              
            }

        }

   

        private void agregar_categoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
