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
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Form1()
        {
           
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Student.accdb;
Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*try
            {
               
                
                con.Open();
                textBox1.Text = "Connected";
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from s_info where s_username = '"+textBox1.Text+"' and s_password = '"+textBox2.Text+"'";
           
            OleDbDataReader rd = cmd.ExecuteReader();
            int count = 0;
            while (rd.Read())
            {
                count++;
            }
            if(count==1)
            {
                MessageBox.Show("Username and Password is Correct");
                con.Close();
                con.Dispose();
                this.Hide();
                Form3 f3 = new Form3(); 
                f3.ShowDialog();  
            }
            else if(count>1)
            {
                 MessageBox.Show("Username or Password is Duplicate");
            }
            else
            {
                 MessageBox.Show("Username or Password is Incorrect");
            }
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Dispose();
            this.Hide();
            Form2 f2 = new Form2(); //Form2 f2 = new Form2();
            f2.ShowDialog();            //f2.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
        }

     
    }
}
