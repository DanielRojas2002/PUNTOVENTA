using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;

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
            string usuario, tabla;


            if (bx_usuario.Text == "")
            {

                MessageBox.Show("Seleccione el usuario a eliminar ");
            }


            else
            {
                usuario = bx_usuario.Text;
                tabla = "USUARIO";

                List<string> listacampos = new List<string>();
                List<string> listatipodato = new List<string>();
                List<string> listavalores = new List<string>();

                listacampos.Add("Usuario");


                listatipodato.Add("string");

                listavalores.Add(usuario);



                c_crud log2 = new c_crud();
                log2.Delete(tabla, listacampos, listavalores, listatipodato);
                MessageBox.Show("Usuario Eliminado", "Correcto");


                string id;
                id = lbl_id.Text;
                string retorno1, retorno2;
                c_seguridad log = new c_seguridad();
                retorno1 = log.ChecarUsuario(id);
                txt_usuario.Text = "";

                c_seguridad log3 = new c_seguridad();
                retorno2 = log3.ChecarPerfil(id);
                lbl_perfil.Text = "";

                this.Hide();
                menu_seguridad formulario = new menu_seguridad();
                formulario.lbl_id.Text = id;
                formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                formulario.txt_usuario.Text = Convert.ToString(retorno1);
                formulario.Show();

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
                MessageBox.Show("No tiene Usuarios Agregadas", "Advertencia");
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
