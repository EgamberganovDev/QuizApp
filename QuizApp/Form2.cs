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
        private string filepath;
        private int testSoni;

        public startQuizForm()
        {
            InitializeComponent();
        }

        static int CountLinesInFile(string filePath)
        {
            int lineCount = 0;

            StreamReader reader = new StreamReader(filePath);
            while (reader.ReadLine() != null)
            {
                lineCount++;
            }

            return lineCount;
        }

        private void start_quiz_Click(object sender, EventArgs e)
        {
            if(fio.Text.Length == 0 && courses.SelectedIndex == -1 && numbersOfQuiz.Value == 0
                || fio.Text.Length != 0 && courses.SelectedIndex == -1 && numbersOfQuiz.Value == 0
                || fio.Text.Length == 0 && courses.SelectedIndex != -1 && numbersOfQuiz.Value == 0
                || fio.Text.Length == 0 && courses.SelectedIndex == -1 && numbersOfQuiz.Value != 0)
            {
                MessageBox.Show("Ism familiya yozilmagan yoki Fan tanlanmagan");
                return;
            }
            string FIO = fio.Text.ToString();
            string FAN = courses.SelectedItem.ToString()!;
            int test_soni = int.Parse(numbersOfQuiz.Value.ToString());

            Form3 obj = new Form3(FIO, FAN, test_soni, filepath);
            obj.Show();
            this.Close();
        }

        private void startQuizForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"Testlar");
            foreach (var fi in di.GetFiles())
            {
                filepath = fi.FullName;
                if (fi.Name.EndsWith(".txt"))
                    courses.Items.Add(fi.Name.Substring(0, fi.Name.Length - 4));
            }

            testSoni = CountLinesInFile(filepath) / 5;
            numbersOfQuiz.Maximum = testSoni;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
