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
        public string _a_apellidos;
  
        public string _direccion_cliente;
        public string _tel_cliente;
        public string _correo_cliente;

        public string _estado_cliente;

        public string _municipio_cliente;

        public string _id_usuario;





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

        public string Apellidos
        {
            get { return _a_apellidos; }
            set { _a_apellidos = value; lbl_apellidos.Text = value; }
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

        public string Estado
        {
            get { return _estado_cliente; }
            set { _estado_cliente = value; lbl_estado.Text = value; }
        }

        public string Municipio
        {
            get { return _municipio_cliente; }
            set { _municipio_cliente = value; lalbl_municipio.Text = value; }
        }

        public string Usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; lbl_idusuario.Text = value; }
        }



        public void UserControlCliente_Load(object sender, EventArgs e)
        {

        }

        public void btn_creditos_cliente_Click(object sender, EventArgs e)
        {
            dgClienteCredito parametro = new dgClienteCredito
            {
                Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                Id_Usuario= Convert.ToInt16(lbl_idusuario.Text),
            };

            string control = "";

            control = c_cliente_credito.InsertarClienteSeleccionado(parametro);


            

            cliente_credito forms =   new cliente_credito();
            forms.Show();

           
        }

        private void lbl_correo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_domicilio_Click(object sender, EventArgs e)
        {

        }
    }
}
