namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 5;
                //label2.Text = progressBar1.Value.ToString()+ "%";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}