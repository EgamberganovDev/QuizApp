namespace QuizApp.models
{
    internal class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> Options { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
