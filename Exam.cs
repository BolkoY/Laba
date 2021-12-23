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
        private Form formtoopen;
        private List<string> sensors;
        private int locationX=30, locationY=300;
        List<int> x = new List<int>();
        List<int> y = new List<int>();
        public Exam(StartExam startExam, List<string> list)
        {
            InitializeComponent();
            formtoopen = startExam;
            sensors=list;
            for (int i = 0; i<sensors.Count; i++)
            {
                _=CreateChartAsync(sensors.ElementAt(i));
                locationY+=300;
            }
        }

        private async Task CreateChartAsync(string sens)
        {
            string sensorname = sens.ToString();
            List<double> values = new List<double>();
            values=FillSensorValues(sensorname);
            Chart chart = new Chart();
            chart.Parent = this;
            chart.Location = new Point(locationX, locationY);
            chart.Width=500;
            chart.ChartAreas.Add(new ChartArea("Math functions"));
            Axis ax = new Axis();
            ax.Title = "время, с";
            chart.ChartAreas[0].AxisX = ax;
            Axis ay = new Axis();
            if (sensorname=="Проводимость")
            {
                ay.Title = sensorname+", (10^-4)/(Om*cm)";
                ay.Minimum = 1;
            }
            else if (sensorname=="Пульс")
            {
                ay.Title = sensorname+", уд/мин";
                ay.Minimum = 30;
            }
            else if (sensorname=="Давление")
            {
                ay.Title = sensorname+", мм рт. ст.";
                ay.Minimum = 0;
            }
            if (sensorname=="Температура")
            {
                ay.Title = sensorname+", °C";
                ay.Minimum = 34;
            }
            else if (sensorname=="Влажность")
            {
                ay.Title = sensorname+", %";
                ay.Minimum = 7;
            }
            chart.ChartAreas[0].AxisY = ay;
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.Series.Add(new Series("Series1"));
            chart.Titles.Add(sensorname);
            chart.Series["Series1"].ChartType=SeriesChartType.Line;
            for (int i = 0; i <= values.Count; i++)
            {
                chart.Series["Series1"].Points.AddXY(i, values[i]);
                await Task.Delay(1000);
            }
            y.Clear();
            x.Clear();
            //return chart;
        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<double> FillSensorValues(string sensorname)
        {
            Random rnd = new Random();
            int a;
            List<double> values = new List<double>();
            if (sensorname == null) { return null; }
            if (sensorname=="Проводимость")
            {
                a=rnd.Next(2, 4);
                for (int i = 0; i<=10; i++)
                {
                    values.Add(a+(rnd.NextDouble()-rnd.NextDouble())/2);
                }
                return values;
            }
            else if (sensorname=="Пульс")
            {
                a=rnd.Next(40, 200);
                for (int i = 0; i<=10; i++)
                {
                    values.Add(a+rnd.Next(-10, 10));
                }
                return values;
            }
            else if (sensorname=="Давление")
            {
                a=rnd.Next(60, 200);
                for (int i = 0; i<=10; i++)
                {
                    
                    values.Add(a+rnd.Next(-10, 10));
                }
                return values;
            }
            else if (sensorname=="Температура")
            {
                a=rnd.Next(35, 40);
                for (int i = 0; i<=10; i++)
                {
                    values.Add(a+rnd.NextDouble()-rnd.NextDouble());
                }
                return values;
            }
            else if (sensorname=="Влажность")
            {
                a=rnd.Next(8, 20);
                for (int i = 0; i<=10; i++)
                {
                    values.Add(a+rnd.NextDouble()-rnd.NextDouble());
                }
                return values;
            }
            else { return null; }
        }
        

        private void Exam_FormClosed(object sender, FormClosedEventArgs e)
        {
            formtoopen.Show();
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

    }
}
