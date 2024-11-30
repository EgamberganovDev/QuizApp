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
    public partial class Result : Form
    {
        string IsmFamiliya;
        string Fan;
        int TestlarSoni;
        int TJ;
        int NJ;

        public Result(string ismFamiliya, string fan, int testlarSoni, int tJ, int nJ)
        {
            InitializeComponent();
            IsmFamiliya = ismFamiliya;
            Fan = fan;
            TestlarSoni = testlarSoni;
            TJ = tJ;
            NJ = nJ;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "Ism Familiya : " + IsmFamiliya;
            label2.Text = "Fan: " + Fan;
            label3.Text = "Jami testlar soni: " + TestlarSoni.ToString();
            label4.Text = "Tog`ri javoblar soni: " + TJ.ToString();
            label7.Text = "Noto'g'ri javoblar soni: " + NJ.ToString();
            int foiz = (int)((double)TJ / ((double)TestlarSoni) * 100);
            int baho = 2;

            if (foiz > 59 && foiz < 70) baho = 3;
            if (foiz >= 70 && foiz < 89) baho = 4;
            if (foiz >= 90) baho = 5;

            label5.Text = (foiz.ToString() + "%");
            label6.Text = (baho.ToString() + " baho");

            saveDataOnDB(IsmFamiliya, Fan, TestlarSoni, TJ, NJ, foiz, baho);
        }

        private void saveDataOnDB(string ismFamiliya, string fan, int testlarSoni, int tJ, int nJ, int foiz, int baho)
        {
            using(var context = new QuizAppContext())
            {
                TestSession testSession = new TestSession();
                testSession.UserId = context.Users.Where(u => u.Name == ismFamiliya).Select(u => u.Id).FirstOrDefault();
                testSession.SubjectId = context.Subjects.Where(sub => sub.Name == fan).Select(sub => sub.Id).FirstOrDefault();
                testSession.QuestionCount = testlarSoni;
                testSession.CorrectAnswers = tJ;
                testSession.IncorrectAnswers = nJ;
                testSession.ScorePercentage = foiz;
                testSession.Grade = baho;

                context.TestSessions.Add(testSession);
                context.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
