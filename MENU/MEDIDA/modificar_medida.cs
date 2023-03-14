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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PUNTOVENTA.MENU.MEDIDA
{
    public partial class modificar_medida : Form
    {
        public modificar_medida()
        {
            InitializeComponent();

           
          
        }

        private void modificar_medida_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_modificar_medida_Click(object sender, EventArgs e)
        {
            try
            {
               

                string valor = bx_medida.SelectedItem.ToString();

                if (valor==null)
                {
                    MessageBox.Show("Selecione una Medida a Modificar ");
                   
                }

                else if ( txt_descripcion.Text == "")
                {
                    MessageBox.Show(" Ingrese la Descripcion a Modificar");
                   
                }

                else
                {
                    
                    dgMedida parametro = new dgMedida
                    {
                        Id_Medida = Convert.ToInt16(lbl_id_medida.Text),

                        Descripcion = Convert.ToString(txt_descripcion.Text.Trim().ToUpper())
                    };

                    string control = "";

                    control = c_medida.ModificarMedida(parametro);

                    if (control == "1")
                    {

                        MessageBox.Show("No se puede modificar esta Medida", "Error");
                    }

                    else
                    {
                        MessageBox.Show("Medida Modificada", "Correcto");

                        RegresarVentana();
                    }






                }
            }
            catch
            {
                MessageBox.Show("Seleccione una Medida", "Error");
            }
        }

        private void bx_medida_SelectedIndexChanged(object sender, EventArgs e)
        {
            string concatenacion = bx_medida.Text;
            string[] words = concatenacion.Split(' ');
            string idmedida,descripcion;
            idmedida = words[0];

            descripcion = words[1];


            lbl_id_medida.Text = idmedida;

            txt_descripcion.Text = descripcion;
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

        private void modificar_medida_Load(object sender, EventArgs e)
        {

            dgMedida parametro = new dgMedida();

            List<dgMedida> lista = c_medida.LeerMedida(1, parametro);

            if (lista.Count > 0)

            {

                string concatenacion = "";
                foreach (dgMedida d in lista)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Medida.ToString() + " " + d.Descripcion.ToString();

                    bx_medida.Items.Add(concatenacion);
                }
            }

        }

        private void modificar_medida_Activated(object sender, EventArgs e)
        {
           

           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bx_medida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_descripcion.Focus();
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                panel_modificarmedida.Focus();
        }
    }
}
