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
    public partial class UserControlOrdenCompra : UserControl
    {
        public UserControlOrdenCompra()
        {
            InitializeComponent();
        }


        private string _idproducto;
        private string _nombreproducto;
        private string _precioproducto;
        private string _stockacomprar;

        private string _subtotal;


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

        public string StockProductoComprar
        {
            get { return _stockacomprar; }
            set { _stockacomprar = value; lbl_stock_a_comprar.Text = value; }
        }

        public string SubTotal
        {
            get { return _subtotal; }
            set { _subtotal = value; lbl_subtotal.Text = value; }
        }





        private void btn_quitar_producto_Click(object sender, EventArgs e)
        {

        }

        private void UserControlOrdenCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
