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
    public partial class Form2 : Form
    {

        OleDbConnection con = new OleDbConnection();
        public Form2()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Student.accdb;
Persist Security Info=False;";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into s_info (s_username, s_password, s_name, s_phone, s_address) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            con.Close();
            con.Dispose();
            
        }

       
    }
}
