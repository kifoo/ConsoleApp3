using Lab1;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            int seed = 0;
            int capacity = 0;

            if (int.TryParse(numericUpDown1.Text, out int value) && value > 0)
            {
                n = value;
            }
            if (int.TryParse(numericUpDown2.Text, out value) && value > 0)
            {
                seed = value;
            }
            if (int.TryParse(numericUpDown3.Text, out value) && value > 0)
            {
                capacity = value;
            }

            Problem problem = new(n, seed);

            if (problem != null)
            {
                problem.Solve(capacity);
                richTextBox1.Text = problem.Result_obj.ToString();
                richTextBox2.Text = problem.ToString();
                
            }
        }
    }
}
