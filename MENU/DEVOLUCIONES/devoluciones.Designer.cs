namespace PUNTOVENTA.MENU.DEVOLUCIONES
{
    partial class devoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(devoluciones));
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.dataGridView_ventas = new System.Windows.Forms.DataGridView();
            this.Col_Id_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SubTotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_FechaVentaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Tipoventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_ticket = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ticket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_dinero_a_devolver = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cerrarapp = new System.Windows.Forms.PictureBox();
            this.btn_minimzar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimzar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(12, 60);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(220, 35);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 55;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(368, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 46);
            this.label1.TabIndex = 57;
            this.label1.Text = "DEVOLUCIONES";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(304, 110);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 23);
            this.lbl_id.TabIndex = 65;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            // 
            // dataGridView_ventas
            // 
            this.dataGridView_ventas.AllowUserToAddRows = false;
            this.dataGridView_ventas.AllowUserToDeleteRows = false;
            this.dataGridView_ventas.AllowUserToOrderColumns = true;
            this.dataGridView_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id_Venta,
            this.Col_IdProducto,
            this.Col_NombreProducto,
            this.Col_PrecioProducto,
            this.Col_CantidadProducto,
            this.Col_SubTotalProducto,
            this.Col_FechaVentaProducto,
            this.Col_Tipoventa,
            this.Col_Check});
            this.dataGridView_ventas.Location = new System.Drawing.Point(55, 268);
            this.dataGridView_ventas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_ventas.Name = "dataGridView_ventas";
            this.dataGridView_ventas.RowHeadersWidth = 51;
            this.dataGridView_ventas.RowTemplate.Height = 25;
            this.dataGridView_ventas.Size = new System.Drawing.Size(994, 222);
            this.dataGridView_ventas.TabIndex = 98;
            this.dataGridView_ventas.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_ventas_CellBeginEdit);
            this.dataGridView_ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ventas_CellContentClick);
            // 
            // Col_Id_Venta
            // 
            this.Col_Id_Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Col_Id_Venta.Frozen = true;
            this.Col_Id_Venta.HeaderText = "No. Venta";
            this.Col_Id_Venta.MinimumWidth = 3;
            this.Col_Id_Venta.Name = "Col_Id_Venta";
            this.Col_Id_Venta.Width = 102;
            // 
            // Col_IdProducto
            // 
            this.Col_IdProducto.Frozen = true;
            this.Col_IdProducto.HeaderText = "Producto";
            this.Col_IdProducto.MinimumWidth = 6;
            this.Col_IdProducto.Name = "Col_IdProducto";
            this.Col_IdProducto.Width = 98;
            // 
            // Col_NombreProducto
            // 
            this.Col_NombreProducto.Frozen = true;
            this.Col_NombreProducto.HeaderText = "Nombre";
            this.Col_NombreProducto.MinimumWidth = 6;
            this.Col_NombreProducto.Name = "Col_NombreProducto";
            this.Col_NombreProducto.Width = 93;
            // 
            // Col_PrecioProducto
            // 
            this.Col_PrecioProducto.Frozen = true;
            this.Col_PrecioProducto.HeaderText = "Precio";
            this.Col_PrecioProducto.MinimumWidth = 6;
            this.Col_PrecioProducto.Name = "Col_PrecioProducto";
            this.Col_PrecioProducto.Width = 79;
            // 
            // Col_CantidadProducto
            // 
            this.Col_CantidadProducto.Frozen = true;
            this.Col_CantidadProducto.HeaderText = "Cantidad";
            this.Col_CantidadProducto.MinimumWidth = 6;
            this.Col_CantidadProducto.Name = "Col_CantidadProducto";
            this.Col_CantidadProducto.Width = 98;
            // 
            // Col_SubTotalProducto
            // 
            this.Col_SubTotalProducto.Frozen = true;
            this.Col_SubTotalProducto.HeaderText = "SubTotal";
            this.Col_SubTotalProducto.MinimumWidth = 6;
            this.Col_SubTotalProducto.Name = "Col_SubTotalProducto";
            this.Col_SubTotalProducto.Width = 96;
            // 
            // Col_FechaVentaProducto
            // 
            this.Col_FechaVentaProducto.Frozen = true;
            this.Col_FechaVentaProducto.HeaderText = "Fecha Venta";
            this.Col_FechaVentaProducto.MinimumWidth = 6;
            this.Col_FechaVentaProducto.Name = "Col_FechaVentaProducto";
            this.Col_FechaVentaProducto.Width = 117;
            // 
            // Col_Tipoventa
            // 
            this.Col_Tipoventa.Frozen = true;
            this.Col_Tipoventa.HeaderText = "TipoVenta";
            this.Col_Tipoventa.MinimumWidth = 6;
            this.Col_Tipoventa.Name = "Col_Tipoventa";
            this.Col_Tipoventa.Width = 125;
            // 
            // Col_Check
            // 
            this.Col_Check.Frozen = true;
            this.Col_Check.HeaderText = "Devolver?";
            this.Col_Check.MinimumWidth = 6;
            this.Col_Check.Name = "Col_Check";
            this.Col_Check.Width = 125;
            // 
            // btn_ticket
            // 
            this.btn_ticket.BackColor = System.Drawing.Color.Navy;
            this.btn_ticket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ticket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ticket.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ticket.ForeColor = System.Drawing.Color.White;
            this.btn_ticket.Location = new System.Drawing.Point(839, 207);
            this.btn_ticket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ticket.Name = "btn_ticket";
            this.btn_ticket.Size = new System.Drawing.Size(206, 53);
            this.btn_ticket.TabIndex = 99;
            this.btn_ticket.Text = "VER PRODUCTOS";
            this.btn_ticket.UseVisualStyleBackColor = false;
            this.btn_ticket.Click += new System.EventHandler(this.btn_ticket_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(774, 207);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(70, 53);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 100;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(82, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 28);
            this.label2.TabIndex = 103;
            this.label2.Text = "Numero de Ticket:";
            // 
            // txt_ticket
            // 
            this.txt_ticket.BackColor = System.Drawing.Color.White;
            this.txt_ticket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ticket.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ticket.ForeColor = System.Drawing.Color.Black;
            this.txt_ticket.Location = new System.Drawing.Point(139, 213);
            this.txt_ticket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ticket.Name = "txt_ticket";
            this.txt_ticket.Size = new System.Drawing.Size(114, 24);
            this.txt_ticket.TabIndex = 104;
            this.txt_ticket.TextChanged += new System.EventHandler(this.txt_ticket_TextChanged);
            this.txt_ticket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ticket_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(774, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 28);
            this.label3.TabIndex = 105;
            this.label3.Text = "Dinero a Devolver:";
            // 
            // lbl_dinero_a_devolver
            // 
            this.lbl_dinero_a_devolver.AutoSize = true;
            this.lbl_dinero_a_devolver.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dinero_a_devolver.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_dinero_a_devolver.Location = new System.Drawing.Point(818, 131);
            this.lbl_dinero_a_devolver.Name = "lbl_dinero_a_devolver";
            this.lbl_dinero_a_devolver.Size = new System.Drawing.Size(71, 28);
            this.lbl_dinero_a_devolver.TabIndex = 106;
            this.lbl_dinero_a_devolver.Text = "Dinero";
            this.lbl_dinero_a_devolver.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(9, 11);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cerrarapp
            // 
            this.cerrarapp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarapp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarapp.Image = ((System.Drawing.Image)(resources.GetObject("cerrarapp.Image")));
            this.cerrarapp.Location = new System.Drawing.Point(2886, 4);
            this.cerrarapp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cerrarapp.Name = "cerrarapp";
            this.cerrarapp.Size = new System.Drawing.Size(29, 31);
            this.cerrarapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarapp.TabIndex = 0;
            this.cerrarapp.TabStop = false;
            // 
            // btn_minimzar
            // 
            this.btn_minimzar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimzar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimzar.Image")));
            this.btn_minimzar.Location = new System.Drawing.Point(2841, 4);
            this.btn_minimzar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_minimzar.Name = "btn_minimzar";
            this.btn_minimzar.Size = new System.Drawing.Size(39, 31);
            this.btn_minimzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimzar.TabIndex = 1;
            this.btn_minimzar.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1980, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1935, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1589, 4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1544, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1044, 4);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 57;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(999, 4);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 58;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btn_minimzar);
            this.panel1.Controls.Add(this.cerrarapp);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 39);
            this.panel1.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(843, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 53);
            this.button1.TabIndex = 107;
            this.button1.Text = "VER PRODUCTOS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(778, 498);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(70, 53);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 108;
            this.pictureBox8.TabStop = false;
            // 
            // devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1081, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.lbl_dinero_a_devolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ticket);
            this.Controls.Add(this.btn_ticket);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.dataGridView_ventas);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_regresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "devoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "devoluciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.devoluciones_FormClosing);
            this.Load += new System.EventHandler(this.devoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimzar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox btn_regresar;
        private Label label1;
        public Label lbl_id;
        private DataGridView dataGridView_ventas;
        private Button btn_ticket;
        private PictureBox pictureBox7;
        private Label label2;
        private TextBox txt_ticket;
        private Label label3;
        private Label lbl_dinero_a_devolver;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox cerrarapp;
        private PictureBox btn_minimzar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Panel panel1;
        private DataGridViewTextBoxColumn Col_Id_Venta;
        private DataGridViewTextBoxColumn Col_IdProducto;
        private DataGridViewTextBoxColumn Col_NombreProducto;
        private DataGridViewTextBoxColumn Col_PrecioProducto;
        private DataGridViewTextBoxColumn Col_CantidadProducto;
        private DataGridViewTextBoxColumn Col_SubTotalProducto;
        private DataGridViewTextBoxColumn Col_FechaVentaProducto;
        private DataGridViewTextBoxColumn Col_Tipoventa;
        private DataGridViewCheckBoxColumn Col_Check;
        private Button button1;
        private PictureBox pictureBox8;
    }
}