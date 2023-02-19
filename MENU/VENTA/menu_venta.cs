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

        private void flowLayoutPanel_productos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_venta_Load(object sender, EventArgs e)
        {
            CargaProductos();
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

                        Productos[contadorproductos].DescripcionProducto = descripcion;

                        Productos[contadorproductos].PrecioProducto = Convert.ToString(precioventa);

                        Productos[contadorproductos].CategoriaProducto = categoriadescripcion;

                        Productos[contadorproductos].MedidaProducto = medidadescripcion;



                        flowLayoutPanel_productos.Controls.Add(Productos[contadorproductos]);



                    }


                }

            }






           





            
        }
    }
}
