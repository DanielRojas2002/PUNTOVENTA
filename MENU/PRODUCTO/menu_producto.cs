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
                int idcategoria, idmedida,stock;
                string nombre, categoriadescripcion, medidadescripcion, idproducto;
                foreach (dgProducto d in lista)
                {
                    idproducto = Convert.ToString(d.Id_Producto.ToString());
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

                        dataGridView_productos.Rows.Add(idproducto, nombre, categoriadescripcion, medidadescripcion, stock);
                    }
                   

                }

            }







            dgProducto parametroinactivos = new dgProducto();

            List<dgProducto> listainactivos = c_producto.LeerProducto(10, parametroinactivos);


            if (listainactivos.Count > 0)

            {
                int idcategoria, idmedida, stock;
                string nombre, categoriadescripcion, medidadescripcion, idproducto;
                foreach (dgProducto d in listainactivos)
                {
                    idproducto = Convert.ToString(d.Id_Producto.ToString());
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

                        dataGridView_productos_inactivos.Rows.Add(idproducto, nombre, categoriadescripcion, medidadescripcion, stock);
                    }


                }

            }

            string concatenacion = "";
            dgMedida parametro2_1 = new dgMedida();

            List<dgMedida> lista2 = c_medida.LeerMedida(1, parametro2_1);

            if (lista2.Count > 0)

            {

                concatenacion = "";
                foreach (dgMedida d in lista2)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Medida.ToString() + " " + d.Descripcion.ToString();

                    bx_medidas.Items.Add(concatenacion);
                }

               

            }


            dgCategoria parametro3_1 = new dgCategoria
            {

            };

            List<dgCategoria> listac = c_categoria.LeerCategoria(1, parametro3_1);


            if (listac.Count > 0)

            {

                concatenacion = "";
                foreach (dgCategoria d in listac)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Categoria.ToString() + " " + d.Descripcion.ToString();
                    bx_categorias.Items.Add(concatenacion);

                }
               
            }

            dgProveedor parametro61 = new dgProveedor();

            List<dgProveedor> listap = c_proveedor.LeerProveedor(1, parametro61);


            if (lista.Count > 0)

            {

                concatenacion = "";
                foreach (dgProveedor d in listap)
                {
                    concatenacion = "";
                    concatenacion = d.Id_Proveedor.ToString() + " " + d.Nombre.ToString();

                    bx_proveedores.Items.Add(concatenacion);
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

        private void RegresarVentana()
        {

            string id;
            id = lbl_id.Text;

            string retorno = "", retorno2 = "";

            dgUsuario parametro2 = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)

            };



            List<dgUsuario> lista = c_usuario.LeerUsuario(2, parametro2);

            if (lista.Count > 0)

            {

                foreach (dgUsuario d in lista)
                {
                    retorno = Convert.ToString(d.Usuario.ToString());
                }


            }



            dgUsuario parametro3 = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)

            };



            List<dgUsuario> lista2 = c_usuario.LeerUsuario(3, parametro3);

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
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
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

         

            if (bx_categorias.Text == "" && bx_medidas.Text == "" && bx_proveedores.Text == "" && txt_nombre_producto.Text=="")
            {
                MessageBox.Show("Seleccione al menos un filtro para poder filtrar");
            }

          

            else
            {
                dataGridView_productos.Rows.Clear();
                dataGridView_productos_inactivos.Rows.Clear();

               
                string idCategoria="",IdMedida="",IdProveedor="",Nombre="0";
                int IDCategoria = 0, IDMedida = 0, IDProveedor = 0;


                string concatenacion = bx_categorias.Text;
                string[] words = concatenacion.Split(' ');
                idCategoria = words[0];


                concatenacion = bx_medidas.Text;
                string[] words2 = concatenacion.Split(' ');
                IdMedida = words2[0];

               

                concatenacion = bx_proveedores.Text;
                string[] words3 = concatenacion.Split(' ');
                IdProveedor = words3[0];


                if (idCategoria!="")
                {
                    IDCategoria = Convert.ToInt16(idCategoria);
                }

                if (IdMedida != "")
                {
                    IDMedida = Convert.ToInt16(IdMedida);
                }

                if (IdProveedor != "")
                {
                    IDProveedor = Convert.ToInt16(IdProveedor);
                }

                if (txt_nombre_producto.Text != "")
                {
                    Nombre = txt_nombre_producto.Text.Trim();
                }


               
                

               


                dgProducto parametrofiltrado = new dgProducto
                {
                    Id_Categoria = IDCategoria,
                    Id_Medida = IDMedida,
                    Id_Proveedor = IDProveedor,
                    Nombre = Nombre

                };

                List<dgProducto> listafiltrado = c_producto.LeerProducto(6, parametrofiltrado);

                if (listafiltrado.Count > 0)

                {
                   
                

                    int idproducto, idcategoria, idmedida, stock;
                    string nombre, categoriadescripcion, medidadescripcion;

                    foreach (dgProducto d in listafiltrado)
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

                            dataGridView_productos.Rows.Add(idproducto, nombre, categoriadescripcion, medidadescripcion, stock);

                           
                        }


                    }


                }

                else
                {
                    MessageBox.Show("No se encontraron resultados Activos");
                }



                dgProducto parametrofiltradoinactivos = new dgProducto
                {
                    Id_Categoria = IDCategoria,
                    Id_Medida = IDMedida,
                    Id_Proveedor = IDProveedor,
                    Nombre = Nombre

                };

                List<dgProducto> listafiltradoinactivos = c_producto.LeerProducto(9, parametrofiltradoinactivos);

                if (listafiltradoinactivos.Count > 0)

                {
                   

                  

                    int idproducto, idcategoria, idmedida, stock;
                    string nombre, categoriadescripcion, medidadescripcion;

                    foreach (dgProducto d in listafiltradoinactivos)
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

                           dataGridView_productos_inactivos.Rows.Add(idproducto, nombre, categoriadescripcion, medidadescripcion, stock);


                        }


                    }


                }

                else
                {
                    MessageBox.Show("No se encontraron resultados Inactivos");
                }




            }
            



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

        private void btn_reiniciar_filtrado_Click(object sender, EventArgs e)
        {
            bx_categorias.Items.Clear();
            bx_medidas.Items.Clear();
            bx_proveedores.Items.Clear();
            txt_nombre_producto.Text = "";
            dataGridView_productos.Rows.Clear();
            dataGridView_productos_inactivos.Rows.Clear();

            dgProducto parametro = new dgProducto();

            List<dgProducto> lista = c_producto.LeerProducto(4, parametro);


            if (lista.Count > 0)

            {
                int idproducto, idcategoria, idmedida, stock;
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

                        dataGridView_productos.Rows.Add(idproducto, nombre, categoriadescripcion, medidadescripcion, stock);
                    }


                }

            }





            dgProducto parametroinactivo = new dgProducto();

            List<dgProducto> listainactivo = c_producto.LeerProducto(10, parametroinactivo);


            if (listainactivo.Count > 0)

            {
                int idproducto, idcategoria, idmedida, stock;
                string nombre, categoriadescripcion, medidadescripcion;
                foreach (dgProducto d in listainactivo)
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

                        dataGridView_productos_inactivos.Rows.Add(idproducto, nombre, categoriadescripcion, medidadescripcion, stock);
                    }


                }

            }


            
            string concatenacion = "";
            dgMedida parametro2_1 = new dgMedida();

            List<dgMedida> lista2 = c_medida.LeerMedida(1, parametro2_1);

            if (lista2.Count > 0)

            {

                concatenacion = "";
                foreach (dgMedida d in lista2)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Medida.ToString() + " " + d.Descripcion.ToString();

                    bx_medidas.Items.Add(concatenacion);
                }



            }


            dgCategoria parametro3_1 = new dgCategoria
            {

            };

            List<dgCategoria> listac = c_categoria.LeerCategoria(1, parametro3_1);


            if (listac.Count > 0)

            {

                concatenacion = "";
                foreach (dgCategoria d in listac)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Categoria.ToString() + " " + d.Descripcion.ToString();
                    bx_categorias.Items.Add(concatenacion);

                }

            }

            dgProveedor parametro61 = new dgProveedor();

            List<dgProveedor> listap = c_proveedor.LeerProveedor(1, parametro61);


            if (lista.Count > 0)

            {

                concatenacion = "";
                foreach (dgProveedor d in listap)
                {
                    concatenacion = "";
                    concatenacion = d.Id_Proveedor.ToString() + " " + d.Nombre.ToString();

                    bx_proveedores.Items.Add(concatenacion);
                }

            }
        }

        private void dataGridView_productos_inactivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idProducto = dataGridView_productos_inactivos.CurrentRow.Cells["Col_IdProducto_Inactivo"].Value.ToString();

            this.Hide();
            modificar_eliminar_producto forms = new modificar_eliminar_producto();
            forms.lbl_id.Text = lbl_id.Text;
            forms.lblidproducto.Text = idProducto;
            forms.Show();
        }
    }
}
