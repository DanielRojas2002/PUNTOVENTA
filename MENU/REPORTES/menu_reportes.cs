using Punto_de_Venta;
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

namespace PUNTOVENTA.MENU.REPORTES
{
    public partial class menu_reportes : Form
    {
        public menu_reportes()
        {
            InitializeComponent();
        }

        private void btn_r_ventas_Click(object sender, EventArgs e)
        {
            this.Hide();
            reporte_venta forms = new reporte_venta();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_r_compras_Click(object sender, EventArgs e)
        {
            this.Hide();
            reporte_compras forms = new reporte_compras();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_r_clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            reporte_cliente forms = new reporte_cliente();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_r_devoluciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            reporte_devoluciones forms = new reporte_devoluciones();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menu_reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_r_caja_Click(object sender, EventArgs e)
        {
            this.Hide();
            reporte_caja forms = new reporte_caja();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void menu_reportes_Load(object sender, EventArgs e)
        {

        }

        private void btn_r_numventa_Click(object sender, EventArgs e)
        {
            this.Hide();
            reporte_numventa forms = new reporte_numventa();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }
    }
}
