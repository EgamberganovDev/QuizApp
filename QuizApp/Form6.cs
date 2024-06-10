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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MyReader nameReader = new MyReader();
            List<string> names = nameReader.userNames();
            foreach (string name in names)
            {
                listBox1.Items.Add(name);
            }
        }
    }
}
