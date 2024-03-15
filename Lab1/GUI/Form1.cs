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

            if (int.TryParse(textBox1.Text, out int value) && value > 0)
            {
                n = value;
            }
            else
            {
                textBox1.Clear();
            }
            if (int.TryParse(textBox2.Text, out value) && value > 0)
            {
                seed = value;
            }
            else
            {
                textBox2.Clear();
            }
            if (int.TryParse(textBox3.Text, out value) && value > 0)
            {
                capacity = value;
            }
            else
            {
                textBox3.Clear();
            }

            Problem problem = new(n, seed);

            if (problem != null)
            {
                string res = "";
                problem.Solve(capacity);
                listBox1.Items.Add("Total value: " + problem.Result_obj.Total_value);
                listBox1.Items.Add("Total weight: " + problem.Result_obj.Total_weight);
                for (int i = 0; i < problem.Result_obj.result.Count; i++)
                {
                    res += problem.Result_obj.result[i].Id + ", ";
                }
                listBox1.Items.Add("Items: " + res);
                for (int i = 0; i < problem.items.Count; i++)
                {
                    listBox2.Items.Add(problem.items[i].ToString());
                    
                }

            }
        }
    }
}
