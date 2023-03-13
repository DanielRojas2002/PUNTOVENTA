using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;

namespace Punto_de_Venta
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barra_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // INCIO DE SESION 
          
            int retorno=0;

            if (txt_usuario.Text == "")
            {

                MessageBox.Show("Ingrese el Usuario ");
            }
            else if (txt_contrase�a.Text == "")
            {

                MessageBox.Show("Ingrese la Contrase�a ");
            }

            else
            {
               

                dgUsuario parametro = new dgUsuario
                {
                    Usuario = txt_usuario.Text.Trim().ToUpper(),
                    Contrasenia= txt_contrase�a.Text.Trim().ToUpper()
                };



                string control = "";

                List<dgUsuario> lista = c_usuario.LeerUsuario(1, parametro);

                if (lista.Count > 0)

                {
                   
                    foreach (dgUsuario d in lista)
                    {
                        retorno = Convert.ToInt16(d.Id_Usuario.ToString());
                    }


                    control = "*";


                }

                else
                {
                    control = "-";
                }




               

                if (control == "-")
                {

                    MessageBox.Show("Credenciales Incorrectas", "Credenciales Incorrectas");
                }

                else
                {
                    this.Hide();
                    Inicio formulario = new Inicio();
                    formulario.lbl_id.Text = Convert.ToString(retorno);
                    formulario.Show();
                }

             

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void barra_panel_MouseDown(object sender, MouseEventArgs e)
        {



        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter) | (e.KeyChar == Convert.ToChar(Keys.Tab)))
                btn_iniciar_sesion.Focus();

        }

        private void txt_contrase�a_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (txt_contrase�a.UseSystemPasswordChar == true)
            {
                txt_contrase�a.UseSystemPasswordChar = false;
            }

            else
            {
                txt_contrase�a.UseSystemPasswordChar = true;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) | (e.KeyChar == Convert.ToChar(Keys.Tab)))
                txt_contrase�a.Focus();
        }

        private void btn_iniciar_sesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}