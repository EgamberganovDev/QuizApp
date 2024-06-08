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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"Testlar");
            foreach (var fi in di.GetFiles())
            {
                if (fi.Name.EndsWith(".txt"))
                comboBox1.Items.Add(fi.Name.Substring(0, fi.Name.Length -4));
            }

            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
            else if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
            else if (checkBox3.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox4.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
        }
    }
}
