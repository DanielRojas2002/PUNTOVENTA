﻿namespace PUNTOVENTA.MENU.REPORTES
{
    partial class reporte_devoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporte_devoluciones));
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.dataGridView_devoluciones = new System.Windows.Forms.DataGridView();
            this.Col_IdDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Id_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechai = new System.Windows.Forms.Label();
            this.Fechadevolucion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cerrarapp = new System.Windows.Forms.PictureBox();
            this.btn_minimzar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_devolucion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_devoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimzar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(82, 558);
            this.btn_exportar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(927, 31);
            this.btn_exportar.TabIndex = 126;
            this.btn_exportar.Text = "Exportar a Excel";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(82, 364);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(927, 31);
            this.btn_generar.TabIndex = 125;
            this.btn_generar.Text = "Generar Reporte";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // dataGridView_devoluciones
            // 
            this.dataGridView_devoluciones.AllowUserToAddRows = false;
            this.dataGridView_devoluciones.AllowUserToDeleteRows = false;
            this.dataGridView_devoluciones.AllowUserToOrderColumns = true;
            this.dataGridView_devoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_devoluciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_IdDevolucion,
            this.Col_Id_Venta,
            this.Col_Producto,
            this.Col_Precio,
            this.Col_Cantidad,
            this.Col_SubTotal,
            this.Col_Usuario,
            this.Col_Fecha});
            this.dataGridView_devoluciones.Location = new System.Drawing.Point(82, 403);
            this.dataGridView_devoluciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_devoluciones.Name = "dataGridView_devoluciones";
            this.dataGridView_devoluciones.ReadOnly = true;
            this.dataGridView_devoluciones.RowHeadersWidth = 51;
            this.dataGridView_devoluciones.RowTemplate.Height = 25;
            this.dataGridView_devoluciones.Size = new System.Drawing.Size(927, 147);
            this.dataGridView_devoluciones.TabIndex = 124;
            // 
            // Col_IdDevolucion
            // 
            this.Col_IdDevolucion.HeaderText = "IdDevolucion";
            this.Col_IdDevolucion.MinimumWidth = 6;
            this.Col_IdDevolucion.Name = "Col_IdDevolucion";
            this.Col_IdDevolucion.ReadOnly = true;
            this.Col_IdDevolucion.Width = 125;
            // 
            // Col_Id_Venta
            // 
            this.Col_Id_Venta.HeaderText = "Id_Venta";
            this.Col_Id_Venta.MinimumWidth = 6;
            this.Col_Id_Venta.Name = "Col_Id_Venta";
            this.Col_Id_Venta.ReadOnly = true;
            this.Col_Id_Venta.Width = 125;
            // 
            // Col_Producto
            // 
            this.Col_Producto.HeaderText = "Producto";
            this.Col_Producto.MinimumWidth = 6;
            this.Col_Producto.Name = "Col_Producto";
            this.Col_Producto.ReadOnly = true;
            this.Col_Producto.Width = 125;
            // 
            // Col_Precio
            // 
            this.Col_Precio.HeaderText = "Precio";
            this.Col_Precio.MinimumWidth = 6;
            this.Col_Precio.Name = "Col_Precio";
            this.Col_Precio.ReadOnly = true;
            this.Col_Precio.Width = 125;
            // 
            // Col_Cantidad
            // 
            this.Col_Cantidad.HeaderText = "Cantidad";
            this.Col_Cantidad.MinimumWidth = 6;
            this.Col_Cantidad.Name = "Col_Cantidad";
            this.Col_Cantidad.ReadOnly = true;
            this.Col_Cantidad.Width = 125;
            // 
            // Col_SubTotal
            // 
            this.Col_SubTotal.HeaderText = "SubTotal";
            this.Col_SubTotal.MinimumWidth = 6;
            this.Col_SubTotal.Name = "Col_SubTotal";
            this.Col_SubTotal.ReadOnly = true;
            this.Col_SubTotal.Width = 125;
            // 
            // Col_Usuario
            // 
            this.Col_Usuario.HeaderText = "Usuario";
            this.Col_Usuario.MinimumWidth = 6;
            this.Col_Usuario.Name = "Col_Usuario";
            this.Col_Usuario.ReadOnly = true;
            this.Col_Usuario.Width = 125;
            // 
            // Col_Fecha
            // 
            this.Col_Fecha.HeaderText = "Fecha";
            this.Col_Fecha.MinimumWidth = 6;
            this.Col_Fecha.Name = "Col_Fecha";
            this.Col_Fecha.ReadOnly = true;
            this.Col_Fecha.Width = 125;
            // 
            // txtFechai
            // 
            this.txtFechai.AutoSize = true;
            this.txtFechai.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFechai.ForeColor = System.Drawing.Color.White;
            this.txtFechai.Location = new System.Drawing.Point(406, 194);
            this.txtFechai.Name = "txtFechai";
            this.txtFechai.Size = new System.Drawing.Size(132, 25);
            this.txtFechai.TabIndex = 123;
            this.txtFechai.Text = "Fecha Inicio:";
            this.txtFechai.Visible = false;
            // 
            // Fechadevolucion
            // 
            this.Fechadevolucion.Location = new System.Drawing.Point(406, 283);
            this.Fechadevolucion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Fechadevolucion.Name = "Fechadevolucion";
            this.Fechadevolucion.Size = new System.Drawing.Size(257, 27);
            this.Fechadevolucion.TabIndex = 122;
            this.Fechadevolucion.Value = new System.DateTime(2023, 4, 7, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(406, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 121;
            this.label2.Text = "Fecha Inicio:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(105, 122);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(274, 234);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 120;
            this.pictureBox7.TabStop = false;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(105, 52);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(274, 35);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 118;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(406, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 46);
            this.label1.TabIndex = 119;
            this.label1.Text = "REPORTE DEVOLUCIONES";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(796, 52);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 23);
            this.lbl_id.TabIndex = 117;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
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
            this.cerrarapp.Location = new System.Drawing.Point(3648, 4);
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
            this.btn_minimzar.Location = new System.Drawing.Point(3603, 4);
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
            this.pictureBox3.Location = new System.Drawing.Point(2742, 4);
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
            this.pictureBox2.Location = new System.Drawing.Point(2697, 4);
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
            this.pictureBox4.Location = new System.Drawing.Point(2351, 4);
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
            this.pictureBox1.Location = new System.Drawing.Point(2306, 4);
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
            this.pictureBox6.Location = new System.Drawing.Point(1807, 4);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 69;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1762, 4);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 70;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(1015, 4);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(29, 31);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 128;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(970, 4);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(39, 31);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 129;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox9);
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
            this.panel1.Size = new System.Drawing.Size(1061, 39);
            this.panel1.TabIndex = 127;
            // 
            // lbl_devolucion
            // 
            this.lbl_devolucion.AutoSize = true;
            this.lbl_devolucion.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_devolucion.ForeColor = System.Drawing.Color.Red;
            this.lbl_devolucion.Location = new System.Drawing.Point(812, 242);
            this.lbl_devolucion.Name = "lbl_devolucion";
            this.lbl_devolucion.Size = new System.Drawing.Size(109, 28);
            this.lbl_devolucion.TabIndex = 129;
            this.lbl_devolucion.Text = "devolucion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(771, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 28);
            this.label9.TabIndex = 128;
            this.label9.Text = "Cantidad Devolucion:";
            // 
            // reporte_devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1061, 613);
            this.Controls.Add(this.lbl_devolucion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.dataGridView_devoluciones);
            this.Controls.Add(this.txtFechai);
            this.Controls.Add(this.Fechadevolucion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reporte_devoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporte_devoluciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.reporte_devoluciones_FormClosing);
            this.Load += new System.EventHandler(this.reporte_devoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_devoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimzar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_exportar;
        private Button btn_generar;
        private DataGridView dataGridView_devoluciones;
        private Label txtFechai;
        private DateTimePicker Fechadevolucion;
        private Label label2;
        private PictureBox pictureBox7;
        private PictureBox btn_regresar;
        private Label label1;
        public Label lbl_id;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox cerrarapp;
        private PictureBox btn_minimzar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Panel panel1;
        private DataGridViewTextBoxColumn Col_IdDevolucion;
        private DataGridViewTextBoxColumn Col_Id_Venta;
        private DataGridViewTextBoxColumn Col_Producto;
        private DataGridViewTextBoxColumn Col_Precio;
        private DataGridViewTextBoxColumn Col_Cantidad;
        private DataGridViewTextBoxColumn Col_SubTotal;
        private DataGridViewTextBoxColumn Col_Usuario;
        private DataGridViewTextBoxColumn Col_Fecha;
        private Label lbl_devolucion;
        private Label label9;
    }
}