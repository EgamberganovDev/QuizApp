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
            string userDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string quizAppPath = Path.Combine(userDocumentsPath, "QuizApp");
            string testsDirectory = Path.Combine(quizAppPath, "Testlar");
            DirectoryInfo di = new DirectoryInfo(testsDirectory);
            foreach (var fi in di.GetFiles())
            {
                if (fi.Name.EndsWith(".txt"))
                {
                    int cntTest = CountLinesInFile(fi.FullName) / 5;
                    comboBox1.Items.Add(fi.Name.Substring(0, fi.Name.Length - 4) + $" ({cntTest})");
                }
            }
        }

        static int CountLinesInFile(string filePath)
        {
            int lineCount = 0;

            StreamReader reader = new StreamReader(filePath);
            while (reader.ReadLine() != null)
            {
                lineCount++;
            }
            reader.Close();

            return lineCount;
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
            string userDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string quizAppPath = Path.Combine(userDocumentsPath, "QuizApp");
            string testsDirectory = Path.Combine(quizAppPath, "Testlar");
            string testFilePath = Path.Combine(testsDirectory, $"{textBox5.Text}.txt");

            if (!Directory.Exists(testsDirectory))
            {
                Directory.CreateDirectory(testsDirectory);
                File.Create(testFilePath).Close();
                updateComboBox();
                panel1.Visible = false;
            }
            else
            {
                File.Create(testFilePath).Close();
                updateComboBox();
                panel1.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fannomi = comboBox1.SelectedItem.ToString()!;
            string userDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string quizAppPath = Path.Combine(userDocumentsPath, "QuizApp");
            string packagePath = Path.Combine(quizAppPath, "Testlar");
            string path = Path.Combine(packagePath, $"{fannomi.Substring(0, fannomi.Length - 4)}.txt");

            if (!Directory.Exists(packagePath))
            {
                Directory.CreateDirectory(packagePath);
                if (File.Exists(path))
                {
                    StreamWriter writer = File.CreateText(path);
                    writer.WriteLine(richTextBox1.Text);
                    if (checkBox1.Checked)
                    {
                        writer.WriteLine("*" + textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.WriteLine(textBox3.Text);
                        writer.WriteLine(textBox4.Text);
                    }

                    if (checkBox2.Checked)
                    {
                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine("*" + textBox2.Text);
                        writer.WriteLine(textBox3.Text);
                        writer.WriteLine(textBox4.Text);
                    }

                    if (checkBox3.Checked)
                    {
                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.WriteLine("*" + textBox3.Text);
                        writer.WriteLine(textBox4.Text);
                    }

                    if (checkBox4.Checked)
                    {
                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.WriteLine(textBox3.Text);
                        writer.WriteLine("*" + textBox4.Text);
                    }
                    writer.Close();
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
                    StreamWriter writer = File.AppendText(path);
                    writer.WriteLine(richTextBox1.Text);
                    if (checkBox1.Checked)
                    {
                        writer.WriteLine("*" + textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.WriteLine(textBox3.Text);
                        writer.WriteLine(textBox4.Text);
                    }

                    if (checkBox2.Checked)
                    {
                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine("*" + textBox2.Text);
                        writer.WriteLine(textBox3.Text);
                        writer.WriteLine(textBox4.Text);
                    }

                    if (checkBox3.Checked)
                    {
                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.WriteLine("*" + textBox3.Text);
                        writer.WriteLine(textBox4.Text);
                    }

                    if (checkBox4.Checked)
                    {
                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.WriteLine(textBox3.Text);
                        writer.WriteLine("*" + textBox4.Text);
                    }
                    writer.Close();
                    comboBox1.ResetText();
                    richTextBox1.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    updateComboBox();
                }
            }
            else
            {
                if (File.Exists(path))
                {
                    StreamWriter writer = File.CreateText(path);
                    writer.WriteLine(richTextBox1.Text);
                    if (checkBox1.Checked)
                    {
                        writer.WriteLine("*" + textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.WriteLine(textBox3.Text);
                        writer.WriteLine(textBox4.Text);
                    }

                    if (checkBox2.Checked)
                    {
                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine("*" + textBox2.Text);
                        writer.WriteLine(textBox3.Text);
                        writer.WriteLine(textBox4.Text);
                    }

                    if (checkBox3.Checked)
                    {
                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.WriteLine("*" + textBox3.Text);
                        writer.WriteLine(textBox4.Text);
                    }

                    if (checkBox4.Checked)
                    {
                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.WriteLine(textBox3.Text);
                        writer.WriteLine("*" + textBox4.Text);
                    }
                    writer.Close();
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
                    StreamWriter writer = File.AppendText(path);
                    writer.WriteLine(richTextBox1.Text);
                    if (checkBox1.Checked)
                    {
                        writer.WriteLine("*" + textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.WriteLine(textBox3.Text);
                        writer.WriteLine(textBox4.Text);
                    }

                    if (checkBox2.Checked)
                    {
                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine("*" + textBox2.Text);
                        writer.WriteLine(textBox3.Text);
                        writer.WriteLine(textBox4.Text);
                    }

                    if (checkBox3.Checked)
                    {
                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.WriteLine("*" + textBox3.Text);
                        writer.WriteLine(textBox4.Text);
                    }

                    if (checkBox4.Checked)
                    {
                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.WriteLine(textBox3.Text);
                        writer.WriteLine("*" + textBox4.Text);
                    }
                    writer.Close();
                    comboBox1.ResetText();
                    richTextBox1.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    updateComboBox();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.Title = "Bir TXT fayl tanlang";
            openFileDialog1.FileName = "";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
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
    }
}