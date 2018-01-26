using System;
using System.Windows.Forms;
using System.Drawing;

namespace LinesAndBoxes
{
    class Line
    {
        public Button line;
        private GameManager gameManager;
        private Player currentPlayer;
        private Point location;
        private bool isChosen;
        private Box[] boxes;
        
        public Line(GameManager gameManager, Point location, Size size)
        {
            this.location = location;
            this.gameManager = gameManager;
            isChosen = false;
            boxes = new Box[2];

            line = new Button();
            line.Text = "";
            line.FlatStyle = FlatStyle.Flat;
            line.BackColor = Color.DarkGray;
            line.Location = location;
            line.Size = size;
            line.Click += Click;
        }

        public void AddBoxes(Box[] boxes)
        {
            this.boxes = boxes;
        }

        private void Click(object sender, EventArgs e)
        {
            bool f1 = false, f2 = false;
            if (!isChosen)
            {
                currentPlayer = gameManager.currentPlayer;
                if(boxes != null)
                {
                    if (boxes[0] != null)
                        f1 = boxes[0].IncrementBox(currentPlayer);
                    if (boxes[1] != null)
                        f2 = boxes[1].IncrementBox(currentPlayer);
                }
                gameManager.Move();
                line.BackColor = currentPlayer.color;
                if (!f1 && !f2) 
                    gameManager.SwitchCurrentPlayer();
                isChosen = true;
            }

        }
    }
}
