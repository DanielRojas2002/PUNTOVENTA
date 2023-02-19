using Punto_de_Venta;
using Punto_de_Venta.Clases;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.VENTA.PRODUCTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.MENU.VENTA
{
    public partial class menu_venta : Form
    {
        public menu_venta()
        {
            InitializeComponent();


        }

        public int _num_venta;
        

        private void flowLayoutPanel_productos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_venta_Load(object sender, EventArgs e)
        {
            _num_venta = NumeroVenta();
            CargaProductos();
           
        }

        private void CargaSubTotal(int total)
        {
            lbl_total.Text = Convert.ToString(total);
        }

        private void CargaProductosOrden()
        {


            dgVentaDetalle parametro = new dgVentaDetalle
            {
                Id_Venta = _num_venta
            };

            List<dgVentaDetalle> listaorden = c_ventadetalle.LeerVentaDetalle(2, parametro);

            int contadorproductos = 0;

            if (listaorden.Count > 0)

            {
                flowLayoutPanel_Orden.Controls.Clear();
                int idproducto, stock, precioventa,subtotal,total=0;
                string nombre;
                foreach (dgVentaDetalle d in listaorden)
                {
                    idproducto = Convert.ToInt16(d.Id_Producto.ToString());

                    stock = Convert.ToInt16(d.CantidadAComprar.ToString());

                    precioventa = Convert.ToInt16(d.PrecioVenta.ToString());






                    UserControlOrdenCompra[] Productos = new UserControlOrdenCompra[10];


                    contadorproductos = contadorproductos + 1;

                    Productos[contadorproductos] = new UserControlOrdenCompra();

                    Productos[contadorproductos].IdProducto = Convert.ToString(idproducto);



                    Productos[contadorproductos].StockProductoComprar = Convert.ToString(stock);

                    Productos[contadorproductos].PrecioProducto = Convert.ToString(precioventa);

                    subtotal = precioventa * stock;

                    total = total + subtotal;

                    Productos[contadorproductos].SubTotal = Convert.ToString(subtotal);

                    flowLayoutPanel_Orden.Controls.Add(Productos[contadorproductos]);



                }

                CargaSubTotal(total);

            }














        }

        public static int NumeroVenta()
        {
            dgVentaDetalle parametronumeroventa = new dgVentaDetalle();

            List<dgVentaDetalle> listanumeroorden = c_ventadetalle.LeerVentaDetalle(1, parametronumeroventa);

            int numeroventa = 1;
            if (listanumeroorden.Count > 0)
            {
                foreach (dgVentaDetalle d in listanumeroorden)
                {
                    numeroventa = Convert.ToInt16(d.Id_Venta);
                }

            }

            return numeroventa;
        }

        private void menu_venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CargaProductos()
        {


            dgProducto parametro = new dgProducto();

            List<dgProducto> lista = c_producto.LeerProducto(7, parametro);

            int contadorproductos = 0;

            if (lista.Count > 0)

            {
                int idproducto, idcategoria, idmedida, stock,precioventa;
                string nombre, categoriadescripcion, medidadescripcion, descripcion;
                foreach (dgProducto d in lista)
                {
                    idproducto = Convert.ToInt16(d.Id_Producto.ToString());
                    idcategoria = Convert.ToInt16(d.Id_Categoria.ToString());
                    idmedida = Convert.ToInt16(d.Id_Medida.ToString());
                    stock = Convert.ToInt16(d.StockInicial.ToString());
                    descripcion = Convert.ToString(d.Descripcion.ToString());
                    precioventa = Convert.ToInt16(d.PrecioVenta.ToString());
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

                        UserControlProducto[] Productos = new UserControlProducto[10];


                        contadorproductos = contadorproductos + 1;

                        Productos[contadorproductos] = new UserControlProducto();

                        Productos[contadorproductos].IdProducto = Convert.ToString(idproducto);

                        Productos[contadorproductos].NombreProducto = nombre;

                        Productos[contadorproductos].StockProducto = Convert.ToString(stock);

                        Productos[contadorproductos].DescripcionProducto = descripcion;

                        Productos[contadorproductos].NumVenta = Convert.ToString(_num_venta);

                        Productos[contadorproductos].PrecioProducto = Convert.ToString(precioventa);

                        Productos[contadorproductos].CategoriaProducto = categoriadescripcion;

                        Productos[contadorproductos].MedidaProducto = medidadescripcion;



                        flowLayoutPanel_productos.Controls.Add(Productos[contadorproductos]);



                    }


                }

            }


            bx_categorias.Items.Clear();
            dgCategoria parametro2_1 = new dgCategoria
            {

            };

            List<dgCategoria> listacategorias = c_categoria.LeerCategoria(1, parametro2_1);

            if (listacategorias.Count > 0)

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










        }


        private void CargaProductosFiltrado(string? nombreproducto,int? idcategoria,int? idmedida)
        {
            dgProducto parametrofiltrado = new dgProducto
            {
                Nombre=nombreproducto,
                Id_Categoria = idcategoria,
                Id_Medida=idmedida
            };

            List<dgProducto> listafiltrado = c_producto.LeerProducto(8, parametrofiltrado);


            int contadorproductos = 0;

            if (listafiltrado.Count > 0)

            {
                flowLayoutPanel_productos.Controls.Clear();
                int idproducto, idcategoriaa, idmedidaa, stock, precioventa;
                string nombre, categoriadescripcion, medidadescripcion, descripcion;
                foreach (dgProducto d in listafiltrado)
                {
                    idproducto = Convert.ToInt16(d.Id_Producto.ToString());
                    idcategoriaa = Convert.ToInt16(d.Id_Categoria.ToString());
                    idmedidaa = Convert.ToInt16(d.Id_Medida.ToString());
                    stock = Convert.ToInt16(d.StockInicial.ToString());
                    descripcion = Convert.ToString(d.Descripcion.ToString());
                    precioventa = Convert.ToInt16(d.PrecioVenta.ToString());
                    nombre = Convert.ToString(d.Nombre.ToString());

                    dgCategoria parametro2 = new dgCategoria
                    {
                        Id_Categoria = Convert.ToInt16(idcategoriaa.ToString())
                    };

                    List<dgCategoria> listacategoria = c_categoria.LeerCategoria(3, parametro2);


                    dgMedida parametro3 = new dgMedida
                    {
                        Id_Medida = Convert.ToInt16(idmedidaa.ToString())
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

                        UserControlProducto[] Productos = new UserControlProducto[10];


                        contadorproductos = contadorproductos + 1;

                        Productos[contadorproductos] = new UserControlProducto();

                        Productos[contadorproductos].IdProducto = Convert.ToString(idproducto);

                        Productos[contadorproductos].NombreProducto = nombre;

                        Productos[contadorproductos].StockProducto = Convert.ToString(stock);

                        Productos[contadorproductos].DescripcionProducto = descripcion;

                        Productos[contadorproductos].NumVenta = Convert.ToString(_num_venta);

                        Productos[contadorproductos].PrecioProducto = Convert.ToString(precioventa);

                        Productos[contadorproductos].CategoriaProducto = categoriadescripcion;

                        Productos[contadorproductos].MedidaProducto = medidadescripcion;



                        flowLayoutPanel_productos.Controls.Add(Productos[contadorproductos]);



                    }


                }

            }


            else
            {
                MessageBox.Show("No se encontraron resultados");
            }










        }
        private void bx_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_aplicar_filtro_Click(object sender, EventArgs e)
        {
            int idCategoria = 0, idMedida = 0;
            string nombreproducto="0";

            if (bx_categorias.Text == "" && bx_medidas.Text == "" && txt_nombre_producto.Text == "")
            {
                MessageBox.Show("Seleccione al menos un filtro para poder filtrar");
            }



            else
            {
                nombreproducto = txt_nombre_producto.Text;
                dgCategoria parametro2_1 = new dgCategoria
                {
                    Descripcion = Convert.ToString(bx_categorias.Text)
                };

                List<dgCategoria> listacategorias = c_categoria.LeerCategoria(2, parametro2_1);

                if (listacategorias.Count > 0)

                {

                    foreach (dgCategoria d in listacategorias)
                    {
                        idCategoria = Convert.ToInt16(d.Id_Categoria.ToString());
                    }

                }


                dgMedida parametro2_2 = new dgMedida
                {
                    Descripcion = Convert.ToString(bx_medidas.Text)
                };

                List<dgMedida> listamedidas = c_medida.LeerMedida(2, parametro2_2);

                if (listamedidas.Count > 0)

                {

                    foreach (dgMedida d in listamedidas)
                    {
                        idMedida = Convert.ToInt16(d.Id_Medida.ToString());
                    }

                }



                



                dgProducto parametrofiltrado = new dgProducto
                {
                    Nombre=nombreproducto,
                    Id_Categoria = idCategoria,
                    Id_Medida = idMedida,
                   
                };

                CargaProductosFiltrado(nombreproducto, idCategoria, idMedida);




            }
        }

        private void btn_reiniciar_filtrado_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_productos.Controls.Clear();

            CargaProductos();

            

            txt_nombre_producto.Text = "";

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

        private void btn_reinciar_orden_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_venta_Activated(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel_Orden_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_venta_MouseMove(object sender, MouseEventArgs e)
        {
            CargaProductosOrden();
        }

        private void flowLayoutPanel_Orden_Enter(object sender, EventArgs e)
        {

        }
    }
}
