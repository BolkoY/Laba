using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace тренажер
{
    public partial class Exam : Form
    {
        public Form formtoopen;
        public Random rnd = new Random();
        public List<string> sensors;
        public List<Chart> diagrams;
        private int locationX=30, locationY=300;
        List<int> x = new List<int>();
        List<int> y = new List<int>();
        public Exam(StartExam startExam, List<string> list)
        {
            InitializeComponent();
            formtoopen = startExam;
            sensors=list;
            for (int i = 0; i<sensors.Count; i++) {
                CreateChart(sensors.ElementAt(i));
                locationY+=300;
            }
        }

        private Chart CreateChart(string sensorname)
        {
            Chart chart = new Chart();
            chart.Parent = this;
            chart.Location = new Point(locationX, locationY);
            chart.ChartAreas.Add(new ChartArea("Math functions"));
            chart.Series.Add(new Series("Series1"));
            chart.Titles.Add(sensorname);
            chart.Series["Series1"].ChartType=SeriesChartType.Line;
            for (int i = 0; i <= 10; i++)
            {
                FillSensorValue();
                chart.Series["Series1"].Points.AddXY(x[i], y[i]);
            }
            y.Clear();
            x.Clear();
            return chart;
        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            this.Close();
        }

        public void FillSensorValue()
        {
            for (int i=0;i<=10;i++) 
            {
                x.Add(i);
                y.Add(rnd.Next(0, 100));
            }
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

        public void PulsPBShow()
        {
            PulsPictureBox.Visible=true;
        }
        public void VlajnostPBShow()
        {
            VlajnostPictureBox.Visible=true;
        }
        public void TemperaturaPBShow()
        {
            TemperaturaPictureBox.Visible=true;
        }
        public void ProvodimostPBShow()
        {
            ProvodimostPictureBox.Visible=true;
        }
        public void DavleniePBShow()
        {
            DavleniePictureBox.Visible=true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
