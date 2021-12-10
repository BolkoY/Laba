using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace тренажер
{
    public partial class StartExam : Form
    {
        public Form formtoopen;
        public StartExam(Main main)
        {
            InitializeComponent();
            formtoopen = main;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            this.Hide();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void List_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StartExamButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam exam = new Exam(this);
            exam.Show();
            this.NameTextBox.Text = "";
        }
    }
}
