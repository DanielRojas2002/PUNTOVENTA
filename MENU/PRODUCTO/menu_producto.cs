﻿using PUNTOVENTA.MENU.CATEGORIA;

namespace PUNTOVENTA.MENU.PRODUCTO
{
    public partial class menu_producto : Form
    {
        public menu_producto()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregar_categoria forms = new agregar_categoria();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void modificarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            modificar_categoria forms = new modificar_categoria();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void eliminarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            eliminar_categoria forms = new eliminar_categoria();
            forms.lbl_id.Text = lbl_id.Text;
            forms.Show();
        }

        private void agregarUnidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarUnidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarUnidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menu_producto_Load(object sender, EventArgs e)
        {

        }
     

        private void menu_producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
