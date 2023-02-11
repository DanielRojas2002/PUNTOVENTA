namespace PUNTOVENTA.MENU.PROVEEDOR
{
    public partial class menu_proveedor : Form
    {
        public menu_proveedor()
        {
            InitializeComponent();
        }

        private void menu_proveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
