using MySql.Data.MySqlClient;
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
        string age, sex;
        bool close=true;
        public StartExam(Form main)
        {
            InitializeComponent();
            formtoopen = main;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            close = false;
            this.Close();
        }



        
        private void StartExamButton_Click(object sender, EventArgs e)
        {
            if (PatientExist()==false)
                return;
            List<string> checkBoxNames = new List<string>();
            if (ProvodimostCheckBox.Checked) checkBoxNames.Add("Проводимость");
            if (VlajnostCheckBox.Checked) checkBoxNames.Add("Влажность");
            if (PulsCheckBox.Checked) checkBoxNames.Add("Пульс");
            if (DavlenieСheckBox.Checked) checkBoxNames.Add("Давление");
            if (TemperaturaCheckBox.Checked) checkBoxNames.Add("Температура");
            
            if (ProvodimostCheckBox.Checked==false && VlajnostCheckBox.Checked==false && 
                PulsCheckBox.Checked==false && DavlenieСheckBox.Checked==false && TemperaturaCheckBox.Checked==false)
            {
                MessageBox.Show("выберите датчики");
                return;
            }

            if (WorkComboBox.Text =="" )
            {
                MessageBox.Show("выберите нагрузку");
                return;
            }

            this.Hide();
            Exam exam = new Exam(this,checkBoxNames);
            
            exam.NameLB=this.NameTextBox.Text;
            exam.AgeLB=age;
            exam.SexLB=sex;
            exam.DateLB=dateTimePicker.Text;
            exam.WorkLB=WorkComboBox.Text;
            if(PulsCheckBox.Checked==true)
                exam.PulsPBShow();
            if (VlajnostCheckBox.Checked==true)
                exam.VlajnostPBShow();
            if (DavlenieСheckBox.Checked==true)
                exam.DavleniePBShow();
            if (TemperaturaCheckBox.Checked==true)
                exam.TemperaturaPBShow();
            if (ProvodimostCheckBox.Checked==true)
                exam.ProvodimostPBShow();
            exam.Show();
            this.NameTextBox.Text = "";
        }

        public bool PatientExist()
        {
            DataBase dataBase = new DataBase();
            dataBase.OpenConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM db.table1 WHERE name=@name", dataBase.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameTextBox.Text;

            adapter.SelectCommand = command;

            DataTable table = new DataTable();

            adapter.Fill(table);

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(3)=="1") { sex="мужской"; }
                else if (reader.GetString(3)=="0") { sex="женский"; }
                age = reader.GetString(2);
            }

            adapter.Dispose();
            dataBase.CloseConnection();
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("такого пациента нет");
                return false;
            }
        }

        private void StartExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close==true) 
                Application.Exit();
            else formtoopen.Show();
        }

        public string nametextbox
        { 
            get { return NameTextBox.Text; } 
            set { NameTextBox.Text =value; } 
        }


    }
}
