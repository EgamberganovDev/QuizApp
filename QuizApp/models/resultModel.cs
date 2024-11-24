namespace QuizApp.models
{
    internal class resultModel
    {
        string userName { get; }
        string courseName { get; }
        int countOfQuiz { get; }
        int trueAnswersCount { get; }
        int falseAnswersCount { get; }
        double percent { get; }
        int score { get; }

        public resultModel (string userName, string courseName, int countOfQuiz, int trueAnswersCount, int falseAnswersCount, double percent, int score)
        {
            this.userName = userName;
            this.courseName = courseName;
            this.countOfQuiz = countOfQuiz;
            this.trueAnswersCount = trueAnswersCount;
            this.falseAnswersCount = falseAnswersCount;
            this.percent = percent;
            this.score = score;
        }
    }
}
