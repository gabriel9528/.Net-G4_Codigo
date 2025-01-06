namespace Tic_Tac_Toc
{
    partial class Form1
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            buttonExit = new Button();
            button1Reset = new Button();
            buttonNewGame = new Button();
            panel4 = new Panel();
            labelPlayer0 = new Label();
            labelPlayerX = new Label();
            labelPlayer00 = new Label();
            labelPlayerXX = new Label();
            panel3 = new Panel();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1260, 108);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(1166, 68);
            label1.TabIndex = 0;
            label1.Text = "JUEGO TIC TAC TOC - WINDOWS FORMS";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(1260, 612);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(buttonExit);
            panel5.Controls.Add(button1Reset);
            panel5.Controls.Add(buttonNewGame);
            panel5.Location = new Point(665, 248);
            panel5.Name = "panel5";
            panel5.Size = new Size(576, 260);
            panel5.TabIndex = 4;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.White;
            buttonExit.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(285, 132);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(284, 110);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // button1Reset
            // 
            button1Reset.BackColor = Color.White;
            button1Reset.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1Reset.Location = new Point(3, 132);
            button1Reset.Name = "button1Reset";
            button1Reset.Size = new Size(276, 110);
            button1Reset.TabIndex = 8;
            button1Reset.Text = "Reset";
            button1Reset.UseVisualStyleBackColor = false;
            button1Reset.Click += button1Reset_Click;
            // 
            // buttonNewGame
            // 
            buttonNewGame.BackColor = Color.White;
            buttonNewGame.Font = new Font("Segoe UI Semibold", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNewGame.Location = new Point(3, 3);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(566, 123);
            buttonNewGame.TabIndex = 7;
            buttonNewGame.Text = "New Game";
            buttonNewGame.UseVisualStyleBackColor = false;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(labelPlayer0);
            panel4.Controls.Add(labelPlayerX);
            panel4.Controls.Add(labelPlayer00);
            panel4.Controls.Add(labelPlayerXX);
            panel4.Location = new Point(665, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(576, 227);
            panel4.TabIndex = 3;
            // 
            // labelPlayer0
            // 
            labelPlayer0.AutoSize = true;
            labelPlayer0.BackColor = Color.White;
            labelPlayer0.BorderStyle = BorderStyle.Fixed3D;
            labelPlayer0.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayer0.Location = new Point(281, 115);
            labelPlayer0.Name = "labelPlayer0";
            labelPlayer0.Size = new Size(75, 88);
            labelPlayer0.TabIndex = 3;
            labelPlayer0.Text = "0";
            labelPlayer0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPlayerX
            // 
            labelPlayerX.AutoSize = true;
            labelPlayerX.BackColor = Color.White;
            labelPlayerX.BorderStyle = BorderStyle.Fixed3D;
            labelPlayerX.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayerX.Location = new Point(281, 13);
            labelPlayerX.Name = "labelPlayerX";
            labelPlayerX.Size = new Size(75, 88);
            labelPlayerX.TabIndex = 2;
            labelPlayerX.Text = "0";
            // 
            // labelPlayer00
            // 
            labelPlayer00.AutoSize = true;
            labelPlayer00.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayer00.Location = new Point(3, 115);
            labelPlayer00.Name = "labelPlayer00";
            labelPlayer00.Size = new Size(284, 86);
            labelPlayer00.TabIndex = 1;
            labelPlayer00.Text = "Player 0:";
            // 
            // labelPlayerXX
            // 
            labelPlayerXX.AutoSize = true;
            labelPlayerXX.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayerXX.Location = new Point(3, 13);
            labelPlayerXX.Name = "labelPlayerXX";
            labelPlayerXX.Size = new Size(288, 86);
            labelPlayerXX.TabIndex = 0;
            labelPlayerXX.Text = "Player X:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(13, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(646, 493);
            panel3.TabIndex = 2;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 96F);
            button7.Location = new Point(16, 325);
            button7.Name = "button7";
            button7.Size = new Size(200, 150);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Segoe UI", 96F);
            button8.Location = new Point(222, 325);
            button8.Name = "button8";
            button8.Size = new Size(200, 150);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Font = new Font("Segoe UI", 96F);
            button9.Location = new Point(428, 325);
            button9.Name = "button9";
            button9.Size = new Size(200, 150);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 96F);
            button4.Location = new Point(16, 169);
            button4.Name = "button4";
            button4.Size = new Size(200, 150);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI", 96F);
            button5.Location = new Point(222, 169);
            button5.Name = "button5";
            button5.Size = new Size(200, 150);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 96F);
            button6.Location = new Point(428, 169);
            button6.Name = "button6";
            button6.Size = new Size(200, 150);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 96F);
            button3.Location = new Point(428, 13);
            button3.Name = "button3";
            button3.Size = new Size(200, 150);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 96F);
            button2.Location = new Point(222, 13);
            button2.Name = "button2";
            button2.Size = new Size(200, 150);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 96F);
            button1.Location = new Point(16, 13);
            button1.Name = "button1";
            button1.Size = new Size(200, 150);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(968, 517);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Tic Tac Toc";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonExit;
        private Button button1Reset;
        private Button buttonNewGame;
        private Label labelPlayer0;
        private Label labelPlayerX;
        private Label labelPlayer00;
        private Label labelPlayerXX;
    }
}
