namespace QuizApp.models
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<TestSession> TestSessions { get; set; }
    }
}
