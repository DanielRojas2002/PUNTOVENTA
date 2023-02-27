using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.CLIENTE.CREDITO;
using PUNTOVENTA.MENU.PROVEEDOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.MENU.CLIENTE
{
    public partial class menu_cliente : Form
    {
        public menu_cliente()
        {
            InitializeComponent();
        }

        private void btn_agregarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregar_cliente forms = new agregar_cliente();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

       

        private void btn_modificar_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            modificar_cliente forms = new modificar_cliente();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_eliminar_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            eliminar_cliente forms = new eliminar_cliente();
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

        private void menu_cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_usuario_Click(object sender, EventArgs e)
        {

        }

        private void lbl_perfil_Click(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void btn_creditos_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_credito forms = new menu_credito();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }
    }
}
