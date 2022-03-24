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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSnakeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSnakeSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStartSnake
            // 
            this.ButtonStartSnake.Location = new System.Drawing.Point(360, 277);
            this.ButtonStartSnake.Name = "ButtonStartSnake";
            this.ButtonStartSnake.Size = new System.Drawing.Size(75, 23);
            this.ButtonStartSnake.TabIndex = 0;
            this.ButtonStartSnake.Text = "Start Snake";
            this.ButtonStartSnake.UseVisualStyleBackColor = true;
            this.ButtonStartSnake.Click += new System.EventHandler(this.ButtonStartSnake_Click);
            // 
            // numericUpDownSnakeSize
            // 
            this.numericUpDownSnakeSize.Location = new System.Drawing.Point(224, 230);
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
            this.numericUpDownSnakeSize.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownSnakeSize.TabIndex = 3;
            this.numericUpDownSnakeSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDownSnakeSpeed
            // 
            this.numericUpDownSnakeSpeed.Location = new System.Drawing.Point(469, 230);
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
            this.numericUpDownSnakeSpeed.Size = new System.Drawing.Size(120, 23);
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
            this.label1.Location = new System.Drawing.Point(224, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Snake Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Snake Speed. 0-10";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSnakeSpeed);
            this.Controls.Add(this.numericUpDownSnakeSize);
            this.Controls.Add(this.ButtonStartSnake);
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
    }
}