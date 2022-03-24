namespace Snake
{
    partial class Menu
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
            this.ButtonStartSnake = new System.Windows.Forms.Button();
            this.numericUpDownSnakeSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSnakeSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonStartBattleSkilpadder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSnakeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSnakeSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStartSnake
            // 
            this.ButtonStartSnake.Location = new System.Drawing.Point(173, 337);
            this.ButtonStartSnake.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonStartSnake.Name = "ButtonStartSnake";
            this.ButtonStartSnake.Size = new System.Drawing.Size(127, 31);
            this.ButtonStartSnake.TabIndex = 0;
            this.ButtonStartSnake.Text = "Start Snake";
            this.ButtonStartSnake.UseVisualStyleBackColor = true;
            this.ButtonStartSnake.Click += new System.EventHandler(this.ButtonStartSnake_Click);
            // 
            // numericUpDownSnakeSize
            // 
            this.numericUpDownSnakeSize.Location = new System.Drawing.Point(31, 277);
            this.numericUpDownSnakeSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownSnakeSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSnakeSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSnakeSize.Name = "numericUpDownSnakeSize";
            this.numericUpDownSnakeSize.Size = new System.Drawing.Size(137, 27);
            this.numericUpDownSnakeSize.TabIndex = 3;
            this.numericUpDownSnakeSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDownSnakeSpeed
            // 
            this.numericUpDownSnakeSpeed.Location = new System.Drawing.Point(311, 277);
            this.numericUpDownSnakeSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownSnakeSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSnakeSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSnakeSpeed.Name = "numericUpDownSnakeSpeed";
            this.numericUpDownSnakeSpeed.Size = new System.Drawing.Size(137, 27);
            this.numericUpDownSnakeSpeed.TabIndex = 4;
            this.numericUpDownSnakeSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Snake Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Snake Speed. 0-10";
            // 
            // ButtonStartBattleSkilpadder
            // 
            this.ButtonStartBattleSkilpadder.Location = new System.Drawing.Point(636, 339);
            this.ButtonStartBattleSkilpadder.Name = "ButtonStartBattleSkilpadder";
            this.ButtonStartBattleSkilpadder.Size = new System.Drawing.Size(182, 29);
            this.ButtonStartBattleSkilpadder.TabIndex = 7;
            this.ButtonStartBattleSkilpadder.Text = "Start Battle Skilpadder";
            this.ButtonStartBattleSkilpadder.UseVisualStyleBackColor = true;
            this.ButtonStartBattleSkilpadder.Click += new System.EventHandler(this.ButtonStartBattleSkilpadder_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.ButtonStartBattleSkilpadder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSnakeSpeed);
            this.Controls.Add(this.numericUpDownSnakeSize);
            this.Controls.Add(this.ButtonStartSnake);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSnakeSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSnakeSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonStartSnake;
        private NumericUpDown numericUpDownSnakeSize;
        private NumericUpDown numericUpDownSnakeSpeed;
        private Label label1;
        private Label label2;
        private Button ButtonStartBattleSkilpadder;
    }
}