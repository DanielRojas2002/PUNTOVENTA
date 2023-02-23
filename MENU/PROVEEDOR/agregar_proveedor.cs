using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PRODUCTO;

namespace PUNTOVENTA.MENU.PROVEEDOR
{
    public partial class agregar_proveedor : Form
    {
        public agregar_proveedor()
        {
            InitializeComponent();
        }

        private void agregar_proveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

       

        private void agregar_proveedor_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_proveedor_Click(object sender, EventArgs e)
        {

            if (txt_correo_agregarproveedor.Text == "" )
            {

                MessageBox.Show("Ingrese el correo del proveedor");
            }
            else if (txt_nombre_agregarproveedor.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del proveedor ");
            }
            else if (txt_telefono_agregarproveedor.Text == "")
            {
                MessageBox.Show("Ingrese el telefono del proveedor ");
            }

            else
            {
                dgProveedor parametro = new dgProveedor
                {
                    Correo = txt_correo_agregarproveedor.Text.Trim(),
                    Nombre = txt_nombre_agregarproveedor.Text.Trim().ToUpper(),
                    Telefono = txt_telefono_agregarproveedor.Text.Trim(),
                    FechaEntrada=DateTime.Now,
                    FechaModificacion=DateTime.Now
                    
                };



                string control = "";

                control = c_proveedor.InsertarProveedor(parametro);

                if (control == "1")
                {

                    MessageBox.Show("Ya Existe un Proveedor con esas Nombre", "Error");
                }

                else if (control == "2")
                {
                    MessageBox.Show("Ya Existe un Proveedor con ese Telefono", "Error");
                }

                else if (control == "3")
                {
                    MessageBox.Show("Ya Existe un Proveedor con ese Correo", "Error");
                }

                else
                {
                    MessageBox.Show("Proveedor Dado de alta exitosamente", "Correcto");
                    RegresarVentana();

                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
