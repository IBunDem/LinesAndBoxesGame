using System.Drawing;
using System.Windows.Forms;

namespace LinesAndBoxes
{
    public class GameManager
    {
        private Player p1;
        private Player p2;
        public Player currentPlayer;
        public int linesCount;
        public int currentCount;
        public GamePanel gamePanel;

        public GameManager(GamePanel panel)
        {
            this.gamePanel = panel;
            p1 = new Player(1, Color.Blue, Color.Aqua);
            p2 = new Player(2, Color.Red, Color.Coral);
            currentPlayer = p1;
        }

        public void SwitchCurrentPlayer()
        {
            if (currentPlayer.number == p1.number)
                currentPlayer = p2;
            else
                currentPlayer = p1;
        }
        public void Move()
        {
            currentCount++;
            if(currentCount == linesCount)
            {
                Player winner = (p1.score > p2.score ? p1 : p2);
                MessageBox.Show("Победил игрок " + winner.number);
            }
        }

    }
}
