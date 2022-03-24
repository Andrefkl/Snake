namespace Snake
{
    public partial class SnakeGameBoard : Form
    {
        int SnakeSpeed = 200; // Invert
        int FoodSize = 50;
        int Score = 0;
        int SnakePieceSize = 50;
        int BoardWidth = 1200;
        int BoardHeight = 800;

        Keys Direction = Keys.Up;
        PictureBox Food = new PictureBox();
        List<PictureBox> SnakePieces = new List<PictureBox>();
        public SnakeGameBoard(int snakeSize, int snakeSpeed)
        {
            SnakeSpeed = snakeSpeed;
            SnakePieceSize = snakeSize;

            InitializeComponent();
            TimerMoveSnake.Interval = SnakeSpeed;
            SnakePieces.Add(SnakeHead);
            SnakeHead.Size = new Size(SnakePieceSize, SnakePieceSize);
            this.Width = BoardWidth;
            this.Height = BoardHeight;
        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            ButtonStartGame.Visible = false;
            TimerMoveSnake.Enabled = true;
            SpawnFood();
        }

        private void TimerMoveSnake_Tick(object sender, EventArgs e)
        {
            Point frontSnakePos = new Point();
            if (Direction == Keys.Up)
                frontSnakePos = new Point(SnakeHead.Location.X, SnakeHead.Location.Y - SnakePieceSize);
            else if (Direction == Keys.Down)
                frontSnakePos = new Point(SnakeHead.Location.X, SnakeHead.Location.Y + SnakePieceSize);
            else if (Direction == Keys.Left)
                frontSnakePos = new Point(SnakeHead.Location.X - SnakePieceSize, SnakeHead.Location.Y);
            else
                frontSnakePos = new Point(SnakeHead.Location.X + SnakePieceSize, SnakeHead.Location.Y);

            // Check if the snake just hit itself or the wall
            if (SnakePieces.Any(snakePiece => snakePiece.Name != "SnakeHead" && snakePiece.Bounds.IntersectsWith(SnakeHead.Bounds))
                || SnakeHead.Location.X > this.Width - 50 || SnakeHead.Location.X < 0
                                   || SnakeHead.Location.Y > this.Height - 50 || SnakeHead.Location.Y < 0)
            {
                EndGame();
                return;
            }

            // Moves all pieces to front piece position
            foreach (var snakePiece in SnakePieces)
            {
                var currentPos = snakePiece.Location;
                snakePiece.Location = frontSnakePos;

                frontSnakePos = new Point(currentPos.X, currentPos.Y);
            }

            // Check if the snake just hit a cherry
            if (SnakePieces.Any(snakePiece => snakePiece.Bounds.IntersectsWith(Food.Bounds)))
            {
                Controls.Remove(Food);
                SpawnFood();
                Score++;
                LabelScore.Text = Score.ToString(); // Updates the score label

                IncreaseSnakeSize();
            }
        }
        private void EndGame()
        {
            TimerMoveSnake.Enabled = false;
        }
        private void IncreaseSnakeSize()
        {
            PictureBox snakePiece = new PictureBox();
            snakePiece.Size = new Size(SnakePieceSize, SnakePieceSize);
            snakePiece.BackColor = Color.Green;

            // Adds a new piece of the snake.
            if (Direction == Keys.Down)
                snakePiece.Location = new Point(SnakePieces.Last().Location.X, SnakePieces.Last().Location.Y - SnakePieceSize);
            else if (Direction == Keys.Up)
                snakePiece.Location = new Point(SnakePieces.Last().Location.X, SnakePieces.Last().Location.Y + SnakePieceSize);
            else if (Direction == Keys.Right)
                snakePiece.Location = new Point(SnakePieces.Last().Location.X - SnakePieceSize, SnakePieces.Last().Location.Y);
            else
                snakePiece.Location = new Point(SnakePieces.Last().Location.X + SnakePieceSize, SnakePieces.Last().Location.Y);

            SnakePieces.Add(snakePiece);

            Controls.Add(snakePiece);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys pressedKey = e.KeyCode;
            if (pressedKey != Keys.Up && pressedKey != Keys.Down && pressedKey != Keys.Left && pressedKey != Keys.Right)
                Direction = Keys.Up;
            else
            {
                if (Direction == Keys.Left && pressedKey == Keys.Right
                    || Direction == Keys.Right && pressedKey == Keys.Left
                    || Direction == Keys.Up && pressedKey == Keys.Down
                    || Direction == Keys.Down && pressedKey == Keys.Up)
                    return;
                Direction = pressedKey;
            }
        }

        private void SpawnFood()
        {
            PictureBox food = new PictureBox();
            food.Size = new Size(FoodSize, FoodSize);
            food.BackColor = Color.Red;

            Random ran = new Random();
            do
            {
                int xPos = ran.Next(0, this.Width - 100);
                int yPos = ran.Next(0, this.Height - 100);

                food.Location = new Point(xPos, yPos);
            }
            while (SnakePieces.Any(snakePiece => snakePiece.Bounds.IntersectsWith(food.Bounds)));
            Controls.Add(food);
            Food = food;
        }
    }
}