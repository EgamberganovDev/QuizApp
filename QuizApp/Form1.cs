namespace QuizApp
{
    public partial class QuizApp : Form
    {
        public QuizApp()
        {
            string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string quizAppFolderPath = Path.Combine(myDocumentsPath, "QuizApp");

            if (!Directory.Exists(quizAppFolderPath))
            {
                Directory.CreateDirectory(quizAppFolderPath);
            }
            InitializeComponent();
        }

        private void Work_quiz_Click(object sender, EventArgs e)
        {
            startQuizForm obj = new startQuizForm();
            obj.Show();
        }

        private void Load_quiz_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            obj.Show();
        }
    }
}