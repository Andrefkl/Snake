namespace Snake
{
    partial class BattleSkilpadder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExclamationMarkHitBox = new System.Windows.Forms.PictureBox();
            this.PlayerHealthBar = new System.Windows.Forms.Label();
            this.Enemy1HealthBar = new System.Windows.Forms.Label();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.timerEnemyMove = new System.Windows.Forms.Timer(this.components);
            this.timerAttack = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExclamationMarkHitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = global::Snake.Properties.Resources.PlayerRightStill;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Player.Location = new System.Drawing.Point(262, 87);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(89, 123);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Enemy1
            // 
            this.Enemy1.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1.BackgroundImage = global::Snake.Properties.Resources.EnemyIdleRight;
            this.Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Enemy1.Location = new System.Drawing.Point(912, 339);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(148, 172);
            this.Enemy1.TabIndex = 1;
            this.Enemy1.TabStop = false;
            // 
            // pictureBoxExclamationMarkHitBox
            // 
            this.pictureBoxExclamationMarkHitBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExclamationMarkHitBox.BackgroundImage = global::Snake.Properties.Resources.ExclamationMark;
            this.pictureBoxExclamationMarkHitBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxExclamationMarkHitBox.Location = new System.Drawing.Point(969, 247);
            this.pictureBoxExclamationMarkHitBox.Name = "pictureBoxExclamationMarkHitBox";
            this.pictureBoxExclamationMarkHitBox.Size = new System.Drawing.Size(51, 74);
            this.pictureBoxExclamationMarkHitBox.TabIndex = 2;
            this.pictureBoxExclamationMarkHitBox.TabStop = false;
            this.pictureBoxExclamationMarkHitBox.Visible = false;
            // 
            // PlayerHealthBar
            // 
            this.PlayerHealthBar.AutoSize = true;
            this.PlayerHealthBar.BackColor = System.Drawing.Color.Red;
            this.PlayerHealthBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerHealthBar.Location = new System.Drawing.Point(265, 40);
            this.PlayerHealthBar.Name = "PlayerHealthBar";
            this.PlayerHealthBar.Size = new System.Drawing.Size(59, 31);
            this.PlayerHealthBar.TabIndex = 3;
            this.PlayerHealthBar.Text = "100";
            // 
            // Enemy1HealthBar
            // 
            this.Enemy1HealthBar.AutoSize = true;
            this.Enemy1HealthBar.BackColor = System.Drawing.Color.Red;
            this.Enemy1HealthBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Enemy1HealthBar.Location = new System.Drawing.Point(847, 308);
            this.Enemy1HealthBar.Name = "Enemy1HealthBar";
            this.Enemy1HealthBar.Size = new System.Drawing.Size(59, 31);
            this.Enemy1HealthBar.TabIndex = 4;
            this.Enemy1HealthBar.Text = "100";
            // 
            // timerMove
            // 
            this.timerMove.Interval = 10;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // timerEnemyMove
            // 
            this.timerEnemyMove.Enabled = true;
            this.timerEnemyMove.Tick += new System.EventHandler(this.timerEnemyMove_Tick);
            // 
            // timerAttack
            // 
            this.timerAttack.Tick += new System.EventHandler(this.timerAttack_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Snake.Properties.Resources.BattleField;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1182, 753);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // BattleSkilpadder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.BattleField;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pictureBoxExclamationMarkHitBox);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.Enemy1HealthBar);
            this.Controls.Add(this.PlayerHealthBar);
            this.Controls.Add(this.pictureBox3);
            this.KeyPreview = true;
            this.Name = "BattleSkilpadder";
            this.Text = "BattleSkilpadder";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExclamationMarkHitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Player;
        private PictureBox Enemy1;
        private PictureBox pictureBoxExclamationMarkHitBox;
        private Label PlayerHealthBar;
        private Label Enemy1HealthBar;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Timer timerEnemyMove;
        private System.Windows.Forms.Timer timerAttack;
        private PictureBox pictureBox3;
    }
}