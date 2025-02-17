﻿using Microsoft.EntityFrameworkCore;
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
            using (var context = new QuizAppContext())
            {
                var subjects = context.Subjects;
                List<Question> questions = new List<Question>();

                openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                openFileDialog1.Title = "Bir TXT fayl tanlang";
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filepath = openFileDialog1.FileName;
                    try
                    {
                        string[] lines = File.ReadAllLines(filepath);
                        for (int i = 0; i < lines.Length; i += 6)
                        {
                            if (i + 5 < lines.Length)
                            {
                                string questionText = lines[i].Trim();
                                string correctAnswer = "";

                                string optionA = ProcessOption(lines[i + 1], ref correctAnswer);
                                string optionB = ProcessOption(lines[i + 2], ref correctAnswer);
                                string optionC = ProcessOption(lines[i + 3], ref correctAnswer);
                                string optionD = ProcessOption(lines[i + 4], ref correctAnswer);

                                var subject = subjects.FirstOrDefault(s => s.Name == lines[i + 5]);
                                
                                Question question = new Question();
                                question.Text = questionText;
                                question.CorrectAnswer = correctAnswer;
                                question.OptionA = optionA;
                                question.OptionB = optionB;
                                question.OptionC = optionC;
                                question.OptionD = optionD;
                                question.SubjectId = subject!.Id;
                                questions.Add(question);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fayldan ma'lumotlarni o'qishda xatolik yuz berdi! {ex.Message}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                using (var context = new QuizAppContext())
                {
                    void AddQuestion(string questionText, string correctAnswer, string optionA, string optionB, string optionC, string optionD)
                    {
                        var question = new Question
                        {
                            Text = questionText,
                            CorrectAnswer = correctAnswer,
                            OptionA = optionA,
                            OptionB = optionB,
                            OptionC = optionC,
                            OptionD = optionD,
                            SubjectId = comboBox1.SelectedIndex + 1
                        };

                        context.Questions.Add(question);
                    }

                    if (checkBox1.Checked)
                    {
                        AddQuestion(
                            richTextBox1.Text,
                            textBox1.Text,
                            textBox1.Text,
                            textBox2.Text,
                            textBox3.Text,
                            textBox4.Text);
                    }

                    if (checkBox2.Checked)
                    {
                        AddQuestion(
                            richTextBox1.Text,
                            textBox2.Text,
                            textBox1.Text,
                            textBox2.Text,
                            textBox3.Text,
                            textBox4.Text);
                    }

                    if (checkBox3.Checked)
                    {
                        AddQuestion(
                            richTextBox1.Text,
                            textBox3.Text,
                            textBox1.Text,
                            textBox2.Text,
                            textBox3.Text,
                            textBox4.Text);
                    }

                    if (checkBox4.Checked)
                    {
                        AddQuestion(
                            richTextBox1.Text,
                            textBox4.Text,
                            textBox1.Text,
                            textBox2.Text,
                            textBox3.Text,
                            textBox4.Text);
                    }

                    context.SaveChanges();
                    MessageBox.Show("Ma'lumot bazaga muvaffaqiyatli yuklandi");
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

        private string ProcessOption(string option, ref string correctAnswer)
        {
            if (option.StartsWith("*"))
            {
                correctAnswer = option.Substring(1).Trim();
                return correctAnswer;
            }
            return option.Trim();
        }
    }
}