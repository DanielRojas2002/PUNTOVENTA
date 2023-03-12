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
    public partial class reporte_cliente : Form
    {
        public reporte_cliente()
        {
            InitializeComponent();
        }

        private void reporte_cliente_Load(object sender, EventArgs e)
        {
            dgCliente parametro = new dgCliente();

            List<dgCliente> lista = c_cliente.LeerCliente(1, parametro);

            if (lista.Count > 0)

            {

                string concatenacion = "";
                foreach (dgCliente d in lista)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Cliente.ToString() + " " + d.Nombre.ToString() + " " + d.Apellido_Paterno.ToString() + " " + d.Apellido_Materno.ToString();

                    bx_cliente.Items.Add(concatenacion);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewClientes.Rows.Clear();
            if (bx_cliente.Text != "")
            {
                dgReportes parametro = new dgReportes
                {
                    IdCliente = Convert.ToInt16(idCliente.Text),
                   
                };




                List<dgReportes> lista = c_reportes.LeerReporte(3, parametro);


                if (lista.Count > 0)

                {
                    string fechaventa;
                    float cantidadpagada,total;
                    foreach (dgReportes d in lista)
                    {

                        cantidadpagada = float.Parse(d.CantidadPagada.ToString());

                        cantidadpagada = (float)Math.Round(cantidadpagada, 2);

                        total = float.Parse(d.Total.ToString());

                        total = (float)Math.Round(total, 2);



                       
                        dataGridViewClientes.Rows.Add(d.IdCliente.ToString(), d.Nombre.ToString(), d.Apellido_Paterno.ToString(),
                            d.Apellido_Materno.ToString(), d.Id_Venta.ToString(), Convert.ToString(cantidadpagada), Convert.ToString(total), d.DescripcionEstatus.ToString(), d.Usuario.ToString());



                    }

                }

                else
                {

                    MessageBox.Show("No se encontró reporte del Cliente Seleccionado");

                }
            }

            else
            {
                MessageBox.Show("Seleccione un Cliente a filtrar");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string concatenacion = bx_cliente.Text;
            string[] words = concatenacion.Split(' ');
            string idcliente;
            idcliente = words[0];


            idCliente.Text = idcliente;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reporte_cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
