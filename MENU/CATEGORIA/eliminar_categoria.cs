using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.MENU.PRODUCTO;
using System.Reflection.Metadata;

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
            lbl_id_categoria.Text= idd;



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


            if (bx_categorias.Text == "" && lbl_id_categoria.Text=="")
            {

                MessageBox.Show("Seleccione la Categoria a eliminar ");
            }


            else
            {


                string idcategoria =lbl_id_categoria.Text;

               
                string control = "";

                control = c_categoria.EliminarCategoria(idcategoria);

                if (control == "1")
                {
                    //swal("Error", "Favor de llenar todos los Campos", "error");
                    MessageBox.Show("No se puede eliminar esta Categoria", "Error");
                }

                else
                {
                    MessageBox.Show("Categoria Eliminada", "Correcto");

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
                    menu_producto formulario = new menu_producto();
                    formulario.lbl_id.Text = id;
                    formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                    formulario.txt_usuario.Text = Convert.ToString(retorno1);
                    formulario.Show();
                }

               


               

            }
        }

        private void eliminar_categoria_Activated(object sender, EventArgs e)
        {

            int c_ListaCategorias = 0;

            string tabla = "CATEGORIA";
            List<string> ListaCampos = new List<string>();
            List<string> ListaTipoDato = new List<string>();

            ListaCampos.Add("Descripcion");
            ListaTipoDato.Add("string");


            List<string> ListaCategoria = new List<string>();
            c_crud log2 = new c_crud();
            ListaCategoria = log2.SelectNormal(tabla,ListaCampos,ListaTipoDato);

            c_ListaCategorias = ListaCategoria.Count();

            for (int i = 0; i < c_ListaCategorias; i++)
            {
               
                bx_categorias.Items.Add(ListaCategoria[i]);
                

            }
        }

        private void lbl_id_categoria_Click(object sender, EventArgs e)
        {

        }

        private void eliminar_categoria_Load(object sender, EventArgs e)
        {

        }
  

        private void eliminar_categoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
