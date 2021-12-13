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

        private void ListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void List_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.OpenConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM db.table1", db.GetConnection());

            adapter.SelectCommand = command;

            string a;

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                a = reader.GetString(0) + " ";
                a += reader.GetString(1) + " ";
                a += reader.GetString(2);
                ListBox.Items.Add(a);
            }
            command.Dispose();
            reader.Close();

            db.CloseConnection();
        }

        private void List_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            this.Hide();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
