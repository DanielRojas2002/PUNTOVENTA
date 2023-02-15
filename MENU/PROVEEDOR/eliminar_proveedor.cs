using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PRODUCTO;

namespace PUNTOVENTA.MENU.PROVEEDOR
{
    public partial class eliminar_proveedor : Form
    {
        public eliminar_proveedor()
        {
            InitializeComponent();
        }

        private void eliminar_proveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txt_usuario_Click(object sender, EventArgs e)
        {

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
            Inicio formulario = new Inicio();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();
        }

        private void bx_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ver que nombre selecciono checar el id proveedor que coincida y poner el valor en 
            // la etiquela idproveedor

            string nombre = bx_proveedor.Text;

            dgProveedor parametro = new dgProveedor
            {
                Nombre = nombre
            };

            List<dgProveedor> lista = c_proveedor.LeerProveedor(3, parametro);

            if (lista.Count > 0)

            {

                foreach (dgProveedor d in lista)
                {

                    idProveedor.Text = Convert.ToString(d.Id_Proveedor.ToString());
                }
            }

            else

            {
                MessageBox.Show("No tiene Proveedores Agregados", "Verifique bien");
            }
        }







        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eliminar_proveedor_Load(object sender, EventArgs e)
        {
            // carga de combobox de proveedor


            // ver que nombre selecciono checar el id proveedor que coincida y poner el valor en 
            // la etiquela idproveedor
            int id;
            string Nombre;
            Nombre = bx_proveedor.Text;

            dgProveedor parametro = new dgProveedor
            {
                Nombre = Nombre
            };

            List<dgProveedor> lista = c_proveedor.LeerProveedor(2, parametro);

            if (lista.Count > 0)

            {

                foreach (dgProveedor d in lista)
                {
                    
                    bx_proveedor.Items.Add(d.Nombre.ToString());
                }
            }

            else

            {
                MessageBox.Show("No tiene Proveedores Agregados", "Verifique bien");
            }
        }









        private void btn_eliminar_proveedor_Click(object sender, EventArgs e)
        {
            // ver que id tienen la etiqueta idproveedor y usar la funcion para eliminarla
            // despues regresarte a la ventan de menu_proveedor
            try
            {
                if (bx_proveedor.Text == "" && idProveedor.Text == "")
                {

                    MessageBox.Show("Seleccione el Proveedor a eliminar ");
                }


                else
                {
                    dgProveedor parametro = new dgProveedor();

                    parametro.Id_Proveedor = Convert.ToInt16(idProveedor.Text);




                    string control = "";

                    control = c_proveedor.EliminarProveedor(parametro);

                    if (control == "1")
                    {

                        MessageBox.Show("No se puede eliminar este Proveedor ya que ya fue asignado a un producto", "Error");
                    }

                    else
                    {
                        MessageBox.Show("Proveedor Eliminado", "Correcto");

                        string id;
                        id = idProveedor.Text;

                        string retorno = "", retorno2 = "";

                        dgUsuario parametro2 = new dgUsuario
                        {
                            Id_Perfil = Convert.ToInt16(idProveedor.Text)

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
                        agregar_proveedor formulario = new agregar_proveedor();
                        formulario.lbl_id.Text = id;
                        formulario.lbl_perfil.Text = Convert.ToString(retorno2);
                        formulario.txt_usuario.Text = Convert.ToString(retorno);
                        formulario.Show();
                    }
                }
            }

            catch
            {

            }
            
    
            
        }

        private void label3_Click(object sender, EventArgs e)
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
