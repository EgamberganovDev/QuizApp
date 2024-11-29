using Microsoft.EntityFrameworkCore;

namespace QuizApp.models
{
    internal class QuizAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<TestSession> TestSessions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=QuizApp; Trusted_Connection=True;");
        }
    }
}
