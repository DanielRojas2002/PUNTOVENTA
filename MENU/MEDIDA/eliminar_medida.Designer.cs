namespace PUNTOVENTA.MENU.MEDIDA
{
    partial class eliminar_medida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eliminar_medida));
            this.lbl_id_medida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblperfil = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_eliminar_medida = new System.Windows.Forms.Button();
            this.bx_medidas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id_medida
            // 
            this.lbl_id_medida.AutoSize = true;
            this.lbl_id_medida.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_id_medida.ForeColor = System.Drawing.Color.White;
            this.lbl_id_medida.Location = new System.Drawing.Point(415, 124);
            this.lbl_id_medida.Name = "lbl_id_medida";
            this.lbl_id_medida.Size = new System.Drawing.Size(104, 23);
            this.lbl_id_medida.TabIndex = 61;
            this.lbl_id_medida.Text = "idmedida";
            this.lbl_id_medida.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 60);
            this.label3.TabIndex = 60;
            this.label3.Text = "Solo se podra eliminar una medida\r\n cuando no existan productos \r\ncon la medida a" +
    " eliminar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblperfil
            // 
            this.lblperfil.AutoSize = true;
            this.lblperfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblperfil.Location = new System.Drawing.Point(468, 104);
            this.lblperfil.Name = "lblperfil";
            this.lblperfil.Size = new System.Drawing.Size(0, 20);
            this.lblperfil.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(225, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 58;
            this.label2.Text = "Medida";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(23, 13);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(42, 39);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 51;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // lbl_perfil
            // 
            this.lbl_perfil.AutoSize = true;
            this.lbl_perfil.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_perfil.ForeColor = System.Drawing.Color.White;
            this.lbl_perfil.Location = new System.Drawing.Point(169, 31);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(73, 23);
            this.lbl_perfil.TabIndex = 57;
            this.lbl_perfil.Text = "perfil:";
            this.lbl_perfil.Visible = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.txt_usuario.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.ForeColor = System.Drawing.Color.White;
            this.txt_usuario.Location = new System.Drawing.Point(292, 26);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(95, 23);
            this.txt_usuario.TabIndex = 56;
            this.txt_usuario.Text = "usuario:";
            this.txt_usuario.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(100, 26);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 23);
            this.lbl_id.TabIndex = 55;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.pictureBox4);
            this.panel13.Controls.Add(this.btn_eliminar_medida);
            this.panel13.Location = new System.Drawing.Point(212, 308);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(333, 61);
            this.panel13.TabIndex = 54;
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
            // btn_eliminar_medida
            // 
            this.btn_eliminar_medida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btn_eliminar_medida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_eliminar_medida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_medida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_medida.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_eliminar_medida.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_medida.Location = new System.Drawing.Point(80, 4);
            this.btn_eliminar_medida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_eliminar_medida.Name = "btn_eliminar_medida";
            this.btn_eliminar_medida.Size = new System.Drawing.Size(249, 53);
            this.btn_eliminar_medida.TabIndex = 0;
            this.btn_eliminar_medida.Text = "ELIMINAR MEDIDA";
            this.btn_eliminar_medida.UseVisualStyleBackColor = false;
            this.btn_eliminar_medida.Click += new System.EventHandler(this.btn_eliminar_medida_Click);
            // 
            // bx_medidas
            // 
            this.bx_medidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.bx_medidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bx_medidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bx_medidas.ForeColor = System.Drawing.Color.White;
            this.bx_medidas.FormattingEnabled = true;
            this.bx_medidas.Location = new System.Drawing.Point(263, 170);
            this.bx_medidas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bx_medidas.Name = "bx_medidas";
            this.bx_medidas.Size = new System.Drawing.Size(205, 28);
            this.bx_medidas.TabIndex = 53;
            this.bx_medidas.SelectedIndexChanged += new System.EventHandler(this.bx_medidas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 46);
            this.label1.TabIndex = 52;
            this.label1.Text = "ELIMINAR MEDIDA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 109);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // eliminar_medida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 407);
            this.Controls.Add(this.lbl_id_medida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblperfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_perfil);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.bx_medidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "eliminar_medida";
            this.Text = "eliminar_medida";
            this.Activated += new System.EventHandler(this.eliminar_medida_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.eliminar_medida_FormClosing);
            this.Load += new System.EventHandler(this.eliminar_medida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label lbl_id_medida;
        private Label label3;
        private Label lblperfil;
        private Label label2;
        private PictureBox btn_regresar;
        public Label lbl_perfil;
        public Label txt_usuario;
        public Label lbl_id;
        private Panel panel13;
        private PictureBox pictureBox4;
        private Button btn_eliminar_medida;
        private ComboBox bx_medidas;
        private Label label1;
        private PictureBox pictureBox2;
    }
}