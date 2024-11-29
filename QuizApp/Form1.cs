namespace QuizApp
{
    public partial class QuizApp : Form
    {
        public QuizApp()
        {
            InitializeComponent();
        }

        private void Work_quiz_Click(object sender, EventArgs e)
        {
            startQuizForm obj = new startQuizForm();
            obj.Show();
        }

        private void Load_quiz_Click(object sender, EventArgs e)
        {
            AddQuizForm obj = new AddQuizForm();
            obj.Show();
        }

        private void Score_table_Click(object sender, EventArgs e)
        {
            Results obj = new Results();
            obj.Show();
        }

        private void about_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();
        }
    }
}