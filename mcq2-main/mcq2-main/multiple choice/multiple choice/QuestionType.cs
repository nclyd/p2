using System;
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
    public partial class QuestionType : Form
    {
        public QuestionType()
        {
            InitializeComponent();
            cBoxDiff.SelectedItem = Quiz.CurrentDifficulty;
            cBoxQType.SelectedItem = Quiz.CurrentTopic;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Form1 q = new Form1();
            
            this.Hide();
            q.Show();
            

        }
    }
}
