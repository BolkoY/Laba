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

        private void Exam_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        public string NameLB
        {
            get { return NameListBox.Text; }
            set { NameListBox.Items.Add ( value); }
        }

        public string DateLB
        {
            get { return DateListBox.Text; }
            set { DateListBox.Items.Add(value); }
        }

        public string AgeLB
        {
            get { return AgeListBox.Text; }
            set { AgeListBox.Items.Add(value); }
        }

        public string SexLB
        {
            get { return SexListBox.Text; }
            set { SexListBox.Items.Add(value); }
        }

        public string WorkLB
        {
            get { return WorkListBox.Text; }
            set { WorkListBox.Items.Add(value); }
        }
    }
}
