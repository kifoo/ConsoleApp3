using Lab1;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(numericUpDown1.Text, out int n) && n > 0) { }
            if (int.TryParse(numericUpDown2.Text, out int seed) && seed > 0) { }
            if (int.TryParse(numericUpDown3.Text, out int capacity) && capacity > 0) { }

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
