using Punto_de_Venta.Clases;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.MENU.VENTA.PRODUCTO
{
    public partial class UserControlProducto : UserControl
    {
        public UserControlProducto()
        {
            InitializeComponent();
        }


        private string _idproducto;
        private string _nombreproducto;
        private string _precioproducto;
        private string _descripcionproducto;
        private string _categoriaproducto;
        private string _medidaproducto;
        private string _stockdisponible;

        private string _numventa;
        public int _validacion = 0;



        public string IdProducto
        {
            get { return _idproducto; }
            set { _idproducto = value; lbl_id_producto.Text = value; }
        }
        public string NombreProducto
        {
            get { return _nombreproducto; }
            set { _nombreproducto = value; lbl_nombreproducto.Text = value; }
        }

        public string NumVenta
        {
            get { return _numventa; }
            set { _numventa = value; lbl_numventa.Text = value; }
        }

        public string PrecioProducto
        {
            get { return _precioproducto; }
            set { _precioproducto = value; lbl_precio_producto.Text = value; }
        }

        public string DescripcionProducto
        {
            get { return _descripcionproducto; }
            set { _descripcionproducto = value; txt_descripcion_producto.Text = value; }
        }

        public string StockProducto
        {
            get { return _stockdisponible; }
            set { _stockdisponible = value; lbl_stock_disponible.Text = value; }
        }

        public string CategoriaProducto
        {
            get { return _categoriaproducto; }
            set { _categoriaproducto = value; lbl_categoria_producto.Text = value; }
        }

        public string MedidaProducto
        {
            get { return _medidaproducto; }
            set { _medidaproducto = value; lbl_medida_producto.Text = value; }
        }

        private void UserControlProducto_Load(object sender, EventArgs e)
        {
            
          
            
        }

       
        

        private void InsertarProductos(int numeroventa)
        {




            dgVentaDetalle parametroinsertar = new dgVentaDetalle
            {
                Id_Venta = numeroventa,
                Id_Producto = Convert.ToInt16(lbl_id_producto.Text),


                PrecioVenta = Convert.ToInt16(lbl_precio_producto.Text),

                CantidadAComprar = Convert.ToInt16(txt_cantidad_a_agregar.Value.ToString()),

                Validacion = _validacion
            };



            string control = "";

            control = c_ventadetalle.InsertarVentaDetalle(parametroinsertar);

            _validacion = _validacion + 1;

        }

       
        private void btn_ordenar_Click(object sender, EventArgs e)
        {
            int cantidadaordenar = 0,stock=0;

            string idproducto = "";

            idproducto = lbl_id_producto.Text;

            cantidadaordenar = Convert.ToInt16(txt_cantidad_a_agregar.Value);

            stock = Convert.ToInt16(lbl_stock_disponible.Text);

            if (cantidadaordenar == 0)
            {
                MessageBox.Show("Ingrese la Cantidad a Vender");
            }
            else
            {
                if (cantidadaordenar > stock)
                {
                    MessageBox.Show("No tiene suficiente stock");
                }

                else
                {
                    int numventa;
                    numventa = Convert.ToInt16(_numventa);
                    InsertarProductos(numventa);


                }
            }
            

           

            
          
        }

        private void lbl_numventa_Click(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_a_agregar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
