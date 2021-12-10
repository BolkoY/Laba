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

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM db.table1",db.GetConnection());

            adapter.SelectCommand = command;

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataColumn column in dt.Columns)
                    ListBox.Items.Add(column.ColumnName);
                
                // перебор всех строк таблицы
                foreach (DataRow row in dt.Rows)
                {
                    string[] a = (string[])row.ItemArray;
                    // получаем все ячейки строки
                    ListBox.Items.Add(a);
                    //foreach (object cell in cells)
                    //    ListBox.Items.Add(cell);
                }
            }
            //string[] countries = 

           // string[] countries = { "Бразилия", "Аргентина", "Чили", "Уругвай", "Колумбия" };
            //ListBox.Items.AddRange(countries);
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
