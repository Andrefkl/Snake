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
    public partial class BattleSkilpadder : Form
    {
        bool PlayerMovingLeft;
        bool PlayerMovingRight;
        bool PlayerIsNear;
        bool EnemyHasMoved;
        bool Player_Enter;
        bool EnemyMovingLeft;
        bool EnemyMovingRight;
        bool Enemy1Died;
        bool CountHasReset;
        int PlayerSpeed = 3;
        int deathCount;
        int PlayerHealth = 100;
        bool BattleFieldEnemy1Dead = false;
        bool SwitchedForms = false;
        new Point DogPosition;
        PictureBox NewLocation = new PictureBox();
        int count = 0;
        int Enemy1Health = 100;
        BattleSkilpadderLibrary library = new BattleSkilpadderLibrary();


        public BattleSkilpadder()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(Game_KeyDown);
            this.KeyUp += new KeyEventHandler(Game_KeyUp);
            NewLocation.Size = Player.Size;
            NewLocation.Name = "NewLocation";
            Player.BackgroundImage = Properties.Resources.PlayerRightStill;
            PlayerHealthBar.Location = new Point(Player.Location.X + 15, Player.Location.Y - 40);
        }
        public void EndGame()
        {
            timerEnemyMove.Enabled = false;
        }
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            library.Game_KeyDown(sender, e, ref timerMove, ref PlayerMovingLeft, ref PlayerMovingRight, ref timerAttack, ref Player_Enter);
        }
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            library.Game_KeyUp(sender, e, Player, ref timerMove, ref PlayerMovingLeft, ref PlayerMovingRight, ref timerAttack, ref Player_Enter);
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            Player.Width = 69;

            //< Player Healthbar>            
            PlayerHealthBar.Location = new Point(Player.Location.X + 15, Player.Location.Y - 40);
            //</ Player Healthbar>

            library.MovePlayer(this, Player, NewLocation, PlayerSpeed, PlayerMovingLeft, PlayerMovingRight);

            if (Player.Location.X >= 350 && !PlayerIsNear)
            {
                PlayerIsNear = true;
                count = 14;
                pictureBoxExclamationMarkHitBox.Visible = true;
                Enemy1.Width = 111;
            }
        }

        private void timerEnemyMove_Tick(object sender, EventArgs e)
        {
            if (!Enemy1Died)
            {
                if (EnemyHasMoved)
                {
                    int PlayerXHit = Player.Location.X - 30;
                    int PlayerYHit = Player.Location.Y - 30;
                    EnemyMovingLeft = false;
                    EnemyMovingRight = false;

                    PictureBox PlayerHitBox = new PictureBox();
                    PlayerHitBox.Name = "PlayerHitBox";
                    PlayerHitBox.Bounds = Player.Bounds;
                    PlayerHitBox.SetBounds(Player.Bounds.X + 60, Player.Bounds.Y + 60, 120, 150);
                    PlayerHitBox.Location = (new Point(PlayerXHit, PlayerYHit));
                    PlayerHitBox.Visible = true;
                    //this.Controls.Add(PlayerHitBox);
                    PlayerHitBox.BackColor = Color.Red;
                    PlayerHitBox.BringToFront();


                    if (Enemy1.Bounds.IntersectsWith(PlayerHitBox.Bounds)) // Runs if the enemy is near the player and should start to attack
                    {
                        if (!CountHasReset)
                        {
                            count = 0;
                            CountHasReset = true;
                        }

                        if (Player.Location.X < Enemy1.Location.X) // Runs if the player is to the left of the enemy
                        {
                            EnemyMovingRight = false;
                            EnemyMovingLeft = true;
                        }

                        else if (Player.Location.X > Enemy1.Location.X) // Runs if the player is to the right of the enemy
                        {
                            EnemyMovingRight = true;
                            EnemyMovingLeft = false;
                        }


                        count++;

                        if (EnemyMovingLeft)
                        {
                            Enemy1.Width = 111;
                            if (count == 14)
                                count = 1;
                            if (count == 1)
                                Enemy1.BackgroundImage = Properties.Resources.EnemyLeftAttack1;
                            else if (count == 2)
                                Enemy1.BackgroundImage = Properties.Resources.EnemyLeftAttack2;
                            else if (count == 3)
                                Enemy1.BackgroundImage = Properties.Resources.EnemyLeftAttack3;
                            else if (count == 4)
                            {
                                Enemy1.BackgroundImage = Properties.Resources.EnemyLeftAttack4;
                                Enemy1.Width += 15;
                            }
                            else if (count == 5)
                            {
                                Enemy1.BackgroundImage = Properties.Resources.EnemyLeftAttack5;
                                Enemy1.Width += 18;
                            }
                            else if (count == 6)
                            {
                                Enemy1.BackgroundImage = Properties.Resources.EnemyLeftAttack6;
                                PlayerHealth -= 15;
                            }
                        }
                        else if (EnemyMovingRight)
                        {
                            Enemy1.Width = 111;
                            if (count == 14)
                                count = 1;
                            if (count == 1)
                                Enemy1.BackgroundImage = Properties.Resources.EnemyRightAttack1;
                            else if (count == 2)
                                Enemy1.BackgroundImage = Properties.Resources.EnemyRightAttack2;
                            else if (count == 3)
                                Enemy1.BackgroundImage = Properties.Resources.EnemyRightAttack3;
                            else if (count == 4)
                            {
                                Enemy1.BackgroundImage = Properties.Resources.EnemyRightAttack4;
                                Enemy1.Width += 15;
                                Enemy1.Location = new Point(Enemy1.Location.X - 15, Enemy1.Location.Y);
                            }
                            else if (count == 5)
                            {
                                Enemy1.BackgroundImage = Properties.Resources.EnemyRightAttack5;
                                Enemy1.Width += 18;
                                Enemy1.Location = new Point(Enemy1.Location.X - 3, Enemy1.Location.Y);
                            }
                            else if (count == 6)
                            {
                                Enemy1.BackgroundImage = Properties.Resources.EnemyRightAttack6;
                                PlayerHealth -= 15;
                                Enemy1.Location = new Point(Enemy1.Location.X + 18, Enemy1.Location.Y);
                            }
                        }
                    }

                    else
                    {
                        CountHasReset = false;
                        if (Player.Location.Y > Enemy1.Location.Y) // Runs if the player is higher than the enemy
                            Enemy1.Top += 10;
                        else if (Player.Location.Y < Enemy1.Location.Y) // Runs if the player is lower than the enemy
                            Enemy1.Top -= 10;

                        if (Player.Location.X < Enemy1.Location.X) // Runs if the player is to the left of the enemy
                        {
                            Enemy1.Left -= 10;
                            EnemyMovingRight = false;
                            EnemyMovingLeft = true;
                        }

                        else if (Player.Location.X > Enemy1.Location.X) // Runs if the player is to the right of the enemy
                        {
                            Enemy1.Left += 10;
                            EnemyMovingRight = true;
                            EnemyMovingLeft = false;
                        }

                        count++;

                        if (EnemyMovingLeft)
                        {
                            if (count >= 7)
                                count = 1;

                            Enemy1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("EnemyLeftWalk" + count);
                        }
                        else if (EnemyMovingRight)
                        {
                            if (count >= 7)
                                count = 1;

                            Enemy1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("EnemyRightWalk" + count);
                        }
                    }
                }
                else if (!EnemyHasMoved)
                {
                    count++;

                    if (count == 14)
                        count = 1;
                    if (count == 2)
                        Enemy1.BackgroundImage = Properties.Resources.EnemyRightCut1;
                    else if (count == 4)
                        Enemy1.BackgroundImage = Properties.Resources.EnemyRightCut2;
                    else if (count == 6)
                        Enemy1.BackgroundImage = Properties.Resources.EnemyRightCut3;
                    else if (count == 8)
                        Enemy1.BackgroundImage = Properties.Resources.EnemyRightCut4;
                    else if (count == 10)
                    {
                        Enemy1.BackgroundImage = Properties.Resources.EnemyRightCut5;
                        Enemy1.Width += 50;
                    }
                    else if (count == 12)
                    {
                        Enemy1.BackgroundImage = Properties.Resources.EnemyRightCut6;
                        Enemy1.Width = 111;
                    }

                    else if (count == 15)
                        Enemy1.BackgroundImage = Properties.Resources.EnemyIdleLeft;
                    else if (count == 20)
                    {
                        count = 0;
                        EnemyHasMoved = true;
                        pictureBoxExclamationMarkHitBox.Visible = false;
                        pictureBoxExclamationMarkHitBox.SetBounds(0, 0, 0, 0);
                        Enemy1HealthBar.Visible = true;
                    }
                }

                //< Player Healthbar>
                PlayerHealthBar.Text = PlayerHealth.ToString();

                if (PlayerHealth <= 0)
                {
                    BackColor = Color.Black;
                    pictureBox3.BackgroundImage = null;
                    pictureBox3.BackColor = Color.Black;
                    pictureBox3.BringToFront();
                }
                //</ Player Healthbar>

                //< Enemy Healthbar>            
                Enemy1HealthBar.Location = new Point(Enemy1.Location.X + 25, Enemy1.Location.Y - 40);
                //</ Enemy Healthbar>
            }

            else if (Enemy1Died) // Runs if the enemy is dead
            {
                BattleFieldEnemy1Dead = true;
                Enemy1HealthBar.Visible = false;
                deathCount++;

                if (deathCount > 6)
                {
                    EndGame();
                }

                if (Player.Location.X < Enemy1.Location.X) // Runs if the player is to the left of the enemy
                {
                    if (deathCount <= 6)
                        Enemy1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("EnemyLeftDeath" + deathCount);
                }
                else if (Player.Location.X > Enemy1.Location.X) // Runs if the player is to the right of the enemy
                {
                    if (deathCount <= 6)
                        Enemy1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("EnemyRightDeath" + deathCount);
                }
            }
        }

        

        private void timerAttack_Tick(object sender, EventArgs e)
        {
            Object[] Enemy1Info = new Object[] { Enemy1, EnemyMovingLeft, EnemyMovingRight, Enemy1Health, Enemy1HealthBar, Enemy1Died };
            Array[] AllEnemies = new Array[] { Enemy1Info };

            library.PlayerAttackWithEnemies(sender, e, Player, timerAttack, ref PlayerMovingRight, ref PlayerMovingLeft, ref AllEnemies);

            EnemyMovingLeft = (bool)Enemy1Info[1];
            EnemyMovingRight = (bool)Enemy1Info[2];
            Enemy1Health = (int)Enemy1Info[3];
            Enemy1HealthBar = (Label)Enemy1Info[4];
            Enemy1Died = (bool)Enemy1Info[5];
        }
    }
}
