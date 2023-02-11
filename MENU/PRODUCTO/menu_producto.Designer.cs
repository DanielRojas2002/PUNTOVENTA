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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUnidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUnidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUnidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.unidadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoriaToolStripMenuItem,
            this.modificarCategoriaToolStripMenuItem,
            this.eliminarCategoriaToolStripMenuItem});
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
            // unidadToolStripMenuItem
            // 
            this.unidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUnidadToolStripMenuItem,
            this.modificarUnidadToolStripMenuItem,
            this.eliminarUnidadToolStripMenuItem});
            this.unidadToolStripMenuItem.Name = "unidadToolStripMenuItem";
            this.unidadToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.unidadToolStripMenuItem.Text = "Unidad";
            // 
            // agregarUnidadToolStripMenuItem
            // 
            this.agregarUnidadToolStripMenuItem.Name = "agregarUnidadToolStripMenuItem";
            this.agregarUnidadToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.agregarUnidadToolStripMenuItem.Text = "Agregar Unidad";
            this.agregarUnidadToolStripMenuItem.Click += new System.EventHandler(this.agregarUnidadToolStripMenuItem_Click);
            // 
            // modificarUnidadToolStripMenuItem
            // 
            this.modificarUnidadToolStripMenuItem.Name = "modificarUnidadToolStripMenuItem";
            this.modificarUnidadToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.modificarUnidadToolStripMenuItem.Text = "Modificar Unidad";
            this.modificarUnidadToolStripMenuItem.Click += new System.EventHandler(this.modificarUnidadToolStripMenuItem_Click);
            // 
            // eliminarUnidadToolStripMenuItem
            // 
            this.eliminarUnidadToolStripMenuItem.Name = "eliminarUnidadToolStripMenuItem";
            this.eliminarUnidadToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.eliminarUnidadToolStripMenuItem.Text = "Eliminar Unidad";
            this.eliminarUnidadToolStripMenuItem.Click += new System.EventHandler(this.eliminarUnidadToolStripMenuItem_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(33, 44);
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
            this.lbl_perfil.Location = new System.Drawing.Point(98, 44);
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
            this.txt_usuario.Location = new System.Drawing.Point(221, 39);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(95, 23);
            this.txt_usuario.TabIndex = 48;
            this.txt_usuario.Text = "usuario:";
            this.txt_usuario.Visible = false;
            // 
            // menu_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_perfil);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu_producto";
            this.Text = "menu_producto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem agregarCategoriaToolStripMenuItem;
        private ToolStripMenuItem modificarCategoriaToolStripMenuItem;
        private ToolStripMenuItem eliminarCategoriaToolStripMenuItem;
        private ToolStripMenuItem unidadToolStripMenuItem;
        private ToolStripMenuItem agregarUnidadToolStripMenuItem;
        private ToolStripMenuItem modificarUnidadToolStripMenuItem;
        private ToolStripMenuItem eliminarUnidadToolStripMenuItem;
        public Label lbl_id;
        public Label lbl_perfil;
        public Label txt_usuario;
    }
}