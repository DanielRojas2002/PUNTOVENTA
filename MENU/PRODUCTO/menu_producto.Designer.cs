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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_aplicar_filtro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bx_proveedores = new System.Windows.Forms.ComboBox();
            this.bx_categorias = new System.Windows.Forms.ComboBox();
            this.datagrid_productos = new System.Windows.Forms.DataGridView();
            this.btn_agregar_producto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bx_medidas = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_productos)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
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
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            this.agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            this.agregarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.agregarCategoriaToolStripMenuItem.Text = "Agregar Categoria";
            this.agregarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.agregarCategoriaToolStripMenuItem_Click);
            // 
            // modificarCategoriaToolStripMenuItem
            // 
            this.modificarCategoriaToolStripMenuItem.Name = "modificarCategoriaToolStripMenuItem";
            this.modificarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.modificarCategoriaToolStripMenuItem.Text = "Modificar Categoria";
            this.modificarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.modificarCategoriaToolStripMenuItem_Click);
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            this.eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            this.eliminarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
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
            this.medidaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.medidaToolStripMenuItem.Text = "Medida";
            // 
            // agregarMedidaToolStripMenuItem
            // 
            this.agregarMedidaToolStripMenuItem.Name = "agregarMedidaToolStripMenuItem";
            this.agregarMedidaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.agregarMedidaToolStripMenuItem.Text = "Agregar Medida";
            this.agregarMedidaToolStripMenuItem.Click += new System.EventHandler(this.agregarMedidaToolStripMenuItem_Click);
            // 
            // modificarMedidaToolStripMenuItem
            // 
            this.modificarMedidaToolStripMenuItem.Name = "modificarMedidaToolStripMenuItem";
            this.modificarMedidaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.modificarMedidaToolStripMenuItem.Text = "Modificar Medida";
            this.modificarMedidaToolStripMenuItem.Click += new System.EventHandler(this.modificarMedidaToolStripMenuItem_Click);
            // 
            // eliminarMedidaToolStripMenuItem
            // 
            this.eliminarMedidaToolStripMenuItem.Name = "eliminarMedidaToolStripMenuItem";
            this.eliminarMedidaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.eliminarMedidaToolStripMenuItem.Text = "Eliminar Medida";
            this.eliminarMedidaToolStripMenuItem.Click += new System.EventHandler(this.eliminarMedidaToolStripMenuItem_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(551, 44);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(25, 19);
            this.lbl_id.TabIndex = 47;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            // 
            // lbl_perfil
            // 
            this.lbl_perfil.AutoSize = true;
            this.lbl_perfil.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_perfil.ForeColor = System.Drawing.Color.White;
            this.lbl_perfil.Location = new System.Drawing.Point(608, 44);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(61, 19);
            this.lbl_perfil.TabIndex = 49;
            this.lbl_perfil.Text = "perfil:";
            this.lbl_perfil.Visible = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.txt_usuario.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.ForeColor = System.Drawing.Color.White;
            this.txt_usuario.Location = new System.Drawing.Point(716, 44);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(78, 19);
            this.txt_usuario.TabIndex = 48;
            this.txt_usuario.Text = "usuario:";
            this.txt_usuario.Visible = false;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(32, 32);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(134, 29);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 50;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.datagrid_productos);
            this.panel1.Controls.Add(this.btn_agregar_producto);
            this.panel1.Location = new System.Drawing.Point(29, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 344);
            this.panel1.TabIndex = 73;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-2, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 15);
            this.panel3.TabIndex = 80;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Location = new System.Drawing.Point(252, 31);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(17, 312);
            this.panel16.TabIndex = 79;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bx_medidas);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bx_proveedores);
            this.panel2.Controls.Add(this.bx_categorias);
            this.panel2.Location = new System.Drawing.Point(3, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 298);
            this.panel2.TabIndex = 76;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.pictureBox4);
            this.panel13.Controls.Add(this.btn_aplicar_filtro);
            this.panel13.Location = new System.Drawing.Point(3, 250);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(263, 46);
            this.panel13.TabIndex = 82;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 40);
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
            this.btn_aplicar_filtro.Location = new System.Drawing.Point(70, 3);
            this.btn_aplicar_filtro.Name = "btn_aplicar_filtro";
            this.btn_aplicar_filtro.Size = new System.Drawing.Size(170, 40);
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
            this.label2.Location = new System.Drawing.Point(64, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
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
            this.bx_proveedores.Location = new System.Drawing.Point(0, 172);
            this.bx_proveedores.Name = "bx_proveedores";
            this.bx_proveedores.Size = new System.Drawing.Size(243, 23);
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
            this.bx_categorias.Location = new System.Drawing.Point(0, 105);
            this.bx_categorias.Name = "bx_categorias";
            this.bx_categorias.Size = new System.Drawing.Size(117, 23);
            this.bx_categorias.TabIndex = 79;
            this.bx_categorias.SelectedIndexChanged += new System.EventHandler(this.bx_categorias_SelectedIndexChanged);
            // 
            // datagrid_productos
            // 
            this.datagrid_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_productos.Location = new System.Drawing.Point(268, 46);
            this.datagrid_productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagrid_productos.Name = "datagrid_productos";
            this.datagrid_productos.RowHeadersWidth = 51;
            this.datagrid_productos.RowTemplate.Height = 29;
            this.datagrid_productos.Size = new System.Drawing.Size(522, 296);
            this.datagrid_productos.TabIndex = 0;
            this.datagrid_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_productos_CellClick);
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar_producto.Image")));
            this.btn_agregar_producto.Location = new System.Drawing.Point(3, 3);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(786, 22);
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
            this.label1.Location = new System.Drawing.Point(165, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 35);
            this.label1.TabIndex = 76;
            this.label1.Text = "MENU PRODUCTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 68);
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
            this.label3.Location = new System.Drawing.Point(537, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 45);
            this.label3.TabIndex = 78;
            this.label3.Text = "Al darle Click en cualquier parte de la celda\r\nse le mostrara una ventana para\r\n " +
    "modificar o eliminar el producto seleccionado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bx_medidas
            // 
            this.bx_medidas.BackColor = System.Drawing.Color.White;
            this.bx_medidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bx_medidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bx_medidas.ForeColor = System.Drawing.Color.Black;
            this.bx_medidas.FormattingEnabled = true;
            this.bx_medidas.Location = new System.Drawing.Point(126, 105);
            this.bx_medidas.Name = "bx_medidas";
            this.bx_medidas.Size = new System.Drawing.Size(117, 23);
            this.bx_medidas.TabIndex = 83;
            this.bx_medidas.SelectedIndexChanged += new System.EventHandler(this.bx_medidas_SelectedIndexChanged);
            // 
            // menu_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(842, 500);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "menu_producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu_producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_producto_FormClosing);
            this.Load += new System.EventHandler(this.menu_producto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_productos)).EndInit();
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
        private DataGridView datagrid_productos;
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
    }
}