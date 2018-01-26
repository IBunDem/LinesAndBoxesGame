using System.Drawing;

namespace LinesAndBoxes
{
    public class Player
    {
        public Color color;
        public Color boxColor;
        public int number;
        public int score;

        public Player(int number, Color color, Color boxColor)
        {

            this.number = number;
            this.color = color;
            this.boxColor = boxColor;
            score = 0;
        }
    }
}