namespace Punto_de_Venta
{
    partial class eliminar_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eliminar_usuario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_eliminar_usuario = new System.Windows.Forms.Button();
            this.bx_usuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblperfil = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.lblperfil);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_regresar);
            this.panel2.Controls.Add(this.lbl_perfil);
            this.panel2.Controls.Add(this.txt_usuario);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.bx_usuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 519);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(277, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Usuario";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(14, 51);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(42, 39);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 12;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // lbl_perfil
            // 
            this.lbl_perfil.AutoSize = true;
            this.lbl_perfil.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_perfil.ForeColor = System.Drawing.Color.White;
            this.lbl_perfil.Location = new System.Drawing.Point(160, 69);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(73, 23);
            this.lbl_perfil.TabIndex = 35;
            this.lbl_perfil.Text = "perfil:";
            this.lbl_perfil.Visible = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.txt_usuario.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.ForeColor = System.Drawing.Color.White;
            this.txt_usuario.Location = new System.Drawing.Point(283, 64);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(95, 23);
            this.txt_usuario.TabIndex = 34;
            this.txt_usuario.Text = "usuario:";
            this.txt_usuario.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(91, 64);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 23);
            this.lbl_id.TabIndex = 33;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(490, -72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Permisos";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.pictureBox4);
            this.panel13.Controls.Add(this.btn_eliminar_usuario);
            this.panel13.Location = new System.Drawing.Point(203, 413);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(333, 61);
            this.panel13.TabIndex = 31;
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
            // btn_eliminar_usuario
            // 
            this.btn_eliminar_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btn_eliminar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_eliminar_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_usuario.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_eliminar_usuario.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_usuario.Location = new System.Drawing.Point(80, 4);
            this.btn_eliminar_usuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_eliminar_usuario.Name = "btn_eliminar_usuario";
            this.btn_eliminar_usuario.Size = new System.Drawing.Size(249, 53);
            this.btn_eliminar_usuario.TabIndex = 0;
            this.btn_eliminar_usuario.Text = "ELIMINAR USUARIO";
            this.btn_eliminar_usuario.UseVisualStyleBackColor = false;
            this.btn_eliminar_usuario.Click += new System.EventHandler(this.btn_eliminar_usuario_Click);
            // 
            // bx_usuario
            // 
            this.bx_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.bx_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bx_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bx_usuario.ForeColor = System.Drawing.Color.White;
            this.bx_usuario.FormattingEnabled = true;
            this.bx_usuario.Location = new System.Drawing.Point(315, 217);
            this.bx_usuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bx_usuario.Name = "bx_usuario";
            this.bx_usuario.Size = new System.Drawing.Size(205, 28);
            this.bx_usuario.TabIndex = 30;
            this.bx_usuario.SelectedIndexChanged += new System.EventHandler(this.bx_usuario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "ELIMINAR USUARIO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 147);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 259);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 43);
            this.panel4.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 555);
            this.panel1.TabIndex = 4;
            // 
            // lblperfil
            // 
            this.lblperfil.AutoSize = true;
            this.lblperfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblperfil.Location = new System.Drawing.Point(459, 142);
            this.lblperfil.Name = "lblperfil";
            this.lblperfil.Size = new System.Drawing.Size(0, 20);
            this.lblperfil.TabIndex = 37;
            // 
            // eliminar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 519);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "eliminar_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eliminar_usuario";
            this.Activated += new System.EventHandler(this.eliminar_usuario_Activated);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private PictureBox btn_regresar;
        private PictureBox pictureBox2;
        private Label label1;
        private ComboBox bx_usuario;
        private Panel panel13;
        private PictureBox pictureBox4;
        private Button btn_eliminar_usuario;
        private Label label5;
        public Label lbl_id;
        public Label txt_usuario;
        public Label lbl_perfil;
        private Label label2;
        private Panel panel4;
        private Panel panel1;
        private Label lblperfil;
    }
}