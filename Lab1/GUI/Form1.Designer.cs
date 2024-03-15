namespace GUI
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(23, 207);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(197, 37);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 4;
            label1.Text = "Number of elements";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 75);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 5;
            label2.Text = "Seed Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 141);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Capacity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 9;
            label4.Text = "Instance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 251);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 11;
            label5.Text = "Result";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(23, 285);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(197, 120);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(263, 37);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(426, 368);
            richTextBox2.TabIndex = 15;
            richTextBox2.Text = "";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(25, 44);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(195, 27);
            numericUpDown1.TabIndex = 16;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(26, 105);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(194, 27);
            numericUpDown2.TabIndex = 17;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(28, 170);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(192, 27);
            numericUpDown3.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 443);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
    }
}
