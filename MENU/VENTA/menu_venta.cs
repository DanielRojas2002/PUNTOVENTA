using Punto_de_Venta;
using Punto_de_Venta.Clases;
using PUNTOVENTA.CLASES;
using PUNTOVENTA.ENTIDAD;
using PUNTOVENTA.MENU.CLIENTE;
using PUNTOVENTA.MENU.CLIENTE.CREDITO;
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
using TextBox = System.Windows.Forms.TextBox;

namespace PUNTOVENTA.MENU.VENTA
{
    public partial class menu_venta : Form
    {
        public menu_venta()
        {
            InitializeComponent();


        }

        public int _num_venta;
        public int _cantidad_productos;


        private void flowLayoutPanel_productos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_venta_Load(object sender, EventArgs e)
        {
            _num_venta = NumeroVenta();
            CargaCantidadProductos(_num_venta);
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

        private void CargaCantidadProductos(int idventa)
        {
            dgProducto parametro = new dgProducto
            {
                Id_Venta = _num_venta
            };

            List<dgProducto> cantidadproductos = c_producto.LeerProducto(12, parametro);

           
            if (cantidadproductos.Count > 0)

            {
              
                foreach (dgProducto d in cantidadproductos)
                {

                    _cantidad_productos =Convert.ToInt16( d.CantidadProductos.ToString())+1;
                }
            }
           
        }

        private void CargaSubTotal(float total)
        {
            lbl_total.Text = Convert.ToString(total);
        }

        public void CargaProductosOrden()
        {


          
            flowLayoutPanel_Orden.Controls.Clear();

            txt_codigoproducto.Text = "";
            txt_nombre_producto.Text = "";


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

                int  stock;
                string nombre, idproducto;
                float precioventa, subtotal, total=0;
                foreach (dgVentaDetalle d in listaorden)
                {
                    idproducto = Convert.ToString(d.Id_Producto.ToString());

                    stock = Convert.ToInt16(d.CantidadAComprar.ToString());

                    precioventa = float.Parse(d.PrecioVenta.ToString());

                    nombre = Convert.ToString(d.Nombre.ToString());




                    UserControlOrdenCompra[] Productos = new UserControlOrdenCompra[_cantidad_productos];


                    contadorproductos = contadorproductos + 1;

                    Productos[contadorproductos] = new UserControlOrdenCompra();

                    Productos[contadorproductos].IdProducto = Convert.ToString(idproducto);

                    Productos[contadorproductos].IdVenta = Convert.ToString(_num_venta);

                    Productos[contadorproductos].NombreProducto = nombre;

                    Productos[contadorproductos].StockProductoComprar = Convert.ToString(stock);

                    Productos[contadorproductos].PrecioProducto = Convert.ToString(precioventa);

                    subtotal = (float)Math.Round(precioventa * stock,2);
                   

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






            Cursor.Position = new Point(600, 120);

            

       







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
                int  idcategoria, idmedida, stock;
                float precioventa,iva,precioventamasiva;
                string nombre, categoriadescripcion, medidadescripcion, descripcion, idproducto;
                foreach (dgProducto d in lista)
                {
                    idproducto = Convert.ToString(d.Id_Producto.ToString());
                    idcategoria = Convert.ToInt16(d.Id_Categoria.ToString());
                    idmedida = Convert.ToInt16(d.Id_Medida.ToString());
                    stock = Convert.ToInt16(d.StockInicial.ToString());
                    descripcion = Convert.ToString(d.Descripcion.ToString());
                    precioventa = float.Parse(d.PrecioVenta.ToString());
                    nombre = Convert.ToString(d.Nombre.ToString());
                    iva = float.Parse(d.Iva.ToString());


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

                        UserControlProducto[] Productos = new UserControlProducto[_cantidad_productos];
                       

                        contadorproductos = contadorproductos + 1;

                        Productos[contadorproductos] = new UserControlProducto();

                        Productos[contadorproductos].IdProducto = Convert.ToString(idproducto);

                        Productos[contadorproductos].NombreProducto = nombre;

                        Productos[contadorproductos].StockProducto = Convert.ToString(stock);

                        Productos[contadorproductos].DescripcionProducto = descripcion;

                        Productos[contadorproductos].NumVenta = Convert.ToString(_num_venta);

                        precioventamasiva = iva + precioventa;
                        Productos[contadorproductos].PrecioProducto = Convert.ToString(precioventamasiva);

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


        private void CargaProductosFiltrado(string? idproducto2,string? nombreproducto,int? idcategoria,int? idmedida)
        {
            dgProducto parametrofiltrado = new dgProducto
            {
                Id_Producto = idproducto2,
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
                int idcategoriaa, idmedidaa, stock;
                float precioventa,iva,preciomasiva;
                string nombre, categoriadescripcion, medidadescripcion, descripcion, idproducto;
                foreach (dgProducto d in listafiltrado)
                {
                    idproducto = Convert.ToString(d.Id_Producto.ToString());
                    idcategoriaa = Convert.ToInt16(d.Id_Categoria.ToString());
                    idmedidaa = Convert.ToInt16(d.Id_Medida.ToString());
                    stock = Convert.ToInt16(d.StockInicial.ToString());
                    descripcion = Convert.ToString(d.Descripcion.ToString());
                    precioventa = float.Parse(d.PrecioVenta.ToString());
                    nombre = Convert.ToString(d.Nombre.ToString());
                    iva = float.Parse(d.Iva.ToString());

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

                        UserControlProducto[] Productos = new UserControlProducto[_cantidad_productos];


                        contadorproductos = contadorproductos + 1;

                        Productos[contadorproductos] = new UserControlProducto();

                        Productos[contadorproductos].IdProducto = Convert.ToString(idproducto);

                        Productos[contadorproductos].NombreProducto = nombre;

                        Productos[contadorproductos].StockProducto = Convert.ToString(stock);

                        Productos[contadorproductos].DescripcionProducto = descripcion;

                        Productos[contadorproductos].NumVenta = Convert.ToString(_num_venta);

                        preciomasiva = precioventa + iva;
                        Productos[contadorproductos].PrecioProducto = Convert.ToString(preciomasiva);

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
            string nombreproducto="0", idproducto="0";

            if (txt_codigoproducto.Text == "" && bx_categorias.Text == "" && bx_medidas.Text == "" && txt_nombre_producto.Text == "")
            {
                MessageBox.Show("Seleccione al menos un filtro para poder filtrar");
            }



            else
            {
                nombreproducto = txt_nombre_producto.Text;
                idproducto = txt_codigoproducto.Text;


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

              



                CargaProductosFiltrado(idproducto,nombreproducto, idCategoria, idMedida);




            }
        }

        private void btn_reiniciar_filtrado_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_productos.Controls.Clear();

            CargaProductos(0);

            

            txt_nombre_producto.Text = "";
            txt_codigoproducto.Text = "";

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
                txt_paga_con.Text = "";

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

                    float total = float.Parse(lbl_total.Text);

                    float pago = float.Parse(txt_paga_con.Text);

                    float cambio = pago - total;
                    cambio = (float)Math.Round(cambio,2);
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

                    float total = float.Parse(lbl_total.Text);

                    float pago = float.Parse(txt_paga_con.Text);

                    float cambio = pago - total;
                    cambio = (float)Math.Round(cambio, 2);
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

                    float total = float.Parse(lbl_total.Text);

                    float pago = float.Parse(txt_paga_con.Text);

                  


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

            string impresora = "";
            dgImpresora parametroimpresora = new dgImpresora
            {



            };

            List<dgImpresora> listaimpresora = c_impresora.LeerImpresora(1, parametroimpresora);

            if (listaimpresora.Count > 0)

            {


                foreach (dgImpresora d in listaimpresora)
                {

                    impresora = d.NombreImpresora.ToString();

                }
            }

            if (lbl_id_tipoventa.Text == "1" && lbl_total.Text != "")
            {
                if (txt_paga_con.Text == "" && lbl_cambio.Text == "")
                {
                    MessageBox.Show("Debe de llenar el campo de pago");

                }
                else
                {

                    float total = float.Parse(lbl_total.Text);

                    float pago = float.Parse(txt_paga_con.Text);

                    float cambio = pago - total;
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
                            int cantidad;
                            string idproducto;
                            foreach (dgVenta d in listaproductoscarrito)
                            {
                                idproducto = Convert.ToString(d.Id_Producto);

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


                        clsventas.CreaRecibo Ticket1 = new clsventas.CreaRecibo();


                        dgTicket parametroticketinfo = new dgTicket
                        {
                        };

                        List<dgTicket> listaticketinfo = c_ticket.Ticket(0, parametroticketinfo);


                        if (listaticketinfo.Count > 0)

                        {


                            foreach (dgTicket d in listaticketinfo)
                            {
                                Ticket1.TextoCentro(d.NombreEmpresa.ToUpper().ToString());
                                Ticket1.TextoIzquierda("Numero de Venta: " + _num_venta);
                                Ticket1.TextoCentro("==================================");
                                Ticket1.TextoIzquierda("Direccion: " + d.Direccion.ToUpper().ToString());
                                Ticket1.TextoIzquierda("Celular: " + d.Telefono.ToString());
                                Ticket1.TextoIzquierda("");
                            }


                            Ticket1.TextoCentro("Recibo de venta realizada por Efectivo");
                            Ticket1.TextoCentro("Los Precios ya contienen IVA");
                            Ticket1.TextoIzquierda("Nombre del cliente: Cliente Efectivo");

                            Ticket1.TextoIzquierda(" -> Fecha de venta: " + DateTime.Now.ToShortDateString() + "  ->Hora: " + DateTime.Now.ToShortTimeString());
                            Ticket1.TextoIzquierda("");
                        }


                        clsventas.CreaRecibo.LineasGuion();

                        clsventas.CreaRecibo.EncabezadoVenta();


                        dgTicket parametroticket = new dgTicket
                        {
                            Id_Venta = _num_venta
                        };

                        List<dgTicket> listaProductosVenta = c_ticket.Ticket(1, parametroticket);


                        if (listaProductosVenta.Count > 0)

                        {



                            string concatenacion = "";
                            double subtotal, sub;
                            foreach (dgTicket d in listaProductosVenta)
                            {
                                sub = double.Parse(d.SubTotal.ToString());

                                subtotal = (double)Math.Round(sub, 2);


                                concatenacion = "(" + d.Id_Producto.ToString() + ")" + " " + d.NombreProducto.ToString();
                                Ticket1.AgregaArticulo(concatenacion, double.Parse(d.PrecioComprado.ToString()), Convert.ToInt16(d.CantidadComprada.ToString()), double.Parse(subtotal.ToString()));
                                clsventas.CreaRecibo.LineasGuion();
                            }
                        }

                        Ticket1.TextoIzquierda(" ");
                        Ticket1.AgregaTotales("Total", double.Parse(lbl_total.Text));
                        Ticket1.TextoIzquierda(" ");
                        Ticket1.AgregaTotales("Pagado con :", double.Parse(txt_paga_con.Text));
                        Ticket1.AgregaTotales("Cambio a dar:", double.Parse(lbl_cambio.Text));

                        if (listaticketinfo.Count > 0)

                        {
                            Ticket1.TextoIzquierda(" ");
                            Ticket1.TextoCentro("=================================================");

                            foreach (dgTicket d in listaticketinfo)
                            {

                                Ticket1.TextoCentro(d.Mensaje.ToUpper().ToString());



                            }
                            Ticket1.TextoCentro("===================================================");
                            Ticket1.TextoIzquierda(" ");


                        }



                       
                        Ticket1.ImprimirTiket(impresora);
                        MessageBox.Show("Venta Realizada Por Efectivo");

                        RegresarVentana();
                    }
                }


            }


            else if (lbl_id_tipoventa.Text == "2" && lbl_total.Text != "")
            {

                if (txt_nombre_transferencia.Text == "")
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
                        int cantidad;
                        string idproducto;
                        foreach (dgVenta d in listaproductoscarrito)
                        {
                            idproducto = Convert.ToString(d.Id_Producto);

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


                    clsventas.CreaRecibo Ticket1 = new clsventas.CreaRecibo();



                    dgTicket parametroticketinfo = new dgTicket
                    {
                    };

                    List<dgTicket> listaticketinfo = c_ticket.Ticket(0, parametroticketinfo);


                    if (listaticketinfo.Count > 0)

                    {


                        foreach (dgTicket d in listaticketinfo)
                        {
                            Ticket1.TextoCentro(d.NombreEmpresa.ToUpper().ToString());
                            Ticket1.TextoIzquierda("Numero de Venta: " + _num_venta);
                            Ticket1.TextoCentro("==================================");
                            Ticket1.TextoIzquierda("Direccion: " + d.Direccion.ToUpper().ToString());
                            Ticket1.TextoIzquierda("Celular: " + d.Telefono.ToString());
                            Ticket1.TextoIzquierda("");
                        }


                        Ticket1.TextoCentro("Recibo de venta realizada por Transferencia");
                        Ticket1.TextoCentro("Los Precios ya contienen IVA");
                        Ticket1.TextoIzquierda("Nombre del cliente: " + txt_nombre_transferencia.Text);

                        Ticket1.TextoIzquierda(" -> Fecha de venta: " + DateTime.Now.ToShortDateString() + "  ->Hora: " + DateTime.Now.ToShortTimeString());
                        Ticket1.TextoIzquierda("");
                    }


                    clsventas.CreaRecibo.LineasGuion();

                    clsventas.CreaRecibo.EncabezadoVenta();


                    dgTicket parametroticket = new dgTicket
                    {
                        Id_Venta = _num_venta
                    };

                    List<dgTicket> listaProductosVenta = c_ticket.Ticket(1, parametroticket);


                    if (listaProductosVenta.Count > 0)

                    {

                        string concatenacion = "";
                        double subtotal, sub;
                        foreach (dgTicket d in listaProductosVenta)
                        {
                            sub = double.Parse(d.SubTotal.ToString());

                            subtotal = (double)Math.Round(sub, 2);


                            concatenacion = "(" + d.Id_Producto.ToString() + ")" + " " + d.NombreProducto.ToString();
                            Ticket1.AgregaArticulo(concatenacion, double.Parse(d.PrecioComprado.ToString()), Convert.ToInt16(d.CantidadComprada.ToString()), double.Parse(subtotal.ToString()));
                            clsventas.CreaRecibo.LineasGuion();
                        }
                    }

                    Ticket1.TextoIzquierda(" ");
                    Ticket1.AgregaTotales("Total", double.Parse(lbl_total.Text));
                    Ticket1.TextoIzquierda(" ");
                    Ticket1.TextoCentro("Pagado Por Transferencia a Nombre de :" + txt_nombre_transferencia.Text);


                    if (listaticketinfo.Count > 0)

                    {
                        Ticket1.TextoIzquierda(" ");
                        Ticket1.TextoCentro("=================================================");

                        foreach (dgTicket d in listaticketinfo)
                        {

                            Ticket1.TextoCentro(d.Mensaje.ToUpper().ToString());



                        }
                        Ticket1.TextoCentro("===================================================");
                        Ticket1.TextoIzquierda(" ");


                    }



                  
                    Ticket1.ImprimirTiket(impresora);


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
                   
                    dgCliente parametrodatoscliente = new dgCliente
                    {

                        Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text )

                    };

                    List<dgCliente> listadatoscliente = c_cliente.LeerCliente(3, parametrodatoscliente);

                    string concatanacionnombre = "", concatenacionotrosdatos = "",titulomsj="",carateres="--------------------------------------";

                    string concatenacionfinal = "",concatenaciondatosventa="";

                    float debemsj = float.Parse(lbl_total.Text) - float.Parse(txt_paga_con.Text);

                    if (listadatoscliente.Count > 0)

                    {
                            

                        foreach (dgCliente d in listadatoscliente)
                        {
                            titulomsj = "SOLICTUD DE CREDITO " + "\n";
                            concatanacionnombre = "Nombre Completo: " + d.Nombre.ToString() + " " + d.Apellido_Paterno.ToString() + " " + d.Apellido_Materno.ToString()+ "\n";
                            concatenacionotrosdatos = "Domicilio: " + d.Direccion.ToString() +"\n"+ "Telefono: "  + d.Telefono.ToString() + "\n" +"Correo: "+ d.Correo.ToString() + "\n";
                            concatenaciondatosventa = "Total del Credito: " + lbl_total.Text +"\n" + "Total Abonado: "+ txt_paga_con.Text + "\n" + "Falta por pagar: " + Convert.ToString(debemsj) ;
                        }
                        concatenacionfinal = titulomsj +carateres+"\n"+ concatanacionnombre + concatenacionotrosdatos+ carateres+"\n"+concatenaciondatosventa;
                    }


                    var confirmResult = MessageBox.Show(concatenacionfinal,
                        "Confirmar Venta Por Credito!!",
                        MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {

                        dgVenta parametro = new dgVenta
                        {
                            Id_Usuario = Convert.ToInt16(lbl_id.Text),
                            Id_Cliente = Convert.ToInt16(lbl_id_cliente.Text),
                            Id_Venta = _num_venta,

                            FechaVenta = DateTime.Now,
                            FechaUltimoPago = DateTime.Now,

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
                            int cantidad;
                            string idproducto;
                            foreach (dgVenta d in listaproductoscarrito)
                            {
                                idproducto = Convert.ToString(d.Id_Producto);

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
                                FechaUltimoPago = DateTime.Now,
                                Id_Estatus = 2,

                                CantidadPagada = decimal.Parse(txt_paga_con.Text)
                               





                            };

                            control = "";

                            control = c_credito_venta.InsertarCreditoVenta(parametrocredito);

                            clsventas.CreaRecibo Ticket1 = new clsventas.CreaRecibo();


                            dgTicket parametroticketinfo = new dgTicket
                            {
                            };

                            List<dgTicket> listaticketinfo = c_ticket.Ticket(0, parametroticketinfo);



                            if (listaticketinfo.Count > 0)

                            {


                                foreach (dgTicket d in listaticketinfo)
                                {
                                    Ticket1.TextoCentro(d.NombreEmpresa.ToUpper().ToString());
                                    Ticket1.TextoIzquierda("Numero de Venta: " + _num_venta);
                                    Ticket1.TextoCentro("==================================");
                                    Ticket1.TextoIzquierda("Direccion: " + d.Direccion.ToUpper().ToString());
                                    Ticket1.TextoIzquierda("Celular: " + d.Telefono.ToString());
                                    Ticket1.TextoIzquierda("");
                                }


                                Ticket1.TextoCentro("Recibo de venta realizada por Credito");
                                Ticket1.TextoCentro("Los Precios ya contienen IVA");
                                Ticket1.TextoIzquierda("Nombre del cliente: " + bx_cliente.Text);

                                Ticket1.TextoIzquierda(" -> Fecha de venta: " + DateTime.Now.ToShortDateString() + "  ->Hora: " + DateTime.Now.ToShortTimeString());
                                Ticket1.TextoIzquierda("");
                            }


                            clsventas.CreaRecibo.LineasGuion();

                            clsventas.CreaRecibo.EncabezadoVenta();


                            dgTicket parametroticket = new dgTicket
                            {
                                Id_Venta = _num_venta
                            };

                            List<dgTicket> listaProductosVenta = c_ticket.Ticket(1, parametroticket);


                            if (listaProductosVenta.Count > 0)

                            {

                                string concatenacion = "";
                                double subtotal, sub;
                                foreach (dgTicket d in listaProductosVenta)
                                {
                                    sub = double.Parse(d.SubTotal.ToString());

                                    subtotal = (double)Math.Round(sub, 2);


                                    concatenacion = "(" + d.Id_Producto.ToString() + ")" + " " + d.NombreProducto.ToString();
                                    Ticket1.AgregaArticulo(concatenacion, double.Parse(d.PrecioComprado.ToString()), Convert.ToInt16(d.CantidadComprada.ToString()), double.Parse(subtotal.ToString()));
                                    clsventas.CreaRecibo.LineasGuion();
                                }
                            }

                            Ticket1.TextoIzquierda(" ");
                            Ticket1.AgregaTotales("Total", double.Parse(lbl_total.Text));


                            Ticket1.TextoIzquierda(" ");
                            Ticket1.AgregaTotales("Abonado con :", double.Parse(txt_paga_con.Text));

                            Ticket1.TextoIzquierda(" ");

                            float debe = float.Parse(lbl_total.Text) - float.Parse(txt_paga_con.Text);
                            Ticket1.AgregaTotales("Cantidad que falta por pagar: ", debe);


                            if (listaticketinfo.Count > 0)

                            {
                                Ticket1.TextoIzquierda(" ");
                                Ticket1.TextoCentro("=================================================");

                                foreach (dgTicket d in listaticketinfo)
                                {

                                    Ticket1.TextoCentro(d.Mensaje.ToUpper().ToString());



                                }
                                Ticket1.TextoCentro("===================================================");
                                Ticket1.TextoIzquierda(" ");


                            }



                            
                            Ticket1.ImprimirTiket(impresora);


                            MessageBox.Show("Venta Realizada Por Credito");
                            RegresarVentana();
                        }
                        else
                        {

                        }





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
           // CargaProductosOrden();
        }

        public void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            CargaProductosOrden();

            string p = "";
            p = this.PointToClient(Cursor.Position).ToString();

            MessageBox.Show(p);

            Cursor.Position = new Point(500, 500);

       
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
                
                string concatenacion = "";
                foreach (dgCliente d in lista)
                {
                    concatenacion = "";

                    concatenacion = d.Id_Cliente.ToString()+" "+d.Nombre.ToString() +" "+ d.Apellido_Paterno.ToString() +" " + d.Apellido_Materno.ToString();

                    bx_cliente.Items.Add(concatenacion);
                }
            }


        }

        private void bx_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string concatenacion = bx_cliente.Text;
            string[] words = concatenacion.Split(' ');
            string idcliente;
            idcliente = words[0];


            lbl_id_cliente.Text = idcliente;

         
        }

        private void lbl_id_tipoventa_Click(object sender, EventArgs e)
        {

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
            // Cambia de campo para escribir
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btn_realizar_venta.Focus();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_nombre_transferencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void bx_medidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void menu_venta_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void menu_venta_Click(object sender, EventArgs e)
        {
            
        }
    }
}
