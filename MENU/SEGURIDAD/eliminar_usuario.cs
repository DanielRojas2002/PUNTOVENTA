using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PRODUCTO;

namespace Punto_de_Venta
{
    public partial class eliminar_usuario : Form
    {
        public eliminar_usuario()
        {
            InitializeComponent();

           

        }

        private void btn_eliminar_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (bx_usuario.Text == "" && lbl_perfil.Text == "")
                {

                    MessageBox.Show("Seleccione el Usuario a eliminar ");
                }


                else
                {
                    dgUsuario parametro = new dgUsuario();

                    parametro.Id_Usuario = Convert.ToInt16(bl_id_combobox.Text);




                    string control = "";

                    control = c_usuario.EliminarUsuario(parametro);

                    if (control == "1")
                    {

                        MessageBox.Show("No se puede eliminar esta Usuario", "Error");
                    }

                    else
                    {
                        MessageBox.Show("Usuario Eliminado", "Correcto");

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
                        menu_seguridad formulario = new menu_seguridad();
                        formulario.lbl_id.Text = id;
                        formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                        formulario.txt_usuario.Text = Convert.ToString(retorno);
                        formulario.Show();
                    }






                }
            }
            catch
            {
                MessageBox.Show("Seleccione una Usuario a Eliminar", "Error");
            }


        }

        private void bx_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int id;
            string descripcion;
            descripcion = bx_usuario.Text;



            // acceder al valor del combobox 


         

            descripcioncb.Text = bx_usuario.Text;


            dgUsuario parametro2 = new dgUsuario
            {
                Usuario = Convert.ToString(descripcioncb.Text)
            };

            List<dgUsuario> lista2 = c_usuario.LeerUsuario(5, parametro2);

            if (lista2.Count > 0)

            {

                foreach (dgUsuario d in lista2)
                {
                    bl_id_combobox.Text = d.Id_Usuario.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Medidas Agregadas", "Advertencia");
            }






            dgUsuario parametro3 = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(bl_id_combobox.Text)
            };

            List<dgUsuario> lista3 = c_usuario.LeerUsuario(3, parametro3);

            if (lista3.Count > 0)

            {

                foreach (dgUsuario d in lista3)
                {
                    lblperfil.Text = d.DescripcionPerfil.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Medidas Agregadas", "Advertencia");
            }



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

            }

            this.Hide();
            menu_seguridad formulario = new menu_seguridad();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();
        }

        private void eliminar_usuario_Activated(object sender, EventArgs e)
        {

            bx_usuario.Items.Clear();
            int id;
            string descripcion;
            descripcion = bx_usuario.Text;

            dgUsuario parametro = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)


            };

            List<dgUsuario> lista = c_usuario.LeerUsuario(4, parametro);

            if (lista.Count > 0)

            {

                foreach (dgUsuario d in lista)
                {

                    bx_usuario.Items.Add(d.Usuario);



                }
            }

            else

            {
                
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
      

        private void eliminar_usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bl_id_combobox_Click(object sender, EventArgs e)
        {

        }

        private void descripcioncb_Click(object sender, EventArgs e)
        {

        }
    }
}
