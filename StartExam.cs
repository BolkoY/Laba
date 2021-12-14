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

        private void List_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        private void StartExamButton_Click(object sender, EventArgs e)
        {
            if (PatientExist()==false)
                return;

            if(ProvodimostCheckBox.Checked==false && VlajnostCheckBox.Checked==false && 
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
            Exam exam = new Exam(this);
            
            exam.NameLB=this.NameTextBox.Text;
            exam.AgeLB=age;
            exam.SexLB=sex;
            exam.DateLB=dateTimePicker.Text;
            exam.WorkLB=WorkComboBox.Text;

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
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
