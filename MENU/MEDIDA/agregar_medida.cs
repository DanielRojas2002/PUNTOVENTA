using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PRODUCTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.MENU.MEDIDA
{
    public partial class agregar_medida : Form
    {
        public agregar_medida()
        {
            InitializeComponent();
        }

        private void btn_crear_medida_Click(object sender, EventArgs e)
        {

            if (txt_descripcion.Text == "")
            {

                MessageBox.Show("Ingrese la Descripcion de la Medida ha agregar ");
            }

            else
            {
                dgMedida parametro = new dgMedida
                {
                    Descripcion = txt_descripcion.Text.Trim().ToUpper()
                };



                string control = "";

                control = c_medida.InsertarMedida(parametro);

                if (control == "1")
                {

                    MessageBox.Show("Ya Existe una Medida Similar", "Error");
                }

                else
                {
                    MessageBox.Show("Medida Dado de alta", "Correcto");
                    string id;
                    id = lbl_id.Text;
                    string retorno1, retorno2;
                    c_seguridad log = new c_seguridad();
                    retorno1 = log.ChecarUsuario(id);
                    txt_usuario.Text = "";

                    c_seguridad log2 = new c_seguridad();
                    retorno2 = log2.ChecarPerfil(id);
                    lbl_perfil.Text = "";

                    this.Hide();
                    menu_producto formulario = new menu_producto();
                    formulario.lbl_id.Text = id;
                    formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                    formulario.txt_usuario.Text = Convert.ToString(retorno1);
                    formulario.Show();
                }

            }

        }

        private void agregar_medida_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            string id;
            id = lbl_id.Text;
            string retorno, retorno2;
            c_seguridad log = new c_seguridad();
            retorno = log.ChecarUsuario(id);
            txt_usuario.Text = "";

            c_seguridad log2 = new c_seguridad();
            retorno2 = log2.ChecarPerfil(id);
            lbl_perfil.Text = "";

            this.Hide();
            menu_producto formulario = new menu_producto();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();
        }

        private void agregar_medida_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
