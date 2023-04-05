using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
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
    public partial class reporte_devoluciones : Form
    {
        public reporte_devoluciones()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
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
            menu_reportes formulario = new menu_reportes();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();





        }

        private void reporte_devoluciones_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            dataGridView_devoluciones.Rows.Clear();

            CargarDevoluciones();
        }

        private void CargarDevoluciones()
        {

            dataGridView_devoluciones.Rows.Clear();

            try
            {




                txtFechai.Text = Fechadevolucion.Value.ToString("dd/MM/yyyy");




                dgReportes parametro = new dgReportes
                {
                    FechaInicio = Convert.ToDateTime(txtFechai.Text)

                };




                List<dgReportes> lista = c_reportes.LeerReporte(44, parametro);


                if (lista.Count > 0)

                {
                    string fechadevolucion;

                    foreach (dgReportes d in lista)
                    {


                        fechadevolucion = d.FechaInicio.Value.ToString("dd/MM/yyyy");
                        dataGridView_devoluciones.Rows.Add(d.IdDevolucion.ToString(), d.Id_Venta.ToString(), d.NombreProducto.ToString(),
                             d.PrecioVenta.ToString(), d.CantidadPagada.ToString(), d.Usuario.ToString(),fechadevolucion);



                    }


                }

                else
                {
                    MessageBox.Show("No se Encontraron Devoluciones en el dia seleccionado");


                }

            }
            catch
            {


                txtFechai.Text = Fechadevolucion.Value.ToString("");


                string fechadiferenteinicio = txtFechai.Text;
                string[] words = fechadiferenteinicio.Split('/');
                string dia, mes, ano;

                mes = words[0];
                dia = words[1];
                ano = words[2];


                txtFechai.Text = dia + "/" + mes + "/" + ano;






                dgReportes parametro = new dgReportes
                {
                    FechaCaja = Convert.ToDateTime(txtFechai.Text),

                };




                List<dgReportes> lista = c_reportes.LeerReporte(4, parametro);


                if (lista.Count > 0)

                {
                    string fechadevolucion;

                    foreach (dgReportes d in lista)
                    {


                        fechadevolucion = d.FechaInicio.Value.ToString("dd/MM/yyyy");
                        dataGridView_devoluciones.Rows.Add(d.IdDevolucion.ToString(), d.Id_Venta.ToString(), d.NombreProducto.ToString(),
                             d.PrecioVenta.ToString(), d.CantidadPagada.ToString(), d.Usuario.ToString(), fechadevolucion);



                    }


                }

                else
                {
                    MessageBox.Show("No se Encontraron Devoluciones en el dia seleccionado");
                }




            }


        }
    }
}
