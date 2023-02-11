﻿using Punto_de_Venta;
using PUNTOVENTA.MENU.PRODUCTO;

namespace PUNTOVENTA.MENU.CATEGORIA
{
    public partial class agregar_categoria : Form
    {
        public agregar_categoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void agregar_categoria_Load(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_Click(object sender, EventArgs e)
        {

        }

        private void lbl_perfil_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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

        private void btn_crear_categoria_Click(object sender, EventArgs e)
        {

            string descripcion, tabla;


            if (txt_descripcion.Text == "")
            {

                MessageBox.Show("Ingrese la Descripcion de la Categoria ha agregar ");
            }

            else
            {
                descripcion = txt_descripcion.Text;



                tabla = "CATEGORIA";

                List<string> listacampos = new List<string>();
                List<string> listatipodato = new List<string>();
                List<string> listavalores = new List<string>();

                listacampos.Add("Descripcion");

                listatipodato.Add("string");

                listavalores.Add(descripcion);


                try
                {
                    c_crud log = new c_crud();
                    log.Insert(tabla, listacampos, listavalores, listatipodato);
                    MessageBox.Show("Categoria Dado de alta", "Correcto");
                }
                catch
                {
                    MessageBox.Show("Error 203", "Incorrecto");
                }
                finally
                {
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

   

        private void agregar_categoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
