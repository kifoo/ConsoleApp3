using System.Collections;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
using CsvHelper;
using Lab3.Image;
using Lab3.Multiplication;
using static System.Net.Mime.MediaTypeNames;

namespace Lab3
{
    public partial class Form1 : Form
    {
        bool choice = true;
        bool textShow = false;
        Matrix M1;
        Matrix M2;
        Matrix result;
        ThreadClass thread;
        ParallelClass parallel;
        private Bitmap? img;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericThreads.Maximum = Environment.ProcessorCount;
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(Convert.ToInt32(0.75 * workingRectangle.Width), Convert.ToInt32(0.75 * workingRectangle.Height));
            this.Location = new Point(workingRectangle.Width / 8, workingRectangle.Height / 8);
            numericRowMatrix1.Value = 100;
            numericColumnMatrix1.Value = 100;
            numericRowMatrix2.Value = 100;
            numericColumnMatrix2.Value = 100;
            numericThreads.Value = 1;

        }
        // Get result for the matrix multiplication
        private void btnTests_Click(object sender, EventArgs e)
        {
            string binOutputPath = AppDomain.CurrentDomain.BaseDirectory;
            string binFolder = Directory.GetParent(Directory.GetParent(binOutputPath).FullName).FullName;
            string mainFolder = Directory.GetParent(Directory.GetParent(binFolder).FullName).FullName;
            string path = Path.Combine(mainFolder, "Multiplication", "results.csv");
            int[] size = [100, 200, 500, 1000];
            int[] n = [1, 2, 3, 4];
            using (var writer = new StreamWriter(path))
            {
                for (int i = 0; i < size.Length; i++)
                {
                    writer.WriteLine("Size;1;;2;;3;;4;;");
                    writer.WriteLine(";Parallel;Thread;Parallel;Thread;Parallel;Thread;Parallel;Thread;");
                    textBoxInfo.Text = $"size: {size[i]}\n";
                    for (int k = 0; k < 5; k++)
                    {
                        var output = $"";
                        textBoxInfo.Text += $"turn: {k} \n";
                        for (int j = 0; j < n.Length; j++)
                        {
                            textBoxInfo.Text += $"thread: {n[j]} \t";
                            M1 = new Matrix(size[i], size[i]);
                            M1.Initialize();
                            M2 = new Matrix(size[i], size[i]);
                            M2.Initialize();
                            thread = new ThreadClass(M1, M2, n[j]);
                            result = thread.Multiply();
                            parallel = new ParallelClass(M1, M2, n[j]);
                            result = parallel.Multiply();
                            output += $"{parallel.multiplying_time};{thread.multiplying_time};";
                        }
                        
                        writer.WriteLine($"{size[i]};{output}");
                    }
                }
            }

        }

