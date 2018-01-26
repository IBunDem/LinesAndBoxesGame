using System;
using System.Windows.Forms;

namespace LinesAndBoxes
{
    public partial class StartPanel : Form
    {      
        public StartPanel()
        {
            InitializeComponent();
        }

        private void StartPanel_Load(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void button_start_Click(object sender, EventArgs e)
        {
            //GameManager gameManager = new GameManager(panel);
            int w = 0;
            if (textBox_width.Text.Equals("") || textBox_width.Text.Equals(" "))
                w = 6;
            else
                w = Convert.ToInt32(textBox_width.Text);
            
            int h = 0;
            if (textBox_height.Text.Equals("") || textBox_height.Text.Equals(" "))
                h = 6;
            else
                h = Convert.ToInt32(textBox_height.Text);

            GamePanel panel = new GamePanel();
            GameManager gameManager = new GameManager(panel);
            GameBoard gameBoard = new GameBoard(gameManager, w, h);
            gameBoard.GenerateBoard();
            panel.Init(gameBoard);
            panel.ShowDialog();
        }
    }
}
