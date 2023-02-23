using Punto_de_Venta;
using Punto_de_Venta.Clases;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.MENU.PRODUCTO
{
    public partial class agregar_stock : Form
    {
        public agregar_stock()
        {
            InitializeComponent();
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
            
            modificar_eliminar_producto formulario = new modificar_eliminar_producto();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.lblidproducto.Text = lblidproducto.Text;
            formulario.Show();



        }
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
        }

        private void btn_agregar_stock_Click(object sender, EventArgs e)
        {

            if (txt_stock_a_agregar.Text == "")
            {

                MessageBox.Show("Ingrese el Stock a Agregar del Producto ");
            }

            else
            {
                try
                {
                    dgEntrada parametro = new dgEntrada
                    {
                        IdProducto = Convert.ToInt16(lblidproducto.Text),
                        Id_Usuario = Convert.ToInt16(lbl_id.Text),
                        Stock = Convert.ToInt16(txt_stock_a_agregar.Text),
                        FechaEntrada = DateTime.Now

                    };




                    string control = "";

                    control = c_entrada.InsertarEntrada(parametro);


                    MessageBox.Show("Stock Agregado al Producto", "Correcto");
                    RegresarVentana();
                }

                catch
                {
                   
                }
               
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregar_stock_Load(object sender, EventArgs e)
        {
            dgProducto parametro = new dgProducto
            {
                Id_Producto = Convert.ToInt16(lblidproducto.Text)
            };


            List<dgProducto> lista = c_producto.LeerProducto(5, parametro);

            if (lista.Count > 0)

            {

                foreach (dgProducto d in lista)
                {
                    lbl_stock_actual.Text = Convert.ToString(d.StockInicial.ToString());

                }

            }
        }
    }
}
