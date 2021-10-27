using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Configuracion : Form
    {
        Form menu;
        public Configuracion(Form menu_)
        {
            InitializeComponent();
            menu = menu_;
        }

        private void volverMainMenubtn_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
