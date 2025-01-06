namespace AplicacionVentas
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
            groupBox1 = new GroupBox();
            textBoxCliente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelFecha = new Label();
            labelHora = new Label();
            groupBox2 = new GroupBox();
            buttonCancelar = new Button();
            buttonRegistrar = new Button();
            labelPrecio = new Label();
            label8 = new Label();
            textBoxCantidad = new TextBox();
            label6 = new Label();
            comboBoxProducto = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            listView1 = new ListView();
            Producto = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label9 = new Label();
            labelTotal = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 19);
            label1.Name = "label1";
            label1.Size = new Size(519, 39);
            label1.TabIndex = 0;
            label1.Text = "Control de Ventas de Productos";
            label1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 118);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            groupBox1.UseWaitCursor = true;
            // 
            // textBoxCliente
            // 
            textBoxCliente.Location = new Point(24, 67);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(310, 29);
            textBoxCliente.TabIndex = 1;
            textBoxCliente.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 39);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 0;
            label2.Text = "Cliente";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(472, 101);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "Fecha";
            label3.TextAlign = ContentAlignment.BottomRight;
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(620, 101);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 3;
            label4.Text = "Hora";
            label4.UseWaitCursor = true;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.Location = new Point(472, 154);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(0, 25);
            labelFecha.TabIndex = 4;
            labelFecha.UseWaitCursor = true;
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHora.Location = new Point(615, 154);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(0, 25);
            labelHora.TabIndex = 5;
            labelHora.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonCancelar);
            groupBox2.Controls.Add(buttonRegistrar);
            groupBox2.Controls.Add(labelPrecio);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBoxCantidad);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBoxProducto);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(24, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(764, 146);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Venta";
            groupBox2.UseWaitCursor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.Yellow;
            buttonCancelar.FlatAppearance.BorderColor = Color.Olive;
            buttonCancelar.FlatAppearance.BorderSize = 2;
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.Red;
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.Red;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Location = new Point(636, 34);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(97, 35);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.UseWaitCursor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.Yellow;
            buttonRegistrar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            buttonRegistrar.FlatAppearance.BorderSize = 4;
            buttonRegistrar.FlatAppearance.MouseDownBackColor = Color.Lime;
            buttonRegistrar.FlatAppearance.MouseOverBackColor = Color.Lime;
            buttonRegistrar.FlatStyle = FlatStyle.Flat;
            buttonRegistrar.Location = new Point(636, 84);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(97, 45);
            buttonRegistrar.TabIndex = 7;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.UseWaitCursor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio.Location = new Point(529, 84);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(0, 25);
            labelPrecio.TabIndex = 6;
            labelPrecio.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(529, 31);
            label8.Name = "label8";
            label8.Size = new Size(68, 25);
            label8.TabIndex = 5;
            label8.Text = "Precio";
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.UseWaitCursor = true;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(376, 75);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(100, 29);
            textBoxCantidad.TabIndex = 3;
            textBoxCantidad.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 34);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 2;
            label6.Text = "Cantidad";
            label6.UseWaitCursor = true;
            // 
            // comboBoxProducto
            // 
            comboBoxProducto.FormattingEnabled = true;
            comboBoxProducto.Location = new Point(26, 75);
            comboBoxProducto.Name = "comboBoxProducto";
            comboBoxProducto.Size = new Size(308, 29);
            comboBoxProducto.TabIndex = 1;
            comboBoxProducto.UseWaitCursor = true;
            comboBoxProducto.SelectedIndexChanged += comboBoxProducto_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 34);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 0;
            label5.Text = "Producto";
            label5.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 389);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 7;
            label7.Text = "ListView";
            label7.UseWaitCursor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Producto, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(24, 407);
            listView1.Name = "listView1";
            listView1.Size = new Size(764, 184);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.UseWaitCursor = true;
            listView1.View = View.Details;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 260;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Sub-Total";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Descuento";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Neto";
            columnHeader6.Width = 100;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(536, 613);
            label9.Name = "label9";
            label9.Size = new Size(116, 30);
            label9.TabIndex = 9;
            label9.Text = "Total Neto";
            label9.UseWaitCursor = true;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(683, 613);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(61, 30);
            labelTotal.TabIndex = 10;
            labelTotal.Text = "Total";
            labelTotal.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 661);
            Controls.Add(labelTotal);
            Controls.Add(label9);
            Controls.Add(listView1);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(labelHora);
            Controls.Add(labelFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            UseWaitCursor = true;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxCliente;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelFecha;
        private Label labelHora;
        private GroupBox groupBox2;
        private Button buttonCancelar;
        private Button buttonRegistrar;
        private Label labelPrecio;
        private Label label8;
        private TextBox textBoxCantidad;
        private Label label6;
        private ComboBox comboBoxProducto;
        private Label label5;
        private Label label7;
        private ListView listView1;
        private ColumnHeader Producto;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label9;
        private Label labelTotal;
    }
}
