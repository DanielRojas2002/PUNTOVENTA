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
    public partial class UserControlCliente : UserControl
    {
        public UserControlCliente()
        {
            InitializeComponent();
        }


        private string _idcliente;
        private string _nombrecliente;
        private string _a_paterno_cliente;
        private string _a_materno_cliente;
        private string _direccion_cliente;
        private string _tel_cliente;
        private string _correo_cliente;

       



        public string IdCliente
        {
            get { return _idcliente; }
            set { _idcliente = value; lbl_id_cliente.Text = value; }
        }
        public string NombreCliente
        {
            get { return _nombrecliente; }
            set { _nombrecliente = value; lbl_nombre.Text = value; }
        }

        public string ApellidoPaterno
        {
            get { return _a_paterno_cliente; }
            set { _a_paterno_cliente = value; lbl_ap.Text = value; }
        }

        public string ApellidoMaterno
        {
            get { return _a_materno_cliente; }
            set { _a_materno_cliente = value; lbl_am.Text = value; }
        }

        public string Direccion
        {
            get { return _direccion_cliente; }
            set { _direccion_cliente = value; lbl_domicilio.Text = value; }
        }

        public string Telefono
        {
            get { return _tel_cliente; }
            set { _tel_cliente = value; lbl_telefono.Text = value; }
        }

        public string Correo
        {
            get { return _correo_cliente; }
            set { _correo_cliente = value; lbl_correo.Text = value; }
        }

       

        private void UserControlCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
