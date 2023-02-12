using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PRODUCTO;

namespace PUNTOVENTA.MENU.CATEGORIA
{
    public partial class modificar_categoria : Form
    {
        public modificar_categoria()
        {
            InitializeComponent();

           
            dgCategoria parametro = new dgCategoria();

            parametro.Descripcion = "no";

            List<dgCategoria> lista = c_categoria.LeerCategoria(1, parametro);

            if (lista.Count > 0)

            {

                foreach (dgCategoria d in lista)
                {
                    bx_categorias.Items.Add(d.Descripcion.ToString());
                }





            }
        }

        private void btn_modificar_categoria_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = bx_categorias.SelectedItem.ToString();

                if (valor == null)
                {
                    MessageBox.Show("Selecione una Categoria a Modificar ");

                }

                else if (txt_descripcion.Text == "")
                {
                    MessageBox.Show(" Ingrese la Descripcion a Modificar");

                }

                else
                {
                    dgCategoria parametro = new dgCategoria();

                    parametro.Id_Categoria = Convert.ToInt16(lbl_id_categoria.Text);

                    parametro.Descripcion=Convert.ToString(txt_descripcion.Text.Trim().ToUpper());
                   


                    string control = "";

                    control = c_categoria.ModificarCategoria(parametro);

                    if (control == "1")
                    {

                        MessageBox.Show("No se puede modificar esta Categoria", "Error");
                    }

                    else
                    {
                        MessageBox.Show("Categoria Modificada", "Correcto");

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

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

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
                    lbl_id_categoria.Text = d.Id_Categoria.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Categorias Agregadas", "Advertencia");
            }

            dgCategoria parametro2 = new dgCategoria();

            parametro2.Id_Categoria = Convert.ToInt16(lbl_id_categoria.Text);

            List<dgCategoria> listadesc = c_categoria.LeerCategoria(3, parametro2);

            if (listadesc.Count > 0)

            {

                foreach (dgCategoria dg in listadesc)
                {
                    txt_descripcion.Text = dg.Descripcion.ToString();
                }
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

        private void modificar_categoria_Activated(object sender, EventArgs e)
        {
            

           
        }

        private void modificar_categoria_Load(object sender, EventArgs e)
        {

        }

      

        private void modificar_categoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
