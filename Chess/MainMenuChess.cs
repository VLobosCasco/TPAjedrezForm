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
        static int cantidad = 10; //parametros por default que recibe el form principal chess
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
            cantidad = comboBox1.SelectedIndex + 1; //Le asignamos al parametro la cantidad que selecciona el usuario
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Dentro del if else que planteamos, nos quedamos con el else ya que este es el de mayor complejidad. Para el mejor caso, se entrara loop while(true) 1 sola vez, es decir que a la primera pasada encuentre un tablero norepetido. De esta forma la complejidad estaría dada por recorrer todo 1 sola vez. Como cada for tiene parámetros fijos que no dependen de la entrada(Ej: N=8 tamaño del tablero), al igual que el loop while dentro de la función atacarCasillas (este corresponde al caso de la reina, que dentro del switch case es el de mayor complejidad), estos tendrán complejidades constantes que se multiplican por la complejidad interior; ésta también será constante ya que tampoco depende de la cantidad de tableros. También tomamos en cuenta que el usuario decide no filtrar las casillas fatales, por lo que no se llama a ésta función y no aporta complejidad. De esta forma, tenemos que la complejidad terminará siendo una constante que resulte de sumar la complejidad de cada línea y función. \nPor otro lado, para un caso general no sabremos cuantas veces tendremos que recorrer el loop while(true), por lo que a la complejidad constante hallada para el mejor caso, deberíamos multiplicarlo por m, es decir, por el número de veces que se recorra el loop while(true). Ademas deberíamos multiplicar este m por la complejidad constante de la función casillasFatales, ya que el usuario puede decidir filtrar para cada tablero sus casillas fatales, por lo que se agregaría una complejidad de (Constante * m). A su vez, lo mencionado anteriormente se multiplicará por un n(tableros) el cual depende de la entrada.Teniendo en cuenta esto, el mejor caso seria cuando n = 1 y el while encuentre el tablero en la primera vuelta.");
        }
    }
}
