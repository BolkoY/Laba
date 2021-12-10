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
    public partial class Exam : Form
    {
        public Form formtoopen;
        public Exam(StartExam startExam)
        {
            InitializeComponent();
            formtoopen = startExam;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            this.Close();
        }

        private void TypWorkloadLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Exam_FormClosed(object sender, FormClosedEventArgs e)
        {
            formtoopen.Show();
        }
    }
}
