﻿namespace PUNTOVENTA.MENU.PRODUCTO
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
            this.dataGridView_productos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bx_medidas = new System.Windows.Forms.ComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_aplicar_filtro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bx_proveedores = new System.Windows.Forms.ComboBox();
            this.bx_categorias = new System.Windows.Forms.ComboBox();
            this.btn_agregar_producto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblfiltrados = new System.Windows.Forms.Label();
            this.Col_IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
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
            this.panel1.Controls.Add(this.dataGridView_productos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_agregar_producto);
            this.panel1.Location = new System.Drawing.Point(33, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 477);
            this.panel1.TabIndex = 73;
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
            this.dataGridView_productos.Location = new System.Drawing.Point(304, 74);
            this.dataGridView_productos.Name = "dataGridView_productos";
            this.dataGridView_productos.ReadOnly = true;
            this.dataGridView_productos.RowHeadersWidth = 51;
            this.dataGridView_productos.RowTemplate.Height = 29;
            this.dataGridView_productos.Size = new System.Drawing.Size(734, 403);
            this.dataGridView_productos.TabIndex = 81;
            this.dataGridView_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productos_CellClick);
            this.dataGridView_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productos_CellContentClick);
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
            this.panel16.Location = new System.Drawing.Point(288, 54);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(19, 423);
            this.panel16.TabIndex = 79;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblfiltrados);
            this.panel2.Controls.Add(this.bx_medidas);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bx_proveedores);
            this.panel2.Controls.Add(this.bx_categorias);
            this.panel2.Location = new System.Drawing.Point(3, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 403);
            this.panel2.TabIndex = 76;
            // 
            // bx_medidas
            // 
            this.bx_medidas.BackColor = System.Drawing.Color.White;
            this.bx_medidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bx_medidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bx_medidas.ForeColor = System.Drawing.Color.Black;
            this.bx_medidas.FormattingEnabled = true;
            this.bx_medidas.Location = new System.Drawing.Point(144, 140);
            this.bx_medidas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bx_medidas.Name = "bx_medidas";
            this.bx_medidas.Size = new System.Drawing.Size(133, 28);
            this.bx_medidas.TabIndex = 83;
            this.bx_medidas.SelectedIndexChanged += new System.EventHandler(this.bx_medidas_SelectedIndexChanged);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.pictureBox4);
            this.panel13.Controls.Add(this.btn_aplicar_filtro);
            this.panel13.Location = new System.Drawing.Point(3, 344);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(301, 61);
            this.panel13.TabIndex = 82;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 53);
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
            this.btn_aplicar_filtro.Location = new System.Drawing.Point(80, 4);
            this.btn_aplicar_filtro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_aplicar_filtro.Name = "btn_aplicar_filtro";
            this.btn_aplicar_filtro.Size = new System.Drawing.Size(194, 53);
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
            this.label2.Location = new System.Drawing.Point(73, 33);
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
            this.bx_proveedores.Location = new System.Drawing.Point(0, 229);
            this.bx_proveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bx_proveedores.Name = "bx_proveedores";
            this.bx_proveedores.Size = new System.Drawing.Size(277, 28);
            this.bx_proveedores.TabIndex = 81;
            this.bx_proveedores.SelectedIndexChanged += new System.EventHandler(this.bx_proveedores_SelectedIndexChanged);
            // 
            // bx_categorias
            // 
            this.bx_categorias.BackColor = System.Drawing.Color.White;
            this.bx_categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bx_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bx_categorias.ForeColor = System.Drawing.Color.Black;
            this.bx_categorias.FormattingEnabled = true;
            this.bx_categorias.Location = new System.Drawing.Point(0, 140);
            this.bx_categorias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bx_categorias.Name = "bx_categorias";
            this.bx_categorias.Size = new System.Drawing.Size(133, 28);
            this.bx_categorias.TabIndex = 79;
            this.bx_categorias.SelectedIndexChanged += new System.EventHandler(this.bx_categorias_SelectedIndexChanged);
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
            // lblfiltrados
            // 
            this.lblfiltrados.AutoSize = true;
            this.lblfiltrados.ForeColor = System.Drawing.Color.White;
            this.lblfiltrados.Location = new System.Drawing.Point(17, 271);
            this.lblfiltrados.Name = "lblfiltrados";
            this.lblfiltrados.Size = new System.Drawing.Size(90, 20);
            this.lblfiltrados.TabIndex = 84;
            this.lblfiltrados.Text = "Filtrado por:";
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
            // menu_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1086, 672);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel13.ResumeLayout(false);
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
        private Label label2;
        private ComboBox bx_proveedores;
        private ComboBox bx_categorias;
        private Panel panel13;
        private PictureBox pictureBox4;
        private Button btn_aplicar_filtro;
        private Panel panel3;
        private Panel panel16;
        private ComboBox bx_medidas;
        private DataGridView dataGridView_productos;
        private Label lblfiltrados;
        private DataGridViewTextBoxColumn Col_IdProducto;
        private DataGridViewTextBoxColumn Col_Nombre;
        private DataGridViewTextBoxColumn Col_Categoria;
        private DataGridViewTextBoxColumn Col_Medida;
        private DataGridViewTextBoxColumn Col_Stock;
    }
}