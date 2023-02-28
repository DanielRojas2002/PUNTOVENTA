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


        public string _idcliente;
        public string _nombrecliente;
        public string _a_paterno_cliente;
        public string _a_materno_cliente;
        public string _direccion_cliente;
        public string _tel_cliente;
        public string _correo_cliente;





 
        //public string NombreCliente
        //{
        //    get { return _nombrecliente; }
        //    set { _nombrecliente = value; lbl_nombre.Text = value; }
        //}

  
       
        private void UserControlCredito_Load(object sender, EventArgs e)
        {

        }
    }
}
