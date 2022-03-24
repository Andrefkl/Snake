﻿namespace Snake
{
    partial class SnakeGameBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerMoveSnake = new System.Windows.Forms.Timer(this.components);
            this.ButtonStartGame = new System.Windows.Forms.Button();
            this.SnakeHead = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHead)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerMoveSnake
            // 
            this.TimerMoveSnake.Tick += new System.EventHandler(this.TimerMoveSnake_Tick);
            // 
            // ButtonStartGame
            // 
            this.ButtonStartGame.Location = new System.Drawing.Point(433, 148);
            this.ButtonStartGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonStartGame.Name = "ButtonStartGame";
            this.ButtonStartGame.Size = new System.Drawing.Size(82, 22);
            this.ButtonStartGame.TabIndex = 0;
            this.ButtonStartGame.Text = "Start Game";
            this.ButtonStartGame.UseVisualStyleBackColor = true;
            this.ButtonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // SnakeHead
            // 
            this.SnakeHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SnakeHead.Location = new System.Drawing.Point(407, 262);
            this.SnakeHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SnakeHead.Name = "SnakeHead";
            this.SnakeHead.Size = new System.Drawing.Size(50, 50);
            this.SnakeHead.TabIndex = 1;
            this.SnakeHead.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(793, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Location = new System.Drawing.Point(841, 21);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(13, 15);
            this.LabelScore.TabIndex = 3;
            this.LabelScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 565);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SnakeHead);
            this.Controls.Add(this.ButtonStartGame);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerMoveSnake;
        private Button ButtonStartGame;
        private PictureBox SnakeHead;
        private Label label1;
        private Label LabelScore;
    }
}