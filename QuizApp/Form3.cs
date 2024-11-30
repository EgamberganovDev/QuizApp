﻿using QuizApp.models;
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

        private static int index;
        private static int True_cnt;
        private static int False_cnt;
        private static string[] s;

        private static string[] TogriJavoblar;
        private static string[] BelgilanganJavoblar;
        private static Dictionary<int, string> trueResults = new Dictionary<int, string>();
        private static Dictionary<int, string> falseResults = new Dictionary<int, string>();
        private static QuizAppContext context = new QuizAppContext();

        public Form3(string fio, string fan, int test_soni)
        {
            InitializeComponent();
            IsmFamiliya = fio;
            FanNomi = fan;
            TestlarSoni = test_soni;

            s = new string[TestlarSoni * 5];
            TogriJavoblar = new string[TestlarSoni];
            BelgilanganJavoblar = new string[TestlarSoni];
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            fan_nomi.Text = FanNomi.ToString();
            index = 0;
            True_cnt = 0;
            False_cnt = 0;
            List<Question> questions = context.Questions.ToList();

            if (index == 0) button1.Enabled = false;

            if (index < TestlarSoni)
            {
                label1.Text = "Savol " + (index + 1).ToString();
                listBox1.Items.Clear();

                listBox1.Items.Add(questions[index].Text);
                radioButton1.Text = questions[index].OptionA;
                radioButton2.Text = questions[index].OptionB;
                radioButton3.Text = questions[index].OptionC;
                radioButton4.Text = questions[index].OptionD;
            }
            else
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) BelgilanganJavoblar[index] = radioButton1.Text;
            if (radioButton2.Checked) BelgilanganJavoblar[index] = radioButton2.Text;
            if (radioButton3.Checked) BelgilanganJavoblar[index] = radioButton3.Text;
            if (radioButton4.Checked) BelgilanganJavoblar[index] = radioButton4.Text;

            int cnt1 = 0;
            int cnt2 = 0;
            for (int i = 0; i < TogriJavoblar.Length; i++)
            {
                if (TogriJavoblar[i] == BelgilanganJavoblar[i])
                {
                    trueResults.Add(i + 1, BelgilanganJavoblar[i]);
                    cnt1++;
                }
                else
                {
                    falseResults.Add(i + 1, BelgilanganJavoblar[i]);
                    cnt2++;
                }
            }

            True_cnt = cnt1;
            False_cnt = cnt2;
            writeResults();
            trueResults.Clear();
            falseResults.Clear();
            Result obj = new Result(IsmFamiliya, FanNomi, TestlarSoni, cnt1);
            obj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Javob tanlanmagan, iltimos bir javob tanlang.");
            }
            else
            {
                if (radioButton1.Checked) BelgilanganJavoblar[index] = radioButton1.Text;
                if (radioButton2.Checked) BelgilanganJavoblar[index] = radioButton2.Text;
                if (radioButton3.Checked) BelgilanganJavoblar[index] = radioButton3.Text;
                if (radioButton4.Checked) BelgilanganJavoblar[index] = radioButton4.Text;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

                index++;
                if (index > 0) button1.Enabled = true;

                label1.Text = "Savol " + (index + 1).ToString();
                listBox1.Items.Clear();

                if (index < TestlarSoni)
                {
                    listBox1.Items.Add(s[5 * index]);
                    radioButton1.Text = s[5 * index + 1];
                    radioButton2.Text = s[5 * index + 2];
                    radioButton3.Text = s[5 * index + 3];
                    radioButton4.Text = s[5 * index + 4];
                }
                else
                {
                    int cnt1 = 0;
                    int cnt2 = 0;
                    for (int i = 0; i < TogriJavoblar.Length; i++)
                    {
                        if (TogriJavoblar[i] == BelgilanganJavoblar[i])
                        {
                            trueResults.Add(i + 1, BelgilanganJavoblar[i]);
                            cnt1++;
                        }
                        else
                        {
                            falseResults.Add(i + 1, BelgilanganJavoblar[i]);
                            cnt2++;
                        }
                    }

                    True_cnt = cnt1;
                    False_cnt = cnt2;
                    writeResults();
                    trueResults.Clear();
                    falseResults.Clear();
                    Result obj = new Result(IsmFamiliya, FanNomi, TestlarSoni, cnt1);
                    obj.Show();
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) BelgilanganJavoblar[index] = radioButton1.Text;
            if (radioButton2.Checked) BelgilanganJavoblar[index] = radioButton2.Text;
            if (radioButton3.Checked) BelgilanganJavoblar[index] = radioButton3.Text;
            if (radioButton4.Checked) BelgilanganJavoblar[index] = radioButton4.Text;

            index--;
            if (index == 0) button1.Enabled = false;
            if (index + 1 < TogriJavoblar.Length) button2.Enabled = true;

            label1.Text = "Savol " + (index + 1).ToString();
            listBox1.Items.Clear();

            listBox1.Items.Add(s[5 * index]);
            radioButton1.Text = s[5 * index + 1];
            radioButton2.Text = s[5 * index + 2];
            radioButton3.Text = s[5 * index + 3];
            radioButton4.Text = s[5 * index + 4];

            if (radioButton1.Text == BelgilanganJavoblar[index]) radioButton1.Checked = true;
            if (radioButton2.Text == BelgilanganJavoblar[index]) radioButton2.Checked = true;
            if (radioButton3.Text == BelgilanganJavoblar[index]) radioButton3.Checked = true;
            if (radioButton4.Text == BelgilanganJavoblar[index]) radioButton4.Checked = true;
        }

        private void writeResults()
        {
            string userDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string quizAppPath = Path.Combine(userDocumentsPath, "QuizApp");
            string packagePath1 = Path.Combine(quizAppPath, "Results");
            string packagePath2 = Path.Combine(quizAppPath, "TrueAnswers");
            string packagePath3 = Path.Combine(quizAppPath, "Natijalar");
            string path1 = Path.Combine(packagePath1, "trueResults.txt");
            string path2 = Path.Combine(packagePath1, "falseResults.txt");
            string path3 = Path.Combine(packagePath2, "TrueAnswers.txt");
            string path4 = Path.Combine(packagePath3, $"{IsmFamiliya}.txt");

            if (!Directory.Exists(packagePath3))
            {
                Directory.CreateDirectory(packagePath3);
                if(!File.Exists(path4))
                {
                    StreamWriter writer4 = File.CreateText(path4);
                    writer4.WriteLine($"Fan {FanNomi}, To'g'ri javoblar: {True_cnt}, Noto'g'ri javoblar: {False_cnt}, Ishlangan vaqti: {DateTime.Now}");
                    writer4.WriteLine("====================");
                    foreach (var result in trueResults)
                    {
                        writer4.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer4.WriteLine("====================");
                    foreach (var result in falseResults)
                    {
                        writer4.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer4.WriteLine("====================");
                    writer4.Close();
                }
                else
                {
                    StreamWriter writer4 = File.AppendText(path4);
                    writer4.WriteLine($"Fan {FanNomi}, To'g'ri javoblar: {True_cnt}, Noto'g'ri javoblar: {False_cnt}, Ishlangan vaqti: {DateTime.Now}");
                    writer4.WriteLine("====================");
                    foreach (var result in trueResults)
                    {
                        writer4.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer4.WriteLine("====================");
                    foreach (var result in falseResults)
                    {
                        writer4.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer4.WriteLine("====================");
                    writer4.Close();
                }
            }
            else
            {
                if (!File.Exists(path4))
                {
                    StreamWriter writer4 = File.CreateText(path4);
                    writer4.WriteLine($"Fan {FanNomi}, To'g'ri javoblar: {True_cnt}, Noto'g'ri javoblar: {False_cnt}, Ishlangan vaqti: {DateTime.Now}");
                    writer4.WriteLine("====================");
                    foreach (var result in trueResults)
                    {
                        writer4.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer4.WriteLine("====================");
                    foreach (var result in falseResults)
                    {
                        writer4.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer4.WriteLine("====================");
                    writer4.Close();
                }
                else
                {
                    StreamWriter writer4 = File.AppendText(path4);
                    writer4.WriteLine($"Fan {FanNomi}, To'g'ri javoblar: {True_cnt}, Noto'g'ri javoblar: {False_cnt}, Ishlangan vaqti: {DateTime.Now}");
                    writer4.WriteLine("====================");
                    foreach (var result in trueResults)
                    {
                        writer4.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer4.WriteLine("====================");
                    foreach (var result in falseResults)
                    {
                        writer4.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer4.WriteLine("====================");
                    writer4.Close();
                }
            }
            /*if (!Directory.Exists(packagePath2))
            {
                Directory.CreateDirectory(packagePath2);
                if (!File.Exists(path3))
                {
                    StreamWriter writer = File.CreateText(path3);

                    writer.WriteLine($"Fan:{FanNomi}");

                    for (int i = 0; i < TogriJavoblar.Length; i++)
                    {
                        writer.WriteLine($"{i + 1}:{TogriJavoblar[i]}");
                    }

                    writer.WriteLine("====================");
                    writer.Close();
                }
                else
                {
                    StreamWriter writer = File.AppendText(path3);

                    writer.WriteLine($"Fan:{FanNomi}");

                    for (int i = 0; i <= TogriJavoblar.Length; i++)
                    {
                        writer.WriteLine($"{i + 1}:{TogriJavoblar[i]}");
                    }

                    writer.WriteLine("====================");
                    writer.Close();
                }
            }*/

            if (!Directory.Exists(packagePath1))
            {
                Directory.CreateDirectory(packagePath1);
                if (File.Exists(path1) && File.Exists(path2))
                {
                    StreamWriter writer1 = File.AppendText(path1);
                    StreamWriter writer2 = File.AppendText(path2);

                    writer1.WriteLine($"Foydalanuvchi:{IsmFamiliya}, Fan:{FanNomi}, To'g'ri javoblar soni:{True_cnt}");

                    foreach (var result in trueResults)
                    {
                        writer1.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer1.WriteLine("====================");
                    writer1.Close();

                    writer2.WriteLine($"Foydalanuvchi:{IsmFamiliya}, Fan:{FanNomi}, Noto'g'ri javoblar soni:{False_cnt}");
                    foreach (var result in falseResults)
                    {
                        writer2.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer2.WriteLine("====================");
                    writer2.Close();
                }
                else
                {
                    StreamWriter writer1 = File.CreateText(path1);
                    StreamWriter writer2 = File.CreateText(path2);

                    writer1.WriteLine($"Foydalanuvchi:{IsmFamiliya}, Fan:{FanNomi}, To'g'ri javoblar soni:{True_cnt}");

                    foreach (var result in trueResults)
                    {
                        writer1.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer1.WriteLine("====================");
                    writer1.Close();

                    writer2.WriteLine($"Foydalanuvchi:{IsmFamiliya}, Fan:{FanNomi}, Noto'g'ri javoblar soni:{False_cnt}");
                    foreach (var result in falseResults)
                    {
                        writer2.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer2.WriteLine("====================");
                    writer2.Close();
                }
            }
            else
            {
                if(File.Exists(path1) && File.Exists(path2))
                {
                    StreamWriter writer1 = File.AppendText(path1);
                    StreamWriter writer2 = File.AppendText(path2);

                    writer1.WriteLine($"Foydalanuvchi:{IsmFamiliya}, Fan:{FanNomi}, To'g'ri javoblar soni:{True_cnt}.");

                    foreach (var result in trueResults)
                    {
                        writer1.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer1.WriteLine("====================");
                    writer1.Close();

                    writer2.WriteLine($"Foydalanuvchi:{IsmFamiliya}, Fan:{FanNomi}, Noto'g'ri javoblar soni:{False_cnt}.");
                    foreach (var result in falseResults)
                    {
                        writer2.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer2.WriteLine("====================");
                    writer2.Close();
                }
                else
                {
                    StreamWriter writer1 = File.CreateText(path1);
                    StreamWriter writer2 = File.CreateText(path2);

                    writer1.WriteLine($"Foydalanuvchi:{IsmFamiliya}, Fan:{FanNomi}, To'g'ri javoblar soni:{True_cnt}.");

                    foreach (var result in trueResults)
                    {
                        writer1.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer1.WriteLine("====================");
                    writer1.Close();

                    writer2.WriteLine($"Foydalanuvchi:{IsmFamiliya}, Fan:{FanNomi}, Noto'g'ri javoblar soni:{False_cnt}.");
                    foreach (var result in falseResults)
                    {
                        writer2.WriteLine($"{result.Key}:{result.Value}");
                    }
                    writer2.WriteLine("====================");
                    writer2.Close();
                }
            }
        }
    }
}