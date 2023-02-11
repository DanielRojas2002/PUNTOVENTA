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
            string usuario, contraseņa;
            int retorno;

            if (txt_usuario.Text == "")
            {

                MessageBox.Show("Ingrese el Usuario ");
            }
            else if (txt_contraseņa.Text == "")
            {

                MessageBox.Show("Ingrese la Contraseņa ");
            }

            else
            {
                usuario = txt_usuario.Text;
                contraseņa = txt_contraseņa.Text;

                c_seguridad log = new c_seguridad();
                retorno = log.Identificacion_Login(usuario, contraseņa);

                if (retorno > 0)
                {
                    this.Hide();
                    Inicio formulario = new Inicio();
                    formulario.lbl_id.Text = Convert.ToString(retorno);
                    formulario.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectas", "Credenciales Incorrectas");
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



        }

        private void txt_contraseņa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (txt_contraseņa.UseSystemPasswordChar == true)
            {
                txt_contraseņa.UseSystemPasswordChar = false;
            }

            else
            {
                txt_contraseņa.UseSystemPasswordChar = true;
            }


        }
    }
}