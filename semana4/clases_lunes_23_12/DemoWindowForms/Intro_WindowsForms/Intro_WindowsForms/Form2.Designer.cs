namespace Intro_WindowsForms
{
    partial class Form2
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
            button_salir = new Button();
            SuspendLayout();
            // 
            // button_salir
            // 
            button_salir.Location = new Point(286, 84);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(75, 23);
            button_salir.TabIndex = 0;
            button_salir.Text = "Salir";
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += button_salir_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_salir);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button_salir;
    }
}