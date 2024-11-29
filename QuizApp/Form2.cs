using QuizApp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizApp
{
    public partial class startQuizForm : Form
    {
        public startQuizForm()
        {
            InitializeComponent();
        }

        private void start_quiz_Click(object sender, EventArgs e)
        {
            if (fio.Text.Length == 0 && courses.SelectedIndex == -1 && numbersOfQuiz.Value == 0
                || fio.Text.Length != 0 && courses.SelectedIndex == -1 && numbersOfQuiz.Value == 0
                || fio.Text.Length == 0 && courses.SelectedIndex != -1 && numbersOfQuiz.Value == 0
                || fio.Text.Length == 0 && courses.SelectedIndex == -1 && numbersOfQuiz.Value != 0)
            {
                MessageBox.Show("Ism familiya yozilmagan yoki Fan tanlanmagan");
                return;
            }

            saveNewUser(fio.Text.ToString());

            string FIO = fio.Text.ToString();
            string FAN = courses.SelectedItem.ToString();
            int test_soni = int.Parse(numbersOfQuiz.Value.ToString());

            Form3 obj = new Form3(FIO, FAN, test_soni);
            obj.Show();
            this.Close();
        }

        private void saveNewUser(string userName)
        {
            using (var context = new QuizAppContext())
            {
                // Foydalanuvchini qidirish
                var existingUser = context.Users.FirstOrDefault(u => u.Name == userName);

                if (existingUser != null)
                {
                    Console.WriteLine($"Foydalanuvchi mavjud: {existingUser.Name}");
                    // Mavjud foydalanuvchi uchun boshqa amalni bajaring
                }
                else
                {
                    // Foydalanuvchi mavjud emas, yangi foydalanuvchi qo'shiladi
                    var newUser = new User { Name = userName };
                    context.Users.Add(newUser);
                    context.SaveChanges();
                    Console.WriteLine("Yangi foydalanuvchi qo'shildi!");
                }
            }
        }

        private void startQuizForm_Load(object sender, EventArgs e)
        {
            loadSubjects();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadSubjects()
        {
            using (var context = new QuizAppContext())
            {
                courses.Items.Clear();
                var subjects = context.Subjects.ToList();
                foreach (var subject in subjects)
                {
                    courses.Items.Add(subject.Name);
                }
            }
        }
    }
}
