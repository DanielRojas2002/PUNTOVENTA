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

namespace PUNTOVENTA.MENU.CLIENTE.CREDITO.UserControls
{
    public partial class UserControlCliente : UserControl
    {
        public UserControlCliente()
        {
            InitializeComponent();
        }


        public string _idcliente;
        public string _nombrecliente;
        public string _a_paterno_cliente;
        public string _a_materno_cliente;
        public string _direccion_cliente;
        public string _tel_cliente;
        public string _correo_cliente;

       



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

       

        public void UserControlCliente_Load(object sender, EventArgs e)
        {

        }

        public void btn_creditos_cliente_Click(object sender, EventArgs e)
        {
            dgClienteCredito parametro = new dgClienteCredito
            {
                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text)
            };

            string control = "";

            control = c_cliente_credito.InsertarClienteSeleccionado(parametro);


            

            cliente_credito forms =   new cliente_credito();
            forms.Show();

           
        }
    }
}
