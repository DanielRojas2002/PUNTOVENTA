﻿using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.CAJA;
using PUNTOVENTA.MENU.CLIENTE;
using PUNTOVENTA.MENU.DEVOLUCIONES;
using PUNTOVENTA.MENU.PRODUCTO;
using PUNTOVENTA.MENU.PROVEEDOR;
using PUNTOVENTA.MENU.REPORTES;
using PUNTOVENTA.MENU.VENTA;
using System.Windows.Forms;

namespace Punto_de_Venta
{
    public partial class Inicio : Form
    {


        public Inicio()
        {
            InitializeComponent();
           


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cerrarapp_Click(object sender, EventArgs e)
        {
            ActualizarCaja();
            Application.Exit();
        }

        private void btn_minimzar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_Click(object sender, EventArgs e)
        {

        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_reportes forms = new menu_reportes();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();



        }
       
        private void pnl_izq_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pnl_der_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Activated(object sender, EventArgs e)
        {
          
           
            string retorno="", retorno2="";
            
            dgUsuario parametro = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)

            };

       

            List<dgUsuario> lista = c_usuario.LeerUsuario(2, parametro);

            if (lista.Count > 0)

            {

                foreach (dgUsuario d in lista)
                {
                    retorno = Convert.ToString(d.Usuario.ToString());
                }


              

                txt_usuario.Text = ("Bievenido usuario: " + retorno);


            }

           

            dgUsuario parametro2 = new dgUsuario
            {
                Id_Usuario = Convert.ToInt16(lbl_id.Text)

            };

            

            List<dgUsuario> lista2 = c_usuario.LeerUsuario(3, parametro);

            if (lista.Count > 0)

            {

                foreach (dgUsuario d in lista2)
                {
                    retorno2 = Convert.ToString(d.DescripcionPerfil.ToString());
                }


                lbl_perfil.Text = ("Perfil: " + retorno2);


            }

           





            if (retorno2 == "Administrador")
            {
                
                pnl_productos.Visible = true;
                pnl_ventas.Visible = true;
                pnl_productos.Visible = true;
                pnl_seguridad.Visible = true;

                pnl_r.Visible = true;
                btn_reportes.Visible = true;
                pnl_provedores.Visible = true;




            }
            else if (retorno2 == "Vendedor")
            {
               
                pnl_productos.Visible = true;
                pnl_ventas.Visible = true;
                pnl_seguridad.Visible = false;
                pnl_r.Visible = false;
                btn_reportes.Visible = false;
                pnl_provedores.Visible = false;

                pnl_caja.Visible = true;
                pnl_clientes.Visible = true;
                pnl_provedores.Visible = true;
                pnl_producto.Visible = true;
                pnl_segurida.Visible = false;
                pnl_reporte.Visible = false;
                pnl_ventas.Visible = true;
            }


          
                


        }

        public void btn_venta_Click(object sender, EventArgs e)
        {
            try
            {
                dgCaja parametro = new dgCaja
                {
                    FechaCaja = DateTime.Now


                };


                List<dgCaja> lista = c_caja.LeerCaja(7, parametro);

                string estatuscaja = "";
                if (lista.Count > 0)

                {

                    foreach (dgCaja d in lista)
                    {
                        estatuscaja = Convert.ToString(d.Id_CajaEstatus.ToString());



                    };

                }

                if (estatuscaja == "1")
                {

                    this.Hide();
                    menu_venta forms = new menu_venta();
                    forms.lbl_id.Text = lbl_id.Text;
                    forms.Show();
                }

                else if (estatuscaja == "2")
                {
                    MessageBox.Show("No puede Acceder al apartado de ventas ya que la caja esta cerrada", "Advertencia");
                }
            }

            catch
            {
                MessageBox.Show("Debe de Ingresar a Caja Antes ", "Advertencia");
            }
           

            

           
        }

