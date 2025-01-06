namespace Intro_WindowsForms
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
            txt_Nombres = new Label();
            textBox_Nombres = new TextBox();
            textBox_Apellidos = new TextBox();
            txt_Edad = new Label();
            textBox_Edad = new TextBox();
            txt_Apellidos = new Label();
            button_Save = new Button();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            newWindow = new Button();
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            test2ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            test1ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Nombres
            // 
            txt_Nombres.AutoSize = true;
            txt_Nombres.Font = new Font("Snap ITC", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Nombres.ForeColor = SystemColors.MenuText;
            txt_Nombres.Location = new Point(18, 28);
            txt_Nombres.Name = "txt_Nombres";
            txt_Nombres.Size = new Size(206, 48);
            txt_Nombres.TabIndex = 0;
            txt_Nombres.Text = "Nombres";
            // 
            // textBox_Nombres
            // 
            textBox_Nombres.Location = new Point(230, 51);
            textBox_Nombres.Name = "textBox_Nombres";
            textBox_Nombres.Size = new Size(100, 23);
            textBox_Nombres.TabIndex = 1;
            // 
            // textBox_Apellidos
            // 
            textBox_Apellidos.Location = new Point(218, 108);
            textBox_Apellidos.Name = "textBox_Apellidos";
            textBox_Apellidos.Size = new Size(100, 23);
            textBox_Apellidos.TabIndex = 3;
            // 
            // txt_Edad
            // 
            txt_Edad.AutoSize = true;
            txt_Edad.Location = new Point(135, 141);
            txt_Edad.Name = "txt_Edad";
            txt_Edad.Size = new Size(33, 15);
            txt_Edad.TabIndex = 2;
            txt_Edad.Text = "Edad";
            // 
            // textBox_Edad
            // 
            textBox_Edad.Location = new Point(218, 138);
            textBox_Edad.Name = "textBox_Edad";
            textBox_Edad.Size = new Size(100, 23);
            textBox_Edad.TabIndex = 5;
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.AutoSize = true;
            txt_Apellidos.Location = new Point(135, 111);
            txt_Apellidos.Name = "txt_Apellidos";
            txt_Apellidos.Size = new Size(56, 15);
            txt_Apellidos.TabIndex = 6;
            txt_Apellidos.Text = "Apellidos";
            // 
            // button_Save
            // 
            button_Save.Location = new Point(177, 203);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(75, 23);
            button_Save.TabIndex = 8;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(135, 174);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(376, 65);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Inicializar barra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // newWindow
            // 
            newWindow.Location = new Point(379, 128);
            newWindow.Name = "newWindow";
            newWindow.Size = new Size(126, 23);
            newWindow.TabIndex = 11;
            newWindow.Text = "nueva ventana";
            newWindow.UseVisualStyleBackColor = true;
            newWindow.Click += newWindow_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 727);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { test2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // test2ToolStripMenuItem
            // 
            test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            test2ToolStripMenuItem.Size = new Size(48, 20);
            test2ToolStripMenuItem.Text = "Test 2";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { test1ToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(984, 24);
            menuStrip2.TabIndex = 14;
            menuStrip2.Text = "menuStrip2";
            // 
            // test1ToolStripMenuItem
            // 
            test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            test1ToolStripMenuItem.Size = new Size(45, 20);
            test1ToolStripMenuItem.Text = "Test1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 749);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(newWindow);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(button_Save);
            Controls.Add(txt_Apellidos);
            Controls.Add(textBox_Edad);
            Controls.Add(textBox_Apellidos);
            Controls.Add(txt_Edad);
            Controls.Add(textBox_Nombres);
            Controls.Add(txt_Nombres);
            ForeColor = SystemColors.InactiveCaption;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_Nombres;
        private TextBox textBox_Nombres;
        private TextBox textBox_Apellidos;
        private Label txt_Edad;
        private TextBox textBox_Edad;
        private Label txt_Apellidos;
        private Button button_Save;
        private ProgressBar progressBar1;
        private Button button1;
        private Button newWindow;
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem test2ToolStripMenuItem;
        private ToolStripMenuItem test1ToolStripMenuItem;
    }
}
