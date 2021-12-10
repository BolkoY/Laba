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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            List list = new List(this);
            list.Show();
        }

        private void StartExamButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartExam startExam= new StartExam(this);
            startExam.Show();
        }
    }
}
