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
    public partial class Result : Form
    {
        string IsmFamiliya;
        string Fan;
        int TestlarSoni;
        int TJ;

        public Result(string ismFamiliya, string fan, int testlarSoni, int tJ)
        {
            InitializeComponent();
            IsmFamiliya = ismFamiliya;
            Fan = fan;
            TestlarSoni = testlarSoni;
            TJ = tJ;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "Ism Familiya : " + IsmFamiliya;
            label2.Text = "Fan: " + Fan;
            label3.Text = "Jami testlar soni: " + TestlarSoni.ToString();
            label4.Text = "Tog`ri javoblar soni: " + TJ.ToString();
            int foiz = (int)((double)TJ / ((double)TestlarSoni) * 100);
            int baho = 2;

            if (foiz > 59 && foiz < 70) baho = 3;
            if (foiz >= 70 && foiz < 89) baho = 4;
            if (foiz >= 90) baho = 5;

            label5.Text = (foiz.ToString() + "%");
            label6.Text = (baho.ToString() + " baho");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
