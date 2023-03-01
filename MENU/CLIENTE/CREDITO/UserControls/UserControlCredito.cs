using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.PROVEEDOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.MENU.CLIENTE.CREDITO.UserControls
{
    public partial class UserControlCredito : UserControl
    {
        public UserControlCredito()
        {
            InitializeComponent();
        }


        public string _idventa;
        public string _totalventa;
        public string _totalpagado;
        public string _faltaporpagar;
     






        public string IdVenta
        {
            get { return _idventa; }
            set { _idventa = value; lbl_id_venta.Text = value; }
        }

        public string TotalVenta
        {
            get { return _totalventa; }
            set { _totalventa = value; lbl_total_venta.Text = value; }
        }

        public string TotalPagado
        {
            get { return _totalpagado; }
            set { _totalpagado = value; lbl_cantidad_pagada.Text = value; }
        }

        public string FaltaPagar
        {
            get { return _faltaporpagar; }
            set { _faltaporpagar = value; lbl_total_faltante.Text = value; }
        }



        private void CargaTipoVenta()
        {

            dgTipoVenta parametro = new dgTipoVenta();

            List<dgTipoVenta> lista = c_tipoventa.LeerTipoVenta(1, parametro);

            if (lista.Count > 0)

            {
                
                foreach (dgTipoVenta d in lista)
                {
                    if (d.Descripcion=="Credito")
                    {

                    }
                    else
                    {
                        bx_tipoventa.Items.Add(d.Descripcion.ToString());
                       
                    }
                    
                }
            }


        }


        private void UserControlCredito_Load(object sender, EventArgs e)
        {
            CargaTipoVenta();
            txt_nombre_transferencia.Visible = false;
            lbl_cambio.Text = "";
        }

        private void txt_paga_con_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float restante = float.Parse(lbl_total_faltante.Text);

                float pagar = float.Parse(txt_paga_con.Text);

                float cambio = pagar - restante;

                cambio = (float)Math.Round(cambio, 2);

                if (restante < pagar)
                {
                    lbl_cambio.ForeColor = Color.Yellow;
                    lbl_cambio.Text = Convert.ToString(cambio);
                }

                else
                {
                    lbl_cambio.ForeColor = Color.Red;

                    lbl_cambio.Text = "0";


                }

            }
            catch
            {

            }







        }

        private void txt_paga_con_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bx_tipoventa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          

            dgTipoVenta parametro = new dgTipoVenta
            {
                Descripcion = bx_tipoventa.Text
            };

            List<dgTipoVenta> lista = c_tipoventa.LeerTipoVenta(2, parametro);



            if (lista.Count > 0)

            {

                foreach (dgTipoVenta d in lista)
                {
                    lbl_id_tipoventa.Text = d.Id_TipoVenta.ToString();
                }


            }

            if (lbl_id_tipoventa.Text == "1") // efectivo
            {


                txt_nombre_transferencia.Visible = false;
                lbl_clienteonombre.Visible = false;
                lbl_cambio.Visible= true;
                label11.Visible = true;
                txt_paga_con.Visible = true;
                label2.Visible = true;

            }

            else if (lbl_id_tipoventa.Text == "2") // transferencia
            {
                lbl_clienteonombre.Visible = true;
                lbl_clienteonombre.Text = "Nombre";
                txt_nombre_transferencia.Visible = true;
                label11.Visible = false;
                lbl_cambio.Visible = false;
                txt_paga_con.Visible = false;
                label2.Visible = false;
                txt_paga_con.Text = "";
                lbl_cambio.Text = "";

            }
        }

        private void btn_realizar_venta_Click(object sender, EventArgs e)
        {
            try
            {
                float restante = float.Parse(lbl_total_faltante.Text);

                float pagar = float.Parse(txt_paga_con.Text);

                float cambio = pagar - restante;
                 
                cambio = (float)Math.Round(cambio, 2);

                if (restante < pagar)
                {
                    lbl_cambio.Text = Convert.ToString(cambio);
                }

                else
                {

                    lbl_cambio.Text = "0";

                    dgClienteCredito parametro = new dgClienteCredito
                    {
                        Id_Venta=Convert.ToInt16(lbl_id_venta.Text),
                        CantidadPagada = float.Parse(txt_paga_con.Text.Trim()),
                        FechaPago=DateTime.Now,
                        Validacion=0
                    };



                    string control = "";

                    control = c_cliente_credito.ActualizarCreditoPago(0,parametro);


                }
            }
            catch
            {
                MessageBox.Show("LLene el campo de pago ");
            }
        }
    }
}
