using Microsoft.EntityFrameworkCore;
using QuizApp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class AddQuizForm : Form
    {
        public AddQuizForm()
        {
            InitializeComponent();
        }

        void updateComboBox()
        {
            comboBox1.Items.Clear();
            using (var context = new QuizAppContext())
            {
                var subjects = context.Subjects.Include(s => s.Questions).ToList();

                foreach (var subject in subjects)
                {
                    comboBox1.Items.Add($"{subject.Name} ({subject.Questions.Count})");
                }
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            updateComboBox();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox4.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox4.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new QuizAppContext())
            {
                Subject subject = new Subject();
                subject.Name = textBox5.Text;
                context.Subjects.Add(subject);
                context.SaveChanges();
            }
            updateComboBox();
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.Title = "Bir TXT fayl tanlang";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                string userDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string quizAppPath = Path.Combine(userDocumentsPath, "QuizApp");
                string targetDirectory = Path.Combine(quizAppPath, "Testlar");
                string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(selectedFilePath));

                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                    File.Copy(selectedFilePath, targetFilePath, true);
                }
                else File.Copy(selectedFilePath, targetFilePath, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
            {
                using (var context = new QuizAppContext())
                {
                    if (checkBox1.Checked)
                    {
                        Question question = new Question();
                        question.Text = richTextBox1.Text;
                        question.CorrectAnswer = textBox1.Text;
                        question.OptionA = textBox1.Text;
                        question.OptionB = textBox2.Text;
                        question.OptionC = textBox3.Text;
                        question.OptionD = textBox4.Text;

                        string subjectName = comboBox1.SelectedItem?.ToString() ?? string.Empty;
                        var subjects = context.Subjects;
                        foreach (var subject in subjects)
                        {
                            if (subject.Name == subjectName)
                            {
                                question.SubjectId = subject.Id;
                            }
                        }

                        context.Questions.Add(question);
                        context.SaveChanges();
                    }

                    if (checkBox2.Checked)
                    {
                        Question question = new Question();
                        question.Text = richTextBox1.Text;
                        question.CorrectAnswer = textBox2.Text;
                        question.OptionA = textBox1.Text;
                        question.OptionB = textBox2.Text;
                        question.OptionC = textBox3.Text;
                        question.OptionD = textBox4.Text;

                        string subjectName = comboBox1.SelectedItem?.ToString() ?? string.Empty;
                        var subjects = context.Subjects;
                        foreach (var subject in subjects)
                        {
                            if (subject.Name == subjectName)
                            {
                                question.SubjectId = subject.Id;
                            }
                        }

                        context.Questions.Add(question);
                        context.SaveChanges();
                    }

                    if (checkBox3.Checked)
                    {
                        Question question = new Question();
                        question.Text = richTextBox1.Text;
                        question.CorrectAnswer = textBox3.Text;
                        question.OptionA = textBox1.Text;
                        question.OptionB = textBox2.Text;
                        question.OptionC = textBox3.Text;
                        question.OptionD = textBox4.Text;

                        string subjectName = comboBox1.SelectedItem?.ToString() ?? string.Empty;
                        var subjects = context.Subjects;
                        foreach (var subject in subjects)
                        {
                            if (subject.Name == subjectName)
                            {
                                question.SubjectId = subject.Id;
                            }
                        }

                        context.Questions.Add(question);
                        context.SaveChanges();
                    }

                    if (checkBox4.Checked)
                    {
                        Question question = new Question();
                        question.Text = richTextBox1.Text;
                        question.CorrectAnswer = textBox4.Text;
                        question.OptionA = textBox1.Text;
                        question.OptionB = textBox2.Text;
                        question.OptionC = textBox3.Text;
                        question.OptionD = textBox4.Text;

                        string subjectName = comboBox1.SelectedItem?.ToString() ?? string.Empty;
                        var subjects = context.Subjects;
                        foreach (var subject in subjects)
                        {
                            if (subject.Name == subjectName)
                            {
                                question.SubjectId = subject.Id;
                            }
                        }

                        context.Questions.Add(question);
                        context.SaveChanges();
                    }
                }

                comboBox1.ResetText();
                richTextBox1.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                updateComboBox();
            }
            else 
            {
                MessageBox.Show("Fan tanlanmagan! Iltimos oldin fan tanlang");
            }
        }
    }
}