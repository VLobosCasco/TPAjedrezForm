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
        static int cantidad = 10;
        static int inicio = 0;
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
            Chess chess = new Chess(cantidad, this, inicio);
            chess.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantidad = comboBox1.SelectedIndex + 1;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
