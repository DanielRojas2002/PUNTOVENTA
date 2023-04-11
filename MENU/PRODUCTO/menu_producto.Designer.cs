namespace PUNTOVENTA.MENU.PRODUCTO
{
    partial class menu_producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_producto));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_productos_inactivos = new System.Windows.Forms.DataGridView();
            this.Col_IdProducto_Inactivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_productos = new System.Windows.Forms.DataGridView();
            this.Col_IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_codigoproducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_reiniciar_filtrado = new System.Windows.Forms.PictureBox();
            this.bx_medidas = new System.Windows.Forms.ComboBox();
            this.panel_aplicarfiltros = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_aplicar_filtro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bx_proveedores = new System.Windows.Forms.ComboBox();
            this.bx_categorias = new System.Windows.Forms.ComboBox();
            this.btn_agregar_producto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos_inactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reiniciar_filtrado)).BeginInit();
            this.panel_aplicarfiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.medidaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1086, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoriaToolStripMenuItem,
            this.modificarCategoriaToolStripMenuItem,
            this.eliminarCategoriaToolStripMenuItem});
            this.categoriaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.categoriaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            this.agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            this.agregarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.agregarCategoriaToolStripMenuItem.Text = "Agregar Categoria";
            this.agregarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.agregarCategoriaToolStripMenuItem_Click);
            // 
            // modificarCategoriaToolStripMenuItem
            // 
            this.modificarCategoriaToolStripMenuItem.Name = "modificarCategoriaToolStripMenuItem";
            this.modificarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.modificarCategoriaToolStripMenuItem.Text = "Modificar Categoria";
            this.modificarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.modificarCategoriaToolStripMenuItem_Click);
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            this.eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            this.eliminarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.eliminarCategoriaToolStripMenuItem.Text = "Eliminar Categoria";
            this.eliminarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCategoriaToolStripMenuItem_Click);
            // 
            // medidaToolStripMenuItem
            // 
            this.medidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMedidaToolStripMenuItem,
            this.modificarMedidaToolStripMenuItem,
            this.eliminarMedidaToolStripMenuItem});
            this.medidaToolStripMenuItem.Name = "medidaToolStripMenuItem";
            this.medidaToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.medidaToolStripMenuItem.Text = "Medida";
            // 
            // agregarMedidaToolStripMenuItem
            // 
            this.agregarMedidaToolStripMenuItem.Name = "agregarMedidaToolStripMenuItem";
            this.agregarMedidaToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.agregarMedidaToolStripMenuItem.Text = "Agregar Medida";
            this.agregarMedidaToolStripMenuItem.Click += new System.EventHandler(this.agregarMedidaToolStripMenuItem_Click);
            // 
            // modificarMedidaToolStripMenuItem
            // 
            this.modificarMedidaToolStripMenuItem.Name = "modificarMedidaToolStripMenuItem";
            this.modificarMedidaToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.modificarMedidaToolStripMenuItem.Text = "Modificar Medida";
            this.modificarMedidaToolStripMenuItem.Click += new System.EventHandler(this.modificarMedidaToolStripMenuItem_Click);
            // 
            // eliminarMedidaToolStripMenuItem
            // 
            this.eliminarMedidaToolStripMenuItem.Name = "eliminarMedidaToolStripMenuItem";
            this.eliminarMedidaToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.eliminarMedidaToolStripMenuItem.Text = "Eliminar Medida";
            this.eliminarMedidaToolStripMenuItem.Click += new System.EventHandler(this.eliminarMedidaToolStripMenuItem_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(630, 59);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 23);
            this.lbl_id.TabIndex = 47;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            // 
            // lbl_perfil
            // 
            this.lbl_perfil.AutoSize = true;
            this.lbl_perfil.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_perfil.ForeColor = System.Drawing.Color.White;
            this.lbl_perfil.Location = new System.Drawing.Point(695, 59);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(73, 23);
            this.lbl_perfil.TabIndex = 49;
            this.lbl_perfil.Text = "perfil:";
            this.lbl_perfil.Visible = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.txt_usuario.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.ForeColor = System.Drawing.Color.White;
            this.txt_usuario.Location = new System.Drawing.Point(818, 59);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(95, 23);
            this.txt_usuario.TabIndex = 48;
            this.txt_usuario.Text = "usuario:";
            this.txt_usuario.Visible = false;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(37, 43);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(153, 39);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 50;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_productos_inactivos);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView_productos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_agregar_producto);
            this.panel1.Location = new System.Drawing.Point(33, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 596);
            this.panel1.TabIndex = 73;
            // 
            // dataGridView_productos_inactivos
            // 
            this.dataGridView_productos_inactivos.AllowUserToAddRows = false;
            this.dataGridView_productos_inactivos.AllowUserToDeleteRows = false;
            this.dataGridView_productos_inactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productos_inactivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_IdProducto_Inactivo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView_productos_inactivos.Location = new System.Drawing.Point(313, 365);
            this.dataGridView_productos_inactivos.Name = "dataGridView_productos_inactivos";
            this.dataGridView_productos_inactivos.ReadOnly = true;
            this.dataGridView_productos_inactivos.RowHeadersWidth = 51;
            this.dataGridView_productos_inactivos.RowTemplate.Height = 29;
            this.dataGridView_productos_inactivos.Size = new System.Drawing.Size(734, 203);
            this.dataGridView_productos_inactivos.TabIndex = 83;
            this.dataGridView_productos_inactivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productos_inactivos_CellContentClick);
            // 
            // Col_IdProducto_Inactivo
            // 
            this.Col_IdProducto_Inactivo.Frozen = true;
            this.Col_IdProducto_Inactivo.HeaderText = "IdProducto";
            this.Col_IdProducto_Inactivo.MinimumWidth = 6;
            this.Col_IdProducto_Inactivo.Name = "Col_IdProducto_Inactivo";
            this.Col_IdProducto_Inactivo.ReadOnly = true;
            this.Col_IdProducto_Inactivo.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(313, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 32);
            this.label8.TabIndex = 82;
            this.label8.Text = "INACTIVOS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(313, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 32);
            this.label7.TabIndex = 79;
            this.label7.Text = "ACTIVOS:";
            // 
            // dataGridView_productos
            // 
            this.dataGridView_productos.AllowUserToAddRows = false;
            this.dataGridView_productos.AllowUserToDeleteRows = false;
            this.dataGridView_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_IdProducto,
            this.Col_Nombre,
            this.Col_Categoria,
            this.Col_Medida,
            this.Col_Stock});
            this.dataGridView_productos.Location = new System.Drawing.Point(313, 114);
            this.dataGridView_productos.Name = "dataGridView_productos";
            this.dataGridView_productos.ReadOnly = true;
            this.dataGridView_productos.RowHeadersWidth = 51;
            this.dataGridView_productos.RowTemplate.Height = 29;
            this.dataGridView_productos.Size = new System.Drawing.Size(734, 203);
            this.dataGridView_productos.TabIndex = 81;
            this.dataGridView_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productos_CellClick);
            this.dataGridView_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productos_CellContentClick);
            // 
            // Col_IdProducto
            // 
            this.Col_IdProducto.Frozen = true;
            this.Col_IdProducto.HeaderText = "IdProducto";
            this.Col_IdProducto.MinimumWidth = 6;
            this.Col_IdProducto.Name = "Col_IdProducto";
            this.Col_IdProducto.ReadOnly = true;
            this.Col_IdProducto.Width = 125;
            // 
            // Col_Nombre
            // 
            this.Col_Nombre.Frozen = true;
            this.Col_Nombre.HeaderText = "Nombre";
            this.Col_Nombre.MinimumWidth = 6;
            this.Col_Nombre.Name = "Col_Nombre";
            this.Col_Nombre.ReadOnly = true;
            this.Col_Nombre.Width = 125;
            // 
            // Col_Categoria
            // 
            this.Col_Categoria.Frozen = true;
            this.Col_Categoria.HeaderText = "Categoria";
            this.Col_Categoria.MinimumWidth = 6;
            this.Col_Categoria.Name = "Col_Categoria";
            this.Col_Categoria.ReadOnly = true;
            this.Col_Categoria.Width = 125;
            // 
            // Col_Medida
            // 
            this.Col_Medida.Frozen = true;
            this.Col_Medida.HeaderText = "Medida";
            this.Col_Medida.MinimumWidth = 6;
            this.Col_Medida.Name = "Col_Medida";
            this.Col_Medida.ReadOnly = true;
            this.Col_Medida.Width = 125;
            // 
            // Col_Stock
            // 
            this.Col_Stock.Frozen = true;
            this.Col_Stock.HeaderText = "Stock";
            this.Col_Stock.MinimumWidth = 6;
            this.Col_Stock.Name = "Col_Stock";
            this.Col_Stock.ReadOnly = true;
            this.Col_Stock.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-2, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 25);
            this.panel3.TabIndex = 80;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Location = new System.Drawing.Point(286, 54);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(21, 514);
            this.panel16.TabIndex = 79;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_codigoproducto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_nombre_producto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_reiniciar_filtrado);
            this.panel2.Controls.Add(this.bx_medidas);
            this.panel2.Controls.Add(this.panel_aplicarfiltros);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bx_proveedores);
            this.panel2.Controls.Add(this.bx_categorias);
            this.panel2.Location = new System.Drawing.Point(3, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 494);
            this.panel2.TabIndex = 76;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 15);
            this.label10.TabIndex = 90;
            this.label10.Text = "CODIGO ULTIMOS DIGITOS:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_codigoproducto
            // 
            this.txt_codigoproducto.BackColor = System.Drawing.Color.White;
            this.txt_codigoproducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigoproducto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_codigoproducto.ForeColor = System.Drawing.Color.Black;
            this.txt_codigoproducto.Location = new System.Drawing.Point(6, 137);
            this.txt_codigoproducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_codigoproducto.Name = "txt_codigoproducto";
            this.txt_codigoproducto.Size = new System.Drawing.Size(155, 24);
            this.txt_codigoproducto.TabIndex = 89;
            this.txt_codigoproducto.TextChanged += new System.EventHandler(this.txt_codigoproducto_TextChanged);
            this.txt_codigoproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigoproducto_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 15);
            this.label9.TabIndex = 88;
            this.label9.Text = "NOMBRE PRODUCTO:";
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.BackColor = System.Drawing.Color.White;
            this.txt_nombre_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_producto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombre_producto.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre_producto.Location = new System.Drawing.Point(6, 203);
            this.txt_nombre_producto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(195, 24);
            this.txt_nombre_producto.TabIndex = 87;
            this.txt_nombre_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_producto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(144, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 86;
            this.label6.Text = "MEDIDA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 85;
            this.label5.Text = "PROVEEDOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 84;
            this.label4.Text = "CATEGORIA:";
            // 
            // btn_reiniciar_filtrado
            // 
            this.btn_reiniciar_filtrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reiniciar_filtrado.Image = ((System.Drawing.Image)(resources.GetObject("btn_reiniciar_filtrado.Image")));
            this.btn_reiniciar_filtrado.Location = new System.Drawing.Point(33, 13);
            this.btn_reiniciar_filtrado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reiniciar_filtrado.Name = "btn_reiniciar_filtrado";
            this.btn_reiniciar_filtrado.Size = new System.Drawing.Size(218, 53);
            this.btn_reiniciar_filtrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_reiniciar_filtrado.TabIndex = 16;
            this.btn_reiniciar_filtrado.TabStop = false;
            this.btn_reiniciar_filtrado.Click += new System.EventHandler(this.btn_reiniciar_filtrado_Click);
            // 
            // bx_medidas
            // 
            this.bx_medidas.BackColor = System.Drawing.Color.White;
            this.bx_medidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bx_medidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bx_medidas.ForeColor = System.Drawing.Color.Black;
            this.bx_medidas.FormattingEnabled = true;
            this.bx_medidas.Location = new System.Drawing.Point(144, 276);
            this.bx_medidas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bx_medidas.Name = "bx_medidas";
            this.bx_medidas.Size = new System.Drawing.Size(123, 28);
            this.bx_medidas.TabIndex = 83;
            this.bx_medidas.SelectedIndexChanged += new System.EventHandler(this.bx_medidas_SelectedIndexChanged);
            this.bx_medidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bx_medidas_KeyPress);
            // 
            // panel_aplicarfiltros
            // 
            this.panel_aplicarfiltros.Controls.Add(this.pictureBox4);
            this.panel_aplicarfiltros.Controls.Add(this.btn_aplicar_filtro);
            this.panel_aplicarfiltros.Location = new System.Drawing.Point(3, 427);
            this.panel_aplicarfiltros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_aplicarfiltros.Name = "panel_aplicarfiltros";
            this.panel_aplicarfiltros.Size = new System.Drawing.Size(301, 61);
            this.panel_aplicarfiltros.TabIndex = 82;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // btn_aplicar_filtro
            // 
            this.btn_aplicar_filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btn_aplicar_filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_aplicar_filtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aplicar_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aplicar_filtro.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aplicar_filtro.ForeColor = System.Drawing.Color.White;
            this.btn_aplicar_filtro.Location = new System.Drawing.Point(47, 4);
            this.btn_aplicar_filtro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_aplicar_filtro.Name = "btn_aplicar_filtro";
            this.btn_aplicar_filtro.Size = new System.Drawing.Size(227, 53);
            this.btn_aplicar_filtro.TabIndex = 0;
            this.btn_aplicar_filtro.Text = "APLICAR FILTROS";
            this.btn_aplicar_filtro.UseVisualStyleBackColor = false;
            this.btn_aplicar_filtro.Click += new System.EventHandler(this.btn_aplicar_filtro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 79;
            this.label2.Text = "FILTROS:";
            // 
            // bx_proveedores
            // 
            this.bx_proveedores.BackColor = System.Drawing.Color.White;
            this.bx_proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bx_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bx_proveedores.ForeColor = System.Drawing.Color.Black;
            this.bx_proveedores.FormattingEnabled = true;
            this.bx_proveedores.Location = new System.Drawing.Point(6, 350);
            this.bx_proveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bx_proveedores.Name = "bx_proveedores";
            this.bx_proveedores.Size = new System.Drawing.Size(261, 28);
            this.bx_proveedores.TabIndex = 81;
            this.bx_proveedores.SelectedIndexChanged += new System.EventHandler(this.bx_proveedores_SelectedIndexChanged);
            this.bx_proveedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bx_proveedores_KeyPress);
            // 
            // bx_categorias
            // 
            this.bx_categorias.BackColor = System.Drawing.Color.White;
            this.bx_categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bx_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bx_categorias.ForeColor = System.Drawing.Color.Black;
            this.bx_categorias.FormattingEnabled = true;
            this.bx_categorias.Location = new System.Drawing.Point(6, 276);
            this.bx_categorias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bx_categorias.Name = "bx_categorias";
            this.bx_categorias.Size = new System.Drawing.Size(133, 28);
            this.bx_categorias.TabIndex = 79;
            this.bx_categorias.SelectedIndexChanged += new System.EventHandler(this.bx_categorias_SelectedIndexChanged);
            this.bx_categorias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bx_categorias_KeyPress);
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar_producto.Image")));
            this.btn_agregar_producto.Location = new System.Drawing.Point(3, 4);
            this.btn_agregar_producto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(1038, 42);
            this.btn_agregar_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_agregar_producto.TabIndex = 75;
            this.btn_agregar_producto.TabStop = false;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 42);
            this.label1.TabIndex = 76;
            this.label1.Text = "MENU PRODUCTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(614, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 60);
            this.label3.TabIndex = 78;
            this.label3.Text = "Al darle Click en cualquier parte de la celda\r\nse le mostrara una ventana para\r\n " +
    "modificar o eliminar el producto seleccionado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1086, 791);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_perfil);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu_producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu_producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_producto_FormClosing);
            this.Load += new System.EventHandler(this.menu_producto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos_inactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reiniciar_filtrado)).EndInit();
            this.panel_aplicarfiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem agregarCategoriaToolStripMenuItem;
        private ToolStripMenuItem modificarCategoriaToolStripMenuItem;
        private ToolStripMenuItem eliminarCategoriaToolStripMenuItem;
        public Label lbl_id;
        public Label lbl_perfil;
        public Label txt_usuario;
        private ToolStripMenuItem medidaToolStripMenuItem;
        private ToolStripMenuItem agregarMedidaToolStripMenuItem;
        private ToolStripMenuItem modificarMedidaToolStripMenuItem;
        private ToolStripMenuItem eliminarMedidaToolStripMenuItem;
        private PictureBox btn_regresar;
        private Panel panel1;
        private PictureBox btn_agregar_producto;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel2;
        private ComboBox bx_proveedores;
        private ComboBox bx_categorias;
        private Panel panel_aplicarfiltros;
        private PictureBox pictureBox4;
        private Button btn_aplicar_filtro;
        private Panel panel3;
        private Panel panel16;
        private ComboBox bx_medidas;
        private DataGridView dataGridView_productos;
        private DataGridViewTextBoxColumn Col_IdProducto;
        private DataGridViewTextBoxColumn Col_Nombre;
        private DataGridViewTextBoxColumn Col_Categoria;
        private DataGridViewTextBoxColumn Col_Medida;
        private DataGridViewTextBoxColumn Col_Stock;
        private PictureBox btn_reiniciar_filtrado;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private DataGridView dataGridView_productos_inactivos;
        private Label label8;
        private Label label7;
        private Label label9;
        private TextBox txt_nombre_producto;
        private DataGridViewTextBoxColumn Col_IdProducto_Inactivo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label10;
        private TextBox txt_codigoproducto;
    }
}