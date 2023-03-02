using Punto_de_Venta;
using Punto_de_Venta.Clases;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PROVEEDOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.MENU.REPORTES
{
    public partial class reporte_venta : Form
    {
        public reporte_venta()
        {
            InitializeComponent();
        }

        private void reporte_venta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            txtFechai.Text = FechaInicio.Value.ToString("dd/MM/yyyy");
            txtFechaf.Text = fechafinal.Value.ToString("dd/MM/yyyy");

            dgReportes parametro = new dgReportes
            {
                FechaInicio = Convert.ToDateTime(txtFechai.Text),
                FechaFinal = Convert.ToDateTime(txtFechaf.Text)
            };




            List <dgReportes> lista = c_reportes.LeerReporte(1, parametro);


            if (lista.Count > 0)

            {
                string fechaventa;
                foreach (dgReportes d in lista)
                {

                    fechaventa = d.FechaVentaProducto.Value.ToString("dd/MM/yyyy");
                    dataGridView1.Rows.Add(d.Id_Venta.ToString(),d.IdProducto.ToString(),d.NombreProducto.ToString(),
                        d.CantidadProducto.ToString(),d.PrecioProducto.ToString(),d.SubTotalProducto.ToString(), fechaventa,d.Usuario.ToString());
                    


                }

            }

            else
            {

                MessageBox.Show("No se encontró reporte de venta este día seleccionado");

            }

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
            Inicio formulario = new Inicio();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();





        }
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reporte_venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FechaInicio_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
