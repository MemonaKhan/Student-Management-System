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
    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Form3()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Student.accdb;
Persist Security Info=False;";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from s_info", con);
            DataSet dt = new DataSet();
            DataTable dtb = new DataTable();
            adap.Fill(dtb);
            dataGridView1.DataSource = dtb;
            //dataGrid1.DataSource = dt;
            
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }

     

       
    }
}
