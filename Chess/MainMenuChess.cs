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
    public partial class MainMenuChess : Form
    {
        public MainMenuChess()
        {
            InitializeComponent();
        }

        private void MainMenuChess_Load(object sender, EventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }
        private void Configuracionbtn_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion(this);
            configuracion.Show();
            this.Hide();
        }
        private void startbtn_Click(object sender, EventArgs e)
        {
           Chess chess = new Chess();
            chess.Show();
            this.Hide();
        }
    }
}
