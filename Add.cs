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
    public partial class Add : Form
    {
        public Form formtoopen;
        public Add(List list)
        {
            InitializeComponent();
            formtoopen=list;
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            formtoopen.Show();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.OpenConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `db`.`table1` (`name`, `age`, `sex`) VALUES (@name, @age, @sex);", dataBase.GetConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameTextBox.Text;
            command.Parameters.Add("@age", MySqlDbType.Int32).Value = AgeComboBox.Text;
            if (radioButton1.Checked)
            {
                command.Parameters.Add("@sex", MySqlDbType.Int32).Value = 1;
            }
            else if (radioButton2.Checked)
            {
                command.Parameters.Add("@sex", MySqlDbType.Int32).Value = 0;
            }

            if (command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("obosralsya");
            }

            dataBase.CloseConnection();
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
