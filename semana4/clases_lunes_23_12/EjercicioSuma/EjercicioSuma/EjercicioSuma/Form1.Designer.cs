namespace EjercicioSuma
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label_Resultado = new Label();
            textBox_primerNumero = new TextBox();
            textBox_SegundoNumero = new TextBox();
            button_Limpiar = new Button();
            button_Cerrar = new Button();
            button_Calcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 41);
            label1.Name = "label1";
            label1.Size = new Size(288, 45);
            label1.TabIndex = 0;
            label1.Text = "Suma de Ejercicios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 123);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 1;
            label2.Text = "primer Numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(151, 182);
            label3.Name = "label3";
            label3.Size = new Size(202, 32);
            label3.TabIndex = 2;
            label3.Text = "segundo Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(151, 249);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 3;
            label4.Text = "Resultado";
            // 
            // label_Resultado
            // 
            label_Resultado.AutoSize = true;
            label_Resultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Resultado.Location = new Point(390, 249);
            label_Resultado.Name = "label_Resultado";
            label_Resultado.Size = new Size(0, 32);
            label_Resultado.TabIndex = 4;
            // 
            // textBox_primerNumero
            // 
            textBox_primerNumero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_primerNumero.Location = new Point(390, 120);
            textBox_primerNumero.Name = "textBox_primerNumero";
            textBox_primerNumero.Size = new Size(224, 35);
            textBox_primerNumero.TabIndex = 5;
            // 
            // textBox_SegundoNumero
            // 
            textBox_SegundoNumero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_SegundoNumero.Location = new Point(390, 181);
            textBox_SegundoNumero.Name = "textBox_SegundoNumero";
            textBox_SegundoNumero.Size = new Size(224, 35);
            textBox_SegundoNumero.TabIndex = 7;
            // 
            // button_Limpiar
            // 
            button_Limpiar.BackColor = Color.FromArgb(128, 128, 255);
            button_Limpiar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Limpiar.Location = new Point(141, 329);
            button_Limpiar.Name = "button_Limpiar";
            button_Limpiar.Size = new Size(111, 45);
            button_Limpiar.TabIndex = 8;
            button_Limpiar.Text = "Limpiar";
            button_Limpiar.UseVisualStyleBackColor = false;
            button_Limpiar.Click += button_Limpiar_Click;
            // 
            // button_Cerrar
            // 
            button_Cerrar.BackColor = Color.FromArgb(255, 255, 192);
            button_Cerrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Cerrar.Location = new Point(501, 336);
            button_Cerrar.Name = "button_Cerrar";
            button_Cerrar.Size = new Size(113, 38);
            button_Cerrar.TabIndex = 9;
            button_Cerrar.Text = "Cerrar";
            button_Cerrar.UseVisualStyleBackColor = false;
            button_Cerrar.Click += button_Cerrar_Click;
            // 
            // button_Calcular
            // 
            button_Calcular.BackColor = Color.FromArgb(192, 255, 192);
            button_Calcular.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Calcular.Location = new Point(313, 333);
            button_Calcular.Name = "button_Calcular";
            button_Calcular.Size = new Size(112, 44);
            button_Calcular.TabIndex = 10;
            button_Calcular.Text = "Calcular";
            button_Calcular.UseVisualStyleBackColor = false;
            button_Calcular.Click += button_Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Calcular);
            Controls.Add(button_Cerrar);
            Controls.Add(button_Limpiar);
            Controls.Add(textBox_SegundoNumero);
            Controls.Add(textBox_primerNumero);
            Controls.Add(label_Resultado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label_Resultado;
        private TextBox textBox_primerNumero;
        private TextBox textBox_SegundoNumero;
        private Button button_Limpiar;
        private Button button_Cerrar;
        private Button button_Calcular;
    }
}
