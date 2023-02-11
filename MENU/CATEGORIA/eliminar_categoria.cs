using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.MENU.PRODUCTO;

namespace PUNTOVENTA.MENU.CATEGORIA
{
    public partial class eliminar_categoria : Form
    {
        public eliminar_categoria()
        {
            InitializeComponent();
        }

        private void bx_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            string descripcion;
            descripcion = bx_categorias.Text;
            c_categoria log = new c_categoria();
            id = log.Checar_id(descripcion);

            string idd;
            idd = Convert.ToString(id);
            List<string> Lista = new List<string>();

            c_categoria log2 = new c_categoria();
            Lista = log2.ChecarDescripcion(idd);



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
            menu_producto formulario = new menu_producto();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_usuario_Click(object sender, EventArgs e)
        {
            string usuario, tabla;


            if (bx_categorias.Text == "")
            {

                MessageBox.Show("Seleccione la Categoria a eliminar ");
            }


            else
            {
                usuario = bx_categorias.Text;
                tabla = "CATEGORIA";

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

        private void eliminar_categoria_Activated(object sender, EventArgs e)
        {
            string id;
            int c_ListaCategorias = 0;
            string usuario = "";

            id = lbl_id.Text;



            c_categoria log = new c_categoria();
            usuario = log.ChecarDescrip(id);



            List<string> ListaCategoria = new List<string>();
            c_categoria log2 = new c_categoria();
            ListaCategoria = log2.ChecarCategoriaTodos();

            c_ListaCategorias = ListaCategoria.Count();

            for (int i = 0; i < c_ListaCategorias; i++)
            {
                if (ListaCategoria[i] != usuario)
                {
                    bx_categorias.Items.Add(ListaCategoria[i]);
                }

            }
        }
    }
}
