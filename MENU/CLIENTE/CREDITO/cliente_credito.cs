using Punto_de_Venta;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.CLIENTE.CREDITO.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.MENU.CLIENTE.CREDITO
{
    public partial class cliente_credito : Form
    {
        public cliente_credito()
        {
            InitializeComponent();
        }

        public int _cantidad_creditos;

        public void CargaClientesCredito(int cantidacreditos)
        {

         
            dgClienteCredito parametro = new dgClienteCredito
            {
                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text)
            };

            List<dgClienteCredito> lista = c_cliente_credito.LeerClienteCredito(33, parametro);


            if (lista.Count > 0)

            {

               
                foreach (dgClienteCredito d in lista)
                {

                 
                    lbl_nombre.Text = Convert.ToString(d.Nombre.ToString());
                    lbl_ap.Text = Convert.ToString(d.Apellido_Paterno.ToString());
                    lbl_am.Text = Convert.ToString(d.Apellido_Materno.ToString());
                    lbl_domicilio.Text = Convert.ToString(d.Direccion.ToString());
                    lbl_telefono.Text = Convert.ToString(d.Telefono.ToString());
                    lbl_correo.Text = Convert.ToString(d.Correo.ToString());


                }

            }


            flowLayoutPanel_creditos.Controls.Clear();

            dgClienteCredito parametro2 = new dgClienteCredito
            {
                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text)
            };

            List<dgClienteCredito> lista2 = c_cliente_credito.LeerClienteCredito(3, parametro2);



            int contadorcreditos = 0;



            if (lista2.Count > 0)

            {

                int idventa,idcliente;
                float cantidadpagada, total,cantidadfaltante;

              

               
                foreach (dgClienteCredito d in lista2)
                {

                    idcliente = Convert.ToInt16(d.Id_Cliente.ToString());
                    idventa = Convert.ToInt16(d.Id_Venta.ToString());
                    cantidadpagada = float.Parse(d.CantidadPagada.ToString());
                    total = float.Parse(d.Total.ToString());


                    cantidadfaltante = total - cantidadpagada;


                    cantidadfaltante = (float)Math.Round(cantidadfaltante, 2);

                  


                    total = (float)Math.Round(total, 2);

                    UserControlCredito[] Creditos = new UserControlCredito[cantidacreditos];


                    contadorcreditos = contadorcreditos + 1;

                    Creditos[contadorcreditos] = new UserControlCredito();


                    Creditos[contadorcreditos].IdCliente = Convert.ToString(idcliente);

                    Creditos[contadorcreditos].IdVenta = Convert.ToString(idventa);

                    Creditos[contadorcreditos].TotalPagado = Convert.ToString(cantidadpagada);

                    Creditos[contadorcreditos].TotalVenta = Convert.ToString(total);

                    Creditos[contadorcreditos].FaltaPagar = Convert.ToString(cantidadfaltante);






                    flowLayoutPanel_creditos.Controls.Add(Creditos[contadorcreditos]);






                }

            }


        }


        private void CargaCantidadCreditos()
        {
            
            dgClienteCredito parametro = new dgClienteCredito
            {
                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text)
            };

            List<dgClienteCredito> cantidadcreditos = c_cliente_credito.LeerClienteCredito(7, parametro);


            if (cantidadcreditos.Count > 0)

            {

                foreach (dgClienteCredito d in cantidadcreditos)
                {

                    _cantidad_creditos = Convert.ToInt16(d.CantidadCreditos.ToString()) + 1;

                }
            }
           

        }

        private void cliente_credito_Load(object sender, EventArgs e)
        {
           


            dgClienteCredito parametro = new dgClienteCredito();


            List<dgClienteCredito> lista = c_cliente_credito.LeerClienteCredito(4, parametro);

            if (lista.Count > 0)

            {

                foreach (dgClienteCredito d in lista)
                {
                    lbl_id_cliente.Text=d.Id_Cliente.ToString();
                }


            }
            CargaCantidadCreditos();
            CargaClientesCredito(_cantidad_creditos);




        }
         
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Cerrar()
        {
            this.Close();  
        }


        private void flowLayoutPanel_creditos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_id_cliente_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel_creditos_MouseMove(object sender, MouseEventArgs e)
        {
           
        }
    }
}