        public void btn_ventaf1()
        {
            dgCaja parametro = new dgCaja
            {
                FechaCaja = DateTime.Now


            };
       


            List<dgCaja> lista = c_caja.LeerCaja(7, parametro);

            string estatuscaja = "";
            if (lista.Count > 0)

            {

                foreach (dgCaja d in lista)
                {
                    estatuscaja = Convert.ToString(d.Id_CajaEstatus.ToString());



                };

            }

            if (estatuscaja == "1")
            {

                this.Hide();
                menu_venta forms = new menu_venta();
                forms.lbl_id.Text = lbl_id.Text;
                forms.Show();
            }

            else if (estatuscaja == "2")
            {
                MessageBox.Show("No puede Acceder al apartado de ventas ya que la caja esta cerrada", "Advertencia");
            }
        }


      
        private void btn_productos_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_producto forms = new menu_producto();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_productof2()
        {
            this.Hide();
            menu_producto forms = new menu_producto();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }
        private void btn_provedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_proveedor forms = new menu_proveedor();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_proveedoresf4()
        {

            this.Hide();
            menu_proveedor forms = new menu_proveedor();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_almacen_Click(object sender, EventArgs e)
        {

        }

        private void btn_r_ventas_Click(object sender, EventArgs e)
        {
            this.Hide();
            reporte_venta forms = new reporte_venta();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_seguridad_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_seguridad forms = new menu_seguridad();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();

        }
        private void btn_seguridadf6()
        {

            this.Hide();
            menu_seguridad forms = new menu_seguridad();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            ActualizarCaja();
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Show();
        }

        private void btn_alimg_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_compras_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void lbl_perfil_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cliente forms = new menu_cliente();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }
        private void btn_clientef3()
        {

            this.Hide();
            menu_cliente forms = new menu_cliente();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }


        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pnl_r_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_caja_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_caja forms = new menu_caja();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }
        private void btn_cajaf5()
        {

            this.Hide();
            menu_caja forms = new menu_caja();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            reporte_compras forms = new reporte_compras();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            reporte_cliente forms = new reporte_cliente();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
            
        }

        private void Inicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.NumPad1))
            {
                
                btn_ventaf1();
               
            }

            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_productof2();
            }

            else if (e.KeyChar == Convert.ToChar(Keys.F3))
            {
                btn_clientef3();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.F4))
            {
                btn_proveedoresf4();
            }
         

            else if (e.KeyChar == Convert.ToChar(Keys.F5))
            {
                btn_cajaf5();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.F6))
            {
                btn_seguridadf6();
            }

        }

        private void btn_devoluciones_Click(object sender, EventArgs e)
        {
            try
            {
                dgCaja parametro = new dgCaja
                {
                    FechaCaja = DateTime.Now


                };


                List<dgCaja> lista = c_caja.LeerCaja(7, parametro);

                string estatuscaja = "";
                if (lista.Count > 0)

                {

                    foreach (dgCaja d in lista)
                    {
                        estatuscaja = Convert.ToString(d.Id_CajaEstatus.ToString());



                    };

                }

                if (estatuscaja == "1")
                {

                    this.Hide();
                    devoluciones forms = new devoluciones();
                    forms.lbl_id.Text = lbl_id.Text;
                    forms.Show();
                }

                else if (estatuscaja == "2")
                {
                    MessageBox.Show("No puede Acceder al apartado de Devoluciones ya que la caja esta cerrada", "Advertencia");
                }
            }

            catch
            {
                MessageBox.Show("Debe de Ingresar a Caja Antes ", "Advertencia");
            }



        }

        private void ActualizarCaja()
        {

            
                float totalventa = 0, totalventapagos = 0, totalventadevolucion = 0, totalabonado = 0, totalretirado = 0;


                dgCaja parametrototalventas = new dgCaja
                {
                    FechaCaja = DateTime.Now

                };


                dgCaja parametrototalventaspagos = new dgCaja
                {
                    FechaCaja = DateTime.Now

                };

                dgCaja parametrototalventasdevoluciones = new dgCaja
                {
                    FechaCaja = DateTime.Now

                };

                dgCaja parametrototalventasabono = new dgCaja
                {
                    FechaCaja = DateTime.Now

                };

                dgCaja parametrototalretirado = new dgCaja
                {
                    FechaCaja = DateTime.Now

                };




                List<dgCaja> listatotalventas = c_caja.LeerCaja(14, parametrototalventas);


                if (listatotalventas.Count > 0)

                {

                    foreach (dgCaja d in listatotalventas)
                    {
                        totalventa = float.Parse(d.CantidadTotal.ToString());
                        totalventa = (float)Math.Round(totalventa, 2);

                    }
                }



                List<dgCaja> listatotalventaspagos = c_caja.LeerCaja(15, parametrototalventaspagos);


                if (listatotalventaspagos.Count > 0)

                {

                    foreach (dgCaja dd in listatotalventaspagos)
                    {

                        totalventapagos = float.Parse(dd.CantidadTotal.ToString());
                        totalventapagos = (float)Math.Round(totalventapagos, 2);

                    }
                }



                List<dgCaja> listatotalventasdevoluciones = c_caja.LeerCaja(16, parametrototalventas);


                if (listatotalventasdevoluciones.Count > 0)

                {

                    foreach (dgCaja d in listatotalventasdevoluciones)
                    {

                        totalventadevolucion = float.Parse(d.CantidadTotal.ToString());
                        totalventadevolucion = (float)Math.Round(totalventadevolucion, 2);

                    }
                }



                List<dgCaja> listatotalventasabono = c_caja.LeerCaja(17, parametrototalventasabono);


                if (listatotalventasabono.Count > 0)

                {

                    foreach (dgCaja d in listatotalventasabono)
                    {

                        totalabonado = float.Parse(d.CantidadTotal.ToString());
                        totalabonado = (float)Math.Round(totalabonado, 2);

                    }
                }


                List<dgCaja> listatotalretirado = c_caja.LeerCaja(18, parametrototalretirado);


                if (listatotalretirado.Count > 0)

                {

                    foreach (dgCaja d in listatotalretirado)
                    {

                        totalretirado = float.Parse(d.CantidadTotal.ToString());
                        totalretirado = (float)Math.Round(totalretirado, 2);

                    }
                }

                float cantidadventas = totalventa + totalventapagos;

                cantidadventas = (float)Math.Round(cantidadventas, 2);

                float cantidatotal = totalventa + totalventapagos + totalabonado - totalventadevolucion - totalretirado;

                cantidatotal = (float)Math.Round(cantidatotal, 2);


                dgCaja parametro = new dgCaja
                {

                    CantidadTotal = cantidatotal,
                    CantidadVenta = cantidadventas,
                    CantidadDevolucion = totalventadevolucion,


                    FechaCaja = DateTime.Now

                };

                string control = "";

                control = c_caja.ActualizarCaja2(parametro);
            
           
        }

        private void Inicio_MouseMove(object sender, MouseEventArgs e)
        {

            ActualizarCaja();

        }

        private void pnl_der_MouseMove(object sender, MouseEventArgs e)
        {
            ActualizarCaja();
        }

        private void pnl_izq_MouseMove(object sender, MouseEventArgs e)
        {
            ActualizarCaja();
        }
    }
}
