using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
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

            dgCategoria parametro = new dgCategoria();

            parametro.Descripcion = descripcion;

            List<dgCategoria> lista = c_categoria.LeerCategoria(2, parametro);

            if (lista.Count > 0)

            {

                foreach (dgCategoria d in lista)
                {
                    lbl_id_categoria.Text=d.Id_Categoria.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Categorias Agregadas", "Advertencia");
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
            try
            {
                if (bx_categorias.Text == "" && lbl_id_categoria.Text == "")
                {

                    MessageBox.Show("Seleccione la Categoria a eliminar ");
                }


                else
                {
                    dgCategoria parametro = new dgCategoria();

                    parametro.Id_Categoria = Convert.ToInt16(lbl_id_categoria.Text);




                    string control = "";

                    control = c_categoria.EliminarCategoria(parametro);

                    if (control == "1")
                    {

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
            catch
            {
                MessageBox.Show("Seleccione una Categoria", "Error");
            }
            
        }

        private void eliminar_categoria_Activated(object sender, EventArgs e)
        {
            bx_categorias.Items.Clear();
            dgCategoria parametro = new dgCategoria();

            parametro.Descripcion = "no";

            List<dgCategoria> lista = c_categoria.LeerCategoria(1,parametro);

            if (lista.Count > 0)

            {

                foreach (dgCategoria d in lista)
                {
                    bx_categorias.Items.Add(d.Descripcion.ToString());
                }

           



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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
