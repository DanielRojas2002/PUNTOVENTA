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
    public partial class reporte_caja : Form
    {
        public reporte_caja()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reporte_caja_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void reporte_caja_Load(object sender, EventArgs e)
        {

        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            dataGridView_caja.Rows.Clear();

            CargarCaja();
        }

        private void CargarCaja()
        {

            dataGridView_caja.Rows.Clear();

            try
            {




                txtFechai.Text = Fechacaja.Value.ToString("dd/MM/yyyy");
              



                dgReportes parametro = new dgReportes
                {
                    FechaCaja = Convert.ToDateTime(txtFechai.Text)
                  
                };




                List<dgReportes> lista = c_reportes.LeerReporte(4, parametro);


                if (lista.Count > 0)

                {
                    string fechacaja;
                  
                    foreach (dgReportes d in lista)
                    {
                       

                        fechacaja = d.FechaCaja.Value.ToString("dd/MM/yyyy");
                        dataGridView_caja.Rows.Add(d.IdCaja.ToString(), d.CantidadVenta.ToString(), d.CantidadAbonada.ToString(),
                             d.CantidadDevolucion.ToString(), d.CantidadRetirada.ToString(), d.CantidadTotal.ToString(), fechacaja, d.DescripcionCaja.ToString());


                        
                    }


                }

                else
                {
                    MessageBox.Show("No se Encontro Caja en el dia seleccionado");


                }

            }
            catch
            {


                txtFechai.Text = Fechacaja.Value.ToString("");
               

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
                    string fechacaja;

                    foreach (dgReportes d in lista)
                    {


                        fechacaja = d.FechaCaja.Value.ToString("dd/MM/yyyy");
                        dataGridView_caja.Rows.Add(d.IdCaja.ToString(), d.CantidadAbonada.ToString(), d.CantidadVenta.ToString(),
                             d.CantidadRetirada.ToString(), d.CantidadTotal.ToString(), fechacaja, d.DescripcionCaja.ToString());



                    }


                }

                else
                {
                    MessageBox.Show("No se Encontro Caja en el dia seleccionado");
                }

             


            }


        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {

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
    }
}
