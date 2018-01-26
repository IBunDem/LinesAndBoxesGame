using System.Drawing;

namespace LinesAndBoxes
{
    public class GameBoard
    {
        public const int V_LINE_W = 10;
        public const int V_LINE_H = 80;
        public const int H_LINE_W = 80;
        public const int H_LINE_H = 10;
        public const int BOX_SIZE = 80;
        
        private Line[,] vLines;
        private Line[,] hLines;
        private Box[,] boxes;
        private int width;
        private int height;
        public GameManager gameManager;
        public GamePanel gamePanel;

        public GameBoard(GameManager game, int width, int height)
        {
            this.gameManager = game;
            gameManager.linesCount = ((width + 1) * height) + ((height + 1) * width);
            gameManager.currentCount = 0;
            this.gamePanel = gameManager.gamePanel;
            this.width = width;
            this.height = height;
            boxes = new Box[width,height];
            vLines = new Line[width + 1, height];
            hLines = new Line[width, height + 1];
            gamePanel.Size = new Size(width * BOX_SIZE + (width + 1) * V_LINE_W + 16, height * BOX_SIZE + (height + 1) * H_LINE_H + 39);
        }

        public void GenerateBoard()
        {
            Line tempLine = null;
            Box tempBox = null;

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    tempBox = new Box(new Point((i + 1) * V_LINE_W + i * BOX_SIZE, (j + 1) * H_LINE_H + j * BOX_SIZE), new Size(BOX_SIZE, BOX_SIZE));
                    boxes[i, j] = tempBox;

                    gamePanel.AddObjectToPanel(tempBox.box);
                }


            for (int i = 0; i < width + 1; i++)
                for (int j = 0; j < height; j++)
                {

                    tempLine = new Line(gameManager, new Point(i * BOX_SIZE + i * H_LINE_H, j * V_LINE_H + (j + 1) * H_LINE_H), new Size(V_LINE_W, V_LINE_H));
                    vLines[i, j] = tempLine;

                    gamePanel.AddObjectToPanel(tempLine.line);
                }
            tempLine = null;

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height + 1; j++)
                {

                    tempLine = new Line(gameManager, new Point(i * H_LINE_W + (i + 1) * V_LINE_W, j * BOX_SIZE + j * V_LINE_W), new Size(H_LINE_W, H_LINE_H));
                    hLines[i, j] = tempLine;

                    gamePanel.AddObjectToPanel(tempLine.line);
                }
            tempLine = null;

            
            Box box1;
            Box[] barr;

            for (int i = 0; i < width + 1; i++)
                for (int j = 0; j < height; j++)
                {
                    if (i == 0)
                    
                        barr = new Box[] { null, boxes[i, j] };
                    else if( i == width)
                    
                        barr = new Box[] { null, boxes[i - 1, j] };
                    else
                    barr = new Box[] { boxes[i - 1, j], boxes[i, j] };
                    vLines[i, j].AddBoxes(barr);
                }
            box1 = null;

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height + 1; j++)
                {
                    if (j == 0)
                        barr = new Box[] { null, boxes[i, j] };
                    else if (j == height)
                        barr = new Box[] { null, boxes[i, j - 1] };
                    else
                    barr = new Box[] {boxes[i,j-1],boxes[i,j]};
                    hLines[i, j].AddBoxes(barr);
                }
            box1 = null;


        }

    }
}
