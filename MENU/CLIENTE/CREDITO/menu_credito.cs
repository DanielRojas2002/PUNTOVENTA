using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTOVENTA.MENU.CLIENTE.CREDITO
{
    public partial class menu_credito : Form
    {
        public menu_credito()
        {
            InitializeComponent();
        }

        private void menu_credito_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void menu_credito_Load(object sender, EventArgs e)
        {

        }
    }
}
