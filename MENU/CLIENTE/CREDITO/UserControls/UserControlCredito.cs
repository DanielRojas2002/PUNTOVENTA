using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


      



        private void UserControlCredito_Load(object sender, EventArgs e)
        {

        }
    }
}
