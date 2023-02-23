﻿using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PRODUCTO;

namespace PUNTOVENTA.MENU.CATEGORIA
{
    public partial class modificar_categoria : Form
    {
        public modificar_categoria()
        {
            InitializeComponent();


            dgCategoria parametro = new dgCategoria
            {
                Descripcion = "no"
            };

            List<dgCategoria> lista = c_categoria.LeerCategoria(1, parametro);

            if (lista.Count > 0)

            {

                foreach (dgCategoria d in lista)
                {
                    bx_categorias.Items.Add(d.Descripcion.ToString());
                }





            }
        }

        private void btn_modificar_categoria_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = bx_categorias.SelectedItem.ToString();

                if (valor == null)
                {
                    MessageBox.Show("Selecione una Categoria a Modificar ");

                }

                else if (txt_descripcion.Text == "")
                {
                    MessageBox.Show(" Ingrese la Descripcion a Modificar");

                }

                else
                {
                    dgCategoria parametro = new dgCategoria
                    {
                        Id_Categoria = Convert.ToInt16(lbl_id_categoria.Text),

                        Descripcion = Convert.ToString(txt_descripcion.Text.Trim().ToUpper())
                    };



                    string control = "";

                    control = c_categoria.ModificarCategoria(parametro);

                    if (control == "1")
                    {

                        MessageBox.Show("No se puede modificar esta Categoria", "Error");
                    }

                    else
                    {
                        MessageBox.Show("Categoria Modificada", "Correcto");

                        RegresarVentana();
                    }






                }
            }
            catch
            {
                MessageBox.Show("Seleccione una Categoria", "Error");
            }

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void bx_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            string descripcion;
            descripcion = bx_categorias.Text;


            dgCategoria parametro = new dgCategoria
            {
                Descripcion = descripcion
            };

            List<dgCategoria> lista = c_categoria.LeerCategoria(2, parametro);

            if (lista.Count > 0)

            {

                foreach (dgCategoria d in lista)
                {
                    lbl_id_categoria.Text = d.Id_Categoria.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Categorias Agregadas", "Advertencia");
            }

            dgCategoria parametro2 = new dgCategoria
            {
                Id_Categoria = Convert.ToInt16(lbl_id_categoria.Text)
            };

            List<dgCategoria> listadesc = c_categoria.LeerCategoria(3, parametro2);

            if (listadesc.Count > 0)

            {

                foreach (dgCategoria dg in listadesc)
                {
                    txt_descripcion.Text = dg.Descripcion.ToString();
                }
            }

          
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
            menu_producto formulario = new menu_producto();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();





        }
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
        }

        private void modificar_categoria_Activated(object sender, EventArgs e)
        {
            

           
        }

        private void modificar_categoria_Load(object sender, EventArgs e)
        {

        }

      

        private void modificar_categoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
