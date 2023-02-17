using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;

namespace PUNTOVENTA.MENU.PROVEEDOR
{
    public partial class modificar_proveedor : Form
    {
        public modificar_proveedor()
        {
            InitializeComponent();
        }

        private void modificar_proveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bx_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            string nombre;
            nombre = bx_proveedor.Text;


            dgProveedor parametro = new dgProveedor
            {
                Nombre = nombre
            };

            List<dgProveedor> lista = c_proveedor.LeerProveedor(6, parametro);

            if (lista.Count > 0)

            {

                foreach (dgProveedor d in lista)
                {
                    lbl_id_proveedor.Text = d.Id_Proveedor.ToString();
                }
            }

            else

            {
                MessageBox.Show("No tiene Categorias Agregadas", "Advertencia");
            }



            dgProveedor parametro2 = new dgProveedor
            {
                Id_Proveedor = Convert.ToInt16(lbl_id_proveedor.Text)
            };

            List<dgProveedor> listaproveedor = c_proveedor.LeerProveedor(7, parametro2);

            if (listaproveedor.Count > 0)

            {

                foreach (dgProveedor dg in listaproveedor)
                {

                    txt_nombre_proveedor.Text = Convert.ToString( dg.Nombre.ToString());
                    txt_correo_proveedor.Text = Convert.ToString(dg.Correo.ToString());
                    txt_telefono_proveedor.Text = Convert.ToString(dg.Telefono.ToString());
                }
            }
        }







        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      









       

        private void modificar_proveedor_Load(object sender, EventArgs e)
        {

            dgProveedor parametro = new dgProveedor();

          

            List<dgProveedor> lista = c_proveedor.LeerProveedor(1, parametro);

            if (lista.Count > 0)

            {

                foreach (dgProveedor d in lista)
                {
                    bx_proveedor.Items.Add(d.Nombre.ToString());
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
            menu_proveedor formulario = new menu_proveedor();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (txt_correo_proveedor.Text == "")
            {

                MessageBox.Show("Ingrese el correo del proveedor");
            }
            else if (txt_nombre_proveedor.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del proveedor ");
            }
            else if (txt_telefono_proveedor.Text == "")
            {
                MessageBox.Show("Ingrese el telefono del proveedor ");
            }

            else
            {
                dgProveedor parametro = new dgProveedor
                {
                    Id_Proveedor = Convert.ToInt16(lbl_id_proveedor.Text),
                    Correo = txt_correo_proveedor.Text.Trim(),
                    Nombre = txt_nombre_proveedor.Text.Trim().ToUpper(),
                    Telefono = txt_telefono_proveedor.Text.Trim(),
                    FechaModificacion = DateTime.Now

                };



                string control = "";

                control = c_proveedor.ModificarProveedor(parametro);

               

               
                MessageBox.Show("Proveedor Modificado exitosamente", "Correcto");
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


                    lbl_perfil.Text = ("Perfil: " + retorno2);


                }

                this.Hide();
                menu_proveedor formulario = new menu_proveedor();
                formulario.lbl_id.Text = id;
                formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                formulario.txt_usuario.Text = Convert.ToString(retorno);
                formulario.Show();

                

            }
        }

        private void txt_nombre_proveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_correo_proveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefono_proveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
