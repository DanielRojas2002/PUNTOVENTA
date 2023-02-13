using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;

namespace Punto_de_Venta
{
    public partial class seguridad : Form
    {
        public seguridad()
        {
            InitializeComponent();

            dgPerfil parametro = new dgPerfil();

        

            List<dgPerfil> lista = c_perfil.LeerPerfil(1, parametro);

            if (lista.Count > 0)

            {

                foreach (dgPerfil d in lista)
                {
                    bx_permisos.Items.Add(d.Descripcion.ToString());
                }





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

        private void seguridad_Activated(object sender, EventArgs e)
        {

        }

        private void btn_crear_usuario_Click(object sender, EventArgs e)
        {
            string perfil;


            if (txt_usuarioo.Text == "")
            {

                MessageBox.Show("Ingrese el Usuario ha agregar ");
            }
            else if (txt_contraseña.Text == "")
            {

                MessageBox.Show("Ingrese la Contraseña ha agregar");

            }
            else if (bx_permisos.Text == "")
            {

                MessageBox.Show("Ingrese el perfil ");
            }


            else
            {
               
                perfil = bx_permisos.Text;

                if (perfil == "Administrador")
                {
                    perfil = "1";
                }
                else if (perfil == "Vendedor")
                {
                    perfil = "2";
                }


                dgUsuario parametro = new dgUsuario
                {
                    Usuario = txt_usuarioo.Text.Trim(),
                    Contrasenia = txt_contraseña.Text.Trim(),
                    Id_Perfil = Convert.ToInt16(perfil)
                };



                string control = "";

                control = c_usuario.InsertarUsuario(parametro);

                if (control == "1")
                {

                    MessageBox.Show("Ya Existe un Usuario Similar", "Error");
                }

                else
                {
                    MessageBox.Show("Usuario Dado de alta", "Correcto");

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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.UseSystemPasswordChar == true)
            {
                txt_contraseña.UseSystemPasswordChar = false;
            }

            else
            {
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void seguridad_Load(object sender, EventArgs e)
        {

        }

    

        private void seguridad_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bx_permisos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
