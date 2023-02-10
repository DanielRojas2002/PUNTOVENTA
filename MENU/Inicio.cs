using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Punto_de_Venta
{
    public partial class Inicio : Form
    {


        public Inicio()
        {
            InitializeComponent();
            pnl_reportes.Visible = false;
        

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cerrarapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimzar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_Click(object sender, EventArgs e)
        {

        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            if (pnl_reportes.Visible == false) {
                pnl_reportes.Visible = true;
            }

            else
            {
                pnl_reportes.Visible = false;
            }

            

        }

        private void pnl_izq_Paint(object sender, PaintEventArgs e)
        {
            pnl_reportes.Visible = false;
        }

        private void pnl_der_Paint(object sender, PaintEventArgs e)
        {
            pnl_reportes.Visible = false;
        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Activated(object sender, EventArgs e)
        {
            string id;
            id = lbl_id.Text;
            string retorno,retorno2;
            c_seguridad log = new c_seguridad();
            retorno = log.ChecarUsuario(id);
            txt_usuario.Text = ("Bievenido usuario: " + retorno);

            c_seguridad log2 = new c_seguridad();
            retorno2 = log2.ChecarPerfil(id);
            lbl_perfil.Text = ("Perfil: " + retorno2);
            

            if (retorno2 == "Administrador")
            {
                pnl_almacen.Visible = true;
                pnl_productos.Visible = true;
                pnl_ventas.Visible = true;
                pnl_productos.Visible = true;
                pnl_seguridad.Visible = true;
               
                pnl_reportes.Visible = true;
                pnl_provedores.Visible = true;
                

            }
            else if (retorno2== "Vendedor")
            {
                pnl_almacen.Visible = false;
                pnl_productos.Visible = true;
                pnl_ventas.Visible = true;
                pnl_seguridad.Visible = false;
              
                pnl_reportes.Visible = true;
                pnl_provedores.Visible = false;
            }

          
           

        }

        private void btn_venta_Click(object sender, EventArgs e)
        {

        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //menu_producto forms = new menu_producto();
            //forms.lbl_id.Text = lbl_id.Text;
            //forms.Show();
        }

        private void btn_provedores_Click(object sender, EventArgs e)
        {

        }

        private void btn_almacen_Click(object sender, EventArgs e)
        {

        }

        private void btn_r_ventas_Click(object sender, EventArgs e)
        {

        }

        private void btn_seguridad_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_seguridad forms = new menu_seguridad();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
            
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Show();
        }

        private void btn_alimg_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_compras_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void lbl_perfil_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {

        }
    }
}
