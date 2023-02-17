using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.CATEGORIA;
using PUNTOVENTA.MENU.MEDIDA;
using System.Windows.Forms;
using System;
using Punto_de_Venta.Clases;

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


            dgProducto parametro = new dgProducto();

            List<dgProducto> lista = c_producto.LeerProducto(4, parametro);


            if (lista.Count > 0)

            {
                int idproducto, idcategoria, idmedida,stock;
                string nombre, categoriadescripcion, medidadescripcion;
                foreach (dgProducto d in lista)
                {
                    idproducto = Convert.ToInt16(d.Id_Producto.ToString());
                    idcategoria = Convert.ToInt16(d.Id_Categoria.ToString());
                    idmedida = Convert.ToInt16(d.Id_Medida.ToString());
                    stock = Convert.ToInt16(d.StockInicial.ToString());

                    nombre = Convert.ToString(d.Nombre.ToString());

                    dgCategoria parametro2 = new dgCategoria
                    {
                        Id_Categoria = Convert.ToInt16(idcategoria.ToString())
                    };

                    List<dgCategoria> listacategoria = c_categoria.LeerCategoria(3, parametro2);


                    dgMedida parametro3 = new dgMedida
                    {
                        Id_Medida = Convert.ToInt16(idmedida.ToString())
                    };

                    List<dgMedida> listamedida = c_medida.LeerMedida(3, parametro3);

                    if (listacategoria.Count > 0 && listamedida.Count > 0)

                    {
                        categoriadescripcion = "";
                        medidadescripcion = "";
                        foreach (dgCategoria dg in listacategoria)
                        {
                            categoriadescripcion = Convert.ToString(dg.Descripcion.ToString());
                        }

                        foreach (dgMedida dg in listamedida)
                        {
                            medidadescripcion = Convert.ToString(dg.Descripcion.ToString());
                        }

                        dataGridView_productos.Rows.Add(idproducto, nombre, categoriadescripcion, medidadescripcion, idmedida, stock);
                    }
                   

                }

            }




            bx_categorias.Items.Clear();
            dgCategoria parametro2_1 = new dgCategoria
            {

            };

            List<dgCategoria> listacategorias = c_categoria.LeerCategoria(1, parametro2_1);

            if (lista.Count > 0)

            {

                foreach (dgCategoria d in listacategorias)
                {
                    bx_categorias.Items.Add(d.Descripcion.ToString());
                }





            }



            bx_medidas.Items.Clear();

            dgMedida parametro4 = new dgMedida
            {

            };

            List<dgMedida> listamedidas = c_medida.LeerMedida(1, parametro4);

            if (listamedidas.Count > 0)

            {

                foreach (dgMedida d in listamedidas)
                {
                    bx_medidas.Items.Add(d.Descripcion.ToString());
                }





            }


            bx_proveedores.Items.Clear();

            dgProveedor parametro5 = new dgProveedor
            {

            };

            List<dgProveedor> listaproveedores = c_proveedor.LeerProveedor(1, parametro5);

            if (listaproveedores.Count > 0)

            {

                foreach (dgProveedor d in listaproveedores)
                {
                    bx_proveedores.Items.Add(d.Nombre.ToString());
                }

            }



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

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregar_producto formulario = new agregar_producto();
            formulario.lbl_id.Text = lbl_id.Text;
            formulario.lbl_perfil.Text = lbl_perfil.Text;
            formulario.txt_usuario.Text = txt_usuario.Text;
            formulario.Show();
        }

        private void datagrid_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_aplicar_filtro_Click(object sender, EventArgs e)
        {

        }

        private void bx_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bx_medidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bx_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            string idProducto = dataGridView_productos.CurrentRow.Cells["Col_IdProducto"].Value.ToString();

            this.Hide();
            modificar_eliminar_producto forms = new modificar_eliminar_producto();
            forms.lbl_id.Text = lbl_id.Text;
            forms.lblidproducto.Text = idProducto;
            forms.Show();
        }
    }
}
