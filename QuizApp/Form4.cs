﻿using System;
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
    public partial class Form4 : Form
    {
        string IsmFamiliya;
        string Fan;
        int TestlarSoni;
        int TJ;

        public Form4(string ismFamiliya, string fan, int testlarSoni, int tJ)
        {
            InitializeComponent();
            IsmFamiliya = ismFamiliya;
            Fan = fan;
            TestlarSoni = testlarSoni;
            TJ = tJ;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
