using Punto_de_Venta;
using Punto_de_Venta.Clases;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.CLIENTE.CREDITO.UserControls;
using PUNTOVENTA.MENU.VENTA.PRODUCTO;
using System;
using System.Collections;
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
    public partial class menu_credito : Form
    {
        public menu_credito()
        {
            InitializeComponent();
        }

        public int _cantidad_clientes=0;
        public void menu_credito_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void CargaClientesCredito()
        {

            flowLayoutPanel_clientes.Controls.Clear();
            dgClienteCredito parametro = new dgClienteCredito
            {
                
            };

            List<dgClienteCredito> lista = c_cliente_credito.LeerClienteCredito(1, parametro);



            int contadorclientes = 0;
            


            if (lista.Count > 0)

            {
                
                int idcliente;
              
                string nombre, ap, am, domicilio , tel, correo;

               

                foreach (dgClienteCredito d in lista)
                {
                    

                    
                   
                    idcliente = Convert.ToInt16(d.Id_Cliente.ToString());
                    nombre = Convert.ToString(d.Nombre.ToString());
                    ap = Convert.ToString(d.Apellido_Paterno.ToString());
                    am = Convert.ToString(d.Apellido_Materno.ToString());
                    domicilio = Convert.ToString(d.Direccion.ToString());
                    tel = Convert.ToString(d.Telefono.ToString());
                    correo = Convert.ToString(d.Correo.ToString());






                    UserControlCliente[] Clientes = new UserControlCliente[_cantidad_clientes];


                    contadorclientes = contadorclientes + 1;

                    Clientes[contadorclientes] = new UserControlCliente();

                    Clientes[contadorclientes].IdCliente = Convert.ToString(idcliente);

                    Clientes[contadorclientes].NombreCliente = nombre;

                    Clientes[contadorclientes].ApellidoPaterno = ap;

                    Clientes[contadorclientes].ApellidoMaterno = am;

                    Clientes[contadorclientes].Direccion = domicilio;

                    Clientes[contadorclientes].Telefono = tel;

                    Clientes[contadorclientes].Correo = correo;





                    flowLayoutPanel_clientes.Controls.Add(Clientes[contadorclientes]);
                    
                    

               

                    


                }

            }


           







        }

        public void CargaClienteCreditoBox()
        {

            dgCliente parametro = new dgCliente();

            List<dgCliente> lista = c_cliente.LeerCliente(4, parametro);

            if (lista.Count > 0)

            {

                string concatenacion = "";
                foreach (dgCliente d in lista)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Cliente.ToString() + " " + d.Nombre.ToString() + " " + d.Apellido_Paterno.ToString() + " " + d.Apellido_Materno.ToString();

                    bx_cliente_credito.Items.Add(concatenacion);
                }
            }


        }

        private void CargaCantidadClientes()
        {
            dgClienteCredito parametro = new dgClienteCredito
            {
               
            };

            List<dgClienteCredito> cantidadclientes = c_cliente_credito.LeerClienteCredito(8, parametro);


            if (cantidadclientes.Count > 0)

            {

                foreach (dgClienteCredito d in cantidadclientes)
                {

                    _cantidad_clientes = Convert.ToInt16(d.CantidadClientes.ToString()) + 1;
                   
                }
            }

        }


        public void menu_credito_Load(object sender, EventArgs e)
        {
            CargaCantidadClientes();
            CargaClientesCredito();
            CargaClienteCreditoBox();
          

        }
        
        public void RegresarVentana()
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
            menu_cliente formulario = new menu_cliente();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();





        }
        public void btn_regresar_Click(object sender, EventArgs e)
        {
            RegresarVentana();
        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void bx_cliente_credito_SelectedIndexChanged(object sender, EventArgs e)
        {
            string concatenacion = bx_cliente_credito.Text;
            string[] words = concatenacion.Split(' ');
            string idcliente;
            idcliente = words[0];


            lbl_id_cliente.Text = idcliente;
        }

        public void btn_aplicar_filtro_Click(object sender, EventArgs e)
        {
            try
            {
                if (bx_cliente_credito.Text == "" && lbl_id_cliente.Text == "")
                {

                    MessageBox.Show("Seleccione el Cliente a Buscar ");
                }

                else
                {
                    int idcliente = Convert.ToInt16(lbl_id_cliente.Text);
                    CargaClientesFiltrado(idcliente);

                }
            }

            catch
            {
                MessageBox.Show("Seleccione el Cliente a Buscar ");

            }
           
          
        }

        public void CargaClientesFiltrado(int? idcliente)
        {
            dgClienteCredito parametrofiltrado = new dgClienteCredito
            {
               Id_Cliente=Convert.ToInt16(idcliente)
            };

            List<dgClienteCredito> listafiltrado = c_cliente_credito.LeerClienteCredito(33, parametrofiltrado);


          
            int contadorclientes = 0;
            if (listafiltrado.Count > 0)

            {
                flowLayoutPanel_clientes.Controls.Clear();
                int idcliente2;



                string nombre, ap, am, domicilio, tel, correo,dia, fechaultimopago;

             
                foreach (dgClienteCredito d in listafiltrado)
                {
                    


                    
                    idcliente2 = Convert.ToInt16(d.Id_Cliente.ToString());
                    nombre = Convert.ToString(d.Nombre.ToString());
                    ap = Convert.ToString(d.Apellido_Paterno.ToString());
                    am = Convert.ToString(d.Apellido_Materno.ToString());
                    domicilio = Convert.ToString(d.Direccion.ToString());
                    tel = Convert.ToString(d.Telefono.ToString());
                    correo = Convert.ToString(d.Correo.ToString());






                    UserControlCliente[] Clientes = new UserControlCliente[10];


                    contadorclientes = contadorclientes + 1;

                    Clientes[contadorclientes] = new UserControlCliente();

                    Clientes[contadorclientes].IdCliente = Convert.ToString(idcliente2);

                    Clientes[contadorclientes].NombreCliente = nombre;

                    Clientes[contadorclientes].ApellidoPaterno = ap;

                    Clientes[contadorclientes].ApellidoMaterno = am;

                    Clientes[contadorclientes].Direccion = domicilio;

                    Clientes[contadorclientes].Telefono = tel;

                    Clientes[contadorclientes].Correo = correo;



                    flowLayoutPanel_clientes.Controls.Add(Clientes[contadorclientes]);
                   






                }

            }










        }

        public void btn_reiniciar_filtrado_Click(object sender, EventArgs e)
        {
            CargaClientesCredito();

            bx_cliente_credito.Items.Clear();
            CargaClienteCreditoBox();
        }

        public void flowLayoutPanel_clientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
