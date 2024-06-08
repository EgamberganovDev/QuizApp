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
    public partial class startQuizForm : Form
    {
        public startQuizForm()
        {
            InitializeComponent();
        }

        private void start_quiz_Click(object sender, EventArgs e)
        {
            string FIO = fio.Text.ToString();
            string FAN = courses.SelectedItem.ToString()!;
            int test_soni = int.Parse(numbersOfQuiz.Value.ToString());

            Form3 obj = new Form3(FIO, FAN, test_soni);
            obj.Show();
        }

        private void startQuizForm_Load(object sender, EventArgs e)
        {

        }
    }
}
