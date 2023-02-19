using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
