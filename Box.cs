using System.Drawing;
using System.Windows.Forms;

namespace LinesAndBoxes
{
    class Box
    {
        public PictureBox box;
        private int countLines;
        private bool isChecked;
        
        public Box(Point location, Size size)
        {
            countLines = 0;
            isChecked = false;
            box = new PictureBox();
            box.BorderStyle = BorderStyle.FixedSingle;
            box.BackColor = Color.LightGray;
            box.Location = location;
            box.Size = size;
        }

        public bool IncrementBox(Player player)
        {
            countLines++;
            if(countLines == 4 && !isChecked)
            {
                isChecked = true;
                box.BackColor = player.boxColor;
                player.score++;
            }
            return isChecked;
        }
    }
}