        // Tab Matrix Multiplication

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                if (M1 == null || M2 == null)
                {
                    MessageBox.Show("Please enter the values for both matrices.");
                    return;
                }
                if (!choice)
                {
                    parallel = new ParallelClass(M1, M2, Convert.ToInt32(numericThreads.Value));
                    result = parallel.Multiply();
                    if (textShow)
                    {
                        textBoxResult.Text = Matrix.GetMatrixString(result);
                    }
                    else
                    {
                        textBoxResult.Text = "ok";
                    }
                    textBoxInfo.Text = ("Parallel\n" + parallel.GetInfo()).ToString();
                }
                else
                {
                    thread = new ThreadClass(M1, M2, Convert.ToInt32(numericThreads.Value));
                    result = thread.Multiply();
                    if (textShow)
                    {
                        textBoxResult.Text = Matrix.GetMatrixString(result);
                    }
                    else
                    {
                        textBoxResult.Text = "ok";
                    }
                    textBoxInfo.Text = ("Threads\n" + thread.GetInfo()).ToString();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Number of columns in matrix1 must be equal to number of rows in matrix2.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nbutton_Click");
            }
        }

        private void matrixAction(int m)
        {
            if (m == 1)
            {
                if (Convert.ToInt32(numericRowMatrix1.Value) > 0 && Convert.ToInt32(numericColumnMatrix1.Value) > 0)
                {
                    M1 = new(Convert.ToInt32(numericRowMatrix1.Value), Convert.ToInt32(numericColumnMatrix1.Value));
                    M1.Initialize();
                    if (textShow)
                    {
                        textBoxMatrix1.Text = Matrix.GetMatrixString(M1);
                    }
                    else
                    {
                        textBoxMatrix1.Text = "ok";
                    }
                }
            }
            else
            {
                if (Convert.ToInt32(numericRowMatrix2.Value) > 0 && Convert.ToInt32(numericColumnMatrix2.Value) > 0)
                {
                    M2 = new(Convert.ToInt32(numericRowMatrix2.Value), Convert.ToInt32(numericColumnMatrix2.Value));
                    M2.Initialize();
                    if (textShow)
                    {
                        textBoxMatrix2.Text = Matrix.GetMatrixString(M2);
                    }
                    else
                    {
                        textBoxMatrix2.Text = "ok";
                    }
                }

            }

        }

        private void numericRowMatrix1_ValueChanged(object sender, EventArgs e)
        {
            if (numericRowMatrix1.Value < 1)
            {
                numericRowMatrix1.BackColor = Color.LightCoral;
            }
            else
            {
                numericRowMatrix1.BackColor = Color.White;
                matrixAction(1);
            }
        }

        private void numericColumnMatrix1_ValueChanged(object sender, EventArgs e)
        {
            if (numericColumnMatrix1.Value < 1)
            {
                numericColumnMatrix1.BackColor = Color.LightCoral;
            }
            else
            {
                numericColumnMatrix1.BackColor = Color.White;
                matrixAction(1);
            }

        }

        private void numericRowMatrix2_ValueChanged(object sender, EventArgs e)
        {
            if (numericRowMatrix2.Value < 1)
            {
                numericRowMatrix2.BackColor = Color.LightCoral;
            }
            else
            {
                numericRowMatrix2.BackColor = Color.White;
                matrixAction(2);
            }

        }

        private void numericColumnMatrix2_ValueChanged(object sender, EventArgs e)
        {
            if (numericColumnMatrix2.Value < 1)
            {
                numericColumnMatrix2.BackColor = Color.LightCoral;
            }
            else
            {
                numericColumnMatrix2.BackColor = Color.White;
                matrixAction(2);
            }

        }

        private void numericThreads_ValueChanged(object sender, EventArgs e)
        {
            if (numericThreads.Value < 1)
            {
                numericThreads.BackColor = Color.LightCoral;
            }
            else
            {
                numericThreads.BackColor = Color.White;
            }

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                if (radioButton == rbParallel)
                {
                    rbThread.Checked = false;
                    choice = false;
                }
                else if (radioButton == rbThread)
                {
                    rbParallel.Checked = false;
                    choice = true;
                }
            }
        }
        // Tab Image Processing
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            var file = openFileDialog.FileName;
            if (file != "")
            {
                img = new Bitmap(file);
                pictureBoxOrigin.Image = img;
            }
        }
        private void btnParallelImage_Click(object sender, EventArgs e)
        {
            if (pictureBoxOrigin.Image != null)
                ImageAction(true);
            else
            {
                MessageBox.Show("Please load an image first.");
            }
        }

        private void btnThreadsImage_Click(object sender, EventArgs e)
        {
            if (pictureBoxOrigin.Image != null)
                ImageAction(false);
            else
            {
                MessageBox.Show("Please load an image first.");
            }
        }

        private void ImageAction(bool choiceImg)
        {
            ImageClasses imageProcessing = new ImageClasses(img);
            PictureBox[] pictureBox = [pictureBox1, pictureBox2, pictureBox3, pictureBox4]; 
            if (choiceImg)
            {
                // Parallel
                imageProcessing.ParrallelConverter(pictureBox);
            }
            else
            {
                // Threads
                imageProcessing.ThreadConverter(pictureBox);
            }
        }

        private void rbTextShow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTextShow.CheckState == CheckState.Checked)
            {
                textShow = true;
            }
            else
            {
                textShow = false;
            }
        }
    }
}
