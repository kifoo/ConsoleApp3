namespace API_GUI
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private async void buttonDownload_ClickAsync(object sender, EventArgs e)
        {
            string call = " http :// radoslaw . idzikowski . staff . iiar . pwr . wroc .pl/instruction / students.json ";
            string response = await client.GetStringAsync(call);
            //textBoxResponse.Text = response;
        }
     }
}
