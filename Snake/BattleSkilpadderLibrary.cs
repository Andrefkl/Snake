namespace Snake
{
    public class BattleSkilpadderLibrary
    {
        int AttackCount = 0;
        bool LeftIsDumb;
        bool RightIsDumb;
        bool UpIsDumb;
        bool DownIsDumb;
        bool Player_Left;
        bool Player_Right;
        bool Player_Up;
        bool Player_Down;
        bool Player_Space;
        int Count = 0;

        bool Ost = true;
        public void MovePlayer(Form form, PictureBox Player, PictureBox NewLocation, int PlayerSpeed, bool PlayerMovingLeft, bool PlayerMovingRight)
        {
            Player.Width = 69;


            Count++;
            NewLocation.Location = Player.Location;
            if (Player_Left)
                NewLocation.Left -= PlayerSpeed;
            if (Player_Right)
                NewLocation.Left += PlayerSpeed;
            if (Player_Up)
                NewLocation.Top -= PlayerSpeed;
            if (Player_Down)
                NewLocation.Top += PlayerSpeed;

            foreach (Control Border in form.Controls)
                if (Border.Name != "Player" && Border is PictureBox && Border.Name != "pictureBox3" && !Border.Name.Contains("Prop") && !Border.Name.Contains("Exit") && Border.Name != "PlayerHealthBar" && !Border.Name.Contains("Sign") || Border.Name.Contains("HitBox"))
                    if (NewLocation.Bounds.IntersectsWith(Border.Bounds))
                    {
                        if (Border.Name == "pictureBox9" && Border.Visible == false)
                            Ost = true;

                        if (Border.Name == "pictureBoxProp")
                        {
                            PictureBox pictureBox9Prop = (PictureBox)Border;
                            if (pictureBox9Prop.Visible == false)
                            {
                                Ost = true;
                                foreach (Control BorderCheck in form.Controls)
                                {
                                    if (BorderCheck.Name == "pictureBox1" && NewLocation.Bounds.IntersectsWith(BorderCheck.Bounds) || BorderCheck.Name == "pictureBox6" && NewLocation.Bounds.IntersectsWith(BorderCheck.Bounds))
                                        Ost = false;
                                }
                            }
                        }

                        else
                        {
                            Ost = false;
                            if (Border.Name == "Enemy1")
                                Ost = true;

                            NewLocation.Left += PlayerSpeed;
                            if (!NewLocation.Bounds.IntersectsWith(Border.Bounds) && Player_Down || !NewLocation.Bounds.IntersectsWith(Border.Bounds) && Player_Up)
                            {
                                LeftIsDumb = true;
                                Ost = true;
                            }
                            NewLocation.Left -= PlayerSpeed * 2;
                            if (!NewLocation.Bounds.IntersectsWith(Border.Bounds) && Player_Down || !NewLocation.Bounds.IntersectsWith(Border.Bounds) && Player_Up)
                            {
                                RightIsDumb = true;
                                Ost = true;
                            }
                            NewLocation.Left += PlayerSpeed;
                            NewLocation.Top += PlayerSpeed;
                            if (!NewLocation.Bounds.IntersectsWith(Border.Bounds) && Player_Left || !NewLocation.Bounds.IntersectsWith(Border.Bounds) && Player_Right)
                            {
                                UpIsDumb = true;
                                Ost = true;
                            }
                            NewLocation.Top -= PlayerSpeed * 2;
                            if (!NewLocation.Bounds.IntersectsWith(Border.Bounds) && Player_Left || !NewLocation.Bounds.IntersectsWith(Border.Bounds) && Player_Right)
                            {
                                DownIsDumb = true;
                                Ost = true;
                            }
                            NewLocation.Top += PlayerSpeed;

                        }
                        break;
                    }

            if (Ost)
            {
                if (Player_Left && !LeftIsDumb)
                    Player.Left -= PlayerSpeed;
                if (Player_Right && !RightIsDumb)
                    Player.Left += PlayerSpeed;
                if (Player_Up && !UpIsDumb)
                    Player.Top -= PlayerSpeed;
                if (Player_Down && !DownIsDumb)
                    Player.Top += PlayerSpeed;

                LeftIsDumb = false;
                RightIsDumb = false;
                UpIsDumb = false;
                DownIsDumb = false;
                MoveAnimation(Player, PlayerMovingLeft, PlayerMovingRight);
            }
            Ost = true;
        }

        public void MoveAnimation(PictureBox Player, bool PlayerMovingLeft, bool PlayerMovingRight)
        {
            if (Count % 10 == 0)
            {
                if (PlayerMovingLeft)
                    Player.BackgroundImage = Properties.Resources.PlayerLeftWalk;
                else if (PlayerMovingRight)
                    Player.BackgroundImage = Properties.Resources.PlayerRightWalk;
            }
            else if (Count % 5 == 0)
            {
                if (PlayerMovingLeft)
                    Player.BackgroundImage = Properties.Resources.PlayerLeftStill;
                else if (PlayerMovingRight)
                    Player.BackgroundImage = Properties.Resources.PlayerRightStill;
            }
        }

        public void Game_KeyDown(object sender, KeyEventArgs e, ref System.Windows.Forms.Timer timerMove, ref bool PlayerMovingLeft, ref bool PlayerMovingRight, ref System.Windows.Forms.Timer timerAttack, ref bool Player_Enter)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Player_Left = true;
                    timerMove.Enabled = true;
                    PlayerMovingLeft = true;
                    PlayerMovingRight = false;
                    break;
                case Keys.Right:
                    Player_Right = true;
                    timerMove.Enabled = true;
                    PlayerMovingRight = true;
                    PlayerMovingLeft = false;
                    break;
                case Keys.Up:
                    Player_Up = true;
                    timerMove.Enabled = true;
                    if (!PlayerMovingLeft && !PlayerMovingRight)
                        PlayerMovingRight = true;
                    break;
                case Keys.Down:
                    Player_Down = true;
                    timerMove.Enabled = true;
                    if (!PlayerMovingLeft && !PlayerMovingRight)
                        PlayerMovingRight = true;
                    break;
                case Keys.Enter:
                    Player_Enter = true;
                    timerMove.Enabled = true;
                    break;
                case Keys.Space:
                        Player_Space = true;
                        timerAttack.Enabled = true;
                    break;
            }
        }

        public void Game_KeyUp(object sender, KeyEventArgs e, PictureBox Player, ref System.Windows.Forms.Timer timerMove, ref bool PlayerMovingLeft, ref bool PlayerMovingRight, ref System.Windows.Forms.Timer timerAttack, ref bool Player_Enter)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Player_Left = false;
                    Ost = true;
                    if (Player_Right == Player_Up == Player_Down == false)
                    {
                        if (PlayerMovingRight)
                            Player.BackgroundImage = Properties.Resources.PlayerRightStill;
                        else if (PlayerMovingLeft)
                            Player.BackgroundImage = Properties.Resources.PlayerLeftStill;

                        timerMove.Enabled = false; Count = 0;
                    }
                    break;
                case Keys.Right:
                    Player_Right = false;
                    Ost = true;
                    if (Player_Left == Player_Up == Player_Down == false)
                    {
                        if (PlayerMovingRight)
                            Player.BackgroundImage = Properties.Resources.PlayerRightStill;
                        else if (PlayerMovingLeft)
                            Player.BackgroundImage = Properties.Resources.PlayerLeftStill;

                        timerMove.Enabled = false; Count = 0;
                    }
                    break;
                case Keys.Up:
                    Player_Up = false;
                    Ost = true;
                    if (Player_Right == Player_Left == Player_Down == false)
                    {
                        if (PlayerMovingRight)
                            Player.BackgroundImage = Properties.Resources.PlayerRightStill;
                        else if (PlayerMovingLeft)
                            Player.BackgroundImage = Properties.Resources.PlayerLeftStill;

                        timerMove.Enabled = false; Count = 0;
                    }
                    break;
                case Keys.Down:
                    Player_Down = false;
                    Ost = true;
                    if (Player_Right == Player_Up == Player_Left == false)
                    {
                        if (PlayerMovingRight)
                            Player.BackgroundImage = Properties.Resources.PlayerRightStill;
                        else if (PlayerMovingLeft)
                            Player.BackgroundImage = Properties.Resources.PlayerLeftStill;

                        timerMove.Enabled = false; Count = 0;
                    }
                    break;
                case Keys.Enter:
                    Player_Enter = false;
                    break;
            }
        }
        public void PlayerAttackWithoutEnemies(object sender, EventArgs e, PictureBox Player, ref System.Windows.Forms.Timer timerAttack, ref bool PlayerMovingRight, ref bool PlayerMovingLeft)
        {
            AttackCount++;
            if (AttackCount == 1)
            {
                if (PlayerMovingRight)
                {
                    Player.BackgroundImage = Properties.Resources.PlayerRightHit;
                }
                else if (PlayerMovingLeft)
                {
                    Player.BackgroundImage = Properties.Resources.PlayerLeftHit;
                    Player.Location = new Point(Player.Location.X - 12, Player.Location.Y);
                    Player.SetBounds(Player.Bounds.X, Player.Bounds.Y, Player.Bounds.Width + 12, Player.Bounds.Height);
                }

                Player.Width = 82;
            }
            if (AttackCount == 2)
            {
                if (PlayerMovingRight)
                    Player.BackgroundImage = Properties.Resources.PlayerRightStill;
                else if (PlayerMovingLeft)
                {
                    Player.BackgroundImage = Properties.Resources.PlayerLeftStill;
                    Player.Location = new Point(Player.Location.X + 12, Player.Location.Y);
                    Player.SetBounds(Player.Bounds.X, Player.Bounds.Y, Player.Bounds.Width - 12, Player.Bounds.Height);
                }

                timerAttack.Enabled = false;
                AttackCount = 0;
                Player.Width = 69;
            }
        }

        public void PlayerAttackWithEnemies(object sender, EventArgs e, PictureBox Player, System.Windows.Forms.Timer timerAttack, ref bool PlayerMovingRight, ref bool PlayerMovingLeft, ref Array[] AllEnemies)
        {
            AttackCount++;
            if (AttackCount == 1)
            {
                if (PlayerMovingRight)
                {
                    Player.BackgroundImage = Properties.Resources.PlayerRightHit;
                }
                else if (PlayerMovingLeft)
                {
                    Player.BackgroundImage = Properties.Resources.PlayerLeftHit;
                    Player.Location = new Point(Player.Location.X - 12, Player.Location.Y);
                    Player.SetBounds(Player.Bounds.X, Player.Bounds.Y, Player.Bounds.Width + 12, Player.Bounds.Height);
                }

                foreach (object[] EnemyInfo in AllEnemies) // Checks if the player hit an enemy
                {
                    PictureBox Enemy = (PictureBox)EnemyInfo[0];
                    bool EnemyMovingLeft = (bool)EnemyInfo[1];
                    bool EnemyMovingRight = (bool)EnemyInfo[2];
                    int EnemyHealth = (int)EnemyInfo[3];
                    Label EnemyHealthBar = (Label)EnemyInfo[4];
                    bool EnemyIsDead = (bool)EnemyInfo[5];

                    if (PlayerMovingRight)
                    {
                        if (Enemy.Location.X - Player.Location.X <= 100 && EnemyMovingLeft)
                        {
                            EnemyHealth -= 20;
                            EnemyHealthBar.Text = EnemyHealth.ToString();
                            if (EnemyHealth <= 0)
                                EnemyIsDead = true;
                        }
                    }
                    else if (PlayerMovingLeft)
                    {
                        if (Player.Location.X - Enemy.Location.X <= 120 && EnemyMovingRight)
                        {
                            EnemyHealth -= 20;
                            EnemyHealthBar.Text = EnemyHealth.ToString();
                            if (EnemyHealth <= 0)
                                EnemyIsDead = true;
                        }
                    }

                    EnemyInfo[1] = EnemyMovingLeft;
                    EnemyInfo[2] = EnemyMovingRight;
                    EnemyInfo[3] = EnemyHealth;
                    EnemyInfo[4] = EnemyHealthBar;
                    EnemyInfo[5] = EnemyIsDead;

                }
                Player.Width = 82;
            }
            if (AttackCount == 2)
            {
                if (PlayerMovingRight)
                    Player.BackgroundImage = Properties.Resources.PlayerRightStill;
                else if (PlayerMovingLeft)
                {
                    Player.BackgroundImage = Properties.Resources.PlayerLeftStill;
                    Player.Location = new Point(Player.Location.X + 12, Player.Location.Y);
                    Player.SetBounds(Player.Bounds.X, Player.Bounds.Y, Player.Bounds.Width - 12, Player.Bounds.Height);
                }

                timerAttack.Enabled = false;
                AttackCount = 0;
                Player.Width = 69;
            }
        }
    }
}
