namespace Lab3
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
            numericRowMatrix1 = new NumericUpDown();
            numericRowMatrix2 = new NumericUpDown();
            numericThreads = new NumericUpDown();
            button = new Button();
            labelMatrix1 = new Label();
            labelMatrix2 = new Label();
            numericColumnMatrix1 = new NumericUpDown();
            numericColumnMatrix2 = new NumericUpDown();
            labelRow1 = new Label();
            labelRow2 = new Label();
            labelCol1 = new Label();
            labelCol2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            labelThreads = new Label();
            rbTextShow = new CheckBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBoxMatrix1 = new RichTextBox();
            textBoxMatrix2 = new RichTextBox();
            textBoxResult = new RichTextBox();
            textBoxInfo = new RichTextBox();
            rbThread = new RadioButton();
            rbParallel = new RadioButton();
            panel1 = new Panel();
            btnTests = new Button();
            tabControl1 = new TabControl();
            tabCalculateMatrix = new TabPage();
            tabImageProcess = new TabPage();
            btnLoadImage = new Button();
            btnParallelImage = new Button();
            btnThreadsImage = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBoxOrigin = new PictureBox();
            openFileDialog = new OpenFileDialog();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericRowMatrix1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRowMatrix2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericThreads).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericColumnMatrix1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericColumnMatrix2).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabCalculateMatrix.SuspendLayout();
            tabImageProcess.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrigin).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // numericRowMatrix1
            // 
            numericRowMatrix1.AccessibleDescription = "";
            numericRowMatrix1.BackColor = SystemColors.Window;
            numericRowMatrix1.Location = new Point(3, 43);
            numericRowMatrix1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericRowMatrix1.Name = "numericRowMatrix1";
            numericRowMatrix1.Size = new Size(155, 23);
            numericRowMatrix1.TabIndex = 3;
            numericRowMatrix1.ValueChanged += numericRowMatrix1_ValueChanged;
            // 
            // numericRowMatrix2
            // 
            numericRowMatrix2.Location = new Point(167, 43);
            numericRowMatrix2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericRowMatrix2.Name = "numericRowMatrix2";
            numericRowMatrix2.Size = new Size(155, 23);
            numericRowMatrix2.TabIndex = 4;
            numericRowMatrix2.ValueChanged += numericRowMatrix2_ValueChanged;
            // 
            // numericThreads
            // 
            numericThreads.Location = new Point(331, 43);
            numericThreads.Name = "numericThreads";
            numericThreads.Size = new Size(155, 23);
            numericThreads.TabIndex = 5;
            numericThreads.ValueChanged += numericThreads_ValueChanged;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 14F);
            button.Location = new Point(514, 74);
            button.Name = "button";
            button.Size = new Size(132, 40);
            button.TabIndex = 7;
            button.Text = "Calculate";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // labelMatrix1
            // 
            labelMatrix1.AutoSize = true;
            labelMatrix1.Font = new Font("Segoe UI", 14F);
            labelMatrix1.Location = new Point(3, 0);
            labelMatrix1.Name = "labelMatrix1";
            labelMatrix1.Size = new Size(81, 25);
            labelMatrix1.TabIndex = 10;
            labelMatrix1.Text = "Matrix 1";
            // 
            // labelMatrix2
            // 
            labelMatrix2.AutoSize = true;
            labelMatrix2.Font = new Font("Segoe UI", 14F);
            labelMatrix2.Location = new Point(167, 0);
            labelMatrix2.Name = "labelMatrix2";
            labelMatrix2.Size = new Size(81, 25);
            labelMatrix2.TabIndex = 11;
            labelMatrix2.Text = "Matrix 2";
            // 
            // numericColumnMatrix1
            // 
            numericColumnMatrix1.Location = new Point(3, 87);
            numericColumnMatrix1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericColumnMatrix1.Name = "numericColumnMatrix1";
            numericColumnMatrix1.Size = new Size(155, 23);
            numericColumnMatrix1.TabIndex = 12;
            numericColumnMatrix1.ValueChanged += numericColumnMatrix1_ValueChanged;
            // 
            // numericColumnMatrix2
            // 
            numericColumnMatrix2.Location = new Point(167, 87);
            numericColumnMatrix2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericColumnMatrix2.Name = "numericColumnMatrix2";
            numericColumnMatrix2.Size = new Size(155, 23);
            numericColumnMatrix2.TabIndex = 13;
            numericColumnMatrix2.ValueChanged += numericColumnMatrix2_ValueChanged;
            // 
            // labelRow1
            // 
            labelRow1.AutoSize = true;
            labelRow1.Location = new Point(3, 25);
            labelRow1.Name = "labelRow1";
            labelRow1.Size = new Size(80, 15);
            labelRow1.TabIndex = 14;
            labelRow1.Text = "Rows number";
            // 
            // labelRow2
            // 
            labelRow2.AutoSize = true;
            labelRow2.Location = new Point(167, 25);
            labelRow2.Name = "labelRow2";
            labelRow2.Size = new Size(80, 15);
            labelRow2.TabIndex = 15;
            labelRow2.Text = "Rows number";
            // 
            // labelCol1
            // 
            labelCol1.AutoSize = true;
            labelCol1.Location = new Point(3, 69);
            labelCol1.Name = "labelCol1";
            labelCol1.Size = new Size(100, 15);
            labelCol1.TabIndex = 16;
            labelCol1.Text = "Columns number";
            // 
            // labelCol2
            // 
            labelCol2.AutoSize = true;
            labelCol2.Location = new Point(167, 69);
            labelCol2.Name = "labelCol2";
            labelCol2.Size = new Size(100, 15);
            labelCol2.TabIndex = 17;
            labelCol2.Text = "Columns number";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(label1, 2, 1);
            tableLayoutPanel2.Controls.Add(labelRow2, 1, 1);
            tableLayoutPanel2.Controls.Add(numericColumnMatrix2, 1, 4);
            tableLayoutPanel2.Controls.Add(numericThreads, 2, 2);
            tableLayoutPanel2.Controls.Add(labelCol2, 1, 3);
            tableLayoutPanel2.Controls.Add(numericColumnMatrix1, 0, 4);
            tableLayoutPanel2.Controls.Add(labelRow1, 0, 1);
            tableLayoutPanel2.Controls.Add(labelCol1, 0, 3);
            tableLayoutPanel2.Controls.Add(numericRowMatrix1, 0, 2);
            tableLayoutPanel2.Controls.Add(numericRowMatrix2, 1, 2);
            tableLayoutPanel2.Controls.Add(labelMatrix1, 0, 0);
            tableLayoutPanel2.Controls.Add(labelMatrix2, 1, 0);
            tableLayoutPanel2.Controls.Add(labelThreads, 2, 0);
            tableLayoutPanel2.Controls.Add(rbTextShow, 2, 4);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(494, 111);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 25);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 19;
            label1.Text = "Number of Threads";
            // 
            // labelThreads
            // 
            labelThreads.AutoSize = true;
            labelThreads.Font = new Font("Segoe UI", 14F);
            labelThreads.Location = new Point(331, 0);
            labelThreads.Name = "labelThreads";
            labelThreads.Size = new Size(79, 25);
            labelThreads.TabIndex = 20;
            labelThreads.Text = "Threads";
            // 
            // rbTextShow
            // 
            rbTextShow.AutoSize = true;
            rbTextShow.Dock = DockStyle.Fill;
            rbTextShow.Location = new Point(331, 87);
            rbTextShow.Name = "rbTextShow";
            rbTextShow.Size = new Size(160, 23);
            rbTextShow.TabIndex = 21;
            rbTextShow.Text = "Show Matrixes";
            rbTextShow.UseVisualStyleBackColor = true;
            rbTextShow.CheckedChanged += rbTextShow_CheckedChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Controls.Add(textBoxMatrix1, 0, 0);
            tableLayoutPanel3.Controls.Add(textBoxMatrix2, 1, 0);
            tableLayoutPanel3.Controls.Add(textBoxResult, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 233);
            tableLayoutPanel3.MinimumSize = new Size(300, 100);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1272, 314);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // textBoxMatrix1
            // 
            textBoxMatrix1.Dock = DockStyle.Fill;
            textBoxMatrix1.Location = new Point(3, 3);
            textBoxMatrix1.MinimumSize = new Size(100, 100);
            textBoxMatrix1.Name = "textBoxMatrix1";
            textBoxMatrix1.Size = new Size(417, 308);
            textBoxMatrix1.TabIndex = 0;
            textBoxMatrix1.Text = "";
            // 
            // textBoxMatrix2
            // 
            textBoxMatrix2.Dock = DockStyle.Fill;
            textBoxMatrix2.Location = new Point(426, 3);
            textBoxMatrix2.MinimumSize = new Size(100, 100);
            textBoxMatrix2.Name = "textBoxMatrix2";
            textBoxMatrix2.Size = new Size(418, 308);
            textBoxMatrix2.TabIndex = 1;
            textBoxMatrix2.Text = "";
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(850, 3);
            textBoxResult.MinimumSize = new Size(100, 100);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(419, 308);
            textBoxResult.TabIndex = 2;
            textBoxResult.Text = "";
            // 
            // textBoxInfo
            // 
            textBoxInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxInfo.Location = new Point(665, 9);
            textBoxInfo.MinimumSize = new Size(200, 104);
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.Size = new Size(589, 203);
            textBoxInfo.TabIndex = 20;
            textBoxInfo.Text = "";
            // 
            // rbThread
            // 
            rbThread.AutoSize = true;
            rbThread.Checked = true;
            rbThread.Location = new Point(530, 9);
            rbThread.Name = "rbThread";
            rbThread.Size = new Size(93, 19);
            rbThread.TabIndex = 21;
            rbThread.TabStop = true;
            rbThread.Text = "using Thread";
            rbThread.UseVisualStyleBackColor = true;
            rbThread.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // rbParallel
            // 
            rbParallel.AutoSize = true;
            rbParallel.Location = new Point(530, 34);
            rbParallel.Name = "rbParallel";
            rbParallel.Size = new Size(95, 19);
            rbParallel.TabIndex = 22;
            rbParallel.Text = "using Parallel";
            rbParallel.UseVisualStyleBackColor = true;
            rbParallel.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTests);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(textBoxInfo);
            panel1.Controls.Add(rbParallel);
            panel1.Controls.Add(rbThread);
            panel1.Controls.Add(button);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1272, 547);
            panel1.TabIndex = 23;
            // 
            // btnTests
            // 
            btnTests.Location = new Point(181, 136);
            btnTests.Name = "btnTests";
            btnTests.Size = new Size(117, 34);
            btnTests.TabIndex = 23;
            btnTests.Text = "RunTests";
            btnTests.UseVisualStyleBackColor = true;
            btnTests.Click += btnTests_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCalculateMatrix);
            tabControl1.Controls.Add(tabImageProcess);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1286, 581);
            tabControl1.TabIndex = 23;
            // 
            // tabCalculateMatrix
            // 
            tabCalculateMatrix.Controls.Add(panel1);
            tabCalculateMatrix.Location = new Point(4, 24);
            tabCalculateMatrix.Name = "tabCalculateMatrix";
            tabCalculateMatrix.Padding = new Padding(3);
            tabCalculateMatrix.Size = new Size(1278, 553);
            tabCalculateMatrix.TabIndex = 0;
            tabCalculateMatrix.Text = "Calculate Matrix";
            tabCalculateMatrix.UseVisualStyleBackColor = true;
            // 
            // tabImageProcess
            // 
            tabImageProcess.Controls.Add(panel2);
            tabImageProcess.Controls.Add(tableLayoutPanel1);
            tabImageProcess.Location = new Point(4, 24);
            tabImageProcess.Name = "tabImageProcess";
            tabImageProcess.Padding = new Padding(3);
            tabImageProcess.Size = new Size(1278, 553);
            tabImageProcess.TabIndex = 1;
            tabImageProcess.Text = "Image Processing";
            tabImageProcess.UseVisualStyleBackColor = true;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLoadImage.Location = new Point(142, 392);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(161, 40);
            btnLoadImage.TabIndex = 4;
            btnLoadImage.Text = "Load Image";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // btnParallelImage
            // 
            btnParallelImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnParallelImage.Location = new Point(442, 293);
            btnParallelImage.Name = "btnParallelImage";
            btnParallelImage.Size = new Size(121, 40);
            btnParallelImage.TabIndex = 3;
            btnParallelImage.Text = "Parallel";
            btnParallelImage.UseVisualStyleBackColor = true;
            btnParallelImage.Click += btnParallelImage_Click;
            // 
            // btnThreadsImage
            // 
            btnThreadsImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThreadsImage.Location = new Point(442, 247);
            btnThreadsImage.Name = "btnThreadsImage";
            btnThreadsImage.Size = new Size(121, 40);
            btnThreadsImage.TabIndex = 2;
            btnThreadsImage.Text = "Thread";
            btnThreadsImage.UseVisualStyleBackColor = true;
            btnThreadsImage.Click += btnThreadsImage_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(578, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(697, 547);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Location = new Point(351, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(343, 267);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Location = new Point(3, 276);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(342, 268);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Location = new Point(351, 276);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(343, 268);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBoxOrigin
            // 
            pictureBoxOrigin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxOrigin.Location = new Point(30, 102);
            pictureBoxOrigin.Name = "pictureBoxOrigin";
            pictureBoxOrigin.Size = new Size(406, 284);
            pictureBoxOrigin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOrigin.TabIndex = 0;
            pictureBoxOrigin.TabStop = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnThreadsImage);
            panel2.Controls.Add(btnLoadImage);
            panel2.Controls.Add(btnParallelImage);
            panel2.Controls.Add(pictureBoxOrigin);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 539);
            panel2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 581);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1230, 620);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericRowMatrix1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRowMatrix2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericThreads).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericColumnMatrix1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericColumnMatrix2).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabCalculateMatrix.ResumeLayout(false);
            tabImageProcess.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrigin).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown numericRowMatrix1;
        private NumericUpDown numericRowMatrix2;
        private NumericUpDown numericThreads;
        private Button button;
        private Label labelMatrix1;
        private Label labelMatrix2;
        private NumericUpDown numericColumnMatrix1;
        private NumericUpDown numericColumnMatrix2;
        private Label labelRow1;
        private Label labelRow2;
        private Label labelCol1;
        private Label labelCol2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label labelThreads;
        private TableLayoutPanel tableLayoutPanel3;
        private RichTextBox textBoxMatrix1;
        private RichTextBox textBoxMatrix2;
        private RichTextBox textBoxResult;
        private RichTextBox textBoxInfo;
        private RadioButton rbThread;
        private RadioButton rbParallel;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabCalculateMatrix;
        private TabPage tabImageProcess;
        private Button btnParallelImage;
        private Button btnThreadsImage;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBoxOrigin;
        private Button btnLoadImage;
        private OpenFileDialog openFileDialog;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnTests;
        private CheckBox rbTextShow;
        private Panel panel2;
    }
}
