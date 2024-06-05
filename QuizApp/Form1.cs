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
    }
}