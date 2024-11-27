namespace QuizApp.models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TestSession> TestSessions { get; set; }
    }
}
