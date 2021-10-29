using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Security.Permissions;

namespace Chess
{
    public partial class Chess : Form
    {
        private Panel[,] _chessBoardPanels;
        public const int tileSize = 40;
        public const int gridSize = 8;
        
        public Chess()
        {
            InitializeComponent();
        }

        private void Chess_Load(object sender, EventArgs e)
        {
            //------------------------Tablero casillas leves-----------------------
            var clr1 = Color.Black;
            var clr2 = Color.White;

            // initialize the "chess board"
            _chessBoardPanels = new Panel[gridSize, gridSize];

            // double for loop to handle all rows and columns
            for (var n = 0; n < gridSize; n++)
            {
                for (var m = 0; m < gridSize; m++)
                {
                    // create new Panel control which will be one 
                    // chess board tile
                    var newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * n +50, tileSize * m + 50)
                    };
                    
                    // add to Form's Controls so that they show up
                    Controls.Add(newPanel);

                    // add to our 2d array of panels for future use
                    _chessBoardPanels[n, m] = newPanel;
                    // color the backgrounds
                    if (n % 2 != 0)
                        newPanel.BackColor = m % 2 != 0 ? clr1 : clr2;
                    else
                        newPanel.BackColor = m % 2 != 0 ? clr2 : clr1;
                }
            }
            //usamos las piezas blancas pq tienen contorno negro y se ven
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Assets\White_Rook.png");
            _chessBoardPanels[0,0].BackgroundImage = Image.FromFile(path);
            _chessBoardPanels[0, 0].BackgroundImageLayout = ImageLayout.Stretch;
            _chessBoardPanels[7, 7].BackgroundImage = Image.FromFile(path);
            _chessBoardPanels[7, 7].BackgroundImageLayout = ImageLayout.Stretch;     
        }

        private void btn_fatales_Click(object sender, EventArgs e)
        {
            var clr1 = Color.Magenta;
            var clr2 = Color.White;

            for (var n = 0; n < gridSize; n++)
            {
                for (var m = 0; m < gridSize; m++)
                {
                    // create new Panel control which will be one 
                    // chess board tile
                    var newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * n + 450, tileSize * m + 50)
                    };

                    // add to Form's Controls so that they show up
                    Controls.Add(newPanel);



                    // add to our 2d array of panels for future use
                    _chessBoardPanels[n, m] = newPanel;
                    // color the backgrounds
                    if (n % 2 != 0)
                        newPanel.BackColor = m % 2 != 0 ? clr1 : clr2;
                    else
                        newPanel.BackColor = m % 2 != 0 ? clr2 : clr1;
                }
            }
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Assets\White_Rook.png");
            _chessBoardPanels[0, 0].BackgroundImage = Image.FromFile(path);
            _chessBoardPanels[0, 0].BackgroundImageLayout = ImageLayout.Stretch;
            _chessBoardPanels[7, 7].BackgroundImage = Image.FromFile(path);
            _chessBoardPanels[7, 7].BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
