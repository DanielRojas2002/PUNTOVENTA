namespace PUNTOVENTA.MENU.PROVEEDOR
{
    public partial class agregar_proveedor : Form
    {
        public agregar_proveedor()
        {
            InitializeComponent();
        }

        private void agregar_proveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
