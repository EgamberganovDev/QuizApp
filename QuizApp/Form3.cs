using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private string filePath;

        private static int index;
        private static string[] s;

        private static string[] TogriJavoblar;
        private static string[] BelgilanganJavoblar;

        public Form3(string fio, string fan, int test_soni, string filepath)
        {
            InitializeComponent();
            IsmFamiliya = fio;
            FanNomi = fan;
            TestlarSoni = test_soni;
            filePath = filepath;

            s = new string[TestlarSoni * 5];
            TogriJavoblar = new string[TestlarSoni];
            BelgilanganJavoblar = new string[TestlarSoni];
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            fan_nomi.Text = FanNomi.ToString();
            index = 0;

            if (index == 0) button1.Enabled = false;

            StreamReader rd = new StreamReader(filePath);

            int i = 0;
            string line;
            while ((line = rd.ReadLine()) != null)
            {
                if (i > s.Length - 1)
                {
                    break;
                }
                else
                {
                    s[i] = line;
                    if (s[i].StartsWith('*'))
                    {
                        s[i] = s[i].Substring(1, s[i].Length - 1);
                        TogriJavoblar[(int)(i / 5)] = s[i];
                    }
                    i++;
                }
            }
            rd.Close();

            if (index <= TestlarSoni - 1)
            {
                label1.Text = "Savol " + (index + 1).ToString();
                listBox1.Items.Clear();

                listBox1.Items.Add(s[5 * index]);
                radioButton1.Text = s[5 * index + 1];
                radioButton2.Text = s[5 * index + 2];
                radioButton3.Text = s[5 * index + 3];
                radioButton4.Text = s[5 * index + 4];
            }
            else
            {
                int cnt = 0;
                for (int j = 0; j < TogriJavoblar.Length; i++)
                {
                    if (TogriJavoblar[j] == BelgilanganJavoblar[j]) cnt++;
                }

                Form4 obj = new Form4(IsmFamiliya, FanNomi, TestlarSoni, cnt);
                obj.Show();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) BelgilanganJavoblar[index] = radioButton1.Text;
            if (radioButton2.Checked) BelgilanganJavoblar[index] = radioButton2.Text;
            if (radioButton3.Checked) BelgilanganJavoblar[index] = radioButton3.Text;
            if (radioButton4.Checked) BelgilanganJavoblar[index] = radioButton4.Text;

            int cnt = 0;
            for (int i = 0; i < TogriJavoblar.Length; i++)
            {
                if (TogriJavoblar[i] == BelgilanganJavoblar[i]) cnt++;
            }

            Form4 obj = new Form4(IsmFamiliya, FanNomi, TestlarSoni, cnt);
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
                if (index + 1 == TogriJavoblar.Length) button2.Enabled = false;

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
                    int cnt = 0;
                    for (int i = 0; i < TogriJavoblar.Length; i++)
                    {
                        if (TogriJavoblar[i] == BelgilanganJavoblar[i]) cnt++;
                    }

                    Form4 obj = new Form4(IsmFamiliya, FanNomi, TestlarSoni, cnt);
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
    }
}