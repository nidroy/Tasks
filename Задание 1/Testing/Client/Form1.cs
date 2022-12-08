namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            int number = random.Next(1000000);
            string name = "User " + number.ToString();
            Program.SendMessage(name);
            Question.Text = Program.ReceiveMessage();
        }

        private void SendAnswer_Click(object sender, EventArgs e)
        {
            Program.SendMessage(Answer.Text);
            Answer.Text = "";
            Question.Text = Program.ReceiveMessage();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Program.SendMessage("restart");
            Answer.Text = "";
            Question.Text = Program.ReceiveMessage();
        }
    }
}