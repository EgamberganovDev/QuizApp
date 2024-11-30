using QuizApp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            using (var context = new QuizAppContext())
            {
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                var sessions = context.TestSessions
                    .Select(s => new
                    {
                        s.Id,
                        User = context.Users.Where(u => u.Id == s.UserId).Select(u => u.Name).FirstOrDefault(),
                        Subject = context.Subjects.Where(sub => sub.Id == s.SubjectId).Select(sub => sub.Name).FirstOrDefault(),
                        s.QuestionCount,
                        s.CorrectAnswers,
                        s.IncorrectAnswers,
                        s.ScorePercentage,
                        s.Grade
                    })
                    .ToList();

                dataGridView1.DataSource = sessions;
            }
        }
    }
}
