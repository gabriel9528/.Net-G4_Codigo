namespace BindingSource2
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
            textBoxName = new TextBox();
            textBoxAge = new TextBox();
            dataGridView1 = new DataGridView();
            buttonName = new Button();
            buttonAge = new Button();
            buttonSave = new Button();
            listView1 = new ListView();
            listView2 = new ListView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(387, 35);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(175, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(387, 84);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(175, 23);
            textBoxAge.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(280, 195);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // buttonName
            // 
            buttonName.Location = new Point(31, 286);
            buttonName.Name = "buttonName";
            buttonName.Size = new Size(75, 23);
            buttonName.TabIndex = 3;
            buttonName.Text = "Name";
            buttonName.UseVisualStyleBackColor = true;
            buttonName.Click += buttonName_Click;
            // 
            // buttonAge
            // 
            buttonAge.Location = new Point(123, 288);
            buttonAge.Name = "buttonAge";
            buttonAge.Size = new Size(75, 23);
            buttonAge.TabIndex = 4;
            buttonAge.Text = "Age";
            buttonAge.UseVisualStyleBackColor = true;
            buttonAge.Click += buttonAge_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(223, 288);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(366, 142);
            listView1.Name = "listView1";
            listView1.Size = new Size(392, 62);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(363, 240);
            listView2.Name = "listView2";
            listView2.Size = new Size(395, 71);
            listView2.TabIndex = 7;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(buttonSave);
            Controls.Add(buttonAge);
            Controls.Add(buttonName);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ListView listView2;
    }
}
