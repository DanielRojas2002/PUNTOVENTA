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




                        txt_usuario.Text = ("Bievenido usuario: " + retorno);


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


                        lbl_perfil.Text = ("Perfil: " + retorno2);


                    }
                    this.Hide();
                    menu_producto formulario = new menu_producto();
                    formulario.lbl_id.Text = id;
                    formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                    formulario.txt_usuario.Text = Convert.ToString(retorno);
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




                txt_usuario.Text = ("Bievenido usuario: " + retorno);


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


                lbl_perfil.Text = ("Perfil: " + retorno2);


            }


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
