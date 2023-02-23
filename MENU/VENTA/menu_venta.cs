﻿using Punto_de_Venta;
using Punto_de_Venta.Clases;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.CLIENTE;
using PUNTOVENTA.MENU.VENTA.PRODUCTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PUNTOVENTA.MENU.VENTA
{
    public partial class menu_venta : Form
    {
        public menu_venta()
        {
            InitializeComponent();


        }

        public int _num_venta;
        

        private void flowLayoutPanel_productos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_venta_Load(object sender, EventArgs e)
        {
            _num_venta = NumeroVenta();
            CargaProductos(0);
            CargaTipoVenta();

            bx_cliente.Visible = false;
            lbl_clienteonombre.Text = "";
            txt_nombre_transferencia.Visible = false;
            txt_paga_con.Visible = false;
            lbl_etiqueta_pago.Text = "";

            label11.Text = "";
            lbl_total.Text = "";
            lbl_cambio.Text = "";
            txt_paga_con.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_paga_con_KeyPress);

        }

        private void CargaSubTotal(int total)
        {
            lbl_total.Text = Convert.ToString(total);
        }

        private void CargaProductosOrden()
        {


          
            flowLayoutPanel_Orden.Controls.Clear();
           


            lbl_total.Text = "";
            dgVentaDetalle parametro = new dgVentaDetalle
            {
                Id_Venta = _num_venta
            };

            List<dgVentaDetalle> listaorden = c_ventadetalle.LeerVentaDetalle(2, parametro);

            int contadorproductos = 0;

            if (listaorden.Count > 0)

            {
                flowLayoutPanel_productos.Controls.Clear();
                flowLayoutPanel_Orden.Controls.Clear();

                CargaProductos(0);

                int idproducto, stock, precioventa,subtotal,total=0;
                string nombre;
                foreach (dgVentaDetalle d in listaorden)
                {
                    idproducto = Convert.ToInt16(d.Id_Producto.ToString());

                    stock = Convert.ToInt16(d.CantidadAComprar.ToString());

                    precioventa = Convert.ToInt16(d.PrecioVenta.ToString());

                    nombre = Convert.ToString(d.Nombre.ToString());




                    UserControlOrdenCompra[] Productos = new UserControlOrdenCompra[10];


                    contadorproductos = contadorproductos + 1;

                    Productos[contadorproductos] = new UserControlOrdenCompra();

                    Productos[contadorproductos].IdProducto = Convert.ToString(idproducto);

                    Productos[contadorproductos].IdVenta = Convert.ToString(_num_venta);

                    Productos[contadorproductos].NombreProducto = nombre;

                    Productos[contadorproductos].StockProductoComprar = Convert.ToString(stock);

                    Productos[contadorproductos].PrecioProducto = Convert.ToString(precioventa);

                    subtotal = precioventa * stock;

                    total = total + subtotal;

                    Productos[contadorproductos].SubTotal = Convert.ToString(subtotal);

                    flowLayoutPanel_Orden.Controls.Add(Productos[contadorproductos]);



                }

                CargaSubTotal(total);

            }
            else
            {
                CargaProductos(0);
            }
            













        }

        public static int NumeroVenta()
        {
            dgVentaDetalle parametronumeroventa = new dgVentaDetalle();

            List<dgVentaDetalle> listanumeroorden = c_ventadetalle.LeerVentaDetalle(1, parametronumeroventa);

            int numeroventa = 1;
            if (listanumeroorden.Count > 0)
            {
                foreach (dgVentaDetalle d in listanumeroorden)
                {
                    numeroventa = Convert.ToInt16(d.Id_Venta);
                }

            }

            return numeroventa;
        }

        private void menu_venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {


            dgVentaDetalle parametroeliminartodos = new dgVentaDetalle
            {
                Id_Venta = _num_venta

            };

            string control = "";
          
            control = c_ventadetalle.EliminarVentaDetalleTodos(parametroeliminartodos);
            Application.Exit();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CargaProductos(int Id_Validacion2)
        {


            dgProducto parametro = new dgProducto
            {
                Id_Venta = _num_venta,
                Id_Validacion2= Id_Validacion2
            };

            List<dgProducto> lista = c_producto.LeerProducto(7, parametro);


            
            int contadorproductos = 0;

            if (lista.Count > 0)

            {
                flowLayoutPanel_productos.Controls.Clear();
                int idproducto, idcategoria, idmedida, stock,precioventa;
                string nombre, categoriadescripcion, medidadescripcion, descripcion;
                foreach (dgProducto d in lista)
                {
                    idproducto = Convert.ToInt16(d.Id_Producto.ToString());
                    idcategoria = Convert.ToInt16(d.Id_Categoria.ToString());
                    idmedida = Convert.ToInt16(d.Id_Medida.ToString());
                    stock = Convert.ToInt16(d.StockInicial.ToString());
                    descripcion = Convert.ToString(d.Descripcion.ToString());
                    precioventa = Convert.ToInt16(d.PrecioVenta.ToString());
                    nombre = Convert.ToString(d.Nombre.ToString());

                    dgCategoria parametro2 = new dgCategoria
                    {
                        Id_Categoria = Convert.ToInt16(idcategoria.ToString())
                    };

                    List<dgCategoria> listacategoria = c_categoria.LeerCategoria(3, parametro2);


                    dgMedida parametro3 = new dgMedida
                    {
                        Id_Medida = Convert.ToInt16(idmedida.ToString())
                    };

                    List<dgMedida> listamedida = c_medida.LeerMedida(3, parametro3);

                    if (listacategoria.Count > 0 && listamedida.Count > 0)

                    {
                        categoriadescripcion = "";
                        medidadescripcion = "";
                        foreach (dgCategoria dg in listacategoria)
                        {
                            categoriadescripcion = Convert.ToString(dg.Descripcion.ToString());
                        }

                        foreach (dgMedida dg in listamedida)
                        {
                            medidadescripcion = Convert.ToString(dg.Descripcion.ToString());
                        }

                        UserControlProducto[] Productos = new UserControlProducto[10];


                        contadorproductos = contadorproductos + 1;

                        Productos[contadorproductos] = new UserControlProducto();

                        Productos[contadorproductos].IdProducto = Convert.ToString(idproducto);

                        Productos[contadorproductos].NombreProducto = nombre;

                        Productos[contadorproductos].StockProducto = Convert.ToString(stock);

                        Productos[contadorproductos].DescripcionProducto = descripcion;

                        Productos[contadorproductos].NumVenta = Convert.ToString(_num_venta);

                        Productos[contadorproductos].PrecioProducto = Convert.ToString(precioventa);

                        Productos[contadorproductos].CategoriaProducto = categoriadescripcion;

                        Productos[contadorproductos].MedidaProducto = medidadescripcion;



                        flowLayoutPanel_productos.Controls.Add(Productos[contadorproductos]);



                    }


                }

            }


            bx_categorias.Items.Clear();
            dgCategoria parametro2_1 = new dgCategoria
            {

            };

            List<dgCategoria> listacategorias = c_categoria.LeerCategoria(1, parametro2_1);

            if (listacategorias.Count > 0)

            {

                foreach (dgCategoria d in listacategorias)
                {
                    bx_categorias.Items.Add(d.Descripcion.ToString());
                }





            }



            bx_medidas.Items.Clear();

            dgMedida parametro4 = new dgMedida
            {

            };

            List<dgMedida> listamedidas = c_medida.LeerMedida(1, parametro4);

            if (listamedidas.Count > 0)

            {

                foreach (dgMedida d in listamedidas)
                {
                    bx_medidas.Items.Add(d.Descripcion.ToString());
                }

            }










        }

        private void  CargaTipoVenta()
        {
            
                dgTipoVenta parametro = new dgTipoVenta();

                List<dgTipoVenta> lista = c_tipoventa.LeerTipoVenta(1, parametro);

                if (lista.Count > 0)

                {

                    foreach (dgTipoVenta d in lista)
                    {
                        bx_tipoventa.Items.Add(d.Descripcion.ToString());
                    }
                }
            

        }


        private void CargaProductosFiltrado(string? nombreproducto,int? idcategoria,int? idmedida)
        {
            dgProducto parametrofiltrado = new dgProducto
            {
                Nombre = nombreproducto,
                Id_Categoria = idcategoria,
                Id_Medida = idmedida,
                Id_Venta=_num_venta
            };

            List<dgProducto> listafiltrado = c_producto.LeerProducto(8, parametrofiltrado);


            int contadorproductos = 0;

            if (listafiltrado.Count > 0)

            {
                flowLayoutPanel_productos.Controls.Clear();
                int idproducto, idcategoriaa, idmedidaa, stock, precioventa;
                string nombre, categoriadescripcion, medidadescripcion, descripcion;
                foreach (dgProducto d in listafiltrado)
                {
                    idproducto = Convert.ToInt16(d.Id_Producto.ToString());
                    idcategoriaa = Convert.ToInt16(d.Id_Categoria.ToString());
                    idmedidaa = Convert.ToInt16(d.Id_Medida.ToString());
                    stock = Convert.ToInt16(d.StockInicial.ToString());
                    descripcion = Convert.ToString(d.Descripcion.ToString());
                    precioventa = Convert.ToInt16(d.PrecioVenta.ToString());
                    nombre = Convert.ToString(d.Nombre.ToString());

                    dgCategoria parametro2 = new dgCategoria
                    {
                        Id_Categoria = Convert.ToInt16(idcategoriaa.ToString())
                    };

                    List<dgCategoria> listacategoria = c_categoria.LeerCategoria(3, parametro2);


                    dgMedida parametro3 = new dgMedida
                    {
                        Id_Medida = Convert.ToInt16(idmedidaa.ToString())
                    };

                    List<dgMedida> listamedida = c_medida.LeerMedida(3, parametro3);

                    if (listacategoria.Count > 0 && listamedida.Count > 0)

                    {
                        categoriadescripcion = "";
                        medidadescripcion = "";
                        foreach (dgCategoria dg in listacategoria)
                        {
                            categoriadescripcion = Convert.ToString(dg.Descripcion.ToString());
                        }

                        foreach (dgMedida dg in listamedida)
                        {
                            medidadescripcion = Convert.ToString(dg.Descripcion.ToString());
                        }

                        UserControlProducto[] Productos = new UserControlProducto[10];


                        contadorproductos = contadorproductos + 1;

                        Productos[contadorproductos] = new UserControlProducto();

                        Productos[contadorproductos].IdProducto = Convert.ToString(idproducto);

                        Productos[contadorproductos].NombreProducto = nombre;

                        Productos[contadorproductos].StockProducto = Convert.ToString(stock);

                        Productos[contadorproductos].DescripcionProducto = descripcion;

                        Productos[contadorproductos].NumVenta = Convert.ToString(_num_venta);

                        Productos[contadorproductos].PrecioProducto = Convert.ToString(precioventa);

                        Productos[contadorproductos].CategoriaProducto = categoriadescripcion;

                        Productos[contadorproductos].MedidaProducto = medidadescripcion;



                        flowLayoutPanel_productos.Controls.Add(Productos[contadorproductos]);



                    }


                }

            }


            else
            {
                MessageBox.Show("No se encontraron resultados");
                flowLayoutPanel_productos.Controls.Clear();
            }










        }
        private void bx_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_aplicar_filtro_Click(object sender, EventArgs e)
        {
            int idCategoria = 0, idMedida = 0;
            string nombreproducto="0";

            if (bx_categorias.Text == "" && bx_medidas.Text == "" && txt_nombre_producto.Text == "")
            {
                MessageBox.Show("Seleccione al menos un filtro para poder filtrar");
            }



            else
            {
                nombreproducto = txt_nombre_producto.Text;
                dgCategoria parametro2_1 = new dgCategoria
                {
                    Descripcion = Convert.ToString(bx_categorias.Text)
                };

                List<dgCategoria> listacategorias = c_categoria.LeerCategoria(2, parametro2_1);

                if (listacategorias.Count > 0)

                {

                    foreach (dgCategoria d in listacategorias)
                    {
                        idCategoria = Convert.ToInt16(d.Id_Categoria.ToString());
                    }

                }


                dgMedida parametro2_2 = new dgMedida
                {
                    Descripcion = Convert.ToString(bx_medidas.Text)
                };

                List<dgMedida> listamedidas = c_medida.LeerMedida(2, parametro2_2);

                if (listamedidas.Count > 0)

                {

                    foreach (dgMedida d in listamedidas)
                    {
                        idMedida = Convert.ToInt16(d.Id_Medida.ToString());
                    }

                }



                



                CargaProductosFiltrado(nombreproducto, idCategoria, idMedida);




            }
        }

        private void btn_reiniciar_filtrado_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_productos.Controls.Clear();

            CargaProductos(0);

            

            txt_nombre_producto.Text = "";

        }



        private void btn_regresar_Click(object sender, EventArgs e)
        {
            string id;
            id = lbl_id.Text;

            string retorno = "", retorno2 = "";

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



            }

            dgVentaDetalle parametroeliminartodos = new dgVentaDetalle
            {
                Id_Venta = _num_venta

            };



            string control = "";



            var confirmResult = MessageBox.Show("Esta seguro de Eliminar toda la Orden",
                                    "Confirm Delete!!",
                                    MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                flowLayoutPanel_Orden.Controls.Clear();
                control = c_ventadetalle.EliminarVentaDetalleTodos(parametroeliminartodos);

                flowLayoutPanel_productos.Controls.Clear();

                lbl_total.Text = "";
                lbl_cambio.Text = "";

                RegresarVentana();
            }

           
        }

        private void btn_reinciar_orden_Click(object sender, EventArgs e)
        {
            


            dgVentaDetalle parametroeliminartodos = new dgVentaDetalle
            {
                Id_Venta = _num_venta

            };



            string control = "";

         

            var confirmResult = MessageBox.Show("Esta seguro de Eliminar toda la Orden",
                                    "Confirm Delete!!",
                                    MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                flowLayoutPanel_Orden.Controls.Clear();
                control = c_ventadetalle.EliminarVentaDetalleTodos(parametroeliminartodos);

                flowLayoutPanel_productos.Controls.Clear();

                CargaProductos(0);

                lbl_total.Text = "";
                lbl_cambio.Text = "";
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_venta_Activated(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel_Orden_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_venta_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void flowLayoutPanel_Orden_Enter(object sender, EventArgs e)
        {

        }

        private void txt_paga_con_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                if (lbl_id_tipoventa.Text == "1" && lbl_total.Text != "")
                {
                    lbl_cambio.Text = "";

                    int total = Convert.ToInt16(lbl_total.Text);

                    int pago = Convert.ToInt32(txt_paga_con.Text);

                    int cambio = pago - total;
                    lbl_cambio.Text = Convert.ToString(cambio);

                    if (pago < total)
                    {

                        lbl_cambio.ForeColor = Color.Red;
                    }

                    else
                    {

                        lbl_cambio.ForeColor = Color.Yellow;
                    }

                }

                else if (lbl_id_tipoventa.Text == "2")
                {
                    lbl_cambio.Text = "";

                    int total = Convert.ToInt16(lbl_total.Text);

                    int pago = Convert.ToInt32(txt_paga_con.Text);

                    int cambio = pago - total;
                    lbl_cambio.Text = Convert.ToString(cambio);

                    if (pago < total)
                    {

                        lbl_cambio.ForeColor = Color.Red;
                    }

                    else
                    {

                        lbl_cambio.ForeColor = Color.Yellow;
                    }

                }

                else if (lbl_id_tipoventa.Text == "3" && lbl_total.Text != "") // credito
                {
                   
                    lbl_cambio.Text = "";

                    int total = Convert.ToInt16(lbl_total.Text);

                    int pago = Convert.ToInt32(txt_paga_con.Text);

                    int cambio = pago - total;
                   

                    if (pago >= total)
                    {

                        MessageBox.Show("No puede abonar mas cantidad o igual de dinero ya que esta en el modulo de credito", "Advertencia");
                        txt_paga_con.Text = "";
                    }

                    else
                    {

                       
                    }

                }










            }
            catch {


                
               
            }
        }

        private void RegresarVentana()
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
            Inicio formulario = new Inicio();
            formulario.lbl_id.Text = id;
            formulario.lbl_perfil.Text = Convert.ToString(retorno2);
            formulario.txt_usuario.Text = Convert.ToString(retorno);
            formulario.Show();



        }

        private void txt_paga_con_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_realizar_venta_Click(object sender, EventArgs e)
        {
            if (lbl_id_tipoventa.Text == "1" && lbl_total.Text != "")
            {
                if (txt_paga_con.Text == "" && lbl_cambio.Text == "")
                {
                    MessageBox.Show("Debe de llenar el campo de pago");

                }
                else
                {

                    int total = Convert.ToInt16(lbl_total.Text);

                    int pago = Convert.ToInt32(txt_paga_con.Text);

                    int cambio = pago - total;
                    lbl_cambio.Text = Convert.ToString(cambio);

                    if (pago < total)
                    {

                        lbl_cambio.ForeColor = Color.Red;
                        MessageBox.Show(" No se puede realizar la venta ");

                    }

                    else
                    {

                        lbl_cambio.ForeColor = Color.Yellow;


                        dgVenta parametro = new dgVenta
                        {
                            Id_Usuario = Convert.ToInt16(lbl_id.Text),
                            FechaVenta = DateTime.Now,
                            Id_Venta = _num_venta,
                            Total = decimal.Parse(lbl_total.Text),
                            Cambio = decimal.Parse(lbl_cambio.Text)


                        };

                        string control = "";

                        control = c_venta.InsertarVentaEfectivo(parametro);


                        dgVenta parametrorestarstock = new dgVenta
                        {

                            Id_Venta = _num_venta,

                        };

                        List<dgVenta> listaproductoscarrito = c_venta.LeerVenta(1, parametrorestarstock);

                        if (listaproductoscarrito.Count > 0)

                        {
                            int idproducto, cantidad;
                            foreach (dgVenta d in listaproductoscarrito)
                            {
                                idproducto = Convert.ToInt16(d.Id_Producto);

                                cantidad = Convert.ToInt16(d.Stock);

                                dgVenta parametrorestarstockrestar = new dgVenta
                                {

                                    Id_Producto = idproducto,
                                    Stock = cantidad

                                };

                                control = "";

                                control = c_venta.ReducirStockProductos(parametrorestarstockrestar);





                            }





                        }



                        MessageBox.Show("Venta Realizada Por Efectivo");

                        RegresarVentana();
                    }
                }


            }


            else if (lbl_id_tipoventa.Text == "2" && lbl_total.Text != "")
            {

                if (txt_nombre_transferencia.Text=="")
                {
                    MessageBox.Show("Ingrese el nombre del cliente para guardarlo en transferencia");
                }
                else
                {
                    dgVenta parametro = new dgVenta
                    {
                        Id_Usuario = Convert.ToInt16(lbl_id.Text),
                        FechaVenta = DateTime.Now,
                        Id_Venta = _num_venta,
                        Total = decimal.Parse(lbl_total.Text),
                        Cambio = 0,
                        NombreTransferencia = txt_nombre_transferencia.Text


                    };

                    string control = "";

                    control = c_venta.InsertarVentaTransferencia(parametro);


                    dgVenta parametrorestarstock = new dgVenta
                    {

                        Id_Venta = _num_venta,

                    };

                    List<dgVenta> listaproductoscarrito = c_venta.LeerVenta(1, parametrorestarstock);

                    if (listaproductoscarrito.Count > 0)

                    {
                        int idproducto, cantidad;
                        foreach (dgVenta d in listaproductoscarrito)
                        {
                            idproducto = Convert.ToInt16(d.Id_Producto);

                            cantidad = Convert.ToInt16(d.Stock);

                            dgVenta parametrorestarstockrestar = new dgVenta
                            {

                                Id_Producto = idproducto,
                                Stock = cantidad

                            };

                            control = "";

                            control = c_venta.ReducirStockProductos(parametrorestarstockrestar);





                        }





                    }



                    MessageBox.Show("Venta Realizada por Transeferencia");

                    RegresarVentana();
                }

                





            }


            else if (lbl_id_tipoventa.Text == "3" && lbl_total.Text != "")
            {
                if (txt_paga_con.Text == "" && lbl_cambio.Text == "")
                {
                    MessageBox.Show("Debe llenar el Campo de pago");
                }
                else if (bx_cliente.Text == "")
                {
                    MessageBox.Show("Seleccione el Cliente para Credito");
                }
                else
                {
                    dgVenta parametro = new dgVenta
                    {
                        Id_Usuario=Convert.ToInt16(lbl_id.Text),
                        Id_Cliente= Convert.ToInt16(lbl_id_cliente.Text),
                        Id_Venta = _num_venta,

                        FechaVenta = DateTime.Now,
                        
                        Total = decimal.Parse(lbl_total.Text),
                        Cambio = 0
                        


                    };

                    
                    string control = "";

                    control = c_venta.InsertarVentaCredito(parametro);


                    dgVenta parametrorestarstock = new dgVenta
                    {

                        Id_Venta = _num_venta,

                    };

                    List<dgVenta> listaproductoscarrito = c_venta.LeerVenta(1, parametrorestarstock);

                    if (listaproductoscarrito.Count > 0)

                    {
                        int idproducto, cantidad;
                        foreach (dgVenta d in listaproductoscarrito)
                        {
                            idproducto = Convert.ToInt16(d.Id_Producto);

                            cantidad = Convert.ToInt16(d.Stock);

                            dgVenta parametrorestarstockrestar = new dgVenta
                            {

                                Id_Producto = idproducto,
                                Stock = cantidad

                            };

                            control = "";

                            control = c_venta.ReducirStockProductos(parametrorestarstockrestar);





                        }


                        dgCredito parametrocredito = new dgCredito
                        {

                            Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                            Id_Venta = _num_venta,
                            FechaRegistro = DateTime.Now,
                            Id_Estatus = 2,

                            CantidadPagada = decimal.Parse(txt_paga_con.Text)





                        };

                        control = "";

                        control = c_credito_venta.InsertarCreditoVenta(parametrocredito);
                        MessageBox.Show("Venta Realizada Por Credito");

                        RegresarVentana();



                    }



                   
                }







            }

            else
            {
                MessageBox.Show("Debe Agregar Productos a la orden ");
            }

            
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void label12_MouseMove(object sender, MouseEventArgs e)
        {
            CargaProductosOrden();
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            CargaProductosOrden();
        }

        private void bx_tipoventa_SelectedIndexChanged(object sender, EventArgs e)
        {
           lbl_id_cliente.Text = "";
           bx_cliente.Items.Clear();
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

            if (lbl_id_tipoventa.Text == "1")
            {
                txt_paga_con.Text = "";
                lbl_clienteonombre.Text = "";  
                bx_cliente.Visible  = false;
                txt_nombre_transferencia.Visible = false;
                lbl_etiqueta_pago.Text = "Paga con:";
                txt_paga_con.Visible = true;
                label11.Text = "Cambio";
                label9.Text = "Total";


            }

            else if (lbl_id_tipoventa.Text == "2")
            {
                lbl_clienteonombre.Text = "Nombre";
                bx_cliente.Visible = false;
                txt_nombre_transferencia.Visible = true;
                lbl_etiqueta_pago.Text = "";
                txt_paga_con.Visible = false;
                label11.Text = "";
                label9.Text = "Total";
                lbl_cambio.Text = "";
            }

            else if (lbl_id_tipoventa.Text == "3")
            {
                txt_paga_con.Text = "";
                lbl_clienteonombre.Text = "Cliente:";
                bx_cliente.Visible = true;
                txt_nombre_transferencia.Visible = false;
                lbl_etiqueta_pago.Text = "Abona con:";
                txt_paga_con.Visible = true;
                label11.Text = "";
                label9.Text = "Total";
                lbl_cambio.Text = "";
                CargaCliente();

            }
        }

        private void CargaCliente()
        {

            dgCliente parametro = new dgCliente();

            List<dgCliente> lista = c_cliente.LeerCliente(1, parametro);

            if (lista.Count > 0)

            {

                foreach (dgCliente d in lista)
                {
                    bx_cliente.Items.Add(d.Nombre.ToString());
                }
            }


        }

        private void bx_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgCliente parametro = new dgCliente
            {
                Nombre = Convert.ToString(bx_cliente.Text)
            };


            List<dgCliente> lista = c_cliente.LeerCliente(2, parametro);

            if (lista.Count > 0)

            {

                foreach (dgCliente d in lista)
                {
                    lbl_id_cliente.Text = d.Id_Cliente.ToString();
                }
            }
        }

        private void lbl_id_tipoventa_Click(object sender, EventArgs e)
        {

        }

        private void txt_paga_con_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
            }
           
        }
    }
}
