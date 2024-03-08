using Lab1;

namespace GUI
{
    public partial class Form1 : Form
    {
        Problem problem;
        int n;
        int seed;
        int capacity;

        public Form1()
        {
            InitializeComponent();
        }

        public void run_problem()
        {
            problem = new Problem(n, seed);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox1.Text, out value) && value > 0)
            {
                n = value;
            }
            else
            {
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox2.Text, out value) && value > 0)
            {
                seed = value;
            }
            else
            {
                textBox1.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox3.Text, out value) && value > 0)
            {
                capacity = value;
            }
            else
            {
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            problem = new Problem(n, seed);

            if (problem != null)
            {
                problem.Solve(capacity);
                listBox1.Text = problem.items.ToString();
                listBox.Text = problem.Result_obj.ToString();
 
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Item)
            {
                Item selectedItem = (Item)listBox1.SelectedItem;
                // textBox3.Text = selectedItem.ToString();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
