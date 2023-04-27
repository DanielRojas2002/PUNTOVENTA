﻿using Punto_de_Venta;
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
                string colonia,calle,numcasa;
               
                foreach (dgClienteCredito d in lista)
                {

                    colonia = d.Colonia;
                    calle = d.Calle;
                    numcasa = d.NumCasa;
                    lbl_nombre.Text = Convert.ToString(d.Nombre.ToString());
                    lbl_ap.Text = Convert.ToString(d.Apellido_Paterno.ToString());
                    lbl_am.Text = Convert.ToString(d.Apellido_Materno.ToString());
                    lbl_domicilio.Text = colonia + " " + calle + " " + numcasa;
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
                string fecharegistro ;

                DateTime fecharegistrofecha;




                foreach (dgClienteCredito d in lista2)
                {

                    idcliente = Convert.ToInt16(d.Id_Cliente.ToString());
                    idventa = Convert.ToInt16(d.Id_Venta.ToString());
                    cantidadpagada = float.Parse(d.CantidadPagada.ToString());
                    total = float.Parse(d.Total.ToString());
                    fecharegistrofecha = Convert.ToDateTime(d.FechaRegistro.ToString());

                    fecharegistro= fecharegistrofecha.ToString("dd/MM/yyyy");

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

                    Creditos[contadorcreditos].FechaRegistro = Convert.ToString(fecharegistro);


                    Creditos[contadorcreditos].Usuario = lbl_idusuario.Text;





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

        private void CargaTotalDeuda()
        {

            dgAbonoTotal parametro = new dgAbonoTotal
            {
                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text)
            };

            List<dgAbonoTotal> cantidadeudatotal = c_abonoTotal.LeerAbonoTotal(1, parametro);


            if (cantidadeudatotal.Count > 0)

            {
                float cantidaddeudafaltante = 0;

                foreach (dgAbonoTotal d in cantidadeudatotal)
                {
                    cantidaddeudafaltante = float.Parse(d.CantidadFaltanteTotal.ToString());
                    cantidaddeudafaltante = (float)Math.Round(cantidaddeudafaltante, 2);

                    lbl_deuda.Text = Convert.ToString(cantidaddeudafaltante);

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
                    lbl_idusuario.Text=d.Id_Usuario.ToString();
                }


            }
            CargaCantidadCreditos();
            CargaClientesCredito(_cantidad_creditos);
            CargaTotalDeuda();



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

        private void txt_deuda_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_abonar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_abonar_TextChanged(object sender, EventArgs e)
        {

            try
            {
                float totaldeuda = float.Parse(lbl_deuda.Text);

                float pago = float.Parse(txt_abonar.Text);
                float cambio = pago - totaldeuda;
                cambio = (float)Math.Round(cambio, 2);

                if (pago < totaldeuda)
                {

                    lbl_cambio.Text = "0";


                }

                else
                {
                    
                    lbl_cambio.Text = Convert.ToString(cambio);

                }
            }
            catch
            {
                lbl_cambio.Text = "";
            }
        }

        private void btn_abonar_Click(object sender, EventArgs e)
        {
            float totaldeuda = float.Parse(lbl_deuda.Text);

            float pago = float.Parse(txt_abonar.Text);
            float cambio = pago - totaldeuda;
            cambio = (float)Math.Round(cambio, 2);

            if (pago < totaldeuda)
            {

                lbl_cambio.Text = "0";


                // logica de ver cuanto pago y aplicarselo a pago historial y al pago mas tarde 


            }

            else
            {
                // logica de ver cuanto pago y aplicarselo a pago historial y al pago mas tarde 
                lbl_cambio.Text = Convert.ToString(cambio);

            }
        }
    }
}
