namespace PUNTOVENTA.MENU.CLIENTE
{
    partial class menu_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_cliente));
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_eliminar_cliente = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_modificar_cliente = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_agregarCliente = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_creditos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_perfil
            // 
            this.lbl_perfil.AutoSize = true;
            this.lbl_perfil.BackColor = System.Drawing.Color.Navy;
            this.lbl_perfil.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_perfil.ForeColor = System.Drawing.Color.White;
            this.lbl_perfil.Location = new System.Drawing.Point(182, 120);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(73, 23);
            this.lbl_perfil.TabIndex = 37;
            this.lbl_perfil.Text = "perfil:";
            this.lbl_perfil.Visible = false;
            this.lbl_perfil.Click += new System.EventHandler(this.lbl_perfil_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btn_eliminar_cliente);
            this.panel2.Location = new System.Drawing.Point(67, 565);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 61);
            this.panel2.TabIndex = 32;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // btn_eliminar_cliente
            // 
            this.btn_eliminar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btn_eliminar_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_eliminar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_cliente.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_eliminar_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_cliente.Location = new System.Drawing.Point(69, 4);
            this.btn_eliminar_cliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_eliminar_cliente.Name = "btn_eliminar_cliente";
            this.btn_eliminar_cliente.Size = new System.Drawing.Size(248, 53);
            this.btn_eliminar_cliente.TabIndex = 0;
            this.btn_eliminar_cliente.Text = "ELIMINAR CLIENTE";
            this.btn_eliminar_cliente.UseVisualStyleBackColor = false;
            this.btn_eliminar_cliente.Click += new System.EventHandler(this.btn_eliminar_cliente_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.txt_usuario.BackColor = System.Drawing.Color.Navy;
            this.txt_usuario.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.ForeColor = System.Drawing.Color.White;
            this.txt_usuario.Location = new System.Drawing.Point(274, 120);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(95, 23);
            this.txt_usuario.TabIndex = 36;
            this.txt_usuario.Text = "usuario:";
            this.txt_usuario.Visible = false;
            this.txt_usuario.Click += new System.EventHandler(this.txt_usuario_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_modificar_cliente);
            this.panel1.Location = new System.Drawing.Point(67, 496);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 61);
            this.panel1.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btn_modificar_cliente
            // 
            this.btn_modificar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btn_modificar_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_modificar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar_cliente.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modificar_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_modificar_cliente.Location = new System.Drawing.Point(65, 8);
            this.btn_modificar_cliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_modificar_cliente.Name = "btn_modificar_cliente";
            this.btn_modificar_cliente.Size = new System.Drawing.Size(252, 53);
            this.btn_modificar_cliente.TabIndex = 0;
            this.btn_modificar_cliente.Text = "MODIFICAR CLIENTE";
            this.btn_modificar_cliente.UseVisualStyleBackColor = false;
            this.btn_modificar_cliente.Click += new System.EventHandler(this.btn_modificar_cliente_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Navy;
            this.lbl_id.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(93, 120);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 23);
            this.lbl_id.TabIndex = 35;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.btn_agregarCliente);
            this.panel5.Location = new System.Drawing.Point(67, 431);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 61);
            this.panel5.TabIndex = 34;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // btn_agregarCliente
            // 
            this.btn_agregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btn_agregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_agregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarCliente.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarCliente.ForeColor = System.Drawing.Color.White;
            this.btn_agregarCliente.Location = new System.Drawing.Point(65, 4);
            this.btn_agregarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_agregarCliente.Name = "btn_agregarCliente";
            this.btn_agregarCliente.Size = new System.Drawing.Size(252, 53);
            this.btn_agregarCliente.TabIndex = 0;
            this.btn_agregarCliente.Text = "CREAR CLIENTE";
            this.btn_agregarCliente.UseVisualStyleBackColor = false;
            this.btn_agregarCliente.Click += new System.EventHandler(this.btn_agregarCliente_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Navy;
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(14, 16);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(461, 44);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 38;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbl_perfil);
            this.panel3.Controls.Add(this.txt_usuario);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lbl_id);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 745);
            this.panel3.TabIndex = 39;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.btn_creditos);
            this.panel4.Location = new System.Drawing.Point(67, 635);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 61);
            this.panel4.TabIndex = 33;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 4);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 53);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // btn_creditos
            // 
            this.btn_creditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btn_creditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_creditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_creditos.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_creditos.ForeColor = System.Drawing.Color.White;
            this.btn_creditos.Location = new System.Drawing.Point(69, 4);
            this.btn_creditos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_creditos.Name = "btn_creditos";
            this.btn_creditos.Size = new System.Drawing.Size(248, 53);
            this.btn_creditos.TabIndex = 0;
            this.btn_creditos.Text = "PAGAR CREDITOS";
            this.btn_creditos.UseVisualStyleBackColor = false;
            this.btn_creditos.Click += new System.EventHandler(this.btn_creditos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 46);
            this.label1.TabIndex = 81;
            this.label1.Text = "CLIENTES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 149);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // menu_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 745);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "menu_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu_cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_cliente_FormClosing);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Label lbl_perfil;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button btn_eliminar_cliente;
        public Label txt_usuario;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btn_modificar_cliente;
        public Label lbl_id;
        private Panel panel5;
        private PictureBox pictureBox4;
        private Button btn_agregarCliente;
        private PictureBox btn_regresar;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel4;
        private PictureBox pictureBox5;
        private Button btn_creditos;
    }
}