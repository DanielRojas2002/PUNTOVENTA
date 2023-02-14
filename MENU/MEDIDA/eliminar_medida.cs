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
    public partial class eliminar_medida : Form
    {
        public eliminar_medida()
        {
            InitializeComponent();
        }

        private void eliminar_medida_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_eliminar_medida_Click(object sender, EventArgs e)
        {
            try
            {
                if (bx_medidas.Text == "" && lbl_id_medida.Text == "")
                {

                    MessageBox.Show("Seleccione la Medida a eliminar ");
                }


                else
                {
                    dgMedida parametro = new dgMedida();

                    parametro.Id_Medida = Convert.ToInt16(lbl_id_medida.Text);




                    string control = "";

                    control = c_medida.EliminarMedida(parametro);

                    if (control == "1")
                    {

                        MessageBox.Show("No se puede eliminar esta Medida", "Error");
                    }

                    else
                    {
                        MessageBox.Show("Medida Eliminada", "Correcto");

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
            catch
            {
                MessageBox.Show("Seleccione una Medida", "Error");
            }
        }

        private void bx_medidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            string descripcion;
            descripcion = bx_medidas.Text;

            dgMedida parametro = new dgMedida();

            parametro.Descripcion = descripcion;

            List<dgMedida> lista = c_medida.LeerMedida(2, parametro);

            if (lista.Count > 0)

            {

                foreach (dgMedida d in lista)
                {
                    lbl_id_medida.Text = d.Id_Medida.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Medidas Agregadas", "Advertencia");
            }
        }

        private void eliminar_medida_Activated(object sender, EventArgs e)
        {
            bx_medidas.Items.Clear();
            dgMedida parametro = new dgMedida();

            parametro.Descripcion = "no";

            List<dgMedida> lista = c_medida.LeerMedida(1, parametro);

            if (lista.Count > 0)

            {

                foreach (dgMedida d in lista)
                {
                    bx_medidas.Items.Add(d.Descripcion.ToString());
                }





            }
        }

        private void eliminar_medida_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
