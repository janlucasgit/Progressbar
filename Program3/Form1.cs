namespace Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsRunning = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value += 10;
                Application.DoEvents();
            }

            
        }

        private void Schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zurücksetzen_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
