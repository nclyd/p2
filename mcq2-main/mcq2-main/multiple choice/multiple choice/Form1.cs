﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiple_choice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }



        private void loadQuestion()
        {
            List<MultipleChoice> quesions = Quiz.GetMCQs();
              
        }

        private void btnAnsSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
