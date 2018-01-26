using System;
using System.Windows.Forms;

namespace LinesAndBoxes
{
    public partial class GamePanel : Form
    {
        private GameBoard gameBoard;

        public GamePanel()
        {
            InitializeComponent();
        }

        public void Init(GameBoard board)
        {
            this.gameBoard = board;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GamePanel_Load(object sender, EventArgs e)
        {

        }

        public void AddObjectToPanel(Control o)
        {

            Controls.Add(o);
        }
    }
}
