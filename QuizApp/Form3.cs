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

        private static int index;
        private static string[] s;

        private static string[] TogriJavoblar;
        private static string[] BelgilanganJavoblar;

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
            index = 0;

            if (index == 0) button1.Enabled = false;

            StreamReader rd = new StreamReader(@"D:\Visual Studio Project\TestWinForm\TestWinForm\Savollar.txt");

            int i = 0;
            string line;
            while ((line = rd.ReadLine()) != null)
            {
                s[i] = line;
                if (s[i][0] == '*')
                {
                    s[i] = s[i].Substring(1, s[i].Length - 1);
                    TogriJavoblar[(int)(i / 5)] = s[i];

                }
                i++;
            }
            rd.Close();

            label1.Text = "Savol " + (index + 1).ToString();
            listBox1.Items.Clear();

            listBox1.Items.Add(s[5 * index]);
            radioButton1.Text = s[5 * index + 1];
            radioButton2.Text = s[5 * index + 2];
            radioButton3.Text = s[5 * index + 3];
            radioButton4.Text = s[5 * index + 4];
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true) BelgilanganJavoblar[index] = radioButton1.Text;
            if (radioButton2.Checked == true) BelgilanganJavoblar[index] = radioButton2.Text;
            if (radioButton3.Checked == true) BelgilanganJavoblar[index] = radioButton3.Text;
            if (radioButton4.Checked == true) BelgilanganJavoblar[index] = radioButton4.Text;
            int cnt = 0;
            for (int i = 0; i < TogriJavoblar.Length; i++)
            {
                //MessageBox.Show(TogriJavoblar[i] + " " + BelgilanganJavoblar[i]);
                if (TogriJavoblar[i] == BelgilanganJavoblar[i]) cnt++;
            }

            Form4 obj = new Form4(IsmFamiliya, FanNomi, TestlarSoni, cnt);
            obj.Show();
            //MessageBox.Show("Ism Familiya : "+IsmFamiliya + "\nFan: " + FanNomi + "\nJami testlar soni: " + TestlarSoni + "\nTo`g`ri javoblar soni: 2");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) BelgilanganJavoblar[index] = radioButton1.Text;
            if (radioButton2.Checked == true) BelgilanganJavoblar[index] = radioButton2.Text;
            if (radioButton3.Checked == true) BelgilanganJavoblar[index] = radioButton3.Text;
            if (radioButton4.Checked == true) BelgilanganJavoblar[index] = radioButton4.Text;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            listBox1.Items.Clear();
            index++;

            if (index > 0) button1.Enabled = true;
            if (index + 1 == TogriJavoblar.Length) button2.Enabled = false;




            label1.Text = "Savol " + (index + 1).ToString();
            listBox1.Items.Add(s[5 * index]);
            radioButton1.Text = s[5 * index + 1];
            radioButton2.Text = s[5 * index + 2];
            radioButton3.Text = s[5 * index + 3];
            radioButton4.Text = s[5 * index + 4];
            /*
            if (BelgilanganJavoblar[index] != null)
            {

                if (radioButton1.Text == BelgilanganJavoblar[index]) radioButton1.Checked = true;
                if (radioButton2.Text == BelgilanganJavoblar[index]) radioButton2.Checked = true;
                if (radioButton3.Text == BelgilanganJavoblar[index]) radioButton3.Checked = true;
                if (radioButton4.Text == BelgilanganJavoblar[index]) radioButton4.Checked = true;
            }
            */

            //MessageBox.Show(BelgilanganJavoblar[index - 1]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) BelgilanganJavoblar[index] = radioButton1.Text;
            if (radioButton2.Checked == true) BelgilanganJavoblar[index] = radioButton2.Text;
            if (radioButton3.Checked == true) BelgilanganJavoblar[index] = radioButton3.Text;
            if (radioButton4.Checked == true) BelgilanganJavoblar[index] = radioButton4.Text;

            listBox1.Items.Clear();
            index--;
            if (index == 0) button1.Enabled = false;
            if (index + 1 < TogriJavoblar.Length) button2.Enabled = true;

            label1.Text = "Savol " + (index + 1).ToString();
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


