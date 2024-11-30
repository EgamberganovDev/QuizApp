using QuizApp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuizApp
{
    public partial class Form3 : Form
    {
        private string IsmFamiliya;
        private string FanNomi;
        private int TestlarSoni;

        private int index = 0;
        private int True_cnt = 0;
        private int False_cnt = 0;

        private string[] TogriJavoblar;
        private string[] BelgilanganJavoblar;
        private List<Question> questions;
        private static QuizAppContext context = new QuizAppContext();

        public Form3(string fio, string fan, int test_soni)
        {
            InitializeComponent();
            IsmFamiliya = fio;
            FanNomi = fan;
            TestlarSoni = test_soni;

            questions = context.Questions.Take(TestlarSoni).ToList();
            TogriJavoblar = questions.Select(q => q.CorrectAnswer).ToArray();
            BelgilanganJavoblar = new string[TestlarSoni];
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            fan_nomi.Text = FanNomi;
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (index < TestlarSoni)
            {
                label1.Text = $"Savol {index + 1}";
                listBox1.Items.Clear();
                listBox1.Items.Add(questions[index].Text);

                radioButton1.Text = questions[index].OptionA;
                radioButton2.Text = questions[index].OptionB;
                radioButton3.Text = questions[index].OptionC;
                radioButton4.Text = questions[index].OptionD;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

                button1.Enabled = index > 0;
            }
            else
            {
                ShowResult();
            }
        }

        private void ShowResult()
        {
            for (int i = 0; i < TestlarSoni; i++)
            {
                if (TogriJavoblar[i] == BelgilanganJavoblar[i])
                {
                    True_cnt++;
                }
                else
                {
                    False_cnt++;
                }
            }

            Result obj = new Result(IsmFamiliya, FanNomi, TestlarSoni, True_cnt, False_cnt);
            obj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Javob tanlanmagan, iltimos bir javob tanlang.");
                return;
            }

            if (radioButton1.Checked) BelgilanganJavoblar[index] = radioButton1.Text;
            if (radioButton2.Checked) BelgilanganJavoblar[index] = radioButton2.Text;
            if (radioButton3.Checked) BelgilanganJavoblar[index] = radioButton3.Text;
            if (radioButton4.Checked) BelgilanganJavoblar[index] = radioButton4.Text;

            index++;
            LoadQuestion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0) index--;

            LoadQuestion();

            if (radioButton1.Text == BelgilanganJavoblar[index]) radioButton1.Checked = true;
            if (radioButton2.Text == BelgilanganJavoblar[index]) radioButton2.Checked = true;
            if (radioButton3.Text == BelgilanganJavoblar[index]) radioButton3.Checked = true;
            if (radioButton4.Text == BelgilanganJavoblar[index]) radioButton4.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowResult();
        }
    }
}