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
    public partial class Form4 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Form4()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Student.accdb;
 Persist Security Info=False;";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from s_info";
            OleDbDataReader rd= cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd[0].ToString());
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into s_info (s_id, s_name, s_phone, s_address) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Added");
            con.Close();
            con.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            string query="Update s_info set s_name='"+textBox2.Text+"', s_phone='"+textBox3.Text+"', s_address='"+textBox4.Text+"' where s_id="+textBox1.Text+"";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Updated");
            con.Close();
            con.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from s_info where s_id="+ comboBox1.SelectedItem.ToString() + " "; //+textBox1.Text+""
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Deleted");
            con.Close();
            con.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from s_info where s_id=" + comboBox1.SelectedItem.ToString();//.Text+"";
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd["s_id"].ToString();
                textBox2.Text = rd["s_name"].ToString();
                textBox3.Text = rd["s_phone"].ToString();
                textBox4.Text = rd["s_address"].ToString();
            }

            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
