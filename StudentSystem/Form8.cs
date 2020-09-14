using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace StudentSystem
{
    public partial class Form8 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Form8()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Student.accdb;
Persist Security Info=False;";
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string query = "Update s_info set s_password='" + textBox1.Text + "' where s_password='" + textBox3.Text + "'";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Has Been Updated");
                con.Close();
            }
            else
            {
                MessageBox.Show("Not OK");
            }
        }
    }
}
