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

        }
    }
}
