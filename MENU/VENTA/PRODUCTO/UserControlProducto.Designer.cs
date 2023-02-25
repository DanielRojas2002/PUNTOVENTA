namespace PUNTOVENTA.MENU.VENTA.PRODUCTO
{
    partial class UserControlProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlProducto));
            this.lbl_nombreproducto = new System.Windows.Forms.Label();
            this.lbl_precio_producto = new System.Windows.Forms.Label();
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.txt_cantidad_a_agregar = new System.Windows.Forms.NumericUpDown();
            this.txt_descripcion_producto = new System.Windows.Forms.RichTextBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_categoria_producto = new System.Windows.Forms.Label();
            this.lbl_medida_producto = new System.Windows.Forms.Label();
            this.lbl_id_producto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_stock_disponible = new System.Windows.Forms.Label();
            this.lbl_numventa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_a_agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombreproducto
            // 
            this.lbl_nombreproducto.AutoSize = true;
            this.lbl_nombreproducto.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombreproducto.ForeColor = System.Drawing.Color.White;
            this.lbl_nombreproducto.Location = new System.Drawing.Point(283, 28);
            this.lbl_nombreproducto.Name = "lbl_nombreproducto";
            this.lbl_nombreproducto.Size = new System.Drawing.Size(125, 26);
            this.lbl_nombreproducto.TabIndex = 77;
            this.lbl_nombreproducto.Text = "NOMBRE ";
            // 
            // lbl_precio_producto
            // 
            this.lbl_precio_producto.AutoSize = true;
            this.lbl_precio_producto.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_precio_producto.ForeColor = System.Drawing.Color.White;
            this.lbl_precio_producto.Location = new System.Drawing.Point(295, 230);
            this.lbl_precio_producto.Name = "lbl_precio_producto";
            this.lbl_precio_producto.Size = new System.Drawing.Size(64, 20);
            this.lbl_precio_producto.TabIndex = 79;
            this.lbl_precio_producto.Text = "Precio";
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btn_ordenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ordenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ordenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ordenar.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ordenar.ForeColor = System.Drawing.Color.White;
            this.btn_ordenar.Location = new System.Drawing.Point(269, 278);
            this.btn_ordenar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(330, 53);
            this.btn_ordenar.TabIndex = 80;
            this.btn_ordenar.Text = "ORDENAR";
            this.btn_ordenar.UseVisualStyleBackColor = false;
            this.btn_ordenar.Click += new System.EventHandler(this.btn_ordenar_Click);
            // 
            // txt_cantidad_a_agregar
            // 
            this.txt_cantidad_a_agregar.Location = new System.Drawing.Point(431, 230);
            this.txt_cantidad_a_agregar.Name = "txt_cantidad_a_agregar";
            this.txt_cantidad_a_agregar.Size = new System.Drawing.Size(148, 27);
            this.txt_cantidad_a_agregar.TabIndex = 81;
            this.txt_cantidad_a_agregar.ValueChanged += new System.EventHandler(this.txt_cantidad_a_agregar_ValueChanged);
            // 
            // txt_descripcion_producto
            // 
            this.txt_descripcion_producto.Location = new System.Drawing.Point(279, 66);
            this.txt_descripcion_producto.Name = "txt_descripcion_producto";
            this.txt_descripcion_producto.Size = new System.Drawing.Size(320, 51);
            this.txt_descripcion_producto.TabIndex = 82;
            this.txt_descripcion_producto.Text = "";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(18, 66);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(243, 265);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 102;
            this.pictureBox12.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(408, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 103;
            this.label1.Text = "Cantidad a Ordenar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(279, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 104;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(279, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 105;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(465, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 106;
            this.label4.Text = "Medida:";
            // 
            // lbl_categoria_producto
            // 
            this.lbl_categoria_producto.AutoSize = true;
            this.lbl_categoria_producto.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_categoria_producto.ForeColor = System.Drawing.Color.White;
            this.lbl_categoria_producto.Location = new System.Drawing.Point(295, 143);
            this.lbl_categoria_producto.Name = "lbl_categoria_producto";
            this.lbl_categoria_producto.Size = new System.Drawing.Size(98, 20);
            this.lbl_categoria_producto.TabIndex = 107;
            this.lbl_categoria_producto.Text = "Categoria:";
            // 
            // lbl_medida_producto
            // 
            this.lbl_medida_producto.AutoSize = true;
            this.lbl_medida_producto.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_medida_producto.ForeColor = System.Drawing.Color.White;
            this.lbl_medida_producto.Location = new System.Drawing.Point(478, 143);
            this.lbl_medida_producto.Name = "lbl_medida_producto";
            this.lbl_medida_producto.Size = new System.Drawing.Size(76, 20);
            this.lbl_medida_producto.TabIndex = 108;
            this.lbl_medida_producto.Text = "Medida:";
            // 
            // lbl_id_producto
            // 
            this.lbl_id_producto.AutoSize = true;
            this.lbl_id_producto.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_id_producto.ForeColor = System.Drawing.Color.White;
            this.lbl_id_producto.Location = new System.Drawing.Point(90, 40);
            this.lbl_id_producto.Name = "lbl_id_producto";
            this.lbl_id_producto.Size = new System.Drawing.Size(127, 23);
            this.lbl_id_producto.TabIndex = 109;
            this.lbl_id_producto.Text = "IdProducto";
            this.lbl_id_producto.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(283, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 110;
            this.label5.Text = "Stock Disponible:";
            // 
            // lbl_stock_disponible
            // 
            this.lbl_stock_disponible.AutoSize = true;
            this.lbl_stock_disponible.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_stock_disponible.ForeColor = System.Drawing.Color.White;
            this.lbl_stock_disponible.Location = new System.Drawing.Point(469, 171);
            this.lbl_stock_disponible.Name = "lbl_stock_disponible";
            this.lbl_stock_disponible.Size = new System.Drawing.Size(70, 23);
            this.lbl_stock_disponible.TabIndex = 111;
            this.lbl_stock_disponible.Text = "Stock";
            // 
            // lbl_numventa
            // 
            this.lbl_numventa.AutoSize = true;
            this.lbl_numventa.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_numventa.ForeColor = System.Drawing.Color.White;
            this.lbl_numventa.Location = new System.Drawing.Point(90, 17);
            this.lbl_numventa.Name = "lbl_numventa";
            this.lbl_numventa.Size = new System.Drawing.Size(113, 23);
            this.lbl_numventa.TabIndex = 112;
            this.lbl_numventa.Text = "numventa";
            this.lbl_numventa.Visible = false;
            this.lbl_numventa.Click += new System.EventHandler(this.lbl_numventa_Click);
            // 
            // UserControlProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.lbl_numventa);
            this.Controls.Add(this.lbl_stock_disponible);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_id_producto);
            this.Controls.Add(this.lbl_medida_producto);
            this.Controls.Add(this.lbl_categoria_producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.txt_descripcion_producto);
            this.Controls.Add(this.txt_cantidad_a_agregar);
            this.Controls.Add(this.btn_ordenar);
            this.Controls.Add(this.lbl_precio_producto);
            this.Controls.Add(this.lbl_nombreproducto);
            this.Name = "UserControlProducto";
            this.Size = new System.Drawing.Size(640, 353);
            this.Load += new System.EventHandler(this.UserControlProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_a_agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_nombreproducto;
        private Label lbl_precio_producto;
        private Button btn_ordenar;
        private NumericUpDown txt_cantidad_a_agregar;
        private RichTextBox txt_descripcion_producto;
        private PictureBox pictureBox12;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_categoria_producto;
        private Label lbl_medida_producto;
        private Label lbl_id_producto;
        private Label label5;
        private Label lbl_stock_disponible;
        private Label lbl_numventa;
    }
}
