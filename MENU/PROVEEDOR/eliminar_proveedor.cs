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
            menu_proveedor formulario = new menu_proveedor();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();





        }
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
        }

        private void bx_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string concatenacion = bx_proveedor.Text;
            string[] words = concatenacion.Split(' ');
            string idproveedor;
            idproveedor = words[0];


            idProveedor.Text = idproveedor;
        }







        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eliminar_proveedor_Load(object sender, EventArgs e)
        {
            dgProveedor parametro = new dgProveedor();

            List<dgProveedor> lista = c_proveedor.LeerProveedor(1, parametro);

            if (lista.Count > 0)

            {

                string concatenacion = "";
                foreach (dgProveedor d in lista)
                {
                    concatenacion = "";
                    concatenacion = d.Id_Proveedor.ToString() + " " + d.Nombre.ToString();

                    bx_proveedor.Items.Add(concatenacion);
                }
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
                    dgProveedor parametro = new dgProveedor
                    {
                        Id_Proveedor = Convert.ToInt16(idProveedor.Text)
                    };




                    string control = "";

                    control = c_proveedor.EliminarProveedor(parametro);

                    if (control == "1")
                    {

                        MessageBox.Show("No se puede eliminar este Proveedor ya que ya fue asignado a un producto", "Error");
                    }

                    else
                    {
                        MessageBox.Show("Proveedor Eliminado", "Correcto");

                        RegresarVentana();
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
