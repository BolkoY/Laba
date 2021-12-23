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
    public partial class List : Form
    {
        bool close = true;
        public Form formtoopen;
        public List(Main main)
        {
            InitializeComponent();
            formtoopen = main;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add add = new Add(this);
            add.Show();
        }

        private void List_Load(object sender, EventArgs e)
        {
            DataBaseUpdate();
        }

        private void List_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close==true)
                Application.Exit();
            else formtoopen.Show();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            close = false;
            this.Close();
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DataBaseUpdate();
        }

        private void DataBaseUpdate()
        {
            ListBox.Items.Clear();
            DataBase db = new DataBase();
            db.OpenConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM db.table1", db.GetConnection());

            adapter.SelectCommand = command;



            MySqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string a = "";
                for (int i = 1; i<3; i++)
                {
                    a+=reader.GetString(i)+" ";
                }
                if (reader.GetString(3)=="1")
                    a+="мужщина";
                else if (reader.GetString(3)=="0")
                    a+="женщина";
                ListBox.Items.Add(a);
            }
            
            adapter.Dispose();
            command.Dispose();
            reader.Close();

            db.CloseConnection();
        }
    }
}
