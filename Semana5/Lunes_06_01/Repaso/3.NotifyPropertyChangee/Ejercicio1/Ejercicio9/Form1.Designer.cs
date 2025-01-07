namespace Ejercicio9
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
            labelNombre = new Label();
            labelPrecio = new Label();
            textBoxNombre = new TextBox();
            textBoxPrecio = new TextBox();
            labelMostrarPrecio = new Label();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(104, 65);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(122, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre del Producto";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(115, 102);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(111, 15);
            labelPrecio.TabIndex = 1;
            labelPrecio.Text = "Precio del Producto";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(245, 62);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(230, 23);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(245, 104);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(230, 23);
            textBoxPrecio.TabIndex = 3;
            // 
            // labelMostrarPrecio
            // 
            labelMostrarPrecio.AutoSize = true;
            labelMostrarPrecio.Location = new Point(115, 169);
            labelMostrarPrecio.Name = "labelMostrarPrecio";
            labelMostrarPrecio.Size = new Size(0, 15);
            labelMostrarPrecio.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMostrarPrecio);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxNombre);
            Controls.Add(labelPrecio);
            Controls.Add(labelNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private Label labelPrecio;
        private TextBox textBoxNombre;
        private TextBox textBoxPrecio;
        private Label labelMostrarPrecio;
    }
}
