namespace Snake
{
    public partial class Form1 : Form
    {
        int SnakeSpeed = 200; // Invert
        int FoodSize = 30;
        int Score = 0;
        Keys Direction = Keys.Up;
        PictureBox Food = new PictureBox();
        List<PictureBox> SnakePieces = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            TimerMoveSnake.Interval = SnakeSpeed;
            SnakePieces.Add(SnakeHead);
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
                frontSnakePos = new Point(SnakeHead.Location.X, SnakeHead.Location.Y - 50);
            else if (Direction == Keys.Down)
                frontSnakePos = new Point(SnakeHead.Location.X, SnakeHead.Location.Y + 50);
            else if (Direction == Keys.Left)
                frontSnakePos = new Point(SnakeHead.Location.X - 50, SnakeHead.Location.Y);
            else
                frontSnakePos = new Point(SnakeHead.Location.X + 50, SnakeHead.Location.Y);

            // Check if the snake just hit itself or the wall
            if (SnakePieces.Any(snakePiece => snakePiece.Name != "SnakeHead" && snakePiece.Bounds.IntersectsWith(SnakeHead.Bounds))
                || SnakePieces.Any(snakePiece => snakePiece.Location.X > this.Width || snakePiece.Location.X < 0
                                   || snakePiece.Location.Y > this.Height || snakePiece.Location.Y < 0))
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

                IncreaseSnakeSize();
            }

            LabelScore.Text = Score.ToString();
        }
        private void EndGame()
        {
            TimerMoveSnake.Enabled = false;
        }
        private void IncreaseSnakeSize()
        {
            PictureBox snakePiece = new PictureBox();
            snakePiece.Size = new Size(50, 50);
            snakePiece.BackColor = Color.DarkGreen;

            // Adds a new piece of the snake.
            if (Direction == Keys.Down)
                snakePiece.Location = new Point(SnakePieces.Last().Location.X, SnakePieces.Last().Location.Y - 50);
            else if (Direction == Keys.Up)
                snakePiece.Location = new Point(SnakePieces.Last().Location.X, SnakePieces.Last().Location.Y + 50);
            else if (Direction == Keys.Right)
                snakePiece.Location = new Point(SnakePieces.Last().Location.X - 50, SnakePieces.Last().Location.Y);
            else
                snakePiece.Location = new Point(SnakePieces.Last().Location.X + 50, SnakePieces.Last().Location.Y);

            SnakePieces.Add(snakePiece);

            Controls.Add(snakePiece);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys pressedKey = e.KeyCode;
            if (pressedKey != Keys.Up && pressedKey != Keys.Down && pressedKey != Keys.Left && pressedKey != Keys.Right)
                Direction = Keys.Up;
            else
                Direction = e.KeyCode;
        }

        private void SpawnFood()
        {
            PictureBox food = new PictureBox();
            food.Size = new Size(FoodSize, FoodSize);
            food.BackColor = Color.Red;

            Random ran = new Random();
            do
            {
                int xPos = ran.Next(0, this.Width - FoodSize);
                int yPos = ran.Next(0, this.Height - FoodSize);

                food.Location = new Point(xPos, yPos);
            }
            while (SnakePieces.Any(snakePiece => snakePiece.Bounds.IntersectsWith(food.Bounds)));
            Controls.Add(food);
            Food = food;
        }
    }
}