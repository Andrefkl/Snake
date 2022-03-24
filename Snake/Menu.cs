using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ButtonStartSnake_Click(object sender, EventArgs e)
        {
            int snakeSpeed = (int)numericUpDownSnakeSpeed.Maximum * 100 + 100 - (int)numericUpDownSnakeSpeed.Value * 100; // Inverts the speed so that 1 is the slowest speed.
            int snakeSize = (int)numericUpDownSnakeSize.Value;

            SnakeGameBoard snakeGameBoard = new SnakeGameBoard(snakeSize, snakeSpeed);
            snakeGameBoard.Show();
        }

        private void ButtonStartBattleSkilpadder_Click(object sender, EventArgs e)
        {
            BattleSkilpadder battleSkilpadder = new BattleSkilpadder();
            battleSkilpadder.Show();
        }
    }
}
